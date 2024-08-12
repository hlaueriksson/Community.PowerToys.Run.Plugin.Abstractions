using Wox.Plugin.Common;

namespace Community.PowerToys.Run.Plugin.Abstractions
{
    /// <summary>
    /// Abstractions for <see cref="DefaultBrowserInfo" />.
    /// </summary>
    public interface IDefaultBrowserInfo
    {
        /// <inheritdoc cref="DefaultBrowserInfo.UpdateIfTimePassed()"/>
        void UpdateIfTimePassed();
    }

    /// <inheritdoc/>
    public class DefaultBrowserInfoWrapper : IDefaultBrowserInfo
    {
        /// <inheritdoc/>
        public void UpdateIfTimePassed() =>
            DefaultBrowserInfo.UpdateIfTimePassed();
    }
}
