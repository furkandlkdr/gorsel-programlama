using System;
using System.Windows.Forms;

namespace Odev1_2
{
    public partial class appForm : Form
    {
        public string[] colors = { "Red", "Green", "Blue", "Yellow", "Black", "White", "Purple", "Orange", "Pink", "Brown" };
        string choosenColor = "White";
        public appForm()
        {
            InitializeComponent();
            colorCombo.DataSource = colors;
        }

        private void colorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                choosenColor = colorCombo.SelectedItem.ToString();
                this.BackColor = System.Drawing.Color.FromName(choosenColor);
            }
            catch { }
        }
    }
}
