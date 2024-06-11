namespace WinFormsApp1
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
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown4 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            button10 = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "den_p";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 311);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 5, 29, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 71);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "val_spec";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 131);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "den_s";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 181);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "den_c";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 225);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "cant_p";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 270);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "suma_f";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Increment = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown3.Location = new Point(106, 263);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(250, 27);
            numericUpDown3.TabIndex = 12;
            numericUpDown3.UpDownAlign = LeftRightAlignment.Left;
            numericUpDown3.Value = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 316);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 13;
            label7.Text = "data_f";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 12);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 14;
            label8.Text = "nume_a";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 64);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 15;
            label9.Text = "functie_a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(408, 127);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 16;
            label10.Text = "locatie_a";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(408, 174);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 17;
            label11.Text = "data_p";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(408, 223);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 18;
            label12.Text = "nr_ore_po";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(408, 265);
            label13.Name = "label13";
            label13.Size = new Size(50, 20);
            label13.TabIndex = 19;
            label13.Text = "loc_cli";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(408, 311);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 20;
            label14.Text = "adresa_cli";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(491, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(491, 57);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(491, 120);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(491, 262);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 27);
            textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(491, 309);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(250, 27);
            textBox8.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(491, 167);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 26;
            dateTimePicker2.Value = new DateTime(2023, 5, 29, 0, 0, 0, 0);
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(491, 216);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(250, 27);
            numericUpDown4.TabIndex = 27;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(35, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 28;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 360);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 360);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 30;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(374, 360);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 31;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(491, 360);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 32;
            button5.Text = "Export";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(35, 395);
            button6.Name = "button6";
            button6.Size = new Size(117, 29);
            button6.TabIndex = 33;
            button6.Text = "Pret ascendent";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(167, 395);
            button7.Name = "button7";
            button7.Size = new Size(126, 29);
            button7.TabIndex = 34;
            button7.Text = "Pret descendent";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(299, 395);
            button8.Name = "button8";
            button8.Size = new Size(128, 29);
            button8.TabIndex = 35;
            button8.Text = "Nume ascendent";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(433, 395);
            button9.Name = "button9";
            button9.Size = new Size(152, 29);
            button9.TabIndex = 36;
            button9.Text = "Nume descendent";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(106, 223);
            numericUpDown2.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(250, 27);
            numericUpDown2.TabIndex = 11;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new Point(106, 64);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 218);
            dataGridView1.TabIndex = 37;
            // 
            // button10
            // 
            button10.Location = new Point(609, 360);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 38;
            button10.Text = "Import";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // button11
            // 
            button11.Location = new Point(609, 395);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 39;
            button11.Text = "logout";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 738);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown4);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private Button button10;
        private Button button11;
    }
}