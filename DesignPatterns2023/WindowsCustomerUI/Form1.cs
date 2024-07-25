using CustomerLibrary;

namespace WindowsCustomerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ICustomer _customer;  //decoupling
            Factory customerFactory = new();
            _customer = customerFactory.Create(cmbCustomerType.SelectedIndex);
            //if (cmbCustomerType.SelectedIndex == 0)
            //{
            //    //this still coupled, what is the fix to decouple
            //    //PIC Pattern for decoupling (Factory Pattern)
            //    //Acronym of PIC is “Polymorphism + Interfaces + Centralizing object creation”
            //    // get rid of the "new" keyword -- create a factory
            //    _customer = new Lead();


            //}
            //else
            //{
            //    _customer = new Customer();
            //}
            _customer.CustomerName = txtCustomerName.Text;
            _customer.Address = txtAddress.Text;
            _customer.PhoneNumber = txtPhoneNumber.Text;
            //_customer.BillDate = Convert.ToDateTime(txtBillingDate.Text);
            //_customer.BillAmount = Convert.ToDecimal(txtBillingAmount.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}