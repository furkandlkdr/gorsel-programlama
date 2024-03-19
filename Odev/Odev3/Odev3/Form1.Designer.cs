namespace Odev3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            bar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            leftEdge = new Label();
            rightEdge = new Label();
            topEdge = new Label();
            timeLabel = new Label();
            remainingLifeLabel = new Label();
            remainingLifeValue = new Label();
            hitCountLabel = new Label();
            timeValue = new Label();
            hitCountValue = new Label();
            startBtn = new Button();
            ball = new Button();
            bottomEdge = new Label();
            SuspendLayout();
            // 
            // bar
            // 
            bar.BackColor = Color.Goldenrod;
            bar.FlatStyle = FlatStyle.Flat;
            bar.ForeColor = SystemColors.AppWorkspace;
            bar.Location = new Point(360, 390);
            bar.Name = "bar";
            bar.Size = new Size(100, 20);
            bar.TabIndex = 0;
            bar.Text = ".";
            bar.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // leftEdge
            // 
            leftEdge.BackColor = SystemColors.ActiveBorder;
            leftEdge.FlatStyle = FlatStyle.Flat;
            leftEdge.Location = new Point(10, 20);
            leftEdge.Name = "leftEdge";
            leftEdge.Size = new Size(20, 392);
            leftEdge.TabIndex = 1;
            // 
            // rightEdge
            // 
            rightEdge.BackColor = SystemColors.ActiveBorder;
            rightEdge.FlatStyle = FlatStyle.Flat;
            rightEdge.Location = new Point(630, 20);
            rightEdge.Name = "rightEdge";
            rightEdge.Size = new Size(20, 392);
            rightEdge.TabIndex = 2;
            // 
            // topEdge
            // 
            topEdge.BackColor = SystemColors.ActiveBorder;
            topEdge.FlatStyle = FlatStyle.Flat;
            topEdge.Location = new Point(10, 0);
            topEdge.Name = "topEdge";
            topEdge.Size = new Size(640, 20);
            topEdge.TabIndex = 3;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(685, 20);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(56, 15);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "Süre: (sn)";
            // 
            // remainingLifeLabel
            // 
            remainingLifeLabel.AutoSize = true;
            remainingLifeLabel.Location = new Point(685, 60);
            remainingLifeLabel.Name = "remainingLifeLabel";
            remainingLifeLabel.Size = new Size(79, 15);
            remainingLifeLabel.TabIndex = 5;
            remainingLifeLabel.Text = "Kalan canınız:";
            // 
            // remainingLifeValue
            // 
            remainingLifeValue.AutoSize = true;
            remainingLifeValue.Location = new Point(791, 60);
            remainingLifeValue.Name = "remainingLifeValue";
            remainingLifeValue.Size = new Size(13, 15);
            remainingLifeValue.TabIndex = 6;
            remainingLifeValue.Text = "5";
            // 
            // hitCountLabel
            // 
            hitCountLabel.AutoSize = true;
            hitCountLabel.Location = new Point(685, 89);
            hitCountLabel.Name = "hitCountLabel";
            hitCountLabel.Size = new Size(91, 15);
            hitCountLabel.TabIndex = 7;
            hitCountLabel.Text = "Kurtarma Sayısı:";
            // 
            // timeValue
            // 
            timeValue.AutoSize = true;
            timeValue.Location = new Point(791, 20);
            timeValue.Name = "timeValue";
            timeValue.Size = new Size(13, 15);
            timeValue.TabIndex = 8;
            timeValue.Text = "0";
            // 
            // hitCountValue
            // 
            hitCountValue.AutoSize = true;
            hitCountValue.Location = new Point(791, 89);
            hitCountValue.Name = "hitCountValue";
            hitCountValue.Size = new Size(13, 15);
            hitCountValue.TabIndex = 9;
            hitCountValue.Text = "0";
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.ButtonHighlight;
            startBtn.ForeColor = SystemColors.ActiveCaptionText;
            startBtn.Location = new Point(685, 125);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(119, 23);
            startBtn.TabIndex = 10;
            startBtn.Text = "Başlat";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // ball
            // 
            ball.BackColor = Color.DarkBlue;
            ball.FlatStyle = FlatStyle.Flat;
            ball.ForeColor = SystemColors.AppWorkspace;
            ball.Location = new Point(373, 220);
            ball.Name = "ball";
            ball.Size = new Size(15, 15);
            ball.TabIndex = 11;
            ball.Text = ".";
            ball.UseVisualStyleBackColor = false;
            // 
            // bottomEdge
            // 
            bottomEdge.BackColor = Color.Indigo;
            bottomEdge.FlatStyle = FlatStyle.Flat;
            bottomEdge.Location = new Point(10, 412);
            bottomEdge.Name = "bottomEdge";
            bottomEdge.Size = new Size(640, 2);
            bottomEdge.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 461);
            Controls.Add(bottomEdge);
            Controls.Add(ball);
            Controls.Add(startBtn);
            Controls.Add(hitCountValue);
            Controls.Add(timeValue);
            Controls.Add(hitCountLabel);
            Controls.Add(remainingLifeValue);
            Controls.Add(remainingLifeLabel);
            Controls.Add(timeLabel);
            Controls.Add(topEdge);
            Controls.Add(rightEdge);
            Controls.Add(leftEdge);
            Controls.Add(bar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bar;
        private System.Windows.Forms.Timer timer1;
        private Label leftEdge;
        private Label rightEdge;
        private Label topEdge;
        private Label timeLabel;
        private Label remainingLifeLabel;
        private Label remainingLifeValue;
        private Label hitCountLabel;
        private Label timeValue;
        private Label hitCountValue;
        private Button startBtn;
        private Button ball;
        private Label bottomEdge;
    }
}
