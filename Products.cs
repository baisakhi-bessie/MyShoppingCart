using System;
using System.Collections.Generic;
using System.Text;

namespace MyShoppingCart
{
    class Products
    {
        Cart cart = new Cart();
        public void SlicedHam()
        {
            Console.WriteLine("You have selected sliced ham..");
            Console.WriteLine("Enter the quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int totalCount = 0, firstPackageCount = 0, secondPackageCount = 0;
            double firstPackagePrice = 0.0, secondPackagePrice = 0.0;
            bool loopContinue = true;
            while (loopContinue)
            {
                if (quantity >= 5)
                {
                    quantity -= 5;
                    firstPackageCount++;
                    firstPackagePrice = 4.99 * firstPackageCount;
                }
                else if (quantity >= 3)
                {
                    quantity -= 3;
                    secondPackageCount++;
                    secondPackagePrice = 2.99 * secondPackageCount;
                }
                else if (quantity < 3 && quantity != 0)
                {
                    quantity = 0;
                    secondPackageCount++;
                    secondPackagePrice = 2.99 * secondPackageCount;
                    loopContinue = false;
                }
                if (quantity == 0)
                    loopContinue = false;
                totalCount++;
                cart.AddToCart("Sliced Ham", totalCount, firstPackagePrice + secondPackagePrice);
            }
            Console.WriteLine("You have selected {0} number of 5 package and {1} number of 3 package", firstPackageCount, secondPackageCount);
            Console.WriteLine("{0} number of items added to your cart.", totalCount);
            Console.WriteLine("The total price is: {0} + {1} = {2}", firstPackagePrice, secondPackagePrice, firstPackagePrice + secondPackagePrice);
        }
        public void Yoghurt()
        {
            Console.WriteLine("You have selected yoghurt..");
            Console.WriteLine("Enter the quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int totalCount = 0, firstPackageCount = 0, secondPackageCount = 0, thirdPackageCount = 0;
            double firstPackagePrice = 0.0, secondPackagePrice = 0.0, thirdPackagePrice = 0.0;
            bool loopContinue = true;
            while (loopContinue)
            {
                if (quantity >= 15)
                {
                    quantity -= 15;
                    firstPackageCount++;
                    firstPackagePrice = 13.95 * firstPackageCount;
                }
                else if (quantity >= 10)
                {
                    quantity -= 10;
                    secondPackageCount++;
                    secondPackagePrice = 9.95 * secondPackageCount;
                }
                else if (quantity >= 4)
                {
                    quantity -= 4;
                    thirdPackageCount++;
                    thirdPackagePrice = 4.95 * thirdPackageCount;
                }
                else if (quantity < 4 && quantity != 0)
                {
                    quantity = 0;
                    thirdPackageCount++;
                    thirdPackagePrice = 4.95 * thirdPackageCount;
                    loopContinue = false;
                }
                if (quantity == 0)
                    loopContinue = false;
                totalCount++;
            }
            Console.WriteLine("You have selected {0} number of 15 package {1} number of 10 package and {2} number of 4 package", firstPackageCount, secondPackageCount, thirdPackageCount);
            Console.WriteLine("{0} number of items added to your cart.", totalCount);
            Console.WriteLine("The total price is: {0} + {1} + {2} = {3}", firstPackagePrice, secondPackagePrice, thirdPackagePrice, firstPackagePrice + secondPackagePrice + thirdPackagePrice);
        }
        public void ToiletRolls()
        {
            Console.WriteLine("You have selected toilet rolls..");
            Console.WriteLine("Enter the quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int totalCount = 0, firstPackageCount = 0, secondPackageCount = 0, thirdPackageCount = 0;
            double firstPackagePrice = 0.0, secondPackagePrice = 0.0, thirdPackagePrice = 0.0;
            bool loopContinue = true;
            while (loopContinue)
            {
                if (quantity >= 9)
                {
                    quantity -= 9;
                    firstPackageCount++;
                    firstPackagePrice = 7.99 * firstPackageCount;
                }
                else if (quantity >= 5)
                {
                    quantity -= 5;
                    secondPackageCount++;
                    secondPackagePrice = 4.45 * secondPackageCount;
                }
                else if (quantity >= 3)
                {
                    quantity -= 3;
                    thirdPackageCount++;
                    thirdPackagePrice = 2.95 * thirdPackageCount;
                }
                else if (quantity < 3 && quantity != 0)
                {
                    quantity = 0;
                    thirdPackageCount++;
                    thirdPackagePrice = 2.95 * thirdPackageCount;
                    loopContinue = false;
                }
                if (quantity == 0)
                    loopContinue = false;
                totalCount++;
            }
            Console.WriteLine("You have selected {0} number of 9 package {1} number of 5 package and {2} number of 3 package", firstPackageCount, secondPackageCount, thirdPackageCount);
            Console.WriteLine("{0} number of items added to your cart.", totalCount);
            Console.WriteLine("The total price is: {0} + {1} + {2} = {3}", firstPackagePrice, secondPackagePrice, thirdPackagePrice, firstPackagePrice + secondPackagePrice + thirdPackagePrice);
        }

        public void ProductDisplay()
        {
            foreach (string itemName in cart.GetCartItemNames())
            {
                Console.WriteLine(itemName);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
