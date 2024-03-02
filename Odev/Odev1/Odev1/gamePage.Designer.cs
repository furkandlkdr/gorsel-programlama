namespace Odev1
{
    partial class gamePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.remainingTitleLbl = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(133, 19);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(267, 42);
            this.currentLabel.TabIndex = 0;
            this.currentLabel.Text = "Şu anki aralık:";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(104, 114);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(332, 49);
            this.userInput.TabIndex = 2;
            this.userInput.Text = "Tahminin:";
            this.userInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userInput_KeyPress);
            // 
            // guessBtn
            // 
            this.guessBtn.BackColor = System.Drawing.Color.MistyRose;
            this.guessBtn.FlatAppearance.BorderSize = 0;
            this.guessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBtn.Location = new System.Drawing.Point(104, 169);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(332, 93);
            this.guessBtn.TabIndex = 3;
            this.guessBtn.Text = "Tahmin et";
            this.guessBtn.UseVisualStyleBackColor = false;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(107, 69);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(40, 42);
            this.minLabel.TabIndex = 4;
            this.minLabel.Text = "0";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(352, 69);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(84, 42);
            this.maxLabel.TabIndex = 5;
            this.maxLabel.Text = "200";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLabel.Location = new System.Drawing.Point(247, 69);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(28, 37);
            this.dividerLabel.TabIndex = 6;
            this.dividerLabel.Text = "-";
            this.dividerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingTitleLbl
            // 
            this.remainingTitleLbl.AutoSize = true;
            this.remainingTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingTitleLbl.Location = new System.Drawing.Point(427, 9);
            this.remainingTitleLbl.Name = "remainingTitleLbl";
            this.remainingTitleLbl.Size = new System.Drawing.Size(104, 24);
            this.remainingTitleLbl.TabIndex = 7;
            this.remainingTitleLbl.Text = "Kalan Hak";
            this.remainingTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.ForeColor = System.Drawing.Color.Red;
            this.remainingLabel.Location = new System.Drawing.Point(462, 33);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(25, 25);
            this.remainingLabel.TabIndex = 8;
            this.remainingLabel.Text = "5";
            this.remainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.remainingTitleLbl);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.currentLabel);
            this.Name = "gamePage";
            this.Text = "Sayı Tahmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label remainingTitleLbl;
        private System.Windows.Forms.Label remainingLabel;
    }
}

