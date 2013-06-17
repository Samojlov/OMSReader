/*
 * Сделано в SharpDevelop.
 * Пользователь: CaiAdminKpk
 * Дата: 05.07.2012
 * Время: 9:36
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Pc.Policy.Smartcard.Crypto;
using Pc.Policy.Smartcard.Data;
using Pc.Policy.Smartcard.Shared;
using Pc.Shared.Utils.Collections;
using Pc.Shared.Utils.Extensions;
using SmartCard.PCSC;
using SmartCard.PCSC.Native;
using System.IO;

namespace OMSReader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			SearchReaders();
		}
		
		void SearchReaders()
		{
			PCSCReadersManager manager = new PCSCReadersManager();
        	try
        	{
        		ReadersComboBox.Items.Clear();
        		
        		manager.EstablishContext(SmartCard.PCSC.READERSCONTEXTSCOPE.SCOPE_USER);
        		manager.OfType<ISCard>().ToList().ForEach(reader =>
          		{
        		    ReadersComboBox.Items.Add(reader.ReaderName);
          		});
        		
        		if (ReadersComboBox.Items.Count > 0) 
        		{
        			ReadersComboBox.Text = ReadersComboBox.Items[0].ToString();
        		}
        		
        		manager.ReleaseContext();
        	}
        	catch (Exception exception)
        	{
        		MessageBox.Show(exception.Message, "Ошибка получения списка ридеров");
        	}
		}
		
		void ClearForm()
		{
			textBoxFIO.Text = "";
			textBoxSex.Text = "";
			textBoxDateOfBirth.Text = "";
			textBoxPlaceOfBirth.Text = "";
			textBoxCountryCode.Text = "";
			textBoxCountryName.Text = "";
			textBoxPolisNumber.Text = "";
			textBoxPolisDate.Text = "";
			textBoxPolisExpire.Text = "";
			textBoxSNILS.Text = "";
			textBoxECPStatus.Text = "";
			textBoxOGRN.Text = "";
          	textBoxOKATO.Text = "";
          	textBoxInsuranceStartDate.Text = "";
          	textBoxExpire.Text = "";
          	textBoxCert.Text = "";
          	textBoxECP.Text = "";
          	textBoxCardSerial.Text = "";
          	textBoxCardType.Text = "";
          	textBoxCardVersion.Text = "";
          	textBoxCompanyID.Text = "";
          	textBoxInformation.Text = "";
          	textBoxManufacturerCode.Text = "";
            textBoxManufacturerData.Text = "";
		}
		
		void GetCardData()
		{
			if (ReadersComboBox.Items.Count == 0) {
				MessageBox.Show("Не обнаружено подключенных ридеров!");
				return;
			}
			
			ClearForm();
			
			PCSCReadersManager manager = new PCSCReadersManager();
      		
      		var SA = ReadersComboBox.Items[0].ToString();
      			
      		manager.EstablishContext(SmartCard.PCSC.READERSCONTEXTSCOPE.SCOPE_USER);
      		if (manager.OfType<ISCard>().Select(s => s.ReaderName).ToList().Contains(SA))
       	 	{
      			ISCard card = manager[SA];
          		PolicySmartcardBase policy = new PolicySmartcardBase(card);
          		policy.Connect();
          			
          		try
      			{          			
					OwnerInformation owner_info = policy.GetOwnerInformation();
					if (owner_info != null)
          			{
						textBoxFIO.Text = FormatPolicyText(owner_info.Identity_1, "") + " " + FormatPolicyText(owner_info.Identity_2, "") + " " + FormatPolicyText(owner_info.Identity_1, "");
						textBoxSex.Text = owner_info.Sex == 1 ? "Мужской" : owner_info.Sex == 2 ? "Женский" : "Неизвестно";
						textBoxDateOfBirth.Text = FormatPolicyDate(owner_info.BirthDate, "Отсутствует");
						textBoxPlaceOfBirth.Text = FormatPolicyText(owner_info.BirthPlace, "Отсутствует");
						
						if (owner_info.Citizenship != null)
						{
							textBoxCountryCode.Text = FormatPolicyText(owner_info.Citizenship.CoutryCode, "Отсутствует");
							textBoxCountryName.Text = FormatPolicyText(owner_info.Citizenship.CoutryCyrillicName, "Отсутствует");
						}
						
						textBoxPolisNumber.Text = owner_info.PolicyNumber;
						textBoxPolisDate.Text = FormatPolicyDate(owner_info.ExpireDate, "Отсутствует");
						textBoxPolisExpire.Text = FormatPolicyDate(owner_info.ExpireDate, "Не ограничено");
						textBoxSNILS.Text = FormatPolicyText(owner_info.SNILS, "Отсутствует");
					}
				}
      			catch (Exception exception)
        		{
        			MessageBox.Show(exception.Message, "Ошибка: ");
        		}
				try
      			{	
					CardID cid = policy.GetCardID();          			
					if (cid != null)
          			{
            			textBoxCardSerial.Text = cid.SerialNumber.ToHexString();
            			textBoxCardType.Text = cid.CardType.ToString();
          				textBoxCardVersion.Text = cid.CardVersion.ToString();
          				textBoxCompanyID.Text = cid.InstitutionID.ToHexString();
          				textBoxInformation.Text = cid.AdditionalInfo.ToHexString();
          			}
				}
				catch (Exception exception)
        		{
        			MessageBox.Show(exception.Message, "Ошибка: ");
        		}
				try
      			{	
					ICCID ccd = policy.GetICCD();          			
					if (ccd != null)
          			{
						textBoxManufacturerCode.Text = ccd.IssuerCode.ToString();
            			textBoxManufacturerData.Text = ccd.IssuerData.ToHexString();
          			}
				}
				catch (Exception exception)
        		{
        			MessageBox.Show(exception.Message, "Ошибка: ");
        		}				
				
				try
      			{	
					SMOInformation smo = policy.GetCurrentSMOInformation();
          			if (smo != null)
          			{
          				textBoxOGRN.Text = smo.OGRN;
          				textBoxOKATO.Text = smo.OKATO;
          				textBoxInsuranceStartDate.Text = FormatPolicyDate(smo.InsuranceStartDate, "Отсутствует");
          				textBoxExpire.Text = FormatPolicyDate(smo.InsuranceExpireDate, "Не ограничено");
          				textBoxCert.Text = new X509Certificate2(smo.EDS.Certificate).Subject;
          				textBoxECP.Text = smo.EDS.Signature.ToHexString();
          				//textBoxECPStatus.Text = smo.VerifyEDS() == true ? "Верна" : "Неверна";
          			}
				}
          		catch (Exception exception)
        		{
        			MessageBox.Show(exception.Message, "Ошибка: ");
        		}	
				policy.Disconnect();
      		}      			
          	manager.ReleaseContext();      		
		}
		
		public static string FormatPolicyText(string value, string null_value)
    	{
      		if (string.IsNullOrEmpty(value))
        		return null_value;
      		return value;
    	}
		
		public static string FormatPolicyDate(DateTime? date, string null_value)
    	{
      		if (date.HasValue == false) 
      			return null_value;
      		if (date.HasValue)
      		{
        		string sdate = date.Value.ToString("ddMMyyyy");
        		if (sdate == "01011900")
          			return null_value;
        		else
          			return date.Value.ToString("dd.MM.yyyy");
      		}
      		return null_value;
    	}
		
		void ButtonSearchReadersClick(object sender, EventArgs e)
		{
			SearchReaders();
		}
		
		void ButtonGetDataClick(object sender, EventArgs e)
		{
			GetCardData();
		}
	}
}
