namespace Vize
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_soru1 = new System.Windows.Forms.Label();
            this.lbl_mayin_sayisi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmrc_sure = new System.Windows.Forms.NumericUpDown();
            this.nmrc_mayin_sayisi = new System.Windows.Forms.NumericUpDown();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.lbl_kalan_sure = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.tlp_butonlar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_mayin_13 = new System.Windows.Forms.Button();
            this.btn_mayin_14 = new System.Windows.Forms.Button();
            this.btn_mayin_12 = new System.Windows.Forms.Button();
            this.btn_mayin_15 = new System.Windows.Forms.Button();
            this.btn_mayin_11 = new System.Windows.Forms.Button();
            this.btn_mayin_6 = new System.Windows.Forms.Button();
            this.btn_mayin_20 = new System.Windows.Forms.Button();
            this.btn_mayin_7 = new System.Windows.Forms.Button();
            this.btn_mayin_19 = new System.Windows.Forms.Button();
            this.btn_mayin_8 = new System.Windows.Forms.Button();
            this.btn_mayin_18 = new System.Windows.Forms.Button();
            this.btn_mayin_9 = new System.Windows.Forms.Button();
            this.btn_mayin_17 = new System.Windows.Forms.Button();
            this.btn_mayin_10 = new System.Windows.Forms.Button();
            this.btn_mayin_16 = new System.Windows.Forms.Button();
            this.btn_mayin_5 = new System.Windows.Forms.Button();
            this.btn_mayin_25 = new System.Windows.Forms.Button();
            this.btn_mayin_4 = new System.Windows.Forms.Button();
            this.btn_mayin_24 = new System.Windows.Forms.Button();
            this.btn_mayin_3 = new System.Windows.Forms.Button();
            this.btn_mayin_23 = new System.Windows.Forms.Button();
            this.btn_mayin_2 = new System.Windows.Forms.Button();
            this.btn_mayin_22 = new System.Windows.Forms.Button();
            this.btn_mayin_1 = new System.Windows.Forms.Button();
            this.btn_mayin_21 = new System.Windows.Forms.Button();
            this.grp_butunlar = new System.Windows.Forms.GroupBox();
            this.tmr_sure = new System.Windows.Forms.Timer(this.components);
            this.lbl_soru2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_armstrong_sayi = new System.Windows.Forms.Label();
            this.btn_bul = new System.Windows.Forms.Button();
            this.list_sayilar = new System.Windows.Forms.ListBox();
            this.txt_ust_sinir = new System.Windows.Forms.TextBox();
            this.txt_alt_sinir = new System.Windows.Forms.TextBox();
            this.lbl_ust_sinir = new System.Windows.Forms.Label();
            this.lbl_alt_sinir = new System.Windows.Forms.Label();
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_sure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_mayin_sayisi)).BeginInit();
            this.grp_butunlar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_soru1
            // 
            this.lbl_soru1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_soru1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soru1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru1.Location = new System.Drawing.Point(12, 9);
            this.lbl_soru1.Name = "lbl_soru1";
            this.lbl_soru1.Size = new System.Drawing.Size(298, 33);
            this.lbl_soru1.TabIndex = 0;
            this.lbl_soru1.Text = "SORU 1:";
            this.lbl_soru1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_mayin_sayisi
            // 
            this.lbl_mayin_sayisi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mayin_sayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mayin_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mayin_sayisi.Location = new System.Drawing.Point(9, 20);
            this.lbl_mayin_sayisi.Name = "lbl_mayin_sayisi";
            this.lbl_mayin_sayisi.Size = new System.Drawing.Size(115, 20);
            this.lbl_mayin_sayisi.TabIndex = 27;
            this.lbl_mayin_sayisi.Text = "Mayın Sayısı =";
            this.lbl_mayin_sayisi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmrc_sure);
            this.groupBox2.Controls.Add(this.nmrc_mayin_sayisi);
            this.groupBox2.Controls.Add(this.lbl_sure);
            this.groupBox2.Controls.Add(this.lbl_mayin_sayisi);
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametreler";
            // 
            // nmrc_sure
            // 
            this.nmrc_sure.Location = new System.Drawing.Point(144, 59);
            this.nmrc_sure.Name = "nmrc_sure";
            this.nmrc_sure.Size = new System.Drawing.Size(148, 20);
            this.nmrc_sure.TabIndex = 30;
            // 
            // nmrc_mayin_sayisi
            // 
            this.nmrc_mayin_sayisi.Location = new System.Drawing.Point(144, 20);
            this.nmrc_mayin_sayisi.Name = "nmrc_mayin_sayisi";
            this.nmrc_mayin_sayisi.Size = new System.Drawing.Size(148, 20);
            this.nmrc_mayin_sayisi.TabIndex = 29;
            // 
            // lbl_sure
            // 
            this.lbl_sure.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sure.Location = new System.Drawing.Point(9, 59);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(115, 20);
            this.lbl_sure.TabIndex = 28;
            this.lbl_sure.Text = "Süre (sn) =";
            this.lbl_sure.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_kalan_sure
            // 
            this.lbl_kalan_sure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_kalan_sure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_kalan_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kalan_sure.Location = new System.Drawing.Point(12, 486);
            this.lbl_kalan_sure.Name = "lbl_kalan_sure";
            this.lbl_kalan_sure.Size = new System.Drawing.Size(158, 33);
            this.lbl_kalan_sure.TabIndex = 29;
            this.lbl_kalan_sure.Text = "Kalan Süre = ___";
            this.lbl_kalan_sure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_basla.Location = new System.Drawing.Point(213, 486);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(97, 33);
            this.btn_basla.TabIndex = 30;
            this.btn_basla.Text = "Başla";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // tlp_butonlar
            // 
            this.tlp_butonlar.BackColor = System.Drawing.SystemColors.Info;
            this.tlp_butonlar.ColumnCount = 5;
            this.tlp_butonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.Location = new System.Drawing.Point(12, 45);
            this.tlp_butonlar.Name = "tlp_butonlar";
            this.tlp_butonlar.RowCount = 5;
            this.tlp_butonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_butonlar.Size = new System.Drawing.Size(298, 321);
            this.tlp_butonlar.TabIndex = 31;
            // 
            // btn_mayin_13
            // 
            this.btn_mayin_13.Location = new System.Drawing.Point(121, 138);
            this.btn_mayin_13.Name = "btn_mayin_13";
            this.btn_mayin_13.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_13.TabIndex = 13;
            this.btn_mayin_13.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_14
            // 
            this.btn_mayin_14.Location = new System.Drawing.Point(65, 138);
            this.btn_mayin_14.Name = "btn_mayin_14";
            this.btn_mayin_14.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_14.TabIndex = 12;
            this.btn_mayin_14.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_12
            // 
            this.btn_mayin_12.Location = new System.Drawing.Point(177, 138);
            this.btn_mayin_12.Name = "btn_mayin_12";
            this.btn_mayin_12.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_12.TabIndex = 14;
            this.btn_mayin_12.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_15
            // 
            this.btn_mayin_15.Location = new System.Drawing.Point(9, 138);
            this.btn_mayin_15.Name = "btn_mayin_15";
            this.btn_mayin_15.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_15.TabIndex = 11;
            this.btn_mayin_15.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_11
            // 
            this.btn_mayin_11.Location = new System.Drawing.Point(233, 138);
            this.btn_mayin_11.Name = "btn_mayin_11";
            this.btn_mayin_11.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_11.TabIndex = 15;
            this.btn_mayin_11.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_6
            // 
            this.btn_mayin_6.Location = new System.Drawing.Point(233, 82);
            this.btn_mayin_6.Name = "btn_mayin_6";
            this.btn_mayin_6.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_6.TabIndex = 10;
            this.btn_mayin_6.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_20
            // 
            this.btn_mayin_20.Location = new System.Drawing.Point(9, 194);
            this.btn_mayin_20.Name = "btn_mayin_20";
            this.btn_mayin_20.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_20.TabIndex = 16;
            this.btn_mayin_20.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_7
            // 
            this.btn_mayin_7.Location = new System.Drawing.Point(177, 82);
            this.btn_mayin_7.Name = "btn_mayin_7";
            this.btn_mayin_7.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_7.TabIndex = 9;
            this.btn_mayin_7.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_19
            // 
            this.btn_mayin_19.Location = new System.Drawing.Point(65, 194);
            this.btn_mayin_19.Name = "btn_mayin_19";
            this.btn_mayin_19.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_19.TabIndex = 17;
            this.btn_mayin_19.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_8
            // 
            this.btn_mayin_8.Location = new System.Drawing.Point(121, 82);
            this.btn_mayin_8.Name = "btn_mayin_8";
            this.btn_mayin_8.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_8.TabIndex = 8;
            this.btn_mayin_8.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_18
            // 
            this.btn_mayin_18.Location = new System.Drawing.Point(121, 194);
            this.btn_mayin_18.Name = "btn_mayin_18";
            this.btn_mayin_18.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_18.TabIndex = 18;
            this.btn_mayin_18.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_9
            // 
            this.btn_mayin_9.Location = new System.Drawing.Point(65, 82);
            this.btn_mayin_9.Name = "btn_mayin_9";
            this.btn_mayin_9.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_9.TabIndex = 7;
            this.btn_mayin_9.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_17
            // 
            this.btn_mayin_17.Location = new System.Drawing.Point(177, 194);
            this.btn_mayin_17.Name = "btn_mayin_17";
            this.btn_mayin_17.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_17.TabIndex = 19;
            this.btn_mayin_17.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_10
            // 
            this.btn_mayin_10.Location = new System.Drawing.Point(9, 82);
            this.btn_mayin_10.Name = "btn_mayin_10";
            this.btn_mayin_10.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_10.TabIndex = 6;
            this.btn_mayin_10.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_16
            // 
            this.btn_mayin_16.Location = new System.Drawing.Point(233, 194);
            this.btn_mayin_16.Name = "btn_mayin_16";
            this.btn_mayin_16.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_16.TabIndex = 20;
            this.btn_mayin_16.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_5
            // 
            this.btn_mayin_5.Location = new System.Drawing.Point(233, 26);
            this.btn_mayin_5.Name = "btn_mayin_5";
            this.btn_mayin_5.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_5.TabIndex = 5;
            this.btn_mayin_5.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_25
            // 
            this.btn_mayin_25.Location = new System.Drawing.Point(9, 250);
            this.btn_mayin_25.Name = "btn_mayin_25";
            this.btn_mayin_25.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_25.TabIndex = 21;
            this.btn_mayin_25.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_4
            // 
            this.btn_mayin_4.Location = new System.Drawing.Point(177, 26);
            this.btn_mayin_4.Name = "btn_mayin_4";
            this.btn_mayin_4.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_4.TabIndex = 4;
            this.btn_mayin_4.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_24
            // 
            this.btn_mayin_24.Location = new System.Drawing.Point(65, 250);
            this.btn_mayin_24.Name = "btn_mayin_24";
            this.btn_mayin_24.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_24.TabIndex = 22;
            this.btn_mayin_24.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_3
            // 
            this.btn_mayin_3.Location = new System.Drawing.Point(121, 26);
            this.btn_mayin_3.Name = "btn_mayin_3";
            this.btn_mayin_3.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_3.TabIndex = 3;
            this.btn_mayin_3.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_23
            // 
            this.btn_mayin_23.Location = new System.Drawing.Point(121, 250);
            this.btn_mayin_23.Name = "btn_mayin_23";
            this.btn_mayin_23.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_23.TabIndex = 23;
            this.btn_mayin_23.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_2
            // 
            this.btn_mayin_2.Location = new System.Drawing.Point(65, 26);
            this.btn_mayin_2.Name = "btn_mayin_2";
            this.btn_mayin_2.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_2.TabIndex = 2;
            this.btn_mayin_2.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_22
            // 
            this.btn_mayin_22.Location = new System.Drawing.Point(177, 250);
            this.btn_mayin_22.Name = "btn_mayin_22";
            this.btn_mayin_22.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_22.TabIndex = 24;
            this.btn_mayin_22.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_1
            // 
            this.btn_mayin_1.Location = new System.Drawing.Point(9, 26);
            this.btn_mayin_1.Name = "btn_mayin_1";
            this.btn_mayin_1.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_1.TabIndex = 1;
            this.btn_mayin_1.UseVisualStyleBackColor = true;
            // 
            // btn_mayin_21
            // 
            this.btn_mayin_21.Location = new System.Drawing.Point(233, 250);
            this.btn_mayin_21.Name = "btn_mayin_21";
            this.btn_mayin_21.Size = new System.Drawing.Size(50, 50);
            this.btn_mayin_21.TabIndex = 25;
            this.btn_mayin_21.UseVisualStyleBackColor = true;
            // 
            // grp_butunlar
            // 
            this.grp_butunlar.BackColor = System.Drawing.SystemColors.Info;
            this.grp_butunlar.Controls.Add(this.btn_mayin_21);
            this.grp_butunlar.Controls.Add(this.btn_mayin_1);
            this.grp_butunlar.Controls.Add(this.btn_mayin_22);
            this.grp_butunlar.Controls.Add(this.btn_mayin_2);
            this.grp_butunlar.Controls.Add(this.btn_mayin_23);
            this.grp_butunlar.Controls.Add(this.btn_mayin_3);
            this.grp_butunlar.Controls.Add(this.btn_mayin_24);
            this.grp_butunlar.Controls.Add(this.btn_mayin_4);
            this.grp_butunlar.Controls.Add(this.btn_mayin_25);
            this.grp_butunlar.Controls.Add(this.btn_mayin_5);
            this.grp_butunlar.Controls.Add(this.btn_mayin_16);
            this.grp_butunlar.Controls.Add(this.btn_mayin_10);
            this.grp_butunlar.Controls.Add(this.btn_mayin_17);
            this.grp_butunlar.Controls.Add(this.btn_mayin_9);
            this.grp_butunlar.Controls.Add(this.btn_mayin_18);
            this.grp_butunlar.Controls.Add(this.btn_mayin_8);
            this.grp_butunlar.Controls.Add(this.btn_mayin_19);
            this.grp_butunlar.Controls.Add(this.btn_mayin_7);
            this.grp_butunlar.Controls.Add(this.btn_mayin_20);
            this.grp_butunlar.Controls.Add(this.btn_mayin_6);
            this.grp_butunlar.Controls.Add(this.btn_mayin_11);
            this.grp_butunlar.Controls.Add(this.btn_mayin_15);
            this.grp_butunlar.Controls.Add(this.btn_mayin_12);
            this.grp_butunlar.Controls.Add(this.btn_mayin_14);
            this.grp_butunlar.Controls.Add(this.btn_mayin_13);
            this.grp_butunlar.Location = new System.Drawing.Point(12, 45);
            this.grp_butunlar.Name = "grp_butunlar";
            this.grp_butunlar.Size = new System.Drawing.Size(298, 321);
            this.grp_butunlar.TabIndex = 26;
            this.grp_butunlar.TabStop = false;
            // 
            // tmr_sure
            // 
            this.tmr_sure.Interval = 1000;
            this.tmr_sure.Tick += new System.EventHandler(this.tmr_sure_Tick);
            // 
            // lbl_soru2
            // 
            this.lbl_soru2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_soru2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soru2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru2.Location = new System.Drawing.Point(17, 9);
            this.lbl_soru2.Name = "lbl_soru2";
            this.lbl_soru2.Size = new System.Drawing.Size(170, 33);
            this.lbl_soru2.TabIndex = 32;
            this.lbl_soru2.Text = "SORU 2:";
            this.lbl_soru2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_armstrong_sayi);
            this.panel1.Controls.Add(this.lbl_soru2);
            this.panel1.Controls.Add(this.btn_bul);
            this.panel1.Controls.Add(this.list_sayilar);
            this.panel1.Controls.Add(this.txt_ust_sinir);
            this.panel1.Controls.Add(this.txt_alt_sinir);
            this.panel1.Controls.Add(this.lbl_ust_sinir);
            this.panel1.Controls.Add(this.lbl_alt_sinir);
            this.panel1.Controls.Add(this.lbl_sayi);
            this.panel1.Location = new System.Drawing.Point(334, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 539);
            this.panel1.TabIndex = 33;
            // 
            // lbl_armstrong_sayi
            // 
            this.lbl_armstrong_sayi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_armstrong_sayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_armstrong_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_armstrong_sayi.Location = new System.Drawing.Point(17, 455);
            this.lbl_armstrong_sayi.Name = "lbl_armstrong_sayi";
            this.lbl_armstrong_sayi.Size = new System.Drawing.Size(177, 73);
            this.lbl_armstrong_sayi.TabIndex = 37;
            this.lbl_armstrong_sayi.Text = "Armstrong Sayısı";
            this.lbl_armstrong_sayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_bul
            // 
            this.btn_bul.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bul.Location = new System.Drawing.Point(136, 420);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(58, 31);
            this.btn_bul.TabIndex = 36;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = false;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // list_sayilar
            // 
            this.list_sayilar.FormattingEnabled = true;
            this.list_sayilar.Location = new System.Drawing.Point(17, 265);
            this.list_sayilar.Name = "list_sayilar";
            this.list_sayilar.Size = new System.Drawing.Size(113, 186);
            this.list_sayilar.TabIndex = 35;
            // 
            // txt_ust_sinir
            // 
            this.txt_ust_sinir.Location = new System.Drawing.Point(108, 140);
            this.txt_ust_sinir.Name = "txt_ust_sinir";
            this.txt_ust_sinir.Size = new System.Drawing.Size(80, 20);
            this.txt_ust_sinir.TabIndex = 34;
            this.txt_ust_sinir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ust_sinir_KeyPress);
            // 
            // txt_alt_sinir
            // 
            this.txt_alt_sinir.Location = new System.Drawing.Point(17, 140);
            this.txt_alt_sinir.Name = "txt_alt_sinir";
            this.txt_alt_sinir.Size = new System.Drawing.Size(80, 20);
            this.txt_alt_sinir.TabIndex = 33;
            this.txt_alt_sinir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alt_sinir_KeyPress);
            // 
            // lbl_ust_sinir
            // 
            this.lbl_ust_sinir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_ust_sinir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ust_sinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ust_sinir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ust_sinir.Location = new System.Drawing.Point(108, 115);
            this.lbl_ust_sinir.Name = "lbl_ust_sinir";
            this.lbl_ust_sinir.Size = new System.Drawing.Size(80, 20);
            this.lbl_ust_sinir.TabIndex = 32;
            this.lbl_ust_sinir.Text = "Üst Sınır";
            this.lbl_ust_sinir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_alt_sinir
            // 
            this.lbl_alt_sinir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_alt_sinir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_alt_sinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alt_sinir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_alt_sinir.Location = new System.Drawing.Point(17, 115);
            this.lbl_alt_sinir.Name = "lbl_alt_sinir";
            this.lbl_alt_sinir.Size = new System.Drawing.Size(80, 20);
            this.lbl_alt_sinir.TabIndex = 31;
            this.lbl_alt_sinir.Text = "Alt Sınır";
            this.lbl_alt_sinir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_sayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_sayi.Location = new System.Drawing.Point(17, 90);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(170, 20);
            this.lbl_sayi.TabIndex = 30;
            this.lbl_sayi.Text = "- SAYI -";
            this.lbl_sayi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlp_butonlar);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.lbl_kalan_sure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_butunlar);
            this.Controls.Add(this.lbl_soru1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vize";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_sure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_mayin_sayisi)).EndInit();
            this.grp_butunlar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_soru1;
        private System.Windows.Forms.Label lbl_mayin_sayisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nmrc_mayin_sayisi;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label lbl_kalan_sure;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.TableLayoutPanel tlp_butonlar;
        private System.Windows.Forms.Button btn_mayin_13;
        private System.Windows.Forms.Button btn_mayin_14;
        private System.Windows.Forms.Button btn_mayin_12;
        private System.Windows.Forms.Button btn_mayin_15;
        private System.Windows.Forms.Button btn_mayin_11;
        private System.Windows.Forms.Button btn_mayin_6;
        private System.Windows.Forms.Button btn_mayin_20;
        private System.Windows.Forms.Button btn_mayin_7;
        private System.Windows.Forms.Button btn_mayin_19;
        private System.Windows.Forms.Button btn_mayin_8;
        private System.Windows.Forms.Button btn_mayin_18;
        private System.Windows.Forms.Button btn_mayin_9;
        private System.Windows.Forms.Button btn_mayin_17;
        private System.Windows.Forms.Button btn_mayin_10;
        private System.Windows.Forms.Button btn_mayin_16;
        private System.Windows.Forms.Button btn_mayin_5;
        private System.Windows.Forms.Button btn_mayin_25;
        private System.Windows.Forms.Button btn_mayin_4;
        private System.Windows.Forms.Button btn_mayin_24;
        private System.Windows.Forms.Button btn_mayin_3;
        private System.Windows.Forms.Button btn_mayin_23;
        private System.Windows.Forms.Button btn_mayin_2;
        private System.Windows.Forms.Button btn_mayin_22;
        private System.Windows.Forms.Button btn_mayin_1;
        private System.Windows.Forms.Button btn_mayin_21;
        private System.Windows.Forms.GroupBox grp_butunlar;
        private System.Windows.Forms.Timer tmr_sure;
        private System.Windows.Forms.Label lbl_soru2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ust_sinir;
        private System.Windows.Forms.Label lbl_alt_sinir;
        private System.Windows.Forms.Label lbl_sayi;
        private System.Windows.Forms.TextBox txt_ust_sinir;
        private System.Windows.Forms.TextBox txt_alt_sinir;
        private System.Windows.Forms.Label lbl_armstrong_sayi;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.ListBox list_sayilar;
        private System.Windows.Forms.NumericUpDown nmrc_sure;
    }
}

