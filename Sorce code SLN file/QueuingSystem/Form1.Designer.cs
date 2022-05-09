
namespace QueuingSystem
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.txtNoCust = new System.Windows.Forms.TextBox();
            this.txtInterarrivalTm = new System.Windows.Forms.TextBox();
            this.lblNoCust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProbaOfInterTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProbOfSrvcTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSrvcTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntArivTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArivTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSrvceBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSrvceEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitTimeInQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimCustInSys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdlTimOfServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStartSim = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAveragWaittime = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lbldom1 = new System.Windows.Forms.Label();
            this.lblNom1 = new System.Windows.Forms.Label();
            this.lblRes1 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.lblNom2 = new System.Windows.Forms.Label();
            this.lbldom2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProbWait = new System.Windows.Forms.Label();
            this.lblRes3 = new System.Windows.Forms.Label();
            this.lblNom3 = new System.Windows.Forms.Label();
            this.lblDom3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProbIdleserv = new System.Windows.Forms.Label();
            this.lblRes4 = new System.Windows.Forms.Label();
            this.lblNom4 = new System.Windows.Forms.Label();
            this.lblDom4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblServicetime = new System.Windows.Forms.Label();
            this.lblRes5 = new System.Windows.Forms.Label();
            this.lblNom5 = new System.Windows.Forms.Label();
            this.lblDom5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvgtmBetArriv = new System.Windows.Forms.Label();
            this.lblRes6 = new System.Windows.Forms.Label();
            this.lblNom6 = new System.Windows.Forms.Label();
            this.lblDom6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblWtigAvgTmOfThsWhoWait = new System.Windows.Forms.Label();
            this.lblRes7 = new System.Windows.Forms.Label();
            this.lblNom7 = new System.Windows.Forms.Label();
            this.lblDom7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAvgTmCustSpdinDSys = new System.Windows.Forms.Label();
            this.btnExpExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoCust
            // 
            this.txtNoCust.Location = new System.Drawing.Point(148, 20);
            this.txtNoCust.Name = "txtNoCust";
            this.txtNoCust.Size = new System.Drawing.Size(77, 20);
            this.txtNoCust.TabIndex = 0;
            this.txtNoCust.TextChanged += new System.EventHandler(this.txtNoCust_TextChanged);
            this.txtNoCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoCust_KeyDown);
            // 
            // txtInterarrivalTm
            // 
            this.txtInterarrivalTm.Location = new System.Drawing.Point(148, 46);
            this.txtInterarrivalTm.Name = "txtInterarrivalTm";
            this.txtInterarrivalTm.Size = new System.Drawing.Size(268, 20);
            this.txtInterarrivalTm.TabIndex = 1;
            this.txtInterarrivalTm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtInterarrivalTm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblNoCust
            // 
            this.lblNoCust.AutoSize = true;
            this.lblNoCust.Location = new System.Drawing.Point(12, 23);
            this.lblNoCust.Name = "lblNoCust";
            this.lblNoCust.Size = new System.Drawing.Size(91, 13);
            this.lblNoCust.TabIndex = 2;
            this.lblNoCust.Text = "No. of Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interarrival time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Probability for each time";
            // 
            // txtProbaOfInterTime
            // 
            this.txtProbaOfInterTime.Location = new System.Drawing.Point(148, 72);
            this.txtProbaOfInterTime.Name = "txtProbaOfInterTime";
            this.txtProbaOfInterTime.Size = new System.Drawing.Size(268, 20);
            this.txtProbaOfInterTime.TabIndex = 4;
            this.txtProbaOfInterTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Probability of service time";
            // 
            // txtProbOfSrvcTime
            // 
            this.txtProbOfSrvcTime.Location = new System.Drawing.Point(148, 124);
            this.txtProbOfSrvcTime.Name = "txtProbOfSrvcTime";
            this.txtProbOfSrvcTime.Size = new System.Drawing.Size(268, 20);
            this.txtProbOfSrvcTime.TabIndex = 8;
            this.txtProbOfSrvcTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProbOfSrvcTime_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Service time";
            // 
            // txtSrvcTime
            // 
            this.txtSrvcTime.Location = new System.Drawing.Point(148, 98);
            this.txtSrvcTime.Name = "txtSrvcTime";
            this.txtSrvcTime.Size = new System.Drawing.Size(268, 20);
            this.txtSrvcTime.TabIndex = 6;
            this.txtSrvcTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cust,
            this.IntArivTime,
            this.ArivTime,
            this.ServTime,
            this.TimeSrvceBegin,
            this.TimeSrvceEnd,
            this.WaitTimeInQ,
            this.TimCustInSys,
            this.IdlTimOfServer});
            this.dataGridView1.Location = new System.Drawing.Point(432, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(749, 493);
            this.dataGridView1.TabIndex = 11;
            // 
            // Cust
            // 
            this.Cust.HeaderText = "Customer";
            this.Cust.Name = "Cust";
            this.Cust.ReadOnly = true;
            // 
            // IntArivTime
            // 
            this.IntArivTime.HeaderText = "Interarival Time";
            this.IntArivTime.Name = "IntArivTime";
            this.IntArivTime.ReadOnly = true;
            // 
            // ArivTime
            // 
            this.ArivTime.HeaderText = "Arrival Time";
            this.ArivTime.Name = "ArivTime";
            this.ArivTime.ReadOnly = true;
            // 
            // ServTime
            // 
            this.ServTime.HeaderText = "Service Time";
            this.ServTime.Name = "ServTime";
            this.ServTime.ReadOnly = true;
            // 
            // TimeSrvceBegin
            // 
            this.TimeSrvceBegin.HeaderText = "Time Service Begins";
            this.TimeSrvceBegin.Name = "TimeSrvceBegin";
            this.TimeSrvceBegin.ReadOnly = true;
            // 
            // TimeSrvceEnd
            // 
            this.TimeSrvceEnd.HeaderText = "Time Service Ends";
            this.TimeSrvceEnd.Name = "TimeSrvceEnd";
            this.TimeSrvceEnd.ReadOnly = true;
            // 
            // WaitTimeInQ
            // 
            this.WaitTimeInQ.HeaderText = "Waiting Time in Queue";
            this.WaitTimeInQ.Name = "WaitTimeInQ";
            this.WaitTimeInQ.ReadOnly = true;
            // 
            // TimCustInSys
            // 
            this.TimCustInSys.HeaderText = "Time Customer in System";
            this.TimCustInSys.Name = "TimCustInSys";
            this.TimCustInSys.ReadOnly = true;
            // 
            // IdlTimOfServer
            // 
            this.IdlTimOfServer.HeaderText = "Idle Time of Server";
            this.IdlTimOfServer.Name = "IdlTimOfServer";
            this.IdlTimOfServer.ReadOnly = true;
            // 
            // btnStartSim
            // 
            this.btnStartSim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSim.Location = new System.Drawing.Point(12, 160);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(148, 23);
            this.btnStartSim.TabIndex = 12;
            this.btnStartSim.Text = "Start Probability fill";
            this.btnStartSim.UseVisualStyleBackColor = true;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(200, 160);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAveragWaittime
            // 
            this.lblAveragWaittime.AutoSize = true;
            this.lblAveragWaittime.Location = new System.Drawing.Point(17, 245);
            this.lblAveragWaittime.Name = "lblAveragWaittime";
            this.lblAveragWaittime.Size = new System.Drawing.Size(122, 13);
            this.lblAveragWaittime.TabIndex = 14;
            this.lblAveragWaittime.Text = "Average waiting time = ";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 211);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(149, 22);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculations";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Location = new System.Drawing.Point(134, 245);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(63, 13);
            this.lblLine1.TabIndex = 16;
            this.lblLine1.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lbldom1
            // 
            this.lbldom1.AutoSize = true;
            this.lbldom1.Location = new System.Drawing.Point(142, 236);
            this.lbldom1.Name = "lbldom1";
            this.lbldom1.Size = new System.Drawing.Size(0, 13);
            this.lbldom1.TabIndex = 17;
            // 
            // lblNom1
            // 
            this.lblNom1.AutoSize = true;
            this.lblNom1.Location = new System.Drawing.Point(140, 257);
            this.lblNom1.Name = "lblNom1";
            this.lblNom1.Size = new System.Drawing.Size(0, 13);
            this.lblNom1.TabIndex = 18;
            // 
            // lblRes1
            // 
            this.lblRes1.AutoSize = true;
            this.lblRes1.Location = new System.Drawing.Point(201, 246);
            this.lblRes1.Name = "lblRes1";
            this.lblRes1.Size = new System.Drawing.Size(0, 13);
            this.lblRes1.TabIndex = 19;
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Location = new System.Drawing.Point(191, 287);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(0, 13);
            this.lblRes2.TabIndex = 24;
            // 
            // lblNom2
            // 
            this.lblNom2.AutoSize = true;
            this.lblNom2.Location = new System.Drawing.Point(130, 298);
            this.lblNom2.Name = "lblNom2";
            this.lblNom2.Size = new System.Drawing.Size(0, 13);
            this.lblNom2.TabIndex = 23;
            // 
            // lbldom2
            // 
            this.lbldom2.AutoSize = true;
            this.lbldom2.Location = new System.Drawing.Point(132, 277);
            this.lbldom2.Name = "lbldom2";
            this.lbldom2.Size = new System.Drawing.Size(0, 13);
            this.lbldom2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lblProbWait
            // 
            this.lblProbWait.AutoSize = true;
            this.lblProbWait.Location = new System.Drawing.Point(15, 286);
            this.lblProbWait.Name = "lblProbWait";
            this.lblProbWait.Size = new System.Drawing.Size(102, 13);
            this.lblProbWait.TabIndex = 20;
            this.lblProbWait.Text = "Probability (wait) = ";
            // 
            // lblRes3
            // 
            this.lblRes3.AutoSize = true;
            this.lblRes3.Location = new System.Drawing.Point(228, 326);
            this.lblRes3.Name = "lblRes3";
            this.lblRes3.Size = new System.Drawing.Size(0, 13);
            this.lblRes3.TabIndex = 29;
            // 
            // lblNom3
            // 
            this.lblNom3.AutoSize = true;
            this.lblNom3.Location = new System.Drawing.Point(167, 337);
            this.lblNom3.Name = "lblNom3";
            this.lblNom3.Size = new System.Drawing.Size(0, 13);
            this.lblNom3.TabIndex = 28;
            // 
            // lblDom3
            // 
            this.lblDom3.AutoSize = true;
            this.lblDom3.Location = new System.Drawing.Point(169, 316);
            this.lblDom3.Name = "lblDom3";
            this.lblDom3.Size = new System.Drawing.Size(0, 13);
            this.lblDom3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lblProbIdleserv
            // 
            this.lblProbIdleserv.AutoSize = true;
            this.lblProbIdleserv.Location = new System.Drawing.Point(15, 325);
            this.lblProbIdleserv.Name = "lblProbIdleserv";
            this.lblProbIdleserv.Size = new System.Drawing.Size(140, 13);
            this.lblProbIdleserv.TabIndex = 25;
            this.lblProbIdleserv.Text = "Probability of idle server  = ";
            // 
            // lblRes4
            // 
            this.lblRes4.AutoSize = true;
            this.lblRes4.Location = new System.Drawing.Point(222, 362);
            this.lblRes4.Name = "lblRes4";
            this.lblRes4.Size = new System.Drawing.Size(0, 13);
            this.lblRes4.TabIndex = 34;
            // 
            // lblNom4
            // 
            this.lblNom4.AutoSize = true;
            this.lblNom4.Location = new System.Drawing.Point(161, 373);
            this.lblNom4.Name = "lblNom4";
            this.lblNom4.Size = new System.Drawing.Size(0, 13);
            this.lblNom4.TabIndex = 33;
            // 
            // lblDom4
            // 
            this.lblDom4.AutoSize = true;
            this.lblDom4.Location = new System.Drawing.Point(163, 352);
            this.lblDom4.Name = "lblDom4";
            this.lblDom4.Size = new System.Drawing.Size(0, 13);
            this.lblDom4.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lblServicetime
            // 
            this.lblServicetime.AutoSize = true;
            this.lblServicetime.Location = new System.Drawing.Point(14, 362);
            this.lblServicetime.Name = "lblServicetime";
            this.lblServicetime.Size = new System.Drawing.Size(122, 13);
            this.lblServicetime.TabIndex = 30;
            this.lblServicetime.Text = "Average service time = ";
            // 
            // lblRes5
            // 
            this.lblRes5.AutoSize = true;
            this.lblRes5.Location = new System.Drawing.Point(257, 404);
            this.lblRes5.Name = "lblRes5";
            this.lblRes5.Size = new System.Drawing.Size(0, 13);
            this.lblRes5.TabIndex = 39;
            // 
            // lblNom5
            // 
            this.lblNom5.AutoSize = true;
            this.lblNom5.Location = new System.Drawing.Point(196, 415);
            this.lblNom5.Name = "lblNom5";
            this.lblNom5.Size = new System.Drawing.Size(0, 13);
            this.lblNom5.TabIndex = 38;
            // 
            // lblDom5
            // 
            this.lblDom5.AutoSize = true;
            this.lblDom5.Location = new System.Drawing.Point(198, 394);
            this.lblDom5.Name = "lblDom5";
            this.lblDom5.Size = new System.Drawing.Size(0, 13);
            this.lblDom5.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lblAvgtmBetArriv
            // 
            this.lblAvgtmBetArriv.AutoSize = true;
            this.lblAvgtmBetArriv.Location = new System.Drawing.Point(12, 403);
            this.lblAvgtmBetArriv.Name = "lblAvgtmBetArriv";
            this.lblAvgtmBetArriv.Size = new System.Drawing.Size(168, 13);
            this.lblAvgtmBetArriv.TabIndex = 35;
            this.lblAvgtmBetArriv.Text = "Average time between arrivals = ";
            // 
            // lblRes6
            // 
            this.lblRes6.AutoSize = true;
            this.lblRes6.Location = new System.Drawing.Point(296, 446);
            this.lblRes6.Name = "lblRes6";
            this.lblRes6.Size = new System.Drawing.Size(0, 13);
            this.lblRes6.TabIndex = 44;
            // 
            // lblNom6
            // 
            this.lblNom6.AutoSize = true;
            this.lblNom6.Location = new System.Drawing.Point(235, 457);
            this.lblNom6.Name = "lblNom6";
            this.lblNom6.Size = new System.Drawing.Size(0, 13);
            this.lblNom6.TabIndex = 43;
            // 
            // lblDom6
            // 
            this.lblDom6.AutoSize = true;
            this.lblDom6.Location = new System.Drawing.Point(237, 436);
            this.lblDom6.Name = "lblDom6";
            this.lblDom6.Size = new System.Drawing.Size(0, 13);
            this.lblDom6.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lblWtigAvgTmOfThsWhoWait
            // 
            this.lblWtigAvgTmOfThsWhoWait.AutoSize = true;
            this.lblWtigAvgTmOfThsWhoWait.Location = new System.Drawing.Point(9, 445);
            this.lblWtigAvgTmOfThsWhoWait.Name = "lblWtigAvgTmOfThsWhoWait";
            this.lblWtigAvgTmOfThsWhoWait.Size = new System.Drawing.Size(211, 13);
            this.lblWtigAvgTmOfThsWhoWait.TabIndex = 40;
            this.lblWtigAvgTmOfThsWhoWait.Text = "Average waiting time of those who wait = ";
            // 
            // lblRes7
            // 
            this.lblRes7.AutoSize = true;
            this.lblRes7.Location = new System.Drawing.Point(312, 496);
            this.lblRes7.Name = "lblRes7";
            this.lblRes7.Size = new System.Drawing.Size(0, 13);
            this.lblRes7.TabIndex = 49;
            // 
            // lblNom7
            // 
            this.lblNom7.AutoSize = true;
            this.lblNom7.Location = new System.Drawing.Point(251, 507);
            this.lblNom7.Name = "lblNom7";
            this.lblNom7.Size = new System.Drawing.Size(0, 13);
            this.lblNom7.TabIndex = 48;
            // 
            // lblDom7
            // 
            this.lblDom7.AutoSize = true;
            this.lblDom7.Location = new System.Drawing.Point(253, 486);
            this.lblDom7.Name = "lblDom7";
            this.lblDom7.Size = new System.Drawing.Size(0, 13);
            this.lblDom7.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "⎯⎯⎯⎯⎯⎯ = ";
            // 
            // lblAvgTmCustSpdinDSys
            // 
            this.lblAvgTmCustSpdinDSys.AutoSize = true;
            this.lblAvgTmCustSpdinDSys.Location = new System.Drawing.Point(7, 495);
            this.lblAvgTmCustSpdinDSys.Name = "lblAvgTmCustSpdinDSys";
            this.lblAvgTmCustSpdinDSys.Size = new System.Drawing.Size(236, 13);
            this.lblAvgTmCustSpdinDSys.TabIndex = 45;
            this.lblAvgTmCustSpdinDSys.Text = "Average time customer spends in the system = ";
            // 
            // btnExpExcel
            // 
            this.btnExpExcel.Location = new System.Drawing.Point(199, 211);
            this.btnExpExcel.Name = "btnExpExcel";
            this.btnExpExcel.Size = new System.Drawing.Size(149, 22);
            this.btnExpExcel.TabIndex = 50;
            this.btnExpExcel.Text = "Export to Excel sheet";
            this.btnExpExcel.UseVisualStyleBackColor = true;
            this.btnExpExcel.Click += new System.EventHandler(this.btnExpExcel_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 527);
            this.Controls.Add(this.btnExpExcel);
            this.Controls.Add(this.lblRes7);
            this.Controls.Add(this.lblNom7);
            this.Controls.Add(this.lblDom7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblAvgTmCustSpdinDSys);
            this.Controls.Add(this.lblRes6);
            this.Controls.Add(this.lblNom6);
            this.Controls.Add(this.lblDom6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblWtigAvgTmOfThsWhoWait);
            this.Controls.Add(this.lblRes5);
            this.Controls.Add(this.lblNom5);
            this.Controls.Add(this.lblDom5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAvgtmBetArriv);
            this.Controls.Add(this.lblRes4);
            this.Controls.Add(this.lblNom4);
            this.Controls.Add(this.lblDom4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblServicetime);
            this.Controls.Add(this.lblRes3);
            this.Controls.Add(this.lblNom3);
            this.Controls.Add(this.lblDom3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblProbIdleserv);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.lblNom2);
            this.Controls.Add(this.lbldom2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblProbWait);
            this.Controls.Add(this.lblRes1);
            this.Controls.Add(this.lblNom1);
            this.Controls.Add(this.lbldom1);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAveragWaittime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStartSim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProbOfSrvcTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSrvcTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProbaOfInterTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoCust);
            this.Controls.Add(this.txtInterarrivalTm);
            this.Controls.Add(this.txtNoCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "Queuing system";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoCust;
        private System.Windows.Forms.TextBox txtInterarrivalTm;
        private System.Windows.Forms.Label lblNoCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProbaOfInterTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProbOfSrvcTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSrvcTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAveragWaittime;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lbldom1;
        private System.Windows.Forms.Label lblNom1;
        private System.Windows.Forms.Label lblRes1;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblNom2;
        private System.Windows.Forms.Label lbldom2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProbWait;
        private System.Windows.Forms.Label lblRes3;
        private System.Windows.Forms.Label lblNom3;
        private System.Windows.Forms.Label lblDom3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProbIdleserv;
        private System.Windows.Forms.Label lblRes4;
        private System.Windows.Forms.Label lblNom4;
        private System.Windows.Forms.Label lblDom4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblServicetime;
        private System.Windows.Forms.Label lblRes5;
        private System.Windows.Forms.Label lblNom5;
        private System.Windows.Forms.Label lblDom5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAvgtmBetArriv;
        private System.Windows.Forms.Label lblRes6;
        private System.Windows.Forms.Label lblNom6;
        private System.Windows.Forms.Label lblDom6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblWtigAvgTmOfThsWhoWait;
        private System.Windows.Forms.Label lblRes7;
        private System.Windows.Forms.Label lblNom7;
        private System.Windows.Forms.Label lblDom7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAvgTmCustSpdinDSys;
        private System.Windows.Forms.Button btnExpExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntArivTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArivTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSrvceBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSrvceEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitTimeInQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimCustInSys;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdlTimOfServer;
    }
}

