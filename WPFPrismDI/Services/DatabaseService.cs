using System.Threading.Tasks;
using WPFPrismDI.Services.Interface;

namespace WPFPrismDI.Services
{
    public class DatabaseService : IDatabaseService
    {
        public async Task<string> GetName()
        {
            string name = "John";
            await Task.Delay(1);
            return name;
        }
    }
}
