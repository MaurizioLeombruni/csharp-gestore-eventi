using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGestoreEventi
{
    public class EventSchedule
    {
        private string scheduleTitle;
        private List<Event> scheduleEvents = new List<Event>();

        public EventSchedule(string title)
        {
            SetScheduleTitle(title);
        }

        //GETTERS

        public string GetScheduleTitle()
        { 
            return scheduleTitle;
        }

        //SETTERS
        public void SetScheduleTitle(string title)
        {
            if(title == null || scheduleTitle == string.Empty)
            {
                throw new ArgumentNullException(nameof(title));
            }
            else
            {
                scheduleTitle = title;
            }
        }

        //METODI

        public void AddEventToSchedule(Event e)
        {
            scheduleEvents.Add(e);
        }

        public List<Event> GetEventsByDate(string date)
        {
            try
            {
                List<Event> validEvents = new List<Event>();
                DateTime dateToSearch = DateTime.Parse(date);

                foreach(Event element in scheduleEvents)
                {
                    if(element.GetEventDate() == dateToSearch)
                    {
                        validEvents.Add(element);
                    }
                }
            }
            catch(Exception e)
            {
                throw new ArgumentException(e.Message, nameof(date));
            }
        }
    }
}
