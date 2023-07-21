using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            label3.Visible = false;
            label2.Visible = true;
            new Form2().Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label4.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            label3.Visible = false;
            new Form3().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            label3.Visible = false;
            label2.Visible = true;
            new Form2().Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Visible = true;
            var t = Task.Delay(1000);
            t.Wait();
            label3.Visible = false;
            label2.Visible = true;
            new Form2().Show(); this.Close();
        }
    }
}
