using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace tabcontrols
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        int num2 = 0;
        int num1 = 0;

        private string windowTitle;

        public event PropertyChangedEventHandler PropertyChanged;

        public string WindowTitle
        {
            get { return windowTitle; }
            set
            {
                if (windowTitle != value)
                {
                    windowTitle = value;
                    
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Regex r = new Regex(@"\d");

                if (!(r.IsMatch(textBox1.Text)))
                {

                    throw new Exception("Введите число");
                }
                else
                {
                    num1 = Convert.ToInt32(textBox1.Text);

                    WindowTitle = (num1 + num2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Regex r = new Regex(@"\d");

                if (!(r.IsMatch(textBox2.Text)))
                    throw new Exception("Введите число");
                else
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    WindowTitle = (num1 + num2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



       
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }
}
