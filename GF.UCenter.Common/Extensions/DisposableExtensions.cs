﻿namespace GF.UCenter.Common.Extensions
{
    using System;

    public static class DisposableExtensions
    {
        public static void DisposeOnException(this IDisposable obj, Action action)
        {
            bool success = false;
            try
            {
                action();
                success = true;
            }
            finally
            {
                if (!success)
                {
                    obj.Dispose();
                }
            }
        }
    }
}