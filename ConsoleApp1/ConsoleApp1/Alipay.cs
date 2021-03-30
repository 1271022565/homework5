using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Alipay:Pay,Scan,Mima,Zhiwen,Renlian
    {
        public override void Zhifu()
        {
            Console.WriteLine("支付宝支付中：");
            Console.WriteLine("请扫描二维码：");
        }
        public void Saomiao()
        {
            Console.WriteLine("扫码中：");
            Console.WriteLine("扫码成功");
            Console.WriteLine("请选择：1.密码支付；2.面部解锁；3.指纹支付");
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
        public void Face()
        {
            Console.WriteLine("人脸扫描中.....");
            Console.WriteLine("扫描成功");
        }
        public void Finger()
        {
            Console.WriteLine("指纹验证中.....");
            Console.WriteLine("验证成功");
        }
    }
}

