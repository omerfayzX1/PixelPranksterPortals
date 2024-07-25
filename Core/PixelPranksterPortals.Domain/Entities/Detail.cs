using PixelPranksterPortals.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPranksterPortals.Domain.Entities
{
    public class Detail:EntityBase
    {
        public Detail()
        {
        }

        public Detail(int categoryId, string description, string title)
        {
            CategoryId = categoryId;
            Description = description;
            Title = title;
        }

        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
    }
}
