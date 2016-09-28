using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkModel
{
    public class WestSect : BasicShow
    {
        public override string Resident { get; set; }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
        public override void Prologue()
        {
            Console.WriteLine("Welcome to The WestSect Show!");
        }
        public override void ConcludingRemarks()
        {
            Console.WriteLine("Thank You Watching The WestSect Show!");
        }

        public override void Bark()
        {
            throw new NotImplementedException();
        }

        public override void HumanSound()
        {
            throw new NotImplementedException();
        }

        public override void Wind()
        {
            throw new NotImplementedException();
        }
    }
}
