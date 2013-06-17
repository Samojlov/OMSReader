/*
 * Сделано в SharpDevelop.
 * Пользователь: CaiAdminKpk
 * Дата: 05.07.2012
 * Время: 9:36
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace OMSReader
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonGetData = new System.Windows.Forms.Button();
			this.ReadersComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonSearchReaders = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPersonalData = new System.Windows.Forms.TabPage();
			this.label23 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.textBoxECPStatus = new System.Windows.Forms.TextBox();
			this.textBoxECP = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.textBoxExpire = new System.Windows.Forms.TextBox();
			this.textBoxInsuranceStartDate = new System.Windows.Forms.TextBox();
			this.textBoxOKATO = new System.Windows.Forms.TextBox();
			this.textBoxOGRN = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.textBoxCert = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxSNILS = new System.Windows.Forms.TextBox();
			this.textBoxPolisExpire = new System.Windows.Forms.TextBox();
			this.textBoxPolisDate = new System.Windows.Forms.TextBox();
			this.textBoxPolisNumber = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxCountryName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxCountryCode = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPlaceOfBirth = new System.Windows.Forms.TextBox();
			this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
			this.textBoxSex = new System.Windows.Forms.TextBox();
			this.textBoxFIO = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabCardData = new System.Windows.Forms.TabPage();
			this.label32 = new System.Windows.Forms.Label();
			this.textBoxManufacturerData = new System.Windows.Forms.TextBox();
			this.textBoxManufacturerCode = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.textBoxInformation = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.textBoxCompanyID = new System.Windows.Forms.TextBox();
			this.textBoxCardVersion = new System.Windows.Forms.TextBox();
			this.textBoxCardType = new System.Windows.Forms.TextBox();
			this.textBoxCardSerial = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPersonalData.SuspendLayout();
			this.tabCardData.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonGetData
			// 
			this.buttonGetData.Location = new System.Drawing.Point(12, 4);
			this.buttonGetData.Name = "buttonGetData";
			this.buttonGetData.Size = new System.Drawing.Size(104, 23);
			this.buttonGetData.TabIndex = 0;
			this.buttonGetData.Text = "Получить данные";
			this.buttonGetData.UseVisualStyleBackColor = true;
			this.buttonGetData.Click += new System.EventHandler(this.ButtonGetDataClick);
			// 
			// ReadersComboBox
			// 
			this.ReadersComboBox.FormattingEnabled = true;
			this.ReadersComboBox.Location = new System.Drawing.Point(568, 6);
			this.ReadersComboBox.Name = "ReadersComboBox";
			this.ReadersComboBox.Size = new System.Drawing.Size(163, 21);
			this.ReadersComboBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(451, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Устройство чтения:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonSearchReaders);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonGetData);
			this.panel1.Controls.Add(this.ReadersComboBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 36);
			this.panel1.TabIndex = 3;
			// 
			// buttonSearchReaders
			// 
			this.buttonSearchReaders.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchReaders.Image")));
			this.buttonSearchReaders.Location = new System.Drawing.Point(737, 4);
			this.buttonSearchReaders.Name = "buttonSearchReaders";
			this.buttonSearchReaders.Size = new System.Drawing.Size(35, 23);
			this.buttonSearchReaders.TabIndex = 3;
			this.buttonSearchReaders.UseVisualStyleBackColor = true;
			this.buttonSearchReaders.Click += new System.EventHandler(this.ButtonSearchReadersClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPersonalData);
			this.tabControl1.Controls.Add(this.tabCardData);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 36);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(784, 583);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPersonalData
			// 
			this.tabPersonalData.Controls.Add(this.label23);
			this.tabPersonalData.Controls.Add(this.label18);
			this.tabPersonalData.Controls.Add(this.textBoxECPStatus);
			this.tabPersonalData.Controls.Add(this.textBoxECP);
			this.tabPersonalData.Controls.Add(this.label19);
			this.tabPersonalData.Controls.Add(this.label20);
			this.tabPersonalData.Controls.Add(this.label21);
			this.tabPersonalData.Controls.Add(this.label22);
			this.tabPersonalData.Controls.Add(this.textBoxExpire);
			this.tabPersonalData.Controls.Add(this.textBoxInsuranceStartDate);
			this.tabPersonalData.Controls.Add(this.textBoxOKATO);
			this.tabPersonalData.Controls.Add(this.textBoxOGRN);
			this.tabPersonalData.Controls.Add(this.label17);
			this.tabPersonalData.Controls.Add(this.label16);
			this.tabPersonalData.Controls.Add(this.textBoxCert);
			this.tabPersonalData.Controls.Add(this.label15);
			this.tabPersonalData.Controls.Add(this.label14);
			this.tabPersonalData.Controls.Add(this.label13);
			this.tabPersonalData.Controls.Add(this.label12);
			this.tabPersonalData.Controls.Add(this.label11);
			this.tabPersonalData.Controls.Add(this.textBoxSNILS);
			this.tabPersonalData.Controls.Add(this.textBoxPolisExpire);
			this.tabPersonalData.Controls.Add(this.textBoxPolisDate);
			this.tabPersonalData.Controls.Add(this.textBoxPolisNumber);
			this.tabPersonalData.Controls.Add(this.label10);
			this.tabPersonalData.Controls.Add(this.label9);
			this.tabPersonalData.Controls.Add(this.textBoxCountryName);
			this.tabPersonalData.Controls.Add(this.label8);
			this.tabPersonalData.Controls.Add(this.textBoxCountryCode);
			this.tabPersonalData.Controls.Add(this.label7);
			this.tabPersonalData.Controls.Add(this.label6);
			this.tabPersonalData.Controls.Add(this.label5);
			this.tabPersonalData.Controls.Add(this.label4);
			this.tabPersonalData.Controls.Add(this.label3);
			this.tabPersonalData.Controls.Add(this.textBoxPlaceOfBirth);
			this.tabPersonalData.Controls.Add(this.textBoxDateOfBirth);
			this.tabPersonalData.Controls.Add(this.textBoxSex);
			this.tabPersonalData.Controls.Add(this.textBoxFIO);
			this.tabPersonalData.Controls.Add(this.label2);
			this.tabPersonalData.Location = new System.Drawing.Point(4, 22);
			this.tabPersonalData.Name = "tabPersonalData";
			this.tabPersonalData.Padding = new System.Windows.Forms.Padding(3);
			this.tabPersonalData.Size = new System.Drawing.Size(776, 557);
			this.tabPersonalData.TabIndex = 0;
			this.tabPersonalData.Text = "Основные данные";
			this.tabPersonalData.UseVisualStyleBackColor = true;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(11, 529);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(211, 17);
			this.label23.TabIndex = 38;
			this.label23.Text = "Статус ЭЦП:";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(11, 503);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(211, 17);
			this.label18.TabIndex = 37;
			this.label18.Text = "ЭЦП:";
			// 
			// textBoxECPStatus
			// 
			this.textBoxECPStatus.Location = new System.Drawing.Point(228, 526);
			this.textBoxECPStatus.Name = "textBoxECPStatus";
			this.textBoxECPStatus.ReadOnly = true;
			this.textBoxECPStatus.Size = new System.Drawing.Size(540, 20);
			this.textBoxECPStatus.TabIndex = 36;
			// 
			// textBoxECP
			// 
			this.textBoxECP.Location = new System.Drawing.Point(228, 500);
			this.textBoxECP.Name = "textBoxECP";
			this.textBoxECP.ReadOnly = true;
			this.textBoxECP.Size = new System.Drawing.Size(540, 20);
			this.textBoxECP.TabIndex = 35;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(11, 307);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(211, 17);
			this.label19.TabIndex = 34;
			this.label19.Text = "Окончание срока действия:";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(11, 281);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(211, 17);
			this.label20.TabIndex = 33;
			this.label20.Text = "Дата начала страхования:";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(11, 255);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(211, 17);
			this.label21.TabIndex = 32;
			this.label21.Text = "ОКАТО:";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(11, 229);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(211, 17);
			this.label22.TabIndex = 31;
			this.label22.Text = "ОГРН:";
			// 
			// textBoxExpire
			// 
			this.textBoxExpire.Location = new System.Drawing.Point(228, 304);
			this.textBoxExpire.Name = "textBoxExpire";
			this.textBoxExpire.ReadOnly = true;
			this.textBoxExpire.Size = new System.Drawing.Size(540, 20);
			this.textBoxExpire.TabIndex = 30;
			// 
			// textBoxInsuranceStartDate
			// 
			this.textBoxInsuranceStartDate.Location = new System.Drawing.Point(228, 278);
			this.textBoxInsuranceStartDate.Name = "textBoxInsuranceStartDate";
			this.textBoxInsuranceStartDate.ReadOnly = true;
			this.textBoxInsuranceStartDate.Size = new System.Drawing.Size(540, 20);
			this.textBoxInsuranceStartDate.TabIndex = 29;
			// 
			// textBoxOKATO
			// 
			this.textBoxOKATO.Location = new System.Drawing.Point(228, 252);
			this.textBoxOKATO.Name = "textBoxOKATO";
			this.textBoxOKATO.ReadOnly = true;
			this.textBoxOKATO.Size = new System.Drawing.Size(540, 20);
			this.textBoxOKATO.TabIndex = 28;
			// 
			// textBoxOGRN
			// 
			this.textBoxOGRN.Location = new System.Drawing.Point(228, 226);
			this.textBoxOGRN.Name = "textBoxOGRN";
			this.textBoxOGRN.ReadOnly = true;
			this.textBoxOGRN.Size = new System.Drawing.Size(540, 20);
			this.textBoxOGRN.TabIndex = 27;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.ForeColor = System.Drawing.Color.MediumBlue;
			this.label17.Location = new System.Drawing.Point(11, 202);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(350, 17);
			this.label17.TabIndex = 26;
			this.label17.Text = "Данные страхового приложения:";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(11, 477);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(211, 17);
			this.label16.TabIndex = 25;
			this.label16.Text = "Сертификат:";
			// 
			// textBoxCert
			// 
			this.textBoxCert.Location = new System.Drawing.Point(228, 474);
			this.textBoxCert.Name = "textBoxCert";
			this.textBoxCert.ReadOnly = true;
			this.textBoxCert.Size = new System.Drawing.Size(540, 20);
			this.textBoxCert.TabIndex = 24;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.ForeColor = System.Drawing.Color.MediumBlue;
			this.label15.Location = new System.Drawing.Point(9, 454);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(350, 17);
			this.label15.TabIndex = 23;
			this.label15.Text = "Данные ЭЦП";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(11, 431);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(211, 17);
			this.label14.TabIndex = 22;
			this.label14.Text = "СНИЛС:";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(11, 405);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(211, 17);
			this.label13.TabIndex = 21;
			this.label13.Text = "Срок действия:";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(11, 379);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(211, 17);
			this.label12.TabIndex = 20;
			this.label12.Text = "Дата выпуска:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(11, 353);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(211, 17);
			this.label11.TabIndex = 19;
			this.label11.Text = "Номер полиса:";
			// 
			// textBoxSNILS
			// 
			this.textBoxSNILS.Location = new System.Drawing.Point(228, 428);
			this.textBoxSNILS.Name = "textBoxSNILS";
			this.textBoxSNILS.ReadOnly = true;
			this.textBoxSNILS.Size = new System.Drawing.Size(540, 20);
			this.textBoxSNILS.TabIndex = 18;
			// 
			// textBoxPolisExpire
			// 
			this.textBoxPolisExpire.Location = new System.Drawing.Point(228, 402);
			this.textBoxPolisExpire.Name = "textBoxPolisExpire";
			this.textBoxPolisExpire.ReadOnly = true;
			this.textBoxPolisExpire.Size = new System.Drawing.Size(540, 20);
			this.textBoxPolisExpire.TabIndex = 17;
			// 
			// textBoxPolisDate
			// 
			this.textBoxPolisDate.Location = new System.Drawing.Point(228, 376);
			this.textBoxPolisDate.Name = "textBoxPolisDate";
			this.textBoxPolisDate.ReadOnly = true;
			this.textBoxPolisDate.Size = new System.Drawing.Size(540, 20);
			this.textBoxPolisDate.TabIndex = 16;
			// 
			// textBoxPolisNumber
			// 
			this.textBoxPolisNumber.Location = new System.Drawing.Point(228, 350);
			this.textBoxPolisNumber.Name = "textBoxPolisNumber";
			this.textBoxPolisNumber.ReadOnly = true;
			this.textBoxPolisNumber.Size = new System.Drawing.Size(540, 20);
			this.textBoxPolisNumber.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.MediumBlue;
			this.label10.Location = new System.Drawing.Point(11, 330);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(350, 17);
			this.label10.TabIndex = 14;
			this.label10.Text = "Информация о полисе:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(11, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(211, 17);
			this.label9.TabIndex = 13;
			this.label9.Text = "Название страны:";
			// 
			// textBoxCountryName
			// 
			this.textBoxCountryName.Location = new System.Drawing.Point(228, 176);
			this.textBoxCountryName.Name = "textBoxCountryName";
			this.textBoxCountryName.ReadOnly = true;
			this.textBoxCountryName.Size = new System.Drawing.Size(540, 20);
			this.textBoxCountryName.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(11, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(211, 17);
			this.label8.TabIndex = 11;
			this.label8.Text = "Код страны:";
			// 
			// textBoxCountryCode
			// 
			this.textBoxCountryCode.Location = new System.Drawing.Point(228, 150);
			this.textBoxCountryCode.Name = "textBoxCountryCode";
			this.textBoxCountryCode.ReadOnly = true;
			this.textBoxCountryCode.Size = new System.Drawing.Size(540, 20);
			this.textBoxCountryCode.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.MediumBlue;
			this.label7.Location = new System.Drawing.Point(11, 127);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(350, 17);
			this.label7.TabIndex = 9;
			this.label7.Text = "Гражданство:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.MediumBlue;
			this.label6.Location = new System.Drawing.Point(11, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(350, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Информация о владельце:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Место рождения:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Дата рождения:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(211, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Пол:";
			// 
			// textBoxPlaceOfBirth
			// 
			this.textBoxPlaceOfBirth.Location = new System.Drawing.Point(228, 101);
			this.textBoxPlaceOfBirth.Name = "textBoxPlaceOfBirth";
			this.textBoxPlaceOfBirth.ReadOnly = true;
			this.textBoxPlaceOfBirth.Size = new System.Drawing.Size(540, 20);
			this.textBoxPlaceOfBirth.TabIndex = 4;
			// 
			// textBoxDateOfBirth
			// 
			this.textBoxDateOfBirth.Location = new System.Drawing.Point(228, 75);
			this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
			this.textBoxDateOfBirth.ReadOnly = true;
			this.textBoxDateOfBirth.Size = new System.Drawing.Size(540, 20);
			this.textBoxDateOfBirth.TabIndex = 3;
			// 
			// textBoxSex
			// 
			this.textBoxSex.Location = new System.Drawing.Point(228, 49);
			this.textBoxSex.Name = "textBoxSex";
			this.textBoxSex.ReadOnly = true;
			this.textBoxSex.Size = new System.Drawing.Size(540, 20);
			this.textBoxSex.TabIndex = 2;
			// 
			// textBoxFIO
			// 
			this.textBoxFIO.Location = new System.Drawing.Point(228, 23);
			this.textBoxFIO.Name = "textBoxFIO";
			this.textBoxFIO.ReadOnly = true;
			this.textBoxFIO.Size = new System.Drawing.Size(540, 20);
			this.textBoxFIO.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "ФИО:";
			// 
			// tabCardData
			// 
			this.tabCardData.Controls.Add(this.label32);
			this.tabCardData.Controls.Add(this.textBoxManufacturerData);
			this.tabCardData.Controls.Add(this.textBoxManufacturerCode);
			this.tabCardData.Controls.Add(this.label33);
			this.tabCardData.Controls.Add(this.label30);
			this.tabCardData.Controls.Add(this.label29);
			this.tabCardData.Controls.Add(this.textBoxInformation);
			this.tabCardData.Controls.Add(this.label25);
			this.tabCardData.Controls.Add(this.label26);
			this.tabCardData.Controls.Add(this.label27);
			this.tabCardData.Controls.Add(this.textBoxCompanyID);
			this.tabCardData.Controls.Add(this.textBoxCardVersion);
			this.tabCardData.Controls.Add(this.textBoxCardType);
			this.tabCardData.Controls.Add(this.textBoxCardSerial);
			this.tabCardData.Controls.Add(this.label28);
			this.tabCardData.Controls.Add(this.label24);
			this.tabCardData.Location = new System.Drawing.Point(4, 22);
			this.tabCardData.Name = "tabCardData";
			this.tabCardData.Padding = new System.Windows.Forms.Padding(3);
			this.tabCardData.Size = new System.Drawing.Size(776, 557);
			this.tabCardData.TabIndex = 1;
			this.tabCardData.Text = "Дополнительные данные";
			this.tabCardData.UseVisualStyleBackColor = true;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(11, 199);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(211, 17);
			this.label32.TabIndex = 25;
			this.label32.Text = "Данные производителя карты:";
			// 
			// textBoxManufacturerData
			// 
			this.textBoxManufacturerData.Location = new System.Drawing.Point(228, 196);
			this.textBoxManufacturerData.Name = "textBoxManufacturerData";
			this.textBoxManufacturerData.ReadOnly = true;
			this.textBoxManufacturerData.Size = new System.Drawing.Size(540, 20);
			this.textBoxManufacturerData.TabIndex = 23;
			// 
			// textBoxManufacturerCode
			// 
			this.textBoxManufacturerCode.Location = new System.Drawing.Point(228, 170);
			this.textBoxManufacturerCode.Name = "textBoxManufacturerCode";
			this.textBoxManufacturerCode.ReadOnly = true;
			this.textBoxManufacturerCode.Size = new System.Drawing.Size(540, 20);
			this.textBoxManufacturerCode.TabIndex = 22;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(11, 173);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(211, 17);
			this.label33.TabIndex = 21;
			this.label33.Text = "Код производителя карты:";
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label30.ForeColor = System.Drawing.Color.MediumBlue;
			this.label30.Location = new System.Drawing.Point(11, 150);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(350, 17);
			this.label30.TabIndex = 20;
			this.label30.Text = "Информация о микросхеме от производителя:";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(11, 127);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(211, 17);
			this.label29.TabIndex = 19;
			this.label29.Text = "Дополнительные сведения о карте:";
			// 
			// textBoxInformation
			// 
			this.textBoxInformation.Location = new System.Drawing.Point(228, 124);
			this.textBoxInformation.Name = "textBoxInformation";
			this.textBoxInformation.ReadOnly = true;
			this.textBoxInformation.Size = new System.Drawing.Size(540, 20);
			this.textBoxInformation.TabIndex = 18;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(11, 101);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(211, 17);
			this.label25.TabIndex = 17;
			this.label25.Text = "Идентификатор учреждения:";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(11, 75);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(211, 17);
			this.label26.TabIndex = 16;
			this.label26.Text = "Версия:";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(11, 49);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(211, 17);
			this.label27.TabIndex = 15;
			this.label27.Text = "Тип карты:";
			// 
			// textBoxCompanyID
			// 
			this.textBoxCompanyID.Location = new System.Drawing.Point(228, 98);
			this.textBoxCompanyID.Name = "textBoxCompanyID";
			this.textBoxCompanyID.ReadOnly = true;
			this.textBoxCompanyID.Size = new System.Drawing.Size(540, 20);
			this.textBoxCompanyID.TabIndex = 14;
			// 
			// textBoxCardVersion
			// 
			this.textBoxCardVersion.Location = new System.Drawing.Point(228, 72);
			this.textBoxCardVersion.Name = "textBoxCardVersion";
			this.textBoxCardVersion.ReadOnly = true;
			this.textBoxCardVersion.Size = new System.Drawing.Size(540, 20);
			this.textBoxCardVersion.TabIndex = 13;
			// 
			// textBoxCardType
			// 
			this.textBoxCardType.Location = new System.Drawing.Point(228, 46);
			this.textBoxCardType.Name = "textBoxCardType";
			this.textBoxCardType.ReadOnly = true;
			this.textBoxCardType.Size = new System.Drawing.Size(540, 20);
			this.textBoxCardType.TabIndex = 12;
			// 
			// textBoxCardSerial
			// 
			this.textBoxCardSerial.Location = new System.Drawing.Point(228, 20);
			this.textBoxCardSerial.Name = "textBoxCardSerial";
			this.textBoxCardSerial.ReadOnly = true;
			this.textBoxCardSerial.Size = new System.Drawing.Size(540, 20);
			this.textBoxCardSerial.TabIndex = 11;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(11, 23);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(211, 17);
			this.label28.TabIndex = 10;
			this.label28.Text = "Серийный номер карты:";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label24.ForeColor = System.Drawing.Color.MediumBlue;
			this.label24.Location = new System.Drawing.Point(11, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(350, 17);
			this.label24.TabIndex = 9;
			this.label24.Text = "Идентификационные данные карты:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 619);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Чтение данных с электронного полиса ОМС";
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPersonalData.ResumeLayout(false);
			this.tabPersonalData.PerformLayout();
			this.tabCardData.ResumeLayout(false);
			this.tabCardData.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox textBoxManufacturerCode;
		private System.Windows.Forms.TextBox textBoxManufacturerData;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Button buttonSearchReaders;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBoxCardSerial;
		private System.Windows.Forms.TextBox textBoxCardType;
		private System.Windows.Forms.TextBox textBoxCardVersion;
		private System.Windows.Forms.TextBox textBoxCompanyID;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox textBoxInformation;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox textBoxPolisNumber;
		private System.Windows.Forms.TextBox textBoxPolisDate;
		private System.Windows.Forms.TextBox textBoxPolisExpire;
		private System.Windows.Forms.TextBox textBoxSNILS;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBoxCert;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBoxOGRN;
		private System.Windows.Forms.TextBox textBoxOKATO;
		private System.Windows.Forms.TextBox textBoxInsuranceStartDate;
		private System.Windows.Forms.TextBox textBoxExpire;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox textBoxECP;
		private System.Windows.Forms.TextBox textBoxECPStatus;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TabPage tabCardData;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFIO;
		private System.Windows.Forms.TextBox textBoxSex;
		private System.Windows.Forms.TextBox textBoxDateOfBirth;
		private System.Windows.Forms.TextBox textBoxPlaceOfBirth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxCountryCode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxCountryName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage tabPersonalData;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ReadersComboBox;
		private System.Windows.Forms.Button buttonGetData;
	}
}
