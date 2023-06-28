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

namespace EXAM2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int val1 = Convert.ToInt32(value1.Text);
                int val2 = Convert.ToInt32(value2.Text);
                int val3 = Convert.ToInt32(value3.Text);

                average1.Content = ((val1 + val2 + val3) / 3).ToString();


                Stud stud = new Stud(lastname.Text, val1, val2, val3);
                using(Model1 db = new Model1())
                {
                    db.Stud.Add(stud);
                    db.SaveChanges();
                }
                MessageBox.Show("Данные сохранены");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
