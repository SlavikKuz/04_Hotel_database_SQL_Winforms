﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDb.DataLayer.Entities
{
    public class GuestListDL
    {
        public Guid ClientId { get; set; }
        public ClientDL Guest { get; set; }

        public Guid BookingId { get; set; }
        public BookingDL Booking { get; set; }

    }
}
