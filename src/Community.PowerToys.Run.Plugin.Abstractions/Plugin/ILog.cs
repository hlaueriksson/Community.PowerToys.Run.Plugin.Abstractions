using System.Runtime.CompilerServices;
using Wox.Plugin.Logger;

namespace Community.PowerToys.Run.Plugin.Abstractions
{
    /// <summary>
    /// Abstractions for <see cref="Log" />.
    /// </summary>
    public interface ILog
    {
        /// <inheritdoc cref="Log.Info(string, Type, string, string, int)"/>
        void Info(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <inheritdoc cref="Log.Debug(string, Type, string, string, int)"/>
        void Debug(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <inheritdoc cref="Log.Warn(string, Type, string, string, int)"/>
        void Warn(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <inheritdoc cref="Log.Error(string, Type, string, string, int)"/>
#pragma warning disable CA1716 // Identifiers should not match keywords
        void Error(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
#pragma warning restore CA1716 // Identifiers should not match keywords

        /// <inheritdoc cref="Log.Exception(string, Exception, Type, string, string, int)"/>
        void Exception(string message, Exception ex, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);
    }

    /// <inheritdoc/>
    public class LogWrapper : ILog
    {
        /// <inheritdoc/>
        public void Info(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0) =>
            Log.Info(message, fullClassName, methodName, sourceFilePath, sourceLineNumber);

        /// <inheritdoc/>
        public void Debug(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0) =>
            Log.Debug(message, fullClassName, methodName, sourceFilePath, sourceLineNumber);

        /// <inheritdoc/>
        public void Warn(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0) =>
            Log.Warn(message, fullClassName, methodName, sourceFilePath, sourceLineNumber);

        /// <inheritdoc/>
        public void Error(string message, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0) =>
            Log.Error(message, fullClassName, methodName, sourceFilePath, sourceLineNumber);

        /// <inheritdoc/>
        public void Exception(string message, Exception ex, Type fullClassName, [CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0) =>
            Log.Exception(message, ex, fullClassName, methodName, sourceFilePath, sourceLineNumber);
    }
}
