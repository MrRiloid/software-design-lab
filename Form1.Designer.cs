namespace calculator
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
            deletALlBt = new Button();
            deleteCharBt = new Button();
            minusBt = new Button();
            plusBt = new Button();
            dvBt = new Button();
            multBt = new Button();
            percentBt = new Button();
            equalBt = new Button();
            dotBtn = new Button();
            btnReverse = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            num0Bt = new NumButton();
            num1Bt = new NumButton();
            num2Bt = new NumButton();
            num3Bt = new NumButton();
            num6Bt = new NumButton();
            num5Bt = new NumButton();
            num4Bt = new NumButton();
            num9Bt = new NumButton();
            num8Bt = new NumButton();
            num7Bt = new NumButton();
            SuspendLayout();
            // 
            // deletALlBt
            // 
            deletALlBt.Location = new Point(11, 150);
            deletALlBt.Name = "deletALlBt";
            deletALlBt.Size = new Size(80, 80);
            deletALlBt.TabIndex = 9;
            deletALlBt.Text = "C";
            deletALlBt.UseVisualStyleBackColor = true;
            deletALlBt.Click += deletALlBt_Click;
            // 
            // deleteCharBt
            // 
            deleteCharBt.Location = new Point(97, 150);
            deleteCharBt.Name = "deleteCharBt";
            deleteCharBt.Size = new Size(80, 80);
            deleteCharBt.TabIndex = 10;
            deleteCharBt.Text = "<=";
            deleteCharBt.UseVisualStyleBackColor = true;
            deleteCharBt.Click += deleteCharBt_Click;
            // 
            // minusBt
            // 
            minusBt.Location = new Point(269, 408);
            minusBt.Name = "minusBt";
            minusBt.Size = new Size(80, 80);
            minusBt.TabIndex = 11;
            minusBt.Text = "-";
            minusBt.UseVisualStyleBackColor = true;
            minusBt.Click += minusBt_Click;
            // 
            // plusBt
            // 
            plusBt.Location = new Point(269, 322);
            plusBt.Name = "plusBt";
            plusBt.Size = new Size(80, 80);
            plusBt.TabIndex = 12;
            plusBt.Text = "+";
            plusBt.UseVisualStyleBackColor = true;
            plusBt.Click += plusBt_Click;
            // 
            // dvBt
            // 
            dvBt.Location = new Point(269, 236);
            dvBt.Name = "dvBt";
            dvBt.Size = new Size(80, 80);
            dvBt.TabIndex = 13;
            dvBt.Text = "/";
            dvBt.UseVisualStyleBackColor = true;
            dvBt.Click += dvBt_Click;
            // 
            // multBt
            // 
            multBt.Location = new Point(269, 150);
            multBt.Name = "multBt";
            multBt.Size = new Size(80, 80);
            multBt.TabIndex = 14;
            multBt.Text = "*";
            multBt.UseVisualStyleBackColor = true;
            multBt.Click += multBt_Click;
            // 
            // percentBt
            // 
            percentBt.Location = new Point(183, 150);
            percentBt.Name = "percentBt";
            percentBt.Size = new Size(80, 80);
            percentBt.TabIndex = 15;
            percentBt.Text = "%";
            percentBt.UseVisualStyleBackColor = true;
            percentBt.Click += percentBt_Click;
            // 
            // equalBt
            // 
            equalBt.Location = new Point(269, 494);
            equalBt.Name = "equalBt";
            equalBt.Size = new Size(80, 80);
            equalBt.TabIndex = 19;
            equalBt.Text = "=";
            equalBt.UseVisualStyleBackColor = true;
            equalBt.Click += equalBt_Click;
            // 
            // dotBtn
            // 
            dotBtn.Location = new Point(183, 494);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(80, 80);
            dotBtn.TabIndex = 18;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = true;
            dotBtn.Click += dotBtn_Click;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(11, 494);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(80, 80);
            btnReverse.TabIndex = 16;
            btnReverse.Text = "+/-";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(11, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(338, 54);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(12, 34);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(338, 50);
            textBox2.TabIndex = 21;
            // 
            // num0Bt
            // 
            num0Bt.Location = new Point(97, 494);
            num0Bt.Name = "num0Bt";
            num0Bt.Num = "9";
            num0Bt.Size = new Size(80, 78);
            num0Bt.TabIndex = 22;
            num0Bt.Text = "0";
            num0Bt.Click += num0Bt_Click;
            // 
            // num1Bt
            // 
            num1Bt.Location = new Point(12, 410);
            num1Bt.Name = "num1Bt";
            num1Bt.Num = "1";
            num1Bt.Size = new Size(80, 78);
            num1Bt.TabIndex = 23;
            num1Bt.Text = "1";
            num1Bt.Click += num1Bt_Click_1;
            // 
            // num2Bt
            // 
            num2Bt.Location = new Point(98, 410);
            num2Bt.Name = "num2Bt";
            num2Bt.Num = "2";
            num2Bt.Size = new Size(80, 78);
            num2Bt.TabIndex = 24;
            num2Bt.Text = "2";
            num2Bt.Click += num2Bt_Click;
            // 
            // num3Bt
            // 
            num3Bt.Location = new Point(184, 410);
            num3Bt.Name = "num3Bt";
            num3Bt.Num = "3";
            num3Bt.Size = new Size(80, 78);
            num3Bt.TabIndex = 25;
            num3Bt.Text = "3";
            num3Bt.Click += num3Bt_Click;
            // 
            // num6Bt
            // 
            num6Bt.Location = new Point(184, 322);
            num6Bt.Name = "num6Bt";
            num6Bt.Num = "6";
            num6Bt.Size = new Size(80, 78);
            num6Bt.TabIndex = 28;
            num6Bt.Text = "6";
            num6Bt.Click += num6Bt_Click;
            // 
            // num5Bt
            // 
            num5Bt.Location = new Point(98, 322);
            num5Bt.Name = "num5Bt";
            num5Bt.Num = "5";
            num5Bt.Size = new Size(80, 78);
            num5Bt.TabIndex = 27;
            num5Bt.Text = "5";
            num5Bt.Click += num5Bt_Click;
            // 
            // num4Bt
            // 
            num4Bt.Location = new Point(12, 322);
            num4Bt.Name = "num4Bt";
            num4Bt.Num = "4";
            num4Bt.Size = new Size(80, 78);
            num4Bt.TabIndex = 26;
            num4Bt.Text = "4";
            num4Bt.Click += num4Bt_Click;
            // 
            // num9Bt
            // 
            num9Bt.Location = new Point(184, 238);
            num9Bt.Name = "num9Bt";
            num9Bt.Num = "9";
            num9Bt.Size = new Size(80, 78);
            num9Bt.TabIndex = 31;
            num9Bt.Text = "9";
            num9Bt.Click += num9Bt_Click;
            // 
            // num8Bt
            // 
            num8Bt.Location = new Point(98, 238);
            num8Bt.Name = "num8Bt";
            num8Bt.Num = "8";
            num8Bt.Size = new Size(80, 78);
            num8Bt.TabIndex = 30;
            num8Bt.Text = "8";
            num8Bt.Click += num8Bt_Click;
            // 
            // num7Bt
            // 
            num7Bt.Location = new Point(12, 238);
            num7Bt.Name = "num7Bt";
            num7Bt.Num = "7";
            num7Bt.Size = new Size(80, 78);
            num7Bt.TabIndex = 29;
            num7Bt.Text = "7";
            num7Bt.Click += num7Bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 584);
            Controls.Add(num9Bt);
            Controls.Add(num8Bt);
            Controls.Add(num7Bt);
            Controls.Add(num6Bt);
            Controls.Add(num5Bt);
            Controls.Add(num4Bt);
            Controls.Add(num3Bt);
            Controls.Add(num2Bt);
            Controls.Add(num1Bt);
            Controls.Add(num0Bt);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(equalBt);
            Controls.Add(dotBtn);
            Controls.Add(btnReverse);
            Controls.Add(percentBt);
            Controls.Add(multBt);
            Controls.Add(dvBt);
            Controls.Add(plusBt);
            Controls.Add(minusBt);
            Controls.Add(deleteCharBt);
            Controls.Add(deletALlBt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deletALlBt;
        private Button deleteCharBt;
        private Button minusBt;
        private Button plusBt;
        private Button dvBt;
        private Button multBt;
        private Button percentBt;
        private Button equalBt;
        private Button dotBtn;
        private Button btnReverse;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumButton num0Bt;
        private NumButton num1Bt;
        private NumButton num2Bt;
        private NumButton num3Bt;
        private NumButton num6Bt;
        private NumButton num5Bt;
        private NumButton num4Bt;
        private NumButton num9Bt;
        private NumButton num8Bt;
        private NumButton num7Bt;
    }
}
