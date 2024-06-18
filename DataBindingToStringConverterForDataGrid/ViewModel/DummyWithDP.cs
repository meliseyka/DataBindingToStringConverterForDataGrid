using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace DataBindingToStringConverterForDataGrid.ViewModel
{
    /// <summary>
    /// Предполагается использовать этот класс для заполнения DataGrid строками через XAML. 
    /// Подробнее https://stackoverflow.com/questions/18495471/adding-rows-to-datagrid-through-xaml
    /// Почти получилось реализовать, но столкнулся с проблемой преобразования Data.Binding в System.String при Value={Binding MyClass.MyProperty}
    /// </summary>
    public class DummyWithDP : DependencyObject
    {


        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(MainWindow), new PropertyMetadata(null));




        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(MainWindow), new PropertyMetadata(null));



    }
}

