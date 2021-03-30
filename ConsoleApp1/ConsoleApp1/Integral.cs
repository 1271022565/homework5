using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Integral : Pay
    {
        public override void Zhifu()
        {
            Console.WriteLine("积分支付中：");
            Console.WriteLine("积分已经扣除。");
            Console.WriteLine("积分支付成功。");
        }
    }
}
