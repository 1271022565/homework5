using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WeChat w1 = new WeChat();
            Alipay a1 = new Alipay();
            CreditCard c1 = new CreditCard();
            Integral ig = new Integral();
            Console.WriteLine("请选择支付方式：");
            Console.WriteLine("1.微信支付：");
            Console.WriteLine("2.支付宝支付：");
            Console.WriteLine("3.信用卡支付：");
            Console.WriteLine("4.积分支付：");
            int t,i,j;
            string str;
            t =Convert.ToInt32(Console.ReadLine());
            if(t==1)
            {
                w1.Zhifu();
                w1.Saomiao();
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("请输入密码：");
                    str = Console.ReadLine();
                    if (w1.Key(str) == 0)
                    {
                        Console.WriteLine("密码错误，支付宝支付失败");
                        for (j = 3; j > 0; j--)
                        {
                            Console.WriteLine("请重新输入密码：");
                            str = Console.ReadLine();
                            if (w1.Key(str) == 1)
                            {
                                Console.WriteLine("密码正确");
                                break;
                            }
                        }
                        if (j == 0)
                            Console.WriteLine("错误次数已经达到上限，请明天再来！");
                    }
                    else
                        Console.WriteLine("密码正确，微信支付成功");
                }
                else if(i==2)
                {
                    w1.Face();
                }
                else if(i==3)
                {
                    w1.Finger();
                }
            }
            else if(t==2)
            {
                a1.Zhifu();
                a1.Saomiao();
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("请输入密码：");
                    str = Console.ReadLine();
                    if (a1.Key(str) == 0)
                    {
                        Console.WriteLine("密码错误，微信支付失败");
                        for (j = 3; j > 0; j--)
                        {
                            Console.WriteLine("请重新输入密码：");
                            str = Console.ReadLine();
                            if (a1.Key(str) == 1)
                            {
                                Console.WriteLine("密码正确");
                                break;
                            }
                        }
                        if (j == 0)
                            Console.WriteLine("错误次数已经达到上限，请明天再来！");
                    }
                    else
                        Console.WriteLine("密码正确，支付宝支付成功");
                }
                else if (i == 2)
                {
                    a1.Face();
                }
                else if (i == 3)
                {
                    a1.Finger();
                }
            }
            else if(t==3)
            {
                c1.Zhifu();
                c1.Paybycard();
                str = Console.ReadLine();
                if (c1.Key(str) == 0)
                {
                    Console.WriteLine("密码错误，刷卡支付失败");
                    for (j = 3; j > 0; j--)
                    {
                        Console.WriteLine("请重新输入密码：");
                        str = Console.ReadLine();
                        if (c1.Key(str) == 1)
                        {
                            Console.WriteLine("密码正确");
                            break;
                        }
                    }
                    if (j == 0)
                        Console.WriteLine("错误次数已经达到上限，请明天再来！");
                }
                else
                    Console.WriteLine("密码正确，刷卡支付成功");
            }
            else if(t==4)
            {
                ig.Zhifu();
            }
        }
    }
}
