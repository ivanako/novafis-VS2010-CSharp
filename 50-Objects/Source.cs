using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Source : INotifyPropertyChanged
    {
        private int _id;
        private string _desc;

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

        [DisplayName("Nombre")]
        public string Description
        {
            get { return _desc; }
            set
            {
                _desc = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Description"));
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
