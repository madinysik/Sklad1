using Sklad1.Data;
using Serilog;
using System;
using System.Linq;
using System.Windows.Forms;
using Sklad1.Properties;

namespace Sklad1.Forms
{
    public partial class FormShipmentHistory : Form
    {
        public FormShipmentHistory()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                using (var bd = new Context())
                {
                    var history = bd.ShipmentItems
                        .OrderByDescending(si => si.Shipment.Date)
                        .Select(si => new
                        {
                            si.Shipment.Date,
                            si.Shipment.Client,
                            ProductName = si.Product.Name,
                            si.Quantity,
                            si.PriceAtShipment,
                            CurrentStock = si.Product.Quantity
                        })
                        .ToList();

                    dataGridView1.DataSource = history;

                    dataGridView1.Columns["Client"].HeaderText = Resources.Client;
                    dataGridView1.Columns["ProductName"].HeaderText = Resources.ProductName;
                    dataGridView1.Columns["Quantity"].HeaderText = Resources.Quantity;
                    dataGridView1.Columns["PriceAtShipment"].HeaderText = Resources.Price;
                    dataGridView1.Columns["CurrentStock"].HeaderText = Resources.CurrentStock;
                    dataGridView1.Columns["Date"].HeaderText = Resources.Date;

                    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, Resources.ErrorLoadHistory);
                MessageBox.Show(Resources.ErrorLoadHistory);
            }
        }
    }
}