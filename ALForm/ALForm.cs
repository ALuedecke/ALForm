using ALOra;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ALForm
{
    public partial class ALForm : Form
    {
        private enum MyButtonts
        {
            btnRun
           ,btnExit 
        };

        private int[] mBtnLeft = new int[2];
        private int mDgvWidth;
        private int mDgvHeight;
        private int mRtxtWidth;

        public ALForm()
        {
            InitializeComponent();

            mBtnLeft[(int) MyButtonts.btnRun] = Width - btnRun.Left;
            mBtnLeft[(int)MyButtonts.btnExit] = Width - btnExit.Left;
            mDgvWidth = Width - dgvData.Width;
            mDgvHeight = Height - dgvData.Height;
            mRtxtWidth = Width - rtxtQuery.Width;
        }

        private void fillGrid(string pSql)
        {
            OraDB oradb = new OraDB("pi01_12_PROD", "tina_user", "T73N65_u115e114#");
            string html;

            tsProgBar.Value = 0;
            tsLabel.Text = oradb.Credentials.UserId + "@" + oradb.Credentials.DataSource;
            statStrip.Refresh();

            try
            {
                dgvData.DataSource = oradb.runQuery(pSql);
                dgvData.ReadOnly = true;
                dgvData.Refresh();
                html = oradb.getHtml(oradb.runQuery(pSql));

                for (int i = 0; i < dgvData.RowCount; i++)
                {
                    tsProgBar.Value = i * 100 / (dgvData.RowCount - 1);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "SQL - Error");
            }
        }

        private void ALForm_Resize(object sender, EventArgs e)
        {
            btnRun.Left = Width - mBtnLeft[(int)MyButtonts.btnRun];
            btnExit.Left = Width - mBtnLeft[(int)MyButtonts.btnExit];
            dgvData.Width = Width - mDgvWidth;
            dgvData.Height = Height - mDgvHeight;
            rtxtQuery.Width = Width - mRtxtWidth;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Application.Exit();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            fillGrid(rtxtQuery.Text);
        }

        private void btnRun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                fillGrid(rtxtQuery.Text);
            }
        }

        private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            string idx = (e.RowIndex + 1).ToString();
            StringFormat format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);

            if (e.RowIndex < dgv.RowCount - 1)
            {
                e.Graphics.DrawString(idx, Font, SystemBrushes.ControlText, headerBounds, format);
            }
        }
    }
}
