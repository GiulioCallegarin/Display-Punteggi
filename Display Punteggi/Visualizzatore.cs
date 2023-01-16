using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Punteggi
{
    public partial class Visualizzatore : Form
    {
        public Visualizzatore()
        {
            InitializeComponent();
        }

        private void Init()
        {
            pnlPreview1.Enabled = true;
            pnlPreview2.Enabled = false;
            pnlPreview3.Enabled = false;
            pnlPreview1.Visible = true;
            pnlPreview2.Visible = false;
            pnlPreview3.Visible = false;

            pnlPreview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPreview3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        }

        private void lblN2_2_Click(object sender, EventArgs e)
        {

        }

        private void pnlUnicorn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
