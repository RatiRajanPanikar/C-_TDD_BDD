
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Patient
    {
        //Empty constructor
        public Patient()
        {

        }

        //Constructor with parameter
        public Patient(int patientID, string _insuranceID)
        {
            PatientID = patientID;
            InsuranceID = _insuranceID;


        }

        //Fields to manipulate data in Patient type
        public int PatientID { get; private set; }

        public string InsuranceID { get; private set; }

        public string PlanName { get; set; }

        public string InsuranceCompany { get; set; }

        public static int Count { get; set; }

        private string _displayInsuranceInfo;

        

        public string DisplayInsuranceInfo {

            get { return "The name of the Insurance Company is: " + InsuranceCompany + " " + "The Plan Type is: " + PlanName; }

            set { _displayInsuranceInfo = value; }
        }

        //Method to Calculate Total service charges incurred
        public void CalcTotalServicePaid(int patID)
        { 
        var paidByPatient = new List<Double>() { 564.90, 778.0, 677.90 };

        var paidByInsurance = new Double[] { 6577.00, 667.90, 98.90 };

            



            double TotalPatient = 0;
            foreach (double pByPat in paidByPatient)
            {

                TotalPatient += pByPat;
                //return TotalPatient;
            }

            double TotalInsurance = 0;
            foreach (Double pByIns in paidByInsurance)
            {
                TotalInsurance += pByIns;
            }
            PatientID = patID;

            

            if (patID < 0)
            {
                
            }

        }

        public Boolean IfNullBlank()
        {
            var null_blank = false;

            null_blank = string.IsNullOrWhiteSpace(PlanName)
                || string.IsNullOrWhiteSpace(InsuranceCompany);

            return null_blank;
        }
        //overloading
        public Patient Display(int PatientID)
        {
            return new Patient();
        }

        //overloading
        public List<Patient> Display()
        {
        
                 return new List<Patient>();
        }

       
        
        

    }
}
