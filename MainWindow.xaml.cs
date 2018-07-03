using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sprawdź_NIP.BIR1;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.Drawing;
using System.Data;
using Microsoft.Win32;
using System.Diagnostics;

namespace Sprawdź_NIP
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string bir1Key = ""; //must write ApiKey from GUS
        static string xmlPath = ""; // must write destination path
        public string inFilename;
        DataTable outTable = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
            nameLabel.Content = "";

        }

        public void downloadDaneSzukaj(string nip)
        {
            if (nip != "")
            {
                if (!File.Exists(xmlPath + "\\DaneSzukaj\\" + nip + ".xml"))
                {
                    string AdresUslugi = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
                    WSHttpBinding myBinding = new WSHttpBinding();
                    myBinding.Security.Mode = SecurityMode.Transport;
                    myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                    myBinding.MessageEncoding = WSMessageEncoding.Mtom;
                    EndpointAddress ea = new EndpointAddress(AdresUslugi);
                    UslugaBIRzewnPublClient cc = new UslugaBIRzewnPublClient(myBinding, ea);
                    cc.Open();
                    string strSID = cc.Zaloguj(bir1Key);
                    using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
                    {
                        HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                        requestMessage.Headers.Add("sid", strSID);
                        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                        //Szukaj
                        ParametryWyszukiwania objParametryGR1 = new ParametryWyszukiwania();
                        objParametryGR1.Nip = nip;
                        string searchXml = cc.DaneSzukaj(objParametryGR1);
                        File.WriteAllText(xmlPath + "\\DaneSzukaj\\" + nip + ".xml", searchXml);
                    }
                }
            }
        }

        public void downloadPublDaneRaportFizycznaOsoba(string regon)
        {
            if (regon != "")
            {
                if (!File.Exists(xmlPath + "\\PublDaneRaportFizycznaOsoba\\" + regon + ".xml"))
                {
                    string AdresUslugi = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
                    WSHttpBinding myBinding = new WSHttpBinding();
                    myBinding.Security.Mode = SecurityMode.Transport;
                    myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                    myBinding.MessageEncoding = WSMessageEncoding.Mtom;
                    EndpointAddress ea = new EndpointAddress(AdresUslugi);
                    UslugaBIRzewnPublClient cc = new UslugaBIRzewnPublClient(myBinding, ea);
                    cc.Open();
                    string strSID = cc.Zaloguj(bir1Key);
                    using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
                    {
                        HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                        requestMessage.Headers.Add("sid", strSID);
                        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                        //Szukaj
                        ParametryWyszukiwania objParametryGR1 = new ParametryWyszukiwania();
                        string xmlFullRaport = cc.DanePobierzPelnyRaport(regon, "PublDaneRaportFizycznaOsoba");
                        File.WriteAllText(xmlPath + "\\PublDaneRaportFizycznaOsoba\\" + regon + ".xml", xmlFullRaport);
                    }
                }
            }
        }

        public void downloadPublDaneRaportPrawna(string regon)
        {
            if (regon != "")
            {
                if (!File.Exists(xmlPath + "\\PublDaneRaportPrawna\\" + regon + ".xml"))
                {
                    string AdresUslugi = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
                    WSHttpBinding myBinding = new WSHttpBinding();
                    myBinding.Security.Mode = SecurityMode.Transport;
                    myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                    myBinding.MessageEncoding = WSMessageEncoding.Mtom;
                    EndpointAddress ea = new EndpointAddress(AdresUslugi);
                    UslugaBIRzewnPublClient cc = new UslugaBIRzewnPublClient(myBinding, ea);
                    cc.Open();
                    string strSID = cc.Zaloguj(bir1Key);
                    using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
                    {
                        HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                        requestMessage.Headers.Add("sid", strSID);
                        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                        //Szukaj
                        ParametryWyszukiwania objParametryGR1 = new ParametryWyszukiwania();
                        string xmlFullRaport = cc.DanePobierzPelnyRaport(regon, "PublDaneRaportPrawna");
                        File.WriteAllText(xmlPath + "\\PublDaneRaportPrawna\\" + regon + ".xml", xmlFullRaport);
                    }
                }
            }
        }

        public void downloadPublDaneRaportDzialalnoscFizycznejCeidg(string regon)
        {
            if (regon != "")
            {
                if (!File.Exists(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg\\" + regon + ".xml"))
                {
                    string AdresUslugi = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
                    WSHttpBinding myBinding = new WSHttpBinding();
                    myBinding.Security.Mode = SecurityMode.Transport;
                    myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                    myBinding.MessageEncoding = WSMessageEncoding.Mtom;
                    EndpointAddress ea = new EndpointAddress(AdresUslugi);
                    UslugaBIRzewnPublClient cc = new UslugaBIRzewnPublClient(myBinding, ea);
                    cc.Open();
                    string strSID = cc.Zaloguj(bir1Key);
                    using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
                    {
                        HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                        requestMessage.Headers.Add("sid", strSID);
                        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                        //Szukaj
                        ParametryWyszukiwania objParametryGR1 = new ParametryWyszukiwania();
                        string xmlFullRaport = cc.DanePobierzPelnyRaport(regon, "PublDaneRaportDzialalnoscFizycznejCeidg");
                        File.WriteAllText(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg\\" + regon + ".xml", xmlFullRaport);
                    }
                }
            }
        }

        public static string RegonFromDaneSzukaj(string nip)
        {
            string regon;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\DaneSzukaj\\" + nip + ".xml");
                regon = xdoc.SelectSingleNode("root/dane/Regon").InnerText;
            }
            catch
            {
                regon = "";
            }
            return regon;
        }

        public static string TypFromDaneSzukaj(string nip)
        {
            string typ;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\DaneSzukaj\\" + nip + ".xml");
                typ = xdoc.SelectSingleNode("root/dane/Typ").InnerText;
            }
            catch
            {
                typ = "";
            }
            return typ;
        }

        private static bool IsValidNip(string input)
        {
            int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
            bool result = false;
            if (input.Length == 10)
            {
                int controlSum = CalculateControlSum(input, weights);
                int controlNum = controlSum % 11;
                if (controlNum == 10)
                {
                    controlNum = 0;
                }
                int lastDigit = int.Parse(input[input.Length - 1].ToString());
                result = controlNum == lastDigit;
        }

            return result;
        }

        private static bool IsValidRegon(string input)
        {
            int controlSum;
            if (input.Length == 7 || input.Length == 9)
            {
                int[] weights = { 8, 9, 2, 3, 4, 5, 6, 7 };
                int offset = 9 - input.Length;
                controlSum = CalculateControlSum(input, weights, offset);
            }
            else if (input.Length == 14)
            {
                int[] weights = { 2, 4, 8, 5, 0, 9, 7, 3, 6, 1, 2, 4, 8 };
                controlSum = CalculateControlSum(input, weights);
            }
            else
            {
                return false;
            }

            int controlNum = controlSum % 11;
            if (controlNum == 10)
            {
                controlNum = 0;
            }

            int lastDigit = int.Parse(input[input.Length - 1].ToString());
            return controlNum == lastDigit;
        }

        public static int CalculateControlSum(string input, int[] weights, int offset = 0)
        {
            int controlSum = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                controlSum += weights[i + offset] * int.Parse(input[i].ToString());
            }
            return controlSum;
        }

        public static string regonFromNIP(string nip, string key)
        {
            try
            {
                string AdresUslugi = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
                WSHttpBinding myBinding = new WSHttpBinding();
                myBinding.Security.Mode = SecurityMode.Transport;
                myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                myBinding.MessageEncoding = WSMessageEncoding.Mtom;
                EndpointAddress ea = new EndpointAddress(AdresUslugi);
                UslugaBIRzewnPublClient cc = new UslugaBIRzewnPublClient(myBinding, ea);
                cc.Open();
                string strSID = cc.Zaloguj(key);
                using (OperationContextScope scope = new OperationContextScope(cc.InnerChannel))
                {
                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers.Add("sid", strSID);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                    //Szukaj
                    ParametryWyszukiwania objParametryGR1 = new ParametryWyszukiwania();
                    objParametryGR1.Nip = nip;
                    string searchXml = cc.DaneSzukaj(objParametryGR1);
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(searchXml);
                    string regon = xdoc.SelectSingleNode("root/dane/Regon").InnerText;
                    return regon;
                }
            }
                catch
            {
                return "";
            }
            }

        public static string rodzajFromPublDaneRaportFizycznaOsoba(string regon)
        {
            string rodzaj = "";
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportFizycznaOsoba\\" + regon + ".xml");
                string ceidg = xdoc.SelectSingleNode("root/dane/fiz_dzialalnosciCeidg").InnerText;
                string rol = xdoc.SelectSingleNode("root/dane/fiz_dzialalnosciRolniczych").InnerText;
                string pozostale = xdoc.SelectSingleNode("root/dane/fiz_dzialalnosciPozostalych").InnerText;
                string krupgn = xdoc.SelectSingleNode("root/dane/fiz_dzialalnosciZKrupgn").InnerText;
                if (ceidg == "1")
                {
                    rodzaj = "CEIDG";
                }
                else if (rol == "1")
                {
                    rodzaj = "Rolnicza";
                }
                else if (pozostale == "1")
                {
                    rodzaj = "Pozostałe";
                }
                else if (krupgn == "1")
                {
                    rodzaj = "KRUPGN";
                }
            }
            catch
            {
                rodzaj = "";
            }
            return rodzaj;
        }

        public static string praw_ZakonczenieDzialalnosci(string regon)
        {
            string data;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportPrawna\\" + regon + ".xml");
                data = xdoc.SelectSingleNode("root/dane/praw_dataZakonczeniaDzialalnosci").InnerText;
            }
            catch
            {
                data = "";
            }
            return data;
        }

        public static string fiz_ZakonczenieDzialalnosci(string regon)
        {
            string data;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg\\" + regon + ".xml");
                data = xdoc.SelectSingleNode("root/dane/fiz_dataZakonczeniaDzialalnosci").InnerText;
            }
            catch
            {
                data = "";
            }
            return data;
        }

        public static string praw_ZawieszeniaDzialalnosci(string regon)
        {
            string data;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportPrawna\\" + regon + ".xml");
                data = xdoc.SelectSingleNode("root/dane/praw_dataZawieszeniaDzialalnosci").InnerText;
            }
            catch
            {
                data = "";
            }
            return data;
        }

        public static string fiz_ZawieszeniaDzialalnosci(string regon)
        {
            string data;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg\\" + regon + ".xml");
                data = xdoc.SelectSingleNode("root/dane/fiz_dataZawieszeniaDzialalnosci").InnerText;
            }
            catch
            {
                data = "";
            }
            return data;
        }

        public static string praw_WznowieniaDzialalnosci(string regon)
        {
            string data;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportPrawna\\" + regon + ".xml");
                data = xdoc.SelectSingleNode("root/dane/praw_dataWznowieniaDzialalnosci").InnerText;
            }
            catch
            {
                data = "";
            }
            return data;
        }

        public static string fiz_WznowieniaDzialalnosci(string regon)
        {
            string data;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg\\" + regon + ".xml");
                data = xdoc.SelectSingleNode("root/dane/fiz_dataWznowieniaDzialalnosci").InnerText;
            }
            catch
            {
                data = "";
            }
            return data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string filename = fileDialog.FileName;
            pathTxtBx.Text = filename;
            inFilename = filename;
            progrBar.IsIndeterminate = true;
        }

        private void loadDataBtn_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo createArch1 = Directory.CreateDirectory(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg");
            DirectoryInfo createArch2 = Directory.CreateDirectory(xmlPath + "\\PublDaneRaportFizycznaOsoba");
            DirectoryInfo createArch3 = Directory.CreateDirectory(xmlPath + "\\PublDaneRaportPrawna");
            DirectoryInfo createArch4 = Directory.CreateDirectory(xmlPath + "\\DaneSzukaj");
            
            if (inFilename == null)
            {
                MessageBox.Show("Wybierz plik do przetworzenia", "Brak pliku", MessageBoxButton.OK, MessageBoxImage.Error);
                progrBar.IsIndeterminate = false;
            }
            else if (!inFilename.Contains(".txt"))
            {
                MessageBox.Show("Proszę podać plik w formacie .txt", "Zły format pliku", MessageBoxButton.OK, MessageBoxImage.Error);
                progrBar.IsIndeterminate = false;
            }
            else if (inFilename.Contains(".txt"))
            {
                string[] nips = System.IO.File.ReadAllLines(inFilename);
                string[] uniqueNips = nips.Distinct().ToArray();
                outTable.Columns.Add("Numer NIP");
                outTable.Columns.Add("Numer REGON");
                outTable.Columns.Add("Czy NIP poprawny?");
                outTable.Columns.Add("Czy podmiot jest aktywny?");
                outTable.Columns.Add("Typ");
                outTable.Columns.Add("Rodzaj rejestru");
                outTable.Columns.Add("Data zamknięcia działalności");
                outTable.Columns.Add("Data zawieszenia działalności");
                outTable.Columns.Add("Data wznowienia działalności");


                foreach(string nip in uniqueNips)
                {
                    outTable.Rows.Add(new Object[] {nip, "" ,IsValidNip(nip)});

                }
                foreach(DataRow row in outTable.Rows)
                {
                    string nip = row[0].ToString();
                    string regon = row[1].ToString();
                    string validnip = row[2].ToString();
                    if (row.ItemArray[2].ToString() != "False")
                    {
                        downloadDaneSzukaj(nip);
                        if (RegonFromDaneSzukaj(nip) == "")
                        {
                            row[3] = "Brak danych";
                        }
                        row[1] = RegonFromDaneSzukaj(nip);
                        row[4] = TypFromDaneSzukaj(nip);
                        if (row[4].ToString() == "F")
                        {
                            downloadPublDaneRaportFizycznaOsoba(row[1].ToString());
                            downloadPublDaneRaportDzialalnoscFizycznejCeidg(row[1].ToString());
                            row[5] = rodzajFromPublDaneRaportFizycznaOsoba(row[1].ToString());
                            row[6] = fiz_ZakonczenieDzialalnosci(row[1].ToString());
                            row[7] = fiz_ZawieszeniaDzialalnosci(row[1].ToString());
                            row[8] = fiz_WznowieniaDzialalnosci(row[1].ToString());
                        }
                        else if(row[4].ToString() == "P")
                        {
                            row[5] = "OS. PRAWNA";
                            downloadPublDaneRaportPrawna(row[1].ToString());
                            row[6] = praw_ZakonczenieDzialalnosci(row[1].ToString());
                            row[7] = praw_ZawieszeniaDzialalnosci(row[1].ToString());
                            row[8] = praw_WznowieniaDzialalnosci(row[1].ToString());
                        }
                        if (row[6].ToString() == "" && row[7].ToString() == "")
                        {
                            row[3] = "AKTYWNY";
                        }
                        else if (row[6].ToString() != "")
                        {
                            row[3] = "NIEAKTYWNY";
                        }
                        else if (row[8].ToString() != "")
                        {
                            row[3] = "AKTYWNY";
                        }
                        else if (row[7].ToString() != "" && row[8].ToString() == "")
                        {
                            row[3] = "NIEAKTYWNY";
                        }
                    }
                    else
                    {
                        row[3] = "Błędny nip";
                    }
                    toExcelBttn.IsEnabled = true;
                }

                dataGrid.DataContext = outTable.DefaultView;
                progrBar.IsIndeterminate = false;
            }

        }

        private void toExcelBttn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);
            excel.Columns.AutoFit();
            for (int i = 1; i < outTable.Columns.Count + 1; i++)
            {
                excel.Cells[1, i] = outTable.Columns[i - 1].ColumnName;
            }

            for (int i = 0; i < outTable.Rows.Count; i++)
            {
                for (int j = 0; j < outTable.Columns.Count; j++)
                {
                    if (outTable.Rows[i][j] != null)
                    {
                        excel.Cells[i + 2, j + 1] = outTable.Rows[i][j].ToString();
                    }
                }
            }
            excel.Columns.AutoFit();
            DateTime actualDate = DateTime.Now;
            string fileName = actualDate.ToString().Replace("-","").Replace(" ", "_").Replace(":", "");
            excel.ActiveWorkbook.SaveCopyAs(xmlPath + "\\" + fileName + ".xlsx");
            Process.Start(xmlPath + "\\" + fileName + ".xlsx");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime actualDate = DateTime.Now;
            string fileName = actualDate.ToString().Replace("-","").Replace(" ", "_").Replace(":", "");
            DirectoryInfo createArch = Directory.CreateDirectory(xmlPath + "\\" + fileName);
                Directory.Move(xmlPath + "\\DaneSzukaj", xmlPath + "\\" + fileName + "\\DaneSzukaj");
                Directory.Move(xmlPath + "\\PublDaneRaportDzialalnoscFizycznejCeidg", xmlPath + "\\" + fileName + "\\PublDaneRaportDzialalnoscFizycznejCeidg");
                Directory.Move(xmlPath + "\\PublDaneRaportFizycznaOsoba", xmlPath + "\\" + fileName + "\\PublDaneRaportFizycznaOsoba");
                Directory.Move(xmlPath + "\\PublDaneRaportPrawna", xmlPath + "\\" + fileName + "\\PublDaneRaportPrawna");

        }
    }
}
