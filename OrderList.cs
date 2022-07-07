using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace DeliveryCalcApp
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
            pickCompanyComboBox.SelectedIndex = 0;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deliveryOrdersDBDataSet.OrdersTable". При необходимости она может быть перемещена или удалена.
            this.ordersTableTableAdapter.Fill(this.deliveryOrdersDBDataSet.OrdersTable);
        }

        private void pickCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            DataTable ordersTable = new DataTable();
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DeliveryOrdersDB;Integrated Security=True";
            string command = $"SELECT * FROM OrdersTable WHERE Название_ТК = '{pickCompanyComboBox.Text}'";
            if (pickCompanyComboBox.Text == "Все") { command = "SELECT * FROM OrdersTable"; }
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlDataAdapter ordersAdapter = new SqlDataAdapter(command, connect);
                ordersAdapter.Fill(ordersTable);
            }
            bindingSource.DataSource = ordersTable;
            ordersDataGridView.DataSource = bindingSource;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            ordersDataGridView.Sort(ordersDataGridView.Columns["датадоставкиDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
        }

        private void exportExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS файл (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application exApp = new Excel.Application();
                exApp.Visible = false;
                exApp.Workbooks.Add();
                Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                workSheet.Cells[1, 1] = "Номер заказа";
                workSheet.Cells[1, 2] = "Название ТК";
                workSheet.Cells[1, 3] = "Город отправителя";
                workSheet.Cells[1, 4] = "От двери";
                workSheet.Cells[1, 5] = "Город получателя";
                workSheet.Cells[1, 6] = "До двери";
                workSheet.Cells[1, 7] = "Адрес доставки";
                workSheet.Cells[1, 8] = "Длина";
                workSheet.Cells[1, 9] = "Ширина";
                workSheet.Cells[1, 10] = "Высота";
                workSheet.Cells[1, 11] = "Вес";
                workSheet.Cells[1, 12] = "Дата заказа";
                workSheet.Cells[1, 13] = "Дата доставки";
                workSheet.Cells[1, 14] = "Стоимость";
                workSheet.Cells[1, 15] = "Фамилия";
                workSheet.Cells[1, 16] = "Имя";
                workSheet.Cells[1, 17] = "Отчество";
                workSheet.Cells[1, 18] = "Номер телефона";
                for (int i = 0; i < ordersDataGridView.Rows.Count; i++)
                {
                    for (int j = 1; j < ordersDataGridView.Rows[i].Cells.Count + 1; j++)
                    {
                        workSheet.Cells[i + 2, j] = ordersDataGridView.Rows[i].Cells[j - 1].Value;
                    }
                }
                File.Delete(saveFileDialog.FileName);
                workSheet.SaveAs(saveFileDialog.FileName);
                exApp.Quit();
                MessageBox.Show("Экспорт был успешно выполнен.");
            }
        }
    }
}