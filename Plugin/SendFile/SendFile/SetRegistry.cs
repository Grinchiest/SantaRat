﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugin
{
    public static class SetRegistry
    {
        private static readonly string ID = @"Software\" + Connection.Hwid;

        public static bool SetValue(string name, string value)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(ID, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    key.SetValue(name, value, RegistryValueKind.ExpandString);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
            }
            return false;
        }

        public static string GetValue(string value)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(ID))
                {
                    object o = key.GetValue(value);
                    return (string)o;
                }
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
            }
            return null;
        }

        public static bool DeleteValue(string name)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(ID))
                {
                    key.DeleteValue(name);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
            }
            return false;
        }

        public static bool DeleteSubKey()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("", true))
                {
                    key.DeleteSubKeyTree(ID);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
            }
            return false;
        }
    }

}
