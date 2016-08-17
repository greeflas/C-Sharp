using System;
using System.Linq;

namespace CSharp_lesson_9_practic
{
    enum ArticleType : uint
    {
        Photocameras = 1,
        Videocameras
    }

    struct Article
    {
        public uint id;
        public string name;
        public double price;
        public ArticleType type;

        public Article(uint id, string name, double price, ArticleType type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
        }

        public override string ToString()
        {
            string GoodsType = Enum.GetName(typeof(ArticleType), type);

            return String.Format("ID: {0} \nName: {1} \nPrice: {2} \nType: {3}\n",
                id, name, price, GoodsType);
        }
    }
}
