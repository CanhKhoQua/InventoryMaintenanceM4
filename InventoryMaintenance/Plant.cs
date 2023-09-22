using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{   //Plant class inherited from InvItem which Plant class has all the attributes that InvItem has such as ItemNo, Description, Price; however,
   //Plant has been assigned one more variable - size.
    public class Plant : InvItem
    {
        public Plant() { }
        public string Size { get; set; }
        public Plant(int itemNo, string description, decimal price, string size) : base(itemNo, description, price) => Size = size;
        public override string GetDisplayText() =>
            $"{ItemNo} {(Size)} {Description} ({Price:c})";
    }
}
