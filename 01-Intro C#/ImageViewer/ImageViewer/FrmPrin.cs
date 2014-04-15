using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Carrega imagem caso a janela de arquivo resulte em OK.
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog.FileName);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnMudarFundo_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog.Color;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAlongar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlongar.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
