using System.Text;

namespace Odev4_2 {
    public partial class MetinIsleme : Form {
        public MetinIsleme() {
            InitializeComponent();
        }

        private void MetinIsleme_Load(object sender, EventArgs e) { }

        private void SearchBtn_Click(object sender, EventArgs e) {
            string firstText = firstTextValue.Text;
            string searchString = secondTextValue.Text;
            StringBuilder sb = new StringBuilder();

            if (searchString == string.Empty || firstText == string.Empty) {
                resultTextValue.Text = "Aranacak metin veya işlenecek metin girilmedi.";
                return;
            }
            int index = firstText.IndexOf(searchString);
            if (index != -1) {
                sb.AppendLine();
                sb.AppendFormat("{1}. Index'te {0} bulundu ", searchString, index);
            } else {
                sb.AppendLine();
                sb.AppendFormat("Aranan metin '{0}' ilk metinde bulunamadı.", searchString);
            }

            resultTextValue.Text = sb.ToString();
        }

        private void MergeBtn_Click(object sender, EventArgs e) {
            string firstText = firstTextValue.Text;
            string secondText = secondTextValue.Text;
            StringBuilder sb = new StringBuilder();

            sb.Append(firstText);
            sb.Append("");
            sb.Append(secondText);

            resultTextValue.Text = sb.ToString();
        }


        private void DeleteBtn_Click(object sender, EventArgs e) {
            string firstText = firstTextValue.Text;
            string secondText = secondTextValue.Text;
            StringBuilder sb = new StringBuilder(firstText);

            if (secondText == string.Empty || firstText == string.Empty) {
                resultTextValue.Text = "Aranacak metin veya işlenecek metin girilmedi.";
                return;
            }
            int index = sb.ToString().IndexOf(secondText);

            if (index != -1) {
                sb.Remove(index, secondText.Length);
            } else {
                resultTextValue.Text = "İşlenecek metin bulunamadı.";
                return;
            }
            resultTextValue.Text = sb.ToString();
        }

        private void ReplaceBtn_Click(object sender, EventArgs e) {
            string firstText = firstTextValue.Text;
            string searchString = secondTextValue.Text;
            string replaceText = ReplaceTextValue.Text;

            if (string.IsNullOrEmpty(firstText) || string.IsNullOrEmpty(searchString) || string.IsNullOrEmpty(replaceText)) {
                resultTextValue.Text = "Aranacak metin, işlenecek metin veya değiştirilecek metin girilmedi.";
                return;
            }
            string replacedText = firstText.Replace(searchString, replaceText);

            resultTextValue.Text = replacedText;
        }

    }
}
