using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroTour_AggregateRoot.Entities;

namespace AgroTour_DTO
{
    public class BookingDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public string? Phone { get; set; }

        public double TotalCost { get; set; }
        public string? Status { get; set; }

        public DateTime BookingDate { get; set; }

        public Location LocationName { get; set; }
        public DateOnly Date { get; set; }

        public bool IsPaymentSuccessful { get; set; } = false;
        public DateTime PaymentDate { get; set; }

        public string? StripeSessionId { get; set; }
        public string? StripePaymentIntentId { get; set; }

    }
}
