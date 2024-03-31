namespace Odev4_1{
    public partial class MemoryTestForm : Form{
        readonly string[] Colors = new string[5] { "Red", "Blue", "Green", "Yellow", "Purple" };
        int[] cards = new int[20] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19 };
        bool isGameRunning = false;
        int currentButton = 0;
        int _score = 0;
        int level = 2;

        public MemoryTestForm(){    InitializeComponent();    }
        public static void Shuffle<T>(T[] array){ // Fisher-Yates Shuffle
            Random _random = new Random();
            int n = array.Length;
            for (int i = 0; i < (n - 1); i++){
                int r = i + _random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;    }
        }
        private void MemoryTestForm_Load(object sender, EventArgs e){    
            Shuffle(cards);        
        }
        private void timer1_Tick(object sender, EventArgs e){
            timer1.Interval = 2000 / ((level / 3) + 1);
            foreach (Control c in BtnGroup.Controls) {
                if (c is Button)    
                    c.BackColor = Color.FromName("ControlLightLight");
            }
            if (level == 20){
                MessageBox.Show("Tebrikler! Oyunu tamamladınız. Skorunuz: " + _score);
                Environment.Exit(0);
            }
            if ((currentButton + 1) % level == 0){
                currentButton = 0;
                timer1.Stop();
                startBtn.Text = "Seç";
            }else{
                Button b = (Button)this.Controls.Find("button" + cards[currentButton], true)[0];
                b.BackColor = Color.FromName(Colors[currentButton % Colors.Length]);
                currentButton++;
            }
        }

        private void Color_Button_Click(object sender, MouseEventArgs e){
            Button b = (Button)sender;
            int buttonIndex = Convert.ToInt32(b.Name.Split("n")[1]);

            if (buttonIndex == cards[currentButton]){
                b.BackColor = Color.FromName(Colors[currentButton % Colors.Length]);
                _score++;
                scoreValue.Text = _score.ToString();
                currentButton++;
            } else{
                MessageBox.Show("Yanlış renk seçtiniz. Oyun bitti. Skorunuz: " + _score);
                Environment.Exit(0);    }
            if ((currentButton + 1) % level == 0){
                level++;
                currentButton = 0;
                startBtn.Text = "Durdur";
                timer1.Start();    }
        }
        private void startBtn_Click(object sender, EventArgs e){
            if (isGameRunning){
                timer1.Stop();
                startBtn.Text = "Devam et";    }
            else{
                timer1.Start();
                startBtn.Text = "Durdur";    }
            isGameRunning = !isGameRunning;
        }
    }
}
