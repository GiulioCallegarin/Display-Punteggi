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
    public partial class frmTabellone : Form
    {
        private Visualizzatore display;
        private const String FONT = "Microsoft Sans Serif";
        private bool bgi = false;
        private bool ctl = false;
        public frmTabellone()
        {
            InitializeComponent();
            Init();
            Check();
        }


        private void Init()
        {
            sizeG1.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeN1.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeP1.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeN2.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeP2.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };

            sizeG2.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeN3.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeP3.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeN4.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeP4.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };

            sizeG3.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeN5.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeP5.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeN6.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };
            sizeP6.DataSource = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 32, 36, 40 };

            sizeG1.SelectedItem = 8;
            sizeN1.SelectedItem = 8;
            sizeP1.SelectedItem = 26;
            sizeN2.SelectedItem = 8;
            sizeP2.SelectedItem = 26;

            txtP1.Text = txtP2.Text = txtP3.Text = txtP4.Text = txtP5.Text = txtP6.Text = "0";

            pnlPreview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPreview3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            display = new Visualizzatore();
            display.Show();
            Update();
        }
        private void Check()
        {
            if (rb1.Checked)
                enableOne();
            if (rb2.Checked)
                enableTwo();
            if (rb3.Checked)
                enableThree();
        }

        private void enableOne()
        {
            pnlPreview1.Visible = true;
            pnlPreview2.Visible = false;
            pnlPreview3.Visible = false;

            pnlPreview1.Enabled = true;
            pnlPreview2.Enabled = false;
            pnlPreview3.Enabled = false;

            grbG1.Visible = true;
            grbG2.Visible = false;
            grbG3.Visible = false;

            grbG1.Enabled = true;
            grbG2.Enabled = false;
            grbG3.Enabled = false;

            //----------------------//

            sizeG1.SelectedItem = (int)lblG1.Font.Size;
            sizeN1.SelectedItem = (int)lblN1_1.Font.Size;
            sizeP1.SelectedItem = (int)lblP1_1.Font.Size;
            sizeN2.SelectedItem = (int)lblN1_2.Font.Size;
            sizeP2.SelectedItem = (int)lblP1_2.Font.Size;
        }

        private void enableTwo()
        {
            pnlPreview1.Visible = false;
            pnlPreview2.Visible = true;
            pnlPreview3.Visible = false;

            pnlPreview1.Enabled = false;
            pnlPreview2.Enabled = true;
            pnlPreview3.Enabled = false;

            grbG1.Visible = true;
            grbG2.Visible = true;
            grbG3.Visible = false;

            grbG1.Enabled = true;
            grbG2.Enabled = true;
            grbG3.Enabled = false;

            //----------------------//

            sizeG1.SelectedItem = (int)lblG2_1.Font.Size;
            sizeN1.SelectedItem = (int)lblN2_1.Font.Size;
            sizeP1.SelectedItem = (int)lblP2_2.Font.Size;
            sizeN2.SelectedItem = (int)lblN2_2.Font.Size;
            sizeP2.SelectedItem = (int)lblP2_2.Font.Size;
            sizeG2.SelectedItem = (int)lblG2_2.Font.Size;
            sizeN3.SelectedItem = (int)lblN2_3.Font.Size;
            sizeP3.SelectedItem = (int)lblP2_3.Font.Size;
            sizeN4.SelectedItem = (int)lblN2_4.Font.Size;
            sizeP4.SelectedItem = (int)lblP2_4.Font.Size;
        }

        private void enableThree()
        {
            pnlPreview1.Visible = false;
            pnlPreview2.Visible = false;
            pnlPreview3.Visible = true;

            pnlPreview1.Enabled = false;
            pnlPreview2.Enabled = false;
            pnlPreview3.Enabled = true;

            grbG1.Visible = true;
            grbG2.Visible = true;
            grbG3.Visible = true;

            grbG1.Enabled = true;
            grbG2.Enabled = true;
            grbG3.Enabled = true;

            //----------------------//

            sizeG1.SelectedItem = (int)lblG3_1.Font.Size;
            sizeN1.SelectedItem = (int)lblN3_1.Font.Size;
            sizeP1.SelectedItem = (int)lblP3_2.Font.Size;
            sizeN2.SelectedItem = (int)lblN3_2.Font.Size;
            sizeP2.SelectedItem = (int)lblP3_2.Font.Size;
            sizeG2.SelectedItem = (int)lblG3_2.Font.Size;
            sizeN3.SelectedItem = (int)lblN3_3.Font.Size;
            sizeP3.SelectedItem = (int)lblP3_3.Font.Size;
            sizeN4.SelectedItem = (int)lblN3_4.Font.Size;
            sizeP4.SelectedItem = (int)lblP3_4.Font.Size;
            sizeG3.SelectedItem = (int)lblG3_3.Font.Size;
            sizeN5.SelectedItem = (int)lblN3_5.Font.Size;
            sizeP5.SelectedItem = (int)lblP3_5.Font.Size;
            sizeN6.SelectedItem = (int)lblN3_6.Font.Size;
            sizeP6.SelectedItem = (int)lblP3_6.Font.Size;
        }

        private Color newColor()
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.CustomColors = new int[] { ColorTranslator.ToOle(Color.FromArgb(229,43,80)) };
            if (dlg.ShowDialog() == DialogResult.OK)
                return dlg.Color;
            return Color.Empty;
        }

        private void Update()
        {
            display.pnlPreview1.BackColor = btnColorBack.BackColor;
            display.pnlPreview2.BackColor = btnColorBack.BackColor;
            display.pnlPreview3.BackColor = btnColorBack.BackColor;
            if (bgi)
            {
                display.pnlPreview1.BackgroundImage = pnlPreview1.BackgroundImage;
                display.pnlPreview2.BackgroundImage = pnlPreview2.BackgroundImage;
                display.pnlPreview3.BackgroundImage = pnlPreview3.BackgroundImage;

                display.pnlPreview1.BackgroundImageLayout = pnlPreview1.BackgroundImageLayout;
                display.pnlPreview2.BackgroundImageLayout = pnlPreview2.BackgroundImageLayout;
                display.pnlPreview3.BackgroundImageLayout = pnlPreview3.BackgroundImageLayout;
            }
            else if (ctl)
            {
                ctl = false;
                try
                {
                    display.pnlPreview1.BackgroundImage.Dispose();
                    display.pnlPreview2.BackgroundImage.Dispose();
                    display.pnlPreview3.BackgroundImage.Dispose();
                }
                catch (Exception ee)
                { }

                display.pnlPreview1.BackgroundImage = null;
                display.pnlPreview2.BackgroundImage = null;
                display.pnlPreview3.BackgroundImage = null;
            }
            if (rb1.Checked)
            {
                display.pnlPreview1.Visible = true;
                display.pnlPreview2.Visible = false;
                display.pnlPreview3.Visible = false;

                display.pnlPreview1.Enabled = true;
                display.pnlPreview2.Enabled = false;
                display.pnlPreview3.Enabled = false;
            }
            else if (rb2.Checked)
            {
                display.pnlPreview1.Visible = false;
                display.pnlPreview2.Visible = true;
                display.pnlPreview3.Visible = false;

                display.pnlPreview1.Enabled = false;
                display.pnlPreview2.Enabled = true;
                display.pnlPreview3.Enabled = false;
            }
            else if (rb3.Checked)
            {
                display.pnlPreview1.Visible = false;
                display.pnlPreview2.Visible = false;
                display.pnlPreview3.Visible = true;

                display.pnlPreview1.Enabled = false;
                display.pnlPreview2.Enabled = false;
                display.pnlPreview3.Enabled = true;
            }

            display.lblG1.Text = lblG1.Text;
            display.lblN1_1.Text = lblN1_1.Text;
            display.lblP1_1.Text = lblP1_1.Text;
            display.lblN1_2.Text = lblN1_2.Text;
            display.lblP1_2.Text = lblP1_2.Text;

            display.lblG2_1.Text = lblG2_1.Text;
            display.lblN2_1.Text = lblN2_1.Text;
            display.lblP2_1.Text = lblP2_1.Text;
            display.lblN2_2.Text = lblN2_2.Text;
            display.lblP2_2.Text = lblP2_2.Text;
            display.lblG2_2.Text = lblG2_2.Text;
            display.lblN2_3.Text = lblN2_3.Text;
            display.lblP2_3.Text = lblP2_3.Text;
            display.lblN2_4.Text = lblN2_4.Text;
            display.lblP2_4.Text = lblP2_4.Text;

            display.lblG3_1.Text = lblG3_1.Text;
            display.lblN3_1.Text = lblN3_1.Text;
            display.lblP3_1.Text = lblP3_1.Text;
            display.lblN3_2.Text = lblN3_2.Text;
            display.lblP3_2.Text = lblP3_2.Text;
            display.lblG3_2.Text = lblG3_2.Text;
            display.lblN3_3.Text = lblN3_3.Text;
            display.lblP3_3.Text = lblP3_3.Text;
            display.lblN3_4.Text = lblN3_4.Text;
            display.lblP3_4.Text = lblP3_4.Text;
            display.lblG3_3.Text = lblG3_3.Text;
            display.lblN3_5.Text = lblN3_5.Text;
            display.lblP3_5.Text = lblP3_5.Text;
            display.lblN3_6.Text = lblN3_6.Text;
            display.lblP3_6.Text = lblP3_6.Text;

            //----------------------------------------//

            display.lblG1.ForeColor = lblG1.ForeColor;
            display.lblN1_1.ForeColor = lblN1_1.ForeColor;
            display.lblP1_1.ForeColor = lblP1_1.ForeColor;
            display.lblN1_2.ForeColor = lblN1_2.ForeColor;
            display.lblP1_2.ForeColor = lblP1_2.ForeColor;

            display.lblG2_1.ForeColor = lblG2_1.ForeColor;
            display.lblN2_1.ForeColor = lblN2_1.ForeColor;
            display.lblP2_1.ForeColor = lblP2_1.ForeColor;
            display.lblN2_2.ForeColor = lblN2_2.ForeColor;
            display.lblP2_2.ForeColor = lblP2_2.ForeColor;
            display.lblG2_2.ForeColor = lblG2_2.ForeColor;
            display.lblN2_3.ForeColor = lblN2_3.ForeColor;
            display.lblP2_3.ForeColor = lblP2_3.ForeColor;
            display.lblN2_4.ForeColor = lblN2_4.ForeColor;
            display.lblP2_4.ForeColor = lblP2_4.ForeColor;

            display.lblG3_1.ForeColor = lblG3_1.ForeColor;
            display.lblN3_1.ForeColor = lblN3_1.ForeColor;
            display.lblP3_1.ForeColor = lblP3_1.ForeColor;
            display.lblN3_2.ForeColor = lblN3_2.ForeColor;
            display.lblP3_2.ForeColor = lblP3_2.ForeColor;
            display.lblG3_2.ForeColor = lblG3_2.ForeColor;
            display.lblN3_3.ForeColor = lblN3_3.ForeColor;
            display.lblP3_3.ForeColor = lblP3_3.ForeColor;
            display.lblN3_4.ForeColor = lblN3_4.ForeColor;
            display.lblP3_4.ForeColor = lblP3_4.ForeColor;
            display.lblG3_3.ForeColor = lblG3_3.ForeColor;
            display.lblN3_5.ForeColor = lblN3_5.ForeColor;
            display.lblP3_5.ForeColor = lblP3_5.ForeColor;
            display.lblN3_6.ForeColor = lblN3_6.ForeColor;
            display.lblP3_6.ForeColor = lblP3_6.ForeColor;

            //----------------------------------------//

            display.lblG1.Font = lblG1.Font;
            display.lblN1_1.Font = lblN1_1.Font;
            display.lblP1_1.Font = lblP1_1.Font;
            display.lblN1_2.Font = lblN1_2.Font;
            display.lblP1_2.Font = lblP1_2.Font;

            display.lblG2_1.Font = lblG2_1.Font;
            display.lblN2_1.Font = lblN2_1.Font;
            display.lblP2_1.Font = lblP2_1.Font;
            display.lblN2_2.Font = lblN2_2.Font;
            display.lblP2_2.Font = lblP2_2.Font;
            display.lblG2_2.Font = lblG2_2.Font;
            display.lblN2_3.Font = lblN2_3.Font;
            display.lblP2_3.Font = lblP2_3.Font;
            display.lblN2_4.Font = lblN2_4.Font;
            display.lblP2_4.Font = lblP2_4.Font;

            display.lblG3_1.Font = lblG3_1.Font;
            display.lblN3_1.Font = lblN3_1.Font;
            display.lblP3_1.Font = lblP3_1.Font;
            display.lblN3_2.Font = lblN3_2.Font;
            display.lblP3_2.Font = lblP3_2.Font;
            display.lblG3_2.Font = lblG3_2.Font;
            display.lblN3_3.Font = lblN3_3.Font;
            display.lblP3_3.Font = lblP3_3.Font;
            display.lblN3_4.Font = lblN3_4.Font;
            display.lblP3_4.Font = lblP3_4.Font;
            display.lblG3_3.Font = lblG3_3.Font;
            display.lblN3_5.Font = lblN3_5.Font;
            display.lblP3_5.Font = lblP3_5.Font;
            display.lblN3_6.Font = lblN3_6.Font;
            display.lblP3_6.Font = lblP3_6.Font;
        }


        //--------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------------------------------------//


        private void btnLoadBack_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                txtImageBack.Text = theDialog.FileName;
                pnlPreview1.BackgroundImage = Image.FromFile(theDialog.FileName);
                pnlPreview2.BackgroundImage = Image.FromFile(theDialog.FileName);
                pnlPreview3.BackgroundImage = Image.FromFile(theDialog.FileName);
                bgi = true;
            }
        }

        private void btnCancellaBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler cancellare il background?", "Cancellare?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bgi = false;
                ctl = true;
                txtImageBack.Text = "";
                pnlUnicorn.Visible = false;
                display.pnlUnicorn.Visible = false;
                try
                {
                    pnlPreview1.BackgroundImage.Dispose();
                    pnlPreview2.BackgroundImage.Dispose();
                    pnlPreview3.BackgroundImage.Dispose();
                }
                catch (Exception ee)
                { }

                pnlPreview1.BackgroundImage = null;
                pnlPreview2.BackgroundImage = null;
                pnlPreview3.BackgroundImage = null;
            }
        }

        private void btnColorBack_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                btnColorBack.BackColor = banana;
                pnlPreview1.BackColor = banana;
                pnlPreview2.BackColor = banana;
                pnlPreview3.BackColor = banana;
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void colorG1_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorG1.BackColor = banana;
                lblG1.ForeColor = banana;
                lblG2_1.ForeColor = banana;
                lblG3_1.ForeColor = banana;
            }
        }

        private void colorN1_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorN1.BackColor = banana;
                lblN1_1.ForeColor = banana;
                lblN2_1.ForeColor = banana;
                lblN3_1.ForeColor = banana;
            }
        }

        private void colorP1_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorP1.BackColor = banana;
                lblP1_1.ForeColor = banana;
                lblP2_1.ForeColor = banana;
                lblP3_1.ForeColor = banana;
            }
        }

        private void colorN2_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorN2.BackColor = banana;
                lblN1_2.ForeColor = banana;
                lblN2_2.ForeColor = banana;
                lblN3_2.ForeColor = banana;
            }
        }

        private void colorP2_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorP2.BackColor = banana;
                lblP1_2.ForeColor = banana;
                lblP2_2.ForeColor = banana;
                lblP3_2.ForeColor = banana;
            }
        }

        private void colorG2_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorG2.BackColor = banana;
                lblG2_2.ForeColor = banana;
                lblG3_2.ForeColor = banana;
            }
        }

        private void colorN3_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorN3.BackColor = banana;
                lblN2_3.ForeColor = banana;
                lblN3_3.ForeColor = banana;
            }
        }

        private void colorP3_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorP3.BackColor = banana;
                lblP2_3.ForeColor = banana;
                lblP3_3.ForeColor = banana;
            }
        }

        private void colorN4_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorN4.BackColor = banana;
                lblN2_4.ForeColor = banana;
                lblN3_4.ForeColor = banana;
            }
        }

        private void colorP4_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorP4.BackColor = banana;
                lblP2_4.ForeColor = banana;
                lblP3_4.ForeColor = banana;
            }
        }

        private void colorG3_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorG3.BackColor = banana;
                lblG3_3.ForeColor = banana;
            }
        }

        private void colorN5_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorN5.BackColor = banana;
                lblN3_5.ForeColor = banana;
            }
        }

        private void colorP5_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorP5.BackColor = banana;
                lblP3_5.ForeColor = banana;
            }
        }

        private void colorN6_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorN6.BackColor = banana;
                lblN3_6.ForeColor = banana;
            }
        }

        private void colorP6_Click(object sender, EventArgs e)
        {
            Color banana = new Color();
            banana = newColor();
            if (banana != Color.Empty)
            {
                colorP6.BackColor = banana;
                lblP3_6.ForeColor = banana;
            }
        }

        private void txtG1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblG1.Text = lblG2_1.Text = lblG3_1.Text = txtG1.Text;
            }
        }

        private void txtN1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblN1_1.Text = lblN2_1.Text = lblN3_1.Text = txtN1.Text;
            }
        }

        private void txtP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblP1_1.Text = lblP2_1.Text = lblP3_1.Text = txtP1.Text;
            }
        }

        private void txtN2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblN1_2.Text = lblN2_2.Text = lblN3_2.Text = txtN2.Text;
            }
        }

        private void txtP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblP1_2.Text = lblP2_2.Text = lblP3_2.Text = txtP2.Text;
            }
        }

        private void txtG2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblG2_2.Text = lblG3_2.Text = txtG2.Text;
            }
        }

        private void txtN3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblN2_3.Text = lblN3_3.Text = txtN3.Text;
            }
        }

        private void txtP3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblP2_3.Text = lblP3_3.Text = txtP3.Text;
            }
        }

        private void txtN4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblN2_4.Text = lblN3_4.Text = txtN4.Text;
            }
        }

        private void txtP4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblP2_4.Text = lblP3_4.Text = txtP4.Text;
            }
        }

        private void txtG3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblG3_3.Text = txtG3.Text;
            }
        }

        private void txtN5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblN3_5.Text = txtN5.Text;
            }
        }

        private void txtP5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblP3_5.Text = txtP5.Text;
            }
        }

        private void txtN6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblN3_6.Text = txtN6.Text;
            }
        }

        private void txtP6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblP3_6.Text = txtP6.Text;
            }
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            if (display.pnlPausa.Enabled)
            {
                btnPausa.Text = "Pausa";
                display.pnlPausa.Enabled = false;
                display.pnlPausa.Visible = false;
            }
            else
            {
                btnPausa.Text = "Riprendi";
                display.pnlPausa.Enabled = true;
                display.pnlPausa.Visible = true;
            }
        }

        private void sizeG1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                lblG1.Font = new Font(FONT, int.Parse(sizeG1.SelectedItem.ToString()));
            }
            else if (rb2.Checked)
            {
                lblG2_1.Font = new Font(FONT, int.Parse(sizeG1.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblG3_1.Font = new Font(FONT, int.Parse(sizeG1.SelectedItem.ToString()));
            }
        }

        private void sizeN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                lblN1_1.Font = new Font(FONT, int.Parse(sizeN1.SelectedItem.ToString()));
            }
            else if (rb2.Checked)
            {
                lblN2_1.Font = new Font(FONT, int.Parse(sizeN1.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblN3_1.Font = new Font(FONT, int.Parse(sizeN1.SelectedItem.ToString()));
            }
        }

        private void sizeP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                lblP1_1.Font = new Font(FONT, int.Parse(sizeP1.SelectedItem.ToString()));
            }
            else if (rb2.Checked)
            {
                lblP2_1.Font = new Font(FONT, int.Parse(sizeP1.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblP3_1.Font = new Font(FONT, int.Parse(sizeP1.SelectedItem.ToString()));
            }
        }

        private void sizeN2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                lblN1_2.Font = new Font(FONT, int.Parse(sizeN2.SelectedItem.ToString()));
            }
            else if (rb2.Checked)
            {
                lblN2_2.Font = new Font(FONT, int.Parse(sizeN2.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblN3_2.Font = new Font(FONT, int.Parse(sizeN2.SelectedItem.ToString()));
            }
        }

        private void sizeP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                lblP1_2.Font = new Font(FONT, int.Parse(sizeP2.SelectedItem.ToString()));
            }
            else if (rb2.Checked)
            {
                lblP2_2.Font = new Font(FONT, int.Parse(sizeP2.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblP3_2.Font = new Font(FONT, int.Parse(sizeP2.SelectedItem.ToString()));
            }
        }

        private void sizeG2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                lblG2_2.Font = new Font(FONT, int.Parse(sizeG2.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblG3_2.Font = new Font(FONT, int.Parse(sizeG2.SelectedItem.ToString()));
            }
        }

        private void sizeN3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                lblN2_3.Font = new Font(FONT, int.Parse(sizeN3.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblN3_3.Font = new Font(FONT, int.Parse(sizeN3.SelectedItem.ToString()));
            }
        }

        private void sizeP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                lblP2_3.Font = new Font(FONT, int.Parse(sizeP3.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblP3_3.Font = new Font(FONT, int.Parse(sizeP3.SelectedItem.ToString()));
            }
        }

        private void sizeN4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                lblN2_4.Font = new Font(FONT, int.Parse(sizeN4.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblN3_4.Font = new Font(FONT, int.Parse(sizeN4.SelectedItem.ToString()));
            }
        }

        private void sizeP4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                lblP2_4.Font = new Font(FONT, int.Parse(sizeP4.SelectedItem.ToString()));
            }
            else if (rb3.Checked)
            {
                lblP3_4.Font = new Font(FONT, int.Parse(sizeP4.SelectedItem.ToString()));
            }
        }

        private void sizeG3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                lblG3_3.Font = new Font(FONT, int.Parse(sizeG3.SelectedItem.ToString()));
            }
        }

        private void sizeN5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                lblN3_5.Font = new Font(FONT, int.Parse(sizeN5.SelectedItem.ToString()));
            }
        }

        private void sizeP5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                lblP3_5.Font = new Font(FONT, int.Parse(sizeP5.SelectedItem.ToString()));
            }
        }

        private void sizeN6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                lblN3_6.Font = new Font(FONT, int.Parse(sizeN6.SelectedItem.ToString()));
            }
        }

        private void sizeP6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                lblP3_6.Font = new Font(FONT, int.Parse(sizeP6.SelectedItem.ToString()));
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            txtP1.Text = (int.Parse(txtP1.Text) + 1).ToString();
            lblP1_1.Text = lblP2_1.Text = lblP3_1.Text = txtP1.Text;
            display.lblP1_1.Text = display.lblP2_1.Text = display.lblP3_1.Text = txtP1.Text;
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            txtP1.Text = (int.Parse(txtP1.Text) - 1).ToString();
            lblP1_1.Text = lblP2_1.Text = lblP3_1.Text = txtP1.Text;
            display.lblP1_1.Text = display.lblP2_1.Text = display.lblP3_1.Text = txtP1.Text;
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            txtP2.Text = (int.Parse(txtP2.Text) + 1).ToString();
            lblP1_2.Text = lblP2_2.Text = lblP3_2.Text = txtP2.Text;
            display.lblP1_2.Text = display.lblP2_2.Text = display.lblP3_2.Text = txtP2.Text;
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            txtP2.Text = (int.Parse(txtP2.Text) - 1).ToString();
            lblP1_2.Text = lblP2_2.Text = lblP3_2.Text = txtP2.Text;
            display.lblP1_2.Text = display.lblP2_2.Text = display.lblP3_2.Text = txtP2.Text;
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            txtP3.Text = (int.Parse(txtP3.Text) + 1).ToString();
            lblP2_3.Text = lblP3_3.Text = txtP3.Text;
            display.lblP2_3.Text = display.lblP3_3.Text = txtP3.Text;
        }

        private void btnMinus3_Click(object sender, EventArgs e)
        {
            txtP3.Text = (int.Parse(txtP3.Text) - 1).ToString();
            lblP2_3.Text = lblP3_3.Text = txtP3.Text;
            display.lblP2_3.Text = display.lblP3_3.Text = txtP3.Text;
        }

        private void btnPlus4_Click(object sender, EventArgs e)
        {
            txtP4.Text = (int.Parse(txtP4.Text) + 1).ToString();
            lblP2_4.Text = lblP3_4.Text = txtP4.Text;
            display.lblP2_4.Text = display.lblP3_4.Text = txtP4.Text;
        }

        private void btnMinus4_Click(object sender, EventArgs e)
        {
            txtP4.Text = (int.Parse(txtP4.Text) - 1).ToString();
            lblP2_4.Text = lblP3_4.Text = txtP4.Text;
            display.lblP2_4.Text = display.lblP3_4.Text = txtP4.Text;
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            txtP5.Text = (int.Parse(txtP5.Text) + 1).ToString();
            lblP3_5.Text = txtP5.Text;
            display.lblP3_5.Text = txtP5.Text;
        }

        private void btnMinus5_Click(object sender, EventArgs e)
        {
            txtP5.Text = (int.Parse(txtP5.Text) - 1).ToString();
            lblP3_5.Text = txtP5.Text;
            display.lblP3_5.Text = txtP5.Text;
        }

        private void btnPlus6_Click(object sender, EventArgs e)
        {
            txtP6.Text = (int.Parse(txtP6.Text) + 1).ToString();
            lblP3_6.Text = txtP6.Text;
            display.lblP3_6.Text = txtP6.Text;
        }

        private void btnMinus6_Click(object sender, EventArgs e)
        {
            txtP6.Text = (int.Parse(txtP6.Text) - 1).ToString();
            lblP3_6.Text = txtP6.Text;
            display.lblP3_6.Text = txtP6.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler cancellare tutto?", "Cancellare?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (bgi)
                {
                    try
                    {
                        pnlPreview1.BackgroundImage.Dispose();
                        pnlPreview2.BackgroundImage.Dispose();
                        pnlPreview3.BackgroundImage.Dispose();

                        pnlPreview1.BackgroundImage = null;
                        pnlPreview2.BackgroundImage = null;
                        pnlPreview3.BackgroundImage = null;
                    }
                    catch (Exception ee) { }
                }

                bgi = false;
                ctl = true;
                txtImageBack.Text = "";

                pnlUnicorn.Visible = false;

                btnColorBack.BackColor = Color.Black;
                pnlPreview1.BackColor = Color.Black;
                pnlPreview2.BackColor = Color.Black;
                pnlPreview3.BackColor = Color.Black;


                rbZoom.Checked = true;



                //--------------------------------//

                lblG1.Text = "Gara";
                lblN1_1.Text = "Nome1";
                lblP1_1.Text = "0";
                lblN1_2.Text = "Nome2";
                lblP1_2.Text = "0";

                lblG2_1.Text = "Gara1";
                lblN2_1.Text = "Nome1";
                lblP2_1.Text = "0";
                lblN2_2.Text = "Nome2";
                lblP2_2.Text = "0";
                lblG2_2.Text = "Gara2";
                lblN2_3.Text = "Nome3";
                lblP2_3.Text = "0";
                lblN2_4.Text = "Nome4";
                lblP2_4.Text = "0";

                lblG3_1.Text = "Gara1";
                lblN3_1.Text = "Nome1";
                lblP3_1.Text = "0";
                lblN3_2.Text = "Nome2";
                lblP3_2.Text = "0";
                lblG3_2.Text = "Gara2";
                lblN3_3.Text = "Nome3";
                lblP3_3.Text = "0";
                lblN3_4.Text = "Nome4";
                lblP3_4.Text = "0";
                lblG3_3.Text = "Gara3";
                lblN3_5.Text = "Nome5";
                lblP3_5.Text = "0";
                lblN3_6.Text = "Nome6";
                lblP3_6.Text = "0";

                //--------------------------------//

                lblG1.ForeColor = Color.White;
                lblN1_1.ForeColor = Color.FromArgb(229,43,80);
                lblP1_1.ForeColor = Color.White;
                lblN1_2.ForeColor = Color.White;
                lblP1_2.ForeColor = Color.White;

                lblG2_1.ForeColor = Color.White;
                lblN2_1.ForeColor = Color.FromArgb(229, 43, 80);
                lblP2_1.ForeColor = Color.White;
                lblN2_2.ForeColor = Color.White;
                lblP2_2.ForeColor = Color.White;
                lblG2_2.ForeColor = Color.White;
                lblN2_3.ForeColor = Color.FromArgb(229, 43, 80);
                lblP2_3.ForeColor = Color.White;
                lblN2_4.ForeColor = Color.White;
                lblP2_4.ForeColor = Color.White;

                lblG3_1.ForeColor = Color.White;
                lblN3_1.ForeColor = Color.FromArgb(229, 43, 80);
                lblP3_1.ForeColor = Color.White;
                lblN3_2.ForeColor = Color.White;
                lblP3_2.ForeColor = Color.White;
                lblG3_2.ForeColor = Color.White;
                lblN3_3.ForeColor = Color.FromArgb(229, 43, 80);
                lblP3_3.ForeColor = Color.White;
                lblN3_4.ForeColor = Color.White;
                lblP3_4.ForeColor = Color.White;
                lblG3_3.ForeColor = Color.White;
                lblN3_5.ForeColor = Color.FromArgb(229, 43, 80);
                lblP3_5.ForeColor = Color.White;
                lblN3_6.ForeColor = Color.White;
                lblP3_6.ForeColor = Color.White;

                //--------------------------------//

                lblG1.Font = new Font(FONT, 8);
                lblN1_1.Font = new Font(FONT, 8);
                lblP1_1.Font = new Font(FONT, 26);
                lblN1_2.Font = new Font(FONT, 8);
                lblP1_2.Font = new Font(FONT, 26);

                lblG2_1.Font = new Font(FONT, 8);
                lblN2_1.Font = new Font(FONT, 8);
                lblP2_1.Font = new Font(FONT, 18);
                lblN2_2.Font = new Font(FONT, 8);
                lblP2_2.Font = new Font(FONT, 18);
                lblG2_2.Font = new Font(FONT, 8);
                lblN2_3.Font = new Font(FONT, 8);
                lblP2_3.Font = new Font(FONT, 18);
                lblN2_4.Font = new Font(FONT, 8);
                lblP2_4.Font = new Font(FONT, 18);

                lblG3_1.Font = new Font(FONT, 7);
                lblN3_1.Font = new Font(FONT, 7);
                lblP3_1.Font = new Font(FONT, 14);
                lblN3_2.Font = new Font(FONT, 7);
                lblP3_2.Font = new Font(FONT, 14);
                lblG3_2.Font = new Font(FONT, 7);
                lblN3_3.Font = new Font(FONT, 7);
                lblP3_3.Font = new Font(FONT, 14);
                lblN3_4.Font = new Font(FONT, 7);
                lblP3_4.Font = new Font(FONT, 14);
                lblG3_3.Font = new Font(FONT, 7);
                lblN3_5.Font = new Font(FONT, 7);
                lblP3_5.Font = new Font(FONT, 14);
                lblN3_6.Font = new Font(FONT, 7);
                lblP3_6.Font = new Font(FONT, 14);

                //-----------------------------------//

                colorG1.BackColor = Color.White;
                colorN1.BackColor = Color.FromArgb(229, 43, 80);
                colorP1.BackColor = Color.White;
                colorN2.BackColor = Color.White;
                colorP2.BackColor = Color.White;

                colorG2.BackColor = Color.White;
                colorN3.BackColor = Color.FromArgb(229, 43, 80);
                colorP3.BackColor = Color.White;
                colorN4.BackColor = Color.White;
                colorP4.BackColor = Color.White;

                colorG3.BackColor = Color.White;
                colorN5.BackColor = Color.FromArgb(229, 43, 80);
                colorP5.BackColor = Color.White;
                colorN6.BackColor = Color.White;
                colorP6.BackColor = Color.White;

                //-------------------------------------//

                txtG1.Text = txtN1.Text = txtN2.Text = txtG2.Text = txtN3.Text = txtN4.Text = txtG3.Text = txtN5.Text = txtN6.Text = "";
                txtP1.Text = txtP2.Text = txtP3.Text = txtP4.Text = txtP5.Text = txtP6.Text = "0";
                Check();
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Banana o Eucalipto?", "Bau?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ottima scelta", "Bau Bau!!");
                pnlUnicorn.Visible = true;
                display.pnlUnicorn.Visible = true;
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Persona triste", "Bau Aargh");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Mmmmmmmmmmm", "Miao");
            }
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            pnlPreview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlPreview3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlUnicorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            pnlPreview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlPreview3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlUnicorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
