using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳游戏
{

    public enum State
    {
        玩家赢,
        电脑赢,
        平手
    }
    public static class Judge
    {
        public static State judge(int playerNum,int computerNum)
        {
            State s = 0 ;
            if(playerNum==computerNum)
            {
                s = State.平手;
                    
            }
            else if(playerNum-computerNum==-1||playerNum-computerNum==2)
            {
                s = State.玩家赢;
            }
            else
            {
                s = State.电脑赢;
            }
            return s;
        }
    }
}
