using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

namespace Community.PowerToys.Run.Plugin.Abstractions.Tests
{
    public class WrapperTests
    {
        [Test]
        public async Task Wrappers_should_call_correct_methods()
        {
            var path = @"..\..\..\..\..\..\Abstractions.sln";
            using var workspace = MSBuildWorkspace.Create();
            var solution = await workspace.OpenSolutionAsync(path);
            var project = solution.Projects.First();

            foreach (var document in project.Documents)
            {
                var syntaxRoot = await document.GetSyntaxRootAsync();
                var methods = syntaxRoot!.DescendantNodes().OfType<MethodDeclarationSyntax>().Where(x => x.Parent!.GetType() == typeof(ClassDeclarationSyntax));

                foreach (var method in methods)
                {
                    var identifier = method.Identifier.ToString();
                    var text = method.ExpressionBody!.GetText().ToString();
                    text.Should().Contain(identifier);
                }
            }
        }
    }
}
