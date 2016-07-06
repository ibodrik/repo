using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        enum EmpType : byte
        {
            Manager = 1,
            Grunt = 2,
            Contractor = 3,
            VicePresident = 4
        }
        static void Main(string[] args)
        {

            Console.WriteLine("**** Fun with Enums *****");
            // Создать тип подрядчика.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            // Вывести тип хранилища, используемый в перечислении.
            System.Type eType;
            eType = emp.GetType();
            Console.WriteLine("EmpType uses а {0} for storage",
            Enum.GetUnderlyingType(emp.GetType()));
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(emp);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();

        }
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options in stead ? ");
                    //He желаете ли взамен фондовые опционы?
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding . . . ");
                    // Вы, наверное, шутите...
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash . . . ");
                    // Вы уже получаете вполне достаточно. . .
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    // Очень хорошо, сэр!
                    break;
            }
        }
        // Этот метод выводит детали любого перечисления,
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}",e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
            Enum.GetUnderlyingType(e.GetType()));
            // Получить все пары "имя/значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Вывести строковое имя и ассоциированное значение,
            // используя флаг формата D (см. главу 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
