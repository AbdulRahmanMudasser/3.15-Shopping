class Project
{
    static void Main(string[] args)
    {
        // declaring variables
        int itemOnePrice;
        int itemTwoPrice;
        int itemThreePrice;

        // prompting user and taking input for itemOne
        Console.Write("Input Price of First Item:  ");
        itemOnePrice = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for itemTwo
        Console.Write("Input Price of Second Item:  ");
        itemTwoPrice = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for itemThree
        Console.Write("Input Price of Third Item:  ");
        itemThreePrice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // applying discount on items prices
        int itemOneDiscount = (int)(itemOnePrice - (itemOnePrice * 0.10));
        int itemTwoDiscount = (int)(itemTwoPrice - (itemTwoPrice * 0.10));
        int itemThreeDiscount = (int)(itemThreePrice - (itemThreePrice * 0.10));

        // displaying discount on every item individually
        Console.WriteLine("Item One Price After Discount:  " + itemOneDiscount);
        Console.WriteLine("Item Two Price After Discount:  " + itemTwoDiscount);
        Console.WriteLine("Item Three Price After Discount:  " + itemThreeDiscount);

        Console.WriteLine();    // just for spacing purpose

        // bill with original prices
        int originalBill = itemOnePrice + itemTwoPrice + itemThreePrice;

        // bill with discounted prices
        int discountedBill = itemOneDiscount + itemTwoDiscount + itemThreeDiscount;

        // displaying bill
        Console.WriteLine("Total Bill ('Without Discount)':  " + originalBill);
        Console.WriteLine("Total Bill ('After Discount)':  " + discountedBill);

        // discount given
        int discountGiven = originalBill - discountedBill;

        // displaying discount given
        Console.Write("Total Discount:  " + discountGiven);

        Console.WriteLine();    // just for spacing purpose
    }
}
