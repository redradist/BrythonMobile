using BrythonMobile.Android;
using Xamarin.Forms;

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace BrythonMobile.Android 
{
	public class BaseUrl_Android : IBaseUrl 
	{
		public string Get () 
		{
			return "file:///android_asset/";
		}
	}
}