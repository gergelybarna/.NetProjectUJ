using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWashingProject
{
    public class Auto
    {
        int id, userId;
        string plate, brand, type;

        public Auto() { }

        public Auto(int id, int userId, string plate, string brand, string type) {
            this.id = id;
            this.userId = userId;
            this.plate = plate;
            this.brand = brand;
            this.type = type;
        }

        public Auto(int userId, string plate, string brand, string type)
        {
            this.userId = userId;
            this.plate = plate;
            this.brand = brand;
            this.type = type;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}
