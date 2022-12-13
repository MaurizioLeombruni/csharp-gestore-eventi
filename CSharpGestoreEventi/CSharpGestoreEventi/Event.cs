using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGestoreEventi
{
    public class Event
    {
        private string eventTitle;
        private string eventDate;
        private string eventCapacity;
        private string eventPreorders;

        public Event(string eventTitle, string eventDate, string eventCapacity, string eventPreorders)
        {
            //placeholder

            this.eventTitle = eventTitle;
            this.eventDate = eventDate;
            this.eventCapacity = eventCapacity;
            this.eventPreorders = eventPreorders;
        }

        //GETTERS

        public string GetEventTitle()
        {
            return this.eventTitle;
        }

        public string GetEventDate()
        {
            return this.eventDate;
        }

        public string GetEventCapacity()
        {
            return this.eventCapacity;
        }

        public string GetEventPreorders()
        {
            return this.eventPreorders;
        }
    }
}
