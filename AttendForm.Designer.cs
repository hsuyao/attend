
namespace Attend;

partial class AttendForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendForm));
        tabControl2 = new TabControl();
        tabPage5 = new TabPage();
        label4 = new Label();
        tbFontSize = new TextBox();
        ckbFwdBwd = new CheckBox();
        cbIgnoreNoData = new CheckBox();
        cbIgnoreElementarySchool = new CheckBox();
        ckbCompare = new CheckBox();
        label6 = new Label();
        label5 = new Label();
        txtbIgnoreLevel = new TextBox();
        label3 = new Label();
        txtBoxStable = new TextBox();
        label2 = new Label();
        label1 = new Label();
        txtBoxStartColumn = new TextBox();
        tabPage6 = new TabPage();
        groupBox2 = new GroupBox();
        tbSheet4Cat3 = new TextBox();
        tbSheet3Cat3 = new TextBox();
        tbSheet2Cat3 = new TextBox();
        tbSheet1Cat3 = new TextBox();
        label14 = new Label();
        tbSheet4Cat2 = new TextBox();
        tbSheet4Cat1 = new TextBox();
        label15 = new Label();
        tbSheet3Cat2 = new TextBox();
        tbSheet3Cat1 = new TextBox();
        label16 = new Label();
        tbSheet2Cat2 = new TextBox();
        tbSheet2Cat1 = new TextBox();
        label17 = new Label();
        tbSheet1Cat2 = new TextBox();
        tbSheet1Cat1 = new TextBox();
        groupBox3 = new GroupBox();
        label13 = new Label();
        tbSheet4WeekCat2 = new TextBox();
        tbSheet4WeekCat1 = new TextBox();
        label12 = new Label();
        tbSheet3WeekCat2 = new TextBox();
        tbSheet3WeekCat1 = new TextBox();
        label11 = new Label();
        tbSheet2WeekCat2 = new TextBox();
        tbSheet2WeekCat1 = new TextBox();
        label10 = new Label();
        tbSheet1WeekCat2 = new TextBox();
        tbSheet1WeekCat1 = new TextBox();
        rbWeek = new RadioButton();
        rbMonth = new RadioButton();
        rbHalfYear = new RadioButton();
        groupBox1 = new GroupBox();
        tbSelfDefWeek = new TextBox();
        rbSelfDef = new RadioButton();
        btnCalculateAllExcel = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        dataGridView1 = new DataGridView();
        panel1 = new Panel();
        btnRemoveFile = new Button();
        lbFileInfo = new ListBox();
        btnAddNewFile = new Button();
        tabControl2.SuspendLayout();
        tabPage5.SuspendLayout();
        tabPage6.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl2
        // 
        tabControl2.Controls.Add(tabPage5);
        tabControl2.Controls.Add(tabPage6);
        tabControl2.Location = new Point(437, 3);
        tabControl2.Name = "tabControl2";
        tabControl2.SelectedIndex = 0;
        tabControl2.Size = new Size(546, 155);
        tabControl2.TabIndex = 38;
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(label4);
        tabPage5.Controls.Add(tbFontSize);
        tabPage5.Controls.Add(ckbFwdBwd);
        tabPage5.Controls.Add(cbIgnoreNoData);
        tabPage5.Controls.Add(cbIgnoreElementarySchool);
        tabPage5.Controls.Add(ckbCompare);
        tabPage5.Controls.Add(label6);
        tabPage5.Controls.Add(label5);
        tabPage5.Controls.Add(txtbIgnoreLevel);
        tabPage5.Controls.Add(label3);
        tabPage5.Controls.Add(txtBoxStable);
        tabPage5.Controls.Add(label2);
        tabPage5.Controls.Add(label1);
        tabPage5.Controls.Add(txtBoxStartColumn);
        tabPage5.Location = new Point(4, 24);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(538, 127);
        tabPage5.TabIndex = 0;
        tabPage5.Text = "參數";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(342, 12);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(58, 15);
        label4.TabIndex = 29;
        label4.Text = "字體大小:";
        // 
        // tbFontSize
        // 
        tbFontSize.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
        tbFontSize.Location = new Point(404, 5);
        tbFontSize.Margin = new Padding(2);
        tbFontSize.Name = "tbFontSize";
        tbFontSize.Size = new Size(33, 24);
        tbFontSize.TabIndex = 28;
        tbFontSize.Text = "12";
        tbFontSize.TextAlign = HorizontalAlignment.Center;
        // 
        // ckbFwdBwd
        // 
        ckbFwdBwd.AutoSize = true;
        ckbFwdBwd.Checked = true;
        ckbFwdBwd.CheckState = CheckState.Checked;
        ckbFwdBwd.Location = new Point(170, 89);
        ckbFwdBwd.Name = "ckbFwdBwd";
        ckbFwdBwd.Size = new Size(152, 19);
        ckbFwdBwd.TabIndex = 27;
        ckbFwdBwd.Text = "向後統計: 半年、自訂週";
        ckbFwdBwd.UseVisualStyleBackColor = true;
        // 
        // cbIgnoreNoData
        // 
        cbIgnoreNoData.AutoSize = true;
        cbIgnoreNoData.Checked = true;
        cbIgnoreNoData.CheckState = CheckState.Checked;
        cbIgnoreNoData.Location = new Point(170, 37);
        cbIgnoreNoData.Name = "cbIgnoreNoData";
        cbIgnoreNoData.Size = new Size(170, 19);
        cbIgnoreNoData.TabIndex = 26;
        cbIgnoreNoData.Text = "忽略無資訊的最新紀錄日期";
        cbIgnoreNoData.UseVisualStyleBackColor = true;
        // 
        // cbIgnoreElementarySchool
        // 
        cbIgnoreElementarySchool.AutoSize = true;
        cbIgnoreElementarySchool.Checked = true;
        cbIgnoreElementarySchool.CheckState = CheckState.Checked;
        cbIgnoreElementarySchool.Location = new Point(170, 10);
        cbIgnoreElementarySchool.Name = "cbIgnoreElementarySchool";
        cbIgnoreElementarySchool.Size = new Size(134, 19);
        cbIgnoreElementarySchool.TabIndex = 25;
        cbIgnoreElementarySchool.Text = "小學未受浸納入總計";
        cbIgnoreElementarySchool.UseVisualStyleBackColor = true;
        // 
        // ckbCompare
        // 
        ckbCompare.AutoSize = true;
        ckbCompare.Checked = true;
        ckbCompare.CheckState = CheckState.Checked;
        ckbCompare.Location = new Point(170, 64);
        ckbCompare.Name = "ckbCompare";
        ckbCompare.Size = new Size(122, 19);
        ckbCompare.TabIndex = 24;
        ckbCompare.Text = "比較前後統計週期";
        ckbCompare.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(101, 44);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(45, 15);
        label6.TabIndex = 23;
        label6.Text = "% 剔除";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(135, 12);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(18, 15);
        label5.TabIndex = 22;
        label5.Text = "%";
        // 
        // txtbIgnoreLevel
        // 
        txtbIgnoreLevel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
        txtbIgnoreLevel.Location = new Point(73, 42);
        txtbIgnoreLevel.Margin = new Padding(2);
        txtbIgnoreLevel.Name = "txtbIgnoreLevel";
        txtbIgnoreLevel.Size = new Size(31, 23);
        txtbIgnoreLevel.TabIndex = 21;
        txtbIgnoreLevel.Text = "40";
        txtbIgnoreLevel.TextAlign = HorizontalAlignment.Center;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(5, 44);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(67, 15);
        label3.TabIndex = 20;
        label3.Text = "低於中位數";
        // 
        // txtBoxStable
        // 
        txtBoxStable.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
        txtBoxStable.Location = new Point(103, 10);
        txtBoxStable.Margin = new Padding(2);
        txtBoxStable.Name = "txtBoxStable";
        txtBoxStable.Size = new Size(29, 23);
        txtBoxStable.TabIndex = 19;
        txtBoxStable.Text = "40";
        txtBoxStable.TextAlign = HorizontalAlignment.Center;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(5, 12);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(94, 15);
        label2.TabIndex = 18;
        label2.Text = "穩定聚會出席率:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(5, 73);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(106, 15);
        label1.TabIndex = 16;
        label1.Text = "出席紀錄開始欄位:";
        // 
        // txtBoxStartColumn
        // 
        txtBoxStartColumn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
        txtBoxStartColumn.Location = new Point(115, 68);
        txtBoxStartColumn.Margin = new Padding(2);
        txtBoxStartColumn.Name = "txtBoxStartColumn";
        txtBoxStartColumn.Size = new Size(41, 24);
        txtBoxStartColumn.TabIndex = 17;
        txtBoxStartColumn.Text = "I";
        txtBoxStartColumn.TextAlign = HorizontalAlignment.Center;
        // 
        // tabPage6
        // 
        tabPage6.Controls.Add(groupBox2);
        tabPage6.Controls.Add(groupBox3);
        tabPage6.Location = new Point(4, 24);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3);
        tabPage6.Size = new Size(538, 127);
        tabPage6.TabIndex = 1;
        tabPage6.Text = "分類文字";
        tabPage6.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(tbSheet4Cat3);
        groupBox2.Controls.Add(tbSheet3Cat3);
        groupBox2.Controls.Add(tbSheet2Cat3);
        groupBox2.Controls.Add(tbSheet1Cat3);
        groupBox2.Controls.Add(label14);
        groupBox2.Controls.Add(tbSheet4Cat2);
        groupBox2.Controls.Add(tbSheet4Cat1);
        groupBox2.Controls.Add(label15);
        groupBox2.Controls.Add(tbSheet3Cat2);
        groupBox2.Controls.Add(tbSheet3Cat1);
        groupBox2.Controls.Add(label16);
        groupBox2.Controls.Add(tbSheet2Cat2);
        groupBox2.Controls.Add(tbSheet2Cat1);
        groupBox2.Controls.Add(label17);
        groupBox2.Controls.Add(tbSheet1Cat2);
        groupBox2.Controls.Add(tbSheet1Cat1);
        groupBox2.Location = new Point(221, 6);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(307, 119);
        groupBox2.TabIndex = 40;
        groupBox2.TabStop = false;
        groupBox2.Text = "週以上";
        // 
        // tbSheet4Cat3
        // 
        tbSheet4Cat3.Location = new Point(221, 93);
        tbSheet4Cat3.Name = "tbSheet4Cat3";
        tbSheet4Cat3.Size = new Size(75, 23);
        tbSheet4Cat3.TabIndex = 43;
        tbSheet4Cat3.Text = "無紀錄";
        // 
        // tbSheet3Cat3
        // 
        tbSheet3Cat3.Location = new Point(221, 67);
        tbSheet3Cat3.Name = "tbSheet3Cat3";
        tbSheet3Cat3.Size = new Size(75, 23);
        tbSheet3Cat3.TabIndex = 42;
        tbSheet3Cat3.Text = "無紀錄";
        // 
        // tbSheet2Cat3
        // 
        tbSheet2Cat3.Location = new Point(221, 42);
        tbSheet2Cat3.Name = "tbSheet2Cat3";
        tbSheet2Cat3.Size = new Size(75, 23);
        tbSheet2Cat3.TabIndex = 41;
        tbSheet2Cat3.Text = "無紀錄";
        // 
        // tbSheet1Cat3
        // 
        tbSheet1Cat3.Location = new Point(221, 16);
        tbSheet1Cat3.Name = "tbSheet1Cat3";
        tbSheet1Cat3.Size = new Size(75, 23);
        tbSheet1Cat3.TabIndex = 40;
        tbSheet1Cat3.Text = "無紀錄";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(6, 97);
        label14.Name = "label14";
        label14.Size = new Size(34, 15);
        label14.TabIndex = 39;
        label14.Text = "晨興:";
        // 
        // tbSheet4Cat2
        // 
        tbSheet4Cat2.Location = new Point(133, 93);
        tbSheet4Cat2.Name = "tbSheet4Cat2";
        tbSheet4Cat2.Size = new Size(82, 23);
        tbSheet4Cat2.TabIndex = 38;
        tbSheet4Cat2.Text = "不穩定";
        // 
        // tbSheet4Cat1
        // 
        tbSheet4Cat1.Location = new Point(53, 94);
        tbSheet4Cat1.Name = "tbSheet4Cat1";
        tbSheet4Cat1.Size = new Size(74, 23);
        tbSheet4Cat1.TabIndex = 37;
        tbSheet4Cat1.Text = "穩定";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(6, 71);
        label15.Name = "label15";
        label15.Size = new Size(34, 15);
        label15.TabIndex = 36;
        label15.Text = "小排:";
        // 
        // tbSheet3Cat2
        // 
        tbSheet3Cat2.Location = new Point(133, 67);
        tbSheet3Cat2.Name = "tbSheet3Cat2";
        tbSheet3Cat2.Size = new Size(82, 23);
        tbSheet3Cat2.TabIndex = 35;
        tbSheet3Cat2.Text = "不穩定";
        // 
        // tbSheet3Cat1
        // 
        tbSheet3Cat1.Location = new Point(53, 68);
        tbSheet3Cat1.Name = "tbSheet3Cat1";
        tbSheet3Cat1.Size = new Size(74, 23);
        tbSheet3Cat1.TabIndex = 34;
        tbSheet3Cat1.Text = "穩定聚會";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(6, 46);
        label16.Name = "label16";
        label16.Size = new Size(34, 15);
        label16.TabIndex = 33;
        label16.Text = "禱告:";
        // 
        // tbSheet2Cat2
        // 
        tbSheet2Cat2.Location = new Point(133, 42);
        tbSheet2Cat2.Name = "tbSheet2Cat2";
        tbSheet2Cat2.Size = new Size(82, 23);
        tbSheet2Cat2.TabIndex = 32;
        tbSheet2Cat2.Text = "不穩定";
        // 
        // tbSheet2Cat1
        // 
        tbSheet2Cat1.Location = new Point(53, 43);
        tbSheet2Cat1.Name = "tbSheet2Cat1";
        tbSheet2Cat1.Size = new Size(74, 23);
        tbSheet2Cat1.TabIndex = 31;
        tbSheet2Cat1.Text = "穩定聚會";
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(6, 20);
        label17.Name = "label17";
        label17.Size = new Size(34, 15);
        label17.TabIndex = 30;
        label17.Text = "主日:";
        // 
        // tbSheet1Cat2
        // 
        tbSheet1Cat2.Location = new Point(133, 16);
        tbSheet1Cat2.Name = "tbSheet1Cat2";
        tbSheet1Cat2.Size = new Size(82, 23);
        tbSheet1Cat2.TabIndex = 2;
        tbSheet1Cat2.Text = "不穩定";
        // 
        // tbSheet1Cat1
        // 
        tbSheet1Cat1.Location = new Point(53, 17);
        tbSheet1Cat1.Name = "tbSheet1Cat1";
        tbSheet1Cat1.Size = new Size(74, 23);
        tbSheet1Cat1.TabIndex = 0;
        tbSheet1Cat1.Text = "穩定聚會";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label13);
        groupBox3.Controls.Add(tbSheet4WeekCat2);
        groupBox3.Controls.Add(tbSheet4WeekCat1);
        groupBox3.Controls.Add(label12);
        groupBox3.Controls.Add(tbSheet3WeekCat2);
        groupBox3.Controls.Add(tbSheet3WeekCat1);
        groupBox3.Controls.Add(label11);
        groupBox3.Controls.Add(tbSheet2WeekCat2);
        groupBox3.Controls.Add(tbSheet2WeekCat1);
        groupBox3.Controls.Add(label10);
        groupBox3.Controls.Add(tbSheet1WeekCat2);
        groupBox3.Controls.Add(tbSheet1WeekCat1);
        groupBox3.Location = new Point(6, 5);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(209, 119);
        groupBox3.TabIndex = 38;
        groupBox3.TabStop = false;
        groupBox3.Text = "週";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(6, 97);
        label13.Name = "label13";
        label13.Size = new Size(34, 15);
        label13.TabIndex = 39;
        label13.Text = "晨興:";
        // 
        // tbSheet4WeekCat2
        // 
        tbSheet4WeekCat2.Location = new Point(124, 94);
        tbSheet4WeekCat2.Name = "tbSheet4WeekCat2";
        tbSheet4WeekCat2.Size = new Size(60, 23);
        tbSheet4WeekCat2.TabIndex = 38;
        tbSheet4WeekCat2.Text = "無紀錄";
        // 
        // tbSheet4WeekCat1
        // 
        tbSheet4WeekCat1.Location = new Point(53, 94);
        tbSheet4WeekCat1.Name = "tbSheet4WeekCat1";
        tbSheet4WeekCat1.Size = new Size(65, 23);
        tbSheet4WeekCat1.TabIndex = 37;
        tbSheet4WeekCat1.Text = "本週有紀錄";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(6, 71);
        label12.Name = "label12";
        label12.Size = new Size(34, 15);
        label12.TabIndex = 36;
        label12.Text = "小排:";
        // 
        // tbSheet3WeekCat2
        // 
        tbSheet3WeekCat2.Location = new Point(124, 68);
        tbSheet3WeekCat2.Name = "tbSheet3WeekCat2";
        tbSheet3WeekCat2.Size = new Size(60, 23);
        tbSheet3WeekCat2.TabIndex = 35;
        tbSheet3WeekCat2.Text = "未到會";
        // 
        // tbSheet3WeekCat1
        // 
        tbSheet3WeekCat1.Location = new Point(53, 68);
        tbSheet3WeekCat1.Name = "tbSheet3WeekCat1";
        tbSheet3WeekCat1.Size = new Size(65, 23);
        tbSheet3WeekCat1.TabIndex = 34;
        tbSheet3WeekCat1.Text = "本週到會";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(6, 46);
        label11.Name = "label11";
        label11.Size = new Size(34, 15);
        label11.TabIndex = 33;
        label11.Text = "禱告:";
        // 
        // tbSheet2WeekCat2
        // 
        tbSheet2WeekCat2.Location = new Point(124, 43);
        tbSheet2WeekCat2.Name = "tbSheet2WeekCat2";
        tbSheet2WeekCat2.Size = new Size(60, 23);
        tbSheet2WeekCat2.TabIndex = 32;
        tbSheet2WeekCat2.Text = "未到會";
        // 
        // tbSheet2WeekCat1
        // 
        tbSheet2WeekCat1.Location = new Point(53, 43);
        tbSheet2WeekCat1.Name = "tbSheet2WeekCat1";
        tbSheet2WeekCat1.Size = new Size(65, 23);
        tbSheet2WeekCat1.TabIndex = 31;
        tbSheet2WeekCat1.Text = "本週到會";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(6, 20);
        label10.Name = "label10";
        label10.Size = new Size(34, 15);
        label10.TabIndex = 30;
        label10.Text = "主日:";
        // 
        // tbSheet1WeekCat2
        // 
        tbSheet1WeekCat2.Location = new Point(124, 17);
        tbSheet1WeekCat2.Name = "tbSheet1WeekCat2";
        tbSheet1WeekCat2.Size = new Size(60, 23);
        tbSheet1WeekCat2.TabIndex = 2;
        tbSheet1WeekCat2.Text = "未到會";
        // 
        // tbSheet1WeekCat1
        // 
        tbSheet1WeekCat1.Location = new Point(53, 17);
        tbSheet1WeekCat1.Name = "tbSheet1WeekCat1";
        tbSheet1WeekCat1.Size = new Size(65, 23);
        tbSheet1WeekCat1.TabIndex = 0;
        tbSheet1WeekCat1.Text = "本週到會";
        // 
        // rbWeek
        // 
        rbWeek.AutoSize = true;
        rbWeek.Checked = true;
        rbWeek.Location = new Point(16, 27);
        rbWeek.Name = "rbWeek";
        rbWeek.Size = new Size(37, 19);
        rbWeek.TabIndex = 9;
        rbWeek.TabStop = true;
        rbWeek.Text = "週";
        rbWeek.UseVisualStyleBackColor = true;
        // 
        // rbMonth
        // 
        rbMonth.AutoSize = true;
        rbMonth.Location = new Point(16, 52);
        rbMonth.Name = "rbMonth";
        rbMonth.Size = new Size(93, 19);
        rbMonth.TabIndex = 10;
        rbMonth.Text = "月(四到五週)";
        rbMonth.UseVisualStyleBackColor = true;
        // 
        // rbHalfYear
        // 
        rbHalfYear.AutoSize = true;
        rbHalfYear.Location = new Point(16, 77);
        rbHalfYear.Name = "rbHalfYear";
        rbHalfYear.Size = new Size(83, 19);
        rbHalfYear.TabIndex = 11;
        rbHalfYear.Text = "半年(26週)";
        rbHalfYear.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tbSelfDefWeek);
        groupBox1.Controls.Add(rbSelfDef);
        groupBox1.Controls.Add(rbHalfYear);
        groupBox1.Controls.Add(rbMonth);
        groupBox1.Controls.Add(rbWeek);
        groupBox1.Location = new Point(292, 12);
        groupBox1.Margin = new Padding(2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(2);
        groupBox1.Size = new Size(141, 146);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "統計單位";
        // 
        // tbSelfDefWeek
        // 
        tbSelfDefWeek.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
        tbSelfDefWeek.Location = new Point(63, 98);
        tbSelfDefWeek.Margin = new Padding(2);
        tbSelfDefWeek.Name = "tbSelfDefWeek";
        tbSelfDefWeek.Size = new Size(19, 23);
        tbSelfDefWeek.TabIndex = 27;
        tbSelfDefWeek.Text = "8";
        tbSelfDefWeek.TextAlign = HorizontalAlignment.Center;
        // 
        // rbSelfDef
        // 
        rbSelfDef.AutoSize = true;
        rbSelfDef.Location = new Point(16, 102);
        rbSelfDef.Name = "rbSelfDef";
        rbSelfDef.Size = new Size(88, 19);
        rbSelfDef.TabIndex = 12;
        rbSelfDef.Text = "自訂         週";
        rbSelfDef.UseVisualStyleBackColor = true;
        // 
        // btnCalculateAllExcel
        // 
        btnCalculateAllExcel.BackColor = SystemColors.ActiveCaption;
        btnCalculateAllExcel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
        btnCalculateAllExcel.Location = new Point(246, 8);
        btnCalculateAllExcel.Margin = new Padding(2);
        btnCalculateAllExcel.Name = "btnCalculateAllExcel";
        btnCalculateAllExcel.Size = new Size(42, 153);
        btnCalculateAllExcel.TabIndex = 36;
        btnCalculateAllExcel.Text = "統計已選擇檔案";
        btnCalculateAllExcel.UseVisualStyleBackColor = false;
        btnCalculateAllExcel.Click += btnCalculateAllExcel_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
        tableLayoutPanel1.Controls.Add(panel1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(1075, 524);
        tableLayoutPanel1.TabIndex = 39;
        // 
        // tabControl1
        // 
        tabControl1.Appearance = TabAppearance.FlatButtons;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
        tabControl1.Location = new Point(2, 182);
        tabControl1.Margin = new Padding(2);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1071, 340);
        tabControl1.TabIndex = 29;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(dataGridView1);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1063, 307);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "統計結果";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(3, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1057, 301);
        dataGridView1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnRemoveFile);
        panel1.Controls.Add(lbFileInfo);
        panel1.Controls.Add(btnAddNewFile);
        panel1.Controls.Add(tabControl2);
        panel1.Controls.Add(groupBox1);
        panel1.Controls.Add(btnCalculateAllExcel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(1069, 174);
        panel1.TabIndex = 0;
        // 
        // btnRemoveFile
        // 
        btnRemoveFile.BackColor = SystemColors.ActiveCaption;
        btnRemoveFile.Location = new Point(126, 9);
        btnRemoveFile.Name = "btnRemoveFile";
        btnRemoveFile.Size = new Size(115, 25);
        btnRemoveFile.TabIndex = 41;
        btnRemoveFile.Text = "移除檔案";
        btnRemoveFile.UseVisualStyleBackColor = false;
        btnRemoveFile.Click += btnRemoveFile_Click;
        // 
        // lbFileInfo
        // 
        lbFileInfo.FormattingEnabled = true;
        lbFileInfo.ItemHeight = 15;
        lbFileInfo.Location = new Point(9, 37);
        lbFileInfo.Name = "lbFileInfo";
        lbFileInfo.Size = new Size(232, 124);
        lbFileInfo.TabIndex = 40;
        // 
        // btnAddNewFile
        // 
        btnAddNewFile.BackColor = SystemColors.ActiveCaption;
        btnAddNewFile.Location = new Point(9, 9);
        btnAddNewFile.Name = "btnAddNewFile";
        btnAddNewFile.Size = new Size(111, 25);
        btnAddNewFile.TabIndex = 39;
        btnAddNewFile.Text = "新增檔案";
        btnAddNewFile.UseVisualStyleBackColor = false;
        btnAddNewFile.Click += btnAddNewFile_Click;
        // 
        // AttendForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1075, 524);
        Controls.Add(tableLayoutPanel1);
        Name = "AttendForm";
        Text = "點名系統表單整理小幫手 v1.0 20240520";
        FormClosing += AttendForm_FormClosing;
        Load += AttendForm_Load;
        SizeChanged += AttendForm_SizeChanged;
        tabControl2.ResumeLayout(false);
        tabPage5.ResumeLayout(false);
        tabPage5.PerformLayout();
        tabPage6.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
       // OpenExcelFile(filenames[0], txtBoxSelect1.Text + ".xlsx", dgvResult1);
        MessageBox.Show("Finished!");
    }

#endregion
    private TabControl tabControl2;
    private TabPage tabPage5;
    private CheckBox cbIgnoreNoData;
    private CheckBox cbIgnoreElementarySchool;
    private CheckBox ckbCompare;
    private Label label6;
    private Label label5;
    private TextBox txtbIgnoreLevel;
    private Label label3;
    private TextBox txtBoxStable;
    private Label label2;
    private Label label1;
    private TextBox txtBoxStartColumn;
    private TabPage tabPage6;
    private GroupBox groupBox3;
    private TextBox tbSheet1WeekCat2;
    private TextBox tbSheet1WeekCat1;
    private GroupBox groupBox2;
    private TextBox tbSheet4Cat3;
    private TextBox tbSheet3Cat3;
    private TextBox tbSheet2Cat3;
    private TextBox tbSheet1Cat3;
    private Label label14;
    private TextBox tbSheet4Cat2;
    private TextBox tbSheet4Cat1;
    private Label label15;
    private TextBox tbSheet3Cat2;
    private TextBox tbSheet3Cat1;
    private Label label16;
    private TextBox tbSheet2Cat2;
    private TextBox tbSheet2Cat1;
    private Label label17;
    private TextBox tbSheet1Cat2;
    private TextBox tbSheet1Cat1;
    private Label label13;
    private TextBox tbSheet4WeekCat2;
    private TextBox tbSheet4WeekCat1;
    private Label label12;
    private TextBox tbSheet3WeekCat2;
    private TextBox tbSheet3WeekCat1;
    private Label label11;
    private TextBox tbSheet2WeekCat2;
    private TextBox tbSheet2WeekCat1;
    private Label label10;
    private RadioButton rbWeek;
    private RadioButton rbMonth;
    private RadioButton rbHalfYear;
    private GroupBox groupBox1;
    private Button btnCalculateAllExcel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private TabControl tabControl1;
    private TextBox tbSelfDefWeek;
    private RadioButton rbSelfDef;
    private CheckBox ckbFwdBwd;
    private Label label4;
    private TextBox tbFontSize;
    private Button btnAddNewFile;
    private ListBox lbFileInfo;
    private Button btnRemoveFile;
    private TabPage tabPage1;
    private DataGridView dataGridView1;
}
