using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Category
    {
        public String CategoryName { get; set; }
        public int Count { get; set; }
        public Category(String name, int count) { }
    }
}
