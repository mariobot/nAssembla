using System.Runtime.InteropServices;

namespace nAssembla.Proxy
{
    internal static class Helper
    {
        [DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
        public extern static System.UInt32 FindMimeFromData(
            System.UInt32 pBC,
            [MarshalAs(UnmanagedType.LPStr)]
            System.String pwzUrl,
            [MarshalAs(UnmanagedType.LPArray)]
            byte[] pBuffer,
            System.UInt32 cbSize,
            [MarshalAs(UnmanagedType.LPStr)]
            System.String pwzMimeProposed,
            System.UInt32 dwMimeFlags,
            out System.UInt32 ppwzMimeOut,
            System.UInt32 dwReserverd);
    }
}