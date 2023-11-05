using AutoMapper;
using JewleryADO_Lab.ViewModels;
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
    /// Interaction logic for OrdersUC.xaml
    /// </summary>
    public partial class OrdersUC : UserControl
    {
        public ContextViewModel ContextViewModel;
        public IMapper Mapper;
        public OrdersUC()
        {
            InitializeComponent();
        }

        private void InsertEFButton_Click(object sender, RoutedEventArgs e)
        {
            var newViewModel = new OrderViewModel()
            {
                Total = Convert.ToDouble(TotalEFTextBox.Text),
                OrderDate = Convert.ToDateTime(DateTimeEFTextBox.Text),
            };
            ContextViewModel.Orders.Add(newViewModel);
        }

        private void UpdateEFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldOrder = (OrderViewModel)OrdersDataGrid.SelectedItem;

                if (oldOrder == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                var newOrder = new OrderViewModel
                {
                    Id = oldOrder.Id,
                    Total = Convert.ToDouble(TotalEFTextBox.Text),
                    OrderDate = Convert.ToDateTime(TotalEFTextBox.Text),
                };
                ContextViewModel.Orders.Remove(oldOrder);
                ContextViewModel.Orders.Add(newOrder);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }

        private void DeleteEFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldOrder = (OrderViewModel)OrdersDataGrid.SelectedItem;

                if (oldOrder == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                ContextViewModel.Orders.Remove(oldOrder);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }
    }
}
