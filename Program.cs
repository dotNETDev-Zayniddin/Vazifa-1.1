using System;
using System.Net.NetworkInformation;
namespace Vazifa {
    class Program{
        static void Main(string[] args){
            decimal Pi = 3.1415926535898m;
            System.Console.Write("Please enter a radius: ");
            decimal Radius = Convert.ToDecimal(Console.ReadLine());
            decimal  S;
            S = Pi*Radius*Radius;
            decimal L;
            L = 2*Pi*Radius;
            System.Console.WriteLine($"S = {S}");
            System.Console.WriteLine($"L = {L}");


        }
    }
}