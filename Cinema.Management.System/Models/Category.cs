using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Category
    {
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public Category(int categoryId,string categoryName)
        {
            this.categoryId=categoryId;
            this.categoryName=categoryName;
        }

    }
}