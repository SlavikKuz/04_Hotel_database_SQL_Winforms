﻿using AutoMapper;
using HotelDb.DataLayer.Entities;
using HotelDb.Logic.Entities;
using HotelDb.WebUI.Models;
using Microsoft.AspNetCore.Http;

namespace HotelDb.WebUI
{
    public class MapperProfileUI : Profile
    {
        public MapperProfileUI()
        {
            CreateMap<ClientLL, ClientModel>();
            CreateMap<BookingLL, BookingModel>();
            CreateMap<RoomLL, RoomModel>();
            CreateMap<DayLL, HolidayModel>();
            CreateMap<GuestLL, GuestModel>();

            CreateMap<ClientModel, ClientLL>();
            CreateMap<BookingModel, BookingLL>();
            CreateMap<RoomModel, RoomLL>();
            CreateMap<HolidayModel, DayLL>();
            CreateMap<GuestModel, GuestLL>();
        }
    }
}
