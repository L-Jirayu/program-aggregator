namespace Program_Aggregator
{
    partial class problem3
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
            result = new ListBox();
            txtnum = new TextBox();
            btnx = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // result
            // 
            result.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.FormattingEnabled = true;
            result.ItemHeight = 20;
            result.Location = new Point(68, 166);
            result.Name = "result";
            result.Size = new Size(407, 204);
            result.TabIndex = 0;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(97, 27);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(407, 23);
            txtnum.TabIndex = 1;
            // 
            // btnx
            // 
            btnx.Location = new Point(123, 75);
            btnx.Name = "btnx";
            btnx.Size = new Size(286, 48);
            btnx.TabIndex = 2;
            btnx.Text = "Enter";
            btnx.UseVisualStyleBackColor = true;
            btnx.Click += btnx_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "ใส่แม่สูตรคูณ";
            // 
            // problem3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 398);
            Controls.Add(label1);
            Controls.Add(btnx);
            Controls.Add(txtnum);
            Controls.Add(result);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "problem3";
            Text = "Multiplication Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox result;
        private TextBox txtnum;
        private Button btnx;
        private Label label1;
    }
}