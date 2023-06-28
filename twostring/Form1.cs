using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twostring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty) throw new Exception("Вы не ввели ничего!");
                string maintext = textBox1.Text;
                int partlenght = maintext.Length/2;
                part1.Text = maintext.Substring(0, (int)partlenght);
                part2.Text = maintext.Substring((int)partlenght);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
