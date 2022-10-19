using System;
using static System.Console;

namespace Demo
{
    #region Struct and enum
    public struct Tixi  // 结构声明
    {
        public string Name;  // public 声明公有
        public int Age;
        public long Phone;
        public string Xi;
        public Gender xingbie;    // Enum
        public Tixi2 Fujia;       // 互相访问
    }

    public struct Tixi2
    {
        public string _Name;
        public string _Age;
    }

    public enum Gender
    {
        boy,
        girl
    }
    #endregion

    class Program
    {
        #region 类型
        //78XL--------------------------------
        static int i = 0;
        static string Onok = "";
        //78XL--------------------------------
        public enum Person     //枚举
        {
            boy,
            girl,
            one,
            two
        }
        public enum season
        {
            spring = 1,
            summer = 4,
            autumn = 7,
            winter = 10
        }

        public struct Personal //9.1
        {
            public int I;
            public int J;

            public void PersonalGame(int I, int J)
            {
                this.I = I;
                this.J = J;
            }
        }
        #endregion

        static void Main(string[] args) //入口点
        {
            Console.WriteLine这个输出函数在内部是重载的 可以容纳很多类型的变量

            #region 9.1
            Personal p;
            p.I = 0;
            p.J = 0;
            WriteLine(p.I);
            WriteLine(p.J);
            结构体概念
            #endregion

            #region 整数输出
            不带小数点都是整数
            int i = 10; //数据类型 变量 = 整数
            short s = 20;
            long l = 30;
            Console.WriteLine("i = {0}\ns = {1}\nl = {2}", i, s, l);// \n回车 空行   从{0}开始
            Console.ReadKey();
            #endregion

            #region 小数输出
            带小数点都是浮点数
            decimal 金钱类型
            float f = 1.1f;
            double d = 1.2;
            Console.WriteLine("f = {0}\nd = {1}", f, d);
            Console.ReadKey();
            #endregion

            #region 字符输出
            char 一次只能存一个 而且必须使用单引号''
             char a = 'a';
            char c = 'c';
            string s = "Hello";
            // string 能存储多个 必须使用双引号""
            Console.WriteLine("c = {0}\ns = {1}", c, s);
            Console.ReadKey();
            #endregion

            #region 布尔输出
            bool b = true;
            Console.WriteLine("{0}", b);
            Console.ReadKey();
            #endregion

            #region 初始化 和 可空类型 和 无符号类型
            初始化
            int? _Age = 18; //创建一个变量给他一个值 就是初始化
            int? _Name = null;
            // short? long? float?
            Console.WriteLine(_Age);
            Console.WriteLine(_Name);
            Console.ReadKey();
            前面说的数字类型都是有最大取值范围的
            如果数字过大那么这个变量类型就会溢出 就会变成负数
            uint INT = 111111111;
            // ushort ulong
            Console.WriteLine(INT);
            Console.ReadKey();
            如果溢出数字不会溢出 而会归零
            #endregion

            #region 变量赋值
            int One = 1, Two = 2, Three = 3;

            int o, t, th;
            o = 1;
            t = 2;
            th = 3;

            int One, Two, Three;
            One = Two = Three = 30;
            #endregion

            #region 输出方式
            string s1 = "我叫";
            string s2 = "GK";
            Console.WriteLine("Hello " + s1 + s2);
            Console.WriteLine("Hello {0}{1}", s1, s2);
            Console.WriteLine($"Hello {s1}{s2}");
            Console.ReadKey();
            #endregion

            #region +号的作用
            数字和数字之间是直接运算
            数字和字符串之间是连接
            字符串跟字符串之间也是连接
            Console.WriteLine("5" + 5);
            #endregion

            #region 变量交换1
            int a = 10;
            int b = 20;
            Console.WriteLine($"a = {a}\nb = {b}");
            Console.WriteLine("交换后");
            int c;
            c = a; //10   c=10 a=10
            a = b; //20   a=20 b=20
            b = c; //10   b=10 c=10
            Console.WriteLine($"a = {a}\nb = {b}");
            Console.ReadKey();
            string a = "雪碧";
            string b = "可乐";
            Console.WriteLine($"a = {a}\nb = {b}");
            string c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}\nb = {b}");
            Console.ReadKey();
            #endregion

            #region 变量交换2
            int a = 10;
            int b = 20;
            Console.WriteLine($"a = {a}\nb = {b}");
            a = a - b; //10 = 10 - 20
            b = a + b; //20 = 10 + 20
            a = b - a; //10 = 20 - 10
            Console.WriteLine($"a = {a}\nb = {b}");
            Console.ReadKey();
            #endregion

            #region 手动输入
            Console.WriteLine("内容: ");
            string str = Console.ReadLine();
            Console.WriteLine($"你输入的是: {str}");
            Console.ReadKey();
            #endregion

            #region 一份作业
            Console.WriteLine("请输入名字: ");
            string name = Console.ReadLine();
            Console.WriteLine("请输入性别: ");
            string gender = Console.ReadLine();
            Console.WriteLine("请输入年龄: ");
            string age = Console.ReadLine();
            Console.WriteLine("请输入工资: ");
            string income = Console.ReadLine();
            Console.WriteLine("请输入身高: ");
            string high = Console.ReadLine();
            Console.WriteLine($"你好\n您的名字为:{name}\n您的性别为:{gender}\n您的年" +
                $"龄为:{age}\n您的工资为:{income}\n您的身高为:{high}");
            Console.ReadKey();
            #endregion

            #region 符号事项
            /****************
            \n   换行
            \"  输出双引号
            \\  输出\
            \b  输出退格符 删除一个
            \r  回车
            \a  振铃符 响一声
            \t  等于Tab
             ***************/
            Console.WriteLine("\tddd\a");
            Console.ReadKey();
            #endregion

            #region 文件修改
            string str = "GOOG\rGO\nOGGG";
            File.WriteAllText(@"C:\Users\reaga\Desktop\Steam.txt", str);
            Console.WriteLine("写入成功");
            Console.ReadKey();
            #endregion

            #region 算数运算
            int a = 50;
            int b = 10;
            int result = a - b;
            Console.WriteLine(result);
            Console.ReadKey();
            平均分(已解决)
            Console.WriteLine("Yuwen: "); string Yw = Console.ReadLine(); int yw = Convert.ToInt32(Yw);
            Console.WriteLine("Shuxue: "); string Sx = Console.ReadLine(); int sx = Convert.ToInt32(Sx);
            Console.WriteLine("Yingyu: "); string Yy = Console.ReadLine(); int yy = Convert.ToInt32(Yy);
            Console.WriteLine("Huangxue: "); string Hx = Console.ReadLine(); int hx = Convert.ToInt32(Hx);
            Console.WriteLine("Wuli: "); string Wl = Console.ReadLine(); int wl = Convert.ToInt32(Wl);
            int Av = (yw + sx + yy + hx + wl) / 5;
            Console.WriteLine($"Yuwen:{yw}\nShuxue:{sx}\n" +
                $"Yingyu:{yy}\nHuaxue:{hx}\nWuli:{wl}\nPingjun:{Av}");
            Console.ReadKey();
            #endregion

            #region 类型转换
            int i = 10;
            double k = i;
            Console.WriteLine("Anser: ");
            int name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            Console.ReadKey();
            或者
            Console.WriteLine("Anser: ");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);
            Console.WriteLine(Age);
            Console.ReadKey();
            或者强制转换
            int i;
            double d = 30;
            i = (int)d;
            Console.WriteLine(i);
            ---------位数去除-------- -
            转换字符
            double d = 300;
            string D = Convert.ToString(d);    //1 
            string D = d.ToString();           //2
            Console.WriteLine("{0:0.000}", d);
            Console.ReadKey();
            #endregion

            #region 转换加减 冗余变化
            1
            Console.WriteLine("Enter a number:");
            string Number = Console.ReadLine();
            int number = Convert.ToInt32(Number);
            Console.WriteLine(number * 3);
            2
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number * 3);
            //3
            Console.WriteLine("Enter a number:");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 3);
            #endregion

            #region  ++--
            int i = 10;
            i++;
            //++放在前面会立即产生效果
            //++放后面的话需要执行一次才能出现效果
            int L = 10;
            int R = L + L++; //R 20  21
            R++; L--; //R 21 22  L 10 9
            int M = --L + ++R; //8+23
            Console.WriteLine(M);
            int i = 10;
            Console.WriteLine(--i);
            123
            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            5(1) + 6 * 2 + 5 + 5(1)
            other
            int a = 10;
            int b = a-- + ++a * 2 + --a + a++ + a++ + a++;
            //      
            Console.WriteLine($"a = {a}\nb = {b}");
            #endregion

            #region bool and     &&与     ||或    +=
             && 两边必须全部成立
             || 必须成立一边
            int a = 10;
            int b = 10;
            bool c = a >= b;
            Console.Writeline(c);
            Console.Readkey();
            int n = 10;
            n += 20; (n = 30) += n = n + 20
              | 只要成立就不判定后面
              & 第一个成立才判断后面
            #endregion

            #region if
            Console.WriteLine("Write time bro:");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time >= 5 == true)
            {
                Console.WriteLine("Good bro");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not good bro");
                Console.ReadKey();
            }
            #endregion

            #region if       else if         else
            可以一直if
            可以一直else if
            Console.WriteLine("English result:");
            int Score = Convert.ToInt32(Console.ReadLine());
            string Name = Console.ReadLine();
            if (Score > 90)
            {
                Console.WriteLine("so good");
                Console.ReadKey();
            }
            #endregion

            #region 如果 否则 结果
            Console.WriteLine("User Name: ");
            string admin = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string pwd = Console.ReadLine();
            //string ok = admin == "admin" && pwd == "pwd" ? "All Good" : "Error";
            string ok = admin == "admin" && pwd == "pwd" ? "All Good" : "Error";
            Console.WriteLine(ok);
            比大小
            Console.WriteLine("1rd number: ");
            int rd1 = Convert.To Int32(Console.ReadLine());
            Console.WriteLine("2rd number: ");
            int rd2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3rd number: ");
            int rd3 = Convert.ToInt32(Console.ReadLine());
            if (rd1 > rd2 && rd1 > rd3)
            {
                Console.WriteLine(rd1);
                Console.ReadKey();
            }
            if (rd2 > rd1 && rd2 > rd3)
            {
                Console.WriteLine(rd2);
                Console.ReadKey();
            }
            if (rd3 > rd1 && rd3 > rd2)
            {
                Console.WriteLine(rd3);
                Console.ReadKey();
            }
            #endregion

            #region try{}  catch{}  swith
            没信心的代码放try{ }
            如果跳到catch 就说明有问题
            string str = 30 > 20 ? "Hello" : "No";
            WriteLine(str);
            int select;
            WriteLine("Enter selecte number: ");
            select = Convert.ToInt32(ReadLine());
            switch (select)
            {
                case 1:
                    WriteLine("I'm" + select);
                    break;
                case 2:
                    WriteLine("Case2" + select);
                    break;
                default:
                    WriteLine("Normally");
                    break;
            }
            #endregion

            #region Years question
            try
            {
                WriteLine("Enter Years: ");
                int year = Convert.ToInt32(ReadLine());
                WriteLine("Enter months: ");
                int month = Convert.ToInt32(ReadLine());
                int day = Convert.ToInt32(ReadLine());
                switch (month)
                {
                    case 1:
                        day = 31;
                        break;
                    case 2:
                        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
             && 两边必须全部成立
             || 必须成立一边
                        {
                            day = 29;
                        }
                        else
                        {
                            day = 28;
                        }
                        break;
                    case 3:
                        day = 31;
                        break;
                    case 5:
                        day = 31;
                        break;
                    case 7:
                        day = 31;
                        break;
                    case 8:
                        day = 31;
                        break;
                    case 10:
                        day = 31;
                        break;
                    case 12:
                        day = 31;
                        break;
                    default:
                        day = 30;
                        break;
                }
                WriteLine(year + "Year: " + day + "Day: ");
                ReadKey();
            }
            catch
            {
                WriteLine("Something wrong maybe");
            }
            #endregion

            #region while循环 try catch的进一步理解
            try
            {
                int i = 1;
                WriteLine("How many time you wanna loop: ");
                int Sum = Convert.ToInt32(ReadLine());
                while (i <= Sum)
                {
                    WriteLine("Hello {0} world {1}", Sum, i);
                    i++;
                }
                ReadKey();
            }
            catch
            {
                WriteLine("Only number plz !");
                ReadKey();
            }
            // 所以这大概就是try和catch的好处吧，能简化程序
            #endregion

            #region 循环嵌套的自我摸索
            // 10 heelo and 100 fine
            int i = 1;
            int j = 1;
            while (i <= 10)
            {
                WriteLine("Hello {0}", i);
                while (j <= 10)
                {
                    WriteLine("Fine {0}", j);
                    j++;
                }
                j = 1;
                i++;
            }
            ReadKey();
            #endregion

            #region 1-100的sum
            int i = 1, sum = 0;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            WriteLine(sum);
            ReadKey();
            #endregion

            #region break; 重复提示 while的进阶运用
            // 要求账号密码 
            // 答对成功 不然失败
            WriteLine("Enter Username: ");
            string user = ReadLine();
            WriteLine("Enter Password: ");
            string pwd = ReadLine();
            while (user != "333" && pwd != "123")
            {
                WriteLine("login fail");
                WriteLine("Enter Username: ");
                user = ReadLine();
                WriteLine("Enter Password: ");
                pwd = ReadLine();
            }
            WriteLine("Welcome back!");
            ReadKey();
            //if (user != "333" && pwd != "123")
            //{
            //    WriteLine("Fail to login");
            //}
            //else
            //{
            //    WriteLine("Welcome back!"); 
            #endregion

            #region LX4.8
            提示用户输入学生的个数， 然后 姓名 年龄 性别
             再依次输出 年龄总和 平均年龄 用循环
            int i = 1;
            int sum = 0;
            int avg;
            try
            {
                WriteLine("Enter how many study you have: ");
                int count = Convert.ToInt32(ReadLine());
                while (i <= count)
                {
                    WriteLine("Enter {0} Name: ", i);
                    string name = ReadLine();
                    WriteLine("Enter {0} age: ", i);
                    int age = Convert.ToInt32(ReadLine());
                    WriteLine("Enter sex: ");
                    string sex = ReadLine();
                    WriteLine("The {0} Student's Name is {1}, Age is {2}, " +
                        "And sex is {3}", i, name, age, sex);
                    sum = sum + age;
                    i++;
                }
                avg = sum / count;
                WriteLine("Total age is {0}, and avage age is {1}", sum, avg);
                ReadKey();
            }
            catch
            {
                WriteLine("Something wrong maybe");
            }
            #endregion

            #region  Do...while 循环 登录
            int i = 1, sum = 0, avg, count;
            WriteLine("Enter Username: ");
            string user = ReadLine();
            WriteLine("Enter Password: ");
            string pwd = ReadLine();
            while (user != "333" || pwd != "123")
            {
                WriteLine("login fail");
                WriteLine("Enter Username: ");
                user = ReadLine();
                WriteLine("Enter Password: ");
                pwd = ReadLine();
            }
            WriteLine("Welcome back!");
            WriteLine("Enter how many study you have: ");
            count = Convert.ToInt32(ReadLine());
            do
            {
                WriteLine("Enter {0} Name: ", i);
                string name = ReadLine();
                WriteLine("Enter {0} age: ", i);
                int age = Convert.ToInt32(ReadLine());
                WriteLine("Enter sex: ");
                string sex = ReadLine();
                WriteLine("The {0} Student's Name is {1}, Age is {2}, " +
                "And sex is {3}", i, name, age, sex);
                sum = sum + age;
                i++;
            } while (i <= count);
            avg = sum / count;
            WriteLine("Total age is {0}, and avage age is {1}", sum, avg);
            ReadKey();
            // && 两边必须全部成立
            // ||必须成立一边
            #endregion

            #region for
            int i = 1;
            WriteLine("Repeat time: ");
            int count = Convert.ToInt32(ReadLine());
            while (i <= count)
            {
                WriteLine("Repeat " + i);
                i++;
            }
            ReadKey();
            // For
            for (int i = 1; i <= 10; i++)
            {
                WriteLine("Repeat " + i);
            }
            ReadKey();
            #endregion

            #region 练习题 总和 倒叙 奇数偶数
            // 总和
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = i + sum;
            }
            WriteLine("Sum = " + sum);
            ReadKey();
            // 倒叙
            for (int i = 10; i >= 1; i--)
            {
                WriteLine(i);
            }
            ReadKey();
            // 奇数偶数
            int sum1 = 0, sum2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = i + sum1;
                }
                if (i % 2 != 0)
                {
                    sum2 = i + sum2;
                }
            }
            WriteLine("O: " + sum1);
            WriteLine("Q: " + sum2);
            ReadKey();
            #endregion

            #region 9*9 list
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Write("{0}*{1}=" + j * i + " ", j, i);
                }
                WriteLine();
            }
            ReadKey();
            #endregion

            #region LX5.7  需要注意
            WriteLine("Enter a number: ");
            int count = Convert.ToInt32(ReadLine());
            for (int i = 0; i <= count; i++)
            {
                WriteLine("{0} + {1} = {2}", i, count - i, count);
            }
            ReadKey();
            #endregion

            #region  parse and tryParse 解析
            int Number = 0;
            bool b = int.TryParse("123a", out Number);
            WriteLine(b);
            WriteLine(Number);
            ReadKey();
            // 我的理解是先建立一个容器，再转换内容，out是指向标
            #endregion

            #region 最大范围的检测
            int i = int.MaxValue;
            int j = int.MinValue;
            short s = short.MaxValue;
            short ss = short.MinValue;
            long l = long.MaxValue;
            long ll = long.MinValue;
            WriteLine(i); WriteLine(j);
            WriteLine(s); WriteLine(ss);
            WriteLine(l); WriteLine(ll);
            ReadKey();
            #endregion

            #region continue and break
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    WriteLine("{0}+{1}={2}", i, j, i + j);
                    continue;  //all code blow here are not working
                    Write("Nice");
                    break;
                    WriteLine("those two has small diffrient");
                    WriteLine("continue blow dont work");
                    WriteLine("break will will stop{ }");
                }
            }
            #endregion

            #region Random             Random
            Random r = new Random();   //面向对象
            int n = r.Next(1, 100);  // .Next 负责在范围内抽出整数发送给int n
            WriteLine("Random number: " + n);
            ReadKey();
            #endregion

            #region LX Random
            Random r = new Random();   //面向对象
            int n = r.Next(1, 3);  // .Next 负责在范围内抽出整数发送给int n
            switch (n)
            {
                case 1:
                    WriteLine("Sometime i feel sorry   {0}", n);
                    break;
                case 2:
                    WriteLine("But i dont have to much time   {0}", n);
                    break;
                case 3:
                    WriteLine("Its my hard time   {0}", n);
                    break;
            }
            ReadKey();
            #endregion

            #region Get time
            DateTime dl = DateTime.Now;  //获取本地时间
            WriteLine(dl);
            int year = dl.Year; WriteLine(year);
            int month = dl.Month; WriteLine(month);
            int day = dl.Day; WriteLine(day);
            int hour = dl.Hour; WriteLine(hour);
            int min = dl.Minute; WriteLine(min);
            int sec = dl.Second; WriteLine(sec);
            WriteLine("{0}-{1}-{2}  {3}:{4}", year, month, day, hour, min);
            ReadKey();
            #endregion

            #region const 常量
            //变量可以多次赋值 但是常量只能赋值一次
            const int number = 10;
            WriteLine(number);
            #endregion

            #region  枚举 6.2-6.4
            top line 14
            Person p = Person.boy;
            WriteLine(p); ReadKey();
            // also here
            / boy, 0
 / girl,1
/ one, 2
/ two  3
            int number = 2;
            Person p1 = (Person)number;
            WriteLine(p1);
            // other type int to int
            WriteLine((int)Person.boy);
            WriteLine((int)Person.girl);
            WriteLine((int)Person.one);
            WriteLine((int)Person.two);
            WriteLine(Convert.ToInt32(Person.two));
            WriteLine(Convert.ToUInt32(Person.two));
            // part 2 to string
            string p = Person.two.ToString();
            string p1 = Convert.ToString(Person.two);
            WriteLine(p); WriteLine(p1); ReadKey();
            // part 3  string to enmu
            //            boy,   0
            //            girl,  1
            //            one,   2
            //            two    3
            string str = "2";
            int n = Convert.ToInt32(str);
            Person p = (Person)n;
            WriteLine(p); ReadKey();
            // str必须转换int后才能有用
            string str = "2";
            Person pp = (Person)Enum.Parse(typeof(Person), str);
            WriteLine(pp); ReadKey();
            #endregion

            #region
            //public enum season
            //{
            //    spring,
            //    summer,
            //    autumn,
            //    winter
            //}
            WriteLine("Enter a month: ");
            string month = ReadLine();
            switch (month)
            {
                case "1":
                case "2":
                case "3":
                    season spr = (season)Enum.Parse(typeof(season), month);
                    WriteLine(spr);
                    break;
                case "4":
                case "5":
                case "6":
                    season sum = (season)Enum.Parse(typeof(season), month);
                    WriteLine(sum);
                    break;
                case "7":
                case "8":
                case "9":
                    season aut = (season)Enum.Parse(typeof(season), month);
                    WriteLine(aut);
                    break;
                case "10":
                case "11":
                case "12":
                    season win = (season)Enum.Parse(typeof(season), month);
                    WriteLine(win);
                    break;
                default:
                    WriteLine("Wrong number");
                    break;
            }
            ReadKey();
            #endregion

            #region struct
            Tixi jiegou;
            jiegou.Name = "San";
            jiegou.Age = 20;
            jiegou.Gender = 'M';
            jiegou.Phone = 123456789;
            jiegou.Xi = "Math";
            WriteLine(jiegou.Name + jiegou.Age + jiegou.Gender + jiegou.Phone + jiegou.Xi);
            ReadKey();
            //// 2rd person information here
            Tixi jiegou1;
            jiegou1.Name = "San";
            jiegou1.Age = 20;
            jiegou1.Gender = 'M';
            jiegou1.Phone = 123456789;
            jiegou1.Xi = "Math";
            WriteLine(jiegou1.Name + jiegou1.Age + jiegou1.Gender + jiegou1.Phone + jiegou1.Xi);
            #endregion

            #region struct and Enum  附加访问
            Tixi jiegou;
            jiegou.xingbie = Gender.boy;
            jiegou.Name = "Wang";
            jiegou.Fujia._Name = "WangWang";           // 附加访问
            WriteLine(jiegou.Name + jiegou.xingbie);   // Enum
            ReadKey();
            #endregion

            #region 数组的结构
            //存储多个相同类型变量
            //  数组类型[]  数组名  =  new  数组类型[长度]
            int[] Number = new int[10];
            ////  new int 相当于是在内存里开了10个int空间 所以要用new
            ////  如果要使用数组 那么就要用数组的下标
            Number[0] = 40; Number[1] = 10; Number[2] = 55;
            Number[3] = 15; Number[4] = 20; Number[5] = 10;
            Number[6] = 10; Number[7] = 30; Number[8] = 70;
            Number[9] = 10;
            for (int i = 0; i < Number.Length; i++)
            {
                Write(Number[i] + " ({0})  ", i + 1);
            }
            ReadKey();
            /////////////////////////////////////////////
            try
            {
                WriteLine("Enter 10 Number: ");
                int[] Number = new int[10];
                for (int i = 0; i < Number.Length; i++)
                {
                    Number[i] = Convert.ToInt32(ReadLine());
                }
                for (int i = 0; i < Number.Length; i++)
                {
                    Write(Number[i] + " ");
                }
                ReadKey();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            #endregion

            #region LX 6.9
            WriteLine("How many people: ");
            int Count = Convert.ToInt32(ReadLine()); int sum = 0, arg;
            string[] Name = new string[Count]; int[] Age = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                WriteLine("Enter the {0}rd name: ", i + 1); Name[i] = ReadLine();
                WriteLine("Enter the {0}rd age: ", i + 1); Age[i] = Convert.ToInt32(ReadLine());
                sum = sum + Age[i];
            }
            arg = sum / Count;
            for (int i = 0; i < Count; i++)
            {
                WriteLine("Name: {0}\nAge: {1}", Name[i], Age[i]);
            }
            WriteLine("Sum: {0}\nArg: {1}", sum, arg);
            ReadKey();
            #endregion

            #region first bigger 6.10
            int[] Count = new int[3];
            for (int i = 0; i < Count.Length; i++)
            {
                WriteLine("Enter {0}rd number: ", i + 1);
                Count[i] = Convert.ToInt32(ReadLine());
            }
            if (Count[0] > Count[1] && Count[0] > Count[2])
            {
                WriteLine(Count[0]);
            }
            if (Count[1] > Count[0] && Count[1] > Count[2])
            {
                WriteLine(Count[1]);
            }
            if (Count[2] > Count[0] && Count[2] > Count[1])
            {
                WriteLine(Count[2]);
            }
            ReadKey();
            //////////////////////////////////////////////////////
            string[] str = { "H", "G", "T", "C" };
            for (int i = 0; i < str.Length - 1; i++)
            {
                Write(str[i] + "|");
            }
            Write(str[str.Length - 1]);
            ReadKey();
            #endregion

            #region Interview Quetion
            string[] name = { "I", "Am", "Good" };
            for (int i = 0; i < name.Length; i++)
            {
                string temp = name[i];
                name[i] = name[name.Length - 1 - i];
                name[name.Length - 1 - i] = temp;
            }
            for (int i = 0; i < name.Length; i++)
            {
                Write(name[i]);
            }
            ReadKey();
            #endregion

            #region 函数引用
            // 如果调用的类型不在第一个类别里 需要提出    类.函数
            int n = Show(10, 20);
            WriteLine(n);
            WriteLine("Enter name: ");
            string Name = Nice();
            WriteLine(Name);
            ReadKey();
            #endregion

            #region LX 7
            int number = 2; int n = Test(number); WriteLine(n); ReadKey();
            #endregion

            #region Serching away to Finish(Pass)
            WriteLine("How many number u want: "); int count = Convert.ToInt32(ReadLine());
            int[] number = new int[count];

            for (int i = 0; i < count; i++)
            {
                WriteLine("Enter the {0}rd number: ", i + 1); number[i] = Convert.ToInt32(ReadLine());
            }
            int Max = number[0]; int Min = number[0];
            for (int i = 0; i < count; i++)
            {
                if (number[i] >= Max)
                {
                    Max = number[i];

                }
                if (number[i] <= Min)
                {
                    Min = number[i];
                }
            }
            WriteLine("Max: {0}\nMin: {1}", Max, Min); ReadKey();
            #endregion

            #region Serching away to Finish(Pass)  2.0
            int n1 = 0, n2 = 0, n3 = 0; WriteLine("Enter 3 number: ");
            n1 = Convert.ToInt32(ReadLine()); n2 = Convert.ToInt32(ReadLine());
            n3 = Convert.ToInt32(ReadLine());
            GetMax(n1, n2, n3);
            #endregion

            #region 7.5 Enter number
            while (true)
            {
                WriteLine("Enter a number plz: ");
                try
                {
                    int number = Convert.ToInt32(ReadLine());
                    WriteLine(number);
                    ReadKey();
                    break;
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            }
            #endregion

            #region out out out out out out
            WriteLine("Enter how many number you want: ");
            int Count = Convert.ToInt32(ReadLine());
            int[] number = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                WriteLine("Enter {0} number: ", i + 1);
                number[i] = Convert.ToInt32(ReadLine());
            }
            int[] number_2 = Getsum(number);
            WriteLine("Sum {0}, Avg {1}", number_2[0], number_2[1]);
            ReadKey();
            #endregion

            #region out XL
            int[] num = { 1, 2, 3, 4, 5, 6, 11, 2, 2333, 22 };
            int sum = 0; int avg;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            avg = sum / num.Length;
            WriteLine("Sum: {0}\nAvg: {1}", sum, avg);
            ReadKey();
            /////////////////////////////////////////////////////
            WriteLine("Enter yes: ");
            string anser = ReadLine();
            while (anser != "yes")
            {
                WriteLine("Enter yes: ");
                anser = ReadLine();
            }
            ////////////////////////////////////////////////////
            / Max Min Avg Sum
            int[] num = { 1, 2, 3, 4, 5, 6, 11, 2, 2333, 22 };
            int[] num1 = Getnum(num);
            WriteLine("Sum: {0}\nAvg: {1}\nMax: {2}\nMin: {3}", num1[0], num1[1], num1[2], num1[3]);
            ReadKey();
            #endregion

            #region out out out out out out out out out out 77
            WriteLine("Enter how many number u need: ");
            int Count = Convert.ToInt32(ReadLine());
            int sum, avg; int[] number = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                WriteLine("Enter the {0} number: ", i + 1);
                number[i] = Convert.ToInt32(ReadLine());
            }
            GetSum(number, out avg, out sum);
            #endregion

            #region 78XL
            while (true)
            {
                WriteLine("Enter User name and password: ");
                string[] UserLogin = new string[2];
                for (int i = 0; i < UserLogin.Length; i++)
                {
                    UserLogin[i] = ReadLine();
                }
                string Onok = CheckLogin(UserLogin);
                try
                {
                    if (Onok == "Login good")
                    {
                        WriteLine("Welcome back");
                        WriteLine("Enter {0}rd student name, gender, age:", ++i);
                        string[] name = new string[3]; char[] gender = new char[3];
                        int[] age = new int[3]; int sum = 0;

                        for (int j = 0; j < name.Length; j++)
                        {
                            name[j] = ReadLine();
                            gender[j] = Convert.ToChar(ReadLine());
                            age[j] = Convert.ToInt32(ReadLine());
                        }
                        Student(out sum, age);
                        WriteLine("Age's Sum is {0}, Age's avg is {1}", sum, sum / age.Length);
                    }
                    else if (Onok == "Faild")
                    {
                        while (true)
                        {
                            WriteLine("Check your password or username");
                            WriteLine("Enter User name and password: ");
                            string[] Login = new string[2];
                            for (int i = 0; i < Login.Length; i++)
                            {
                                UserLogin[i] = ReadLine();
                            }
                            Onok = CheckLogin(Login);
                            if (Onok == "Login good")
                            {
                                WriteLine("Welcome back");
                                WriteLine("Enter {0}rd student name, gender, age:", ++i);
                                string[] name = new string[3]; char[] gender = new char[3];
                                int[] age = new int[3]; int sum = 0;

                                for (int j = 0; j < name.Length; j++)
                                {
                                    name[j] = ReadLine();
                                    gender[j] = Convert.ToChar(ReadLine());
                                    age[j] = Convert.ToInt32(ReadLine());
                                }
                                Student(out sum, age);
                                WriteLine("Age's Sum is {0}, Age's avg is {1}", sum, sum / age.Length);
                                break;
                            }
                        }
                    }
                    else if (Onok == "You have to enter something")
                    {
                        WriteLine("You should enter something");
                    }
                    else
                    {
                        WriteLine("Something may wrong");
                    }
                    ReadKey();
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                    throw;
                }
            }
            #endregion

            #region 7.10 ref 无返回值 带回 ref ref ref ref ref ref ref ref ref ref ref ref ref ref 
            //7.10
            double mon = 5000;
            double d = Edit1(mon);
            WriteLine(d);
            ReadKey();
            //7.10
            7.10.1
            double mon = 5000;
            Edit(ref mon);
            WriteLine(mon);
            ReadKey();
            #endregion

            #region 7.11 params 1.0
            int[] number = { 1, 2, 3, 4, 5, 6 };
            Sum(number); ReadKey();
            7.11 params 1.1-------------------- - 1.1
            Sum(1, 2, 3, 4, 5, 6); ReadKey();
            #endregion

            #region 7.12 重载 reload
            in some satuation, a(double a, double b + 1)can hoding double 1 2 3
            #endregion

            #region Digui 7.13
            WriteLine("Enter your UserNmae; "); string Name = ReadLine();
            WriteLine("Enter your Password; "); string Pwd = ReadLine();
            Login(Name, Pwd); ReadKey();
            #endregion

            #region Air Game
            Make a small game here
            need 2 player in three
            Using Random to switch number
            Using string to make player see where are they
            using limit number to const like 1 - 8
            using diffrient logo to make a Maps
            Using print to DrawMap
            Using * *************************
            using **************************
            using **************************
            Using //////////////////////////
            using //////////////////////////
            using //////////////////////////
            using **************************
            using namespace
            Total long = long + 3
            Total Ku = Ku + long
            print("{0}{1}{2]", long, ku, long + ku)
            using namespace,using Console.WriteLine
            using namespace,using print("********{0}********",long)
            //////////////////////////////
            Gameshow();
    PlayerNameINfo();
    INfoGame();
    InitailMap();
    DrawMap();
    PlayerLocat();
    ReadKey();
    #endregion

    #region 面向对象的结构


    #endregion

    }


    #region Air Game all
    public static int[] Maps = new int[100];
    public static int[] PlayerPos = new int[2];
    public static string[] PlayerName = new string[2];
    static bool[] Flag = new bool[2];

    public static void Gameshow()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        WriteLine("****************************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteLine("****************************************");
        Console.ForegroundColor = ConsoleColor.Blue;
        WriteLine("****************************************");
        Console.ForegroundColor = ConsoleColor.Cyan;
        WriteLine("*************** Air Game ***************");
        Console.ForegroundColor = ConsoleColor.Blue;
        WriteLine("****************************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteLine("****************************************");
        Console.ForegroundColor = ConsoleColor.Red;
        WriteLine("****************************************");
        WriteLine("                                        ");
    }

    public static void PlayerLocat()
    {
        while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
        {
            if (Flag[0] == false)
            {
                PlayGame(0);
            }
            else
            {
                Flag[0] = false;
            }
            if (PlayerPos[0] >= 99)
            {
                WriteLine("玩家{0}赢了玩家{1}", PlayerName[1], PlayerName[0]); break;
            }
            if (Flag[1] == false)
            {
                PlayGame(1);
            }
            else
            {
                Flag[1] = false;
            }
        }
    }

    public static void PlayerNameINfo()
    {
        Console.ForegroundColor = ConsoleColor.White;
        WriteLine("请输入第一个玩家的名字:");
        PlayerName[0] = ReadLine();
        while (PlayerName[0] == "")
        {
            WriteLine("玩家1的名字不能为空, 请重新输入:");
            PlayerName[0] = ReadLine();
        }
        WriteLine("请输入第二个玩家的名字:");
        PlayerName[1] = ReadLine();
        while (PlayerName[1] == "" || PlayerName[0] == PlayerName[1])
        {
            WriteLine("玩家2的名字不能为空或与1一致, 请重新输入:");
            PlayerName[1] = ReadLine();
        }
        Clear();
        Gameshow();
        WriteLine("");
    }

    public static void INfoGame()
    {
        Console.ForegroundColor = ConsoleColor.White;
        WriteLine("{0}的士兵用A表示", PlayerName[0]);
        WriteLine("{0}的士兵用B表示", PlayerName[1]); WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Write("幸运轮盘: ○     ");
        Console.ForegroundColor = ConsoleColor.Red;
        Write("地雷: ☆     ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Write("时空隧道: ◇");
        Console.ForegroundColor = ConsoleColor.White;
        WriteLine(""); WriteLine("");
    }

    public static void PlayGame(int playerNumber)
    {
        Random r = new Random(); int rNumber = r.Next(1, 7);
        WriteLine(""); WriteLine(""); WriteLine("{0} 按任意按键开始掷骰子", PlayerName[playerNumber]);
        ReadKey(true); WriteLine("{0}掷出了{1}", PlayerName[playerNumber], rNumber);
        PlayerPos[playerNumber] += rNumber; ReadKey(true);
        WriteLine("{0}按任意键开始行动", PlayerName[playerNumber]); ReadKey(true);
        WriteLine("{0}行动完了", PlayerName[playerNumber]); ReadKey(true);
        if (PlayerPos[playerNumber] == PlayerPos[1 - playerNumber])
        {
            WriteLine("玩家{0}踩到了玩家{1}, 玩家{2}退3格", PlayerName[playerNumber],
                PlayerName[1 - playerNumber], PlayerName[1 - playerNumber]);
            PlayerPos[1 - playerNumber] -= 3; ReadKey(true);
            if (PlayerPos[playerNumber] <= 0)
            {
                PlayerPos[playerNumber] = 0;
            }
            if (PlayerPos[1 - playerNumber] <= 0)
            {
                PlayerPos[1 - playerNumber] = 0;
            }
        }
        else
        {
            switch (Maps[playerNumber])
            {
                case 0:
                    WriteLine("玩家{0}踩到了方块, 安全", PlayerName[playerNumber]);
                    break;
                case 1:
                    WriteLine("玩家{0}踩到了幸运轮盘, 请选择");
                    WriteLine("1 - 交换位置");
                    WriteLine("2 - 轰炸对方"); string input = ReadLine();
                    while (true)
                    {
                        if (input == "1")
                        {
                            WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerName[playerNumber], PlayerName[1 - playerNumber]);
                            ReadKey(true); int jiaohuan1 = PlayerPos[playerNumber];
                            PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                            PlayerPos[1 - playerNumber] = jiaohuan1;
                            WriteLine("交换完成! 按任意键继续"); ReadKey(true); break;
                        }
                        else if (input == "2")
                        {
                            WriteLine("玩家{0}轰炸了玩家{1},玩家{2}退6格", PlayerName[playerNumber],
                                PlayerName[1 - playerNumber], PlayerName[1 - playerNumber]); ReadKey(true);
                            PlayerPos[1 - playerNumber] -= 6;
                            WriteLine("玩家{0}退了 6格", PlayerName[1 - playerNumber]); ReadKey(true); break;
                        }
                        else
                        {
                            WriteLine("只能输入1或2:"); input = ReadLine();
                        }
                    }
                    break;
                case 2:
                    WriteLine("玩家{0}踩到了地雷,退6格", PlayerName[playerNumber]); ReadKey(true);
                    PlayerPos[playerNumber] -= 6;
                    break;
                case 3:
                    WriteLine("玩家{0}踩到了暂停,暂停一回合", PlayerName[playerNumber]); ReadKey(true);
                    Flag[playerNumber] = true;
                    break;
                case 4:
                    WriteLine("玩家{0}踩到了时空隧道,前进6格", PlayerName[playerNumber]);
                    PlayerPos[playerNumber] += 6; ReadKey(true);
                    break;

            }
        }
        ReadKey(); Clear(); Gameshow(); INfoGame(); DrawMap();

    }

    public static void InitailMap()
    {
        int[] luckturn = { 6, 23, 40, 55, 69, 83 };
        for (int i = 0; i < luckturn.Length; i++)
        {
            Maps[luckturn[i]] = 1;
        }
        int[] LandMine = { 5, 13, 17, 33, 3, 50, 64, 80, 94 };
        for (int i = 0; i < LandMine.Length; i++)
        {
            Maps[LandMine[i]] = 2;
        }
        int[] pause = { 9, 27, 60, 93 };
        for (int i = 0; i < pause.Length; i++)
        {
            Maps[pause[i]] = 3;
        }
        int[] timeTunnel = { 20, 25, 42, 63, 2, 8, 90 };
        for (int i = 0; i < timeTunnel.Length; i++)
        {
            Maps[timeTunnel[i]] = 4;
        }
    }
    public static void DrawMap()
    {
        for (int i = 0; i < 30; i++)
        {
            Write(DrawStringMap(i));
        }
        WriteLine();

        for (int i = 30; i < 35; i++)
        {
            for (int j = 0; j <= 28; j++)
            {
                Write("  ");
            }
            Write(DrawStringMap(i));
            WriteLine();
        }

        for (int i = 64; i >= 35; i--)
        {
            Write(DrawStringMap(i));
        }
        WriteLine();

        for (int i = 65; i <= 69; i++)
        {
            WriteLine(DrawStringMap(i));
        }

        for (int i = 70; i <= 99; i++)
        {
            Write(DrawStringMap(i));
        }
    }
    public static string DrawStringMap(int i)
    {
        string str = "";
        if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
        {
            str = "<>";
        }
        else if (PlayerPos[0] == i)
        {
            str = "A";
        }
        else if (PlayerPos[1] == i)
        {
            str = "B";
        }
        else
        {
            switch (Maps[i])
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.White;//正常
                    str = "□";
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;//幸运
                    str = "○";
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;//地雷
                    str = "☆";
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    str = "△";
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;//时空
                    str = "◇";
                    break;
            }
        }
        return str;
    }
        #endregion

        7.13
        public static void Login(string Name, string Pwd)
    {
        if (Name == "123" || Pwd == "456")
        {
            WriteLine("Good");
        }
        else
        {
            WriteLine("Someting woring with your password or username");
            WriteLine("Enter your UserNmae; "); Name = ReadLine();
            WriteLine("Enter your Password; "); Pwd = ReadLine();
            Login(Name, Pwd);
        }
    }
        //digui7.13------------------------------------------------------------------------
        7.11 params 1.0
        public static void Sum(int[] Number)
    {
        int sum = 0;
        for (int i = 0; i < Number.Length; i++)
        {
            sum += Number[i];
        }
        WriteLine(sum);
    }
        7.11 params 1.1------------------------1.1
        public static void Sum(params int[] Number)
    {
        int sum = 0;
        for (int i = 0; i < Number.Length; i++)
        {
            sum += Number[i];
        }
        WriteLine(sum);
    }
    //7.11 params---------------------------------------------------------------------------------
    //7.10.1 ref 无返回值 带回--------------------------------------------------------------------
    public static void Edit(ref double mon)
    {
        mon += 300;
    }
    //7.10 ref 无返回值 带回
    public static double Edit1(double mon)
    {
        return mon += 300;
    }
    //7.10 ref 无返回值 带回
    public static void Edit2(double mon)
    {
        mon -= 300;
    }
    //7.10.1 ref 无返回值 带回--------------------------------------------------------------------
    //78XL return to anaser---------------------------------------------------------------------
    public static string CheckLogin(string[] UserLogin)
    {
        if (UserLogin[0].Length <= 0 || UserLogin[1].Length <= 0)
        {
            return "You have to enter something";
        }
        if (UserLogin[0] == "123" || UserLogin[1] == "4")
        {
            return "Login good";
        }
        else
        {
            return "Faild";
        }
    }
    //78XL 
    public static void Student(out int Sum, int[] Age)
    {

        int sum = 0;
        for (int i = 0; i < Age.Length; i++)
        {
            sum += Age[i];
        }
        Sum = sum;
        for (int i = 0; i < Name.Length; i++)
        {
            WriteLine("My name is {0}, My gender is {1}, My age is {2}", Name[i], Gender[i], Age[i]);
        }
        //78XL ----------------------------------------------------------------------------------------

    }
    public static void GetSum(int[] nNumber, out int avg, out int sum) ////77
    {
        int j = 0;
        for (int i = 0; i < nNumber.Length; i++)
        {
            j = j + nNumber[i];
        }
        sum = j;
        avg = sum / nNumber.Length;
    }
    public static int[] Getnum(int[] num) //out XL
    {
        int[] number = new int[4]; int sum = 0; int max = 0, min = num[0], avg;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];//sum
        }
        avg = sum / num.Length; //avg
        for (int i = 0; i < num.Length; i++)//max min
        {
            if (num[i] >= max)
            {
                max = num[i];
            }
            if (num[i] <= min)
            {
                min = num[i];
            }
        }
        number[0] = sum; number[1] = avg; number[2] = max; number[3] = min;
        return number;
    }
    public static int[] Getsum(int[] nCount)
    {
        int[] number = new int[2];
        int sum = 0;
        for (int i = 0; i < nCount.Length; i++)
        {
            sum += nCount[i];
        }
        number[0] = sum;
        number[1] = sum / nCount.Length;
        return number;
    }
    public static void XXX it more like value box, and u can use it when u need to use
    public static void GetMax(int one, int two, int three) //Serching away to Finish(Pass)  2.0
    {
        if (one > two && one > three)
        {
            WriteLine(one);
        }
        if (two > one && two > three)
        {
            WriteLine(two);
        }
        if (three > one && three > two)
        {
            WriteLine(three);
        }
    }

    public static int Test(int number)
    {
        number = number + 3;
        //WriteLine(number);
        return number;
    }
    公有 void 没有返回值
     我认为函数的主要作用是在于简化需要调用很多功能的程序

    public static string Nice()
    {
        string Nice = ReadLine();
        WriteLine("Loading Name, Wait---");
        return Nice;
    }
    public static int Show(int i, int j)
    {
        int sum = i + j;
        return sum;
    }


    }