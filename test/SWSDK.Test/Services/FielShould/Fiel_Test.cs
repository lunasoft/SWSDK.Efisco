using SW.Services.Fiel;
using SWSDK.Test.Helpers;
using Xunit;

namespace SWSDK.Test.Services.FielShould
{
    public class Fiel_Test
    {
        [Fact]
        public async void Test1()
        {
            Fiel fiel = new Fiel(Settings.Url, Settings.Token);

            var result = await fiel.GetAllFielAsync();

            Assert.Contains("success", result.status);
        }

        [Fact]
        public async void Test2()
        {
            Fiel fiel = new Fiel(Settings.Url, Settings.Token);

            var result = await fiel.PostFielAsync(Settings.Pass, Settings.Key, Settings.Cer);

            Assert.Contains("success", result.status);
        }

        [Fact]
        public async void Test3()
        { 
            Fiel fiel = new Fiel(Settings.Url, Settings.Token);

            var result = await fiel.DeleteFielAsync(Settings.RFC);
            
            Assert.Contains("success", result.status);
        }
    }
}
