using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EyewearCompany
{
    public partial class EditAgents : Form
    {
        public EditAgents()
        {
            InitializeComponent();
        }

        private void BackToAgents()
        {
            Agents agents = new Agents();
            agents.Show();
            this.Hide();
        }

        private void EditAgents_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToAgents();
        }

        private void GoToBack_Click(object sender, EventArgs e)
        {
            BackToAgents();
        }

        private DataTable GetData(string cmd)
        {
            string connectionString = $@"Data Source=localhost;Initial Catalog=EyesSave;Integrated Security=True";
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(connectionString))
            {
                // Открываем асинхронное соединение с базой данных
                Task connectionTask = connection.OpenAsync();
                Task.WaitAll(connectionTask);

                // Если соединение произвелось успешно
                if (!connectionTask.IsFaulted)
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = cmd;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SqlDataReader DataRead = null;
                        DataRead = reader;
                        dataTable.Load(DataRead);
                    }
                }

                return dataTable;
            }
        }

        private void EditAgents_Load(object sender, EventArgs e)
        {
            DataTable dataTable = GetData("select Title from AgentType");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox1.Items.Add(dataTable.Rows[i][0].ToString());
            }

            string ID = Agents.EditID;

            dataTable = GetData($"select* from Agent where ID = '{ID}'");

            DataTable dataTable2 = GetData($"select AgentType.Title from AgentType where AgentType.ID = '{dataTable.Rows[0][2]}'");

            comboBox1.SelectedItem = dataTable2.Rows[0][0].ToString();

            nameCompany.Text = dataTable.Rows[0][1].ToString();
            address.Text = dataTable.Rows[0][3].ToString();
            FIO.Text = dataTable.Rows[0][6].ToString();
            phone.Text = dataTable.Rows[0][7].ToString();
            email.Text = dataTable.Rows[0][8].ToString();
            logo.Text = dataTable.Rows[0][9].ToString();
            INN.Text = dataTable.Rows[0][4].ToString();
            KPP.Text = dataTable.Rows[0][5].ToString();
            priority.Text = dataTable.Rows[0][10].ToString();
        }

        private void GoToEditAgent_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || String.IsNullOrEmpty(nameCompany.Text.Trim()) || String.IsNullOrEmpty(phone.Text.Trim()))
            {
                MessageBox.Show("Данные были некорректно заполены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dataTable = GetData($"select AgentType.ID from AgentType where AgentType.Title = '{comboBox1.SelectedItem}'");
                string agentTypeID = dataTable.Rows[0][0].ToString();

                string adr = "NULL", fio = "NULL", milo = "NULL", ssilka = "NULL", company = "NULL", phon = "NULL";
                Int64 prior = 0, inn = 0, kpp = 0;

                if (!String.IsNullOrEmpty(address.Text.Trim())) adr = "'" + address.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(nameCompany.Text.Trim())) company = "'" + nameCompany.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(FIO.Text.Trim())) fio = "'" + FIO.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(phone.Text.Trim())) phon = "'" + phone.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(email.Text.Trim())) milo = "'" + email.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(logo.Text.Trim())) ssilka = "'" + logo.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(KPP.Text.Trim())) kpp = Convert.ToInt32(KPP.Text);
                if (!String.IsNullOrEmpty(priority.Text.Trim())) prior = Convert.ToInt32(priority.Text);

                GetData($"UPDATE [dbo].[Agent] set AgentTypeID = {agentTypeID} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set Title = {company} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set DirectorName = {fio} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set Email = {milo} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set Logo = {ssilka} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set Address = {adr} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set Phone = {phon} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set Priority = {prior} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set INN = {inn} where ID = '{Agents.EditID}'");
                GetData($"UPDATE [dbo].[Agent] set KPP = {kpp} where ID = '{Agents.EditID}'");

                MessageBox.Show("Данные агента были успешно изменены!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackToAgents();
            }
        }

        private void KPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)Keys.Back || e.KeyChar == 40 || e.KeyChar == 32 || e.KeyChar == 41 || e.KeyChar == 45 || e.KeyChar == 43) { }
            else e.Handled = true;
        }
    }
}
