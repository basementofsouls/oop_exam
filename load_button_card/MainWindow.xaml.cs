using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace load_button_card
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

        public List<Card> cards = new List<Card>();

        public Card card1 = new Card("1233 1234 4556 2166", "Artyom Nevazhnov", "04/25");
        public Card card2 = new Card("1233 1235 4566 2611", "Artyom Neochvazhnov", "04/24");
        public Card card3 = new Card("1289 1265 6566 2666", "Artyom Vazhnov", "04/27");


        private Model1 db;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            //SqlConnection connection;
           
            //string DB_Key = ConfigurationManager.ConnectionStrings["card"].ConnectionString;
            using (db = new Model1())
            {
                //connection.Open();

                //string InputQuery = string.Format(
                //       "insert into Card" +
                //       "(number, name, srok)" +
                //       "Values(" +
                //       "@Number, @Name, @Srok)"
                //       );
                try
                {
                    foreach (Card card in cards)
                    {
                        //using (SqlCommand cmd = new SqlCommand(InputQuery, connection))
                        //{
                        //    cmd.Parameters.AddWithValue("@Number", card.number);
                        //    cmd.Parameters.AddWithValue("@Name", card.name);
                        //    cmd.Parameters.AddWithValue("@Srok", card.srok);
                        //    cmd.ExecuteNonQuery();
                        //}
                        db.Card.Add(card);
                        db.SaveChanges();

                    }
                    //connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 
    } 
}
