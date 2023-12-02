/*
 * ITSE 1430
 */

using Nile.Stores.Sql;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            var connString = Program.GetConnectionString("ProductDatabase");
            UpdateList();
        }

        #region Event Handlers

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd ( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            try
            {
                _database.Add(child.Product);
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to add product to database: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void OnProductEdit ( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }

        private void OnProductDelete ( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }

        private void OnEditRow ( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid ( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);

            //Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            //Delete product
            try
            {
                _database.Remove(product.Id);
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to remove product from database: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            try
            {
                _database.Update(child.Product);
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to update product on database: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            try
            {
                var data = _database.GetAll();
                var ordered = data.OrderBy(x => x.Name);
                _bsProducts.DataSource = ordered;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to retrieve products from database: {ex.Message}", "Error",
                    MessageBoxButtons.OK);
            }
        }

        private readonly IProductDatabase _database = new SqlProductDatabase(Program.GetConnectionString("ProductDatabase"));
        #endregion

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e ) => new AboutForm().ShowDialog();
    }
}
