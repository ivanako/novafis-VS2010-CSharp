using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Treatment : INotifyPropertyChanged
    {
        private long _id;
        private DateTime _date;
        private string _desc;
        private TreatmentStatus _status;
        private double _paid;
        private double _debt;
        private Location _location;
        private Lesion _lesion;
        private short _sessions;
        private Physiotherapist _physio;


        [DisplayName("Identificador")]
        public long Identifier
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

        [DisplayName("Descripción")]
        public string Description
        {
            get { return _desc; }
            set
            {
                _desc = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Description"));
            }
        }

        [DisplayName("Estado")]
        public string StatusName
        {
            get { return Status.Description; }
        }

        [DisplayName("Pagado")]
        public double Paid
        {
            get { return _paid; }
            set
            {
                _paid = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Paid"));
            }
        }

        [DisplayName("Deuda")]
        public double Debt
        {
            get { return _debt; }
            set
            {
                _debt = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Debt"));
            }
        }

        [DisplayName("Lesión")]
        public string LesionName
        {
            get { return Lesion.Description; }
        }
        [DisplayName("Localización")]
        public string LocationName
        {
            get { return Location.Description; }
        }

        public TreatmentStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
            }
        }

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Lesion Lesion
        {
            get { return _lesion; }
            set { _lesion = value; }
        }

        [DisplayName("Sesiones")]
        public short Sessions
        {
            get { return _sessions; }
            set
            {
                _sessions = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Sessions"));
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

        [DisplayName("Fisio")]
        public string PhysiotherapistName
        {
            get { return Physiotherapist.Alias; }
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
