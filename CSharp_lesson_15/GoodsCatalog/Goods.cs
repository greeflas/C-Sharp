using System;

namespace GoodsCatalog
{
    class Goods
    {
        int id;
        string title;
        string category;

        public Goods(int id, string title, string category)
        {
            this.id = id;
            this.title = title;
            this.category = category;
        }

        public override string ToString()
        {
            return String.Format("id: {0} \nTitle: {1} \nCategory: {2}", 
                id, title, category);
        }
    }
}
