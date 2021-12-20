using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface IChance
    {
        int InitialValue { get; set; }
        //확률 초기시작값
        int Max { get; set; }
        //확률 최대값
        int Min { get; set; }
        //확률 최소값
        int PlusMinus { get; set; }
        //성공 및 실패 시 플마되는 값
        bool prob();
        //확률 변동해주는 메서드
    }
    class Chance : IChance
    {
        Random random = new Random();
        public int InitialValue { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int PlusMinus { get; set; }
        public bool prob()
        {
            int x = random.Next(1, 101);
            if (x <= this.InitialValue)
            {
                if (this.InitialValue > this.Min)
                    this.InitialValue -= this.PlusMinus;
                return true;
            }
            else
            {
                if (this.InitialValue < this.Max)
                    this.InitialValue += this.PlusMinus;
                return false;
            }
        }
    }
}
