using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            ReadQuotesFile();
        }

        private void ReadQuotesFile()
        {
            
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
        }
    }
}
