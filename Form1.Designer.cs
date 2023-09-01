namespace LaCalculadora_I
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
            label1 = new Label();
            button11 = new Button();
            button3 = new Button();
            button5 = new Button();
            button7 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            btn10 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Help;
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(127, 28);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA DE LA IA";
            label1.Click += label1_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 255, 192);
            button11.Cursor = Cursors.Hand;
            button11.Location = new Point(46, 140);
            button11.Name = "button11";
            button11.Size = new Size(42, 43);
            button11.TabIndex = 12;
            button11.Text = "(";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(147, 140);
            button3.Name = "button3";
            button3.Size = new Size(42, 43);
            button3.TabIndex = 14;
            button3.Text = ")";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 192);
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(238, 140);
            button5.Name = "button5";
            button5.Size = new Size(42, 43);
            button5.TabIndex = 15;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 255, 192);
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(332, 140);
            button7.Name = "button7";
            button7.Size = new Size(42, 43);
            button7.TabIndex = 16;
            button7.Text = "AC";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(255, 255, 192);
            button14.Cursor = Cursors.Hand;
            button14.Location = new Point(46, 209);
            button14.Name = "button14";
            button14.Size = new Size(42, 43);
            button14.TabIndex = 18;
            button14.Text = "7";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(255, 255, 192);
            button15.Cursor = Cursors.Hand;
            button15.Location = new Point(46, 289);
            button15.Name = "button15";
            button15.Size = new Size(42, 43);
            button15.TabIndex = 19;
            button15.Text = "4";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(255, 255, 192);
            button16.Cursor = Cursors.Hand;
            button16.Location = new Point(46, 358);
            button16.Name = "button16";
            button16.Size = new Size(42, 43);
            button16.TabIndex = 20;
            button16.Text = "1";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(255, 255, 192);
            button17.Cursor = Cursors.Hand;
            button17.Location = new Point(46, 422);
            button17.Name = "button17";
            button17.Size = new Size(42, 43);
            button17.TabIndex = 21;
            button17.Text = "0";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(147, 209);
            button1.Name = "button1";
            button1.Size = new Size(42, 43);
            button1.TabIndex = 22;
            button1.Text = "8";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(238, 209);
            button2.Name = "button2";
            button2.Size = new Size(42, 43);
            button2.TabIndex = 23;
            button2.Text = "9";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 192);
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(332, 209);
            button4.Name = "button4";
            button4.Size = new Size(42, 43);
            button4.TabIndex = 24;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 255, 192);
            button8.Cursor = Cursors.Hand;
            button8.Location = new Point(147, 289);
            button8.Name = "button8";
            button8.Size = new Size(42, 43);
            button8.TabIndex = 26;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 255, 192);
            button9.Cursor = Cursors.Hand;
            button9.Location = new Point(238, 289);
            button9.Name = "button9";
            button9.Size = new Size(42, 43);
            button9.TabIndex = 27;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btn10
            // 
            btn10.BackColor = Color.FromArgb(255, 255, 192);
            btn10.Cursor = Cursors.Hand;
            btn10.Location = new Point(332, 289);
            btn10.Name = "btn10";
            btn10.Size = new Size(42, 43);
            btn10.TabIndex = 28;
            btn10.Text = "*";
            btn10.UseVisualStyleBackColor = false;
            btn10.Click += btn10_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(255, 255, 192);
            button18.Cursor = Cursors.Hand;
            button18.Location = new Point(147, 358);
            button18.Name = "button18";
            button18.Size = new Size(42, 43);
            button18.TabIndex = 30;
            button18.Text = "2";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(255, 255, 192);
            button19.Cursor = Cursors.Hand;
            button19.Location = new Point(238, 358);
            button19.Name = "button19";
            button19.Size = new Size(42, 43);
            button19.TabIndex = 31;
            button19.Text = "3";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(255, 255, 192);
            button20.Cursor = Cursors.Hand;
            button20.Location = new Point(332, 358);
            button20.Name = "button20";
            button20.Size = new Size(42, 43);
            button20.TabIndex = 32;
            button20.Text = "-";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(255, 255, 192);
            button22.Cursor = Cursors.Hand;
            button22.Location = new Point(147, 422);
            button22.Name = "button22";
            button22.Size = new Size(42, 43);
            button22.TabIndex = 34;
            button22.Text = ".";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(255, 255, 192);
            button23.Cursor = Cursors.Hand;
            button23.Location = new Point(238, 422);
            button23.Name = "button23";
            button23.Size = new Size(42, 43);
            button23.TabIndex = 35;
            button23.Text = "=";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(255, 255, 192);
            button24.Cursor = Cursors.Hand;
            button24.Location = new Point(332, 422);
            button24.Name = "button24";
            button24.Size = new Size(42, 43);
            button24.TabIndex = 36;
            button24.Text = "+";
            button24.UseVisualStyleBackColor = false;
            button24.Click += button24_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(46, 68);
            textBox1.MaxLength = 327675;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 38;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(431, 497);
            Controls.Add(textBox1);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(btn10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button11);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button11;
        private Button button3;
        private Button button5;
        private Button button7;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button btn10;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button22;
        private Button button23;
        private Button button24;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}