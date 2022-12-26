using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AnimalHospital
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {

        Form1 frm1 = new Form1();
        public static string connStr = ""; //mysql 문 받음
        MySqlConnection conn;
        MySqlCommand cmd;
        string orgStr = "";

        public Form3()
        {
            InitializeComponent();
        }


        // MySQL 연결 체크
        public void ConnectCheck()
        {
            try { conn.Open(); }
            catch { conn.Close(); MessageBox.Show("MySQL 연결 실패"); }
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {
            string txtId = this.txtId.Text;
            string txtName = this.txtName.Text;
            string txtPw = this.txtPw.Text;
            string txtPwCheck = this.txtPwCheck.Text;
            string txtCode = this.txtCode.Text;


            if (txtId == "" || txtName == "" || txtPw == "" || txtPwCheck == "")
            {
                MessageBox.Show("항목을 모두 입력해주세용", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtId.Equals(txtPw))
            {
                MessageBox.Show("ID와 PW는 동일할 수 없습니당.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPw != txtPwCheck)
            {
                MessageBox.Show("PW와 PW확인이 일치하지 않습니당.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtCode != "ganzi")
            {
                MessageBox.Show("인증문자가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // 회원가입
                try
                {
                    conn = new MySqlConnection(connStr);
                    ConnectCheck();


                    string cmdStr = "insert into user values('" +
                                    txtId + "', '" + txtPw + "', '" + txtName + " '); ";

                    cmd = new MySqlCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    txtId = orgStr;
                    txtPw = orgStr;
                    txtPwCheck = orgStr;
                    txtName = orgStr;

                    MessageBox.Show("회원가입에 성공하였습니다.", "알림", MessageBoxButtons.OK);
                    this.Hide(); //숨김처리

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            } 
        }

            
    }

 }
