using System;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

namespace Goods_DB
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
                if (textboxYear.Text == string.Empty) 
                    throw new Exception("Введите год!");
                Regex r = new Regex(@"^[0-9]{4}$");
                if (!(r.IsMatch(textboxYear.Text))) 
                    throw new Exception("Введите год нормально пожалуйста(4 цифры)");
                SqlConnection connection;
                string DB_Key = ConfigurationManager.ConnectionStrings["ModelGoods"].ConnectionString;
                using (connection = new SqlConnection(DB_Key))
                {
                    connection.Open();
                    string Query = string.Format(
                        "Select * from Goods where good_year =" + "@Year"
                        );

                    using(SqlCommand command = new SqlCommand(Query, connection)) {
                        command.Parameters.AddWithValue("@Year", Convert.ToInt32(textboxYear.Text));
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count == 0) 
                                throw new Exception("NO DATA FOUND");
                            DataGridGoods.ItemsSource = dataTable.DefaultView;
                        }

                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
