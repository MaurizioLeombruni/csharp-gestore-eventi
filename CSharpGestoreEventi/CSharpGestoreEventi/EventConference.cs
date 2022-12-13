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

        //Il prezzo viene settato con un double in ingresso. Il valore non può essere minore di zero, ma può essere uguale (conferenze gratis, yay!).
        //Se il valore è valido, viene settato arrotondandolo a 2 cifre decimali.
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

        //L'override restitusce un valore diverso da quello della classe padre Evento.
        //Banalmente aggiunge alla stringa restituita il relatore della conferenza e il prezzo, arrotondato a 2 cifre (se ce n'è bisogno).
        public override string ToString()
        {
            string conferenceInfo = eventDate.ToShortDateString() + " - " + eventTitle + " - " + GetConferenceSpeaker() + " - "  + GetConferencePrice().ToString("N2") + " euro";

            return conferenceInfo;
        }
    }
}
