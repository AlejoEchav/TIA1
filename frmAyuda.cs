using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmAyuda : Form
    {
        WebBrowser webBrowser1 = new WebBrowser();

        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;

            webBrowser1.ScriptErrorsSuppressed = true;

            this.Controls.Add(webBrowser1);

            string urlAyuda = "https://learn.microsoft.com/es-es/dotnet/desktop/winforms/";
            webBrowser1.Navigate(urlAyuda);
        }
    }
}
