namespace QuizGUI
{
    partial class Form2
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-5, 63);
            label1.Name = "label1";
            label1.Size = new Size(811, 128);
            label1.TabIndex = 9;
            label1.Text = "Quanto fa 13X13?";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(421, 262);
            button4.Name = "button4";
            button4.Size = new Size(286, 62);
            button4.TabIndex = 8;
            button4.Text = "53";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(421, 347);
            button3.Name = "button3";
            button3.Size = new Size(286, 62);
            button3.TabIndex = 7;
            button3.Text = "223";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(86, 347);
            button2.Name = "button2";
            button2.Size = new Size(307, 62);
            button2.TabIndex = 6;
            button2.Text = "169";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(86, 262);
            button1.Name = "button1";
            button1.Size = new Size(307, 62);
            button1.TabIndex = 5;
            button1.Text = "133";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 63);
            label2.Name = "label2";
            label2.Size = new Size(781, 81);
            label2.TabIndex = 10;
            label2.Text = "STUDIA CAPRA IGNORANTE";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(138, 63);
            label3.Name = "label3";
            label3.Size = new Size(545, 106);
            label3.TabIndex = 11;
            label3.Text = "CARICANDO...";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 38);
            label4.Name = "label4";
            label4.Size = new Size(653, 159);
            label4.TabIndex = 12;
            label4.Text = "BRAVO FIO";
            label4.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}