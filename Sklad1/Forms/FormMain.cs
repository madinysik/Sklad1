using Serilog;
using Sklad1.Data;
using Sklad1.Helpers;
using Sklad1.Properties;

namespace Sklad1.Forms
{
    /// <summary>
    /// Главная форма приложения, отображает список товаров
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Свойство для сохранения роли пользователя 
        /// </summary>
        public static UserRole UserRole { get; set; }

        public FormMain()
        {
            InitializeComponent();
            var displayRole = UserRole == UserRole.Admin ? Resources.Admin : Resources.Storekeeper;
            this.Text = string.Format(Resources.Title, displayRole);
            LoadProducts();
            btnCreate.Click += btnCreate_Click;
            btnEdit.Click += btnEdit_Click;

            if (!IsAdmin())
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;

                menuProduct.Visible = false;
                menuCategory.Visible = false;

                menuEditProduct.Visible = false;
                menuEditCategory.Visible = false;

                btnHistory.Visible = false;
            }
        }

        private bool IsAdmin()
        {
            return UserRole == UserRole.Admin;
        }

        private void LoadProducts()
        {
            try
            {
                using (var bd = new Context())
                {
                    var products = bd.Products.ToList();
                    var categories = bd.Categories.ToDictionary(c => c.Id, c => c.Name);

                    var data = products.Select(p => new
                    {
                        p.Article,
                        p.Name,
                        Category = categories.ContainsKey(p.CategoryId) ? categories[p.CategoryId] : string.Empty,
                        p.Quantity,
                        p.PurchasePrice,
                        Stock = p.Quantity
                    }).ToList();

                    dgvProducts.DataSource = data;

                    dgvProducts.Columns["Article"].HeaderText = Resources.Article;
                    dgvProducts.Columns["Name"].HeaderText = Resources.Name;
                    dgvProducts.Columns["Category"].HeaderText = Resources.Category;
                    dgvProducts.Columns["Quantity"].HeaderText = Resources.Quantity;
                    dgvProducts.Columns["PurchasePrice"].HeaderText = Resources.PurchasePrice;
                    dgvProducts.Columns["Stock"].HeaderText = Resources.Stock;


                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ошибка загрузки товаров");
                MessageBox.Show(Resources.ProductLoadError);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMenu.Show(btnCreate, 0, btnCreate.Height);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMenu.Show(btnEdit, 0, btnEdit.Height);
        }

        // меню создать 
        private void menuCategory_Click(object sender, EventArgs e)
        {
            var form = new FormCategory();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            var form = new FormProduct();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }
        private void menuShipment_Click(object sender, EventArgs e)
        {

        }

        // меню редактировать
        private void menuEditProduct_Click(object sender, EventArgs e)
        {

        }
        private void menuEditCategory_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvProducts.SelectedRows[0];
            var categoryName = selectedRow.Cells["Category"].Value.ToString();

            using (var bd = new Context())
            {
                var category = bd.Categories.FirstOrDefault(c => c.Name == categoryName);

                if (category == null)
                {
                    MessageBox.Show(Resources.CategoryNotFound);
                    return;
                }

                var form = new FormEditCategory(category);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }

            }
        }
    }
}
