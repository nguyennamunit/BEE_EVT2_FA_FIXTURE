using BEE_EVT2_FA_FIXTURE.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BEE_EVT2_FA_FIXTURE
{
    public partial class Form1 : Form
    {
        public Form1()
        {///comman
            InitializeComponent();
            LoadDataFromJson();
         
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);

        }
      

        private void LoadDataFromJson()
        {
            string jsonFilePath = @"C:\Users\DUCPCB\source\repos\BEE_EVT2_FA_FIXTURE\BEE_EVT2_FA_FIXTURE\User.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            foreach (var item in users)
            {
                if (item.Value == "Name")
                {

                }
            } 
            dataGridView1.DataSource = users;

        }
        private void size()
        {

        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; 
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; 
            }
        }
    }
}
