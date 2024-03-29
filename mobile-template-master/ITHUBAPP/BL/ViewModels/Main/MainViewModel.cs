using System.Threading.Tasks;
using System.Windows.Input;
using ITHUBAPP.DAL.DataObjects;
using ITHUBAPP.DAL.DataServices;

namespace ITHUBAPP.BL.ViewModels.Main
{
    public class MainViewModel: BaseViewModel
    {
		public SampleDataObject SampleObject {
			get => Get<SampleDataObject>();
			private set => Set(value);
		}

	    public ICommand SampleCommand => MakeCommand(OnSampleCommand);

	    public override async Task OnPageAppearing() {
			State = PageState.Loading;
		    var result = await DataServices.Main.GetSampleDataObject(CancellationToken);
			if (result.IsValid) {
				SampleObject = result.Data;
				State = PageState.Normal;
			}
			else
				State = PageState.Error;
		}

		async void OnSampleCommand() {
			NavigateTo("Menu");
		}
    }
}

