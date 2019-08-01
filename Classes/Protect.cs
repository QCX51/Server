using System;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Classes
{
    internal static class Protect
    {

        [DllImport("ntdll")]
        private static extern int NtSetInformationProcess([In]IntPtr hProcess, [In]int psInfoClass, [In]ref int psInfo, [In]int psInfoLength);
        /// <summary>
        /// Enables or disables a privilege from the calling thread or process. 
        /// </summary>
        /// <param name="Privilege">index to change.</param>
        /// <param name="Enable">If TRUE, then enable the privilege otherwise disable.</param>
        /// <param name="CurrentThread">If TRUE, then enable in calling thread, otherwise process.</param>
        /// <param name="Enabled">Whether privilege was previously enabled or disabled.</param>
        /// <returns>int</returns>
        [DllImport("ntdll")]
        private static extern int RtlAdjustPrivilege([In]ulong Privilege, [In]bool Enable, [In]bool CurrentThread, [Out]out bool Enabled);

        internal static bool Start()
        {
             return StartProcessProtection(1);
        }
        internal static bool Stop()
        {
            return StartProcessProtection(0);
        }
        private static bool StartProcessProtection(int psInfo)
        {
            try
            {
                return RtlAdjustPrivilege(20, true, false, out bool Enabled) >= 0 |
                    NtSetInformationProcess(Process.GetCurrentProcess().Handle, 0x1d, ref psInfo, Marshal.SizeOf(psInfo)) >= 0;
            }
            catch { return false; }
        }
    }
}
