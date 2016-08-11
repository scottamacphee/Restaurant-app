using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class FoodItem
    {        
        public string name { get; set; } //name of food item
        public double price { get; set; } //price of food item

        public FoodItem()
        {
            //constructor
        }

        public static void loadMenu(ref List<FoodItem> menu) //load all menu items into menu from saved XML
        {
            try
            {
                XDocument menuDoc = XDocument.Load("menu.xml"); //open XML file

                //populate menu from XML nodes
                menu = (from m in menuDoc.Element("Menu").Elements("FoodItem")
                        select new FoodItem
                        {
                            name = m.Element("name").Value,
                            price = Convert.ToDouble(m.Element("price").Value)                               
                        }).ToList();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
