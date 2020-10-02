namespace ToldecaAppCore
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public partial class FrmBase : Form
    {
        frmCargando loadingForm = new frmCargando();

        public FrmBase()
        {
            InitializeComponent();
        }

        public void StartLoading()
        {
            ShowLoading();
        }

        public void CloseLoading()
        {
            Thread.Sleep(200);
            loadingForm.Invoke(new Action(loadingForm.Close));
        }

        private void ShowLoading()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    loadingForm.Cursor = Cursors.WaitCursor;
                    loadingForm.ShowDialog();
                }
                else
                {
                    Thread th = new Thread(ShowLoading);
                    th.IsBackground = false;
                    th.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
