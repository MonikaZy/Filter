using System;
using System.ComponentModel.DataAnnotations;


namespace Filter.Domain.Models
{
    public class FilterItem
    {
        public FilterItem()
        {
           
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string jsonCategory { get; set; }
    }
}


