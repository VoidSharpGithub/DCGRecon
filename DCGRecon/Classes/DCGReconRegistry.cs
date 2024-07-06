using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCGRecon.Recon;

namespace DCGRecon.Classes
{
    public static class DCGReconRegistry
    {
        public static int LoadReceiverList(ref ReconStruct reconInfo)
        {
            bool UpdateReg = false;
            string newAppKey = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Application Key", (object)"");
            if (newAppKey == "" || newAppKey == null)
            {
                newAppKey = ReconMgmt.GenerateNewAppKey();
                UpdateReg = true;
            }
            reconInfo.appkey = newAppKey;
            string newFilter = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Selected Filter", (object)"");
            if (newFilter == "" || newFilter == null)
            {
                newFilter = "";
                UpdateReg = true;
            }
            reconInfo.filter = newFilter;
            object UniversalUpdates = Registry.GetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receiver Universal Updates Enabled", (object)99);
            if (UniversalUpdates == null || (int)UniversalUpdates == 99)
            {
                UniversalUpdates = 1;
                UpdateReg = true;
            }
            reconInfo.updatesenabled = (int)UniversalUpdates != 0;
            string updateTime = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receiver Universal Update Time", (object)"");
            if (updateTime == "" || updateTime == null)
            {
                updateTime = Helper.DateToEpoch(DateTime.Today.AddHours(3));
                UpdateReg = true;
            }
            reconInfo.updatetime = Helper.EpochToDate(updateTime);
            string[] receiverArray;
            try
            {
                receiverArray = (string[])Registry.GetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receivers", new string[1] { "" });
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                Log.LogMessageStatic(message);
                return -7;
            }
            if (receiverArray == null)
            {
                return -1;
            }
            else if (receiverArray.Length == 1 && receiverArray[0] == "")
            {
                return -1;
            }
            else if (receiverArray.Length == 0)
            {
                return -1;
            }
            else
            {
                reconInfo.receivers = new List<Receivers>();
                bool flag = false;
                for (int index = 0; index < receiverArray.Length; ++index)
                {
                    Receivers newReceiver = new Receivers();
                    newReceiver.tuner = new List<Tuners>{ new Tuners(), new Tuners() };

                    int length1 = receiverArray[index].IndexOf(";");
                    if (length1 == -1)
                    {
                        flag = true;
                        break;
                    }
                    newReceiver.ipaddress = receiverArray[index].Substring(0, length1);
                    receiverArray[index] = receiverArray[index].Remove(0, length1 + 1);
                    int length2 = receiverArray[index].IndexOf(";");
                    if (length2 == -1)
                    {
                        flag = true;
                        break;
                    }
                    newReceiver.receivernumber = receiverArray[index].Substring(0, length2);
                    receiverArray[index] = receiverArray[index].Remove(0, length2 + 1);
                    newReceiver.receivername = receiverArray[index];


                    reconInfo.receivers.Add(newReceiver);
                }
                if (flag)
                    return -1;
            }
            if (UpdateReg)
                SaveRegistry(reconInfo);
            return 0;
        }

        public static int SaveRegistry(ReconStruct reconInfo)
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Application Key", (object)reconInfo.appkey, RegistryValueKind.String);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Selected Filter", (object)reconInfo.filter, RegistryValueKind.String);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receiver Universal Updates Enabled", (object)(reconInfo.updatesenabled ? 1 : 0), RegistryValueKind.DWord);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receiver Universal Update Time", (object)(Helper.DateToEpoch(reconInfo.updatetime)), RegistryValueKind.String);
                if (reconInfo.receivers == null)
                {
                    Registry.SetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receivers", new string[0], RegistryValueKind.MultiString);
                }
                else
                {
                    string[] receiverArray = new string[reconInfo.receivers.Count];
                    for (int index = 0; index < reconInfo.receivers.Count; ++index)
                        receiverArray[index] = reconInfo.receivers[index].ipaddress + ";" + reconInfo.receivers[index].receivernumber + ";" + reconInfo.receivers[index].receivername;
                    Registry.SetValue("HKEY_CURRENT_USER\\Software\\DCG\\Recon", "Receivers", (object)receiverArray, RegistryValueKind.MultiString);
                }
            }
            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                    MessageBox.Show("No access to Registry");
                string message = ex.Message;
                Log.LogMessageStatic(message);
                return -1;
            }
            return 0;
        }
    }
}
