namespace Odev4_1
{
    partial class MemoryTestForm
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
            startBtn = new Button();
            scoreLabel = new Label();
            scoreValue = new Label();
            BtnGroup = new GroupBox();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button0 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            BtnGroup.SuspendLayout();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.DarkCyan;
            startBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.ForeColor = Color.Cornsilk;
            startBtn.Location = new Point(12, 12);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(93, 56);
            startBtn.TabIndex = 0;
            startBtn.Text = "Başla";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(126, 12);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(43, 15);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Seviye:";
            // 
            // scoreValue
            // 
            scoreValue.AutoSize = true;
            scoreValue.Location = new Point(175, 12);
            scoreValue.Name = "scoreValue";
            scoreValue.Size = new Size(13, 15);
            scoreValue.TabIndex = 2;
            scoreValue.Text = "0";
            scoreValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnGroup
            // 
            BtnGroup.Controls.Add(button15);
            BtnGroup.Controls.Add(button16);
            BtnGroup.Controls.Add(button17);
            BtnGroup.Controls.Add(button18);
            BtnGroup.Controls.Add(button19);
            BtnGroup.Controls.Add(button12);
            BtnGroup.Controls.Add(button13);
            BtnGroup.Controls.Add(button14);
            BtnGroup.Controls.Add(button6);
            BtnGroup.Controls.Add(button7);
            BtnGroup.Controls.Add(button8);
            BtnGroup.Controls.Add(button9);
            BtnGroup.Controls.Add(button10);
            BtnGroup.Controls.Add(button11);
            BtnGroup.Controls.Add(button5);
            BtnGroup.Controls.Add(button4);
            BtnGroup.Controls.Add(button3);
            BtnGroup.Controls.Add(button2);
            BtnGroup.Controls.Add(button1);
            BtnGroup.Controls.Add(button0);
            BtnGroup.Location = new Point(12, 74);
            BtnGroup.Name = "BtnGroup";
            BtnGroup.Size = new Size(314, 260);
            BtnGroup.TabIndex = 3;
            BtnGroup.TabStop = false;
            BtnGroup.Text = "Butonlar";
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 1.5F);
            button15.ForeColor = SystemColors.ControlLight;
            button15.Location = new Point(128, 199);
            button15.Name = "button15";
            button15.Size = new Size(55, 53);
            button15.TabIndex = 22;
            button15.UseVisualStyleBackColor = true;
            button15.MouseClick += Color_Button_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 1.5F);
            button16.ForeColor = SystemColors.ControlLight;
            button16.Location = new Point(67, 199);
            button16.Name = "button16";
            button16.Size = new Size(55, 53);
            button16.TabIndex = 21;
            button16.UseVisualStyleBackColor = true;
            button16.MouseClick += Color_Button_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 1.5F);
            button17.ForeColor = SystemColors.ControlLight;
            button17.Location = new Point(6, 199);
            button17.Name = "button17";
            button17.Size = new Size(55, 53);
            button17.TabIndex = 20;
            button17.UseVisualStyleBackColor = true;
            button17.MouseClick += Color_Button_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 1.5F);
            button18.ForeColor = SystemColors.ControlLight;
            button18.Location = new Point(250, 199);
            button18.Name = "button18";
            button18.Size = new Size(55, 53);
            button18.TabIndex = 19;
            button18.UseVisualStyleBackColor = true;
            button18.MouseClick += Color_Button_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button19.ForeColor = SystemColors.ControlLight;
            button19.Location = new Point(189, 199);
            button19.Name = "button19";
            button19.Size = new Size(55, 53);
            button19.TabIndex = 18;
            button19.UseVisualStyleBackColor = true;
            button19.MouseClick += Color_Button_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 1.5F);
            button12.ForeColor = SystemColors.ControlLight;
            button12.Location = new Point(128, 140);
            button12.Name = "button12";
            button12.Size = new Size(55, 53);
            button12.TabIndex = 17;
            button12.UseVisualStyleBackColor = true;
            button12.MouseClick += Color_Button_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 1.5F);
            button13.ForeColor = SystemColors.ControlLight;
            button13.Location = new Point(67, 140);
            button13.Name = "button13";
            button13.Size = new Size(55, 53);
            button13.TabIndex = 16;
            button13.UseVisualStyleBackColor = true;
            button13.MouseClick += Color_Button_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 1.5F);
            button14.ForeColor = SystemColors.ControlLight;
            button14.Location = new Point(6, 140);
            button14.Name = "button14";
            button14.Size = new Size(55, 53);
            button14.TabIndex = 15;
            button14.UseVisualStyleBackColor = true;
            button14.MouseClick += Color_Button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 1.5F);
            button6.ForeColor = SystemColors.ControlLight;
            button6.Location = new Point(189, 81);
            button6.Name = "button6";
            button6.Size = new Size(55, 53);
            button6.TabIndex = 11;
            button6.UseVisualStyleBackColor = true;
            button6.MouseClick += Color_Button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 1.5F);
            button7.ForeColor = SystemColors.ControlLight;
            button7.Location = new Point(128, 81);
            button7.Name = "button7";
            button7.Size = new Size(55, 53);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = true;
            button7.MouseClick += Color_Button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 1.5F);
            button8.ForeColor = SystemColors.ControlLight;
            button8.Location = new Point(67, 81);
            button8.Name = "button8";
            button8.Size = new Size(55, 53);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = true;
            button8.MouseClick += Color_Button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 1.5F);
            button9.ForeColor = SystemColors.ControlLight;
            button9.Location = new Point(6, 81);
            button9.Name = "button9";
            button9.Size = new Size(55, 53);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.MouseClick += Color_Button_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 1.5F);
            button10.ForeColor = SystemColors.ControlLight;
            button10.Location = new Point(250, 140);
            button10.Name = "button10";
            button10.Size = new Size(55, 53);
            button10.TabIndex = 7;
            button10.UseVisualStyleBackColor = true;
            button10.MouseClick += Color_Button_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ControlLight;
            button11.Location = new Point(189, 140);
            button11.Name = "button11";
            button11.Size = new Size(55, 53);
            button11.TabIndex = 6;
            button11.UseVisualStyleBackColor = true;
            button11.MouseClick += Color_Button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 1.5F);
            button5.ForeColor = SystemColors.ControlLight;
            button5.Location = new Point(250, 81);
            button5.Name = "button5";
            button5.Size = new Size(55, 53);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.MouseClick += Color_Button_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Segoe UI", 1.5F);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(250, 22);
            button4.Name = "button4";
            button4.Size = new Size(55, 53);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.MouseClick += Color_Button_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Segoe UI", 1.5F);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(189, 22);
            button3.Name = "button3";
            button3.Size = new Size(55, 53);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.MouseClick += Color_Button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 1.5F);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(128, 22);
            button2.Name = "button2";
            button2.Size = new Size(55, 53);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += Color_Button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 1.5F);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(67, 22);
            button1.Name = "button1";
            button1.Size = new Size(55, 53);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += Color_Button_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.ForeColor = SystemColors.ControlLight;
            button0.Location = new Point(6, 22);
            button0.Name = "button0";
            button0.Size = new Size(55, 53);
            button0.TabIndex = 0;
            button0.UseVisualStyleBackColor = true;
            button0.MouseClick += Color_Button_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MemoryTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(334, 341);
            Controls.Add(BtnGroup);
            Controls.Add(scoreValue);
            Controls.Add(scoreLabel);
            Controls.Add(startBtn);
            ForeColor = SystemColors.ControlText;
            Name = "MemoryTestForm";
            Text = "Maymun Hafıza Testi";
            Load += MemoryTestForm_Load;
            BtnGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Label scoreLabel;
        private Label scoreValue;
        private GroupBox BtnGroup;
        private Button button0;
        private Button button1;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
