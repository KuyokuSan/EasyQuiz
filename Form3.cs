using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void wrong1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label3.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            new Form3().Show();
            this.Close();
        }

        private void right1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label4.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            new Form4().Show();
            this.Close();
        }

        private void wrong2_click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label3.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            new Form3().Show();
            this.Close();
        }

        private void wrong3_click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label3.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            new Form3().Show();
            this.Close();
        }
    }
}
