using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class VerifyPatientDetails : IpatientDetails
    {
        private ImembershipVerification @object;

        public VerifyPatientDetails(ImembershipVerification @object)
        {
            this.@object = @object;
        }

        public List<string> Validate(PatientDetails details)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(details.PatientFullName))
            {
                errors.Add("Name cannot be blank.");
            }

            if (string.IsNullOrWhiteSpace(details.DateOfBirth))
            {
                errors.Add("Date of Birth is invalid");
            }

            return errors;
        }



    }
}
