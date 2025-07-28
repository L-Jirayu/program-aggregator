namespace Program_Aggregator
{
    partial class problem2
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
            label1 = new Label();
            num = new TextBox();
            button1 = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "ใส่ตัวเลข";
            // 
            // num
            // 
            num.Location = new Point(85, 35);
            num.Name = "num";
            num.Size = new Size(297, 23);
            num.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(109, 77);
            button1.Name = "button1";
            button1.Size = new Size(205, 39);
            button1.TabIndex = 2;
            button1.Text = "เช็ค";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(176, 134);
            result.Name = "result";
            result.Size = new Size(80, 30);
            result.TabIndex = 3;
            result.Text = "Result: ";
            // 
            // problem2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 183);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(num);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "problem2";
            Text = "Even and Odd Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num;
        private Button button1;
        private Label result;
    }
}