using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErkamAbiyeStok
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        Frmslider fsl;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fsl == null)
            {
                fsl = new Frmslider();
                fsl.MdiParent = this;
                fsl.Show();
            }
            else
            {
                fsl = new Frmslider();
                fsl.MdiParent = this;
                fsl.Show();
            }
        }

        FrmUrunler fs;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fs == null)
            {
                fs = new FrmUrunler();
                fs.MdiParent = this;
                fs.Show();
            }
            else {
                fs = new FrmUrunler();
                fs.MdiParent = this;
                fs.Show();
            }
        }
        FrmUrunArama fua;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fua == null)
            {
                fua = new FrmUrunArama();
                fua.MdiParent = this;
                fua.Show();
            }
            else {
                fua = new FrmUrunArama();
                fua.MdiParent = this;
                fua.Show();
            }
        }
        FrmMusteriler frm;
        private void BtnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null)
            {
                frm = new FrmMusteriler();
                frm.MdiParent = this;
                frm.Show();
            }
            else {
                frm = new FrmMusteriler();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        FrmFirmalar frf;
        private void BtnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frf == null)
            {
                frf = new FrmFirmalar();
                frf.MdiParent = this;
                frf.Show();
            }
            else {
                frf = new FrmFirmalar();
                frf.MdiParent = this;
                frf.Show();
            }
        }
        FrmSatıs frs;
        private void BtnSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frs == null)
            {
                frs = new FrmSatıs();
                frs.MdiParent = this;
                frs.Show();
            }
            else {
                frs = new FrmSatıs();
                frs.MdiParent = this;
                frs.Show();
            }
        }
        FrmSatısListele frsl;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frsl == null)
            {
                frsl = new FrmSatısListele();
                frsl.MdiParent = this;
                frsl.Show();
            }
            else {
                frsl = new FrmSatısListele();
                frsl.MdiParent = this;
                frsl.Show();
            }
        }
        FrmSatisKisi fsk;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fsk == null) {
                fsk = new FrmSatisKisi();
                fsk.MdiParent = this;
                fsk.Show();
            }
            else
            {
                fsk = new FrmSatisKisi();
                fsk.MdiParent = this;
                fsk.Show();
            }
        }
        FrmSatısdüzenleme fsa;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fsa == null)
            {
                fsa = new FrmSatısdüzenleme();
                fsa.MdiParent = this;
                fsa.Show();
                return;
            }
            else {
                fsa = new FrmSatısdüzenleme();
                fsa.MdiParent = this;
                fsa.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        Frmgorsel frg;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frg == null)
            {
                frg = new Frmgorsel();
                frg.MdiParent = this;
                frg.Show();
                return;
            }
            else
            {
                frg = new Frmgorsel();
                frg.MdiParent = this;
                frg.Show();
            }
        }
        Frmİade fri;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fri == null)
            {
                fri = new Frmİade();
                fri.MdiParent = this;
                fri.Show();
                return;
            }
            else
            {
                fri = new Frmİade();
                fri.MdiParent = this;
                fri.Show();
            }
        }

        FrmYedek fryk;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fri == null)
            {
                fryk = new FrmYedek();
                fryk.MdiParent = this;
                fryk.Show();
                return;
            }
            else
            {
                fryk = new FrmYedek();
                fryk.MdiParent = this;
                fryk.Show();
            }
        }
    }
}
