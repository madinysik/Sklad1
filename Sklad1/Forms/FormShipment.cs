using Sklad1.Data;
using Sklad1.Helpers;
using Sklad1.Properties;

namespace Sklad1.Forms
{
    public partial class FormShipment : Form
    {
        private List<ShipmentItemTemp> _items = new List<ShipmentItemTemp>();

        public FormShipment()
        {
            InitializeComponent();

            LoadProducts();

            btnAdd.Click += BtnAdd_Click;
            btnShip.Click += BtnShip_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadProducts()
        {
            using (var bd = new Context())
            {
                var products = bd.Products.Where(p => p.Quantity > 0).Select(p => new ProductItem
                {
                    Article = p.Article,
                    Name = p.Name,
                    Quantity = p.Quantity,
                    PurchasePrice = p.PurchasePrice
                })
                    .ToList();

                cmbProduct.DisplayMember = nameof(ProductItem.Name);
                cmbProduct.ValueMember = nameof(ProductItem.Article);
                cmbProduct.DataSource = products;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateSelection())
                return;

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show(Resources.InvalidQuantity);
                return;
            }

            var selected = (ProductItem)cmbProduct.SelectedItem;

            if (quantity > selected.Quantity)
            {
                MessageBox.Show(Resources.InsufficientStock);
                return;
            }

            AddOrUpdateItem(selected, quantity);
            UpdateGrid();
            txtQuantity.Clear();
        }

        private bool ValidateSelection()
        {
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show(Resources.SelectProduct);
                return false;
            }
            return true;
        }

        private void AddOrUpdateItem(ProductItem selected, int quantity)
        {
            var existing = _items.FirstOrDefault(i => i.Article == selected.Article);

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _items.Add(new ShipmentItemTemp
                {
                    Article = selected.Article,
                    Name = selected.Name,
                    Quantity = quantity,
                    Price = selected.PurchasePrice
                });
            }
        }

        private void UpdateGrid()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = _items;

            dgvItems.Columns[nameof(ShipmentItemTemp.Article)].HeaderText = Resources.Article;
            dgvItems.Columns[nameof(ShipmentItemTemp.Name)].HeaderText = Resources.Name;
            dgvItems.Columns[nameof(ShipmentItemTemp.Quantity)].HeaderText = Resources.Quantity;
            dgvItems.Columns[nameof(ShipmentItemTemp.Price)].HeaderText = Resources.Price;

            btnShip.Enabled = _items.Count > 0;
        }

        private void BtnShip_Click(object sender, EventArgs e)
        {
            if (!ValidateClient())
                return;

            if (!ValidateItems())
                return;

            var itemsForShipment = _items.Select(i => (i.Article, i.Quantity)).ToList();
            bool success = ShipmentService.ProcessShipment(txtClient.Text.Trim(), itemsForShipment);

            if (success)
            {
                MessageBox.Show(Resources.ShipmentSuccess);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Resources.ShipmentError);
            }
        }

        private bool ValidateClient()
        {
            if (string.IsNullOrWhiteSpace(txtClient.Text))
            {
                MessageBox.Show(Resources.ShipmentNoClient);
                txtClient.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateItems()
        {
            if (_items.Count == 0)
            {
                MessageBox.Show(Resources.ShipmentNoItems);
                return false;
            }
            return true;
        }

        private void FormShipment_Load(object sender, EventArgs e)
        {

        }
    }
}
