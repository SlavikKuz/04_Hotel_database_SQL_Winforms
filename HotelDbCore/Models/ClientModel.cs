﻿using System.Collections.Generic;

namespace HotelDB.Domain.Model
{
    public class ClientModel
    {
    public int Id { get; set; }
    public string ClientFullName { get; set; }
    public string Email { get; set; }
    public string Tel { get; set; }
    public string Address { get; set; }
    public string Notes { get; set; }
    public List<BookingModel> BookingsHistory { get; set; } = new List<BookingModel>();
    }
}