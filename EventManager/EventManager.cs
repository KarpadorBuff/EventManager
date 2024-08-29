using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    internal class EventManager
    {
        
        Event CreateEvent(string title, DateTime date, string location)
        {
            return new Event(title,location,date);
        }
        void RegisterUserToEvent(string username, string eventTitle)
        {

        }
        List<Event> GetEventsByDate(DateTime date)
        {

            return null;
        }
        void CancelEvent(string eventTitle)
        {

        }
    }
}
