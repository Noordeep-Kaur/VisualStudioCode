//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bus.Models
{
    using System;
    
    public partial class proc_cancel_Result
    {
        public int TicketID { get; set; }
        public int BusID { get; set; }
        public int BookingUserID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public System.TimeSpan FromTime { get; set; }
        public System.TimeSpan ToTime { get; set; }
        public int TicketBookingStatus { get; set; }
        public int NumberOfSeats { get; set; }
        public int Fare { get; set; }
        public bool PaymentStatus { get; set; }
    }
}
