using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            
        }

        private void LoadQuotesGrid(Desk.DesktopSurfaceMaterial desktopSurfaceMaterial)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                viewAllQuotesDataGridView.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.SurfaceMaterial,
                    ShippingSpeed = d.ShippingSpeed,
                    QuotePrice = d.QuotePrice
                })
                .Where(d => d.SurfaceMaterial == desktopSurfaceMaterial)
                .ToList();
            }
        }

        private void exitViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void surfaceMaterialSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAllQuotesDataGridView.Rows.Clear();
            ComboBox combo = (ComboBox)sender;
            string selectedItem = combo.SelectedItem.ToString();
            Desk.DesktopSurfaceMaterial selectedMaterial = (Desk.DesktopSurfaceMaterial)Enum.Parse(typeof(Desk.DesktopSurfaceMaterial), selectedItem);
            LoadQuotesGrid(selectedMaterial);
        }
    }
}
