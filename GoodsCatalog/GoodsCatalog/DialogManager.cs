using System;

namespace GoodsCatalog
{
    enum MenuPoints
    {
        EXIT,
        DISPLAY_GOODS,
        SEARCH,
        ADD_PRODUCT,
        REMOVE_PRODUCT,
        EDIT_PRODUCT_INFO,
    }

    class DialogManager
    {
        MenuPoints choise;

        void Actions()
        {
            switch(choise)
            {
                case MenuPoints.DISPLAY_GOODS:
                    break;
                case MenuPoints.SEARCH:
                    break;
                case MenuPoints.ADD_PRODUCT:
                    break;
                case MenuPoints.REMOVE_PRODUCT:
                    break;
                case MenuPoints.EDIT_PRODUCT_INFO:
                    break;
            }
        }

        public void Start()
        {
            Console.WriteLine("\tGoods catalog");
        }

        public void Finish()
        {
            Console.WriteLine("\tBye :)");
        }

        public bool GeneralMenu()
        {
            Console.WriteLine("<{0}> - exit",               MenuPoints.EXIT);
            Console.WriteLine("<{0}> - display goods",      MenuPoints.DISPLAY_GOODS);
            Console.WriteLine("<{0}> - search",             MenuPoints.SEARCH);
            Console.WriteLine("<{0}> - add product",        MenuPoints.ADD_PRODUCT);
            Console.WriteLine("<{0}> - remove product",     MenuPoints.REMOVE_PRODUCT);
            Console.WriteLine("<{0}> - edit product info",  MenuPoints.EDIT_PRODUCT_INFO);
            try
            {
                Console.Write("> ");
                choise = (MenuPoints)Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Error]: {0}", error.Message);
                Console.ResetColor();
            }

            if (choise == MenuPoints.EXIT)
                return false;

            Actions();

            return true;
        }
    }
}