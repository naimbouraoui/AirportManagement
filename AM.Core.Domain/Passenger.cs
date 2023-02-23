using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public  class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        //public int Age { get; set; }
        public IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "BirthDate:" + BirthDate 
                + ";PassportNumber:" + PassportNumber 
                + ";EmailAddress:" + EmailAddress + ";FirstName:" 
                + FirstName + ";LastName:" + LastName + ";Telnumber:" 
                + TelNumber;
        }
        ///Tp1.Q11.A
        ///public bool CheckProfile(String firstname, String lastname)
        ///{
        ///  return FirstName==firstname && LastName==lastname ;
        ///}
        ///TP1.Q11.B
        ///public bool CheckProfile(String firstname, String lastname,String emailaddress)
        ///{
           /// return EmailAddress==emailaddress && LastName==lastname && FirstName==firstname ;
        ///}
        ///tp1.q11.C
        public bool CheckProfile(String firstname, String lastname, String emailaddress=null)
        {
            return EmailAddress == emailaddress && LastName == lastname && FirstName == firstname;
        }
        
        public virtual string GetPassengerType()
        {
            return "I'm passenger";
        }
        int age;
        public int Age
        {
            get
            {
                age = DateTime.Now.Year - BirthDate.Year;
                if (BirthDate.Month > DateTime.Now.Month)
                {
                    age -= 1;
                }
                else if (
             BirthDate.Month == DateTime.Now.Month
                    && BirthDate.Day > DateTime.Now.Day)
                {

                    age--;
                }
                return age;
            }
        }
    }
}
