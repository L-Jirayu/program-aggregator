namespace UdomBet888
{
    partial class problem1
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
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            result = new ListBox();
            SuspendLayout();
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(125, 31);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(404, 23);
            txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(125, 84);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(404, 23);
            txtnum2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(55, 135);
            button1.Name = "button1";
            button1.Size = new Size(154, 48);
            button1.TabIndex = 2;
            button1.Text = "If-Else (เท่ากับไม่เท่ากับ)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 135);
            button2.Name = "button2";
            button2.Size = new Size(154, 48);
            button2.TabIndex = 3;
            button2.Text = "Switch Case (เปิด-ปิดไฟ)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 135);
            button3.Name = "button3";
            button3.Size = new Size(154, 48);
            button3.TabIndex = 4;
            button3.Text = "Loop (ไล่ตัวเลข)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 34);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "ตัวเลข 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 84);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "ตัวเลข 2";
            // 
            // result
            // 
            result.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.FormattingEnabled = true;
            result.ItemHeight = 25;
            result.Location = new Point(71, 212);
            result.Name = "result";
            result.Size = new Size(477, 304);
            result.TabIndex = 7;
            // 
            // problem1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 528);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            MaximizeBox = false;
            Name = "problem1";
            Text = "Condition and Iteration Concept";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtnum2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private ListBox result;
    }
}