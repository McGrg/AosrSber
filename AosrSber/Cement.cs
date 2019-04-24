using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AosrSber
{
    class Cement
    {
        public string Date { get; set; }
        public string DrillNumber { get; set; }
        public string HoleNumber { get; set; }
        public string HoleLenght { get; set; }
        public string StartLevel { get; set; }
        public string FinishLevel { get; set; }
        public string Angle { get; set; }
        public string Volume { get; set; }
        public string Pressure { get; set; }
        public string ConcreteDate { get; set; }
        public string ConcreteNumber { get; set; }

        public Cement(string Date, string DrillNumber, string HoleNumber, string HoleLenght, string StartLevel, string FinishLevel, string Angle, string Volume, string Pressure, string ConcreteDate, string ConcreteNumber)
        {
            this.Date = Date;
            this.DrillNumber = DrillNumber;
            this.HoleNumber = HoleNumber;
            this.HoleLenght = HoleLenght;
            this.StartLevel = StartLevel;
            this.FinishLevel = FinishLevel;
            this.Angle = Angle;
            this.Volume = Volume;
            this.Pressure = Pressure;
            this.ConcreteDate = ConcreteDate;
            this.ConcreteNumber = ConcreteNumber;
        }
    }
}
