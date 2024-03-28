using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


namespace ToDo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window { 
    public MainWindow()
    {
        InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source = 3205EC07\SQLEXPRESS; Initial Catalog = Taskers; Integrated Security = True;");
            connection.Open();
            string cmd = "SELECT * FROM Tasks";
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Tasks");
            dataAdp.Fill(dt);
            TaskList.ItemsSource = dt.DefaultView;
    }
        

        private void Add_button(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
            this.Close();
        }

        private void Delete_button(object sender, RoutedEventArgs e)
        {

        }

        private void Complete_button(object sender, RoutedEventArgs e)
        {

        }
    }
}
