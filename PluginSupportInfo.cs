using PaintDotNet;
using System;

namespace IconCreatorFileType {
    public sealed class PluginSupportInfo : IPluginSupportInfo {
        public string DisplayName => "Icon FileType";

        public string Author => "Kyle Tucker";

        public string Copyright => "Kyle Tucker © GNU 3.0 2022";

        public Version Version => typeof(PluginSupportInfo).Assembly.GetName().Version;

        public Uri WebsiteUri => new Uri("https://github.com/KyleTTucker/Paint.net-Icon-Creator");
    }
}
