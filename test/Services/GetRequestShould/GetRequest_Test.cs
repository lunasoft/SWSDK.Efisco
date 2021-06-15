using SWSDK.Services.GetRequest;
using SWSDK.Test.Helpers;
using Xunit;

namespace SWSDK.Test.Services.GetRequestShould
{
    public class GetRequest_Test
    {
        private const string IdRequest = "f326848a-f560-4a66-b858-27a29fe4bbc0";

        [Fact]
        public async void Test1()
        {
            GetRequest getRequest = new GetRequest(Settings.Url, Settings.Token);

            var result = await getRequest.GelAllRequestAsync();

            Assert.Contains("success", result.status);
        }

        [Fact]
        public async void Test2()
        {
            GetRequest getRequest = new GetRequest(Settings.Url, Settings.Token);
            var result = await getRequest.GetAllSchedulerAsync();
            
            Assert.Contains("success", result.status);
        }

        [Fact]
        public async void Test3()
        {
            GetRequest getRequest = new GetRequest(Settings.Url, Settings.Token);

            var result = await getRequest.GetRequestByIdAsync(IdRequest);

            Assert.Contains("success", result.status);
        }


    }
}