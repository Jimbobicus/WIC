using System;
using System.ComponentModel;

namespace stakx.WIC
{
    [Flags]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public enum STGM : int
    {
        STGM_READ = 0x00000000,
        STGM_WRITE = 0x00000001,
        STGM_READWRITE = 0x00000002,
        #warning `STGM`: Enumeration incomplete. Consider adding all values.
    }
}
