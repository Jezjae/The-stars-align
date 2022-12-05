using System;

namespace TheStarsAlign
{
    class MainApp
    {
        static void Main(string[] args)
        {

            String selectNum = "";
            int number = 0;


            //while문
            string answer = "1";
            while (answer == "1")
            {
                Console.Clear();
                printMainMenu();
                select();

                Console.WriteLine("첫 화면으로 돌아가려면 '1'을, 종료하기는 '아무 키'를 누르세요.");
                
                answer = Console.ReadLine();
            }


            void printMainMenu()
            {
                Console.WriteLine("　　 　＊ 　　　　　　　　　　★　　　　　　");
                Console.WriteLine("　　★　　　　　＊　　　　　　　　　　＊　　");
                Console.WriteLine("　　　　　　　　　　　　　　　　　　　　　　");
                Console.WriteLine("　　　＊　　　　　　　　　　＊　　　　　　　");
                Console.WriteLine("　　　　　　　★  　　　　　　　    　　　　");
                Console.WriteLine("　　　　　　　　　The 　　　　　　＊　　　　");
                Console.WriteLine("　＊　　　　　   　  stas      　   　　    ");
                Console.WriteLine("　　　　　　　　　　align　★ 　　　　　　　");
                Console.WriteLine("　　　　　＊　  　　 　　　　　     ★　　  ");
                Console.WriteLine("　　　　　　　　　　　　　　　＊　　　  　　");
                Console.WriteLine("　　　　＊　　　　　　　　　　　　　　　 ＊ ");
                Console.WriteLine("　　　　　　　　★　　＊　　  　　　　　　　");
                Console.WriteLine("　　★　　　　　　　　　　　　　　　　＊　　");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("★＊　　　　　　　          　　　　　　　　　＊★");
                Console.WriteLine("＊★　　　　　 　　M　E　N　U　　　　　 　　　★＊");
                Console.WriteLine("★＊　　  　　　　　　　　　　　　　　　　    ＊★");
                Console.WriteLine("＊★　　　 　    　1. 사각형　　　　    　　　★＊");
                Console.WriteLine("★＊　　　　     　2. 삼각형　　　　　   　 　＊★");
                Console.WriteLine("＊★　　　　     　3. 역삼각형　　　　 　   　★＊");
                Console.WriteLine("★＊　　　　    　 4. 다이아몬드　　　 　 　  ＊★");
                Console.WriteLine("＊★　　　　    　 5. 모래시계　　　　 　 　  ★＊");
                Console.WriteLine("★＊　　　　　　　          　　　　　　　　　＊★");
                Console.WriteLine("＊★　　　　　　　          　　　　　　　　　★＊");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("　　　　원하시는 번호를 선택하세요 ! | 번호 : ");
                selectNum = Console.ReadLine();
            }



            void select()
            {
                switch (selectNum)
                {

                    case ("1"):
                        Console.Clear();
                        Console.WriteLine("★*사각형*★");
                        Console.WriteLine();
                        Console.Write("숫자를 입력하세요 : ");

                        string a = Console.ReadLine();
                        number = Convert.ToInt32(a);

                        Console.WriteLine();
                    
                        Console.WriteLine();

                        makeRectangle(number);

                        Console.WriteLine();
       
                        break;

                    case ("2"):
                        Console.Clear();
                        Console.WriteLine("★*삼각형*★");
                        Console.WriteLine();
                        Console.Write("숫자를 입력하세요 : ");

                        string b = Console.ReadLine();
                        number = Convert.ToInt32(b);

                        Console.WriteLine();
                        
                        Console.WriteLine();

                        makeTriangle(number);

                        Console.WriteLine();
                        
                        break;

                    case ("3"):
                        Console.Clear();
                        Console.WriteLine("★*역삼각형*★");
                        Console.WriteLine();
                        Console.Write("숫자를 입력하세요 : ");

                        string c = Console.ReadLine();
                        number = Convert.ToInt32(c);

                        Console.WriteLine();
                        
                        Console.WriteLine();

                        makeV(number);

                        Console.WriteLine();
                       
                        break;

                    case ("4"):
                        Console.Clear();
                        Console.WriteLine("★*다이아몬드*★");
                        Console.WriteLine();
                        Console.Write("숫자를 입력하세요 : ");

                        string d = Console.ReadLine();
                        number = Convert.ToInt32(d);

                        Console.WriteLine();
                        
                        Console.WriteLine();

                        makeDiamond(number);

                        Console.WriteLine();
                        
                        break;

                    case ("5"):
                        Console.Clear();
                        Console.WriteLine("★*모래시계*★");
                        Console.WriteLine();
                        Console.Write("숫자를 입력하세요 : ");

                        string e = Console.ReadLine();
                        number = Convert.ToInt32(e);

                        Console.WriteLine();
                        
                        Console.WriteLine();

                        makeSandglass(number);

                        Console.WriteLine();
                   
                        break;

                    default:
                        Console.WriteLine("다시 입력해주세요!");
                        break;
                }
            }


            // 사각형
            void makeRectangle(int number)
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            // 삼각형
            void makeTriangle(int number)
            {
                for (int i = number; i >= 0; i--)
                {
                    for (int j = 0; j < number * 2 - 1; j++)
                    {
                        if (j >= i && j <= number * 2 - 2 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // 역삼각형
            void makeV(int number)
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number * 2 - 1; j++)
                    {
                        if (j >= i && j <= number * 2 - 2 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // 다이아몬드
            void makeDiamond(int number)
            {
                for (int i = number; i >= 0; i--)
                {
                    for (int j = 0; j < number * 2 - 1; j++)
                    {
                        if (j >= i && j <= number * 2 - 2 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < number; i++)
                {
                    for (int j = 0; j < number * 2 - 1; j++)
                    {
                        if (j >= i && j <= number * 2 - 2 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // 모래시계
            void makeSandglass(int number)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    for (int j = 0; j < number * 2 - 1; j++)
                    {
                        if (j >= i && j <= number * 2 - 2 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = number - 1; i >= 0; i--)
                {
                    for (int j = 0; j < number * 2 - 1; j++)
                    {
                        if (j >= i && j <= number * 2 - 2 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }




            /* 해보려했는데 안됨.
            void endindMent()
            {
                string endNum = Console.ReadLine();

                if (endNum == "1")
                {
                    Console.Clear();
                    printMainMenu();
                }
                
                else if (endNum == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("다시 입력하시오.");
                }
                */
        }
    }

}

