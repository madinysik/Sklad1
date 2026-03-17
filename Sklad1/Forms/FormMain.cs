using Sklad1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad1.Forms
{
    public partial class FormMain : Form
    {
        public static string UserRole { get; set; }
        public FormMain()
        {
            InitializeComponent();
            this.Text = $"Складской учёт - {UserRole}";
            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                using (var bd = new Context())
                {
                    var products = bd.products.ToList();
                    var categories = new Dictionary<int, string>();
                    foreach (var c in bd.categories)
                    {
                        categories.Add(c.id, c.name);
                    }

                    var data = new List<dynamic>();

                    foreach (var p in products)
                    {
                        var catName = categories.ContainsKey(p.category_id) ? categories[p.category_id] : string.Empty;

                        data.Add(new
                        {
                            Article = p.article,
                            Name = p.name,
                            Category = catName,
                            Quantity = p.quantity,
                            PurchasePrice = p.purchase_price,
                            Stock = p.quantity
                        });
                    }

                    dgvProducts.DataSource = data;

                    dgvProducts.Columns["Article"].HeaderText = "Артикул";
                    dgvProducts.Columns["Name"].HeaderText = "Название";
                    dgvProducts.Columns["Category"].HeaderText = "Категория";
                    dgvProducts.Columns["Quantity"].HeaderText = "Количество";
                    dgvProducts.Columns["PurchasePrice"].HeaderText = "Цена закупки";
                    dgvProducts.Columns["Stock"].HeaderText = "Текущий остаток";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки товаров: " + ex.Message);
            }
        }
    }
}
