using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagement.ViewModel
{
    public class PurchaseReportingView
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string Category { set; get; }
        public int SoldQty { set; get; }
        public double Costprice { set; get; }
        public double Salesprice { set; get; }
        public double Profit { set; get; }
    }
}
