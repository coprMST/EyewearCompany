
namespace EyewearCompany
{
    partial class EditAgents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAgents));
            this.GoToBack = new System.Windows.Forms.Button();
            this.GoToEditAgent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.FIOLabel1 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.nameCompanyLabel1 = new System.Windows.Forms.Label();
            this.nameCompany = new System.Windows.Forms.TextBox();
            this.agentLabel1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.KPP = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.INN)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToBack
            // 
            this.GoToBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToBack.Location = new System.Drawing.Point(200, 600);
            this.GoToBack.Name = "GoToBack";
            this.GoToBack.Size = new System.Drawing.Size(110, 60);
            this.GoToBack.TabIndex = 79;
            this.GoToBack.Text = "Вернуться назад";
            this.GoToBack.UseVisualStyleBackColor = true;
            this.GoToBack.Click += new System.EventHandler(this.GoToBack_Click);
            // 
            // GoToEditAgent
            // 
            this.GoToEditAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToEditAgent.Location = new System.Drawing.Point(6, 600);
            this.GoToEditAgent.Name = "GoToEditAgent";
            this.GoToEditAgent.Size = new System.Drawing.Size(188, 60);
            this.GoToEditAgent.TabIndex = 78;
            this.GoToEditAgent.Text = "Изменить агента";
            this.GoToEditAgent.UseVisualStyleBackColor = true;
            this.GoToEditAgent.Click += new System.EventHandler(this.GoToEditAgent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(54, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 158;
            this.label9.Text = "Ссылка на логотип";
            // 
            // logo
            // 
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.Location = new System.Drawing.Point(37, 353);
            this.logo.MaxLength = 100;
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(236, 26);
            this.logo.TabIndex = 157;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(54, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 156;
            this.label8.Text = "Электронная почта";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(37, 303);
            this.email.MaxLength = 255;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(236, 26);
            this.email.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(54, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 154;
            this.label7.Text = "Номер телефона*";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(37, 253);
            this.phone.MaxLength = 20;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(236, 26);
            this.phone.TabIndex = 153;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // FIOLabel1
            // 
            this.FIOLabel1.AutoSize = true;
            this.FIOLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel1.Location = new System.Drawing.Point(54, 182);
            this.FIOLabel1.Name = "FIOLabel1";
            this.FIOLabel1.Size = new System.Drawing.Size(121, 18);
            this.FIOLabel1.TabIndex = 152;
            this.FIOLabel1.Text = "ФИО директора";
            // 
            // FIO
            // 
            this.FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(37, 203);
            this.FIO.MaxLength = 100;
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(236, 26);
            this.FIO.TabIndex = 151;
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel1.Location = new System.Drawing.Point(54, 132);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(149, 18);
            this.addressLabel1.TabIndex = 150;
            this.addressLabel1.Text = "Юридический адрес";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(37, 153);
            this.address.MaxLength = 300;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(236, 26);
            this.address.TabIndex = 149;
            // 
            // nameCompanyLabel1
            // 
            this.nameCompanyLabel1.AutoSize = true;
            this.nameCompanyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompanyLabel1.Location = new System.Drawing.Point(54, 77);
            this.nameCompanyLabel1.Name = "nameCompanyLabel1";
            this.nameCompanyLabel1.Size = new System.Drawing.Size(153, 18);
            this.nameCompanyLabel1.TabIndex = 148;
            this.nameCompanyLabel1.Text = "Название компании*";
            // 
            // nameCompany
            // 
            this.nameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompany.Location = new System.Drawing.Point(37, 98);
            this.nameCompany.MaxLength = 150;
            this.nameCompany.Name = "nameCompany";
            this.nameCompany.Size = new System.Drawing.Size(236, 26);
            this.nameCompany.TabIndex = 147;
            // 
            // agentLabel1
            // 
            this.agentLabel1.AutoSize = true;
            this.agentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentLabel1.Location = new System.Drawing.Point(54, 23);
            this.agentLabel1.Name = "agentLabel1";
            this.agentLabel1.Size = new System.Drawing.Size(88, 18);
            this.agentLabel1.TabIndex = 160;
            this.agentLabel1.Text = "Тип агента*";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 28);
            this.comboBox1.TabIndex = 159;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 162;
            this.label4.Text = "ИНН*";
            // 
            // INN
            // 
            this.INN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INN.Location = new System.Drawing.Point(37, 404);
            this.INN.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.INN.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(235, 26);
            this.INN.TabIndex = 163;
            this.INN.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(54, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 164;
            this.label6.Text = "КПП";
            // 
            // KPP
            // 
            this.KPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KPP.Location = new System.Drawing.Point(37, 454);
            this.KPP.MaxLength = 9;
            this.KPP.Name = "KPP";
            this.KPP.Size = new System.Drawing.Size(236, 26);
            this.KPP.TabIndex = 165;
            this.KPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KPP_KeyPress);
            // 
            // priority
            // 
            this.priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority.Location = new System.Drawing.Point(37, 504);
            this.priority.MaxLength = 10;
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(236, 26);
            this.priority.TabIndex = 167;
            this.priority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KPP_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(54, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 166;
            this.label10.Text = "Приоритет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 168;
            this.label1.Text = "* - обязательные для\r\n         заполения поля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.KPP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agentLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.FIOLabel1);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.addressLabel1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.nameCompanyLabel1);
            this.Controls.Add(this.nameCompany);
            this.Controls.Add(this.GoToBack);
            this.Controls.Add(this.GoToEditAgent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение агентов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditAgents_FormClosed);
            this.Load += new System.EventHandler(this.EditAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToBack;
        private System.Windows.Forms.Button GoToEditAgent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox logo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label FIOLabel1;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label nameCompanyLabel1;
        private System.Windows.Forms.TextBox nameCompany;
        private System.Windows.Forms.Label agentLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown INN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KPP;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}