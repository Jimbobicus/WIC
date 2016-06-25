﻿using System;

namespace stakx.WIC.Interop
{
    [Flags]
    public enum WICComponentSigning : int
    {
        WICComponentSigned = 0x00000001,
        WICComponentUnsigned = 0x00000002,
        WICComponentSafe = 0x00000004,
        WICComponentDisabled = unchecked((int)0x80000000U),
    }
}
