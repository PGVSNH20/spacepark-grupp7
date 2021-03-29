using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Models
{
    class UserRegistrationEntry
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeOfRegistration { get; set; }
        public string ShipName { get; set; }
        public int ParkingSpace { get; set; }
        public double ParkingFee { get; set; }
        public UserRegistrationEntry()
        {
            TimeOfRegistration = DateTime.Now;
        }
    }
}
