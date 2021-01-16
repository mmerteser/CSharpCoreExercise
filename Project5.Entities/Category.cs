using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.Entities
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
