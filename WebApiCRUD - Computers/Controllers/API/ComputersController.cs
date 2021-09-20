using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCRUD___Computers.Models;
using AutoMapper;

namespace WebApiCRUD___Computers.Controllers.API
{
    public class ComputersController : ApiController
    {
        private ApplicationDbContext _context;

        public ComputersController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult GetComupters(int? Id=null, string ModelName=null, string ManufacturerCompanyName=null,
                                                string CPU=null, int? RAM=null, int? Memory=null, int? ScreenSize=null,
                                                int? Price=null, int? MinPrice=null, int? MaxPrice=null)
        {
            var searchModel = new ComputerSearchModel() 
            { 
                Id=Id,
                ModelName = ModelName,
                ManufacturerCompanyName = ManufacturerCompanyName,
                CPU = CPU,
                RAM = RAM,
                Memory = Memory,
                ScreenSize = ScreenSize,
                Price = Price,
                MaxPrice=MaxPrice,
                MinPrice=MinPrice
            };

            var Computers = ComputerFilter(searchModel);

            return Ok(Computers);
        }

        private List<Computer> ComputerFilter(ComputerSearchModel searchModel)
        {
            var result = _context.Computers.AsQueryable();

            if (searchModel != null)
            {
                if (searchModel.Id.HasValue)
                    result = result.Where(x => x.Id == searchModel.Id);

                if (!string.IsNullOrEmpty(searchModel.ModelName))
                    result = result.Where(x => x.ModelName.Contains(searchModel.ModelName));

                if (!string.IsNullOrEmpty(searchModel.ManufacturerCompanyName))
                    result = result.Where(x => x.ManufacturerCompanyName.Contains(searchModel.ManufacturerCompanyName));

                if (!string.IsNullOrEmpty(searchModel.CPU))
                    result = result.Where(x => x.CPU.Contains(searchModel.CPU));

                if (searchModel.RAM.HasValue)
                    result = result.Where(x => x.RAM == searchModel.RAM);

                if (searchModel.Memory.HasValue)
                    result = result.Where(x => x.Memory == searchModel.Memory);

                if (searchModel.ScreenSize.HasValue)
                    result = result.Where(x => x.ScreenSize == searchModel.ScreenSize);

                if (searchModel.Price.HasValue)
                    result = result.Where(x => x.Price == searchModel.Price);

                if (searchModel.MaxPrice.HasValue)
                    result = result.Where(x => x.Price <= searchModel.MaxPrice);
                
                if (searchModel.MinPrice.HasValue)
                    result = result.Where(x => x.Price >= searchModel.MinPrice);

            }
            return result.ToList();
        }

        [HttpGet]
        public IHttpActionResult GetComputer(int id)
        {
            var computer = _context.Computers.SingleOrDefault(c => c.Id == id);

            if (computer == null)
                return NotFound();

            return Ok(computer);
        }


        [HttpPost]
        public IHttpActionResult CreateComputer(Computer computer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Computers.Add(computer);
            _context.SaveChanges();

            return Ok(computer);
        }

        [HttpPut]
        public IHttpActionResult UpdateComputer(int id, Computer updatedComputer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var computerInDb = _context.Computers.SingleOrDefault(c => c.Id == id);

            if (computerInDb == null)
                return NotFound();

            computerInDb.ModelName = updatedComputer.ModelName;
            computerInDb.ManufacturerCompanyName = updatedComputer.ManufacturerCompanyName;
            computerInDb.CPU = updatedComputer.CPU;
            computerInDb.RAM = updatedComputer.RAM;
            computerInDb.Memory = updatedComputer.Memory;
            computerInDb.ScreenSize = updatedComputer.ScreenSize;
            computerInDb.Price = updatedComputer.Price;

            //Mapper.Map<Computer,Computer>(updatedComputer, computerInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteComputer(int id)
        {
            var computerInDb = _context.Computers.SingleOrDefault(c => c.Id == id);

            if (computerInDb == null)
                return NotFound();

            _context.Computers.Remove(computerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
