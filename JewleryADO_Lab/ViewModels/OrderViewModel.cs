using System;
using System.Configuration;

namespace JewleryADO_Lab.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        private double _total;
        public double Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        public DateTime _orderDate;
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                _orderDate = value;
                OnPropertyChanged("DateTime");
            }
        }
    }
}
