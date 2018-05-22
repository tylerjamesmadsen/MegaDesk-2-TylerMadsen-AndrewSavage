using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.DesktopSurfaceMaterial>();
            materials = Enum.GetValues(typeof(Desk.DesktopSurfaceMaterial))
                            .Cast<Desk.DesktopSurfaceMaterial>()
                            .ToList();

            surfaceMaterialSelectionComboBox.DataSource = materials;
            shippingSelectionComboBox.DataSource = DeskQuote.ShippingSpeeds;
        }

        private void CancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {

                Desk desk = new Desk
                {
                    Width = (int)widthNumericUpDown.Value,
                    Depth = (int)depthNumericUpDown.Value,
                    NumberOfDrawers = (int)numberOfDrawersNumericUpDown.Value,
                    SurfaceMaterial = (Desk.DesktopSurfaceMaterial)surfaceMaterialSelectionComboBox.SelectedItem
                };

                DeskQuote deskQuote = new DeskQuote
                {
                    Desk = desk,
                    CustomerName = customerNameTextBox.Text,
                    ShippingSpeed = GetRushShippingChoice(),
                    QuoteDate = DateTime.Now
                };

                totalPriceAmountLabel.Text = $@"${deskQuote.CalculateQuote()}";
                shippingPriceLabel.Text = $@"${deskQuote.GetShippingPrice()}";

                string quotesFile = @"quotes.txt";
                if (!File.Exists(quotesFile))
                {
                    using (StreamWriter writer = File.CreateText(quotesFile))
                    {
                        writer.WriteLine(
                            $"{deskQuote.QuoteDate}," +
                            $"{deskQuote.CustomerName}," +
                            $"{deskQuote.Desk.Width}," +
                            $"{deskQuote.Desk.Depth}," +
                            $"{deskQuote.Desk.NumberOfDrawers}," +
                            $"{deskQuote.Desk.SurfaceMaterial}," +
                            $"{deskQuote.ShippingSpeed}," +
                            $"{deskQuote.GetShippingPrice()}," +
                            $"{deskQuote.CalculateQuote()}");
                        writer.Close();
                    }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(quotesFile))
                    {
                        writer.WriteLine(
                            $"{deskQuote.QuoteDate}," +
                            $"{deskQuote.CustomerName}," +
                            $"{deskQuote.Desk.Width}," +
                            $"{deskQuote.Desk.Depth}," +
                            $"{deskQuote.Desk.NumberOfDrawers}," +
                            $"{deskQuote.Desk.SurfaceMaterial}," +
                            $"{deskQuote.ShippingSpeed}," +
                            $"{deskQuote.GetShippingPrice()}," +
                            $"{deskQuote.CalculateQuote()}");
                        writer.Close();
                    }
                }

                DisplayQuote();

        }

        private DeskQuote.RushShippingChoice GetRushShippingChoice()
        {
            if (shippingSelectionComboBox.Text == DeskQuote.ShippingSpeeds[0])
            {
                return DeskQuote.RushShippingChoice.Rush3Days;
            }
            if (shippingSelectionComboBox.Text == DeskQuote.ShippingSpeeds[1])
            {
                return DeskQuote.RushShippingChoice.Rush5Days;
            }
            if (shippingSelectionComboBox.Text == DeskQuote.ShippingSpeeds[2])
            {
                return DeskQuote.RushShippingChoice.Rush7Days;
            }

            return DeskQuote.RushShippingChoice.Standard14Days;
        }

        private void DisplayQuote()
        {
            // disable input fields
            customerNameTextBox.Enabled = false;
            widthNumericUpDown.Enabled = false;
            depthNumericUpDown.Enabled = false;
            numberOfDrawersNumericUpDown.Enabled = false;
            surfaceMaterialSelectionComboBox.Enabled = false;
            shippingSelectionComboBox.Enabled = false;

            // display shipping price
            shippingPriceTextLabel.Visible = true;
            shippingPriceLabel.Visible = true;

            // display total price
            totalPriceLabel.Visible = true;
            totalPriceAmountLabel.Visible = true;

            // hide get quote button
            getQuoteButton.Visible = false;

            // change text of cancel button to "Main Menu"
            cancelQuoteButton.Text = @"Main Menu";
        }
    }
}
