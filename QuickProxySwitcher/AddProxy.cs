using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuickProxySwitcher
{
    public partial class AddProxy : Form
    {
        private readonly List<Proxy> _list;

        public AddProxy(List<Proxy> list)
        {
            InitializeComponent();
            _list = list;
        }

        public Proxy Proxy { get; set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(AddressTextBox.Text))
            {
                MessageBox.Show("Name or address has not been entered.");
                return;
            }

            var proxy = new Proxy { Name = NameTextBox.Text, Address = AddressTextBox.Text };

            if (_list.Find(p => p.GetData == proxy.GetData) != null)
            {
                MessageBox.Show("A duplicate configuration already exists.");
                return;
            }

            Proxy = proxy;
            Close();
        }
    }
}
