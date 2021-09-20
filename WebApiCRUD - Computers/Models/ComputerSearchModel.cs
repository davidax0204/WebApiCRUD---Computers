using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCRUD___Computers.Models
{
    public class ComputerSearchModel
    {
        public int? Id { get; set; }
        public string ModelName { get; set; }
        public string ManufacturerCompanyName { get; set; }
        public string CPU { get; set; }
        public int? RAM { get; set; }
        public int? Memory { get; set; }
        public int? ScreenSize { get; set; }
        public int? Price { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }


    }
}