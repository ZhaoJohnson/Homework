using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkModel.Interface;

namespace WorkModel
{
    public class NorthScet:BasicShow,IPay
    {
        public override string Resident { get; set; }
        public override string Table { get; set; }
        public override string Chair { get; set; }
        public override string Fan { get; set; }
        public override string Ruler { get; set; }
        

        public override void ConcludingRemarks()
        {
            Console.WriteLine("Thank You Watching The NorthScet Show!");
        }

        public override void Bark()
        {
        }

        public override void HumanSound()
        {
        }

        public override void Wind()
        {
        }

        public void Fee()
        {
        }
    }
}
