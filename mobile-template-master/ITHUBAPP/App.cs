using ITHUBAPP.DAL.DataServices;
using ITHUBAPP.UI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ITHUBAPP
{
	public class App : Application
	{
		public App ()
		{
			DialogService.Init(this);
			NavigationService.Init(this);
			DataServices.Init(true);
		}

		protected override void OnStart ()
		{
			NavigationService.Instance.SetMainPage(AppPages.Main);
		}
	}
}

