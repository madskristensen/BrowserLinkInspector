using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace BrowserLinkInspector
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", Vsix.Version, IconResourceID = 400)]
    [Guid("40d72d39-a940-40dd-b0a6-32c5563360cf")]
    public sealed class InspectorPackage : Package
    {
    }
}
