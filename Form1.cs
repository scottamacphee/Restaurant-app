using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        List<Reservation> resList = new List<Reservation>(); //list of active reservations
        List<Order> orderList = new List<Order>(); //list of active orders
        List<FoodItem> menu = new List<FoodItem>(); //list of available menu items
        List<FoodItem> selectedFood = new List<FoodItem>(); //list of selected food items for a new order
        string errorMessage = "";
        bool errors = false; 

        public Form1()
        {
            InitializeComponent();
            Reservation.loadReservations(ref resList); //load active reservations into resList from saved XML
            Order.loadOrders(ref orderList); //load orders into orderList from saved XML
            FoodItem.loadMenu(ref menu); //load menu items into menu from saved XML
            populateFoodDropDown(); //populates dropdown in 'New Order' section with menu items
            updateOrderTable(); //initializing table showing current reservations
            updateReservationTable(); //initializing table showing current orders
        }

        private void menuButton_Click(object sender, EventArgs e) //switch to Main Menu
        {
            tabControl1.SelectTab("menuTab");
            menuButton.Visible = false;
            managerToggle.Visible = false;
        }

        private void resManagerButton_Click(object sender, EventArgs e) //switch to Reservation Manager
        {
            showReservations();
        }

        private void showReservations()
        {
            tabControl1.SelectTab("reservationTab");
            menuButton.Visible = true;
            reservationTable.ClearSelection();
            managerToggle.Text = "Order Manager";
            managerToggle.Visible = true;
        }

        private void ordManagerButton_Click(object sender, EventArgs e) //switch to Order Manager
        {
            showOrders();
        }

        private void showOrders()
        {
            tabControl1.SelectTab("orderTab");
            menuButton.Visible = true;
            orderTable.ClearSelection();
            managerToggle.Text = "Reservation Manager";
            managerToggle.Visible = true;
        }

        private void managerToggle_Click(object sender, EventArgs e)
        {            
            if (tabControl1.SelectedTab.Text == "Reservations")
            {
                showOrders();
            }
            else if (tabControl1.SelectedTab.Text == "Orders")
            {
                showReservations();
            }
        }

        public void populateFoodDropDown() //populates dropdown in 'New Order' section with menu items
        {
            foreach (FoodItem f in menu)
            {
                menuList.Items.Add(f.name + ", " + string.Format("{0:0.00}", f.price));
            }
            menuList.SelectedIndex = 0;
        }

        private void addFoodButton_Click(object sender, EventArgs e) //adds food to a new order
        {
            FoodItem selected = new FoodItem();
            selected = menu.Where(i => i.name == menuList.SelectedItem.ToString().Split(',')[0]).First(); //finds menu item based on selected item in dropdown
            selectedFood.Add(selected); //adds selected item to list of current food in the order
            updateFoodDataGrid(); //updates the table to show current food in the order
            deleteFoodButton.Enabled = true;
        }

        private void deleteFoodButton_Click(object sender, EventArgs e) //deletes food from a new order
        {
            selectedFood.RemoveAt(newOrderFoodList.CurrentCell.RowIndex); //removes selected table item from list of current food in the order
            if(selectedFood.Count == 0)
            {
                deleteFoodButton.Enabled = false;                
            }
            updateFoodDataGrid(); //updates the table to show current food in the order

        }

        public void updateFoodDataGrid() //updates the table to show current food in the order
        {
            newOrderFoodList.Rows.Clear(); //resets the table
            foreach (FoodItem f in selectedFood)
            {
                newOrderFoodList.Rows.Add(f.name, string.Format("{0:0.00}", f.price)); //adds each item in the current food list to the table
            }
        }

        private void orderSubmitButton_Click(object sender, EventArgs e) //submits and saves new order
        {
            if (validateOrder())
            {
                Order o = new Order();
                if (orderList.Count > 0) //determining order number
                {
                    o.orderNum = orderList.OrderBy(x => x.orderNum).Last().orderNum + 1;
                }
                else
                {
                    o.orderNum = 1;
                }
                o.firstName = newOrderFirst.Text;
                o.lastName = newOrderLast.Text;
                o.phone = newOrderPhone.Text;
                o.foodList = selectedFood.ToList();
                foreach (FoodItem f in o.foodList)
                {
                    o.total += f.price; //adding up total price of the order
                }
                o.date = newOrderDate.Value;
                orderList.Add(o); //add new order to list of active orders
                clearNewOrder(); //resets the 'new order' form
                Order.saveOrders(ref orderList); //saves all order information to XML
                updateOrderTable(); //refresh table showing active orders
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resSubmit_Click(object sender, EventArgs e) //submits and saves new reservation
        {

            if(validateReservation())
            {
                Reservation r = new Reservation();
                if (resList.Count > 0) //determining reservation number
                {
                    r.resNum = resList.OrderBy(x => x.resNum).Last().resNum + 1;
                }
                else
                {
                    r.resNum = 1;
                }
                r.partySize = Convert.ToInt32(newResParty.Value);
                r.tableNum = Convert.ToInt32(newResTableNum.Value);
                r.firstName = newResFirst.Text;
                r.lastName = newResLast.Text;
                r.phone = newResPhone.Text;
                r.date = newResDate.Value;
                resList.Add(r); //add new reservation to list of active reservations
                clearNewReservation(); //resets the 'new reservation' form
                Reservation.saveReservations(ref resList); //saves all reservation information to XML
                updateReservationTable(); //refresh table showing active reservations
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool validateReservation()
        {
            errorMessage = "The following errors have occured:\n\n";
            bool errors = false;
            
            if (newResFirst.Text == "")
            {
                errorMessage += "First name cannot be blank.\n";
                errors = true;
            }

            if (newResLast.Text == "")
            {
                errorMessage += "Last name cannot be blank.\n";
                errors = true;
            }

            if (newResParty.Value == 0)
            {
                errorMessage += "Party size must be greater than 0.\n";
                errors = true;
            }

            if (newResTableNum.Value == 0)
            {
                errorMessage += "Table must be greater than 0.\n";
                errors = true;
            }

            if (newResPhone.Text == "")
            {
                errorMessage += "Phone number cannot be blank.";
                errors = true;
            }

            return !errors;
        }

        private bool validateOrder()
        {
            errorMessage = "The following errors have occured:\n\n";
            errors = false;

            if (selectedFood.Count == 0)
            {
                errorMessage += "No menu items have been added.\n";
                errors = true;
            }

            if (newOrderFirst.Text == "")
            {
                errorMessage += "First name cannot be blank.\n";
                errors = true;
            }

            if (newOrderLast.Text == "")
            {
                errorMessage += "Last name cannot be blank.\n";
                errors = true;
            }

            if (newOrderPhone.Text == "")
            {
                errorMessage += "Phone number cannot be blank.";
                errors = true;
            }

            return !errors;
        }

        private void clearNewOrder() //resets the 'new order' form
        {
            selectedFood.Clear();
            newOrderFoodList.Rows.Clear();
            newOrderFirst.Text = "";
            newOrderLast.Text = "";
            newOrderPhone.Text = "";            
            newOrderDate.Value = DateTime.Now;
            deleteFoodButton.Enabled = false;            
        }

        private void clearNewReservation() //resets the 'new reservation' form
        {
            newResParty.Value = 0;
            newResTableNum.Value = 0;
            newResFirst.Text = "";
            newResLast.Text = "";
            newResPhone.Text = "";
            newResDate.Value = DateTime.Now;
        }

        public void updateOrderTable() //refresh table showing active orders
        {
            orderTable.Rows.Clear(); //resets the table

            foreach (Order o in orderList.OrderBy(x => x.date)) //adds all active orders, ordered by date
            {
                string foodOrder = String.Empty;
                foreach (FoodItem f in o.foodList)
                {
                    foodOrder += f.name + ", "; //creating a single string out of all the food in a single order
                }
                foodOrder = foodOrder.TrimEnd(',', ' ');
                orderTable.Rows.Add(o.orderNum, o.date, foodOrder, "$" + o.total, o.firstName, o.lastName, o.phone); //add order to table
            }

            orderTable.ClearSelection();
        }

        public void updateReservationTable() //refresh table showing active reservations
        {
            reservationTable.Rows.Clear(); //resets the table

            foreach (Reservation r in resList.OrderBy(x => x.date)) //adds all active reservations, ordered by date
            {
                reservationTable.Rows.Add(r.resNum, r.date, r.firstName, r.lastName, r.partySize, r.tableNum, r.phone); //add reservation to table
            }

            reservationTable.ClearSelection();
        }

        private void orderClearButton_Click(object sender, EventArgs e)
        {
            clearNewOrder();
        }

        private void resClearButton_Click(object sender, EventArgs e)
        {
            clearNewReservation();
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if(orderTable.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Click OK to confirm deletion of the selected order.", "Delete Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    removeOrder(Convert.ToInt16(orderTable.Rows[orderTable.CurrentCell.RowIndex].Cells[0].Value));
                }
            }
            else
            {
                MessageBox.Show("No orders have been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                      
        }

        public void removeOrder(int toBeDeleted) 
        {
            Order delOrder = new Order();
            delOrder = orderList.Where(x => x.orderNum == toBeDeleted).First();
            orderList.Remove(delOrder);
            Order.saveOrders(ref orderList); //saves all order information to XML
            updateOrderTable(); //refresh table showing active orders
        }

        private void removeResButton_Click(object sender, EventArgs e)
        {
            if (reservationTable.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Click OK to confirm deletion of the selected reservation.", "Delete Reservation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    removeReservation(Convert.ToInt16(reservationTable.Rows[reservationTable.CurrentCell.RowIndex].Cells[0].Value));
                }
            }
            else
            {
                MessageBox.Show("No reservations have been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void removeReservation(int toBeDeleted)
        {
            Reservation delReservation = new Reservation();
            delReservation = resList.Where(x => x.resNum == toBeDeleted).First();
            resList.Remove(delReservation);
            Reservation.saveReservations(ref resList); //saves all reservation information to XML
            updateReservationTable(); //refresh table showing active reservations
        }

        
    }
}
