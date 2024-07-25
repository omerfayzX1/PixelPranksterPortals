using PixelPranksterPortals.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPranksterPortals.Domain.Entities
{
    public class Category:EntityBase
    {
        public Category()
        {
        }

        public Category(string name, int priorty, int parentId)
        {
            Name = name;
            Priorty = priorty;
            ParentId = parentId;
        }

        public string Name { get; set; }
        public int Priorty { get; set; }
        public int ParentId { get; set; }

        public Brand Brand { get; set; }
    }
}
