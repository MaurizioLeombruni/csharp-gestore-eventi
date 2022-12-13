using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGestoreEventi
{
    public class Event
    {
        private string? eventTitle;
        private DateTime eventDate;
        private int eventCapacity;
        private int eventPreorders;

        public Event(string eventTitle, string eventDate, int eventCapacity)
        {
            SetEventTitle(eventTitle);
            SetEventDate(eventDate);
            SetEventCapacity(eventCapacity);

            this.eventPreorders = 0;
        }

        //GETTERS

        public string GetEventTitle()
        {
            if(eventTitle == null)
            {
                return "Non è stato assegnato un titolo all'evento.";
            }
            else
            {
                return eventTitle;
            }
        }

        public DateTime GetEventDate()
        {
            return this.eventDate;
        }

        public int GetEventCapacity()
        {
            return this.eventCapacity;
        }

        public int GetEventPreorders()
        {
            return this.eventPreorders;
        }

        //SETTERS

        public void SetEventTitle(string title)
        {
            if(title == null || title.Length == 0 || title.Trim() == null)
            {
                Console.WriteLine("Il titolo inserito non è valido.");
                throw new ArgumentException(title, nameof(title));
            }
            else
            {
                this.eventTitle = title;
            }
        }

        public void SetEventDate(string date)
        {
            DateTime currentDate = DateTime.Now;

            try
            {
                DateTime inputDate = DateTime.Parse(date);

                if(inputDate <= currentDate)
                {
                    throw new ArgumentException(date, nameof(date));
                }
                else
                {
                    this.eventDate = inputDate;
                }
            }
            catch(Exception e)
            {
                throw new ArgumentException(date, nameof(date));
            }
        }

        private void SetEventCapacity(int capacity)
        {
            if(capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }
            else
            {
                this.eventCapacity = capacity;
            }
        }

        //METODI

        public void AddPreorders(int preorders)
        {
            if(preorders <= 0)
            {
                Console.WriteLine("Il numero inserito non è valido.");
                throw new ArgumentOutOfRangeException(nameof(preorders));
            }

            if((eventPreorders + preorders) > eventCapacity)
            {
                Console.WriteLine("Il numero di posti richiesto non è disponibile.");
                throw new ArgumentOutOfRangeException(nameof(preorders));
            }
            else
            {
                this.eventPreorders += preorders;
                Console.WriteLine("Aggiunti n." + preorders + " posti. Il totale è: " + this.eventPreorders + " posti prenotati.");
            }
        }

        public void CancelPreorders(int preorders)
        {
            if(preorders <= 0)
            {
                Console.WriteLine("Il numero inserito non è valido.");
                throw new ArgumentOutOfRangeException(nameof(preorders));
            }

            if(preorders > this.eventPreorders)
            {
                Console.WriteLine("Il numero di disdette inserito è più grande del numero di posti prenotati. Azzero i posti prenotati.");
                this.eventPreorders = 0;
            }
            else
            {
                this.eventPreorders -= preorders;
            }
        }

        public override string ToString()
        {
            string eventInfo = eventDate + " - " + eventTitle;

            return eventInfo;
        }
    }
}
