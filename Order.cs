using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Order
    {
        public int orderNum { get; set; } //order number
        public string firstName { get; set; } //customer's first name
        public string lastName { get; set; } //customer's last name
        public string phone { get; set; } //customer's phone number
        public List<FoodItem> foodList { get; set; } //menu items added to the order
        public double total { get; set; } //total price for all items
        public DateTime date { get; set; } //date and time of order

        public Order()
        {
            //constructor
        }

        public void getTotalPrice()
        {
            foreach(FoodItem f in foodList)
            {
                total += f.price;
            }
        }

        public static void loadOrders(ref List<Order> orderList) //load active orders into orderList from saved XML
        {
            try
            {
                XDocument orderDoc = XDocument.Load("orders.xml"); //open XML file

                //populate orderList from XML nodes
                orderList = (from o in orderDoc.Element("Orders").Elements("Order")
                             select new Order
                             {
                                 orderNum = Convert.ToInt32(o.Element("orderNum").Value),
                                 firstName = o.Element("firstName").Value,
                                 lastName = o.Element("lastName").Value,
                                 phone = o.Element("phone").Value,
                                 foodList = (from f in o.Element("foodList").Elements("FoodItem")
                                         select new FoodItem
                                         {
                                             name = f.Element("name").Value,
                                             price = Convert.ToDouble(f.Element("price").Value)
                                         }).ToList(),                               
                                total = Convert.ToDouble(o.Element("total").Value),
                                date = Convert.ToDateTime(o.Element("date").Value)
                            }).ToList();
            }
            catch (Exception ex)
            {

            }
        }

        public static void saveOrders(ref List<Order> orderList) //saves all order information to XML
        {
            try
            {
                //create XML nodes from list of orders
                XElement x = new XElement("Orders",
                              from order in orderList
                              select new XElement("Order",
                              new XElement("orderNum", order.orderNum),
                              new XElement("firstName", order.firstName),
                              new XElement("lastName", order.lastName),
                              new XElement("phone", order.phone),
                              new XElement("foodList",
                                from food in order.foodList
                                select new XElement("FoodItem",
                                new XElement("name", food.name),
                                new XElement("price", string.Format("{0:0.00}", food.price))
                                )),
                              new XElement("total", string.Format("{0:0.00}", order.total)),
                              new XElement("date", order.date)));

                x.Save("orders.xml"); //saves XML file
            }
            catch (Exception ex)
            {

            }
        }
    }
}
