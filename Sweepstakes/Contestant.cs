using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        int firstRegisterNumber = 1000;

        public Contestant()
        {
            string firstName = UI.first;
            string lastName = UI.last;
            string emailAddress = UI.email;
            int registrationNumber = UI.registrationNumber;
        }

       
    }
}
