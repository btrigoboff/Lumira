using System;
using System.Windows.Forms;
using Ivi.DCPwr.Interop;
using Ivi.Driver.Interop;
using Ivi.SessionFactory.Interop;
using Ivi.Visa.Interop;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace Amiratest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void PublishResults(string[] args)
        {
            var csvPath = Path.Combine(Environment.CurrentDirectory, $"TestData-{DateTime.Now.ToFileTime()}.csv");
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    //var data = TestData.board0.serNum;
                    //csvWriter.WriteRecords(TestData);
                }
            }
        }
    }
}
