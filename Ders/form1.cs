using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Form_Denemesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int i,sayi, fak = 1;
            sayi = Convert.ToInt32(Interaction.InputBox("Faktöriyeli alınacak sayıyı girin"));
            for (i = 1; i <= sayi; i++)
            {
                fak = fak * i;
            }
            MessageBox.Show(sayi + " Sayinin faktöriyeli: " + fak);
        }
    }
}
