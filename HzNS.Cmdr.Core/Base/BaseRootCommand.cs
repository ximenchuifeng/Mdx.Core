using System.Diagnostics.CodeAnalysis;
using HzNS.Cmdr.Builder;

namespace HzNS.Cmdr.Base
{
    [SuppressMessage("ReSharper", "ConvertToAutoPropertyWhenPossible")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public abstract class BaseRootCommand : BaseCommand, IRootCommand
    {
        public IAppInfo AppInfo;

        // ReSharper disable once PublicConstructorInAbstractClass
        public BaseRootCommand(IAppInfo appInfo)
        {
            AddAppInfo(appInfo);
        }

        // ReSharper disable once PublicConstructorInAbstractClass
        private BaseRootCommand(string shortTitle, string longTitle, string[] aliases, string description,
            string descriptionLong, string examples) : base(shortTitle, longTitle, aliases, description,
            descriptionLong, examples)
        {
        }

        public IRootCommand AddAppInfo(IAppInfo appInfo)
        {
            // throw new System.NotImplementedException();
            AppInfo = appInfo;
            return this;
        }
    }
}