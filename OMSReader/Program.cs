/*
 * Сделано в SharpDevelop.
 * Пользователь: CaiAdminKpk
 * Дата: 05.07.2012
 * Время: 9:36
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ApplicationManagement;
using Pc.Shared.Utils.Collections;
using Pc.Shared.Utils.Extensions;

namespace OMSReader
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		
		[DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        #region Variables

        public static Instance instance;
        public static MemoryManagement memory;
        //public static Profiling profiling;
        public static ExceptionHandler exceptionHandler;

        #endregion Variables
        
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] arguments)
		{
			#region Profiling Class

            // Our profiling will determinate the time taken by the app to initialize.
            //profiling = new Profiling();
            //Profiling.ProfilingData profilingData = profiling.Create("InitApp", true);

            #endregion Profiling Class

            #region Instance Class (Make single instance app)

            // Check if that is a single instance
            instance = new Instance(Application.ProductName);
            // instance is created but make sure you call next line:
            if (!instance.MakeSingleInstance(true, false))
            {
                Instance.ShowDuplicateInstanceDialogError();
                // Stop and quit App.
                return;
            }

            #endregion Instance Class (Make single instance app)

            #region Memory Management class

            // MemoryManagement only make effect in WinNT Systems,
            // if your app is multi system use that.
            if (MemoryManagement.CanUseClass())
            {
                memory = new MemoryManagement();
                memory.Start();
            }
            else
            {
                memory = null;
            }

            #endregion Memory Management class

            #region Exception Handler Class (Automatic cath and log unhandled exceptions)

            // Automatic cath and log unhandled exceptions
            exceptionHandler = new ExceptionHandler();
            // Next two lines are optional
            exceptionHandler.PrefixText = "В данном файле содержится информация об ошибках программы";
            exceptionHandler.SuffixText = "Пожалуйста, отправьте эти файлы по электронной почте: kopak@kopak.ru";
            exceptionHandler.StartHandlingExceptions();

            #endregion Exception Handler Class (Automatic cath and log unhandled exceptions)

            #region End started profile and show results

            //profilingData.Stop();
            //MessageBox.Show(
            //string.Format("Start Date: {0}\nEnd Date: {1}\nTime Taken: {2}ms", profilingData.StartDate, profilingData.EndDate, profilingData.TimeTaken.TotalMilliseconds), "Our application initializes time");

            #endregion End started profile and show results
            
            ArgumentCollection args = ArgumentCollection.GetArgumets(arguments);
            if (args.Count == 0)
      		{
            	Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
            }
            else if (args["ptf"] != null)
			{
            	CreateDataFile.GetData(args["ptf"]);
			}
            else
            {
            	CreateDataFile.GetData();
            }
			
		}
		
	}
}
