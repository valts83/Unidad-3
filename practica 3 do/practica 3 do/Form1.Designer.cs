namespace practica_3_do
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.Location = new Point(432, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "AÑADIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepPink;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 35);
            label1.Name = "label1";
            label1.Size = new Size(600, 31);
            label1.TabIndex = 1;
            label1.Text = "ESTE PROGRAMA SUMA LOS NUMEROS CAPTURADOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 139);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 2;
            label2.Text = "introduce un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 340);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 3;
            label3.Text = "las suma de todos son:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(432, 333);
            textBox2.MaxLength = 20;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.TabStop = false;
            
            // 
            // listBox1
            // 
            listBox1.ColumnWidth = 20;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(638, 162);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(150, 224);
            listBox1.TabIndex = 20;
            listBox1.Tag = "";
            // 
            // button2
            // 
            button2.BackColor = Color.Magenta;
            button2.Location = new Point(72, 299);
            button2.Name = "button2";
            button2.Size = new Size(134, 80);
            button2.TabIndex = 7;
            button2.Text = "suma de los numeros";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Label label4;
        private Button button2;
    }
}
