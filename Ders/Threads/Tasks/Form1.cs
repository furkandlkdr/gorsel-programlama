using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Tasks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_Basla_Click(object sender, EventArgs e) {
            CheckForIllegalCrossThreadCalls = false;
            Task task1 = Task.Factory.StartNew(() => {
                for (int i = 0; i < 30; i++) {
                    Thread.Sleep(500);
                    label1.Text = i.ToString();
                }
            });
            Task task2 = Task.Factory.StartNew(() => {
                for (int i = 0; i < 30; i++) {
                    Thread.Sleep(500);
                    label2.Text = i.ToString();
                }
            });
        }
    }
}
