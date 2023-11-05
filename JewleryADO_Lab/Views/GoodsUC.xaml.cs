using AutoMapper;
using JewleryADO_Lab.ViewModels;
using Microsoft.Data.SqlClient;
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

namespace JewleryADO_Lab.Views
{
    /// <summary>
    /// Interaction logic for GoodsUC.xaml
    /// </summary>
    public partial class GoodsUC : UserControl
    {
        public ContextViewModel ContextViewModel;
        public IMapper Mapper;
        public GoodsUC()
        {
            InitializeComponent();
        }

        private void InsertADOButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=JewleryADO_db;Trusted_Connection=True;"))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Goods (Name, Price, MaterialId) VALUES (@Name, @Price, @MaterialId)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", NameADOTextBox.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToInt32(PriceADOTextBox.Text));
                    command.Parameters.AddWithValue("@MaterialId", 1);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void UpdateADOButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldGood = (GoodViewModel)GoodsDataGrid.SelectedItem;

                if (oldGood == null)
                {
                    MessageBox.Show("Please choose a project you want to update!", "Alert");
                    return;
                }

                using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=JewleryADO_db;Trusted_Connection=True;"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Goods SET Name = @Name, Price = @Price WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", oldGood.Id);
                        command.Parameters.AddWithValue("@Name", NameADOTextBox.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToInt32(PriceADOTextBox.Text));

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }

        private void DeleteADOButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldGood = (GoodViewModel)GoodsDataGrid.SelectedItem;

                if (oldGood == null)
                {
                    MessageBox.Show("Please choose a project you want to delete!", "Alert");
                    return;
                }

                using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=JewleryADO_db;Trusted_Connection=True;"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Goods WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", oldGood.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }

    }
}
