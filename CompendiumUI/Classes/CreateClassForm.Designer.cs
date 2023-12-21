namespace CompendiumUI
{
    partial class CreateClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Class Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(201, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 26);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Source";
            // 
            // button1
            // 
            button1.Location = new Point(340, 24);
            button1.Name = "button1";
            button1.Size = new Size(152, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Source";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "Hit Dice";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 113);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 6;
            label1.Text = "Proficiency";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 113);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 7;
            label2.Text = "Saving Throw";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 143);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 22);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(30, 180);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 9;
            button2.Text = "Features";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(26, 223);
            button3.Name = "button3";
            button3.Size = new Size(183, 23);
            button3.TabIndex = 10;
            button3.Text = "Scaling Resources";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(26, 263);
            button4.Name = "button4";
            button4.Size = new Size(177, 23);
            button4.TabIndex = 11;
            button4.Text = "Multiclassing";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 301);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(599, 142);
            textBox3.TabIndex = 12;
            textBox3.Text = "Description";
            // 
            // CreateClassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(681, 466);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CreateClassForm";
            Text = "Create Class";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
    }
}