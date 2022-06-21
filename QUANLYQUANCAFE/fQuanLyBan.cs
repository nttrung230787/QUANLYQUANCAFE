using QUANLYQUANCAFE.Model;
using QUANLYQUANCAFE.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANCAFE
{
    public partial class fQuanLyBan : Form
    {
        public fQuanLyBan()
        {
            InitializeComponent();
            loadDanhSachBan();
        }

        #region Method
        void loadDanhSachBan()
        {
            List<BAN> lb = BanDAO.Instance.LoadTableList();
            foreach (BAN item in lb)
            {
                Button bt = new Button() { Width = BanDAO.TableWidth = 100, Height = BanDAO.TableHeight = 100 };
                bt.Text = item.Name + "\n" + "\n" + item.Status;
                switch (item.Status)
                {
                    case ("Trống"):
                        bt.BackColor = Color.Aqua;
                        break;
                    default:
                        bt.BackColor = Color.LightPink;
                        break;
                }


                flowLayoutPanel1.Controls.Add(bt) ;
            }
        }

        #endregion

        #region EVENT
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLy f = new fQuanLy();
            this.Hide();
            f.ShowDialog();
        }
        #endregion
    }
}
