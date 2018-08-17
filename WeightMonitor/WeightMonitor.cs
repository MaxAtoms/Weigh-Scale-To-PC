using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WeightMonitor
{
    public partial class WeightMonitor : Form
    {

        private string selectedUnit = "Kilogram";
        private string currentWeight = "";

        System.Threading.Thread t;

        public string SelectedUnit { get => selectedUnit; set => selectedUnit = value; }
        public string CurrentWeight { get => currentWeight; set => currentWeight = value; }

        public WeightMonitor()
        {
            InitializeComponent();
            AddComPorts();
            StartDefaultConnection();

            WeightOutput.Font = new Font("Arial", 24, FontStyle.Bold);
            UnitComboBox.SelectedIndex = 0;
            
            t = new System.Threading.Thread(ShowWeight);
            t.Start();
        }

        private void ShowWeight()
        {
            while (true)
            {
                string text;
                double weight = 0;

                try
                {
                    weight = Double.Parse(SerialCom.GetWeight());

                    if (SelectedUnit == "Kilogram")
                    {
                        weight /= 1000;
                        text = weight.ToString("F2") + " kg";
                    }
                    else
                    {
                        text = weight + " g";
                    }
                }
                catch (System.FormatException)
                {
                    text = "Error";
                }
                
                CurrentWeight = text;

                UpdateOutput(text);
            }
        }

        private void UpdateOutput(string text)
        {
            Action action = () => WeightOutput.Text = text;
            try
            {
                this.Invoke(action);
            }
            catch (System.ObjectDisposedException)
            { }
        }

        private void AddComPorts()
        {
            string[] uniquePorts = System.IO.Ports.SerialPort.GetPortNames();
            uniquePorts = uniquePorts.Distinct().ToArray();

            foreach (string s in uniquePorts)
            {
                ComPortComboBox.Items.Add(s);
            }

            ComPortComboBox.SelectedIndex = ComPortComboBox.Items.Count - 1;
        }

        private void StartDefaultConnection()
        {
            object selectedItem = ComPortComboBox.SelectedItem;
            string itemText = ComPortComboBox.GetItemText(selectedItem);
            SerialCom.Setup(itemText);
        }

        private void ComPortComboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            SerialCom.ChangePort(ComPortComboBox.GetItemText(ComPortComboBox.SelectedItem));
        }

        private void UnitComboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            SelectedUnit = UnitComboBox.GetItemText(UnitComboBox.SelectedItem);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CurrentWeight);
        }

        private void TareButton_Click(object sender, EventArgs e)
        {
            SerialCom.SendTara();
        }
    }
}