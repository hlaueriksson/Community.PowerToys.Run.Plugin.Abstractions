using System.Reflection;
using FluentAssertions;

namespace Community.PowerToys.Run.Plugin.Abstractions.Tests
{
    public class NamespaceTests
    {
        [Test]
        public void Namespaces_should_be_correct()
        {
            var assembly = Assembly.Load("Community.PowerToys.Run.Plugin.Abstractions");
            var types = assembly.GetTypes();

            types.Should().AllSatisfy(x => x.Namespace.Should().Be("Community.PowerToys.Run.Plugin.Abstractions"));
        }
    }
}
