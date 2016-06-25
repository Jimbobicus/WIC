﻿using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICBitmapFrameEncode)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe interface IWICBitmapFrameEncode
    {
        void Initialize(
            [In] IPropertyBag2 pIEncoderOptions);

        void SetSize(
            [In] int uiWidth,
            [In] int uiHeight);

        void SetResolution(
            [In] double dpiX,
            [In] double dpiY);

        void SetPixelFormat(
            [In, Out] ref Guid pPixelFormat);

        void SetColorContexts(
            [In] int cCount,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 0)] IWICColorContext[] ppIColorContext);

        void SetPalette(
            [In] IWICPalette pIPalette);

        void SetThumbnail(
            [In] IWICBitmapSource pIThumbnail);

        void WritePixels(
            [In] int lineCount,
            [In] int cbStride,
            [In] int cbBufferSize,
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 2)] byte[] pbPixels);

        unsafe void WriteSource(
            [In] IWICBitmapSource pIBitmapSource,
            [In] WICRect* prc);

        void Commit();

        void GetMetadataQueryWriter(
            [Out] out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
