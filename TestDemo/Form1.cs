using DevExpress.Utils.MVVM.Services;
using ManuTalent.Mom.Opeartion.UserControl.ModelsGenerated;
using System.Windows.Forms;

namespace TestDemo
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		public Form1()
		{
			InitializeComponent();

			if (!mvvmContext1.IsDesignMode) { InitializeBindings(); }
		}

		void InitializeBindings()
		{
			mvvmContext1.ContainerControl = this;
			mvvmContext1.ViewModelType = typeof(Test);
			var service = WindowService.CreateXtraFormService(this);
			service.StartPosition = FormStartPosition.CenterParent;
			service.ShowMode = WindowService.WindowShowMode.Modal;
			mvvmContext1.RegisterService(service);
			var fluent = mvvmContext1.OfType<Test>();

			fluent.BindCommand(simpleButton1, x => x.Set);//this right
			fluent.BindCommand(simpleButton1, x => x.Set2);//this right
			//fluent.BindCommand(simpleButton1, x => x.SetCommand);//This is generated , Wrong

		}
	}
}
