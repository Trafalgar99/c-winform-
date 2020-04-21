using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳游戏
{
   public class Player
    {
        //出拳的方法


        public int ShowFist(string fist)   //返回1 2 3
        {
            int result = 0;
            switch(fist)
            {
                case "石头":result = 1;
                    break;
                case "剪刀":result = 2;
                    break;
                case "布":result = 3;
                    break;
            }
            return result;
        }
    }
}
