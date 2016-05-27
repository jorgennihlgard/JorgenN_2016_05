using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace JorgenN.Models
{
    public class Store
    {
        public int Id { get; set; }
        [Required,Display (Name = "Store Name")]
        public string Name { get; set; }
        [Required,MaxLength(50)]
        public string Address { get; set; }
        public List<Product> Products { get; set; }


    }
}