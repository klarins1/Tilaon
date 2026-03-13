using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarModels;
using CalendarBLL;

namespace CalendarDLL
{
    internal class CalendarDataService
    {
        EventModels[] events = new EventModels[100];
        int x = 0;

        public void AddEvent(EventModels e)
        {
            events[x] = e;
            x++;
        }

        public void ShowEvents()
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Event: {events[i].name}");
                Console.WriteLine($"Date: {events[i].date}");
                Console.WriteLine();
            }
        }
    }
}
 
