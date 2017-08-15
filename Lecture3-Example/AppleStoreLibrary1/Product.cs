using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleStoreLibrary1
{
    public class Product
    {
        private int id;
        public string Name;
        private int price;
        public string Category;
        public bool Soldout;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            /*
            if (value <= 0)
                Id = 1;
            else
                Id = value;*/

            id = value <= 0 ? 1 : value;
        }

        //C# 類別中的屬性(用大寫開頭)
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value <= 0 ? 1 : value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                switch (Category)
                {
                    case "iPhone":

                        if (value < 28900)
                        {
                            price = 28922;
                        }
                        else if (value > 52200)
                        {
                            price = 52200;
                        }
                        else
                        {
                            price = value;
                        }
                        break;

                    case "iPad":
                        if (value < 28900)
                        {
                            price = 28922;
                        }
                        else if (value > 42870)
                        {
                            price = 42870;
                        }
                        else
                        {
                            price = value;
                        }
                        break;

                    default:
                        price = value < 10000 ? 10000 : value;
                        break;
                }
            }
        }
    }
}