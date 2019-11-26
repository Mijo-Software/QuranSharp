using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace QuranSharp
{
    public partial class QuranSharpDesktop : Form
    {
        public QuranSharpDesktop()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

            //System.IO.Stream stream = this.GetType().Assembly.GetManifestResourceStream("QuranSharp.Properties.quran_ar.xml");
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load("quran_ar.xml");
            }
            catch (XmlException xmlException)
            {
                MessageBox.Show(xmlException.Message + Environment.NewLine + Environment.NewLine + "Line number: " + xmlException.LineNumber + Environment.NewLine + "Line position: " + xmlException.LinePosition + Environment.NewLine + "Target site: " + xmlException.TargetSite);
            }
            catch (XmlException xmlException)
            {
                MessageBox.Show(xmlException.Message + Environment.NewLine + Environment.NewLine + "Line number: " + xmlException.LineNumber + Environment.NewLine + "Line position: " + xmlException.LinePosition + Environment.NewLine + "Target site: " + xmlException.TargetSite);
            }
        }


    }
}
