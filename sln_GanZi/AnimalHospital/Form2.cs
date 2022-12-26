using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalHospital
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        Form1 frm1 = new Form1();
        public static string connStr = ""; //mysql 문 받음
        MySqlConnection conn;
        MySqlCommand cmd;

      
        public Form2()
        {
            InitializeComponent();
        }

        // MySQL 연결 체크
        public void ConnectCheck()
        {
            try { conn.Open(); }
            catch { conn.Close(); MessageBox.Show("MySQL 연결 실패"); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new MySqlConnection(connStr);
            ConnectCheck();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) from user where id='" + this.txtId.Text + "' and pw='" + this.txtPw.Text + "'", conn);

            DataTable newtable = new DataTable();
            sda.Fill(newtable);

                if (newtable.Rows[0][0].ToString() == "1")
                {
                    //로그인 성공인 경우
                    this.Hide(); //숨김처리
                    frm1.Show();
                }

                else
                {
                    //로그인 실패시
                    MessageBox.Show("아이디와 비밀번호를 확인해주세요");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
