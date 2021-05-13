using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestone3
{
    public partial class inventoryManager : Form
    {
        public inventoryManager()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventoryManager_Load(object sender, EventArgs e)
        {
            //Create a Object of the Inventory Manager Class
            InventoryManager inventory = new InventoryManager();

            //Create Inventory Item Classes
            InventoryItem item1 = new InventoryItem("Nike Shoes", 99, 2, "Large", "Shoes");
            InventoryItem item2 = new InventoryItem("Plaid Shirt", 30, 3, "Medium", "Clothing");
            InventoryItem item3 = new InventoryItem("Ripped Jeans", 50, 4, "Small", "Clothing");
            InventoryItem item4 = new InventoryItem("Swimming Suit", 45, 2, "Large", "Water Sports");

            inventory.AddItem(item1, 0);
            inventory.AddItem(item2, 1);
            inventory.AddItem(item3, 2);
            inventory.AddItem(item4, 3);
            inventory.ReStock(item1);

            InventoryItem[] displayeditems = inventory.DisplayItems();

            for (int index = 0; index < displayeditems.Length; index++)
            {
                itemListBox.Items.Add(displayeditems[index].itemName + "\t"
                    + displayeditems[index].itemPrice + "\t" + displayeditems[index].numberOnHand + "\t"
                    + displayeditems[index].productCategory);
            }

            int searchresult1 = inventory.searchInventoryName("Nike Shoes");
            int searchresult2 = inventory.searchInventoryPrice(45);

        }
    }
}
