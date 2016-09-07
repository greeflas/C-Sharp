using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace _02_practic
{
    [Serializable]
    class Market
    {
        // Private fields
        string name;
        List<Goods> goods;

        // Public methods
        public Market(string name)
        {
            this.name = name;
            goods = new List<Goods>();
        }

        public void addGoodsItem(Goods g)
        {
            goods.Add(g);
        }

        public void addGoodsItems(Goods[] goods)
        {
            foreach(Goods g in goods)
            {
                this.goods.Add(g);
            }
        }

        public void DisplayGoods()
        {
            if(goods.Count != 0)
            {
                foreach(Goods g in goods)
                    Console.WriteLine(g.ToString());
            }
            else
                Console.WriteLine("Goods list is empty!");
        }

        public static void GoodsToFile(string path, Market m)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, m);

            fs.Close();
        }

        public static Market GoodsFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            BinaryFormatter formatter = new BinaryFormatter();
            Market m = (Market)formatter.Deserialize(fs);

            fs.Close();

            return m;
        }
    }
}
