using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Invoice : INotifyPropertyChanged
    {
        private int _id;
        private string _invNumber;
        private DateTime _date;
        private string _identification;
        private string _to;
        private byte _sessions;
        private string _treat;
        private double _amount;

        private Patient _pat;
        private Physiotherapist _phy;


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
        [DisplayName("Número Factura")]
        public string InvoiceNumber
        {
            get { return _invNumber; }
            set
            {
                _invNumber = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("InvoiceNumber"));
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
        [DisplayName("Otro")]
        public string Client
        {
            get { return _to; }
            set
            {
                _to = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Client"));
            }
        }
        [DisplayName("Cliente")]
        public string ClientName
        {
            get 
            {
                string clientName;

                if (Patient == null)
                {
                    clientName = Client;
                }
                else
                {
                    clientName = Patient.FullName;
                }

                return clientName; 
            }
        }
        [DisplayName("Sesiones")]
        public byte Sessions
        {
            get { return _sessions; }
            set
            {
                _sessions = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Identification"));
            }
        }
        [DisplayName("Tratamiento")]
        public string Treatment
        {
            get { return _treat; }
            set
            {
                _treat = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Treatment"));
            }
        }
        [DisplayName("Importe")]
        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Amount"));
            }
        }



        [DisplayName("Paciente")]
        public Patient Patient
        {
            get { return _pat; }
            set 
            { 
                _pat = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Patient"));
            }
        }
        [DisplayName("Fisio")]
        public Physiotherapist Physio
        {
            get { return _phy; }
            set { _phy = value; }
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
