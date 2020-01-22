﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBookingAsp.netCrudOperation.Models;

namespace HotelBookingAsp.netCrudOperation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (DataModels db = new DataModels())
            {
                return View(db.Customers.ToList());
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (DataModels db = new DataModels())
            {
                return View(db.Customers.Where(x => x.CustomerId == id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                using (DataModels db = new DataModels())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DataModels db = new DataModels())
            {
                return View(db.Customers.Where(x => x.CustomerId == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                using (DataModels db = new DataModels())
                {

                    db.Entry(customer).State = EntityState.Modified;
                    db.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DataModels db = new DataModels())
            {
                return View(db.Customers.Where(x => x.CustomerId == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                // TODO: Add delete logic here
                using (DataModels db = new DataModels())
                {
                    customer = db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
                    db.Customers.Remove(customer);
                    db.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
