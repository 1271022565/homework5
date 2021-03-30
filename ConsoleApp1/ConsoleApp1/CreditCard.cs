using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class CreditCard:Pay,Shuaka,Mima
    {
        public override void Zhifu()
        {
            Console.WriteLine("请插入信用卡");
        }
        public void Paybycard()
        {
            Console.WriteLine("刷卡中");
            Console.WriteLine("请输入密码：");
        }
        public int Key(string num)
        {
            int i;
            if (num == "123456")
                i = 1;
            else
                i = 0;
            return i;
        }
    }
}
