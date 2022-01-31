using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyewearCompany
{
    public partial class AddNewAgent : Form
    {
        public AddNewAgent()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            KPP.Text = trackBar1.Value.ToString();
        }

        private void InsertINN_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Int32 num = rnd.Next(100000000, 999999999);
            INN.Text = num.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            priority.Text = trackBar2.Value.ToString();
        }

        private void BackToAgents()
        {
            Agents agents = new Agents();
            agents.Show();
            this.Hide();
        }

        private void AddNewAgent_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToAgents();
        }

        private void GoToBack_Click(object sender, EventArgs e)
        {
            BackToAgents();
        }

        private void GoToAddNewAgent_Click(object sender, EventArgs e)
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

                if (!String.IsNullOrEmpty(address.Text.Trim())) adr = "'" + address.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(nameCompany.Text.Trim())) company = "'" + nameCompany.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(FIO.Text.Trim())) fio = "'" + FIO.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(phone.Text.Trim())) phon = "'" + phone.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(email.Text.Trim())) milo = "'" + email.Text.Trim() + "'";
                if (!String.IsNullOrEmpty(logo.Text.Trim())) ssilka = "'" + logo.Text.Trim() + "'";

                dataTable = GetData($"insert into [dbo].[Agent](Title, AgentTypeID, [Address], INN, KPP, DirectorName, Phone, Email, Logo, [Priority]) values ({company}, '{agentTypeID}', {adr}, '{INN.Text.Trim()}0', '{KPP.Text.Trim()}', {fio}, {phon}, {milo}, {ssilka}, '{priority.Text.Trim()}')");

                MessageBox.Show("Данные агента были успешно добавлены!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackToAgents();
            }
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

        private void AddNewAgent_Load(object sender, EventArgs e)
        {
            DataTable dataTable = GetData("select Title from AgentType");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox1.Items.Add(dataTable.Rows[i][0].ToString());
            }
        }
    }
}
