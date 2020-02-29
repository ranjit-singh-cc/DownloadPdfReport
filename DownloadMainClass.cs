using System;
using System.Diagnostics;

namespace DownloadAPlusReport {
	class DownloadMainClass {
		static void Main(string[] args) {
			try {
				string exePath = @"C:\Program Files (x86)\Google\Chrome\Application";
				string userDataDir = Environment.GetEnvironmentVariable("LocalAppData") + @"\Google\Chrome\User Data";
				string webUrl = @"https://www.google.com";

				string savePath = @"D:\google.pdf";
				ProcessStartInfo proStart = new ProcessStartInfo();
				Process pro = new Process();
				proStart.FileName = "cmd.exe";
				proStart.WorkingDirectory = exePath;
				string arg = string.Format("/c {0} --headless --disable-gpu --user-data-dir=\"{1}\" --print-to-pdf=\"{2}\" \"{3}\"", "chrome", userDataDir, savePath, webUrl);
				proStart.Arguments = arg;
				proStart.WindowStyle = ProcessWindowStyle.Hidden;
				pro.StartInfo = proStart;
				pro.Start();
				pro.WaitForExit();

				Console.WriteLine("Press any key to exit");
				Console.ReadKey();
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
	}
}