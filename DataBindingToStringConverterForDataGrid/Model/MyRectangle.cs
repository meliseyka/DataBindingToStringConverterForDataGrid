using DataBindingToStringConverterForDataGrid.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingToStringConverterForDataGrid.Model
{
    public class MyRectangle : BaseInpc
    {
        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }

        private double _a;
        public double a { get => _a; set => Set(ref _a, value); }

        private double _b;
        public double b { get => _b; set => Set(ref _b, value); }

        private double _Area;
        public double Area { get => _Area; set => Set(ref _Area, value); }

        public MyRectangle(double a, double b)
        {
            this.a = a;
            this.b = b;

            Area = a * b;

        }
    }
}
