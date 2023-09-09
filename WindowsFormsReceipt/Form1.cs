using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Student name: Sandra Isabel Yanza Hernandez
//Student code: C0888063
//Assignment 3 – Invoice/ Receipt Generator 

namespace WindowsFormsAppAssign
{
    public partial class Form1 : Form
    {
        //Items Array
        private string[] itemProductsName = { "WALL-E Robert Arm", 
                                       "Rocket powered roller blades", 
                                       "Jet propelled jumping shoes" };
        private string[] itemCodes = { "WE", "RB", "JS" };
        private decimal[] itemPrices = { 399.00m, 199.00m, 249.00m };

        public Form1()
        {
            InitializeComponent();
            InitializeItems();
        }

        //This method is to add the items in the ComboBox
        private void InitializeItems()
        {
            for (int i = 0; i < itemProductsName.Length; i++)
            {
                itemComboBox.Items.Add($"({itemCodes[i]}) - {itemProductsName[i]}");
            }
        }

        //This method is to validate the user inputs and generate the invoice.
        private void generateButton_Click(object sender, EventArgs e)
        {

            try
            {
                int itemSelected = itemComboBox.SelectedIndex;
                if (itemSelected < 0)
                {
                    MessageBox.Show("Please, select the item you would like to purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int quantityPurchased = Convert.ToInt32(quantityTextBox.Text);
                if (quantityPurchased < 1 || quantityPurchased > 100)
                {
                    MessageBox.Show("Please, enter valid quantity. Quantity must be between 1 and 100.", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalAmount = itemPrices[itemSelected] * quantityPurchased;

                MessageBox.Show($"Invoice/ Receipt Generator:\n\nItem: {itemProductsName[itemSelected]}\nItem price: " +
                    $"{itemPrices[itemSelected]:C}\nQuantity: {quantityPurchased}\nTotal amount: " +
                    $"{totalAmount:C}", "Receipt Generator");
            }

            catch (FormatException) 
            {
                MessageBox.Show("A format exception has occurred. Please check all entries.", "Entry Error");
            }
            catch (OverflowException) 
            {
                MessageBox.Show("An overflow exception has occurred. Please enter smaller values.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error exception has occurred: {ex.Message}", "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //This method is to show the item image when the user select an item in the ComboBox.
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemNumber = itemComboBox.SelectedIndex;
            if (itemNumber == 0)
                itemPicture.Image = Properties.Resources.walle;
            else
            {
                if (itemNumber == 1)
                    itemPicture.Image = Properties.Resources.rocketroller;
                else
                    itemPicture.Image = Properties.Resources.jetshoes;
            }
        }
    }
}
