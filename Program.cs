using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadAPlusReport {
	class Program {
		static void Main(string[] args) {
			try {
				string exePath = @"C:\Program Files (x86)\Google\Chrome\Application";
				string userDataDir = @"C:\Users\CC USER 2160\AppData\Local\Google\Chrome\User Data";
				string webUrl = @"https://www.cocubes.com/url-redirect?id=3261042391519364542&rl=0&qs=candidateid%3d15906238%26expires%3d637474449645702237%26nhk-param%3dlanguage%257cprofile%26oot%3d67116099%26target-appid%3d73%26testid%3d34238%26tks%3d637158225645702237%26v%3d3%26hk%3d2aINPdpa7pSbeddJag7A7y6RY0k%252c";

				for (int i = 1; i <= 20; i++) {
					string savePath = @"D:\158409331";
					ProcessStartInfo proStart = new ProcessStartInfo();
					Process pro = new Process();
					proStart.FileName = "cmd.exe";
					proStart.WorkingDirectory = exePath;
					string arg = string.Format("/c {0} --headless --disable-gpu --user-data-dir=\"{1}\" --print-to-pdf=\"{2}-{4}.pdf\" \"{3}\"", "chrome", userDataDir, savePath, webUrl, i);
					proStart.Arguments = arg;
					proStart.WindowStyle = ProcessWindowStyle.Hidden;
					pro.StartInfo = proStart;
					pro.Start();
				}

				//Console.ReadKey();
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
	}
}