namespace jop
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
            button2 = new Button();
            listView1 = new ListView();
            Абоба = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(206, 39);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(175, 36);
            button2.TabIndex = 3;
            button2.Text = "Добавить товар";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ScrollBar;
            listView1.BackgroundImageTiled = true;
            listView1.Columns.AddRange(new ColumnHeader[] { Абоба, columnHeader1, columnHeader2 });
            listView1.GridLines = true;
            listView1.Location = new Point(629, 0);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(471, 970);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Абоба
            // 
            Абоба.Text = "Товар";
            Абоба.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Кол-во ";
            columnHeader2.Width = 150;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // button1
            // 
            button1.Location = new Point(206, 106);
            button1.Name = "button1";
            button1.Size = new Size(175, 34);
            button1.TabIndex = 5;
            button1.Text = "Удалить товар";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(206, 169);
            button3.Name = "button3";
            button3.Size = new Size(175, 34);
            button3.TabIndex = 6;
            button3.Text = "Изменить товар";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 503);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 448);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 561);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 31);
            textBox3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 266);
            label1.Name = "label1";
            label1.Size = new Size(310, 125);
            label1.TabIndex = 10;
            label1.Text = "Для добавления в таблицу значений\r\nвведите х в отведённые поля\r\n1.Товар\r\n2.id\r\n3. Количество";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 677);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(listView1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Склад";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        protected ColumnHeader Абоба;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
    }
}
