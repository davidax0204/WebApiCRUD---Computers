using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiCRUD___Computers.Models;

namespace WebApiCRUD___Computers.Controllers
{
    public class ComputersController : Controller
    {
        // GET: Computers
        private ApplicationDbContext _context;

        public ComputersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}