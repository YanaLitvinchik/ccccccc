using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc0._1
{
    class Calculator : INotifyPropertyChanged
    {
        public string current { get; set; }
        public Calculator()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
