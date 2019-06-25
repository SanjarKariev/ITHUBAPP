using System.Threading;
using System.Threading.Tasks;
using ITHUBAPP.DAL.DataObjects;

namespace ITHUBAPP.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

