using AutoMapper;
using JewleryADO_Lab.ViewModels;
using Microsoft.Data.SqlClient;
using System;
using System.Windows;
using System.Windows.Controls;

namespace JewleryADO_Lab.Views
{
    /// <summary>
    /// Interaction logic for MaterialsUC.xaml
    /// </summary>
    public partial class MaterialsUC : UserControl
    {
        public ContextViewModel ContextViewModel;
        public IMapper Mapper;
        public MaterialsUC()
        {
            InitializeComponent();
        }

        private void InsertEFButton_Click(object sender, RoutedEventArgs e)
        {
            var newViewModel = new MaterialViewModel()
            {
                Name = NameEFTextBox.Text,
                Price = Convert.ToInt32(PriceEFTextBox.Text),
                Value = Convert.ToInt32(ValueEFTextBox.Text),
            };
            ContextViewModel.Materials.Add(newViewModel);
        }

        private void UpdateEFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldMaterial = (MaterialViewModel)MaterialsDataGrid.SelectedItem;

                if (oldMaterial == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                var newMaterial = new MaterialViewModel
                {
                    Id = oldMaterial.Id,
                    Name = NameEFTextBox.Text,
                    Price = Convert.ToInt32(PriceEFTextBox.Text),
                    Value = Convert.ToInt32(ValueEFTextBox.Text),
                };
                ContextViewModel.Materials.Remove(oldMaterial);
                ContextViewModel.Materials.Add(newMaterial);
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
                var oldMaterial = (MaterialViewModel)MaterialsDataGrid.SelectedItem;

                if (oldMaterial == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                ContextViewModel.Materials.Remove(oldMaterial);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }
    }
}
