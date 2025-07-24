using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ass2OOP
{
    internal struct PhoneBook
    {
        #region Attributes
        private string[] names;
        private long[] numbers;
        private int size;
        #endregion
        public int Size() { 
            return size;
        }
        public PhoneBook(int _size)
        {
           size = _size;
           names = new string[size];
           numbers = new long[size];
        }

        #region Methods
        public void AddPerson(int position, string name, long number)
        {
            if(names != null && numbers != null)
            {
                if (position >= 0 && position < size)
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
           
        }
        #endregion
        #region using setter and getter
        public long GetPersonNumber(string  name)
        {
            if (names is not  null && numbers is not  null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
            }
            return -1; // or throw an exception
        }
        public void SetPersonNumber(string Name , long NewNumber)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == Name)
                    {
                        numbers[i]= NewNumber;
                        return; // Exit after updating the first match
                    }
                }
            }
        }
        #endregion

        #region indexer
        public long this[string name]
        {
            get
            {
                return GetPersonNumber(name);
            }
            set
            {
                SetPersonNumber(name, value);
            }
        }
        //method to print specfic person data by indexer
        public string this[int index]
        {
            get
            {
               
                    return $"{names[index]}: {numbers[index]}";
               
            }
        }

        #endregion
    }
}
