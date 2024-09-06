using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroTour_AggregateRoot.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string locationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public int Cost { get; set; }
        public int Capacity { get; set; }

    }
}
