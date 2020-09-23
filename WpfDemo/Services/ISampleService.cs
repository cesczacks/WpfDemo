using System.Threading.Tasks;

namespace WpfDemo.Services
{
	public interface ISampleService
	{
		Task<string> GetCurrentDate();
	}
}
