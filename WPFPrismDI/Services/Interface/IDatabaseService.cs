using System.Threading.Tasks;

namespace WPFPrismDI.Services.Interface
{
    public interface IDatabaseService
    {
        public Task<string> GetName();
    }
}
