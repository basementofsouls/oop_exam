using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Student_name_age
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
            Regex r = new Regex(@"^[0-9]*$");
            using (Model1 db = new Model1())
            {
                if (textBoxID.Text == string.Empty)
                {
                    var query = from t in db.Students
                                select t.name;
                    string names = "";
                    foreach (var item in query)
                    {
                        names += item.ToString() + "\n";
                    }
                    MessageBox.Show(names);
                }
                else
                {
                    int id = 0;
                    try
                    {
                        if(r.IsMatch(textBoxID.Text)) {
                            id = Convert.ToInt32(textBoxID.Text);
                        }
                        else
                        {
                            throw new Exception("Неверный формат");
                        }
                        var query = from t in db.Students
                                    where t.id == id
                                    select t.name;
                        if (query.Any() == false)
                        {
                            throw new Exception("Данные не найдены");
                        }
                        foreach (var item in query)
                        {
                            MessageBox.Show(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
              
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]*$");
            using (Model1 db = new Model1())
            {
                if (textBoxID.Text == string.Empty)
                {
                    var query = from t in db.Students
                                select t.age;
                    string names = "";
                    foreach (var item in query)
                    {
                        names += item.ToString() + "\n";
                    }
                    MessageBox.Show(names);
                }
                else
                {
                    int id = 0;
                    try
                    {
                        if (r.IsMatch(textBoxID.Text))
                        {
                            id = Convert.ToInt32(textBoxID.Text);
                        }
                        else
                        {
                            throw new Exception("Неверный формат");
                        }
                        var query = from t in db.Students
                                    where t.id == id
                                    select t.age;
                        if (query.Any() == false)
                        {
                            throw new Exception("Данные не найдены");
                        }
                        foreach (var item in query)
                        {
                            MessageBox.Show(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }
    }
}
