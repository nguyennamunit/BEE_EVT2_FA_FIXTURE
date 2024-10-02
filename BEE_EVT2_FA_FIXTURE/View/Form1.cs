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
        {
            InitializeComponent();
            LoadDataFromJson();
            SetColumnSizes();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);

        }
        private void SetColumnSizes()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Width=50;           
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;   
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;       
         
            }
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 13);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                users[i].ID = i+1;
            }
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
