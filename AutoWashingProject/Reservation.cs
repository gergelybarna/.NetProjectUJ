using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWashingProject
{
    class Reservation
    {
        int id, autoId, reservationType;
        DateTime date;

        public Reservation() { }

        public Reservation(int autoId, DateTime date, int reservationType)
        {
            this.autoId = autoId;
            this.date = date;
            this.reservationType = reservationType;
        }

        public Reservation(int id, int autoId, DateTime date, int reservationType) {
            this.id = id;
            this.autoId = autoId;
            this.date = date;
            this.reservationType = reservationType;
        }

        public int Id { get; set; }
        public int AutoId { get; set; }
        public int ReservationId { get; set; }
        public DateTime Date { get; set; }
    }
}
