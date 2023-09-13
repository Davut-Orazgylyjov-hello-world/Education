using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива:");
            var array = new int[GetUserNum()];
            
            Exercise1(ref array);
            
            Exercise2(ref array);
      
            Exercise3(ref array);
        }

        private static void Exercise1(ref int[] array)
        {
            Console.WriteLine("Введите новый размер массива:");
            ResizeCustom(ref array,GetUserNum());

            Console.WriteLine($"Длина массива: {array.Length}");
        }
        private static void Exercise2(ref int[] array)
        {
            Console.WriteLine("Введите индекс массива куда добавить элемент:");
            Insert(ref array,5,GetUserNum());
            
            Console.WriteLine($"Длина массива: {array.Length}");
        }
        private static void Exercise3(ref int[] array)
        {
            Console.WriteLine("Введите индекс массива удаляемого элемента:");
            RemoveAt(ref array,GetUserNum());
            
            Console.WriteLine($"Длина массива: {array.Length}");
        }
        

        private static int GetUserNum()
        {
            return int.Parse(Console.ReadLine() ?? string.Empty);
        }
        
        private static void Resize(ref int[] array, int setSize) => Array.Resize(ref array, setSize);

        private static void ResizeCustom<T>(ref T[] array, int newSize)
        {
            var newArray = new T[newSize];

            for (var i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];
            
            array = newArray;
        }

        private static void InsertElement(ref int[] array, int indexElement = 0)
        {
            var list = new List<int>(array);
            
            list.Insert(indexElement,0);

            array = list.ToArray();
        }

        private static void Insert(ref int[] array, int value, int index)
        {
            var newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (var i = 0; i < index; i++)
                newArray[i] = array[i];

            for (var i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }

        private static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }
        
        private static void AddLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length);
        }

        private static void RemoveElement(ref int[] array, int indexElement = 0)
        {
            var list = new List<int>(array);
            
            list.RemoveAt(indexElement);

            array = list.ToArray();
        }
        
        private static void RemoveAt(ref int[] array, int indexElement = 0)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < indexElement; i++)
                newArray[i] = array[i];
            
            for (int i = indexElement+1; i < array.Length; i++)
                newArray[i-1] = array[i];

            array = newArray;
        }

        private static void RemoveFirst(ref int[] array) => RemoveAt(ref array, 0);

        private static void RemoveLust(ref int[] array) => RemoveAt(ref array, array.Length-1);
    }
}