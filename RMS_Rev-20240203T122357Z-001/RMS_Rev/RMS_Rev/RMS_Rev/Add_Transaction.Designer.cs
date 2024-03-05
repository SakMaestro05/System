namespace RMS_Rev
{
    partial class Add_Transaction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Transaction));
            this.lbltimer = new System.Windows.Forms.Label();
            this.lbltodate = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.txtln = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdeviceinfo = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtsuf = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.cbopay = new System.Windows.Forms.ComboBox();
            this.lblpay = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.cbotrans = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.optbtnphone = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optbtnlaptop = new System.Windows.Forms.RadioButton();
            this.lblsuf = new System.Windows.Forms.Label();
            this.lblsur = new System.Windows.Forms.Label();
            this.lblmname = new System.Windows.Forms.Label();
            this.lbltransno = new System.Windows.Forms.Label();
            this.lblhomeaddress = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblphoneno = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblReset = new System.Windows.Forms.Label();
            this.lblArchive = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.picboxRms = new System.Windows.Forms.PictureBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTransactionNo = new System.Windows.Forms.TextBox();
            this.lblSignout = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.picboxTrans = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Black;
            this.lbltimer.Location = new System.Drawing.Point(807, 60);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(85, 16);
            this.lbltimer.TabIndex = 204;
            this.lbltimer.Text = "TIME TODAY";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltodate
            // 
            this.lbltodate.AutoSize = true;
            this.lbltodate.BackColor = System.Drawing.Color.Transparent;
            this.lbltodate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltodate.ForeColor = System.Drawing.Color.Black;
            this.lbltodate.Location = new System.Drawing.Point(826, 44);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(87, 16);
            this.lbltodate.TabIndex = 205;
            this.lbltodate.Text = "DATE TODAY";
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.Location = new System.Drawing.Point(675, 8);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(54, 13);
            this.lblPrint.TabIndex = 203;
            this.lblPrint.Text = "Records";
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            // 
            // txtln
            // 
            this.txtln.BackColor = System.Drawing.SystemColors.Control;
            this.txtln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtln.Location = new System.Drawing.Point(127, 208);
            this.txtln.Multiline = true;
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(204, 20);
            this.txtln.TabIndex = 202;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(128, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 13);
            this.label12.TabIndex = 201;
            this.label12.Text = "_________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(129, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 13);
            this.label11.TabIndex = 200;
            this.label11.Text = "_________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(129, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 13);
            this.label10.TabIndex = 199;
            this.label10.Text = "_________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(540, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 13);
            this.label9.TabIndex = 198;
            this.label9.Text = "_________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(127, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 197;
            this.label8.Text = "_________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(127, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 196;
            this.label7.Text = "_________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(128, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 13);
            this.label6.TabIndex = 195;
            this.label6.Text = "_________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(128, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 194;
            this.label5.Text = "_________________________________";
            // 
            // txtdeviceinfo
            // 
            this.txtdeviceinfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtdeviceinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdeviceinfo.Location = new System.Drawing.Point(541, 119);
            this.txtdeviceinfo.Multiline = true;
            this.txtdeviceinfo.Name = "txtdeviceinfo";
            this.txtdeviceinfo.Size = new System.Drawing.Size(204, 20);
            this.txtdeviceinfo.TabIndex = 193;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Location = new System.Drawing.Point(130, 269);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNumber.TabIndex = 192;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtHomeAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHomeAddress.Location = new System.Drawing.Point(129, 292);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(204, 20);
            this.txtHomeAddress.TabIndex = 191;
            // 
            // txtsuf
            // 
            this.txtsuf.BackColor = System.Drawing.SystemColors.Control;
            this.txtsuf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsuf.Location = new System.Drawing.Point(131, 232);
            this.txtsuf.Multiline = true;
            this.txtsuf.Name = "txtsuf";
            this.txtsuf.Size = new System.Drawing.Size(204, 20);
            this.txtsuf.TabIndex = 190;
            // 
            // txtfn
            // 
            this.txtfn.BackColor = System.Drawing.SystemColors.Control;
            this.txtfn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfn.Location = new System.Drawing.Point(129, 149);
            this.txtfn.Multiline = true;
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(204, 20);
            this.txtfn.TabIndex = 189;
            // 
            // txtmn
            // 
            this.txtmn.BackColor = System.Drawing.SystemColors.Control;
            this.txtmn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmn.Location = new System.Drawing.Point(129, 178);
            this.txtmn.Multiline = true;
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(204, 20);
            this.txtmn.TabIndex = 188;
            // 
            // cbopay
            // 
            this.cbopay.BackColor = System.Drawing.Color.DimGray;
            this.cbopay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopay.ForeColor = System.Drawing.Color.White;
            this.cbopay.FormattingEnabled = true;
            this.cbopay.Items.AddRange(new object[] {
            "Fully Paid",
            "Partially Paid"});
            this.cbopay.Location = new System.Drawing.Point(541, 237);
            this.cbopay.Name = "cbopay";
            this.cbopay.Size = new System.Drawing.Size(146, 23);
            this.cbopay.TabIndex = 187;
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblpay.ForeColor = System.Drawing.Color.Black;
            this.lblpay.Location = new System.Drawing.Point(407, 240);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(99, 13);
            this.lblpay.TabIndex = 186;
            this.lblpay.Text = "Payment Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.DimGray;
            this.cboStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.White;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ongoing",
            "Paused",
            "Done",
            "Cancelled"});
            this.cboStatus.Location = new System.Drawing.Point(541, 205);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(146, 23);
            this.cboStatus.TabIndex = 185;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(410, 212);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 184;
            this.lblStatus.Text = "Status:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblprice.ForeColor = System.Drawing.Color.Black;
            this.lblprice.Location = new System.Drawing.Point(407, 182);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(40, 13);
            this.lblprice.TabIndex = 183;
            this.lblprice.Text = "Price:";
            // 
            // cbotrans
            // 
            this.cbotrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotrans.FormattingEnabled = true;
            this.cbotrans.Location = new System.Drawing.Point(541, 145);
            this.cbotrans.Name = "cbotrans";
            this.cbotrans.Size = new System.Drawing.Size(158, 24);
            this.cbotrans.TabIndex = 178;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(541, 175);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(90, 20);
            this.txtprice.TabIndex = 182;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // optbtnphone
            // 
            this.optbtnphone.AutoSize = true;
            this.optbtnphone.BackColor = System.Drawing.Color.Transparent;
            this.optbtnphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.optbtnphone.ForeColor = System.Drawing.Color.Black;
            this.optbtnphone.Location = new System.Drawing.Point(500, 90);
            this.optbtnphone.Name = "optbtnphone";
            this.optbtnphone.Size = new System.Drawing.Size(68, 17);
            this.optbtnphone.TabIndex = 179;
            this.optbtnphone.TabStop = true;
            this.optbtnphone.Text = "PHONE";
            this.optbtnphone.UseVisualStyleBackColor = false;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblgender.ForeColor = System.Drawing.Color.Black;
            this.lblgender.Location = new System.Drawing.Point(410, 120);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(77, 13);
            this.lblgender.TabIndex = 177;
            this.lblgender.Text = "Device Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(407, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 181;
            this.label1.Text = "Select Service:";
            // 
            // optbtnlaptop
            // 
            this.optbtnlaptop.AutoSize = true;
            this.optbtnlaptop.BackColor = System.Drawing.Color.Transparent;
            this.optbtnlaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.optbtnlaptop.ForeColor = System.Drawing.Color.Black;
            this.optbtnlaptop.Location = new System.Drawing.Point(595, 90);
            this.optbtnlaptop.Name = "optbtnlaptop";
            this.optbtnlaptop.Size = new System.Drawing.Size(94, 17);
            this.optbtnlaptop.TabIndex = 180;
            this.optbtnlaptop.TabStop = true;
            this.optbtnlaptop.Text = "COMPUTER";
            this.optbtnlaptop.UseVisualStyleBackColor = false;
            // 
            // lblsuf
            // 
            this.lblsuf.AutoSize = true;
            this.lblsuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblsuf.ForeColor = System.Drawing.Color.Black;
            this.lblsuf.Location = new System.Drawing.Point(17, 237);
            this.lblsuf.Name = "lblsuf";
            this.lblsuf.Size = new System.Drawing.Size(39, 13);
            this.lblsuf.TabIndex = 175;
            this.lblsuf.Text = "Suffix";
            // 
            // lblsur
            // 
            this.lblsur.AutoSize = true;
            this.lblsur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblsur.ForeColor = System.Drawing.Color.Black;
            this.lblsur.Location = new System.Drawing.Point(13, 205);
            this.lblsur.Name = "lblsur";
            this.lblsur.Size = new System.Drawing.Size(65, 13);
            this.lblsur.TabIndex = 174;
            this.lblsur.Text = "Lastname:";
            // 
            // lblmname
            // 
            this.lblmname.AutoSize = true;
            this.lblmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblmname.ForeColor = System.Drawing.Color.Black;
            this.lblmname.Location = new System.Drawing.Point(13, 179);
            this.lblmname.Name = "lblmname";
            this.lblmname.Size = new System.Drawing.Size(84, 13);
            this.lblmname.TabIndex = 173;
            this.lblmname.Text = "Middle Name:";
            // 
            // lbltransno
            // 
            this.lbltransno.AutoSize = true;
            this.lbltransno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbltransno.ForeColor = System.Drawing.Color.Black;
            this.lbltransno.Location = new System.Drawing.Point(13, 113);
            this.lbltransno.Name = "lbltransno";
            this.lbltransno.Size = new System.Drawing.Size(98, 13);
            this.lbltransno.TabIndex = 172;
            this.lbltransno.Text = "Transaction No:";
            // 
            // lblhomeaddress
            // 
            this.lblhomeaddress.AutoSize = true;
            this.lblhomeaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblhomeaddress.ForeColor = System.Drawing.Color.Black;
            this.lblhomeaddress.Location = new System.Drawing.Point(15, 296);
            this.lblhomeaddress.Name = "lblhomeaddress";
            this.lblhomeaddress.Size = new System.Drawing.Size(92, 13);
            this.lblhomeaddress.TabIndex = 171;
            this.lblhomeaddress.Text = "Home Address:";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblfirstname.ForeColor = System.Drawing.Color.Black;
            this.lblfirstname.Location = new System.Drawing.Point(15, 150);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(65, 13);
            this.lblfirstname.TabIndex = 169;
            this.lblfirstname.Text = "Firstname:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(27, 12);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(29, 13);
            this.lblAdd.TabIndex = 36;
            this.lblAdd.Text = "Add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblphoneno
            // 
            this.lblphoneno.AutoSize = true;
            this.lblphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblphoneno.ForeColor = System.Drawing.Color.Black;
            this.lblphoneno.Location = new System.Drawing.Point(13, 269);
            this.lblphoneno.Name = "lblphoneno";
            this.lblphoneno.Size = new System.Drawing.Size(94, 13);
            this.lblphoneno.TabIndex = 170;
            this.lblphoneno.Text = "Phone Number:";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(867, 8);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(36, 13);
            this.lblBack.TabIndex = 168;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.lblReset);
            this.pnlControl.Controls.Add(this.lblArchive);
            this.pnlControl.Controls.Add(this.lblAdd);
            this.pnlControl.Location = new System.Drawing.Point(77, 345);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(215, 35);
            this.pnlControl.TabIndex = 167;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(154, 12);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(40, 13);
            this.lblReset.TabIndex = 90;
            this.lblReset.Text = "Reset";
            // 
            // lblArchive
            // 
            this.lblArchive.AutoSize = true;
            this.lblArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchive.Location = new System.Drawing.Point(86, 12);
            this.lblArchive.Name = "lblArchive";
            this.lblArchive.Size = new System.Drawing.Size(50, 13);
            this.lblArchive.TabIndex = 37;
            this.lblArchive.Text = "Archive";
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(354, 269);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(568, 149);
            this.dtGridView.TabIndex = 166;
            this.dtGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGridView_CellFormatting);
            // 
            // picboxRms
            // 
            this.picboxRms.BackColor = System.Drawing.Color.Transparent;
            this.picboxRms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxRms.BackgroundImage")));
            this.picboxRms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxRms.Location = new System.Drawing.Point(3, 5);
            this.picboxRms.Name = "picboxRms";
            this.picboxRms.Size = new System.Drawing.Size(48, 26);
            this.picboxRms.TabIndex = 156;
            this.picboxRms.TabStop = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(411, 70);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(64, 16);
            this.lblService.TabIndex = 165;
            this.lblService.Text = "Service:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(360, 44);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 42);
            this.lbl2.TabIndex = 164;
            this.lbl2.Text = "2.";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(58, 68);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(156, 16);
            this.lblCustomer.TabIndex = 161;
            this.lblCustomer.Text = "Customer Information:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("The Bold Font", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(9, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(43, 42);
            this.lbl1.TabIndex = 160;
            this.lbl1.Text = "1.";
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTransactionNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransactionNo.Location = new System.Drawing.Point(129, 113);
            this.txtTransactionNo.Multiline = true;
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.ReadOnly = true;
            this.txtTransactionNo.Size = new System.Drawing.Size(204, 20);
            this.txtTransactionNo.TabIndex = 163;
            // 
            // lblSignout
            // 
            this.lblSignout.AutoSize = true;
            this.lblSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignout.Location = new System.Drawing.Point(737, 8);
            this.lblSignout.Name = "lblSignout";
            this.lblSignout.Size = new System.Drawing.Size(56, 13);
            this.lblSignout.TabIndex = 157;
            this.lblSignout.Text = "Sign Out";
            this.lblSignout.Click += new System.EventHandler(this.lblSignout_Click);
            // 
            // dtpstart
            // 
            this.dtpstart.CustomFormat = "yyyy-MM-dd";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstart.Location = new System.Drawing.Point(447, 345);
            this.dtpstart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(143, 20);
            this.dtpstart.TabIndex = 176;
            // 
            // picboxTrans
            // 
            this.picboxTrans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxTrans.BackgroundImage")));
            this.picboxTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxTrans.Location = new System.Drawing.Point(-4, 35);
            this.picboxTrans.Name = "picboxTrans";
            this.picboxTrans.Size = new System.Drawing.Size(936, 405);
            this.picboxTrans.TabIndex = 162;
            this.picboxTrans.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(812, 8);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 13);
            this.lblExit.TabIndex = 158;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 206;
            this.label2.Text = "Records";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 207;
            this.label3.Text = "Records";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Add_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.lbltodate);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdeviceinfo);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtsuf);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.txtmn);
            this.Controls.Add(this.cbopay);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.cbotrans);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.optbtnphone);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optbtnlaptop);
            this.Controls.Add(this.lblsuf);
            this.Controls.Add(this.lblsur);
            this.Controls.Add(this.lblmname);
            this.Controls.Add(this.lbltransno);
            this.Controls.Add(this.lblhomeaddress);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lblphoneno);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.picboxRms);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTransactionNo);
            this.Controls.Add(this.lblSignout);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.picboxTrans);
            this.Controls.Add(this.lblExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Transaction";
            this.Load += new System.EventHandler(this.Add_Transaction_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Add_Transaction_Paint);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lbltodate;
        private System.Windows.Forms.Label lblPrint;
        public System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtdeviceinfo;
        public System.Windows.Forms.TextBox txtPhoneNumber;
        public System.Windows.Forms.TextBox txtHomeAddress;
        public System.Windows.Forms.TextBox txtsuf;
        public System.Windows.Forms.TextBox txtfn;
        public System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.ComboBox cbopay;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.ComboBox cbotrans;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Timer tmr;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RadioButton optbtnphone;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optbtnlaptop;
        private System.Windows.Forms.Label lblsuf;
        private System.Windows.Forms.Label lblsur;
        private System.Windows.Forms.Label lblmname;
        private System.Windows.Forms.Label lbltransno;
        private System.Windows.Forms.Label lblhomeaddress;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblphoneno;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label lblArchive;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.PictureBox picboxRms;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.TextBox txtTransactionNo;
        private System.Windows.Forms.Label lblSignout;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.PictureBox picboxTrans;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}