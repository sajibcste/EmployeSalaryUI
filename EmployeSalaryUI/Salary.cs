using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeSalaryUI
{
    class Salary
    {
        private double Basic;

        public double Basic1
        {
            get { return Basic; }
            set { Basic = value; }
        }
        private double medicalAmount;
        private double ConveryanceAmount;
        private double noOfIncrement = 0;

        public double NoOfIncrement
        {
            get { return noOfIncrement; }
            set { noOfIncrement = value; }
        }

        public Salary(double Basic, double medicalAmount, double ConveryanceAmount)
        {
            // TODO: Complete member initialization
            this.Basic = Basic;
            this.medicalAmount = medicalAmount;
            this.ConveryanceAmount = ConveryanceAmount;
        }
        public double GetMedicalAmount()
        {
            return( Basic * medicalAmount )/ 100;
        }

        public double GetConveryanceAmount()
        {
            return (Basic * ConveryanceAmount) / 100;
        }

        public  String  incrementAmount(double BasicPercentegeToBeIncrease )
        {
            Basic = Basic + (Basic * BasicPercentegeToBeIncrease) / 100;
            noOfIncrement++;
            return ("AMOUNT INCREASE");

        }
        public double GetTotal()
        {
            return Basic+GetMedicalAmount()+GetConveryanceAmount();
        }




        
    }
}
