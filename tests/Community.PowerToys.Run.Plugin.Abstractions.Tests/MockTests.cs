using NSubstitute;

namespace Community.PowerToys.Run.Plugin.Abstractions.Tests
{
    public class MockTests
    {
        [Test]
        public void Mock_Infrastructure_IHelper()
        {
            var mock = Substitute.For<IHelper>();
            mock.RunAsAdmin(@"%windir%\system32\notepad.exe");
        }

        [Test]
        public void Mock_Plugin_IDefaultBrowserInfo()
        {
            var mock = Substitute.For<IDefaultBrowserInfo>();
            mock.UpdateIfTimePassed();
        }

        [Test]
        public void Mock_Plugin_ILog()
        {
            var mock = Substitute.For<ILog>();
            mock.Info("Message", GetType());
        }
    }
}
