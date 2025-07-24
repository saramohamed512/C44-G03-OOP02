namespace ass2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region user defined datatype [Struct]
            //Point p1;
            //p1=new Point(10, 20);
            ////new => just for constructor selection
            //Console.WriteLine(p1);
            #endregion
            #region OOP
            #region encapsulation
            //Employee emp01 = new Employee(1, "John Doe", 50000);
            //Console.WriteLine(emp01);
            //emp01.Name="Johnathan Doe";
            //Console.WriteLine(emp01.GetName());
            //emp01.SetName("Johnathan Doe");
            //Console.WriteLine(emp01.GetName());

            //emp01.Salaryproperty = 8000;
            //Console.WriteLine(emp01.Salaryproperty);

            #endregion
            #region indexer
            PhoneBook Note= new PhoneBook(3);
            Note.AddPerson(0, "Sara", 1234567890);
            Note.AddPerson(1, "Ali", 9876543210);
            Note.AddPerson(2, "Mohamed", 1122334455);
            //Console.WriteLine(Note.GetPersonNumber("Ali"));
            //Note.SetPersonNumber("Sara", 1111111111);
            //Console.WriteLine(Note.GetPersonNumber("Sara"));
            //Note["Mohamed"]= 1234567890;
            Console.WriteLine(Note[2]);

            #endregion
            #endregion
        }
    }
    }
