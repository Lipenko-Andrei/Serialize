using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            tb_Name.Text = string.Empty;
            tb_Surename.Text = string.Empty;
            numericUpDown_Age.Value = 0;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            User user = new User(tb_Name.Text,tb_Surename.Text, (int)numericUpDown_Age.Value);
            ListViewItem LVI = new ListViewItem(user.UserName+" "+ user.UserSurname);
            LVI.Tag = user;
            listView1.Items.Add(LVI);
            ClearInput();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                User user = (User)listView1.SelectedItems[0].Tag;
                if(user!= null)
                {
                    tb_Name.Text = user.UserName;
                    tb_Surename.Text = user.UserSurname;
                    numericUpDown_Age.Value = user.Age;
                }
            }
             else if (listView1.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }
        private void SerialiazeXML(Users users)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Users));
            using(FileStream fs = new FileStream("User.txt",FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, users);
            }
            
        }
        
        private void bt_Serialization_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            foreach (ListViewItem item in listView1.Items)
            {
                if(item.Tag != null)
                {
                    users.UserList.Add((User)item.Tag);
                }
            }
               SerialiazeXML(users);
        }

        
    }
}
