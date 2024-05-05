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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            button2 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 254);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 1;
            label1.Text = "Кнопка откроет склад";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 103);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Кнопка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.Location = new Point(562, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(827, 678);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "1";
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 600;
            // 
            // columnHeader3
            // 
            columnHeader3.Width = 600;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1366, 617);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Склад";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
