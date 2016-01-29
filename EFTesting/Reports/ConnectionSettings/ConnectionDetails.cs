using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace ITRACK.DBConfiguration
{
    class ConnectionDetails
    {


        public static void writeConnection(string Connection_String)
        {
            try
            {
                string connectionPath = "product.xml";
                XmlTextWriter writer = new XmlTextWriter("product.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Application_Configaration");

                writer.WriteStartElement("Connection");
                writer.WriteStartElement("Connection_String");
                writer.WriteString(Connection_String);
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("Connection String File Created", "Connection Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
            }


        }

        public  string readConnection()
        {

            string connectionString = "";
            XmlTextReader m_xmlr = default(XmlTextReader);
            //Create the XML Reader

            m_xmlr = new XmlTextReader("product.xml");
            //Disable whitespace so that you don't have to read over whitespaces

            m_xmlr.WhitespaceHandling = WhitespaceHandling.None;
            //read the xml declaration and advance to family tag

            m_xmlr.Read();
            //read the family tag

            m_xmlr.Read();
            //Load the Loop

            while (!m_xmlr.EOF)
            {
                //Go to the name tag

                m_xmlr.Read();
                //if not start element exit while loop

                if (!m_xmlr.IsStartElement())
                {
                    break; // TODO: might not be correct. Was : Exit While
                }
                //Get the Gender Attribute Value

                dynamic Attribute = m_xmlr.GetAttribute("Application_Configaration");
                //Read elements firstname and lastname

                m_xmlr.Read();
                //Get the firstName Element Value

                connectionString = m_xmlr.ReadElementString("Connection_String");



            }
            //close the reader

            m_xmlr.Close();
            return connectionString;



        }
    }
}
