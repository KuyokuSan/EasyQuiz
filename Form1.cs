using Microsoft.VisualBasic.FileIO;

namespace QuizGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            var m = new Form2();
            m.Show();
            MessageBox.Show(text: "ciao, benvenuto su easyquiz, speriamo di farti divertire in questo quiz", value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
