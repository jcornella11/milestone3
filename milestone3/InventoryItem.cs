using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone3
{
    class InventoryItem
    {
        private string _itemName;
        private double _itemPrice;
        private int _numberOnHand;
        private string _itemSize;
        private string _productCategory;

        public InventoryItem(string itemName, double itemPrice, int numberOnHand, string itemSize,
        string productCategory)
        {
            _itemName = itemName;
            _itemPrice = itemPrice;
            _numberOnHand = numberOnHand;
            _itemSize = itemSize;
            _productCategory = productCategory;
        }

        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public double itemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }

        public int numberOnHand 
        {
            get { return _numberOnHand; }
            set { _numberOnHand = value; }

        }

        public string itemSize
        {
            get { return _itemSize; }
            set { _itemSize = value; }
        }

        public string productCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }

        public void ReStock() 
        {
            _numberOnHand = _numberOnHand + 1;
        }

    }

}
