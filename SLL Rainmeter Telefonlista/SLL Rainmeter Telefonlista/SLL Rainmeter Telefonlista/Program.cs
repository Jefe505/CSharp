using System;
using System.Text;
using System.IO;
using System.Xml;

namespace SLL_Rainmeter_Telefonlista
{
    public class MainProgram
    {
        public void YourMethod(String namn, String hsaid, String intern, String mobil)
        {
            // Do something with strFirst and strLast.
            Console.WriteLine("{0}, {1}, {2}, {3}", namn, hsaid, intern, mobil);
            return;
        }
        public void ReadXML(String xmlText)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlText);
            // alternately, _doc.Load( _strFilename); to read from a file.
            XmlNodeList namn = doc.GetElementsByTagName("namn");
            XmlNodeList hsaid = doc.GetElementsByTagName("hsaid");
            XmlNodeList intern = doc.GetElementsByTagName("interntel");
            XmlNodeList mobil = doc.GetElementsByTagName("mobiltel");
            // I'm assuming every FirstName has a LastName in this example, your requirements may vary. // 
            for (int i = 0; i < namn.Count; ++i)
            {
                FillList(namn[i].InnerText, hsaid[i].InnerText, intern[i].InnerText, mobil[i].InnerText);
            }

            return;
        }

        private void FillList(string namn, string hsaid, string intern, string mobil)
        {
            
        }

        private void WriteRMInit()
        {
            for (int i = 0; i < 0; i++)
                CreateRMSkin(namn[i].InnerText, hsaid[i].InnerText, intern[i].InnerText, mobil[i].InnerText);
        }
        public void CreateRMSkin(String namn, String hsaid, String intern, String mobil)
        {
            CopyInit();
            TextWriter writer = new StreamWriter("Personal.ini");
            String[] meters = new String[3];

            meters = CreateMeterGroup(namn, hsaid, intern, mobil));
            for (int i=0; i < 3; i++)
            {
                writer.WriteLine(meters[i]);
            }
            writer.Close();
            return;
        }
        private String[] CreateMeterGroup(String namn, String hsaid, String intern, String mobil)
        {
            int i=0;
            String[] a = new String[3];
            String[] X = new String[] {"0", "200r" , "166r"};
            String[] W = new String[] {"200", "166" , "134"};
            String meterConfig1 = "]\\Meter=String\\X=";
            String meterConfig2 = "\\Y=0R\\H=20\\W=";
            String meterConfig3 = "\\MeterStyle=TextStyle\\SolidColor=#bakgrund.ColorTitel#\\StringStyle=#font.StyleTitel#\\FontSize=#font.SizeTitel#\\MouseOverAction=!SetOptionGroup " + hsaid + " SolidColor #bakgrund.ColorIn\\MouseLeaveAction=!SetOptionGroup " + hsaid + " SolidColor #bakgrund.Color##\\Group=" + hsaid + "\\Text=""";

       	    a[0] = "[metText" + hsaid + meterConfig1 + X[i] + meterConfig2 + W + meterConfig3 + namn + "\"";
            i++;
       	    a[1] = "[metText" + hsaid + meterConfig1 + X[i] + meterConfig2 + W + meterConfig3 + intern + " - " + hsaid + "\"";
            i++;
       	    a[2] = "[metText" + hsaid + meterConfig1 + X[i] + meterConfig2 + W + meterConfig3 + mobil + "\"";

            return a;
        }
        public void CopyInit()
        {
            StreamReader readPersonal = new StreamReader("PersonalRMInit.txt");
            StreamWriter writePersonal = new StreamWriter("Personal.ini");

            writePersonal.WriteLine(readPersonal.ReadLine());

            writePersonal.Close();
            readPersonal.Close();
            return;
        }
        public static void Main(String[] args)
        {
            XMLApp _app = new XMLApp();
            // Passing XML text as a String, you can also use the
            // XMLDocument::Load( ) method to read the XML from a file.
            _app.ReadXML(@"<personal><person><namn>Carl Landberg</namn><hsaid>6G1W</hsaid><interntel>785 92</interntel><mobiltel>073-702 44 88</mobiltel></person><person><namn>Alexander Ratajc</namn><hsaid>6740</hsaid><interntel>785 71</interntel><mobiltel>070 479 91 78</mobiltel></person></personal>");
        }
    }
}