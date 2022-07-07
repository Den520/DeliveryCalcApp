using System;
using System.Reflection;
using System.Windows.Forms;

namespace DeliveryCalcApp
{
    public partial class CalculationForm : Form
    {
        dynamic Boxberry;
        dynamic CDEK;
        dynamic RussianPost;

        public CalculationForm()
        {
            InitializeComponent();

            //динамическое добавление библиотек
            Assembly BoxberryLib = Assembly.LoadFrom("BoxberryLib.dll");
            Boxberry = Activator.CreateInstance(BoxberryLib.GetType("BoxberryLib.Boxberry"));
            Assembly CDEKLib = Assembly.LoadFrom("CDEKLib.dll");
            CDEK = Activator.CreateInstance(CDEKLib.GetType("CDEKLib.CDEK"));
            Assembly RussianPostLib = Assembly.LoadFrom("RussianPostLib.dll");
            RussianPost = Activator.CreateInstance(RussianPostLib.GetType("RussianPostLib.RussianPost"));
        }

        double length;
        double width;
        double height;
        double weight;
        string senderPoint;
        string destinationPoint;
        string destinationAddress;
        bool fromDoor;
        bool toDoor;
        DateTime[] dateOfDeliveryArr = new DateTime[3];
        double[] priceArr = new double[3];

        private void calculateButton_Click(object sender, EventArgs e)
        {
            orderRegistrationButton.Enabled = false;
            warningLabel.Visible = false;
            //проверка на незаполненные поля
            if (sendingPointComboBox.Text == "" || destinationPointComboBox.Text == "" ||
                destinationAddressTextBox.Text == "" || lengthTextBox.Text == "" ||
                widthTextBox.Text == "" || heightTextBox.Text == "" || weightTextBox.Text == "")
            {
                MessageBox.Show("Не все поля были заполнены. Каждое поле является обязательным для заполнения.", "Невозможно произвести рассчёт.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stepOfDistance = Math.Abs(destinationPointComboBox.SelectedIndex - sendingPointComboBox.SelectedIndex);

            length = Convert.ToDouble(lengthTextBox.Text.Replace(".", ","));
            width = Convert.ToDouble(widthTextBox.Text.Replace(".", ","));
            height = Convert.ToDouble(heightTextBox.Text.Replace(".", ","));
            weight = Convert.ToDouble(weightTextBox.Text.Replace(".", ","));
            senderPoint = sendingPointComboBox.Text;
            destinationPoint = destinationPointComboBox.Text;
            destinationAddress = destinationAddressTextBox.Text;
            fromDoor = fromDoorCheckBox.Checked;
            toDoor = toDoorCheckBox.Checked;

            if (Boxberry.CheckAvailability(length, width, height, weight))
            {
                //произвести рассчёты и установить на лейблы значения
                dateOfDeliveryArr[0] = Boxberry.GetDate(stepOfDistance);
                priceArr[0] = Boxberry.GetPrice(stepOfDistance, fromDoorCheckBox.Checked, toDoorCheckBox.Checked, length, width, height, weight);
                dateBoxberryLabel.Text = dateOfDeliveryArr[0].ToShortDateString();
                priceBoxberryLabel.Text = priceArr[0].ToString();
                boxberryRadioButton.Enabled = true;
                orderRegistrationButton.Enabled = true;
            }
            else
            {
                boxberryRadioButton.Enabled = false;
                boxberryRadioButton.Checked = false;
                dateBoxberryLabel.Text = "Пусто";
                priceBoxberryLabel.Text = "Пусто";
                warningLabel.Visible = true;
            }

            if (CDEK.CheckAvailability(length, width, height, weight))
            {
                //произвести рассчёты и установить на лейблы значения
                dateOfDeliveryArr[1] = CDEK.GetDate(stepOfDistance);
                priceArr[1] = CDEK.GetPrice(stepOfDistance, fromDoorCheckBox.Checked, toDoorCheckBox.Checked, length, width, height, weight);
                dateCDEKLabel.Text = dateOfDeliveryArr[1].ToShortDateString();
                priceCDEKLabel.Text = priceArr[1].ToString();
                CDEKRadioButton.Enabled = true;
                orderRegistrationButton.Enabled = true;
            }
            else
            {
                CDEKRadioButton.Enabled = false;
                CDEKRadioButton.Checked = false;
                dateCDEKLabel.Text = "Пусто";
                priceCDEKLabel.Text = "Пусто";
                warningLabel.Visible = true;
            }

            if (RussianPost.CheckAvailability(length, width, height, weight))
            {
                //произвести рассчёты и установить на лейблы значения
                dateOfDeliveryArr[2] = RussianPost.GetDate(stepOfDistance);
                priceArr[2] = RussianPost.GetPrice(stepOfDistance, fromDoorCheckBox.Checked, toDoorCheckBox.Checked, length, width, height, weight);
                dateRussianPostLabel.Text = dateOfDeliveryArr[2].ToShortDateString();
                priceRussianPostLabel.Text = priceArr[2].ToString();
                russianPostRadioButton.Enabled = true;
                orderRegistrationButton.Enabled = true;
            }
            else
            {
                russianPostRadioButton.Enabled = false;
                russianPostRadioButton.Checked = false;
                dateRussianPostLabel.Text = "Пусто";
                priceRussianPostLabel.Text = "Пусто";
                warningLabel.Visible = true;
            }
        }

        private void orderRegistrationButton_Click(object sender, EventArgs e)
        {
            RadioButton[] radioButtons_Group = { boxberryRadioButton, CDEKRadioButton, russianPostRadioButton };
            for (int i = 0; i < radioButtons_Group.Length; i++)
            {
                if (radioButtons_Group[i].Checked == true)
                {
                    OrderRegistration orderRegistration = new OrderRegistration();
                    orderRegistration.length = length;
                    orderRegistration.width = width;
                    orderRegistration.height = height;
                    orderRegistration.weight = weight;
                    orderRegistration.senderPoint = senderPoint;
                    orderRegistration.destinationPoint = destinationPoint;
                    orderRegistration.destinationAddress = destinationAddress;
                    orderRegistration.fromDoor = fromDoor;
                    orderRegistration.toDoor = toDoor;
                    orderRegistration.companyName = radioButtons_Group[i].Text;
                    orderRegistration.dateOfDelivery = dateOfDeliveryArr[i];
                    orderRegistration.price = priceArr[i];
                    orderRegistration.ShowDialog();
                    return;
                }
            }
        }

        private void orderListButton_Click(object sender, EventArgs e)
        {
            OrderList orderList = new OrderList();
            orderList.ShowDialog();
        }
    }
}
