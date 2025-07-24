using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2OOP
{
    internal struct Employee
    {
        #region Attributes
        private int Id;
        private string Name;
        private Decimal Salary;



        #endregion
        #region Constructor
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            salary = salary;
        }

        #endregion
        #region Methods
        public override string ToString()
        { 
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:C}";
        }
        #endregion
        #region 1. Apply Encapsulation using Setters and Getters
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
             Name = name.Length>10? name.Substring(0,10):name;
           
        }
        #endregion
        #region 2. Apply Encapsulation using Properties
        #region full property | propfull + tab + tab
        //when you need to apply validation 
        //propfull + tab
        public decimal Salaryproperty
        {
            get { return Salary; }
            set
            {
               Salary= value < 10000 ? 5000 : value;
            }
        }


        #endregion
        #region auto property | prop + tab + tab
        //when you don't need to apply validation
        //prop + tab
        public int Age { get; set; }
  

       

        #endregion
        #endregion




    }
}
