using AutoMapper;
using Castle.Core.Resource;
using Domain.Entities;
using JewleryADO_Lab.Views;
using Microsoft.Data.SqlClient;
using Persistance;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace JewleryADO_Lab.ViewModels
{
    public class ContextViewModel : BaseViewModel
    {
        private readonly IMapper _mapper;
        private readonly ApplicationContext _context;

        public ContextViewModel(IMapper mapper, ApplicationContext context)
        {
            _mapper = mapper;
            _context = context;

            Clients = _mapper.Map<ObservableCollection<ClientViewModel>>(_context.Clients);
            Goods = SelectUsingADONET(); // ADO Select
            Materials = _mapper.Map<ObservableCollection<MaterialViewModel>>(_context.Materials);
            Orders = _mapper.Map<ObservableCollection<OrderViewModel>>(_context.Orders);
            Clients.CollectionChanged += Clients_CollectionChanged;
            
        }

        private ObservableCollection<ClientViewModel> _clients;
        public ObservableCollection<ClientViewModel> Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged("Clients");
            }
        }

        private ObservableCollection<GoodViewModel> _goods;
        public ObservableCollection<GoodViewModel> Goods
        {
            get { return _goods; }
            set
            {
                _goods = value;
                OnPropertyChanged("Goods");
            }
        }

        private ObservableCollection<MaterialViewModel> _materials;
        public ObservableCollection<MaterialViewModel> Materials
        {
            get { return _materials; }
            set
            {
                _materials = value;
                OnPropertyChanged("Materials");
            }
        }

        private ObservableCollection<OrderViewModel> _orders;
        public ObservableCollection<OrderViewModel> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged("Clients");
            }
        }

        private ClientViewModel _selectedClient;
        public ClientViewModel SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }

        private void Clients_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (var item in e.NewItems)
                    {
                        _context.Clients.Add(_mapper.Map<Client>(item as ClientViewModel));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (var item in e.OldItems)
                    {
                        _context.Clients.Remove(_context.Clients.FirstOrDefault(c => c.Id == (item as ClientViewModel).Id));
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;

            }
        }

        private ObservableCollection<GoodViewModel> SelectUsingADONET()
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=JewleryADO_db;Trusted_Connection=True;";
            var sql = "SELECT * FROM dbo.Goods;";
            var collection = new ObservableCollection<GoodViewModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        collection.Add(new GoodViewModel
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Price = (int)reader["Price"],
                        });
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    return collection;
                }
            }
            return collection;
        }

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleTab = args.ToString();
        }

        private string _visibleTab = "Orders";
        public string VisibleTab
        {
            get { return _visibleTab; }
            set
            {
                _visibleTab = value;
                OnPropertyChanged("VisibleTab");
            }
        }

    }
}
