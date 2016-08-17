using System.Windows.Forms;

namespace CRM_VIEW
{
	partial class CRMDBContextController
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && _context != null) {
				_context.ChangeTracker.DetectChanges();
				if (_context.ChangeTracker.HasChanges() &&
					MessageBox.Show("Сохранить изменения?", string.IsNullOrEmpty(ContainerForm?.Text) ? "CRM" : ContainerForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					_context.SaveChanges();
				_context.Dispose();
			}
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}

		#endregion
	}
}
