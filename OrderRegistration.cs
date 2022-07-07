using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryCalcApp
{
    public partial class OrderRegistration : Form
    {
        public OrderRegistration()
        {
            InitializeComponent();
        }

        public double length;
        public double width;
        public double height;
        public double weight;
        public string senderPoint;
        public string destinationPoint;
        public string destinationAddress;
        public bool fromDoor;
        public bool toDoor;
        public string companyName;
        public DateTime dateOfDelivery;
        public double price;

        private void acceptOrderButton_Click(object sender, EventArgs e)
        {
            if (!lastNameMaskedTextBox.MaskCompleted || !nameMaskedTextBox.MaskCompleted || !phoneMaskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Не все обязательные поля были заполнены правильно.", "Невозможно оформить заказ.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DeliveryOrdersDB;Integrated Security=True");
            connection.Open();
            string command = String.Format("INSERT INTO OrdersTable (Название_ТК, Город_отправителя, От_двери, Город_получателя, До_двери, Адрес_доставки, Длина, Ширина, Высота, Вес, Дата_заказа, Дата_доставки, Стоимость, Фамилия, Имя, Отчество, Номер_телефона) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, {7}, {8}, {9}, GETDATE(), '{10}', {11}, '{12}', '{13}', '{14}', '{15}')",
                companyName, senderPoint, fromDoor, destinationPoint, toDoor, destinationAddress, length.ToString().Replace(",", "."), width.ToString().Replace(",", "."), height.ToString().Replace(",", "."), weight.ToString().Replace(",", "."), dateOfDelivery, price.ToString().Replace(",", "."), lastNameMaskedTextBox.Text, nameMaskedTextBox.Text, patronymicMaskedTextBox.Text, phoneMaskedTextBox.Text);
            SqlCommand cmd = new SqlCommand(command);
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Заказ был успешно оформлен.");
            this.Close();
        }
    }
}
