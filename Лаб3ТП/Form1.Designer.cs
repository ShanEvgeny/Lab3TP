namespace Лаб3ТП
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(431, 82);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(254, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(431, 141);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(254, 27);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(33, 209);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 4;
            button1.Text = "A + B";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 209);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 5;
            button2.Text = "A - B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(555, 209);
            button3.Name = "button3";
            button3.Size = new Size(130, 29);
            button3.TabIndex = 6;
            button3.Text = "A x B";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 9;
            label1.Text = "Изменение множества A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 114);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 10;
            label2.Text = "Изменение множества B";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 300);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(584, 27);
            textBox5.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 300);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 12;
            label3.Text = "Ответ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 14);
            label4.Name = "label4";
            label4.Size = new Size(560, 20);
            label4.TabIndex = 13;
            label4.Text = "Примечание: добавление отмечается галочкой, удаление отсутствием галочки";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(33, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "добавление";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(33, 144);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 24);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "добавление";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button4
            // 
            button4.Location = new Point(309, 82);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 16;
            button4.Text = "Изменить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(310, 145);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 17;
            button5.Text = "Изменить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(384, 209);
            button6.Name = "button6";
            button6.Size = new Size(130, 29);
            button6.TabIndex = 18;
            button6.Text = "B - A";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}