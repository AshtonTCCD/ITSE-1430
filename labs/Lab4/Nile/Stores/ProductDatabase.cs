/*
 * ITSE 1430
 */

using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <inheritdoc />
        public Product Add ( Product product )
        {
            if (product == null) throw new NullReferenceException("Provided product is null.");
            if (product.Id < 0) throw new ArgumentOutOfRangeException("Product Id is out of range. Id must be greater than or equal to 0.");
            if (product.Price < 0) throw new ArgumentOutOfRangeException("Product price is out of range. Price must be greater than or equal to 0.");

            var validation = product.Validate(new ValidationContext(this));
            var v = validation.FirstOrDefault();
            if (v != null) throw new ValidationException(v.ErrorMessage);

            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <inheritdoc />
        public Product Get ( int id )
        {
            if (id < 0) throw new ArgumentOutOfRangeException("Id is out of range. Id must be greater than or equal to 0.");

            return GetCore(id);
        }

        /// <inheritdoc />
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }

        /// <inheritdoc />
        public void Remove ( int id )
        {
            if (id < 0) throw new ArgumentOutOfRangeException("Id is out of range. Id must be greater than or equal to 0.");

            RemoveCore(id);
        }

        /// <inheritdoc />
        public Product Update ( Product product )
        {
            if (product == null) throw new NullReferenceException("Provided product is null.");
            if (product.Id < 0) throw new ArgumentOutOfRangeException("Product Id is out of range. Id must be greater than or equal to 0.");
            if (product.Price < 0) throw new ArgumentOutOfRangeException("Product price is out of range. Price must be greater than or equal to 0.");

            var validation = product.Validate(new ValidationContext(this));
            var v = validation.FirstOrDefault();
            if (v != null) throw new ValidationException(v.ErrorMessage);

            //Get existing product
            var existing = GetCore(product.Id);
            if (existing == null) throw new IndexOutOfRangeException("Cannot update a non-existing product.");

            //Check for duplicate names
            if (GetAllCore().Any(p => p.Name == product.Name && p.Id != product.Id))
                throw new DuplicateNameException("Cannot change a product's name to an already-existing product's name.");

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );
        #endregion
    }
}
