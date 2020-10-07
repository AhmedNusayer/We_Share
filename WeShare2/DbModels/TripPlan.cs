using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeShare2.DbModels
{

    [Table("trip_plan")]
    public class TripPlan
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("pickup_address")]
        public string PickupAddress { get; set; }

        [Column("destination_address")]
        public string DestinationAddress { get; set; }

        [Column("pickup_time")]
        public DateTime PickupTime { get; set; }

        [Column("available_seat")]
        public int AvailableSeat { get; set; }

  }
}
