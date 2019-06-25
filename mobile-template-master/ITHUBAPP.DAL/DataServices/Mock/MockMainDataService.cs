using System.Threading;
using System.Threading.Tasks;
using ITHUBAPP.DAL.DataObjects;

namespace ITHUBAPP.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("ITHUBAPP.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

