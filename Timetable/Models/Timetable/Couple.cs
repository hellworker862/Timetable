using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable.Models.Timetable
{
    public class Couple
    {
        public TimeOnly StartDate { get; init; }
        public string Location { get; init; }
        public string Teacher { get; init; }
        public string? Group { get; init; }

    }
}
