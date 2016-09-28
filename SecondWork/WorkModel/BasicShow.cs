using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkModel
{
    public abstract class BasicShow
    {
        public abstract string Resident { get; set; }
        public abstract string Table { get; set; }
        public abstract string Chair { get; set; }
        public abstract string Fan { get; set; }
        public abstract string Ruler { get; set; }
        /// <summary>
        /// 开场
        /// </summary>
        public void InitialShow()
        {
            Console.WriteLine("The Show Star");
        }
        /// <summary>
        /// 狗狗叫
        /// </summary>
        public abstract void Bark();
        /// <summary>
        /// 人声
        /// </summary>
        public abstract void HumanSound();
        /// <summary>
        /// 风声
        /// </summary>
        public abstract void Wind();

        /// <summary>
        /// 开场白
        /// </summary>
        public virtual void Prologue()
        {
            Console.WriteLine("Welcome!");
        }

        public virtual void ConcludingRemarks()
        {
            Console.WriteLine("See U Again!");
        }

        public event Action Fire;

        public virtual Action SetTemperature(int temperature)
        {
            if (temperature>400)
            {
                Fire.Invoke();
            }
            return null;
        }
       

    }
}
