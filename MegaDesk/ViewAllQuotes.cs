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
            LoadQuotesGrid();
        }

        private void LoadQuotesGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                viewAllQuotesDataGridView.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Name = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    NumDrawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.SurfaceMaterial,
                    ShippingSpeed = d.ShippingSpeed,
                    TotalPrice = d.QuotePrice
                })
                .ToList();
            }
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
                    Name = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    NumDrawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.SurfaceMaterial,
                    ShippingSpeed = d.ShippingSpeed,
                    TotalPrice = d.QuotePrice
                })
                .Where(d => d.SurfaceMaterial == desktopSurfaceMaterial)
                .ToList();
            }
        }

        private void surfaceMaterialSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string selectedItem = combo.SelectedItem.ToString();
            if (Enum.IsDefined(typeof(Desk.DesktopSurfaceMaterial), selectedItem))
            {
                Desk.DesktopSurfaceMaterial selection =
                    (Desk.DesktopSurfaceMaterial)Enum
                    .Parse(typeof(Desk.DesktopSurfaceMaterial)
                    , selectedItem);
                LoadQuotesGrid(selection);
            }
            else
            {
                LoadQuotesGrid();
            }
        }

        private void exitViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
