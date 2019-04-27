
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HM_Migration
{
    public class Registration
    {
        public Registration()
        {
            using (var contex = new VisitorContext())
            {
                var dateJoin = Convert.ToDateTime(DateTime.Now);
                Console.WriteLine($"Время когда зашел посетителель: {dateJoin}");
                
               
                Console.WriteLine("Введите имя посетителя: ");
                var name = Console.ReadLine();

                Console.WriteLine("Введите номер документа: ");
                var docNumber = Console.ReadLine();


                Console.WriteLine("Введите цель посещения: ");
                var visitPurpose = Console.ReadLine();

                Console.WriteLine("Прошло 3 часа");
                var dateLeave = Convert.ToDateTime(DateTime.Now);
                dateLeave = dateLeave.AddHours(3);
                Console.Write($"Время когда вышел посетителель: {dateLeave}");
                



                
                var visitor = new Visitor
                {
                    DateJoin = dateJoin,
                    DateLeave = dateLeave,
                    Name = name,
                    DocumentNumber = docNumber,
                    VisitPurpose = visitPurpose


                };



                contex.Visitors.Add(visitor);
                contex.SaveChanges();

                

            }
        }
    }
}