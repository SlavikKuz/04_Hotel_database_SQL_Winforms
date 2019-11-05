﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HotelDb.Logic;
using HotelDb.Logic.Entities;
using HotelDb.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelDb.WebUI.Controllers
{
    public class ClientModelController : Controller
    {
        private readonly IMapper mapper;
        public ClientModelController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public ActionResult Create()
        {
            return View();
        }               
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientModel client)
        {
            try
            {
                using (var database = new LogicLL())
                    database.AddClient(mapper.Map<ClientLL>(client));

                return RedirectToAction("ShowAll");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Search()
        {
            return View(new List<ClientModel>());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(string searchString)
        {
            if (String.IsNullOrWhiteSpace(searchString))
                return RedirectToAction("Search");

            List<ClientModel> input = null;
            List<ClientModel> output = null;

            using (var database = new LogicLL())
                input = mapper.Map<List<ClientModel>>(database.GetAllClients());

            foreach (ClientModel client in input)
                output = input.Where(x =>
                                   (x.ClientFullName.Contains(searchString)) ||
                                   (x.Address.Contains(searchString)) ||
                                   (x.Email.Contains(searchString)) ||
                                   (x.Notes.Contains(searchString))).ToList();

            return View(output);
        }

        public ActionResult ShowAll()
        {
            List<ClientModel> list = null;

            using (var database = new LogicLL())
                list = mapper.Map<List<ClientModel>>(database.GetAllClients());

            return View(list);
        }

        public ActionResult Edit(int id)
        {
            List<ClientModel> clients = new List<ClientModel>();
            ClientModel selectedClient = new ClientModel();

            using (var database = new LogicLL())
                clients = mapper.Map<List<ClientModel>>(database.GetAllClients());

            selectedClient = clients.Where(x => x.Id == id).First();

            return View(selectedClient);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientModel client)
        {
            try
            {
                using (var database = new LogicLL())
                    database.UpdateClient(mapper.Map<ClientLL>(client));

                return RedirectToAction("ShowAll");
            }
            catch
            {
                return View();
            }
        }

    }
}