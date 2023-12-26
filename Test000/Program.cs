using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jack
{
    class Program
    {
        static void Main(string[] args)
        {

            // 題目 : 讀入兩個數x和y，選出大的那一個。

            //double x, y, z;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("請輸入y值");
            //y = Convert.ToDouble(Console.ReadLine());


            //if (x > y)
            //{
            //    z = x;
            //    Console.WriteLine($"\"x比較大\",{z}");
            //}
            //else
            //{
            //    z = y;
            //    Console.WriteLine($"\"y比較大\",{z}");
            //}

            //Console.ReadKey();




            //題目 : 讀入x和y，如果x>y，則回傳x-y，否則回傳y-x。

            //double x, y, z;
            //Console.WriteLine("請輸入一個x的值");
            //x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("請輸入一個y的值");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x > y)
            //{
            //    z = x - y;
            //    Console.WriteLine($"{z}");
            //}
            //else if (x < y)
            //{
            //    z = y - x;
            //    Console.WriteLine(z);
            //}
            ////else { Console.WriteLine("x=y"); }


            //Console.ReadKey();




            //題目 :  讀入一數字，如果是負數，就將它轉成正數。

            //double x;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());

            //if (x < 0)
            //{
            //    x = -x;
            //    Console.WriteLine($"\"把負數轉換成正數\"{x}");
            //    x = Math.Abs(x);
            //}
            //else
            //{
            //    Console.WriteLine($"\"判斷是正數\"{x}");
            //}

            //Console.ReadKey();



            //題目 : 輸入一個學生的分數，輸出該成績級別，分數級別如下：
            // 90分以上 -> A
            // 80~89分 -> B
            // 70~79分 -> C
            // 60~69分 -> D
            // 60分以下 -> F

            //    double x;
            //Console.WriteLine("請輸入學生分數");
            //x = Convert.ToDouble(Console.ReadLine());

            //if (x > 90)
            //{
            //    Console.WriteLine("\"gradeA\"");
            //}
            //else if (x >= 80)
            //{
            //    Console.WriteLine("\"gradeB\"");
            //}
            //else if (x >= 70)
            //{
            //    Console.WriteLine("\"gradeC\"");
            //}
            //else if (x >= 60)
            //{
            //    Console.WriteLine("\"gradeD\"");
            //}
            //else
            //{
            //    Console.WriteLine("\"gradeF\"");
            //}

            //Console.ReadKey();



            //題目:用Switch改寫

            //double x;
            //Console.WriteLine("請輸入學生分數");
            //x = Convert.ToDouble(Console.ReadLine());

            //switch (x)
            //{
            //    case 90:
            //        Console.WriteLine("gradeA");
            //        break;

            //    case 80:
            //        Console.WriteLine("gradeB");
            //        break;

            //    case 70:
            //        Console.WriteLine("gradeC");
            //        break;

            //    case 60:
            //        Console.WriteLine("gradeD");
            //        break;

            //    default:
            //        Console.WriteLine("gradeF");
            //        break;

            //}

            //Console.ReadKey();



            //題目:某商店在大特價，根據購買的商品總金額決定打折的折扣，總金額越高折扣越多，折扣表如下：

            //未滿1000 -> 無折扣
            //1000~4999 -> 9折
            //5000~9999 -> 8折
            //高於10000 -> 7折
            //小數點四捨五入，印出折扣後的金額。

            //    double x, y;
            //Console.WriteLine("請輸入購買金額");
            //x = Convert.ToDouble(Console.ReadLine());

            //if (x < 1000)
            //{
            //    y = Math.Round(x);
            //    Console.WriteLine($"\"discont=1.0\",{y}");
            //}
            //else if (x <= 4999)
            //{
            //    y = Math.Round(0.9 * x);
            //    Console.WriteLine($"\"discont=0.9\",{y}");
            //}
            //else if (x <= 9999)
            //{
            //    y = Math.Round(0.8 * x);
            //    Console.WriteLine($"\"discont=0.8\",{y}");
            //}
            //else
            //{
            //    y = Math.Round(0.7 * x);
            //    Console.WriteLine($"\"discont=0.7\",{y}");

            //}

            //Console.ReadKey();



            //題目:2-1.寫一程式，輸入x和y，如果x>=y 印z=x，如果x>=y不成立 則列印z=y

            //double x, y, z;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x >= y)
            //{
            //    z = x;
            //    Console.WriteLine($"\"答案是\"{z}");
            //}
            //else
            //{
            //    z = y;
            //    Console.WriteLine($"\"答案是\"{z}");
            //}
            //Console.ReadKey();



            //題目:2-2.寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0

            //double x, y, z;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    z = 1;
            //    Console.WriteLine($"\"x和y都是正數\"{z}");
            //}

            //else if (x < 0 && y < 0)
            //{
            //    z = -1;
            //    Console.WriteLine($"\"x和y都是負數\"{z}");
            //}

            //else
            //{
            //    z = 0;
            //    Console.WriteLine($"\"x和y一正一負\"{z}");
            //}
            //Console.ReadKey();



            //題目:2-3.寫一程式，輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x-y，否則令z=u-v

            //double x, y, u, v, z;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入u值");
            //u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入v值");
            //v = Convert.ToDouble(Console.ReadLine());

            //if ((x + y) > (u + v))
            //{
            //    z = x - y;
            //    Console.WriteLine($"\"答案是\"{z}");
            //}

            //else
            //{
            //    z = u - v;
            //    Console.WriteLine($"\"答案是\"{z}");
            //}
            //Console.ReadKey();



            //題目:2-4.寫一程式，輸入x、y、u、v，如果，令z=x-y，否則令z=u-v。

            //double x, y, u, v, z;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入u值");
            //u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入v值");
            //v = Convert.ToDouble(Console.ReadLine());

            //if ((x + y) / (u - v) >= 2)
            //{
            //    z = x - y;
            //    Console.WriteLine($"\"答案\"{z}");
            //}

            //else
            //{
            //    z = u - v;
            //    Console.WriteLine($"\"答案\"{z}");
            //}
            //Console.ReadKey();



            //題目:2-5.寫一程式，輸入x和y，如果xy，令z=x2，否則令z=y2

            //double x, y, z;
            //Console.WriteLine("請輸入x值");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //y = Convert.ToDouble(Console.ReadLine());


            //if (x >= y)
            //{
            //    z = Math.Pow(x, 2);
            //    Console.WriteLine($"\"x>=y所以答案是x平方\"{z}");
            //}

            //else
            //{
            //    z = Math.Pow(y, 2);
            //    Console.WriteLine($"\"x<y所以答案是y平方\"{z}");
            //}
            //Console.ReadKey();




            //題目:2-6.依照以下的流程圖，寫一程式。

            //double income, rate, difference, tax;
            //Console.WriteLine("請輸入income");
            //income = Convert.ToDouble(Console.ReadLine());

            //if (income > 4090000)
            //{
            //    rate = 0.4;
            //    difference = 721100;
            //    tax = (income * rate) - difference;
            //    Console.WriteLine($"\"答案是\"{tax}");
            //}
            //else if (income > 2180000)
            //{
            //    rate = 0.3;
            //    difference = 312100;
            //    tax = (income * rate) - difference;
            //    Console.WriteLine($"\"答案是\"{tax}");
            //}
            //else if (income > 1090000)
            //{
            //    rate = 0.21;
            //    difference = 115900;
            //    tax = (income * rate) - difference;
            //    Console.WriteLine($"\"答案是\"{tax}");
            //}
            //else if (income > 410000)
            //{
            //    rate = 0.13;
            //    difference = 28700;
            //    tax = (income * rate) - difference;
            //    Console.WriteLine($"\"答案是\"{tax}");
            //}
            //else
            //{
            //    rate = 0.06;
            //    difference = 0;
            //    tax = (income * rate) - difference;
            //    Console.WriteLine($"\"答案是\"{tax}");

            //}

            //Console.ReadKey();



            //題目:2-7.流程圖

            //double x, y;
            //Console.WriteLine("請輸入x");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("1st quadrant\n");
            //}
            //else if (x > 0 && y == 0)
            //{
            //    Console.WriteLine("X-axis\n");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("4th quadrant\n");
            //}
            //else if (x == 0 && y == 0)
            //{
            //    Console.WriteLine("Origin\n");
            //}
            //else if (x == 0 && y > 0 && y < 0)
            //{
            //    Console.WriteLine("Y-axis\n");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("2nd quadrant\n");
            //}
            //else if (x < 0 && y == 0)
            //{
            //    Console.WriteLine("X-axis\n");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("3th quadrant\n");
            //}
            //Console.ReadKey();



            //題目:sagit 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
            //答對題數在 0~10 者，每題給6分。
            //題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
            //題數在 21~40 者，從第21題開始，每題給1分。
            //題數在 40 以上者，一律100分。
            //請輸入答對題數，輸出統計後分數

            //    double score, examquestions;
            //Console.WriteLine("請輸入答對題數");
            //examquestions = Convert.ToDouble(Console.ReadLine());


            //if (examquestions <= 10)
            //{
            //    score = examquestions * 6;
            //    Console.WriteLine($"\"您的分數\"{score}分");
            //}
            //else if (examquestions >= 11 && examquestions <= 20)
            //{
            //    score = (examquestions - 10) * 2 + 60;
            //    Console.WriteLine($"\"您的分數\"{score}分");
            //}
            //else if (examquestions >= 21 && examquestions <= 40)
            //{
            //    score = (examquestions - 20) * 1 + 80;
            //    Console.WriteLine($"\"您的分數\"{score}分");
            //}
            //else
            //{
            //    score = 100;
            //    Console.WriteLine($"\"恭喜你獲得\"{score}分");
            //}


            //Console.ReadKey();




            //題目:請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。

            //double height, weight, BMI;

            //Console.WriteLine("請輸入您的身高(cm)");
            //height = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("請輸入您的體重(kg)");
            //weight = Convert.ToDouble(Console.ReadLine());

            //height = (height / 100);

            //if ((weight / Math.Pow(height, 2) >= 18.5) && (weight / Math.Pow(height, 2) < 24))
            //{

            //    BMI = (weight / Math.Pow(height, 2));
            //    Console.WriteLine($"\"您的BMI正常\"{BMI}");
            //}

            //else if (weight / Math.Pow(height, 2) < 18.5)
            //{

            //    BMI = (weight / Math.Pow(height, 2));
            //    Console.WriteLine($"\"您的BMI過輕\"{BMI}");
            //}

            //else
            //{

            //    BMI = (weight / Math.Pow(height, 2));
            //    Console.WriteLine($"\"您的BMI過重\"{BMI}");
            //}


            //Console.ReadKey();




            //題目:請隨意輸入三個數，請由大到小 依序印出。

            //double a, b, c;
            //Console.WriteLine("請輸入隨意數字");
            //a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("請輸入隨意數字");
            //b = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("請輸入隨意數字");
            //c = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("您輸入的數字" + a.ToString() + "," + b.ToString() + "," + c.ToString());

            //if (a > b && a > c) //a最大
            //{
            //    if (b > c) //a>b>c
            //    {
            //        Console.WriteLine("排序結果由大到小:" + a.ToString() + "," + b.ToString() + "," + c.ToString());
            //    }
            //    else  //a>c>b
            //    {
            //        Console.WriteLine("排序結果由大到小:" + a.ToString() + "," + c.ToString() + "," + b.ToString());
            //    }

            //}

            //else if (b > a && a > c) //a第二大
            //{      //b>a>c
            //    Console.WriteLine("排序結果由大到小:" + b.ToString() + "," + a.ToString() + "," + c.ToString());
            //}
            //else if (c > a && a > b) //a第二大
            //{     //c>a>b
            //    Console.WriteLine("排序結果由大到小:" + c.ToString() + "," + a.ToString() + "," + b.ToString());
            //}

            //else //a最小
            //{
            //    if (b > c) //b>c>a
            //    {
            //        Console.WriteLine("排序結果由大到小:" + b.ToString() + "," + c.ToString() + "," + a.ToString());
            //    }
            //    else
            //    {         //c>b>a
            //        Console.WriteLine("排序結果由大到小:" + c.ToString() + "," + b.ToString() + "," + a.ToString());
            //    }
            //}

            //Console.ReadKey();




            //題目:企業發放的獎金根據利潤提成。利潤低於或等於10萬元時，獎金可提10%；
            //利潤高于10萬元，低於20萬元時，低於10萬元的部分按10 % 提成，高於10萬元的部分，可提成7.5 %；20萬到40萬之間時，高於20萬元的部分，可提成5 %；
            //40萬到60萬之間時高於40萬元的部分，可提成3 %；
            //60萬到100萬之間時，高於60萬元的部分，可提成1.5 %，高於100萬元時，超過100萬元的部分按1 % 提成，從鍵盤輸入當月利潤I，求應發放獎金總數？

            //    double i, a;
            //Console.WriteLine("請輸入當月利潤");
            //i = Convert.ToDouble(Console.ReadLine());

            //if (i <= 100000)
            //{
            //    a = (i * 0.1);
            //    Console.WriteLine($"\"您的當月獎金\"{a}");
            //}
            //else if ((i > 100000) && (i < 200000))
            //{
            //    a = ((i - 100000) * 0.075) + (100000 * 0.1);
            //    Console.WriteLine($"\"您的當月獎金\"{a}");
            //}
            //else if ((i >= 200000) && (i < 400000))
            //{
            //    a = ((i - 199999) * 0.05) + (99999 * 0.075) + (100000 * 0.1);
            //    Console.WriteLine($"\"您的當月獎金\"{a}");
            //}
            //else if ((i >= 400000) && (i < 600000))
            //{
            //    a = ((i - 399999) * 0.03) + (200000 * 0.05) + (99999 * 0.075) + (100000 * 0.1);
            //    Console.WriteLine($"\"您的當月獎金\"{a}");
            //}
            //else if ((i >= 600000) && (i < 1000000))
            //{
            //    a = ((i - 599999) * 0.015) + (200000 * 0.03) + (200000 * 0.05) + (99999 * 0.075) + (100000 * 0.1);
            //    Console.WriteLine($"\"您的當月獎金\"{a}");
            //}
            //else
            //{
            //    a = (((i - 999999) * 0.01) + (400000 * 0.015) + (200000 * 0.03) + (200000 * 0.05) + (99999 * 0.075) + (100000 * 0.1));
            //    Console.WriteLine($"\"您的當月獎金\"{a}");
            //}



            //Console.ReadKey();



        }


    }
}





