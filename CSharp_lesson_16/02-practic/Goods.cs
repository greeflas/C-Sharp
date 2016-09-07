using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _02_practic
{
    [Serializable]
    class Goods
    {
        // Private fields
        uint id;
        string title;
        double price;
        uint quantity;
        DateTime date;

        // Properties
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public uint Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        // Public methods
        public Goods(uint id, string title, double price, DateTime date)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.date = date;
        }

        public override string ToString()
        {
            return String.Format(
                "id: {0}\n"+
                "Title: {1}\n"+
                "Price: {2}\n"+
                "Quantity: {3}\n"+
                "Date: {4}\n",

                id,
                title,
                price,
                quantity,
                date
            );
        }

        public static void ToFile(string path, Goods g)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, g);

            fs.Close();
        }

        public static Goods FromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            BinaryFormatter formatter = new BinaryFormatter();
            Goods g = (Goods)formatter.Deserialize(fs);

            fs.Close();

            return g;
        }
    }
}
