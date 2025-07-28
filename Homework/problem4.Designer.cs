namespace Program_Aggregator
{
    partial class problem4
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
            listBox1 = new ListBox();
            rand = new Button();
            txtnum = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "เริ่มเกมได้" });
            listBox1.Location = new Point(28, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(287, 228);
            listBox1.TabIndex = 0;
            // 
            // rand
            // 
            rand.Location = new Point(86, 64);
            rand.Name = "rand";
            rand.Size = new Size(154, 37);
            rand.TabIndex = 1;
            rand.Text = "Random Check";
            rand.UseVisualStyleBackColor = true;
            rand.Click += button1_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(38, 26);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(266, 23);
            txtnum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 136);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 3;
            label1.Text = "Ans: ";
            // 
            // button1
            // 
            button1.Location = new Point(240, 157);
            button1.Name = "button1";
            button1.Size = new Size(86, 37);
            button1.TabIndex = 4;
            button1.Text = "Random";
            button1.Click += button1_Click_1;
            // 
            // problem4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtnum);
            Controls.Add(rand);
            Controls.Add(listBox1);
            MaximizeBox = false;
            Name = "problem4";
            Text = "Random Number Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button rand;
        private TextBox txtnum;
        private Label label1;
        private Button button1;
    }
}