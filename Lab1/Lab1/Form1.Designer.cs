namespace Lab1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResPowerAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommPowerAmount = new System.Windows.Forms.TextBox();
            this.txtIndustPowerAmount = new System.Windows.Forms.TextBox();
            this.txtCommCost = new System.Windows.Forms.TextBox();
            this.txtIndustCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResFlatRate = new System.Windows.Forms.TextBox();
            this.txtCommFlatRate = new System.Windows.Forms.TextBox();
            this.txtPeakHourFlat = new System.Windows.Forms.TextBox();
            this.txtResRatePerHour = new System.Windows.Forms.TextBox();
            this.txtCommRatePerHour = new System.Windows.Forms.TextBox();
            this.txtPeakRate = new System.Windows.Forms.TextBox();
            this.formBox = new System.Windows.Forms.GroupBox();
            this.txtIndustNonPeakPowerAmount = new System.Windows.Forms.TextBox();
            this.txtIndustPeakPowerAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnResidential = new System.Windows.Forms.RadioButton();
            this.txtNonPeakHourFlat = new System.Windows.Forms.TextBox();
            this.txtNonPeakRate = new System.Windows.Forms.TextBox();
            this.txtPeakHourCost = new System.Windows.Forms.TextBox();
            this.txtNonPeakCost = new System.Windows.Forms.TextBox();
            this.formBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(20, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(917, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Cost";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(655, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 49);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Residential Customer :";
            // 
            // txtResPowerAmount
            // 
            this.txtResPowerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPowerAmount.Location = new System.Drawing.Point(305, 88);
            this.txtResPowerAmount.Name = "txtResPowerAmount";
            this.txtResPowerAmount.Size = new System.Drawing.Size(221, 35);
            this.txtResPowerAmount.TabIndex = 4;
            this.txtResPowerAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hours Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(939, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Cost";
            // 
            // txtResCost
            // 
            this.txtResCost.Enabled = false;
            this.txtResCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResCost.Location = new System.Drawing.Point(917, 88);
            this.txtResCost.Name = "txtResCost";
            this.txtResCost.Size = new System.Drawing.Size(184, 35);
            this.txtResCost.TabIndex = 7;
            this.txtResCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Industrial Customer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Commercial Customer :";
            // 
            // txtCommPowerAmount
            // 
            this.txtCommPowerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommPowerAmount.Location = new System.Drawing.Point(305, 165);
            this.txtCommPowerAmount.Name = "txtCommPowerAmount";
            this.txtCommPowerAmount.Size = new System.Drawing.Size(221, 35);
            this.txtCommPowerAmount.TabIndex = 10;
            this.txtCommPowerAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIndustPowerAmount
            // 
            this.txtIndustPowerAmount.Enabled = false;
            this.txtIndustPowerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustPowerAmount.Location = new System.Drawing.Point(305, 362);
            this.txtIndustPowerAmount.Name = "txtIndustPowerAmount";
            this.txtIndustPowerAmount.Size = new System.Drawing.Size(221, 35);
            this.txtIndustPowerAmount.TabIndex = 11;
            this.txtIndustPowerAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCommCost
            // 
            this.txtCommCost.Enabled = false;
            this.txtCommCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommCost.Location = new System.Drawing.Point(917, 165);
            this.txtCommCost.Name = "txtCommCost";
            this.txtCommCost.Size = new System.Drawing.Size(184, 35);
            this.txtCommCost.TabIndex = 12;
            this.txtCommCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIndustCost
            // 
            this.txtIndustCost.Enabled = false;
            this.txtIndustCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustCost.Location = new System.Drawing.Point(917, 362);
            this.txtIndustCost.Name = "txtIndustCost";
            this.txtIndustCost.Size = new System.Drawing.Size(184, 35);
            this.txtIndustCost.TabIndex = 13;
            this.txtIndustCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(940, 58);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cost Calculation for Power Usage Program";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(901, 96);
            this.label7.TabIndex = 15;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Flat Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(699, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Rate Per kWh";
            // 
            // txtResFlatRate
            // 
            this.txtResFlatRate.Enabled = false;
            this.txtResFlatRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResFlatRate.Location = new System.Drawing.Point(554, 88);
            this.txtResFlatRate.Name = "txtResFlatRate";
            this.txtResFlatRate.Size = new System.Drawing.Size(144, 35);
            this.txtResFlatRate.TabIndex = 18;
            this.txtResFlatRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCommFlatRate
            // 
            this.txtCommFlatRate.Enabled = false;
            this.txtCommFlatRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommFlatRate.Location = new System.Drawing.Point(554, 165);
            this.txtCommFlatRate.Name = "txtCommFlatRate";
            this.txtCommFlatRate.Size = new System.Drawing.Size(144, 35);
            this.txtCommFlatRate.TabIndex = 19;
            this.txtCommFlatRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeakHourFlat
            // 
            this.txtPeakHourFlat.Enabled = false;
            this.txtPeakHourFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakHourFlat.Location = new System.Drawing.Point(554, 266);
            this.txtPeakHourFlat.Name = "txtPeakHourFlat";
            this.txtPeakHourFlat.Size = new System.Drawing.Size(144, 35);
            this.txtPeakHourFlat.TabIndex = 20;
            this.txtPeakHourFlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResRatePerHour
            // 
            this.txtResRatePerHour.Enabled = false;
            this.txtResRatePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResRatePerHour.Location = new System.Drawing.Point(719, 88);
            this.txtResRatePerHour.Name = "txtResRatePerHour";
            this.txtResRatePerHour.Size = new System.Drawing.Size(144, 35);
            this.txtResRatePerHour.TabIndex = 21;
            this.txtResRatePerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCommRatePerHour
            // 
            this.txtCommRatePerHour.Enabled = false;
            this.txtCommRatePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommRatePerHour.Location = new System.Drawing.Point(719, 165);
            this.txtCommRatePerHour.Name = "txtCommRatePerHour";
            this.txtCommRatePerHour.Size = new System.Drawing.Size(144, 35);
            this.txtCommRatePerHour.TabIndex = 22;
            this.txtCommRatePerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeakRate
            // 
            this.txtPeakRate.Enabled = false;
            this.txtPeakRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakRate.Location = new System.Drawing.Point(719, 266);
            this.txtPeakRate.Name = "txtPeakRate";
            this.txtPeakRate.Size = new System.Drawing.Size(144, 35);
            this.txtPeakRate.TabIndex = 23;
            this.txtPeakRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formBox
            // 
            this.formBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.formBox.Controls.Add(this.txtNonPeakCost);
            this.formBox.Controls.Add(this.txtPeakHourCost);
            this.formBox.Controls.Add(this.txtNonPeakRate);
            this.formBox.Controls.Add(this.txtNonPeakHourFlat);
            this.formBox.Controls.Add(this.txtIndustNonPeakPowerAmount);
            this.formBox.Controls.Add(this.txtIndustPeakPowerAmount);
            this.formBox.Controls.Add(this.label11);
            this.formBox.Controls.Add(this.label10);
            this.formBox.Controls.Add(this.txtPeakRate);
            this.formBox.Controls.Add(this.txtCommRatePerHour);
            this.formBox.Controls.Add(this.txtResRatePerHour);
            this.formBox.Controls.Add(this.txtPeakHourFlat);
            this.formBox.Controls.Add(this.txtCommFlatRate);
            this.formBox.Controls.Add(this.btnExit);
            this.formBox.Controls.Add(this.txtResFlatRate);
            this.formBox.Controls.Add(this.label9);
            this.formBox.Controls.Add(this.label8);
            this.formBox.Controls.Add(this.txtIndustCost);
            this.formBox.Controls.Add(this.txtCommCost);
            this.formBox.Controls.Add(this.txtIndustPowerAmount);
            this.formBox.Controls.Add(this.txtCommPowerAmount);
            this.formBox.Controls.Add(this.label5);
            this.formBox.Controls.Add(this.label4);
            this.formBox.Controls.Add(this.txtResCost);
            this.formBox.Controls.Add(this.label3);
            this.formBox.Controls.Add(this.label2);
            this.formBox.Controls.Add(this.txtResPowerAmount);
            this.formBox.Controls.Add(this.label1);
            this.formBox.Controls.Add(this.btnClear);
            this.formBox.Controls.Add(this.button1);
            this.formBox.Location = new System.Drawing.Point(4, 238);
            this.formBox.Name = "formBox";
            this.formBox.Size = new System.Drawing.Size(1129, 484);
            this.formBox.TabIndex = 24;
            this.formBox.TabStop = false;
            // 
            // txtIndustNonPeakPowerAmount
            // 
            this.txtIndustNonPeakPowerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustNonPeakPowerAmount.Location = new System.Drawing.Point(305, 307);
            this.txtIndustNonPeakPowerAmount.Name = "txtIndustNonPeakPowerAmount";
            this.txtIndustNonPeakPowerAmount.Size = new System.Drawing.Size(221, 35);
            this.txtIndustNonPeakPowerAmount.TabIndex = 27;
            this.txtIndustNonPeakPowerAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIndustPeakPowerAmount
            // 
            this.txtIndustPeakPowerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustPeakPowerAmount.Location = new System.Drawing.Point(305, 266);
            this.txtIndustPeakPowerAmount.Name = "txtIndustPeakPowerAmount";
            this.txtIndustPeakPowerAmount.Size = new System.Drawing.Size(221, 35);
            this.txtIndustPeakPowerAmount.TabIndex = 26;
            this.txtIndustPeakPowerAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "Non-Peak Hours :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Peak Hours :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(946, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 117);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // optionBox
            // 
            this.optionBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.optionBox.Controls.Add(this.radioButton2);
            this.optionBox.Controls.Add(this.radioButton1);
            this.optionBox.Controls.Add(this.btnResidential);
            this.optionBox.Location = new System.Drawing.Point(4, 171);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(1129, 61);
            this.optionBox.TabIndex = 26;
            this.optionBox.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(815, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 46);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Industrial";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(451, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(233, 46);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Commercial";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnResidential
            // 
            this.btnResidential.AutoSize = true;
            this.btnResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidential.Location = new System.Drawing.Point(95, 9);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(221, 46);
            this.btnResidential.TabIndex = 0;
            this.btnResidential.TabStop = true;
            this.btnResidential.Text = "Residential";
            this.btnResidential.UseVisualStyleBackColor = true;
            // 
            // txtNonPeakHourFlat
            // 
            this.txtNonPeakHourFlat.Enabled = false;
            this.txtNonPeakHourFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonPeakHourFlat.Location = new System.Drawing.Point(554, 307);
            this.txtNonPeakHourFlat.Name = "txtNonPeakHourFlat";
            this.txtNonPeakHourFlat.Size = new System.Drawing.Size(144, 35);
            this.txtNonPeakHourFlat.TabIndex = 28;
            this.txtNonPeakHourFlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNonPeakRate
            // 
            this.txtNonPeakRate.Enabled = false;
            this.txtNonPeakRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonPeakRate.Location = new System.Drawing.Point(719, 307);
            this.txtNonPeakRate.Name = "txtNonPeakRate";
            this.txtNonPeakRate.Size = new System.Drawing.Size(144, 35);
            this.txtNonPeakRate.TabIndex = 29;
            this.txtNonPeakRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeakHourCost
            // 
            this.txtPeakHourCost.Enabled = false;
            this.txtPeakHourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakHourCost.Location = new System.Drawing.Point(917, 266);
            this.txtPeakHourCost.Name = "txtPeakHourCost";
            this.txtPeakHourCost.Size = new System.Drawing.Size(184, 35);
            this.txtPeakHourCost.TabIndex = 30;
            this.txtPeakHourCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNonPeakCost
            // 
            this.txtNonPeakCost.Enabled = false;
            this.txtNonPeakCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonPeakCost.Location = new System.Drawing.Point(917, 307);
            this.txtNonPeakCost.Name = "txtNonPeakCost";
            this.txtNonPeakCost.Size = new System.Drawing.Size(184, 35);
            this.txtNonPeakCost.TabIndex = 31;
            this.txtNonPeakCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 740);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.formBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.formBox.ResumeLayout(false);
            this.formBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionBox.ResumeLayout(false);
            this.optionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResPowerAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommPowerAmount;
        private System.Windows.Forms.TextBox txtIndustPowerAmount;
        private System.Windows.Forms.TextBox txtCommCost;
        private System.Windows.Forms.TextBox txtIndustCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResFlatRate;
        private System.Windows.Forms.TextBox txtCommFlatRate;
        private System.Windows.Forms.TextBox txtPeakHourFlat;
        private System.Windows.Forms.TextBox txtResRatePerHour;
        private System.Windows.Forms.TextBox txtCommRatePerHour;
        private System.Windows.Forms.TextBox txtPeakRate;
        private System.Windows.Forms.GroupBox formBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox optionBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnResidential;
        private System.Windows.Forms.TextBox txtIndustNonPeakPowerAmount;
        private System.Windows.Forms.TextBox txtIndustPeakPowerAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNonPeakCost;
        private System.Windows.Forms.TextBox txtPeakHourCost;
        private System.Windows.Forms.TextBox txtNonPeakRate;
        private System.Windows.Forms.TextBox txtNonPeakHourFlat;
    }
}

