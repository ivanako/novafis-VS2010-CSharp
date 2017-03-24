using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    //[TypeDescriptionProvider(typeof(
    public class Patient : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _surname1;
        private string _surname2;
        private string _identification;
        private DateTime _entryDate;
        private string _heardAboutUs;
        private char _gender;
        private Nullable<DateTime> _birthDate;
        private bool _blackList;
        private bool _isDeleted;
        private Physiotherapist _physio;
        private Source _source;
        private Address _address;
        private List<Cancellation> _cancellations;
        private List<Observation> _observations;
        private List<Treatment> _treatments;

        [DisplayName("Matrícula")]
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
        [DisplayName("Fecha Registro")]
        public DateTime EntryDate
        {
            get { return _entryDate; }
            set
            {
                _entryDate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EntryDate"));
            }
        }
        [DisplayName("Cómo nos conoció")]
        public string HowHeardAboutUs
        {
            get { return _heardAboutUs; }
            set
            {
                _heardAboutUs = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("HowHeardAboutUs"));
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
        [DisplayName("Fecha Nacimiento")]
        public Nullable<DateTime> DateOfBirth
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("DateOfBirth"));
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
        [DisplayName("Lista negra")]
        public bool BlackList
        {
            get { return _blackList; }
            set
            {
                _blackList = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("BlackList"));
            }
        }
        [DisplayName("Eliminado")]
        public bool Deleted
        {
            get { return _isDeleted; }
            set
            {
                _isDeleted = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Deleted"));
            }
        }

        public Physiotherapist Physiotherapist
        {
            get { return _physio; }
            set 
            {
                _physio = value;
            }
        }

        public Source Source
        {
            get { return _source; }
            set 
            {
                _source = value;
            }
        }


        [DisplayName("Fuente")]
        public string SourceDesc
        {
            get 
            {
                string srcDesc = string.Empty;

                if (Source != null)
                {
                    srcDesc = Source.Description;
                }

                return srcDesc;
            }
        }

        [DisplayName("Fisio Referencia")]
        public string PhysiotherapistName
        {
            get { return Physiotherapist.FullName; }
        }

        [DisplayName("Domicilio")]
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [DisplayName("Anulaciones")]
        public List<Cancellation> Cancellations
        {
            get { return _cancellations; }
            set { _cancellations = value; }
        }

        [DisplayName("Observaciones")]
        public List<Observation> Observations
        {
            get { return _observations; }
            set { _observations = value; }
        }

        [DisplayName("Tratamientos")]
        public List<Treatment> Treatments
        {
            get { return _treatments; }
            set { _treatments = value; }
        }

        [DisplayName("Observación permanente")]
        public string PermanentObs
        {
            get 
            {
                string permObs = string.Empty;

                if (this.Observations != null)
                {
                    if (this.Observations.Count > 0)
                    {
                        permObs = this.Observations.First<Observation>().Description;
                    }
                }

                return permObs; 
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
