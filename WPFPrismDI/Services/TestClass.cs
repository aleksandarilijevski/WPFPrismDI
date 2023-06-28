using System.Threading.Tasks;
using WPFPrismDI.Services.Interface;

namespace WPFPrismDI.Services
{
    public class TestClass
    {
        private IDatabaseService _databaseService;

        public TestClass(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<string> GetName()
        {
            return await _databaseService.GetName();
        }
    }
}
