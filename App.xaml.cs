using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace Warehouser_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static Win_Start? win_Start = null;
        internal static HttpClient? hc = null;
        internal static string LogFilePath = string.Empty;
        internal string secretKey = $"f9ag8ak10ap{Environment.UserName}";
        private void Hiro_We_Go(object sender, StartupEventArgs e)
        {
            Initialize_Folders();
            Initialize_Static_Params();
            win_Start = new();
            win_Start.Show();
        }

        private void Initialize_Static_Params()
        {
            LogFilePath = HiroUtils.Path_Prepare("<current>\\users\\<hiuser>\\logs\\<yyyy>\\<date>.log");
            Initialize_HttpClient();
            var res = string.Empty;
            Task.Run(() =>
            {
                var s = string.Empty;
                var a = HiroUtils.Http_Post("login", new List<string>(new string[] { "1" }), new List<string>(new string[] { "1" }), s).GetAwaiter();
                a.OnCompleted(() =>
                {
                    if(a.GetResult())
                    {
                        MessageBox.Show("成功？");
                    }
                    else
                    {
                        MessageBox.Show("失败");
                    }
                });
            });
        }

        private void Initialize_HttpClient()
        {
            switch (Hi_Settings.Default.httpProxy)
            {
                case 1://System Proxy aka. IE Proxy
                    {
                        hc = new();
                        break;
                    }

                case 2://Customized Proxy
                    {
                        try
                        {
                            HttpClientHandler hch = new();
                            hch.UseProxy = true;
                            hch.Proxy = new WebProxy(Hi_Settings.Default.httpProxyURL, Hi_Settings.Default.httpProxyPort);
                            if (Hi_Settings.Default.httpProxyEC)
                            {
                                hch.PreAuthenticate = true;
                                hch.UseDefaultCredentials = false;
                                hch.Credentials = new NetworkCredential(
                                    HiroUtils.TextDecrypt(Hi_Settings.Default.httpProxyUser.ToCharArray(), secretKey),
                                    HiroUtils.TextDecrypt(Hi_Settings.Default.httpProxyPwd.ToCharArray(), secretKey));
                            }
                            hc = new(hch);
                        }
                        catch (Exception ex)
                        {
                            HiroUtils.LogError(ex, "Exception.HttpClient.Proxy");
                            hc = new();
                        }
                        break;
                    }
                default:
                    {
                        hc = new(new HttpClientHandler()
                        {
                            UseProxy = false
                        });
                        break;
                    }
            }
        }

        private void Initialize_Folders()
        {
            HiroUtils.CreateFolder(HiroUtils.Path_Prepare("<current>\\users\\<hiuser>\\logs\\<yyyy>\\<date>.log"));
        }


    }
}
