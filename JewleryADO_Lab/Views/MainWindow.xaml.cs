using AutoMapper;
using JewleryADO_Lab.ViewModels;
using JewleryADO_Lab.Views;
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

namespace JewleryADO_Lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ContextViewModel _contextViewModel;
        private readonly IMapper _mapper;

        public MainWindow(ContextViewModel contextViewModel, IMapper mapper)
        {
            DataContext = contextViewModel;
            _mapper = mapper;
            InitializeComponent();
            GoodsUC.Mapper = mapper;
            GoodsUC.ContextViewModel = contextViewModel;

            MaterialsUC.Mapper = mapper;
            MaterialsUC.ContextViewModel = contextViewModel;

            ClientsUC.Mapper = mapper;
            ClientsUC.ContextViewModel = contextViewModel;

            OrdersUC.Mapper = mapper;
            OrdersUC.ContextViewModel = contextViewModel; 
        }
    }
}
