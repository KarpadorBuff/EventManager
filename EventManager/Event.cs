using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class Event
    {
        string Title;
        string Location;
        DateTime Date;
        List<Benutzer> Participants = [];

        public Event(string title, string location, DateTime date)
        {
            Title = title;
            Location = location;
            Date = date;
        }

    }
}
