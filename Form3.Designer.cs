namespace QuizGUI
{
    partial class Form3
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(414, 233);
            button4.Name = "button4";
            button4.Size = new Size(286, 62);
            button4.TabIndex = 12;
            button4.Text = "12";
            button4.UseVisualStyleBackColor = true;
            button4.Click += wrong2_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(414, 310);
            button3.Name = "button3";
            button3.Size = new Size(286, 62);
            button3.TabIndex = 11;
            button3.Text = "104";
            button3.UseVisualStyleBackColor = true;
            button3.Click += wrong3_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(90, 310);
            button2.Name = "button2";
            button2.Size = new Size(307, 62);
            button2.TabIndex = 10;
            button2.Text = "69";
            button2.UseVisualStyleBackColor = true;
            button2.Click += wrong1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(90, 233);
            button1.Name = "button1";
            button1.Size = new Size(307, 62);
            button1.TabIndex = 9;
            button1.Text = "120";
            button1.UseVisualStyleBackColor = true;
            button1.Click += right1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 69F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-14, 22);
            label1.Name = "label1";
            label1.Size = new Size(835, 107);
            label1.TabIndex = 13;
            label1.Text = "QUANTO FA 960:8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 22);
            label4.Name = "label4";
            label4.Size = new Size(653, 159);
            label4.TabIndex = 14;
            label4.Text = "BRAVO FIO";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 43);
            label3.Name = "label3";
            label3.Size = new Size(781, 81);
            label3.TabIndex = 15;
            label3.Text = "STUDIA CAPRA IGNORANTE";
            label3.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}