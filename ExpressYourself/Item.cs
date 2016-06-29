using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSafari
{
    class Item
    {
        //public string Type { get; set; }

        public string Title { get; set; }

        public int Length { get; set; }

        public Item()
        {
            //Type = null;
            Title = null;
            Length = 0;
        }

        public Item(string title, int length)
        {
            //Type = type;
            Title = title;
            Length = length;
        }
    }
}
