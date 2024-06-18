using DataBindingToStringConverterForDataGrid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace DataBindingToStringConverterForDataGrid.ViewModel
{
    public class VM : BaseInpc
    {
        private MyRectangle _Rectangle;
        public MyRectangle Rectangle { get => _Rectangle; set => Set(ref _Rectangle, value); }

        public VM()
        {
            Rectangle = new MyRectangle("МойПрямоугольник", 10, 15);
        }
    }
}
