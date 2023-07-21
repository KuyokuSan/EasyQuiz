namespace QuizGUI
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
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(189, 181);
            button1.Name = "button1";
            button1.Size = new Size(368, 129);
            button1.TabIndex = 0;
            button1.Text = "Inizia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Accetto i";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(92, 52);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Termini e Condizioni";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(590, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 225);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, -2);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 6;
            label2.Text = "v pre-release 1.8";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 24);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "By KuyoDev";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.download__2_;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}