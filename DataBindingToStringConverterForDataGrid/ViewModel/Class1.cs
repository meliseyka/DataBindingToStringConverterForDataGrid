using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingToStringConverterForDataGrid.ViewModel
{
    /// <summary>
    /// Предполагается использовать этот класс для заполнения DataGrid строками через XAML. 
    /// Подробнее https://stackoverflow.com/questions/18495471/adding-rows-to-datagrid-through-xaml
    /// Почти получилось реализовать, но столкнулся с проблемой преобразования Data.Binding в System.String при Value={Binding MyClass.MyProperty}
    /// </summary>
    public class Dummy : BaseInpc
    {

        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }


        private string _Value;
        public string Value { get => _Value; set => Set(ref _Value, value); }

    }
}
