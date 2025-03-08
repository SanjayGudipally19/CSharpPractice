using System;
using System.Collections.Generic;
//namespace CsharpPractice
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string word= Console.ReadLine();
    //        ReverseString rev= new ReverseString();
    //        string revword=rev.Reverse(word);
    //        Console.WriteLine(revword);
    //    }
    //}
    //public class ReverseString
    //{
    //    public string Reverse(string s)
    //    {
    //        char[] charArray = s.ToCharArray();
    //        string result = string.Empty;
    //        for (int i = charArray.Length - 1; i >= 0; i--)
    //        {
    //            result += charArray[i];
    //        }
    //        //Array.Reverse(charArray);
    //        // return new string (charArray);
    //        return result;
    //    }
    //}



    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    int res = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < res)
        {
            res = array[i];
        }
    }
    Console.WriteLine(res);
}   