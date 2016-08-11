using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Reservation
    {
        public int resNum { get; set; } //reservation number
        public int partySize { get; set; } //party size
        public int tableNum { get; set; } //table number
        public string firstName { get; set; } //customer's first name
        public string lastName { get; set; } //customer's last name
        public string phone { get; set; } //customer's phone number
        public DateTime date { get; set; } //date and time of reservation

        public Reservation()
        {
            //constructor
        }

        public static void loadReservations(ref List<Reservation> resList) //load active reservations into resList from saved XML
        {
            try
            {
                XDocument resDoc = XDocument.Load("reservations.xml"); //open XML file

                //populate resList from XML nodes
                resList = (from r in resDoc.Element("Reservations").Elements("Reservation")
                           select new Reservation
                           {
                               resNum = Convert.ToInt32(r.Element("resNum").Value),
                               partySize = Convert.ToInt32(r.Element("partySize").Value),
                               tableNum = Convert.ToInt32(r.Element("tableNum").Value),
                               firstName = r.Element("firstName").Value,
                               lastName = r.Element("lastName").Value,
                               phone = r.Element("phone").Value,
                               date = Convert.ToDateTime(r.Element("date").Value)
                           }).ToList();
            }
            catch (Exception ex)
            {

            }
        }

        public static void saveReservations(ref List<Reservation> resList) //saves all reservation information to XML
        {
            try
            {
                //create XML nodes from list of reservations
                XElement x = new XElement("Reservations",
                              from res in resList
                              select new XElement("Reservation",
                              new XElement("resNum", res.resNum),
                              new XElement("partySize", res.partySize),
                              new XElement("tableNum", res.tableNum),
                              new XElement("firstName", res.firstName),
                              new XElement("lastName", res.lastName),
                              new XElement("phone", res.phone),
                              new XElement("date", res.date)));

                x.Save("reservations.xml"); //saves XML file
            }
            catch (Exception ex)
            {

            }
        }
    }
}
