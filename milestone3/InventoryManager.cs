using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone3
{
    class InventoryManager
    {
        //Items Array with Max 10 Items
        private InventoryItem[] items = new InventoryItem[4];

        public void AddItem(InventoryItem item, int index) 
        {
            items[index] = item;
        }

        public InventoryItem[] DisplayItems() 
        {
            return items;
        }

    public void RemoveItem(InventoryItem item, int index) 
        {
            items[index] = null;
        }

        public void ReStock(InventoryItem item) 
        {
            item.ReStock();
        }

        public int searchInventoryName(string name)
        {
            bool found = false;
            int searchindex = 0;
            int resultindex = -1;

            while (!found && searchindex < items.Length) 
            {
                if (items[searchindex].itemName == name) 
                {
                    found = true;
                    resultindex = searchindex;
                }
                searchindex++;
            }
            return resultindex;

        }

        public int searchInventoryPrice(double price) 
        {
            bool found = false;
            int searchindex = 0;
            int resultindex = -1;

            while (!found && searchindex < items.Length)
            {
                if (items[searchindex].itemPrice == price)
                {
                    found = true;
                    resultindex = searchindex;
                }
                searchindex++;
            }
            return resultindex;

        }

    }
}
