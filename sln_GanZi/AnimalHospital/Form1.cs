using System.Collections;
using System.Globalization;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using System;
using System.Security.Cryptography;

namespace AnimalHospital
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        // 데이터베이스 연결
        MySqlConnection conn;
        MySqlCommand cmd;
        public string connStr = "Server = localhost;  Database = ganzi; Uid = root; Pwd = 0000; CharSet=utf8;";
        public string selectedlist;




        // 검색 델리게이트 생성
        private delegate void selectReDelegate();
        private selectReDelegate selectRe = null;

        public Form1()
        {
            InitializeComponent();
            Form2.connStr = connStr;
            Form3.connStr = connStr;
        }


        string orgStr = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            cbVaccine.SelectedIndex = 0;
            selectRe = new selectReDelegate(selectReceipt);
            Invoke(selectRe);

            cbCity.SelectedIndex = 0;
            cbBorough.SelectedIndex = 0;

        }



        // MySQL 연결 체크
        public void ConnectCheck()
        {
            try { conn.Open(); }
            catch { conn.Close(); MessageBox.Show("MySQL 연결 실패"); }
        }


        // 접수된 전체 강아지 목록 
        void selectReceipt()
        {
            try
            {
                conn = new MySqlConnection(connStr);    // MySQL 연결
                ConnectCheck();                         // MySQL 연결 체크
                lvView.Items.Clear();

                cmd = new MySqlCommand("select * from receipt", conn);
                MySqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                    listitem.SubItems.Add(dr["protector"].ToString());
                    listitem.SubItems.Add(dr["dog"].ToString());
                    listitem.SubItems.Add(dr["breed"].ToString());
                    listitem.SubItems.Add(dr["weight"].ToString());
                    listitem.SubItems.Add(dr["birth"].ToString());


                    lvView.Items.Add(listitem);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }




        // 등록 버튼 클릭 시 
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.txtProtector.Text != "" && this.txtDog.Text != "" && this.txtBreed.Text != "" && this.txtWeight.Text != "" && this.txtBirth.Text != "")
            {
                try
                {
                    conn = new MySqlConnection(connStr);
                    ConnectCheck();
                    string brith = this.txtBirth.Text;
                    DateTime currdate = DateTime.ParseExact(brith, "yyyyMMdd", CultureInfo.InvariantCulture);


                    string cmdStr = "insert into receipt(protector, dog, breed, weight, birth) values('" +
                                    txtProtector.Text + "', '" + txtDog.Text + "', '" + txtBreed.Text + "', '" + txtWeight.Text + "', '" + currdate.ToString().Substring(0, 11) + " '); ";

                    cmd = new MySqlCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();

                    Invoke(selectRe);
                    conn.Close();

                    this.txtProtector.Text = orgStr;
                    this.txtDog.Text = orgStr;
                    this.txtBreed.Text = orgStr;
                    this.txtWeight.Text = orgStr;
                    this.txtBirth.Text = orgStr;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            else
            {
                MessageBox.Show("값을 모두 입력하여 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtProtector.Focus();
            }

        }


        // 삭제버튼 클릭 시
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다.\r계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lvView.SelectedItems.Count > 0)
                {
                    try
                    {

                        conn = new MySqlConnection(connStr);    // MySQL 연결
                        ConnectCheck();                         // MySQL 연결 체크

                        int pos = lvView.SelectedItems[0].Index;
                        int index = Convert.ToInt32(lvView.Items[pos].Text);

                        string query = string.Format("DELETE FROM receipt WHERE code={0};", index);
                        cmd = new MySqlCommand(query, conn);


                        if (cmd.ExecuteNonQuery() != 1)
                            MessageBox.Show("데이터 삭제에 실패하였습니다.");

                        this.txtProtector.Text = orgStr;
                        this.txtDog.Text = orgStr;
                        this.txtBreed.Text = orgStr;
                        this.txtWeight.Text = orgStr;
                        this.txtBirth.Text = orgStr;

                        Invoke(selectRe);
                        MessageBox.Show("삭제되었습니다.", "알림", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                    MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 수정 버튼 클릭 시
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count > 0)
            {
                try
                {
                    conn = new MySqlConnection(connStr);    // MySQL 연결
                    ConnectCheck();                         // MySQL 연결 체크

                    int pos = lvView.SelectedItems[0].Index;
                    int index = Convert.ToInt32(lvView.Items[pos].Text);

                    string query = string.Format("update receipt set protector='{1}', dog='{2}', breed='{3}', weight='{4}', birth='{5}' WHERE code={0};",
                                                index, this.txtProtector.Text, this.txtDog.Text, this.txtBreed.Text, this.txtWeight.Text, this.txtBirth.Text);
                    cmd = new MySqlCommand(query, conn);


                    if (cmd.ExecuteNonQuery() != 1)
                        MessageBox.Show("데이터 수정에 실패하였습니다.");


                    this.txtProtector.Text = orgStr;
                    this.txtDog.Text = orgStr;
                    this.txtBreed.Text = orgStr;
                    this.txtWeight.Text = orgStr;
                    this.txtBirth.Text = orgStr;


                    Invoke(selectRe);
                    MessageBox.Show("수정되었습니다.", "알림", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        // 초기화 버튼 클릭 시 
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtProtector.Text = orgStr;
            this.txtDog.Text = orgStr;
            this.txtBreed.Text = orgStr;
            this.txtWeight.Text = orgStr;
            this.txtBirth.Text = orgStr;
        }


        // 접수 강아지명 검색 버튼 클릭 시
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSeProtector.Text != "")
            {
                try
                {
                    conn = new MySqlConnection(connStr);    // MySQL 연결
                    ConnectCheck();                         // MySQL 연결 체크
                    lvView.Items.Clear();

                    string searchDog = this.txtSearch.Text.ToString();

                    string query = string.Format("select * from receipt WHERE dog= '{0}' ;", searchDog);
                    cmd = new MySqlCommand(query, conn);


                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                        listitem.SubItems.Add(dr["protector"].ToString());
                        listitem.SubItems.Add(dr["dog"].ToString());
                        listitem.SubItems.Add(dr["breed"].ToString());
                        listitem.SubItems.Add(dr["weight"].ToString());
                        listitem.SubItems.Add(dr["birth"].ToString());

                        lvView.Items.Add(listitem);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                Invoke(selectRe);

        }

        // 접수 보호자명 검색 클릭 시
        private void btnSeProtector_Click(object sender, EventArgs e)
        {
            if (this.txtSeProtector.Text != "")
            {
                try
                {
                    conn = new MySqlConnection(connStr);    // MySQL 연결
                    ConnectCheck();                         // MySQL 연결 체크
                    lvView.Items.Clear();

                    string searchProtector = this.txtSeProtector.Text.ToString();

                    string query = string.Format("select * from receipt WHERE protector= '{0}' ;", searchProtector);
                    cmd = new MySqlCommand(query, conn);


                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                        listitem.SubItems.Add(dr["protector"].ToString());
                        listitem.SubItems.Add(dr["dog"].ToString());
                        listitem.SubItems.Add(dr["breed"].ToString());
                        listitem.SubItems.Add(dr["weight"].ToString());
                        listitem.SubItems.Add(dr["birth"].ToString());

                        lvView.Items.Add(listitem);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        // 접수 리스트박스 클릭 시 텍스트박스에 자동으로 들어가게
        private void lvView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            txtProtector.Text = listview.Items[index].SubItems[1].Text;
            txtDog.Text = listview.Items[index].SubItems[2].Text;
            txtBreed.Text = listview.Items[index].SubItems[3].Text;
            txtWeight.Text = listview.Items[index].SubItems[4].Text;
            txtBirth.Text = listview.Items[index].SubItems[5].Text;
        }



        // 진료 강아지명 검색버튼 클릭 시
        private void btntrSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);    // MySQL 연결
                ConnectCheck();                         // MySQL 연결 체크
                lvtrView.Items.Clear();

                string searchDogtr = this.txttrSearch.Text.ToString();

                string query = string.Format("select * from receipt WHERE dog= '{0}' ;", searchDogtr);
                cmd = new MySqlCommand(query, conn);


                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                    listitem.SubItems.Add(dr["protector"].ToString());
                    listitem.SubItems.Add(dr["dog"].ToString());
                    listitem.SubItems.Add(dr["breed"].ToString());
                    listitem.SubItems.Add(dr["weight"].ToString());
                    listitem.SubItems.Add(dr["birth"].ToString());

                    lvtrView.Items.Add(listitem);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        // 진료 보호자명 검색버튼 클릭 시
        private void btntrProtector_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);    // MySQL 연결
                ConnectCheck();                         // MySQL 연결 체크
                lvtrView.Items.Clear();

                string searchProtr = this.txttrProtector.Text.ToString();

                string query = string.Format("select * from receipt WHERE protector = '{0}' ;", searchProtr);
                cmd = new MySqlCommand(query, conn);


                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                    listitem.SubItems.Add(dr["protector"].ToString());
                    listitem.SubItems.Add(dr["dog"].ToString());
                    listitem.SubItems.Add(dr["breed"].ToString());
                    listitem.SubItems.Add(dr["weight"].ToString());
                    listitem.SubItems.Add(dr["birth"].ToString());

                    lvtrView.Items.Add(listitem);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        // 진료 리스트박스 클릭 시 텍스트박스에 자동으로 들어가게
        private void lvtrView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            txttrCode.Text = listview.Items[index].SubItems[0].Text;
            txttrDog.Text = listview.Items[index].SubItems[2].Text;
            txttrDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


            try
            {
                conn = new MySqlConnection(connStr);    // MySQL 연결
                ConnectCheck();                         // MySQL 연결 체크
                lvtrDetails.Items.Clear();

                string searchCode = this.txttrCode.Text.ToString();

                string query = string.Format("select * from treate WHERE code= '{0}' ;", searchCode);
                cmd = new MySqlCommand(query, conn);


                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                    listitem.SubItems.Add(dr["dog"].ToString());
                    listitem.SubItems.Add(dr["date"].ToString());
                    listitem.SubItems.Add(dr["symptom"].ToString());
                    listitem.SubItems.Add(dr["prescription"].ToString());
                    listitem.SubItems.Add(dr["vaccine"].ToString());

                    lvtrDetails.Items.Add(listitem);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }


        // 저장 버튼 클릭 시 
        private void btntrSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                ConnectCheck();


                string cmdStr = "insert into treate values('" +
                                txttrCode.Text + "', '" + txttrDog.Text + "', '" + txttrDate.Text + "', '" + txttrSymptom.Text + "', '" + txttrPrescription.Text + "', '" + cbVaccine.SelectedItem.ToString() + " '); ";

                cmd = new MySqlCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();


                lvtrDetails.Items.Clear();

                string searchCode = this.txttrCode.Text.ToString();
                string query = string.Format("select * from treate WHERE code= '{0}' ;", searchCode);

                cmd = new MySqlCommand(query, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem listitem = new ListViewItem(dr["code"].ToString());
                    listitem.SubItems.Add(dr["dog"].ToString());
                    listitem.SubItems.Add(dr["date"].ToString());
                    listitem.SubItems.Add(dr["symptom"].ToString());
                    listitem.SubItems.Add(dr["prescription"].ToString());
                    listitem.SubItems.Add(dr["vaccine"].ToString());

                    lvtrDetails.Items.Add(listitem);
                }

                this.txttrCode.Text = orgStr;
                this.txttrDate.Text = orgStr;
                this.txttrDog.Text = orgStr;
                this.txttrPrescription.Text = orgStr;
                this.txttrSymptom.Text = orgStr;
                this.cbVaccine.SelectedIndex = 0;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                ConnectCheck();


                string cmdStr = "select * from hospital where hos_add like  '% " + cbBorough.SelectedItem.ToString() + " %' ";
                cmd = new MySqlCommand(cmdStr, conn);
                cmd.ExecuteNonQuery();


                lvHospital.Items.Clear();

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem listitem = new ListViewItem(dr["hos_name"].ToString());
                    listitem.SubItems.Add(dr["hos_add"].ToString());
                    listitem.SubItems.Add(dr["hos_tel"].ToString());
                    listitem.SubItems.Add(dr["hos_details4"].ToString());
                    listitem.SubItems.Add(dr["hos_details5"].ToString());

                    lvHospital.Items.Add(listitem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
 
