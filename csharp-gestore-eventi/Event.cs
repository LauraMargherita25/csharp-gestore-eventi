using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Event
    {
        private string title;
        private DateTime date;
        private int seats;
        private int reservedSeats;


        public Event (string title, DateTime date, int seats, int reservedSeats)
        {
            this.Title = title;
            this.Date = date;
            this.Seats = seats;
            this.ReservedSeats = reservedSeats;
            
        }

        public string Title {
            get { return this.title; } 
            set 
            { 
                this.title = value;

                if (this.title == null)
                {
                    throw new ArgumentNullException("title");
                }
            } 
        }
        public DateTime Date {
            get { return this.date; }
            set { 
                this.date = value;
                
                DateTime today = DateTime.Today;
                int res = DateTime.Compare(value, today);
                if (res < 0)
                {
                    throw new InvalidOperationException();
                }
            } 
        }
        public int Seats {
            get { return this.seats } 
            private set { 
                this.seats = value;
                
                if(this.seats < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            } 
        }
        public int ReservedSeats { get; private set; } = 0;
        
    }
}
