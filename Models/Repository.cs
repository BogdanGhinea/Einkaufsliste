using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Einkaufsliste.Models
{
    public class Repository
    {
        private static List<Position> positions = new List<Position>();
        public static IEnumerable<Position> Positions { get { return positions; } }
        public static void AddPosition(Position position)
        {
            positions.Add(position);
        }
    }
}
