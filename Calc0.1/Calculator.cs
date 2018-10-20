using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calc0._1
{
    public class Calculator : INotifyPropertyChanged
    {
        private string previousOperations;
        private string result;

        public string PreviousOperations
        {
            get { return PreviousOperations; }
            set
            {
                PreviousOperations = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public string Result
        {
            get { return Result; }
            set
            {
                Result = value;
                OnPropertyChanged();
            }
        }
        
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void GetResult(string s)
        {
            if(s == "+")
            {

            }
        }
    }
}
