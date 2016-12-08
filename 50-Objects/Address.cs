using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Address : INotifyPropertyChanged
    {
        private int _id;
        private string _thoroughfare;
        private string _number;
        private string _block;
        private string _floor;
        private string _stair;
        private string _gate;
        private string _postCode;
        private string _phone1;
        private string _phone2;
        private string _phone3;
        private string _email;
        private string _web;
        private string _city;
        private Province _province;


        [DisplayName("Vía Pública")]
        public string Thoroughfare
        {
            get { return _thoroughfare; }
            set
            {
                _thoroughfare = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Thoroughfare"));
            }
        }
        [DisplayName("Número")]
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Number"));
            }
        }
        [DisplayName("Bloque")]
        public string Block
        {
            get { return _block; }
            set
            {
                _block = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Block"));
            }
        }
        [DisplayName("Piso")]
        public string Floor
        {
            get { return _floor; }
            set
            {
                _floor = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Floor"));
            }
        }
        [DisplayName("Escalera")]
        public string Stair
        {
            get { return _stair; }
            set
            {
                _stair = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Stair"));
            }
        }
        [DisplayName("Puerta")]
        public string Gate
        {
            get { return _gate; }
            set
            {
                _gate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Gate"));
            }
        }
        [DisplayName("Código Postal")]
        public string PostCode
        {
            get { return _postCode; }
            set
            {
                _postCode = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("PostCode"));
            }
        }
        [DisplayName("Teléfono 1")]
        public string Phone1
        {
            get { return _phone1; }
            set
            {
                _phone1 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Phone1"));
            }
        }
        [DisplayName("Teléfono 2")]
        public string Phone2
        {
            get { return _phone2; }
            set
            {
                _phone2 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Phone2"));
            }
        }
        [DisplayName("Teléfono 3")]
        public string Phone3
        {
            get { return _phone3; }
            set
            {
                _phone3 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Phone3"));
            }
        }
        [DisplayName("Correo electrónico")]
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Email"));
            }
        }
        [DisplayName("Sitio Web")]
        public string Web
        {
            get { return _web; }
            set
            {
                _web = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Web"));
            }
        }
        [DisplayName("Municipio")]
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("City"));
            }
        }

        [DisplayName("Provincia")]
        public Province Province
        {
            get { return _province; }
            set
            {
                _province = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Province"));
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
