using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1주차_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //a = a + 1;
            //Console.WriteLine("a++ 테스트 a= a++ + 1 결과 {0}",a);
            //a++;
            //Console.WriteLine("a++ 테스트 a++ 결과 {0}",a);


            //a = 10;
            //a = a + 1;
            //++a;
            //Console.WriteLine("++a 테스트 a= ++a + 1 결과 {0}", a);

            //Console.ReadLine();

            //String str = "abcd안녕하세요";
            //Console.WriteLine(str);
            //Console.WriteLine("str 문자열 길이는 {0}",str.Length);
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str[1]);
            //Console.WriteLine(str[2]);
            //Console.WriteLine(str[3]);
            //Console.WriteLine(str[4]);
            //Console.WriteLine(str[5]);
            //Console.WriteLine(str[6]);
            //Console.WriteLine(str[7]);
            //Console.WriteLine(str[8]);
            //Console.WriteLine(str[9]);

            //Console.ReadLine();

            string st;
            int num01;
            int num02;

            Console.Write("첫번째 숫자 입력 : ");
            st = Console.ReadLine();
            num01 = int.Parse(st);
            st = "";

            Console.Write("더할 숫자 입력 : ");
            st=Console.ReadLine();
            num02 = int.Parse(st);
            long num03 = (long)num01 + (long)num02;

            Console.WriteLine("{0}+{1}={2}",num01, num02,num03);

            Console.ReadLine();
        }
    }
}
