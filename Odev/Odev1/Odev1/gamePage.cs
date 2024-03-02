using System;
using System.Windows.Forms;

namespace Odev1
{
    public partial class gamePage : Form
    {
        int searchingNumber;
        int maxGuess = 5;
        int guessCount = 0;
        int numberMax = 200;
        int numberMin = 0;
        public gamePage()
        {
            InitializeComponent();
            Random rnd = new Random();
            searchingNumber = rnd.Next(0, 200);
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userGuess = int.Parse(userInput.Text);

                if (userGuess < numberMin || userGuess > numberMax)
                {
                    MessageBox.Show("Lütfen aralık içerisinde bir sayı girin.");
                    return;
                }

                if (userGuess == searchingNumber)
                {
                    MessageBox.Show("Tebrikler! Doğru tahmin ettiniz!");
                    Environment.Exit(0);
                }
                else if (userGuess > searchingNumber)
                {
                    MessageBox.Show("Tahmininiz büyük. Daha küçük bir sayı deneyin.");
                    updateGap(2, userGuess.ToString());

                }
                else
                {
                    MessageBox.Show("Tahmininiz küçük. Daha büyük bir sayı deneyin.");
                    updateGap(1, userGuess.ToString());
                }
                userInput.Text = "";

                guessCount++;
                remainingLabel.Text = (maxGuess - guessCount).ToString();
                if (guessCount == maxGuess)
                {
                    MessageBox.Show("Tahmin hakkınız bitti. Aranan sayı: " + searchingNumber);
                    Environment.Exit(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }


        private void updateGap(int choice, string number)
        {
            if (choice == 1)
            {
                numberMin = int.Parse(number);
                minLabel.Text = number;
            }
            else
            {
                numberMax = int.Parse(number);
                maxLabel.Text = number;
            }
        }

        private void userInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                guessBtn_Click(sender, e);
            }
        }
    }
}
