using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace solution
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new BindingList<Product>();
            listBoxProducts.DataSource = products;
            listBoxProducts.DisplayMember = "Name";
            comboBoxCategory.DataSource = Enum.GetValues(typeof(ProductCategory));
        }

        private void editProductButton_click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null && ValidateInputs())
            {
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;
                selectedProduct.Name = textBoxName.Text;
                selectedProduct.Manufacturer = textBoxManufacturer.Text;
                selectedProduct.Category = (ProductCategory)comboBoxCategory.SelectedItem;
                selectedProduct.Quantity = (int)numericUpDownQuantity.Value;
                SortProducts();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Product newProduct = new Product
                {
                    Name = textBoxName.Text,
                    Manufacturer = textBoxManufacturer.Text,
                    Category = (ProductCategory)comboBoxCategory.SelectedItem,
                    Quantity = (int)numericUpDownQuantity.Value
                };
                products.Add(newProduct);
                SortProducts();
                ClearInputs();
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                products.Remove((Product)listBoxProducts.SelectedItem);
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;
                textBoxName.Text = selectedProduct.Name;
                textBoxManufacturer.Text = selectedProduct.Manufacturer;
                comboBoxCategory.SelectedItem = selectedProduct.Category;
                numericUpDownQuantity.Value = selectedProduct.Quantity;
            }
        }

        private void SortProducts()
        {
            var sorted = products.OrderBy(p => p.Name).ToList();
            products.Clear();
            foreach (var product in sorted)
            {
                products.Add(product);
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (!Validator.ValidateName(textBoxName.Text, out string nameError))
            {
                errorProvider.SetError(textBoxName, nameError);
                isValid = false;
            }

            if (!Validator.ValidateManufacturer(textBoxManufacturer.Text, out string manufacturerError))
            {
                errorProvider.SetError(textBoxManufacturer, manufacturerError);
                isValid = false;
            }

            return isValid;
        }

        private void ClearInputs()
        {
            textBoxName.Clear();
            textBoxManufacturer.Clear();
            comboBoxCategory.SelectedIndex = 0;
            numericUpDownQuantity.Value = 0;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProductsToFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProductsFromFile();
        }

        private void SaveProductsToFile()
        {
            var json = JsonSerializer.Serialize(products.ToList());
            File.WriteAllText("products.json", json);
        }

        private void LoadProductsFromFile()
        {
            if (File.Exists("products.json"))
            {
                var json = File.ReadAllText("products.json");
                var loadedProducts = JsonSerializer.Deserialize<List<Product>>(json);
                foreach (var product in loadedProducts)
                {
                    products.Add(product);
                }
            }
        }
    }
}
