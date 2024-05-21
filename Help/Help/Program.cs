using IM_AM;
using System;
using System.Runtime.CompilerServices;

namespace IM_AM 
{
    public class Credit_cart
    {
        public int money {  get; set; }
        public int CVC {  get; set; }
        
        public static Credit_cart operator +(Credit_cart a, int b)
        {
            a.money += b;
            return a;
        }
        public static Credit_cart operator -(Credit_cart a, int b)
        {
            a.money -= b;
            return a;
        }
        public static bool operator ==(Credit_cart a, Credit_cart b)
        {
            bool x;
            if (a.CVC == b.CVC) { x = true; } else { x = false; }
            return x;
        }
        public static bool operator !=(Credit_cart a, Credit_cart b)
        {
            bool x;
            if (a.CVC == b.CVC)
            {
                x = false;
            }
            else
            {
                x = true;
            }
            return x;
        }
        public static bool operator <(Credit_cart a, Credit_cart b)
        {
            bool x;
            if (a.money < b.money)
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;
        }
        public static bool operator >(Credit_cart a, Credit_cart b)
        {
            bool x;
            if (a.money > b.money)
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;
        }
        public override bool Equals(object obj) 
        {
            Credit_cart other = obj as Credit_cart;
            return this.CVC == other.CVC;
        }
        public override int GetHashCode()
        {
            return this.CVC.GetHashCode();
        }

        public override string ToString()
        {
            return $"Money = {money}, CVC = {CVC}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Credit_cart cart1 = new Credit_cart {money = 100, CVC = 123 };
            Credit_cart cart2 = new Credit_cart {money = 200, CVC = 123 };
            Credit_cart cart3 = new Credit_cart {money = 0, CVC = 321 };
            Console.WriteLine($"First- {cart1}, Second- {cart2}, Third- {cart3}");
            Console.WriteLine();
            Console.WriteLine($"Addition cart1 and 100- ({cart1 + 100})");
            Console.WriteLine($"Subtraction cart1 and 100- ({cart1 - 100})");
            Console.WriteLine($"Equality (CVC) cart1 and cart2- ({cart1 == cart2})");
            Console.WriteLine($"Not equality (CVC) cart1 and cart2- ({cart1 != cart2})");
            Console.WriteLine($"Cart1 > cart2 ? (money) - ({cart1 > cart2})");
            Console.WriteLine($"Cart1 < cart2 ? (money) - ({cart1 < cart2})");
            Console.WriteLine($"Equality (All) - ({cart1.Equals(cart2)})");
        }
    }
}