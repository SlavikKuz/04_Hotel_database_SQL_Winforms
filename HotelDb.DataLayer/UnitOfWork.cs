﻿using HotelDb.DataLayer.Context;
using HotelDb.DataLayer.Entities;
using HotelDb.DataLayer.Interfaces;
using HotelDb.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDb.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private HotelDbContext DataBase { get; }

        private ClientRepository clientsRepository;
        private BookingRepository bookingsRepository;
        private RoomRepository roomsRepository;
        private DayRepository holidaysRepository;
        private GuestRepository guestsRepository;

        public IRepository<ClientDL> Clients
        {
            get
            {
                if (clientsRepository == null)
                    clientsRepository = new ClientRepository(DataBase);
                return clientsRepository;
            }
        }
        public IRepository<BookingDL> Bookings
        {
            get
            {
                if (bookingsRepository == null)
                    bookingsRepository = new BookingRepository(DataBase);
                return bookingsRepository;
            }
        }
        public IRepository<RoomDL> Rooms
        {
            get
            {
                if (roomsRepository == null)
                    roomsRepository = new RoomRepository(DataBase);
                return roomsRepository;
            }
        }
        public IRepository<DayDL> Days
        {
            get
            {
                if (holidaysRepository == null)
                    holidaysRepository = new DayRepository(DataBase);
                return holidaysRepository;
            }
        }
        public IRepository<GuestDL> Guests
        {
            get
            {
                if (guestsRepository == null)
                    guestsRepository = new GuestRepository(DataBase);
                return guestsRepository;
            }
        }

        public UnitOfWork()
        {
            DataBase = new HotelDbContext();
        }

        public void Save()
        {
            DataBase.SaveChanges();
        }

        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}