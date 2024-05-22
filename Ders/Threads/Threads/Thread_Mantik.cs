using System;
using System.Threading;
using System.Windows.Forms;

namespace Threads
{
    public partial class Thread_Mantik : Form
    {
        public Thread_Mantik()
        {
            InitializeComponent();
        }
        private void Dongu()
        {
            decimal i = default(decimal);
            for (i= 0; i <= 1000000000; i++)
            {
            }
            MessageBox.Show("Döngü Bitti");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dongu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Başka bir kanal üzerinde bu işlemi gerçekleştirdiği için diğer işlemleri
            // engellemez. Mesaj yazdırabiliriz.
            Thread kanal1 = new Thread(Dongu);
            kanal1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }
    }
}
