namespace AnimalHospital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tbReceipt = new System.Windows.Forms.TabPage();
            this.txtSeProtector = new System.Windows.Forms.TextBox();
            this.lblSeProtector = new System.Windows.Forms.Label();
            this.btnSeProtector = new System.Windows.Forms.Button();
            this.lvView = new System.Windows.Forms.ListView();
            this.chCode = new System.Windows.Forms.ColumnHeader();
            this.chProtect = new System.Windows.Forms.ColumnHeader();
            this.chDog = new System.Windows.Forms.ColumnHeader();
            this.chBreed = new System.Windows.Forms.ColumnHeader();
            this.chWeight = new System.Windows.Forms.ColumnHeader();
            this.chBirth = new System.Windows.Forms.ColumnHeader();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtDog = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtProtector = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblDog = new System.Windows.Forms.Label();
            this.lblProtector = new System.Windows.Forms.Label();
            this.tbTreat = new System.Windows.Forms.TabPage();
            this.btntrProtector = new System.Windows.Forms.Button();
            this.txttrProtector = new System.Windows.Forms.TextBox();
            this.lbltrProtector = new System.Windows.Forms.Label();
            this.cbVaccine = new System.Windows.Forms.ComboBox();
            this.lblVac = new System.Windows.Forms.Label();
            this.txttrPrescription = new System.Windows.Forms.TextBox();
            this.txttrCode = new System.Windows.Forms.TextBox();
            this.txttrDog = new System.Windows.Forms.TextBox();
            this.txttrSymptom = new System.Windows.Forms.TextBox();
            this.txttrDate = new System.Windows.Forms.TextBox();
            this.txttrSearch = new System.Windows.Forms.TextBox();
            this.btntrSave = new System.Windows.Forms.Button();
            this.btntrSearch = new System.Windows.Forms.Button();
            this.lvtrDetails = new System.Windows.Forms.ListView();
            this.chtr2Code = new System.Windows.Forms.ColumnHeader();
            this.chtr2Dog = new System.Windows.Forms.ColumnHeader();
            this.chtr2Date = new System.Windows.Forms.ColumnHeader();
            this.chtr2Symptom = new System.Windows.Forms.ColumnHeader();
            this.chtr2Prescription = new System.Windows.Forms.ColumnHeader();
            this.chtr2Vaccine = new System.Windows.Forms.ColumnHeader();
            this.lbtrSymptom = new System.Windows.Forms.Label();
            this.lbtrDog = new System.Windows.Forms.Label();
            this.lbtrDate = new System.Windows.Forms.Label();
            this.lbtrPrescription = new System.Windows.Forms.Label();
            this.lbtrCode = new System.Windows.Forms.Label();
            this.lbtrSearch = new System.Windows.Forms.Label();
            this.lvtrView = new System.Windows.Forms.ListView();
            this.chtrCode = new System.Windows.Forms.ColumnHeader();
            this.chtrProtect = new System.Windows.Forms.ColumnHeader();
            this.chtrDog = new System.Windows.Forms.ColumnHeader();
            this.chtrBreed = new System.Windows.Forms.ColumnHeader();
            this.chtrWeight = new System.Windows.Forms.ColumnHeader();
            this.chtrBirth = new System.Windows.Forms.ColumnHeader();
            this.tbHospital = new System.Windows.Forms.TabPage();
            this.lvHospital = new System.Windows.Forms.ListView();
            this.chHosName = new System.Windows.Forms.ColumnHeader();
            this.chHosAdd = new System.Windows.Forms.ColumnHeader();
            this.chHosTel = new System.Windows.Forms.ColumnHeader();
            this.chHosSurgery = new System.Windows.Forms.ColumnHeader();
            this.chHosRe = new System.Windows.Forms.ColumnHeader();
            this.btnHospital = new System.Windows.Forms.Button();
            this.cbBorough = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tbMenu.SuspendLayout();
            this.tbReceipt.SuspendLayout();
            this.tbTreat.SuspendLayout();
            this.tbHospital.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbReceipt);
            this.tbMenu.Controls.Add(this.tbTreat);
            this.tbMenu.Controls.Add(this.tbHospital);
            this.tbMenu.Location = new System.Drawing.Point(23, 63);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(935, 527);
            this.tbMenu.TabIndex = 2;
            // 
            // tbReceipt
            // 
            this.tbReceipt.Controls.Add(this.txtSeProtector);
            this.tbReceipt.Controls.Add(this.lblSeProtector);
            this.tbReceipt.Controls.Add(this.btnSeProtector);
            this.tbReceipt.Controls.Add(this.lvView);
            this.tbReceipt.Controls.Add(this.btnSearch);
            this.tbReceipt.Controls.Add(this.btnReset);
            this.tbReceipt.Controls.Add(this.btnEnter);
            this.tbReceipt.Controls.Add(this.btnUpdate);
            this.tbReceipt.Controls.Add(this.btnDelete);
            this.tbReceipt.Controls.Add(this.txtBirth);
            this.tbReceipt.Controls.Add(this.txtWeight);
            this.tbReceipt.Controls.Add(this.txtDog);
            this.tbReceipt.Controls.Add(this.txtSearch);
            this.tbReceipt.Controls.Add(this.txtBreed);
            this.tbReceipt.Controls.Add(this.txtProtector);
            this.tbReceipt.Controls.Add(this.lblSearch);
            this.tbReceipt.Controls.Add(this.lblBirth);
            this.tbReceipt.Controls.Add(this.lblWeight);
            this.tbReceipt.Controls.Add(this.lblBreed);
            this.tbReceipt.Controls.Add(this.lblDog);
            this.tbReceipt.Controls.Add(this.lblProtector);
            this.tbReceipt.Location = new System.Drawing.Point(4, 24);
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tbReceipt.Size = new System.Drawing.Size(927, 499);
            this.tbReceipt.TabIndex = 0;
            this.tbReceipt.Text = "접수";
            this.tbReceipt.UseVisualStyleBackColor = true;
            // 
            // txtSeProtector
            // 
            this.txtSeProtector.Location = new System.Drawing.Point(698, 187);
            this.txtSeProtector.Name = "txtSeProtector";
            this.txtSeProtector.Size = new System.Drawing.Size(112, 23);
            this.txtSeProtector.TabIndex = 22;
            // 
            // lblSeProtector
            // 
            this.lblSeProtector.AutoSize = true;
            this.lblSeProtector.Location = new System.Drawing.Point(637, 191);
            this.lblSeProtector.Name = "lblSeProtector";
            this.lblSeProtector.Size = new System.Drawing.Size(55, 15);
            this.lblSeProtector.TabIndex = 21;
            this.lblSeProtector.Text = "보호자명";
            // 
            // btnSeProtector
            // 
            this.btnSeProtector.Location = new System.Drawing.Point(816, 187);
            this.btnSeProtector.Name = "btnSeProtector";
            this.btnSeProtector.Size = new System.Drawing.Size(56, 23);
            this.btnSeProtector.TabIndex = 20;
            this.btnSeProtector.Text = "검색";
            this.btnSeProtector.UseVisualStyleBackColor = true;
            this.btnSeProtector.Click += new System.EventHandler(this.btnSeProtector_Click);
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCode,
            this.chProtect,
            this.chDog,
            this.chBreed,
            this.chWeight,
            this.chBirth});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.Location = new System.Drawing.Point(20, 216);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(858, 258);
            this.lvView.TabIndex = 19;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            this.lvView.SelectedIndexChanged += new System.EventHandler(this.lvView_SelectedIndexChanged);
            // 
            // chCode
            // 
            this.chCode.Text = "코드";
            this.chCode.Width = 100;
            // 
            // chProtect
            // 
            this.chProtect.Text = "보호자명";
            this.chProtect.Width = 120;
            // 
            // chDog
            // 
            this.chDog.Text = "강아지명";
            this.chDog.Width = 120;
            // 
            // chBreed
            // 
            this.chBreed.Text = "견종";
            this.chBreed.Width = 120;
            // 
            // chWeight
            // 
            this.chWeight.Text = "체중";
            this.chWeight.Width = 120;
            // 
            // chBirth
            // 
            this.chBirth.Text = "생년월일";
            this.chBirth.Width = 270;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(816, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(228, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(228, 17);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "등록";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(228, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(228, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(81, 149);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(126, 23);
            this.txtBirth.TabIndex = 13;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(81, 115);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(126, 23);
            this.txtWeight.TabIndex = 12;
            // 
            // txtDog
            // 
            this.txtDog.Location = new System.Drawing.Point(81, 48);
            this.txtDog.Name = "txtDog";
            this.txtDog.Size = new System.Drawing.Size(126, 23);
            this.txtDog.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(698, 153);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 23);
            this.txtSearch.TabIndex = 10;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(81, 82);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(126, 23);
            this.txtBreed.TabIndex = 9;
            // 
            // txtProtector
            // 
            this.txtProtector.Location = new System.Drawing.Point(81, 17);
            this.txtProtector.Name = "txtProtector";
            this.txtProtector.Size = new System.Drawing.Size(126, 23);
            this.txtProtector.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(637, 157);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 15);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "강아지명";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(20, 152);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(55, 15);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "생년월일";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 115);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(31, 15);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "체중";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(20, 85);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(31, 15);
            this.lblBreed.TabIndex = 2;
            this.lblBreed.Text = "견종";
            // 
            // lblDog
            // 
            this.lblDog.AutoSize = true;
            this.lblDog.Location = new System.Drawing.Point(20, 51);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(55, 15);
            this.lblDog.TabIndex = 1;
            this.lblDog.Text = "강아지명";
            // 
            // lblProtector
            // 
            this.lblProtector.AutoSize = true;
            this.lblProtector.Location = new System.Drawing.Point(20, 20);
            this.lblProtector.Name = "lblProtector";
            this.lblProtector.Size = new System.Drawing.Size(55, 15);
            this.lblProtector.TabIndex = 0;
            this.lblProtector.Text = "보호자명";
            // 
            // tbTreat
            // 
            this.tbTreat.Controls.Add(this.btntrProtector);
            this.tbTreat.Controls.Add(this.txttrProtector);
            this.tbTreat.Controls.Add(this.lbltrProtector);
            this.tbTreat.Controls.Add(this.cbVaccine);
            this.tbTreat.Controls.Add(this.lblVac);
            this.tbTreat.Controls.Add(this.txttrPrescription);
            this.tbTreat.Controls.Add(this.txttrCode);
            this.tbTreat.Controls.Add(this.txttrDog);
            this.tbTreat.Controls.Add(this.txttrSymptom);
            this.tbTreat.Controls.Add(this.txttrDate);
            this.tbTreat.Controls.Add(this.txttrSearch);
            this.tbTreat.Controls.Add(this.btntrSave);
            this.tbTreat.Controls.Add(this.btntrSearch);
            this.tbTreat.Controls.Add(this.lvtrDetails);
            this.tbTreat.Controls.Add(this.lbtrSymptom);
            this.tbTreat.Controls.Add(this.lbtrDog);
            this.tbTreat.Controls.Add(this.lbtrDate);
            this.tbTreat.Controls.Add(this.lbtrPrescription);
            this.tbTreat.Controls.Add(this.lbtrCode);
            this.tbTreat.Controls.Add(this.lbtrSearch);
            this.tbTreat.Controls.Add(this.lvtrView);
            this.tbTreat.Location = new System.Drawing.Point(4, 24);
            this.tbTreat.Name = "tbTreat";
            this.tbTreat.Padding = new System.Windows.Forms.Padding(3);
            this.tbTreat.Size = new System.Drawing.Size(958, 523);
            this.tbTreat.TabIndex = 1;
            this.tbTreat.Text = "진료";
            this.tbTreat.UseVisualStyleBackColor = true;
            // 
            // btntrProtector
            // 
            this.btntrProtector.Location = new System.Drawing.Point(828, 6);
            this.btntrProtector.Name = "btntrProtector";
            this.btntrProtector.Size = new System.Drawing.Size(50, 23);
            this.btntrProtector.TabIndex = 21;
            this.btntrProtector.Text = "검색";
            this.btntrProtector.UseVisualStyleBackColor = true;
            this.btntrProtector.Click += new System.EventHandler(this.btntrProtector_Click);
            // 
            // txttrProtector
            // 
            this.txttrProtector.Location = new System.Drawing.Point(696, 6);
            this.txttrProtector.Name = "txttrProtector";
            this.txttrProtector.Size = new System.Drawing.Size(126, 23);
            this.txttrProtector.TabIndex = 20;
            // 
            // lbltrProtector
            // 
            this.lbltrProtector.AutoSize = true;
            this.lbltrProtector.Location = new System.Drawing.Point(635, 9);
            this.lbltrProtector.Name = "lbltrProtector";
            this.lbltrProtector.Size = new System.Drawing.Size(55, 15);
            this.lbltrProtector.TabIndex = 19;
            this.lbltrProtector.Text = "보호자명";
            // 
            // cbVaccine
            // 
            this.cbVaccine.FormattingEnabled = true;
            this.cbVaccine.Items.AddRange(new object[] {
            "X",
            "혼합종합백신",
            "코로나 장염",
            "켄넬 코프",
            "광견병 ",
            "인플루엔자"});
            this.cbVaccine.Location = new System.Drawing.Point(55, 386);
            this.cbVaccine.Name = "cbVaccine";
            this.cbVaccine.Size = new System.Drawing.Size(217, 23);
            this.cbVaccine.TabIndex = 18;
            // 
            // lblVac
            // 
            this.lblVac.AutoSize = true;
            this.lblVac.Location = new System.Drawing.Point(18, 386);
            this.lblVac.Name = "lblVac";
            this.lblVac.Size = new System.Drawing.Size(31, 15);
            this.lblVac.TabIndex = 17;
            this.lblVac.Text = "접종";
            // 
            // txttrPrescription
            // 
            this.txttrPrescription.Location = new System.Drawing.Point(55, 295);
            this.txttrPrescription.Multiline = true;
            this.txttrPrescription.Name = "txttrPrescription";
            this.txttrPrescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttrPrescription.Size = new System.Drawing.Size(217, 68);
            this.txttrPrescription.TabIndex = 16;
            // 
            // txttrCode
            // 
            this.txttrCode.Location = new System.Drawing.Point(197, 151);
            this.txttrCode.Name = "txttrCode";
            this.txttrCode.ReadOnly = true;
            this.txttrCode.Size = new System.Drawing.Size(75, 23);
            this.txttrCode.TabIndex = 15;
            // 
            // txttrDog
            // 
            this.txttrDog.Location = new System.Drawing.Point(55, 151);
            this.txttrDog.Name = "txttrDog";
            this.txttrDog.ReadOnly = true;
            this.txttrDog.Size = new System.Drawing.Size(75, 23);
            this.txttrDog.TabIndex = 14;
            // 
            // txttrSymptom
            // 
            this.txttrSymptom.Location = new System.Drawing.Point(55, 217);
            this.txttrSymptom.Multiline = true;
            this.txttrSymptom.Name = "txttrSymptom";
            this.txttrSymptom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttrSymptom.Size = new System.Drawing.Size(217, 68);
            this.txttrSymptom.TabIndex = 13;
            // 
            // txttrDate
            // 
            this.txttrDate.Location = new System.Drawing.Point(79, 185);
            this.txttrDate.Name = "txttrDate";
            this.txttrDate.ReadOnly = true;
            this.txttrDate.Size = new System.Drawing.Size(193, 23);
            this.txttrDate.TabIndex = 12;
            // 
            // txttrSearch
            // 
            this.txttrSearch.Location = new System.Drawing.Point(435, 6);
            this.txttrSearch.Name = "txttrSearch";
            this.txttrSearch.Size = new System.Drawing.Size(126, 23);
            this.txttrSearch.TabIndex = 11;
            // 
            // btntrSave
            // 
            this.btntrSave.Location = new System.Drawing.Point(214, 452);
            this.btntrSave.Name = "btntrSave";
            this.btntrSave.Size = new System.Drawing.Size(58, 23);
            this.btntrSave.TabIndex = 10;
            this.btntrSave.Text = "저장";
            this.btntrSave.UseVisualStyleBackColor = true;
            this.btntrSave.Click += new System.EventHandler(this.btntrSave_Click);
            // 
            // btntrSearch
            // 
            this.btntrSearch.Location = new System.Drawing.Point(567, 6);
            this.btntrSearch.Name = "btntrSearch";
            this.btntrSearch.Size = new System.Drawing.Size(50, 23);
            this.btntrSearch.TabIndex = 8;
            this.btntrSearch.Text = "검색";
            this.btntrSearch.UseVisualStyleBackColor = true;
            this.btntrSearch.Click += new System.EventHandler(this.btntrSearch_Click);
            // 
            // lvtrDetails
            // 
            this.lvtrDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chtr2Code,
            this.chtr2Dog,
            this.chtr2Date,
            this.chtr2Symptom,
            this.chtr2Prescription,
            this.chtr2Vaccine});
            this.lvtrDetails.GridLines = true;
            this.lvtrDetails.Location = new System.Drawing.Point(289, 151);
            this.lvtrDetails.Name = "lvtrDetails";
            this.lvtrDetails.Size = new System.Drawing.Size(589, 324);
            this.lvtrDetails.TabIndex = 7;
            this.lvtrDetails.UseCompatibleStateImageBehavior = false;
            this.lvtrDetails.View = System.Windows.Forms.View.Details;
            // 
            // chtr2Code
            // 
            this.chtr2Code.Text = "코드";
            this.chtr2Code.Width = 50;
            // 
            // chtr2Dog
            // 
            this.chtr2Dog.Text = "강아지명";
            // 
            // chtr2Date
            // 
            this.chtr2Date.Text = "내원일";
            this.chtr2Date.Width = 135;
            // 
            // chtr2Symptom
            // 
            this.chtr2Symptom.Text = "증상";
            this.chtr2Symptom.Width = 125;
            // 
            // chtr2Prescription
            // 
            this.chtr2Prescription.Text = "처방";
            this.chtr2Prescription.Width = 125;
            // 
            // chtr2Vaccine
            // 
            this.chtr2Vaccine.Text = "접종";
            this.chtr2Vaccine.Width = 90;
            // 
            // lbtrSymptom
            // 
            this.lbtrSymptom.AutoSize = true;
            this.lbtrSymptom.Location = new System.Drawing.Point(18, 220);
            this.lbtrSymptom.Name = "lbtrSymptom";
            this.lbtrSymptom.Size = new System.Drawing.Size(31, 15);
            this.lbtrSymptom.TabIndex = 6;
            this.lbtrSymptom.Text = "증상";
            // 
            // lbtrDog
            // 
            this.lbtrDog.AutoSize = true;
            this.lbtrDog.Location = new System.Drawing.Point(136, 156);
            this.lbtrDog.Name = "lbtrDog";
            this.lbtrDog.Size = new System.Drawing.Size(55, 15);
            this.lbtrDog.TabIndex = 5;
            this.lbtrDog.Text = "강아지명";
            // 
            // lbtrDate
            // 
            this.lbtrDate.AutoSize = true;
            this.lbtrDate.Location = new System.Drawing.Point(18, 188);
            this.lbtrDate.Name = "lbtrDate";
            this.lbtrDate.Size = new System.Drawing.Size(55, 15);
            this.lbtrDate.TabIndex = 4;
            this.lbtrDate.Text = "내원일자";
            // 
            // lbtrPrescription
            // 
            this.lbtrPrescription.AutoSize = true;
            this.lbtrPrescription.Location = new System.Drawing.Point(18, 298);
            this.lbtrPrescription.Name = "lbtrPrescription";
            this.lbtrPrescription.Size = new System.Drawing.Size(31, 15);
            this.lbtrPrescription.TabIndex = 3;
            this.lbtrPrescription.Text = "처방";
            // 
            // lbtrCode
            // 
            this.lbtrCode.AutoSize = true;
            this.lbtrCode.Location = new System.Drawing.Point(18, 159);
            this.lbtrCode.Name = "lbtrCode";
            this.lbtrCode.Size = new System.Drawing.Size(31, 15);
            this.lbtrCode.TabIndex = 2;
            this.lbtrCode.Text = "코드";
            // 
            // lbtrSearch
            // 
            this.lbtrSearch.AutoSize = true;
            this.lbtrSearch.Location = new System.Drawing.Point(374, 10);
            this.lbtrSearch.Name = "lbtrSearch";
            this.lbtrSearch.Size = new System.Drawing.Size(55, 15);
            this.lbtrSearch.TabIndex = 1;
            this.lbtrSearch.Text = "강아지명";
            // 
            // lvtrView
            // 
            this.lvtrView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chtrCode,
            this.chtrProtect,
            this.chtrDog,
            this.chtrBreed,
            this.chtrWeight,
            this.chtrBirth});
            this.lvtrView.FullRowSelect = true;
            this.lvtrView.GridLines = true;
            this.lvtrView.Location = new System.Drawing.Point(18, 35);
            this.lvtrView.Name = "lvtrView";
            this.lvtrView.Size = new System.Drawing.Size(860, 97);
            this.lvtrView.TabIndex = 0;
            this.lvtrView.UseCompatibleStateImageBehavior = false;
            this.lvtrView.View = System.Windows.Forms.View.Details;
            this.lvtrView.SelectedIndexChanged += new System.EventHandler(this.lvtrView_SelectedIndexChanged);
            // 
            // chtrCode
            // 
            this.chtrCode.Text = "코드";
            this.chtrCode.Width = 120;
            // 
            // chtrProtect
            // 
            this.chtrProtect.Text = "보호자명";
            this.chtrProtect.Width = 120;
            // 
            // chtrDog
            // 
            this.chtrDog.Text = "강아지명";
            this.chtrDog.Width = 120;
            // 
            // chtrBreed
            // 
            this.chtrBreed.Text = "견종";
            this.chtrBreed.Width = 120;
            // 
            // chtrWeight
            // 
            this.chtrWeight.Text = "체중";
            this.chtrWeight.Width = 120;
            // 
            // chtrBirth
            // 
            this.chtrBirth.Text = "생년월일";
            this.chtrBirth.Width = 250;
            // 
            // tbHospital
            // 
            this.tbHospital.Controls.Add(this.lvHospital);
            this.tbHospital.Controls.Add(this.btnHospital);
            this.tbHospital.Controls.Add(this.cbBorough);
            this.tbHospital.Controls.Add(this.cbCity);
            this.tbHospital.Location = new System.Drawing.Point(4, 24);
            this.tbHospital.Name = "tbHospital";
            this.tbHospital.Padding = new System.Windows.Forms.Padding(3);
            this.tbHospital.Size = new System.Drawing.Size(958, 523);
            this.tbHospital.TabIndex = 2;
            this.tbHospital.Text = "병원 찾기";
            this.tbHospital.UseVisualStyleBackColor = true;
            // 
            // lvHospital
            // 
            this.lvHospital.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHosName,
            this.chHosAdd,
            this.chHosTel,
            this.chHosSurgery,
            this.chHosRe});
            this.lvHospital.GridLines = true;
            this.lvHospital.Location = new System.Drawing.Point(19, 59);
            this.lvHospital.Name = "lvHospital";
            this.lvHospital.Size = new System.Drawing.Size(860, 414);
            this.lvHospital.TabIndex = 6;
            this.lvHospital.UseCompatibleStateImageBehavior = false;
            this.lvHospital.View = System.Windows.Forms.View.Details;
            // 
            // chHosName
            // 
            this.chHosName.Text = "병원명";
            this.chHosName.Width = 200;
            // 
            // chHosAdd
            // 
            this.chHosAdd.Text = "주소";
            this.chHosAdd.Width = 330;
            // 
            // chHosTel
            // 
            this.chHosTel.Text = "전화번호";
            this.chHosTel.Width = 200;
            // 
            // chHosSurgery
            // 
            this.chHosSurgery.Text = "수술";
            // 
            // chHosRe
            // 
            this.chHosRe.Text = "재활";
            // 
            // btnHospital
            // 
            this.btnHospital.Location = new System.Drawing.Point(804, 18);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(85, 23);
            this.btnHospital.TabIndex = 5;
            this.btnHospital.Text = "검색";
            this.btnHospital.UseVisualStyleBackColor = true;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // cbBorough
            // 
            this.cbBorough.FormattingEnabled = true;
            this.cbBorough.Items.AddRange(new object[] {
            "강서구",
            "양천구",
            "구로구",
            "영등포구",
            "금천구",
            "동작구",
            "관악구",
            "서초구",
            "강남구",
            "송파구",
            "강동구",
            "성동구",
            "용산구",
            "마포구",
            "서대문구",
            "중구",
            "동대문구",
            "종로구",
            "은평구",
            "성북구",
            "강북구",
            "도봉구"});
            this.cbBorough.Location = new System.Drawing.Point(665, 18);
            this.cbBorough.Name = "cbBorough";
            this.cbBorough.Size = new System.Drawing.Size(121, 23);
            this.cbBorough.TabIndex = 4;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "서울특별시"});
            this.cbCity.Location = new System.Drawing.Point(525, 18);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 23);
            this.cbCity.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.tbMenu);
            this.Name = "Form1";
            this.Text = "동물병원 관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbMenu.ResumeLayout(false);
            this.tbReceipt.ResumeLayout(false);
            this.tbReceipt.PerformLayout();
            this.tbTreat.ResumeLayout(false);
            this.tbTreat.PerformLayout();
            this.tbHospital.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbMenu;
        private TabPage tbReceipt;
        private TextBox txtBirth;
        private TextBox txtWeight;
        private TextBox txtDog;
        private TextBox txtSearch;
        private TextBox txtBreed;
        private TextBox txtProtector;
        private Label lblSearch;
        private Label lblBirth;
        private Label lblWeight;
        private Label lblBreed;
        private Label lblDog;
        private Label lblProtector;
        private TabPage tbTreat;
        private Button btnSearch;
        private Button btnReset;
        private Button btnEnter;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvView;
        private ColumnHeader chCode;
        private ColumnHeader chProtect;
        private ColumnHeader chDog;
        private ColumnHeader chBreed;
        private ColumnHeader chWeight;
        private ColumnHeader chBirth;
        private TextBox txttrCode;
        private TextBox txttrDog;
        private TextBox txttrSymptom;
        private TextBox txttrDate;
        private TextBox txttrSearch;
        private Button btntrSave;
        private Button btntrSearch;
        private ListView lvtrDetails;
        private Label lbtrSymptom;
        private Label lbtrDog;
        private Label lbtrDate;
        private Label lbtrPrescription;
        private Label lbtrCode;
        private Label lbtrSearch;
        private ListView lvtrView;
        private TextBox txttrPrescription;
        private ColumnHeader chtr2Code;
        private ColumnHeader chtr2Dog;
        private ColumnHeader chtr2Date;
        private ColumnHeader chtr2Symptom;
        private ColumnHeader chtr2Prescription;
        private ColumnHeader chtrCode;
        private ColumnHeader chtrProtect;
        private ColumnHeader chtrDog;
        private ColumnHeader chtrBreed;
        private ColumnHeader chtrWeight;
        private ColumnHeader chtrBirth;
        private ComboBox cbVaccine;
        private Label lblVac;
        private ColumnHeader chtr2Vaccine;
        private Label lbltrProtector;
        private TextBox txtSeProtector;
        private Label lblSeProtector;
        private Button btnSeProtector;
        private Button btntrProtector;
        private TextBox txttrProtector;
        private TabPage tbHospital;
        private Button btnHospital;
        private ComboBox cbBorough;
        private ComboBox cbCity;
        private ListView lvHospital;
        private ColumnHeader chHosName;
        private ColumnHeader chHosAdd;
        private ColumnHeader chHosTel;
        private ColumnHeader chHosSurgery;
        private ColumnHeader chHosRe;
    }
}