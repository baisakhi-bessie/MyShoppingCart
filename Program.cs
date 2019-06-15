using System;

namespace MyShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        Cart cart = new Cart();
        static bool MainMenu()
        {
            Products products = new Products();
            Console.WriteLine("We have the following items to choose from:");
            Console.WriteLine("1-Sliced ham (SH3) -- Price: 3 packs @ 2.99 and 5 packs @ 4.99\n2-Yoghurt (YT2) -- " +
                "Price: 4 packs @ 4.95, 9 packs @ 9.95 and 15 packs @ 13.95\n3-Toilet Rolls (TR) -- " +
                "Price: 3 packs @ 2.95, 5 packs @ 4.45 and 9 packs @ 7.99");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Sliced Ham, 2 for Yoghurt, 3 for Toilet Rolls. Enter 4 to exit, 5 to show cart");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 1)
            {
                products.SlicedHam();
                return true;
            }
            else if(num == 2)
            {
                products.Yoghurt();
                return true;
            }
            else if(num == 3)
            {
                products.ToiletRolls();
                return true;
            }
            else if(num == 4)
            {
                return false;
            }
            else if(num==5)
            {
                products.ProductDisplay();
                return true;
            }
            else
            {
                Console.WriteLine("Wrong choice! Choose any number between 1, 2, 3 or 4");
                return true;
            }
        }
        //static void SlicedHam()
        //{
        //    Console.WriteLine("You have selected sliced ham..");
        //    Console.WriteLine("Enter the quantity:");
        //    int quantity = Convert.ToInt32(Console.ReadLine());
        //    int totalCount = 0, firstPackageCount = 0, secondPackageCount = 0;
        //    double firstPackagePrice=0.0, secondPackagePrice=0.0;
        //    bool loopContinue = true;
        //    while(loopContinue)
        //    {
        //        if (quantity >= 5)
        //        {
        //            quantity -= 5;
        //            firstPackageCount++;
        //            firstPackagePrice = 4.99 * firstPackageCount;
        //        }
        //        else if (quantity >= 3)
        //        {
        //            quantity -= 3;
        //            secondPackageCount++;
        //            secondPackagePrice = 2.99 * secondPackageCount;
        //        }
        //        else if(quantity < 3 && quantity != 0)
        //        {
        //            quantity = 0;
        //            secondPackageCount++;
        //            secondPackagePrice = 2.99 * secondPackageCount;
        //            loopContinue = false;
        //        }
        //        if (quantity == 0)
        //            loopContinue = false;
        //        totalCount++;
        //    }
        //    Console.WriteLine("You have selected {0} number of 5 package and {1} number of 3 package", firstPackageCount, secondPackageCount);
        //    Console.WriteLine("{0} number of items added to your cart.", totalCount);
        //    Console.WriteLine("The total price is: {0} + {1} = {2}", firstPackagePrice,secondPackagePrice, firstPackagePrice+secondPackagePrice);
        //}
        //static void Yoghurt()
        //{
        //    Console.WriteLine("You have selected yoghurt..");
        //    Console.WriteLine("Enter the quantity:");
        //    int quantity = Convert.ToInt32(Console.ReadLine());
        //    int totalCount = 0, firstPackageCount = 0, secondPackageCount = 0, thirdPackageCount = 0;
        //    double firstPackagePrice = 0.0, secondPackagePrice = 0.0, thirdPackagePrice = 0.0;
        //    bool loopContinue = true;
        //    while(loopContinue)
        //    {
        //        if(quantity >= 15)
        //        {
        //            quantity -= 15;
        //            firstPackageCount++;
        //            firstPackagePrice = 13.95 * firstPackageCount;
        //        }
        //        else if(quantity >= 10)
        //        {
        //            quantity -= 10;
        //            secondPackageCount++;
        //            secondPackagePrice = 9.95 * secondPackageCount;
        //        }
        //        else if(quantity >= 4)
        //        {
        //            quantity -= 4;
        //            thirdPackageCount++;
        //            thirdPackagePrice = 4.95 * thirdPackageCount;
        //        }
        //        else if(quantity < 4 && quantity != 0)
        //        {
        //            quantity = 0;
        //            thirdPackageCount++;
        //            thirdPackagePrice = 4.95 * thirdPackageCount;
        //            loopContinue = false;
        //        }
        //        if (quantity == 0)
        //            loopContinue = false;
        //        totalCount++;
        //    }
        //    Console.WriteLine("You have selected {0} number of 15 package {1} number of 10 package and {2} number of 4 package", firstPackageCount, secondPackageCount,thirdPackageCount);
        //    Console.WriteLine("{0} number of items added to your cart.", totalCount);
        //    Console.WriteLine("The total price is: {0} + {1} + {2} = {3}", firstPackagePrice, secondPackagePrice,thirdPackagePrice,firstPackagePrice + secondPackagePrice+thirdPackagePrice);
        //}
        //static void ToiletRolls()
        //{
        //    Console.WriteLine("You have selected toilet rolls..");
        //    Console.WriteLine("Enter the quantity:");
        //    int quantity = Convert.ToInt32(Console.ReadLine());
        //    int totalCount = 0, firstPackageCount = 0, secondPackageCount = 0, thirdPackageCount = 0;
        //    double firstPackagePrice = 0.0, secondPackagePrice = 0.0, thirdPackagePrice = 0.0;
        //    bool loopContinue = true;
        //    while(loopContinue)
        //    {
        //        if (quantity >= 9)
        //        {
        //            quantity -= 9;
        //            firstPackageCount++;
        //            firstPackagePrice = 7.99 * firstPackageCount;
        //        }
        //        else if (quantity >= 5)
        //        {
        //            quantity -= 5;
        //            secondPackageCount++;
        //            secondPackagePrice = 4.45 * secondPackageCount;
        //        }
        //        else if (quantity >= 3)
        //        {
        //            quantity -= 3;
        //            thirdPackageCount++;
        //            thirdPackagePrice = 2.95 * thirdPackageCount;
        //        }
        //        else if (quantity < 3 && quantity != 0)
        //        {
        //            quantity = 0;
        //            thirdPackageCount++;
        //            thirdPackagePrice = 2.95 * thirdPackageCount;
        //            loopContinue = false;
        //        }
        //        if (quantity == 0)
        //            loopContinue = false;
        //        totalCount++;
        //    }
        //    Console.WriteLine("You have selected {0} number of 9 package {1} number of 5 package and {2} number of 3 package", firstPackageCount, secondPackageCount, thirdPackageCount);
        //    Console.WriteLine("{0} number of items added to your cart.", totalCount);
        //    Console.WriteLine("The total price is: {0} + {1} + {2} = {3}", firstPackagePrice, secondPackagePrice, thirdPackagePrice, firstPackagePrice + secondPackagePrice + thirdPackagePrice);
        //}
        static void displayCart()
        {

        }
    }
}
