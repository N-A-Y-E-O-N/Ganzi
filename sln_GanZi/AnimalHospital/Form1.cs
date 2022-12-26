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

        // �����ͺ��̽� ����
        MySqlConnection conn;
        MySqlCommand cmd;
        public string connStr = "Server = localhost;  Database = ganzi; Uid = root; Pwd = 0000; CharSet=utf8;";
        public string selectedlist;




        // �˻� ��������Ʈ ����
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



        // MySQL ���� üũ
        public void ConnectCheck()
        {
            try { conn.Open(); }
            catch { conn.Close(); MessageBox.Show("MySQL ���� ����"); }
        }


        // ������ ��ü ������ ��� 
        void selectReceipt()
        {
            try
            {
                conn = new MySqlConnection(connStr);    // MySQL ����
                ConnectCheck();                         // MySQL ���� üũ
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




        // ��� ��ư Ŭ�� �� 
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
                MessageBox.Show("���� ��� �Է��Ͽ� �ּ���", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtProtector.Focus();
            }

        }


        // ������ư Ŭ�� ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�����Ͻ� �׸��� ���� �˴ϴ�.\r��� �Ͻðڽ��ϱ�?", "�׸� ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lvView.SelectedItems.Count > 0)
                {
                    try
                    {

                        conn = new MySqlConnection(connStr);    // MySQL ����
                        ConnectCheck();                         // MySQL ���� üũ

                        int pos = lvView.SelectedItems[0].Index;
                        int index = Convert.ToInt32(lvView.Items[pos].Text);

                        string query = string.Format("DELETE FROM receipt WHERE code={0};", index);
                        cmd = new MySqlCommand(query, conn);


                        if (cmd.ExecuteNonQuery() != 1)
                            MessageBox.Show("������ ������ �����Ͽ����ϴ�.");

                        this.txtProtector.Text = orgStr;
                        this.txtDog.Text = orgStr;
                        this.txtBreed.Text = orgStr;
                        this.txtWeight.Text = orgStr;
                        this.txtBirth.Text = orgStr;

                        Invoke(selectRe);
                        MessageBox.Show("�����Ǿ����ϴ�.", "�˸�", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                    MessageBox.Show("���õ� �׸��� �����ϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ���� ��ư Ŭ�� ��
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count > 0)
            {
                try
                {
                    conn = new MySqlConnection(connStr);    // MySQL ����
                    ConnectCheck();                         // MySQL ���� üũ

                    int pos = lvView.SelectedItems[0].Index;
                    int index = Convert.ToInt32(lvView.Items[pos].Text);

                    string query = string.Format("update receipt set protector='{1}', dog='{2}', breed='{3}', weight='{4}', birth='{5}' WHERE code={0};",
                                                index, this.txtProtector.Text, this.txtDog.Text, this.txtBreed.Text, this.txtWeight.Text, this.txtBirth.Text);
                    cmd = new MySqlCommand(query, conn);


                    if (cmd.ExecuteNonQuery() != 1)
                        MessageBox.Show("������ ������ �����Ͽ����ϴ�.");


                    this.txtProtector.Text = orgStr;
                    this.txtDog.Text = orgStr;
                    this.txtBreed.Text = orgStr;
                    this.txtWeight.Text = orgStr;
                    this.txtBirth.Text = orgStr;


                    Invoke(selectRe);
                    MessageBox.Show("�����Ǿ����ϴ�.", "�˸�", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("���õ� �׸��� �����ϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        // �ʱ�ȭ ��ư Ŭ�� �� 
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtProtector.Text = orgStr;
            this.txtDog.Text = orgStr;
            this.txtBreed.Text = orgStr;
            this.txtWeight.Text = orgStr;
            this.txtBirth.Text = orgStr;
        }


        // ���� �������� �˻� ��ư Ŭ�� ��
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSeProtector.Text != "")
            {
                try
                {
                    conn = new MySqlConnection(connStr);    // MySQL ����
                    ConnectCheck();                         // MySQL ���� üũ
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

        // ���� ��ȣ�ڸ� �˻� Ŭ�� ��
        private void btnSeProtector_Click(object sender, EventArgs e)
        {
            if (this.txtSeProtector.Text != "")
            {
                try
                {
                    conn = new MySqlConnection(connStr);    // MySQL ����
                    ConnectCheck();                         // MySQL ���� üũ
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



        // ���� ����Ʈ�ڽ� Ŭ�� �� �ؽ�Ʈ�ڽ��� �ڵ����� ����
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



        // ���� �������� �˻���ư Ŭ�� ��
        private void btntrSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);    // MySQL ����
                ConnectCheck();                         // MySQL ���� üũ
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

        // ���� ��ȣ�ڸ� �˻���ư Ŭ�� ��
        private void btntrProtector_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);    // MySQL ����
                ConnectCheck();                         // MySQL ���� üũ
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



        // ���� ����Ʈ�ڽ� Ŭ�� �� �ؽ�Ʈ�ڽ��� �ڵ����� ����
        private void lvtrView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            txttrCode.Text = listview.Items[index].SubItems[0].Text;
            txttrDog.Text = listview.Items[index].SubItems[2].Text;
            txttrDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


            try
            {
                conn = new MySqlConnection(connStr);    // MySQL ����
                ConnectCheck();                         // MySQL ���� üũ
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


        // ���� ��ư Ŭ�� �� 
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
 
