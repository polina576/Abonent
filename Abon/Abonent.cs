using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abon
{
    public class Abonent
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }
        public double Credit { get; set; }
        public double IntercityTime { get; set; }
        public double CityTime { get; set; }

        public Abonent(int id, string lastName, string firstName, string middleName, string address, string creditCardNumber, double credit, double intercityTime, double cityTime)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Address = address;
            CreditCardNumber = creditCardNumber;
            Credit = credit;
            IntercityTime = intercityTime;
            CityTime = cityTime;
        }
    }
}
