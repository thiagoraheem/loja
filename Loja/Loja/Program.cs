using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace Loja
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				Application.SetHighDpiMode(HighDpiMode.SystemAware);
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				// Inicializar DevExpress com tratamento de exceção para IconGuard
				try
				{
					DevExpress.Skins.SkinManager.EnableFormSkins();
					DevExpress.UserSkins.BonusSkins.Register();

				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine($"Erro ao registrar skins: {ex.Message}");
				}

				// Aplicar skin com fallback seguro
				try
				{
					string skinStyle = Properties.Settings.Default.Estilo;
					if (string.IsNullOrWhiteSpace(skinStyle))
					{
						skinStyle = "Office 2013 White";
					}
					UserLookAndFeel.Default.SetSkinStyle(skinStyle);
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine($"Erro ao aplicar skin: {ex.Message}");
					try
					{
						UserLookAndFeel.Default.SetSkinStyle("Office 2013 White");
					}
					catch
					{
						// Se falhar, continua sem skin
					}
				}

				var frmPrincipal = new frmPrincipal();

				Application.Run(frmPrincipal);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine($"Erro fatal na inicialização: {ex.Message}");
				MessageBox.Show($"Erro ao inicializar a aplicação: {ex.Message}\n\n{ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
