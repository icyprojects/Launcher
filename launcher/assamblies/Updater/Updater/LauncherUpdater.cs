using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//формы для сообщений
using System.Windows.Forms;
// получение версии файла
using System.Diagnostics;
// XML для updater.cfg
using System.Xml;
// Net для получения файла из репозитория
using System.Net;


namespace Updater
{
    public class LauncherUpdater
    {
        public struct RemoteVersions
        {
            public string form;
            public string updater;
            public string launcher;
            public string cfg;
        }

        public struct CurrentVersions
        {
            public string form;
            public string updater;
            public string launcher;
            public string cfg;
        }

        public struct Links
        {
            public string updText;
            public string form;
            public string updater;
            public string launcher;
            public string cfg;
        }

        private Links _links;
        private CurrentVersions _currentVersions;
        private RemoteVersions _remoteVersions;

        public LauncherUpdater()
        {
            FillCurrentVersions();
        }

        public string GetCurrentFormVersion()
        {
            return _currentVersions.form;
        }

        public void CheckUpdates()
        {
            FillLinksStructure();
            string content = RequestSiteContent();
            FillRemoteVersions(content);

            MessageBox.Show(_currentVersions.form);
            MessageBox.Show(_currentVersions.updater);
            MessageBox.Show(_currentVersions.cfg);

        }

        private string _getCurrentFileVersion(string _in)
        {
            FileVersionInfo formDllVersionInfo =
                FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\" + _in);
            return formDllVersionInfo.FileVersion;
        }

        private string RequestSiteContent()
        {
            WebRequest request = WebRequest.Create(_links.updText);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return content;
        }

        private string ScanHtml(string _in, int index, int count)
        {
            string formVer = "";
            int i = 0;
            while (i < count)
            {
                if (((int)(_in[index])) != 10 && ((int)(_in[index])) != 9)
                {
                    formVer += _in[index];
                    index++;
                    i++;
                }
                else
                {
                    index++;
                }
            }

            return formVer;
        }

        private void FillRemoteVersions(string _in)
        {
            
            int formIndexStart = _in.IndexOf("<formdll>") + 10;
            int formFirstNum = _in.IndexOf(">", formIndexStart) + 1;

            _remoteVersions.form = ScanHtml(_in, formFirstNum,7);

            formIndexStart = _in.IndexOf("<updater>") + 10;
            formFirstNum = _in.IndexOf(">", formIndexStart) + 1;

            _remoteVersions.updater = ScanHtml(_in, formFirstNum,7);

            formIndexStart = _in.IndexOf("<launcher>") + 11;
            formFirstNum = _in.IndexOf(">", formIndexStart) + 1;

            _remoteVersions.launcher = ScanHtml(_in, formFirstNum,7);

            formIndexStart = _in.IndexOf("<cfg>") + 6;
            formFirstNum = _in.IndexOf(">", formIndexStart) + 1;

            _remoteVersions.cfg = ScanHtml(_in, formFirstNum,1);
        }

        private void CompareVersions()
        {
            
        }

        private void FillCurrentVersions()
        {
            try
            {
                _currentVersions.form = _getCurrentFileVersion("form.dll");
                _currentVersions.updater = _getCurrentFileVersion("Updater.dll");
                //_currentVersions.launcher = _getCurrentFileVersion("TusurGPO.Launcher.exe");
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Environment.CurrentDirectory + "\\updater.cfg");
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlNode xNode in xRoot)
                {
                    if (xNode.Name == "build")
                    {
                        _currentVersions.cfg = xNode.ChildNodes[0].InnerText;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void FillLinksStructure()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Environment.CurrentDirectory + "\\updater.cfg");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе     
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Name == "updText")
                {
                    _links.updText = xNode.ChildNodes[0].InnerText;
                }

                if (xNode.Name == "form")
                {
                    _links.form = xNode.ChildNodes[0].InnerText;
                }

                if (xNode.Name == "updater")
                {
                    _links.updater = xNode.ChildNodes[0].InnerText;
                }

                if (xNode.Name == "launcher")
                {
                    _links.launcher = xNode.ChildNodes[0].InnerText;
                }

                if (xNode.Name == "cfg")
                {
                    _links.cfg = xNode.ChildNodes[0].InnerText;
                }
            }
        }
    }
}
