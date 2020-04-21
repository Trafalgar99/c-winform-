using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳游戏
{
   public class Computer
    {
        /// <summary>
        /// 声明一个属性来记录出的拳
        /// </summary>
        public string Fist
        {
            get;
            set;
           
        }

        public int ShowFist()
        {
            Random r = new Random();
            int rNum = r.Next(1, 4);
            switch(rNum)
            {
                case 1: this.Fist = "石头";
                    break;
                case 2:this.Fist = "剪刀";
                    break;
                case 3:this.Fist = "布";
                    break;
            }
            return rNum;
        }
    }
}
