using System;

namespace _02_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "../../data/";

            // Example 1
            Goods g = new Goods(1, "iPhone", 10000.99, DateTime.Now);

            string file_name = "goods_item_" + g.Id + ".dat";
            Goods.ToFile(PATH + file_name, g);

            Console.WriteLine("Serialized!\n");

            Goods g2 = Goods.FromFile(PATH + file_name);
            Console.WriteLine(g2.ToString());

            // Example 2
            Goods[] goods = new Goods[]
            {
                new Goods(1, "iPhone 5", 10000.00, DateTime.Now),
                new Goods(2, "iPhone 5s", 12000.00, DateTime.Now),
                new Goods(3, "iPhone 6s", 17000.99, DateTime.Now)
            };

            Market m = new Market("Citrus");
            m.addGoodsItems(goods);

            string file_name2 = "market_goods.dat";
            Market.GoodsToFile(PATH + file_name2, m);

            Market m2 = Market.GoodsFromFile(PATH + file_name2);
            m2.DisplayGoods();
        }
    }
}
