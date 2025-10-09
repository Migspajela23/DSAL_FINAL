using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Price_Item_Value
    {
        public required String price, item_name, discount_amount;
        
        public void SetPriceItemValue(string item_name, string item_price)
        {
            this.item_name = item_name;
            this.price = item_price;
        }
        public String GetItemName()
            {
                return item_name;
            }
            public String GetPrice()
            {
                return price ;
        }
        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)

            {
                this.price = priceItem;
                this.discount_amount = discount_amt;
        }

        public String GetPriceItem()
            {
            return price;
        }

        public string GetDiscountAmount()
            {
                return discount_amount;

            }
    }
    
    
}
