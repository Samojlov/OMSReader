/*
 * Сделано в SharpDevelop.
 * Пользователь: CaiAdminKpk
 * Дата: 05.07.2012
 * Время: 11:43
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
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
	/// Description of CreateDataFile.
	/// </summary>
	public class CreateDataFile
	{
    	static string ContentFile = "";
    	static string ReaderName = "";

		public CreateDataFile()
		{
		}
		
		public static void GetData(string args = "")
		{
			PCSCReadersManager manager = new PCSCReadersManager();
        	try
        	{        		
        		manager.EstablishContext(SmartCard.PCSC.READERSCONTEXTSCOPE.SCOPE_USER);
        		if (args != "") {
        			ReaderName = args;
        		}
        		else
        		{
        			var list = manager.OfType<ISCard>().ToList();
        		
        			if (list.Count > 0) {
        				ReaderName = list[0].ReaderName;
        			}
        			else
        			{
        				ContentFile += "Не найдены ридеры!";
        			}
        		}        		
        		
        		if (manager.OfType<ISCard>().Select(s => s.ReaderName).ToList().Contains(ReaderName))
        		{
          			//Получение объекта ридера
          			ISCard card = manager[ReaderName];
          			//Создание объекта для работы с картой полиса ОМС
          			PolicySmartcardBase policy = new PolicySmartcardBase(card);
          			//Подключение к карте полиса ОМС
          			policy.Connect();
          			//Чтение информации о владельце полиса ОМС
          			OwnerInformation owner_info = policy.GetOwnerInformation();
          			if (owner_info != null)
          			{
            			printf("Информация о владельце:");
            			printf("{0} = {1}", "Фамилия".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.Identity_1, "Отсутствует"));
            			printf("{0} = {1}", "Имя".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.Identity_2, "Отсутствует"));
            			printf("{0} = {1}", "Отчество".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.Identity_3, "Отсутствует"));
            			printf("{0} = {1}", "Пол".PadRight(35, ' '), owner_info.Sex == 1 ? "Мужской" : owner_info.Sex == 2 ? "Женский" : "Неизвестно");
            			printf("{0} = {1}", "Дата рождения".PadRight(35, ' '), MainForm.FormatPolicyDate(owner_info.BirthDate, "Отсутствует"));
            			printf("{0} = {1}", "Место рождения".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.BirthPlace, "Отсутствует"));
            			
            			if (owner_info.Citizenship != null)
            			{
              				printf("Гражданство:");
              				printf("{0} = {1}", "Код страны".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.Citizenship.CoutryCode, "Отсутствует"));
              				printf("{0} = {1}", "Кириллическое название".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.Citizenship.CoutryCyrillicName, "Отсутствует"));
            			}
            			else
            			{
              				printf("{0} = {1}", "Гражданство".PadRight(35, ' '), "Отсутствует");
            			}
            			
            			printf("Информация о полисе:");
            			printf("{0} = {1:D16}", "Номер полиса".PadRight(35, ' '), owner_info.PolicyNumber);
            			printf("{0} = {1}", "Дата выпуска".PadRight(35, ' '), MainForm.FormatPolicyDate(owner_info.ExpireDate, "Отсутствует"));
            			printf("{0} = {1}", "Срок действия".PadRight(35, ' '), MainForm.FormatPolicyDate(owner_info.ExpireDate, "Не ограничено"));
            			printf("{0} = {1}", "СНИЛС".PadRight(35, ' '), MainForm.FormatPolicyText(owner_info.SNILS, "Отсутствует"));
            			//printf("Чтение атрибутов безопасности карты полиса ОМС");
            			//SecurityInformation SOD = policy.GetSecurityInformation();
            			//printf("{0} = {1}", "Статус ЭЦП".PadRight(35, ' '), owner_info.VerifyEDS(SOD) ? "Верна" : "Неверна");
          			}
          			else
          			{
            			printf("Данные о владельце отсутствуют на карте!");
          			}
          			
          			SMOInformation smo = policy.GetCurrentSMOInformation();
          			if (smo != null)
          			{
            			printf("Данные страхового приложения:");
            			printf("{0} = {1}", "ОГРН".PadRight(35, ' '), smo.OGRN);
            			printf("{0} = {1}", "ОКАТО".PadRight(35, ' '), smo.OKATO);
            			printf("{0} = {1}", "Дата начала страхования".PadRight(35, ' '), MainForm.FormatPolicyDate(smo.InsuranceStartDate, "Отсутствует"));
            			printf("{0} = {1}", "Окончание срока действия".PadRight(35, ' '), MainForm.FormatPolicyDate(smo.InsuranceExpireDate, "Не ограничено"));
            			if (smo.EDS != null)
            			{
             				printf("Данные ЭЦП");
              				printf("{0} = {1}", "Сертификат".PadRight(35, ' '), new X509Certificate2(smo.EDS.Certificate).Subject);
              				printf("{0} = {1}", "ЭЦП".PadRight(35, ' '), smo.EDS.Signature.ToHexString());
              				//printf("{0} = {1}", "Статус ЭЦП".PadRight(35, ' '), smo.VerifyEDS() == true ? "Верна" : "Неверна");
            			}
            			else
            			{
              				printf("{0} = {1}", "Данные ЭЦП".PadRight(35, ' '), "Отсутствуют");
            			}
          			}
          			else
          			{
            			printf("Данные о смо отсутствуют на карте!");
          			}
          			
          			CardID cid = policy.GetCardID();
			        ICCID ccd = policy.GetICCD();
					if (cid != null)
          			{
            			printf("Идентификационные данные карты:");
            			printf("{0} = {1}", "Серийный номер карты".PadRight(35, ' '), cid.SerialNumber.ToHexString());
            			printf("{0} = {1}", "Тип карты".PadRight(35, ' '), cid.CardType);
            			printf("{0} = {1}", "Версия".PadRight(35, ' '), cid.CardVersion);
            			printf("{0} = {1}", "Идентификатор учреждения".PadRight(35, ' '), cid.InstitutionID.ToHexString());
            			printf("{0} = {1}", "Дополнительные сведения о карте".PadRight(35, ' '), cid.AdditionalInfo.ToHexString());
          			}
          			else
          			{
            			printf("Идентификационные данные отсутствуют на карте!");
          			}

          			if (ccd != null)
          			{
            			printf("Информация о микросхеме от производителя:");
            			printf("{0} = {1}", "Код производителя карты".PadRight(35, ' '), ccd.IssuerCode);
            			printf("{0} = {1}", "Данные производителя карты".PadRight(35, ' '), ccd.IssuerData.ToHexString());
          			}
          			else
          			{
            			printf("Информация о микросхеме от производителя отсутствует на карте!");
          			}          			
          			//Отключение от карты полиса ОМС
          			policy.Disconnect();
          			//Отключение от смарт-карт API
          			manager.ReleaseContext();
        		}
        		else
        		{
          			printf("Устройство чтения смарт-карт с именем [{0}] не найдено в системе.");
          			manager.ReleaseContext();
        		}      	
        	}
        	catch (Exception exception)
        	{
        		ContentFile += "Ошибка получения списка ридеров: " + exception.Message;
        	}
        	
        	StreamWriter wf;
       		wf = new StreamWriter("infofile.txt", false, Encoding.GetEncoding(1251));
        	wf.Write(ContentFile);
        	wf.Close();
			
		}
		
		static void printf(string format = "", params object[] parameters)
    	{
    		ContentFile += string.Format(format, parameters)+"\r\n";     
    	}
	}
}
