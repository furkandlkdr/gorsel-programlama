using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamePage game = new gamePage();
            game.Show();
            this.Hide();
            game.FormClosed += (s, args) => Application.Exit();
        }
    }
}
