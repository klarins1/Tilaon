using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarDLL;
using CalendarModels;

namespace CalendarBLL
{
    internal class CalendarAppService
    {
        CalendarDataService data = new CalendarDataService();

        public void AddEvent(string name, string date)
        {
            if (name == " "  || date == " " )
            {
                Console.WriteLine("Event Unsuccessfully Added");
                return;
            }

            EventModels e = new EventModels();
            e.name = name;
            e.date = date;

            data.AddEvent(e);

            Console.WriteLine("Event Successfully Added");
        }

        public void ShowEvents()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("SHOW EVENTS");
            data.ShowEvents();
        }
    }

}
