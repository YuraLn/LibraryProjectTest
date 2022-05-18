using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Journal : AbstractItem
    {
        public JournalType Type { get; set; }
        public JournalMonth Month { get; set; }
        public Journal(string title) : base(title)
        {
            Type = JournalType.Comedy;
            Month = JournalMonth.Jan | JournalMonth.Feb | JournalMonth.Apr;
        }
    }

    public enum JournalType
    {
        Drama = 1,
        Horror = 2,
        Comedy = 3
    }

    [Flags]
    public enum JournalMonth
    {
        Jan = 1,
        Feb = 2,
        Mar = 4,
        Apr = 8
    }



    //public class JournalDrama : Journal { }
    //public class JournalHorror : JournalDrama { }
    //public class JournalComedy : JournalHorror
    //{
    //    public string title { get; set; }
    //}

}
