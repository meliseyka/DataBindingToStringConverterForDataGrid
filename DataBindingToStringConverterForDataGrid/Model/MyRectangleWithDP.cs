using DataBindingToStringConverterForDataGrid.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingToStringConverterForDataGrid.Model
{
    public class MyRectangleWithDP : DependencyObject
    {



        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(MainWindow), new PropertyMetadata(null));




        public double a
        {
            get { return (double)GetValue(aProperty); }
            set { SetValue(aProperty, value); }
        }

        // Using a DependencyProperty as the backing store for a.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty aProperty =
            DependencyProperty.Register("a", typeof(double), typeof(MainWindow), new PropertyMetadata(0));



        public double b
        {
            get { return (double)GetValue(bProperty); }
            set { SetValue(bProperty, value); }
        }

        // Using a DependencyProperty as the backing store for b.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty bProperty =
            DependencyProperty.Register("b", typeof(double), typeof(MainWindow), new PropertyMetadata(0));



        public double Area
        {
            get { return (double)GetValue(AreaProperty); }
            set { SetValue(AreaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Area.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AreaProperty =
            DependencyProperty.Register("Area", typeof(double), typeof(MainWindow), new PropertyMetadata(0));


        public MyRectangleWithDP(string Name, double a, double b)
        {
            this.Name = Name;

            this.a = a;
            this.b = b;

            Area = a * b;

        }
    }
}
