namespace Odev4
{
    public partial class PasswordRandomizer : Form
    {
        int[][] positions = new int[10][];
        string password = "1 2 3 4";
        public PasswordRandomizer()
        {
            InitializeComponent();
        }

        private void PasswordRandomizer_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control control in Controls)
            {
                if (control is Button b)
                {
                    positions[i] = new int[2];
                    positions[i][0] = b.Location.X;
                    positions[i][1] = b.Location.Y;
                    i++;
                }
            }
        }

        private void number_click(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Left){
                for (int i = 0; i < 10; i++) {
                    int randomIndex = new Random().Next(0, 10);
                    Button button1 = (Button)Controls.Find("button" + randomIndex, true)[0];
                    Button button2 = (Button)Controls.Find("button" + i, true)[0];

                    button1.Location = new Point(positions[i][0], positions[i][1]);
                    button2.Location = new Point(positions[randomIndex][0], positions[randomIndex][1]);
                    positions[randomIndex] = [button1.Location.X, button1.Location.Y];
                    positions[i] = [button2.Location.X, button2.Location.Y];
                }

                Button b = (Button)sender;
                int foundedIndex = passwordLabel.Text.IndexOf('_');
                if (foundedIndex != -1)
                    passwordLabel.Text = passwordLabel.Text.Remove(foundedIndex, 1).Insert(foundedIndex, b.Text);
                if (passwordLabel.Text.IndexOf('_') == -1){
                    if (passwordLabel.Text == password){
                        MessageBox.Show("Giriş başarılı!");
                        Environment.Exit(0);
                    } else{
                        MessageBox.Show("Şifre hatalı, tekrar deneyin!");
                    }
                    passwordLabel.Text = "_ _ _ _";
                }
            }
        }
    }
}
