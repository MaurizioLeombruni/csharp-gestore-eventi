using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGestoreEventi
{
    public class EventConference : Event
    {
        private string conferenceSpeaker;
        private double conferencePrice;
        public EventConference(string eventTitle, string eventDate, int eventCapacity, string conferenceSpeaker, double conferencePrice) : base(eventTitle, eventDate, eventCapacity)
        {
            this.conferenceSpeaker = conferenceSpeaker;
            this.conferencePrice = conferencePrice;
        }

        //GETTERS

        public string GetConferenceSpeaker()
        {
            return conferenceSpeaker;
        }

        public double GetConferencePrice()
        {
            return conferencePrice;
        }

        //SETTERS

        public void SetConferenceSpeaker(string conferenceSpeaker)
        {
            if(conferenceSpeaker== null || conferenceSpeaker.Length == 0)
            {
                throw new ArgumentException(conferenceSpeaker, nameof(conferenceSpeaker));
            }
            else
            {
                this.conferenceSpeaker = conferenceSpeaker;
            }
        }

        public void SetConferencePrice(double conferencePrice)
        {
            if(conferencePrice < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(conferencePrice));
            }
            else
            {
                this.conferencePrice = Math.Round(conferencePrice, 2);
            }
        }

        public override string ToString()
        {
            string conferenceInfo = eventDate.ToShortDateString() + " - " + eventTitle + " - " + GetConferenceSpeaker() + " - "  + GetConferencePrice().ToString("N2") + " euro";

            return conferenceInfo;
        }
    }
}
