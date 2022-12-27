﻿using PKISharp.WACS.Plugins.Base;
using PKISharp.WACS.Plugins.Base.Options;

namespace PKISharp.WACS.Plugins.TargetPlugins
{
    internal class CsrOptions : TargetPluginOptions<Csr>
    {
        public static string NameLabel => "CSR";
        public override string Name => NameLabel;
        public override string Description => "CSR created by another program";
        public string? CsrFile { get; set; }
        public string? PkFile { get; set; }
    }
}
