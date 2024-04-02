namespace Odev4_2
{
    partial class MetinIsleme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstTextValue = new TextBox();
            firstTextLabel = new Label();
            secondTextLabel = new Label();
            secondTextValue = new TextBox();
            processGroup = new GroupBox();
            ReplaceBtn = new Button();
            ReplaceTextValue = new TextBox();
            DeleteBtn = new Button();
            MergeBtn = new Button();
            SearchBtn = new Button();
            resultTextLabel = new Label();
            resultTextValue = new RichTextBox();
            processGroup.SuspendLayout();
            SuspendLayout();
            // 
            // firstTextValue
            // 
            firstTextValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstTextValue.Location = new Point(143, 12);
            firstTextValue.Name = "firstTextValue";
            firstTextValue.Size = new Size(187, 25);
            firstTextValue.TabIndex = 0;
            // 
            // firstTextLabel
            // 
            firstTextLabel.AutoSize = true;
            firstTextLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstTextLabel.Location = new Point(12, 20);
            firstTextLabel.Name = "firstTextLabel";
            firstTextLabel.Size = new Size(125, 17);
            firstTextLabel.TabIndex = 1;
            firstTextLabel.Text = "Düzenlenecek yazı:";
            // 
            // secondTextLabel
            // 
            secondTextLabel.AutoSize = true;
            secondTextLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secondTextLabel.Location = new Point(12, 46);
            secondTextLabel.Name = "secondTextLabel";
            secondTextLabel.Size = new Size(108, 17);
            secondTextLabel.TabIndex = 2;
            secondTextLabel.Text = "İşlenecek metin:";
            // 
            // secondTextValue
            // 
            secondTextValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secondTextValue.Location = new Point(143, 43);
            secondTextValue.Name = "secondTextValue";
            secondTextValue.Size = new Size(187, 25);
            secondTextValue.TabIndex = 3;
            // 
            // processGroup
            // 
            processGroup.Controls.Add(ReplaceBtn);
            processGroup.Controls.Add(ReplaceTextValue);
            processGroup.Controls.Add(DeleteBtn);
            processGroup.Controls.Add(MergeBtn);
            processGroup.Controls.Add(SearchBtn);
            processGroup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            processGroup.Location = new Point(12, 74);
            processGroup.Name = "processGroup";
            processGroup.Size = new Size(318, 117);
            processGroup.TabIndex = 6;
            processGroup.TabStop = false;
            processGroup.Text = "İşlemler";
            // 
            // ReplaceBtn
            // 
            ReplaceBtn.BackColor = Color.MistyRose;
            ReplaceBtn.Location = new Point(203, 69);
            ReplaceBtn.Name = "ReplaceBtn";
            ReplaceBtn.Size = new Size(82, 33);
            ReplaceBtn.TabIndex = 7;
            ReplaceBtn.Text = "Değiştir";
            ReplaceBtn.UseVisualStyleBackColor = false;
            ReplaceBtn.Click += ReplaceBtn_Click;
            // 
            // ReplaceTextValue
            // 
            ReplaceTextValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReplaceTextValue.Location = new Point(22, 74);
            ReplaceTextValue.Name = "ReplaceTextValue";
            ReplaceTextValue.PlaceholderText = "Yerine yazılacak yazı";
            ReplaceTextValue.Size = new Size(170, 25);
            ReplaceTextValue.TabIndex = 6;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.MistyRose;
            DeleteBtn.Location = new Point(203, 24);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(82, 33);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // MergeBtn
            // 
            MergeBtn.BackColor = Color.MistyRose;
            MergeBtn.Location = new Point(110, 24);
            MergeBtn.Name = "MergeBtn";
            MergeBtn.Size = new Size(82, 33);
            MergeBtn.TabIndex = 1;
            MergeBtn.Text = "Birleştir";
            MergeBtn.UseVisualStyleBackColor = false;
            MergeBtn.Click += MergeBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.MistyRose;
            SearchBtn.Location = new Point(22, 24);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(82, 33);
            SearchBtn.TabIndex = 0;
            SearchBtn.Text = "İlkini Ara";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // resultTextLabel
            // 
            resultTextLabel.AutoSize = true;
            resultTextLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultTextLabel.Location = new Point(12, 204);
            resultTextLabel.Name = "resultTextLabel";
            resultTextLabel.Size = new Size(93, 17);
            resultTextLabel.TabIndex = 4;
            resultTextLabel.Text = "İşlem sonucu:";
            // 
            // resultTextValue
            // 
            resultTextValue.Location = new Point(12, 224);
            resultTextValue.Name = "resultTextValue";
            resultTextValue.Size = new Size(318, 96);
            resultTextValue.TabIndex = 7;
            resultTextValue.Text = "";
            // 
            // MetinIsleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(351, 406);
            Controls.Add(resultTextValue);
            Controls.Add(processGroup);
            Controls.Add(resultTextLabel);
            Controls.Add(secondTextValue);
            Controls.Add(secondTextLabel);
            Controls.Add(firstTextLabel);
            Controls.Add(firstTextValue);
            Name = "MetinIsleme";
            Text = "Metin İşleme";
            Load += MetinIsleme_Load;
            processGroup.ResumeLayout(false);
            processGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstTextValue;
        private Label firstTextLabel;
        private Label secondTextLabel;
        private TextBox secondTextValue;
        private GroupBox processGroup;
        private Button SearchBtn;
        private Label resultTextLabel;
        private Button MergeBtn;
        private TextBox ReplaceTextValue;
        private Button DeleteBtn;
        private Button ReplaceBtn;
        private RichTextBox resultTextValue;
    }
}
