using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
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
                if(enter.Text != confirm.Text)
                {
                    throw new Exception("Пароли не совпадают");
                }
                if(enter.Text.Length <6 || enter.Text.Length > 12)
                {
                    throw new Exception("Пароль не должен быть менее 6 символов или превышать 12");
                }
                Regex r = new Regex(@"\d");
                if (!(r.IsMatch(enter.Text.ToString())))
                {
                    throw new Exception("Пароль должен содержать хотя бы одну цифру");
                }
                Regex rsym = new Regex(@"[a-zA-Z]");
                if (!(rsym.IsMatch(enter.Text.ToString())))
                {
                    throw new Exception("Пароль должен содержать хотя бы одну букву");
                }
                else {
                    MessageBox.Show("Успех!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
