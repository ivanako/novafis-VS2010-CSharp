using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Timetable
    {
        private int _id;
        private DateTime _date;
        private string _mornTimeStart;
        private string _mornTimeFinish;
        private Nullable<byte> _mornDuration;
        private string _afterTimeStart;
        private string _afterTimeFinish;
        private Nullable<byte> _afterDuration;
        private Physiotherapist _physio;


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
        [DisplayName("Inicio Mañana")]
        public string MorningTimeStart
        {
            get { return _mornTimeStart; }
            set
            {
                _mornTimeStart = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MorningTimeStart"));
            }
        }
        [DisplayName("Fin Mañana")]
        public string MorningTimeFinish
        {
            get { return _mornTimeFinish; }
            set
            {
                _mornTimeFinish = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MorningTimeFinish"));
            }
        }
        [DisplayName("Duración (min)")]
        public Nullable<byte> MorningDuration
        {
            get { return _mornDuration; }
            set
            {
                _mornDuration = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MorningDuration"));
            }
        }
        [DisplayName("Inicio Tarde")]
        public string AfternoonTimeStart
        {
            get { return _afterTimeStart; }
            set
            {
                _afterTimeStart = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("AfternoonTimeStart"));
            }
        }
        [DisplayName("Fin Tarde")]
        public string AfternoonTimeFinish
        {
            get { return _afterTimeFinish; }
            set
            {
                _afterTimeFinish = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("AfternoonTimeFinish"));
            }
        }
        [DisplayName("Duración (min)")]
        public Nullable<byte> AfternoonDuration
        {
            get { return _afterDuration; }
            set
            {
                _afterDuration = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("AfternoonDuration"));
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
