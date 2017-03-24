using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
    public class Appointment : INotifyPropertyChanged
    {
        private long _id;
        private DateTime _appDate;
        private string _appTime;
        //private Nullable<DateTime> _appRegDate;

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
            get { return _appDate; }
            set
            {
                _appDate = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Date"));
            }
        }
        [DisplayName("Hora")]
        public string Time
        {
            get { return _appTime; }
            set
            {
                _appTime = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Time"));
            }
        }
        
        [DisplayName("Fisio")]
        public string Physio
        {
            get 
            {
                string phyName = string.Empty;

                if (Physiotherapist != null)
                {
                    phyName = Physiotherapist.Alias;
                }

                return phyName; 
            }
        }
        [DisplayName("Paciente")]
        public string PatientName
        {
            get 
            {
                string patName = string.Empty;

                if (Patient != null)
                {
                    patName = Patient.FullName;
                }

                return patName; 
            }
        }
        [DisplayName("Nº Ficha")]
        public Nullable<int> PatientId
        {
            get 
            {
                Nullable<int> patId = null;

                if (Patient != null)
                {
                    patId = Patient.Identifier;
                }

                return patId; 
            }
        }
        [DisplayName("Fuente")]
        public string SourceName
        {
            get
            {
                string srcName = string.Empty;

                if (Patient != null)
                {
                    if (Patient.Source != null)
                    {
                        srcName = Patient.Source.Description;
                    }
                }

                return srcName; 
            }
        }
        [DisplayName("Observación")]
        public string Observation { get; set; }

        [DisplayName("C")]
        public bool IsPaid
        {
            get { return Paid > 0; }
        }
        [DisplayName("D")]
        public bool HasDebt
        {
            get { return Debt > 0; }
        }
        [DisplayName("A")]
        public bool IsCancelled { get; set; }
        [DisplayName("P")]
        public bool HasTreatment
        {
            get
            {
                bool patTreat = false;

                if (Patient != null)
                {
                    Treatment tmt = Patient.Treatments.Where(t => t.Date.Equals(Date)).First<Treatment>();

                    patTreat = !string.IsNullOrWhiteSpace(tmt.Description);
                }

                return patTreat;
            }
        }

        [DisplayName("Cobrada")]
        public double Paid { get; set; }
        [DisplayName("Deuda")]
        public double Debt { get; set; }
        [DisplayName("Motivo Anulación")]
        public string CancellationWhy { get; set; }

        [DisplayName("Paciente")]
        public Patient Patient { get; set; }
        [DisplayName("Fisioterapeuta")]
        public Physiotherapist Physiotherapist { get; set; }
        [DisplayName("Forma de pago")]
        public FormOfPayment FormOfPayment { get; set; }

        [DisplayName("Fecha Registro")]
        public Nullable<DateTime> RegistryDate { get; set; }
        //{
        //    get { return _appRegDate; }
        //}

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
