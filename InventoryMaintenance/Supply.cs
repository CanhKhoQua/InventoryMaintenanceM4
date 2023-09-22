using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public Supply() { }
        public string Manufacturer;
        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price) => Manufacturer = manufacturer;
        public override string GetDisplayText() =>
            $"{ItemNo} {(Manufacturer)} {Description} ({Price:c})";
    }
}
