using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenDataBase();
            CheckOnOpen();
        }
        private void OpenDataBase()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["practicaDB"].ConnectionString);
            sqlConnection.Open();                      
        }
        private void CheckOnOpen()
        {
            if (sqlConnection.State == ConnectionState.Open) MessageBox.Show("Подключение к бд открыто");
            else MessageBox.Show("Подключение к бд не успешно");
        }

        private void InsertWorker_Click(object sender, EventArgs e)
        {
            string commandLine = $"INSERT INTO [Workers] (Name, Surname, Salary, Experience, Age, Post) VALUES ('{WorkerNameTextBox.Text}', '{WorkerSurnameTextBox.Text}', '{WorkerSalaryTextBox.Text}', '{WorkerExpirienceTextBox.Text}', '{WorkerAgeTextBox.Text}', '{WorkerPostTextBox.Text}')";
            SqlCommand sqlCommand = new SqlCommand(commandLine, sqlConnection);
            
            string successInsertCount = sqlCommand.ExecuteNonQuery().ToString();
            CheckOnSuccessfulInsert(successInsertCount);
        }
        private void CheckOnSuccessfulInsert(string count)
        {
            int countInt = Convert.ToInt32(count);
            if (countInt > 0) { MessageBox.Show("Успешное занесение в бд"); }
            else MessageBox.Show("Проблемы с добавление в бд");
        }

        private void WorkersSelectButton_Click(object sender, EventArgs e)
        {
            FillFormTable();
        }
        private void FillFormTable()
        {
            string selectCommand = "SELECT * FROM Workers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Workers_Read_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader = null;
            try {
                SqlCommand sqlCommand = new SqlCommand("SELECT Name, Age, Post FROM Workers", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                ListViewItem listViewItem = null;

                while (dataReader.Read())
                {
                    listViewItem = new ListViewItem();
                }

            } catch (Exception ex) {
                MessageBox.Show($"Ошибка чтение: {ex}");

            } finally {
                if (dataReader !=null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void InsertProduct_Click(object sender, EventArgs e)
        {
            string commandLine = $"INSERT INTO [Product] (Name, Cost) VALUES ('{ProductName.Text}', '{ProductCost.Text}')";
            SqlCommand sqlCommand = new SqlCommand(commandLine, sqlConnection);
            string successInsertCount = sqlCommand.ExecuteNonQuery().ToString();
            CheckOnSuccessfulInsert(successInsertCount);
        }

        private void InsertClient_Click(object sender, EventArgs e)
        {
            string commandLine = $"INSERT INTO [Client] (Name, Surname, Age, Phone) VALUES ('{ClientName.Text}', '{ClientSurname.Text}', '{ClientAge.Text}', '{ClientPhone.Text}')";
            SqlCommand sqlCommand = new SqlCommand(commandLine, sqlConnection);
            string successInsertCount = sqlCommand.ExecuteNonQuery().ToString();
            CheckOnSuccessfulInsert(successInsertCount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string commandLine = $"INSERT INTO [Sponsors] (Name, Attachments, Phone) VALUES ('{PartnerName.Text}', '{PartnerAttach.Text}', '{PartnerPhone.Text}')";
            SqlCommand sqlCommand = new SqlCommand(commandLine, sqlConnection);
            string successInsertCount = sqlCommand.ExecuteNonQuery().ToString();
            CheckOnSuccessfulInsert(successInsertCount);
        }

        private void ProductSelect_Click(object sender, EventArgs e)
        {
            string selectCommand = "SELECT * FROM Product";
            SetDataTable(selectCommand, DataProduct);
        }

        private void SelectClient_Click(object sender, EventArgs e)
        {
            string selectCommand = "SELECT * FROM Client";
            SetDataTable(selectCommand, DataGridClient);
        }

        private void PartnerSelect_Click(object sender, EventArgs e)
        {            
            string selectCommand = "SELECT * FROM Sponsors";
            SetDataTable(selectCommand, DataGridPartnet);
        }
        private void SetDataTable(string command, DataGridView dataGrid)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGrid.DataSource = dataSet.Tables[0];
        }
    }
}
