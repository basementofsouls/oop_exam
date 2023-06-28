using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> arr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            arr = new List<int>(10);
            for(int i = 0; i < 10; i++)
            {
                listOfIndexes.Items.Add(i.ToString());
                arr.Add(rand.Next(1, 500));
                listOfValues.Items.Add(arr[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = arr.Max();
            textBoxOfValues.Text = max.ToString();
            textBoxOfIndex.Text = arr.IndexOf(max).ToString();
        }
    }
}
