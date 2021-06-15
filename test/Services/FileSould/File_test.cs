using SWSDK.Services.GetFile;
using SWSDK.Test.Helpers;
using Xunit;

namespace SWSDK.Test.Services.FileSould
{
    public class File_test
    {
        private const string FilePath = "ce8ec187-73a6-49f1-b956-6521bf673edd/20-04-2021/Report_f326848a-f560-4a66-b858-27a29fe4bbc0.zip";
        
        [Fact]
        public async void Test1()
        {
            GetFile getFile = new GetFile(Settings.Url, Settings.Token);

            var result = await getFile.GetFileUrlAsync(FilePath);
            
            Assert.Contains("success", result.status);
        }
    }
}
