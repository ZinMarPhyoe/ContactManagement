using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ContactManagement
{
    internal static class Program
    {
        static void Main()
        {            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

    }
}