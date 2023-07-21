namespace QuizGUI
{
    partial class Form4
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
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(424, 256);
            button4.Name = "button4";
            button4.Size = new Size(290, 66);
            button4.TabIndex = 16;
            button4.Text = "158";
            button4.UseVisualStyleBackColor = true;
            button4.Click += wrong3_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(424, 333);
            button3.Name = "button3";
            button3.Size = new Size(290, 66);
            button3.TabIndex = 15;
            button3.Text = "2877";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Correct1_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(100, 333);
            button2.Name = "button2";
            button2.Size = new Size(311, 66);
            button2.TabIndex = 14;
            button2.Text = "1277";
            button2.UseVisualStyleBackColor = true;
            button2.Click += wrong2_click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(100, 256);
            button1.Name = "button1";
            button1.Size = new Size(311, 66);
            button1.TabIndex = 13;
            button1.Text = "2777";
            button1.UseVisualStyleBackColor = true;
            button1.Click += wrong1_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-3, 39);
            label1.Name = "label1";
            label1.Size = new Size(830, 106);
            label1.TabIndex = 17;
            label1.Text = "QUANTO FA 137 x 21?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 70F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 20);
            label2.Name = "label2";
            label2.Size = new Size(513, 125);
            label2.TabIndex = 18;
            label2.Text = "BRAVO FIO";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 30);
            label3.Name = "label3";
            label3.Size = new Size(781, 81);
            label3.TabIndex = 19;
            label3.Text = "STUDIA CAPRA IGNORANTE";
            label3.Click += label3_Click;
            label3.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}