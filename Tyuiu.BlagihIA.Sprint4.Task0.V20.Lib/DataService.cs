﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BlagihIA.Sprint4.Task0.V20.Lib
{
    public class DataService : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int  sum= 1;
            for (int i=0; i <array.Length; i++)
            {
                if (array[i] % 2 ==0)
                {
                    sum *=array[i];
                }
            }
            return sum;
        }
    } 
}
