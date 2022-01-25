
namespace ProjectAgent007_WindowsForms
{
    partial class Agents
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.percent1 = new System.Windows.Forms.Label();
            this.priority1 = new System.Windows.Forms.Label();
            this.phone1 = new System.Windows.Forms.Label();
            this.sells1 = new System.Windows.Forms.Label();
            this.agentImage1 = new System.Windows.Forms.PictureBox();
            this.nameAgent1 = new System.Windows.Forms.Label();
            this.percent2 = new System.Windows.Forms.Label();
            this.priority2 = new System.Windows.Forms.Label();
            this.phone2 = new System.Windows.Forms.Label();
            this.sells2 = new System.Windows.Forms.Label();
            this.agentImage2 = new System.Windows.Forms.PictureBox();
            this.nameAgent2 = new System.Windows.Forms.Label();
            this.percent3 = new System.Windows.Forms.Label();
            this.priority3 = new System.Windows.Forms.Label();
            this.phone3 = new System.Windows.Forms.Label();
            this.sells3 = new System.Windows.Forms.Label();
            this.agentImage3 = new System.Windows.Forms.PictureBox();
            this.nameAgent3 = new System.Windows.Forms.Label();
            this.percent4 = new System.Windows.Forms.Label();
            this.priority4 = new System.Windows.Forms.Label();
            this.phone4 = new System.Windows.Forms.Label();
            this.sells4 = new System.Windows.Forms.Label();
            this.agentImage4 = new System.Windows.Forms.PictureBox();
            this.nameAgent4 = new System.Windows.Forms.Label();
            this.percent5 = new System.Windows.Forms.Label();
            this.priority5 = new System.Windows.Forms.Label();
            this.phone5 = new System.Windows.Forms.Label();
            this.sells5 = new System.Windows.Forms.Label();
            this.agentImage5 = new System.Windows.Forms.PictureBox();
            this.nameAgent5 = new System.Windows.Forms.Label();
            this.GoToClearSearch = new System.Windows.Forms.Button();
            this.GoOpenList3 = new System.Windows.Forms.Button();
            this.GoOpenList4 = new System.Windows.Forms.Button();
            this.GoOpenList5 = new System.Windows.Forms.Button();
            this.GoOpenList2 = new System.Windows.Forms.Button();
            this.GoOpenList1 = new System.Windows.Forms.Button();
            this.GoOpenBack = new System.Windows.Forms.Button();
            this.GoOpenNext = new System.Windows.Forms.Button();
            this.GoOpenEnd = new System.Windows.Forms.Button();
            this.GoOpenStart = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GoToAddNewAgent = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.GoToEditAgent = new System.Windows.Forms.Button();
            this.GoToDeleteAgent = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.infoAboutError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage5)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(27, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 29);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Сортировка",
            "по компании ▼",
            "по компании ▲",
            "по скидке ▼",
            "по скидке ▲",
            "по приоритетности ▼",
            "по приоритетности ▲"});
            this.sortComboBox.Location = new System.Drawing.Point(319, 15);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(184, 28);
            this.sortComboBox.TabIndex = 3;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sorting_SelectedIndexChanged);
            // 
            // percent1
            // 
            this.percent1.AutoSize = true;
            this.percent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.percent1.Location = new System.Drawing.Point(738, 113);
            this.percent1.Name = "percent1";
            this.percent1.Size = new System.Drawing.Size(59, 25);
            this.percent1.TabIndex = 16;
            this.percent1.Text = "XX%";
            this.percent1.Visible = false;
            // 
            // priority1
            // 
            this.priority1.AutoSize = true;
            this.priority1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority1.Location = new System.Drawing.Point(364, 139);
            this.priority1.Name = "priority1";
            this.priority1.Size = new System.Drawing.Size(150, 18);
            this.priority1.TabIndex = 15;
            this.priority1.Text = "Приоритетность: XX";
            this.priority1.Visible = false;
            // 
            // phone1
            // 
            this.phone1.AutoSize = true;
            this.phone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone1.Location = new System.Drawing.Point(364, 121);
            this.phone1.Name = "phone1";
            this.phone1.Size = new System.Drawing.Size(110, 18);
            this.phone1.TabIndex = 14;
            this.phone1.Text = "+x xxx xxx xx xx";
            this.phone1.Visible = false;
            // 
            // sells1
            // 
            this.sells1.AutoSize = true;
            this.sells1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sells1.Location = new System.Drawing.Point(364, 103);
            this.sells1.Name = "sells1";
            this.sells1.Size = new System.Drawing.Size(133, 18);
            this.sells1.TabIndex = 13;
            this.sells1.Text = "XX продаж за год";
            this.sells1.Visible = false;
            // 
            // agentImage1
            // 
            this.agentImage1.Location = new System.Drawing.Point(231, 71);
            this.agentImage1.Name = "agentImage1";
            this.agentImage1.Size = new System.Drawing.Size(126, 100);
            this.agentImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agentImage1.TabIndex = 11;
            this.agentImage1.TabStop = false;
            this.agentImage1.Visible = false;
            // 
            // nameAgent1
            // 
            this.nameAgent1.AutoSize = true;
            this.nameAgent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAgent1.Location = new System.Drawing.Point(363, 79);
            this.nameAgent1.Name = "nameAgent1";
            this.nameAgent1.Size = new System.Drawing.Size(283, 24);
            this.nameAgent1.TabIndex = 12;
            this.nameAgent1.Text = "Тип | Наименование агента";
            this.nameAgent1.Visible = false;
            // 
            // percent2
            // 
            this.percent2.AutoSize = true;
            this.percent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.percent2.Location = new System.Drawing.Point(738, 219);
            this.percent2.Name = "percent2";
            this.percent2.Size = new System.Drawing.Size(59, 25);
            this.percent2.TabIndex = 23;
            this.percent2.Text = "XX%";
            this.percent2.Visible = false;
            // 
            // priority2
            // 
            this.priority2.AutoSize = true;
            this.priority2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority2.Location = new System.Drawing.Point(364, 245);
            this.priority2.Name = "priority2";
            this.priority2.Size = new System.Drawing.Size(150, 18);
            this.priority2.TabIndex = 22;
            this.priority2.Text = "Приоритетность: XX";
            this.priority2.Visible = false;
            // 
            // phone2
            // 
            this.phone2.AutoSize = true;
            this.phone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone2.Location = new System.Drawing.Point(364, 227);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(110, 18);
            this.phone2.TabIndex = 21;
            this.phone2.Text = "+x xxx xxx xx xx";
            this.phone2.Visible = false;
            // 
            // sells2
            // 
            this.sells2.AutoSize = true;
            this.sells2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sells2.Location = new System.Drawing.Point(364, 209);
            this.sells2.Name = "sells2";
            this.sells2.Size = new System.Drawing.Size(133, 18);
            this.sells2.TabIndex = 20;
            this.sells2.Text = "XX продаж за год";
            this.sells2.Visible = false;
            // 
            // agentImage2
            // 
            this.agentImage2.Location = new System.Drawing.Point(231, 177);
            this.agentImage2.Name = "agentImage2";
            this.agentImage2.Size = new System.Drawing.Size(126, 100);
            this.agentImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agentImage2.TabIndex = 18;
            this.agentImage2.TabStop = false;
            this.agentImage2.Visible = false;
            // 
            // nameAgent2
            // 
            this.nameAgent2.AutoSize = true;
            this.nameAgent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAgent2.Location = new System.Drawing.Point(363, 185);
            this.nameAgent2.Name = "nameAgent2";
            this.nameAgent2.Size = new System.Drawing.Size(373, 24);
            this.nameAgent2.TabIndex = 19;
            this.nameAgent2.Text = "Тип | Наимеппнааааааование агента";
            this.nameAgent2.Visible = false;
            // 
            // percent3
            // 
            this.percent3.AutoSize = true;
            this.percent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.percent3.Location = new System.Drawing.Point(738, 325);
            this.percent3.Name = "percent3";
            this.percent3.Size = new System.Drawing.Size(59, 25);
            this.percent3.TabIndex = 30;
            this.percent3.Text = "XX%";
            this.percent3.Visible = false;
            // 
            // priority3
            // 
            this.priority3.AutoSize = true;
            this.priority3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority3.Location = new System.Drawing.Point(364, 351);
            this.priority3.Name = "priority3";
            this.priority3.Size = new System.Drawing.Size(150, 18);
            this.priority3.TabIndex = 29;
            this.priority3.Text = "Приоритетность: XX";
            this.priority3.Visible = false;
            // 
            // phone3
            // 
            this.phone3.AutoSize = true;
            this.phone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone3.Location = new System.Drawing.Point(364, 333);
            this.phone3.Name = "phone3";
            this.phone3.Size = new System.Drawing.Size(110, 18);
            this.phone3.TabIndex = 28;
            this.phone3.Text = "+x xxx xxx xx xx";
            this.phone3.Visible = false;
            // 
            // sells3
            // 
            this.sells3.AutoSize = true;
            this.sells3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sells3.Location = new System.Drawing.Point(364, 315);
            this.sells3.Name = "sells3";
            this.sells3.Size = new System.Drawing.Size(133, 18);
            this.sells3.TabIndex = 27;
            this.sells3.Text = "XX продаж за год";
            this.sells3.Visible = false;
            // 
            // agentImage3
            // 
            this.agentImage3.Location = new System.Drawing.Point(231, 283);
            this.agentImage3.Name = "agentImage3";
            this.agentImage3.Size = new System.Drawing.Size(126, 100);
            this.agentImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agentImage3.TabIndex = 25;
            this.agentImage3.TabStop = false;
            this.agentImage3.Visible = false;
            // 
            // nameAgent3
            // 
            this.nameAgent3.AutoSize = true;
            this.nameAgent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAgent3.Location = new System.Drawing.Point(363, 291);
            this.nameAgent3.Name = "nameAgent3";
            this.nameAgent3.Size = new System.Drawing.Size(283, 24);
            this.nameAgent3.TabIndex = 26;
            this.nameAgent3.Text = "Тип | Наименование агента";
            this.nameAgent3.Visible = false;
            // 
            // percent4
            // 
            this.percent4.AutoSize = true;
            this.percent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.percent4.Location = new System.Drawing.Point(738, 431);
            this.percent4.Name = "percent4";
            this.percent4.Size = new System.Drawing.Size(59, 25);
            this.percent4.TabIndex = 37;
            this.percent4.Text = "XX%";
            this.percent4.Visible = false;
            // 
            // priority4
            // 
            this.priority4.AutoSize = true;
            this.priority4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority4.Location = new System.Drawing.Point(364, 457);
            this.priority4.Name = "priority4";
            this.priority4.Size = new System.Drawing.Size(150, 18);
            this.priority4.TabIndex = 36;
            this.priority4.Text = "Приоритетность: XX";
            this.priority4.Visible = false;
            // 
            // phone4
            // 
            this.phone4.AutoSize = true;
            this.phone4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone4.Location = new System.Drawing.Point(364, 439);
            this.phone4.Name = "phone4";
            this.phone4.Size = new System.Drawing.Size(110, 18);
            this.phone4.TabIndex = 35;
            this.phone4.Text = "+x xxx xxx xx xx";
            this.phone4.Visible = false;
            // 
            // sells4
            // 
            this.sells4.AutoSize = true;
            this.sells4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sells4.Location = new System.Drawing.Point(364, 421);
            this.sells4.Name = "sells4";
            this.sells4.Size = new System.Drawing.Size(133, 18);
            this.sells4.TabIndex = 34;
            this.sells4.Text = "XX продаж за год";
            this.sells4.Visible = false;
            // 
            // agentImage4
            // 
            this.agentImage4.Location = new System.Drawing.Point(231, 389);
            this.agentImage4.Name = "agentImage4";
            this.agentImage4.Size = new System.Drawing.Size(126, 100);
            this.agentImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agentImage4.TabIndex = 32;
            this.agentImage4.TabStop = false;
            this.agentImage4.Visible = false;
            // 
            // nameAgent4
            // 
            this.nameAgent4.AutoSize = true;
            this.nameAgent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAgent4.Location = new System.Drawing.Point(363, 397);
            this.nameAgent4.Name = "nameAgent4";
            this.nameAgent4.Size = new System.Drawing.Size(283, 24);
            this.nameAgent4.TabIndex = 33;
            this.nameAgent4.Text = "Тип | Наименование агента";
            this.nameAgent4.Visible = false;
            // 
            // percent5
            // 
            this.percent5.AutoSize = true;
            this.percent5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.percent5.Location = new System.Drawing.Point(738, 537);
            this.percent5.Name = "percent5";
            this.percent5.Size = new System.Drawing.Size(59, 25);
            this.percent5.TabIndex = 44;
            this.percent5.Text = "XX%";
            this.percent5.Visible = false;
            // 
            // priority5
            // 
            this.priority5.AutoSize = true;
            this.priority5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority5.Location = new System.Drawing.Point(364, 563);
            this.priority5.Name = "priority5";
            this.priority5.Size = new System.Drawing.Size(150, 18);
            this.priority5.TabIndex = 43;
            this.priority5.Text = "Приоритетность: XX";
            this.priority5.Visible = false;
            // 
            // phone5
            // 
            this.phone5.AutoSize = true;
            this.phone5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone5.Location = new System.Drawing.Point(364, 545);
            this.phone5.Name = "phone5";
            this.phone5.Size = new System.Drawing.Size(110, 18);
            this.phone5.TabIndex = 42;
            this.phone5.Text = "+x xxx xxx xx xx";
            this.phone5.Visible = false;
            // 
            // sells5
            // 
            this.sells5.AutoSize = true;
            this.sells5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sells5.Location = new System.Drawing.Point(364, 527);
            this.sells5.Name = "sells5";
            this.sells5.Size = new System.Drawing.Size(133, 18);
            this.sells5.TabIndex = 41;
            this.sells5.Text = "XX продаж за год";
            this.sells5.Visible = false;
            // 
            // agentImage5
            // 
            this.agentImage5.Location = new System.Drawing.Point(231, 495);
            this.agentImage5.Name = "agentImage5";
            this.agentImage5.Size = new System.Drawing.Size(126, 100);
            this.agentImage5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agentImage5.TabIndex = 39;
            this.agentImage5.TabStop = false;
            this.agentImage5.Visible = false;
            // 
            // nameAgent5
            // 
            this.nameAgent5.AutoSize = true;
            this.nameAgent5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAgent5.Location = new System.Drawing.Point(363, 503);
            this.nameAgent5.Name = "nameAgent5";
            this.nameAgent5.Size = new System.Drawing.Size(283, 24);
            this.nameAgent5.TabIndex = 40;
            this.nameAgent5.Text = "Тип | Наименование агента";
            this.nameAgent5.Visible = false;
            // 
            // GoToClearSearch
            // 
            this.GoToClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToClearSearch.Location = new System.Drawing.Point(283, 14);
            this.GoToClearSearch.Name = "GoToClearSearch";
            this.GoToClearSearch.Size = new System.Drawing.Size(30, 30);
            this.GoToClearSearch.TabIndex = 46;
            this.GoToClearSearch.Text = "❌";
            this.GoToClearSearch.UseVisualStyleBackColor = true;
            this.GoToClearSearch.Click += new System.EventHandler(this.GoToClearSearch_Click);
            // 
            // GoOpenList3
            // 
            this.GoOpenList3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenList3.Location = new System.Drawing.Point(483, 622);
            this.GoOpenList3.Name = "GoOpenList3";
            this.GoOpenList3.Size = new System.Drawing.Size(40, 40);
            this.GoOpenList3.TabIndex = 47;
            this.GoOpenList3.Text = "3";
            this.GoOpenList3.UseVisualStyleBackColor = true;
            this.GoOpenList3.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenList4
            // 
            this.GoOpenList4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenList4.Location = new System.Drawing.Point(529, 622);
            this.GoOpenList4.Name = "GoOpenList4";
            this.GoOpenList4.Size = new System.Drawing.Size(40, 40);
            this.GoOpenList4.TabIndex = 48;
            this.GoOpenList4.Text = "4";
            this.GoOpenList4.UseVisualStyleBackColor = true;
            this.GoOpenList4.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenList5
            // 
            this.GoOpenList5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenList5.Location = new System.Drawing.Point(575, 622);
            this.GoOpenList5.Name = "GoOpenList5";
            this.GoOpenList5.Size = new System.Drawing.Size(40, 40);
            this.GoOpenList5.TabIndex = 49;
            this.GoOpenList5.Text = "5";
            this.GoOpenList5.UseVisualStyleBackColor = true;
            this.GoOpenList5.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenList2
            // 
            this.GoOpenList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenList2.Location = new System.Drawing.Point(437, 622);
            this.GoOpenList2.Name = "GoOpenList2";
            this.GoOpenList2.Size = new System.Drawing.Size(40, 40);
            this.GoOpenList2.TabIndex = 50;
            this.GoOpenList2.Text = "2";
            this.GoOpenList2.UseVisualStyleBackColor = true;
            this.GoOpenList2.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenList1
            // 
            this.GoOpenList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenList1.Location = new System.Drawing.Point(391, 622);
            this.GoOpenList1.Name = "GoOpenList1";
            this.GoOpenList1.Size = new System.Drawing.Size(40, 40);
            this.GoOpenList1.TabIndex = 51;
            this.GoOpenList1.Text = "1";
            this.GoOpenList1.UseVisualStyleBackColor = true;
            this.GoOpenList1.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenBack
            // 
            this.GoOpenBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenBack.Location = new System.Drawing.Point(345, 622);
            this.GoOpenBack.Name = "GoOpenBack";
            this.GoOpenBack.Size = new System.Drawing.Size(40, 40);
            this.GoOpenBack.TabIndex = 52;
            this.GoOpenBack.Text = "<";
            this.GoOpenBack.UseVisualStyleBackColor = true;
            this.GoOpenBack.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenNext
            // 
            this.GoOpenNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenNext.Location = new System.Drawing.Point(621, 622);
            this.GoOpenNext.Name = "GoOpenNext";
            this.GoOpenNext.Size = new System.Drawing.Size(40, 40);
            this.GoOpenNext.TabIndex = 53;
            this.GoOpenNext.Text = ">";
            this.GoOpenNext.UseVisualStyleBackColor = true;
            this.GoOpenNext.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenEnd
            // 
            this.GoOpenEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenEnd.Location = new System.Drawing.Point(667, 622);
            this.GoOpenEnd.Name = "GoOpenEnd";
            this.GoOpenEnd.Size = new System.Drawing.Size(40, 40);
            this.GoOpenEnd.TabIndex = 54;
            this.GoOpenEnd.Text = ">>";
            this.GoOpenEnd.UseVisualStyleBackColor = true;
            this.GoOpenEnd.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // GoOpenStart
            // 
            this.GoOpenStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOpenStart.Location = new System.Drawing.Point(299, 622);
            this.GoOpenStart.Name = "GoOpenStart";
            this.GoOpenStart.Size = new System.Drawing.Size(40, 40);
            this.GoOpenStart.TabIndex = 55;
            this.GoOpenStart.Text = "<<";
            this.GoOpenStart.UseVisualStyleBackColor = true;
            this.GoOpenStart.Click += new System.EventHandler(this.UpdateOpener);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(197, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // GoToAddNewAgent
            // 
            this.GoToAddNewAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToAddNewAgent.Location = new System.Drawing.Point(3, 14);
            this.GoToAddNewAgent.Name = "GoToAddNewAgent";
            this.GoToAddNewAgent.Size = new System.Drawing.Size(140, 60);
            this.GoToAddNewAgent.TabIndex = 62;
            this.GoToAddNewAgent.Text = "Добавить агента";
            this.GoToAddNewAgent.UseVisualStyleBackColor = true;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.GoToEditAgent);
            this.leftPanel.Controls.Add(this.GoToDeleteAgent);
            this.leftPanel.Controls.Add(this.GoToAddNewAgent);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(146, 679);
            this.leftPanel.TabIndex = 63;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 39);
            this.button3.TabIndex = 65;
            this.button3.Text = "Заказы";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GoToEditAgent
            // 
            this.GoToEditAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToEditAgent.Location = new System.Drawing.Point(3, 80);
            this.GoToEditAgent.Name = "GoToEditAgent";
            this.GoToEditAgent.Size = new System.Drawing.Size(140, 60);
            this.GoToEditAgent.TabIndex = 64;
            this.GoToEditAgent.Text = "Редактировать агента";
            this.GoToEditAgent.UseVisualStyleBackColor = true;
            // 
            // GoToDeleteAgent
            // 
            this.GoToDeleteAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToDeleteAgent.Location = new System.Drawing.Point(3, 146);
            this.GoToDeleteAgent.Name = "GoToDeleteAgent";
            this.GoToDeleteAgent.Size = new System.Drawing.Size(140, 60);
            this.GoToDeleteAgent.TabIndex = 63;
            this.GoToDeleteAgent.Text = "Удалить агента";
            this.GoToDeleteAgent.UseVisualStyleBackColor = true;
            this.GoToDeleteAgent.Click += new System.EventHandler(this.GoToDeleteAgent_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Controls.Add(this.sortComboBox);
            this.topPanel.Controls.Add(this.GoToClearSearch);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(146, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(727, 56);
            this.topPanel.TabIndex = 64;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(197, 227);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(197, 325);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 66;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(197, 431);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 67;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.Location = new System.Drawing.Point(197, 537);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 68;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // infoAboutError
            // 
            this.infoAboutError.AutoSize = true;
            this.infoAboutError.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoAboutError.ForeColor = System.Drawing.SystemColors.Control;
            this.infoAboutError.Location = new System.Drawing.Point(202, 151);
            this.infoAboutError.Name = "infoAboutError";
            this.infoAboutError.Size = new System.Drawing.Size(605, 55);
            this.infoAboutError.TabIndex = 69;
            this.infoAboutError.Text = "Информация не найдена.";
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 679);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.GoOpenStart);
            this.Controls.Add(this.GoOpenList3);
            this.Controls.Add(this.GoOpenList4);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.GoOpenList5);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.GoOpenList2);
            this.Controls.Add(this.GoOpenList1);
            this.Controls.Add(this.GoOpenBack);
            this.Controls.Add(this.GoOpenNext);
            this.Controls.Add(this.GoOpenEnd);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.percent5);
            this.Controls.Add(this.priority5);
            this.Controls.Add(this.phone5);
            this.Controls.Add(this.sells5);
            this.Controls.Add(this.agentImage5);
            this.Controls.Add(this.nameAgent5);
            this.Controls.Add(this.percent4);
            this.Controls.Add(this.priority4);
            this.Controls.Add(this.phone4);
            this.Controls.Add(this.sells4);
            this.Controls.Add(this.agentImage4);
            this.Controls.Add(this.nameAgent4);
            this.Controls.Add(this.percent3);
            this.Controls.Add(this.priority3);
            this.Controls.Add(this.phone3);
            this.Controls.Add(this.sells3);
            this.Controls.Add(this.agentImage3);
            this.Controls.Add(this.nameAgent3);
            this.Controls.Add(this.percent2);
            this.Controls.Add(this.priority2);
            this.Controls.Add(this.phone2);
            this.Controls.Add(this.sells2);
            this.Controls.Add(this.agentImage2);
            this.Controls.Add(this.nameAgent2);
            this.Controls.Add(this.percent1);
            this.Controls.Add(this.priority1);
            this.Controls.Add(this.phone1);
            this.Controls.Add(this.sells1);
            this.Controls.Add(this.agentImage1);
            this.Controls.Add(this.nameAgent1);
            this.Controls.Add(this.infoAboutError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EyewearCompanyDesktopApp v0.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentImage5)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label percent1;
        private System.Windows.Forms.Label priority1;
        private System.Windows.Forms.Label phone1;
        private System.Windows.Forms.Label sells1;
        private System.Windows.Forms.PictureBox agentImage1;
        private System.Windows.Forms.Label nameAgent1;
        private System.Windows.Forms.Label percent2;
        private System.Windows.Forms.Label priority2;
        private System.Windows.Forms.Label phone2;
        private System.Windows.Forms.Label sells2;
        private System.Windows.Forms.PictureBox agentImage2;
        private System.Windows.Forms.Label nameAgent2;
        private System.Windows.Forms.Label percent3;
        private System.Windows.Forms.Label priority3;
        private System.Windows.Forms.Label phone3;
        private System.Windows.Forms.Label sells3;
        private System.Windows.Forms.PictureBox agentImage3;
        private System.Windows.Forms.Label nameAgent3;
        private System.Windows.Forms.Label percent4;
        private System.Windows.Forms.Label priority4;
        private System.Windows.Forms.Label phone4;
        private System.Windows.Forms.Label sells4;
        private System.Windows.Forms.PictureBox agentImage4;
        private System.Windows.Forms.Label nameAgent4;
        private System.Windows.Forms.Label percent5;
        private System.Windows.Forms.Label priority5;
        private System.Windows.Forms.Label phone5;
        private System.Windows.Forms.Label sells5;
        private System.Windows.Forms.PictureBox agentImage5;
        private System.Windows.Forms.Label nameAgent5;
        private System.Windows.Forms.Button GoToClearSearch;
        private System.Windows.Forms.Button GoOpenList3;
        private System.Windows.Forms.Button GoOpenList4;
        private System.Windows.Forms.Button GoOpenList5;
        private System.Windows.Forms.Button GoOpenList2;
        private System.Windows.Forms.Button GoOpenList1;
        private System.Windows.Forms.Button GoOpenBack;
        private System.Windows.Forms.Button GoOpenNext;
        private System.Windows.Forms.Button GoOpenEnd;
        private System.Windows.Forms.Button GoOpenStart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button GoToAddNewAgent;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GoToEditAgent;
        private System.Windows.Forms.Button GoToDeleteAgent;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label infoAboutError;
    }
}

