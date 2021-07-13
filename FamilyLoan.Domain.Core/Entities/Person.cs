using FamilyLoan.Domain.Core.Common;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Core.Entities
{
    public  class Person : BaseEntity
    {
        public Person()
        {

        }
        public int ID{ get; set; }

        public string Name { get; set; }

        public int AccountIDNo { get; set; }
        public string AccountNo { get; set; }

        public string Family { get; set; }

        public bool Gender { get; set; }

        public DateTime Birthdate { get; set; }

        public string Mobile { get; set; }

        public Loan loan { get; set; }

        public string ProfileImage { get; set; }

        public List<Account> Account { get; set; }
        private string _fullName;
        public string FullName 
        {
            get 
            {
                return _fullName; 
            }
            set
            {
                _fullName = value;
            }
        }
     
        public string Title=>Gender ? "مرد" : "زن";
            
        public byte Age=> Birthdate.CalculateAge();
     
       

        public string PersianBirthDate=> Birthdate.ToPersianDate();
    

        public string FormalFullName=> (Gender ? "جناب آقای " : "سرکار خانم ") + FullName;
      
     

      

    }
}
