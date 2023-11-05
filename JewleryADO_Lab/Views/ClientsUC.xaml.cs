using AutoMapper;
using JewleryADO_Lab.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace JewleryADO_Lab.Views
{
    /// <summary>
    /// Interaction logic for ClientsUC.xaml
    /// </summary>
    public partial class ClientsUC : UserControl
    {
        public ContextViewModel ContextViewModel;
        public IMapper Mapper;
        public ClientsUC()
        {
            InitializeComponent();
        }

        private void InsertEFButton_Click(object sender, RoutedEventArgs e)
        {
            var newViewModel = new ClientViewModel()
            {
                FirstName = FirstNameEFTextBox.Text,
                LastName = LastNameEFTextBox.Text,
                Age = AgeEFTextBox.Text,
            };
            ContextViewModel.Clients.Add(newViewModel);
        }

        private void UpdateEFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldCustomer = (ClientViewModel)ClientsDataGrid.SelectedItem;

                if (oldCustomer == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                var newCustomer = new ClientViewModel
                {
                    Id = oldCustomer.Id,
                    FirstName = FirstNameEFTextBox.Text,
                    LastName = LastNameEFTextBox.Text,
                    Age= AgeEFTextBox.Text,
                };
                ContextViewModel.Clients.Remove(oldCustomer);
                ContextViewModel.Clients.Add(newCustomer);
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
                var oldCustomer = (ClientViewModel)ClientsDataGrid.SelectedItem;

                if (oldCustomer == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                ContextViewModel.Clients.Remove(oldCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }
    }
}
