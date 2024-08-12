namespace Community.PowerToys.Run.Plugin.Abstractions.Tests
{
    [Category("Integration")]
    public class VerifyTests
    {
        [Test]
        public async Task Verify_Infrastructure_Helper()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://raw.githubusercontent.com/microsoft/PowerToys/main/src/modules/launcher/Wox.Infrastructure/Helper.cs");
            var code = await response.Content.ReadAsStringAsync();

            await Verify(code);
        }

        [Test]
        public async Task Verify_Plugin_DefaultBrowserInfo()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://raw.githubusercontent.com/microsoft/PowerToys/main/src/modules/launcher/Wox.Plugin/Common/DefaultBrowserInfo.cs");
            var code = await response.Content.ReadAsStringAsync();

            await Verify(code);
        }

        [Test]
        public async Task Verify_Plugin_Log()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://raw.githubusercontent.com/microsoft/PowerToys/main/src/modules/launcher/Wox.Plugin/Logger/Log.cs");
            var code = await response.Content.ReadAsStringAsync();

            await Verify(code);
        }
    }
}
