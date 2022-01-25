using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ProjectAgent007_WindowsForms
{
    public partial class Agents : Form
    {
        public string stringSort = "order by Agent.Title asc";
        public int myPage = 1;
        public int maxPages = 1;
        public int[] IDs = new int[5];

        public Agents()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
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

        private void Update()
        {
            string cmd = $"SELECT Agent.Logo,AgentType.Title,Agent.Title,Agent.Phone,[Agent].[Priority],Agent.ID,( SELECT count(*) FROM ProductSale WHERE datediff(day,SaleDate,sysdatetime()) < 3650 AND ProductSale.AgentID = Agent.ID ) AS AmountOfSells,( SELECT cast(CASE WHEN sum(MinCostForAgent) * ProductCount < 10000 THEN 0 WHEN sum(MinCostForAgent) * ProductCount > 10000 AND sum(MinCostForAgent) * ProductCount < 50000 THEN 10 WHEN sum(MinCostForAgent) * ProductCount > 50000 AND sum(MinCostForAgent) * ProductCount < 150000 THEN 10 WHEN sum(MinCostForAgent) * ProductCount > 150000 AND sum(MinCostForAgent) * ProductCount < 500000 THEN 20 WHEN sum(MinCostForAgent) * ProductCount > 500000 THEN 25 END AS numeric(3)) FROM ProductSale INNER JOIN Product ON ProductSale.ProductID = Product.ID WHERE ProductSale.AgentID = Agent.ID GROUP BY ProductCount ) AS Discount FROM Agent INNER JOIN AgentType ON Agent.AgentTypeID = AgentType.ID WHERE Agent.Title LIKE '%' + '{searchTextBox.Text.Trim()}' + '%' or Agent.Phone LIKE '%' + '{searchTextBox.Text.Trim()}' + '%' or Agent.Email LIKE '%' + '{searchTextBox.Text.Trim()}' + '%' or AgentType.Title LIKE '%' + '{searchTextBox.Text.Trim()}' + '%'";
            cmd += stringSort;
            DataTable dataTable = GetData(cmd);
            maxPages = dataTable.Rows.Count / 5;
            if (dataTable.Rows.Count % 5 > 0) maxPages++;

            if (myPage < 1) myPage = 1;
            cmd += $" OFFSET {(myPage - 1) * 5} ROWS FETCH NEXT 5 ROWS ONLY";
            dataTable = GetData(cmd);

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (dataTable.Rows[i][2] != null)
                    {
                        (Controls["nameAgent" + (i + 1).ToString()] as Label).Text = dataTable.Rows[i][1].ToString() + " | " + dataTable.Rows[i][2].ToString();
                        if ((Controls["nameAgent" + (i + 1).ToString()] as Label).Text.Length > 34)
                        {
                            (Controls["nameAgent" + (i + 1).ToString()] as Label).Text = (Controls["nameAgent" + (i + 1).ToString()] as Label).Text.Substring(0, 34);
                            (Controls["nameAgent" + (i + 1).ToString()] as Label).Text += "...";
                        }

                        (Controls["phone" + (i + 1).ToString()] as Label).Text = dataTable.Rows[i][3].ToString();
                        (Controls["priority" + (i + 1).ToString()] as Label).Text = "Приоритетность: " + dataTable.Rows[i][4].ToString();
                        (Controls["agentImage" + (i + 1).ToString()] as PictureBox).ImageLocation = string.IsNullOrEmpty((dataTable.Rows[i][0]).ToString()) ? "agents/picture.png" : dataTable.Rows[i][0].ToString().Remove(0, 1).Replace(@"\", "/");
                        (Controls["phone" + (i + 1).ToString()] as Label).Text = dataTable.Rows[i][3].ToString();
                        (Controls["sells" + (i + 1).ToString()] as Label).Text = dataTable.Rows[i][6].ToString() + " продаж за 10 лет";
                        (Controls["percent" + (i + 1).ToString()] as Label).Text = dataTable.Rows[i][7].ToString() + "%";
                        IDs[i] = Convert.ToInt32(dataTable.Rows[i][5]);

                        // Выделение цветом агентов, скидка которых 25%
                        (Controls["nameAgent" + (i + 1).ToString()] as Label).ForeColor = ((Controls["percent" + (i + 1).ToString()] as Label).Text == "25%") ? Color.LightSeaGreen : Color.Black;

                        (Controls["nameAgent" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["phone" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["priority" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["agentImage" + (i + 1).ToString()] as PictureBox).Visible = true;
                        (Controls["phone" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["sells" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["percent" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["checkBox" + (i + 1).ToString()] as CheckBox).Visible = true;
                    }
                }
                catch
                {
                    (Controls["nameAgent" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["phone" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["priority" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["agentImage" + (i + 1).ToString()] as PictureBox).Visible = false;
                    (Controls["phone" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["sells" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["percent" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["checkBox" + (i + 1).ToString()] as CheckBox).Visible = false;
                }
            }

            infoAboutError.ForeColor = ((Controls["nameAgent" + (1).ToString()] as Label).Visible == false) ? Color.Black : SystemColors.Control;

            if (sortComboBox.SelectedIndex == -1)
                sortComboBox.SelectedIndex = 0;

            ResetCheckBoxes();
        }

        private void sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;

            myPage = 1;
            UpdatePages();

            switch (cbSender.SelectedIndex)
            {
                case 1: stringSort = "order by Agent.Title asc"; Update(); break;
                case 2: stringSort = "order by Agent.Title desc"; Update(); break;

                case 3: stringSort = "order by Discount desc"; Update(); break;
                case 4: stringSort = "order by Discount asc"; Update(); break;

                case 5: stringSort = "order by [Agent].[Priority] desc"; Update(); break;
                case 6: stringSort = "order by [Agent].[Priority] asc"; Update(); break;
            }
        }

        private void UpdateOpener(object sender, EventArgs e)
        {
            Button btSender = sender as Button;

            switch (btSender.Name)
            {
                case "GoOpenStart": myPage = 1; break;
                case "GoOpenBack": myPage -= 1; break;
                case "GoOpenList1": myPage = Convert.ToInt32(GoOpenList1.Text); break;
                case "GoOpenList2": myPage = Convert.ToInt32(GoOpenList2.Text); break;
                case "GoOpenList3": myPage = Convert.ToInt32(GoOpenList3.Text); break;
                case "GoOpenList4": myPage = Convert.ToInt32(GoOpenList4.Text); break;
                case "GoOpenList5": myPage = Convert.ToInt32(GoOpenList5.Text); break;
                case "GoOpenNext": myPage += 1; break;
                case "GoOpenEnd": myPage = maxPages; break;
            }

            UpdatePages();
        }

        private void GoDeleteAgent_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            myPage = 1;
            Update();
            UpdatePages();
        }

        private void UpdatePages()
        {
            if (myPage < 1) myPage = 1;
            if (myPage > maxPages) myPage = maxPages;

            if (myPage < 3 && GoOpenList5.Enabled)
            {
                GoOpenList1.Text = (1).ToString();
                GoOpenList2.Text = (2).ToString();
                GoOpenList3.Text = (3).ToString();
                GoOpenList4.Text = (4).ToString();
                GoOpenList5.Text = (5).ToString();
            }
            else if (myPage > maxPages - 3 && GoOpenList5.Enabled)
            {
                GoOpenList1.Text = (maxPages - 4).ToString();
                GoOpenList2.Text = (maxPages - 3).ToString();
                GoOpenList3.Text = (maxPages - 2).ToString();
                GoOpenList4.Text = (maxPages - 1).ToString();
                GoOpenList5.Text = (maxPages).ToString();
            }
            else if (GoOpenList5.Enabled)
            {
                GoOpenList1.Text = (myPage - 2).ToString();
                GoOpenList2.Text = (myPage - 1).ToString();
                GoOpenList3.Text = (myPage).ToString();
                GoOpenList4.Text = (myPage + 1).ToString();
                GoOpenList5.Text = (myPage + 2).ToString();
            }

            GoOpenList5.Enabled = maxPages < 5 ? false : true;
            GoOpenList4.Enabled = maxPages < 4 ? false : true;
            GoOpenList3.Enabled = maxPages < 3 ? false : true;
            GoOpenList2.Enabled = maxPages < 2 ? false : true;
            GoOpenList1.Enabled = maxPages < 1 ? false : true;

            // Выделение жирным текстом номер страницы, на которой находится пользователь
            for (int i = 0; i < 5; i++)
            {
                (Controls["GoOpenList" + (i + 1).ToString()] as Button).Font = new Font("Microsoft Sans Serif", 12);
                if ((Controls["GoOpenList" + (i + 1).ToString()] as Button).Text.Contains(myPage.ToString()))
                    (Controls["GoOpenList" + (i + 1).ToString()] as Button).Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }

            Update();
        }

        private void GoToClearSearch_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            Update();
        }

        private void ResetCheckBoxes()
        {
            for (int i = 0; i < 5; i++)
            {
                (Controls["checkBox" + (i + 1).ToString()] as CheckBox).Checked = false;
            }
        }

        private void InsertData(string cmd)
        {
            string connectionString = $@"Data Source=localhost;Initial Catalog=EyesSave;Integrated Security=True";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем асинхронное соединение с базой данных
                    Task connectionTask = connection.OpenAsync();
                    Task.WaitAll(connectionTask);


                    // Если соединение произвелось успешно, то заполняем базу данных
                    if (!connectionTask.IsFaulted)
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = cmd;
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GoToDeleteAgent_Click(object sender, EventArgs e)
        {
            bool presenceOfAgents = false;

            for (int i = 0; i < 5; i++)
            {
                if ((Controls["checkBox" + (i + 1).ToString()] as CheckBox).Checked)
                {
                    InsertData($"delete from Agent where Agent.ID = {IDs[i]}");
                    presenceOfAgents = true;
                }
            }

            if (presenceOfAgents)
            {
                Update();
                MessageBox.Show("Данные агентов были успешно удалены!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Для удаление не были указаны агенты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
