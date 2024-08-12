using System.Diagnostics;
using Wox.Infrastructure;
using static Wox.Infrastructure.Helper;

namespace Community.PowerToys.Run.Plugin.Abstractions
{
    /// <summary>
    /// Abstractions for <see cref="Helper" />.
    /// </summary>
    public interface IHelper
    {
        /// <inheritdoc cref="Helper.RunAsAdmin(string)"/>
        void RunAsAdmin(string path);

        /// <inheritdoc cref="Helper.RunAsUser(string)"/>
        void RunAsUser(string path);

        /// <inheritdoc cref="Helper.OpenInConsole(string)"/>
        Process OpenInConsole(string path);

        /// <inheritdoc cref="Helper.OpenCommandInShell(string, string, string, string, ShellRunAsType, bool)"/>
        bool OpenCommandInShell(string path, string pattern, string arguments, string? workingDir = null, ShellRunAsType runAs = ShellRunAsType.None, bool runWithHiddenWindow = false);

        /// <inheritdoc cref="Helper.OpenInShell(string, string, string, ShellRunAsType, bool)"/>
        bool OpenInShell(string path, string? arguments = null, string? workingDir = null, ShellRunAsType runAs = ShellRunAsType.None, bool runWithHiddenWindow = false);
    }

    /// <inheritdoc/>
    public class HelperWrapper : IHelper
    {
        /// <inheritdoc/>
        public void RunAsAdmin(string path) =>
            Helper.RunAsAdmin(path);

        /// <inheritdoc/>
        public void RunAsUser(string path) =>
            Helper.RunAsUser(path);

        /// <inheritdoc/>
        public Process OpenInConsole(string path) =>
            Helper.OpenInConsole(path);

        /// <inheritdoc/>
        public bool OpenCommandInShell(string path, string pattern, string arguments, string? workingDir = null, ShellRunAsType runAs = ShellRunAsType.None, bool runWithHiddenWindow = false) =>
            Helper.OpenCommandInShell(path, pattern, arguments, workingDir, runAs, runWithHiddenWindow);

        /// <inheritdoc/>
        public bool OpenInShell(string path, string? arguments = null, string? workingDir = null, ShellRunAsType runAs = ShellRunAsType.None, bool runWithHiddenWindow = false) =>
            Helper.OpenInShell(path, arguments, workingDir, runAs, runWithHiddenWindow);
    }
}
