using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName = UI.first;
        public string lastName = UI.last;
        public string emailAddress = UI.email;
        public int registrationNumber;

        int firstRegisterNumber = 1000;

        public Contestant()
        {
            string firstName;
            string lastName;
            string emailAddress;
            int registrationNumber;
        }

        public void GetRegistrationNumber()
        {
            firstRegisterNumber++;
            registrationNumber = firstRegisterNumber;
        }
    }
}
