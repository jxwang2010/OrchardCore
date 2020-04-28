using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheAgencyTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("TheAgencyTheme")
                .SetDependencies("jQuery")
                .SetUrl("~/TheAgencyTheme/Scripts/scripts.min.css", "~/TheAgencyTheme/Scripts/scripts.js")
                .SetVersion("6.0.0");

            manifest
                .DefineStyle("TheAgencyTheme")
                .SetUrl("~/TheAgencyTheme/Styles/styles.min.css", "~/TheAgencyTheme/Styles/styles.css")
                .SetVersion("6.0.0");
        }
    }
}
