using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Cancellation : INotifyPropertyChanged
    {
        private int _id;
        private DateTime _date;
        private string _reason;

        [DisplayName("Identificador")]
        public int Identifier
        {
            get { return _id; }
            set
            {
                _id = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Identifier"));
            }
        }

        [DisplayName("Fecha")]
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Date"));
            }
        }

        [DisplayName("Motivo")]
        public string Reason
        {
            get { return _reason; }
            set
            {
                _reason = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Reason"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
