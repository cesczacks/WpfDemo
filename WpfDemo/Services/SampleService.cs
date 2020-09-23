using System;
using System.Threading.Tasks;

namespace WpfDemo.Services
{
	public class SampleService : ISampleService
	{
		public async Task<string> GetCurrentDate() =>
			await Task.FromResult(DateTime.Now.ToLongDateString());
	}
}
