using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.IO;

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
                    workSheet.Cells[i + 2, 1] = ordersDataGridView.Rows[i].Cells[0].Value;
                    workSheet.Cells[i + 2, 2] = ordersDataGridView.Rows[i].Cells[1].Value;
                    workSheet.Cells[i + 2, 3] = ordersDataGridView.Rows[i].Cells[2].Value;
                    workSheet.Cells[i + 2, 4] = ordersDataGridView.Rows[i].Cells[3].Value;
                    workSheet.Cells[i + 2, 5] = ordersDataGridView.Rows[i].Cells[4].Value;
                    workSheet.Cells[i + 2, 6] = ordersDataGridView.Rows[i].Cells[5].Value;
                    workSheet.Cells[i + 2, 7] = ordersDataGridView.Rows[i].Cells[6].Value;
                    workSheet.Cells[i + 2, 8] = ordersDataGridView.Rows[i].Cells[7].Value;
                    workSheet.Cells[i + 2, 9] = ordersDataGridView.Rows[i].Cells[8].Value;
                    workSheet.Cells[i + 2, 10] = ordersDataGridView.Rows[i].Cells[9].Value;
                    workSheet.Cells[i + 2, 11] = ordersDataGridView.Rows[i].Cells[10].Value;
                    workSheet.Cells[i + 2, 12] = ordersDataGridView.Rows[i].Cells[11].Value;
                    workSheet.Cells[i + 2, 13] = ordersDataGridView.Rows[i].Cells[12].Value;
                    workSheet.Cells[i + 2, 14] = ordersDataGridView.Rows[i].Cells[13].Value;
                    workSheet.Cells[i + 2, 15] = ordersDataGridView.Rows[i].Cells[14].Value;
                    workSheet.Cells[i + 2, 16] = ordersDataGridView.Rows[i].Cells[15].Value;
                    workSheet.Cells[i + 2, 17] = ordersDataGridView.Rows[i].Cells[16].Value;
                    workSheet.Cells[i + 2, 18] = ordersDataGridView.Rows[i].Cells[17].Value;
                }
                File.Delete(saveFileDialog.FileName);
                workSheet.SaveAs(saveFileDialog.FileName);
                exApp.Quit();
                MessageBox.Show("Экспорт был успешно выполнен.");
            }
        }
    }
}