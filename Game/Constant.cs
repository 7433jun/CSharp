﻿using System;

namespace Game
{
    public class GameObject
    {
        // Run-Time 상수
        // 선언과 동시에 초기화를 하지 않아도 됩니다.
        readonly int itemID;

        // Compile-Time 상수
        // 선언과 동시에 초기화
        const float pi = 3.141592f;

        public GameObject()
        {
            // readonly는 생성자에서 단 한번 초기화
            // 재 컴파일을 안하는 장점이 있다
            itemID = 1493;
        }
    }

    internal class Program
    {
        static void Function1()
        {
            Function2();
        }

        #region 스택 풀기
        // 예외가 발생한 함수에서 예외가 처리되지 않으면
        // 상위 함수로 돌아가서 예외를 처리하는 과정입니다.
        static void Function2()
        {
            throw new Exception("My Exception");
            Console.WriteLine("실행"); // 실행안됨
        }
        #endregion

        static void Main(string[] args)
        {
            #region 예외 처리

            // int[] array = new int[3];
            // 
            // try
            // {
            //     //int x = 10;
            //     //int y = 0;
            //     //int result = x / y;
            // 
            //     //for(int i = 0; i < 5; i++)
            //     //{
            //     //    array[i] = i;
            //     //}
            // 
            //     Function1();
            // 
            //     Console.WriteLine("Console");
            // }
            // catch(Exception error)
            // {
            //     Console.WriteLine(error);
            // }
            // finally
            // {
            //     Console.WriteLine("Close");
            // }
            #endregion

            #region 최소 공배수
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //
            //int div = 1;
            //for(int i = 1; i <= x && i <= y; i++)
            //{
            //    if(x % i == 0 && y % i == 0)
            //    {
            //        div = i;
            //    }
            //}
            //
            //Console.WriteLine(x * y / div);
            #endregion
        }
    }
}