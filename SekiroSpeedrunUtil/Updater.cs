using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SekiroSpeedrunUtil {
    public static class Updater {

        private static string _apiEndpoint = "https://api.github.com/repos/Jiiks/Sekiro.SpeerunUtility/releases/latest";

        public static bool CheckForUpdates(out string latestVer) {
            Diag.WriteLine("Checking for updates");
            try {
                using (var wc = new WebClient()) {
                    wc.Headers.Set("Content-Type", "application/json");
                    wc.Headers.Set("User-Agent", "Sekiro.SpeedrunUtility");
                    var json = wc.DownloadString(_apiEndpoint);

                    var obj = JObject.Parse(json);
                    var tagName = obj["tag_name"].ToString();

                    var vCur = new Version(Application.ProductVersion);
                    var latest = new Version(tagName);

                    if (latest.CompareTo(vCur) > 0) {
                        latestVer = tagName;
                        Diag.WriteLine($"Update available! {tagName} > {Application.ProductVersion}");
                        return true;
                    }

                    Diag.WriteLine($"No updates available {Application.ProductVersion} >= {tagName}");
                    latestVer = "";
                    return false;
                }
            } catch (Exception ex) {
                Diag.WriteLine($"Update check failed :( {ex.Message}");
            }
            latestVer = "";
            return false;
        }

    }
}
