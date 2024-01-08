using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomieReserveMAUI.Components.Data
{
    public class Item
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Owner_Id { get; set; }
        public int Boxie_Id { get; set; }
        public DateOnly BestBefore { get; set; }
    }
}
