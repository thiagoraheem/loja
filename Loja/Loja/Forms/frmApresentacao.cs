using System;
using DevExpress.XtraSplashScreen;

namespace Loja
{
	public partial class frmApresentacao : SplashScreen
    {
        public frmApresentacao()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

    }
}