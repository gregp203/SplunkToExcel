using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static String[] MainArgs { get; private set; }
      

        [STAThread]
        static void Main(string[] args)
        {
            MainArgs = args;
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1());   
        }
        
    } 
}
