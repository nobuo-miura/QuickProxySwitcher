using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;

namespace QuickProxySwitcher
{
    public partial class MainForm : Form
    {
        private const string FilePath = "proxies.dat";
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;


        public MainForm()
        {
            InitializeComponent();
            LoadProxies();
            PopulateProxyListBox();
            UpdateProxyStatusLabel();
        }

        public List<Proxy> Proxies { get; private set; }

        private void PopulateProxyListBox()
        {
            ProxyListBox.Items.Clear();
            foreach (var proxy in Proxies)
            {
                ProxyListBox.Items.Add(proxy.GetData);
            }
        }

        private void ProxyListBox_DoubleClick(object sender, EventArgs e)
        {
            SetProxy();
        }


        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool
            InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        private void LoadProxies()
        {
            if (File.Exists(FilePath))
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    var formatter = new BinaryFormatter();
                    Proxies = (List<Proxy>)formatter.Deserialize(stream);
                }
            }
            else
            {
                Proxies = new List<Proxy>();
            }
        }

        public void SaveProxies()
        {
            using (var stream = File.Create(FilePath))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Proxies);
            }
        }

        private void SetProxy(bool enable, string proxyAddress)
        {
            using (var registry =
                   Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings",
                       true))
            {
                registry.SetValue("ProxyEnable", enable ? 1 : 0);
                registry.SetValue("ProxyServer", enable ? proxyAddress : string.Empty);
            }

            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            UpdateProxyStatusLabel();
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetProxy(false, string.Empty);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProxyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new AddProxy(Proxies);
                form.ShowDialog(this);
                if (form.Proxy != null)
                {
                    Proxies.Add(form.Proxy);
                    PopulateProxyListBox();
                    SaveProxies();
                }

                form.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProxyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProxyListBox.SelectedIndex == -1)
                {
                    return;
                }

                var selectedProxyName = ProxyListBox.SelectedItem.ToString();
                var selectedProxy = Proxies.Find(p => p.GetData == selectedProxyName);

                if (selectedProxy == null)
                {
                    return;
                }

                Proxies.Remove(selectedProxy);
                ProxyListBox.Items.RemoveAt(ProxyListBox.SelectedIndex);
                SaveProxies();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetProxy();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetProxy()
        {
            if (ProxyListBox.SelectedIndex == -1)
            {
                return;
            }

            var selectedProxyName = ProxyListBox.SelectedItem.ToString();
            var selectedProxy = Proxies.Find(p => p.GetData == selectedProxyName);

            if (selectedProxy != null)
            {
                SetProxy(true, selectedProxy.Address);
            }
        }

        private void UpdateProxyStatusLabel()
        {
            var proxySettings = GetCurrentProxySettings();
            ProxyStatusLabel.Text =
                $"Enabled: {proxySettings.Enabled}{Environment.NewLine}Address: {proxySettings.Address}";
        }

        private (bool Enabled, string Address) GetCurrentProxySettings()
        {
            using (var registry =
                   Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings",
                       false))
            {
                var isEnabled = Convert.ToBoolean(registry.GetValue("ProxyEnable", 0));
                var proxyAddress = registry.GetValue("ProxyServer", "") as string;
                return (isEnabled, proxyAddress);
            }
        }
    }
}
