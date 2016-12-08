using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;

namespace Objects
{
    public class Physiotherapist : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _surname1;
        private string _surname2;
        private string _alias;
        private string _identification;
        private DateTime _entryDate;
        private Nullable<DateTime> _terminationDate;
        private string _licenseNumber;
        private char _gender;
        private string _colour;

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
        public string Name 
        {
            get { return _name; }
            set 
            {
                _name = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Name")); 
            } 
        }
        [DisplayName("Primer Apellido")]
        public string Surname1 
        {
            get { return _surname1; }
            set 
            {
                _surname1 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Surname1")); 
            } 
        }
        [DisplayName("Segundo Apellido")]
        public string Surname2 
        {
            get { return _surname2; }
            set 
            {
                _surname2 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Surname2")); 
            }
        }
        [DisplayName("Alias")]
        public string Alias 
        {
            get { return _alias; }
            set 
            {
                _alias = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Alias")); 
            }
        }
        [DisplayName("N.I.F.")]
        public string Identification 
        {
            get { return _identification; }
            set 
            {
                _identification = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Identification")); 
            } 
        }
        [DisplayName("Fecha Alta")]
        public DateTime EntryDate 
        {
            get { return _entryDate; }
            set 
            {
                _entryDate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EntryDate")); 
            }
        }
        [DisplayName("Fecha Baja")]
        public Nullable<DateTime> TerminationDate
        {
            get { return _terminationDate; }
            set
            {
                _terminationDate = value;
                //InvokePropertyChanged(new PropertyChangedEventArgs("TerminationDate"));
            }
        }
        [DisplayName("Número Colegiado")]
        public string LicenseNumber 
        {
            get { return _licenseNumber; }
            set 
            {
                _licenseNumber = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("LicenseNumber")); 
            }
        }
        [DisplayName("Género")]
        public char Gender 
        {
            get { return _gender; }
            set 
            {
                _gender = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Gender")); 
            }
        }
        [DisplayName("Color")]
        public string Colour
        {
            get { return _colour; }
            set
            {
                _colour = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Colour"));
            }
        }

        [DisplayName("Nombre completo")]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}", Name, Surname1, Surname2);
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
