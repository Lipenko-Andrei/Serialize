
namespace Serialize
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Users = new System.Windows.Forms.Label();
            this.bt_Serialization = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Age = new System.Windows.Forms.Label();
            this.lb_Surname = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.tb_Surename = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.numericUpDown_Age = new System.Windows.Forms.NumericUpDown();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(221, 413);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Location = new System.Drawing.Point(12, 9);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(34, 13);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            // 
            // bt_Serialization
            // 
            this.bt_Serialization.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_Serialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Serialization.Location = new System.Drawing.Point(590, 415);
            this.bt_Serialization.Name = "bt_Serialization";
            this.bt_Serialization.Size = new System.Drawing.Size(75, 23);
            this.bt_Serialization.TabIndex = 2;
            this.bt_Serialization.Text = "Serialization";
            this.bt_Serialization.UseVisualStyleBackColor = false;
            this.bt_Serialization.Click += new System.EventHandler(this.bt_Serialization_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Age);
            this.panel1.Controls.Add(this.lb_Surname);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.tb_Surename);
            this.panel1.Controls.Add(this.bt_Add);
            this.panel1.Controls.Add(this.numericUpDown_Age);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Location = new System.Drawing.Point(229, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 384);
            this.panel1.TabIndex = 3;
            // 
            // lb_Age
            // 
            this.lb_Age.AutoSize = true;
            this.lb_Age.Location = new System.Drawing.Point(21, 122);
            this.lb_Age.Name = "lb_Age";
            this.lb_Age.Size = new System.Drawing.Size(26, 13);
            this.lb_Age.TabIndex = 6;
            this.lb_Age.Text = "Age";
            // 
            // lb_Surname
            // 
            this.lb_Surname.AutoSize = true;
            this.lb_Surname.Location = new System.Drawing.Point(21, 71);
            this.lb_Surname.Name = "lb_Surname";
            this.lb_Surname.Size = new System.Drawing.Size(55, 13);
            this.lb_Surname.TabIndex = 5;
            this.lb_Surname.Text = "Surename";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(21, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            // 
            // tb_Surename
            // 
            this.tb_Surename.Location = new System.Drawing.Point(18, 87);
            this.tb_Surename.Name = "tb_Surename";
            this.tb_Surename.Size = new System.Drawing.Size(382, 20);
            this.tb_Surename.TabIndex = 3;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.SystemColors.Info;
            this.bt_Add.Location = new System.Drawing.Point(316, 181);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(83, 31);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // numericUpDown_Age
            // 
            this.numericUpDown_Age.Location = new System.Drawing.Point(17, 138);
            this.numericUpDown_Age.Name = "numericUpDown_Age";
            this.numericUpDown_Age.Size = new System.Drawing.Size(383, 20);
            this.numericUpDown_Age.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(17, 39);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(384, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Serialization);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.listView1);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.Button bt_Serialization;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Age;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_Surename;
        private System.Windows.Forms.Label lb_Age;
        private System.Windows.Forms.Label lb_Surname;
        private System.Windows.Forms.Label Name;
    }
}

