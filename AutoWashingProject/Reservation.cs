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
        string problem;

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

        public Reservation(int id, int autoId, DateTime date, int reservationType, string problem)
        {
            this.autoId = autoId;
            this.date = date;
            this.reservationType = reservationType;
            this.problem = problem;
        }

        public int Id { get; set; }
        public int AutoId { get; set; }
        public int ReservationType { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }
    }
}
