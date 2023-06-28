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

namespace ExamFinal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Style style1;
        Style style2;
     
        public MainWindow()
        {
            InitializeComponent();

            style1 = this.FindResource("buttonStyle") as Style;
            style2 = this.FindResource("buttonStyle2") as Style;
            
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            if (myButton.Style == style1)
                myButton.Style = style2;
            else if (myButton.Style == style2)
                myButton.Style = style1;
            else
                myButton.Style = style1;
        }

      
    }
}
