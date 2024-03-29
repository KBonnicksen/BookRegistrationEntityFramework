﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
            PopulateBookList();
        }

        /// <summary>
        /// Adds all books to the form
        /// </summary>
        private void PopulateBookList()
        {
            List<Book> books = BookDB.GetBooks();
            cboBooks.DataSource = books;
            cboBooks.DisplayMember = nameof(Book.Title);
        }

        /// <summary>
        /// Populates customer list from the database
        /// </summary>
        private void PopulateCustomerList()
        {
            List<Customer> customers = CustomerDB.GetCustomers();

            cboCustomers.DataSource = customers;
            cboCustomers.DisplayMember = nameof(Customer.FullName);
        }

        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            //Hard code customer for test purposes
            Customer c = new Customer()
            {
                FirstName = "Larry",
                LastName = "King",
                DateOfBirth = DateTime.Now,
                Title = "Talk show host"
            };
            CustomerDB.AddCustomer(c);
            MessageBox.Show($"Successfully added {c.CustomerID} : {c.FullName}");
        }
    }
}
