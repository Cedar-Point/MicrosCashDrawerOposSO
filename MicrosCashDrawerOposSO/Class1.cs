using OposCashDrawer_CCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosCashDrawerOposSO
{
    public class MicrosCashDrawer : OPOSCashDrawer
    {
        public void SODataDummy(int Status)
        {
            throw new NotImplementedException();
        }

        public void SODirectIO(int EventNumber, ref int pData, ref string pString)
        {
            throw new NotImplementedException();
        }

        public void SOErrorDummy(int ResultCode, int ResultCodeExtended, int ErrorLocus, ref int pErrorResponse)
        {
            throw new NotImplementedException();
        }

        public void SOOutputCompleteDummy(int OutputID)
        {
            throw new NotImplementedException();
        }

        public void SOStatusUpdate(int Data)
        {
            throw new NotImplementedException();
        }

        public int SOProcessID()
        {
            throw new NotImplementedException();
        }

        public int CheckHealth(int Level)
        {
            throw new NotImplementedException();
        }

        public int ClaimDevice(int Timeout)
        {
            throw new NotImplementedException();
        }

        public int Close()
        {
            throw new NotImplementedException();
        }

        public int DirectIO(int Command, ref int pData, ref string pString)
        {
            throw new NotImplementedException();
        }

        public int Open(string DeviceName)
        {
            throw new NotImplementedException();
        }

        public int ReleaseDevice()
        {
            throw new NotImplementedException();
        }

        public int OpenDrawer()
        {
            throw new NotImplementedException();
        }

        public int WaitForDrawerClose(int BeepTimeout, int BeepFrequency, int BeepDuration, int BeepDelay)
        {
            throw new NotImplementedException();
        }

        public int ResetStatistics(string StatisticsBuffer)
        {
            throw new NotImplementedException();
        }

        public int RetrieveStatistics(ref string pStatisticsBuffer)
        {
            throw new NotImplementedException();
        }

        public int UpdateStatistics(string StatisticsBuffer)
        {
            throw new NotImplementedException();
        }

        public int CompareFirmwareVersion(string FirmwareFileName, out int pResult)
        {
            throw new NotImplementedException();
        }

        public int UpdateFirmware(string FirmwareFileName)
        {
            throw new NotImplementedException();
        }

        public int OpenResult => throw new NotImplementedException();

        public string CheckHealthText => throw new NotImplementedException();

        public bool Claimed => throw new NotImplementedException();

        public bool DeviceEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FreezeEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ResultCode => throw new NotImplementedException();

        public int ResultCodeExtended => throw new NotImplementedException();

        public int State => throw new NotImplementedException();

        public string ControlObjectDescription => throw new NotImplementedException();

        public int ControlObjectVersion => throw new NotImplementedException();

        public string ServiceObjectDescription => throw new NotImplementedException();

        public int ServiceObjectVersion => throw new NotImplementedException();

        public string DeviceDescription => throw new NotImplementedException();

        public string DeviceName => throw new NotImplementedException();

        public bool CapStatus => throw new NotImplementedException();

        public bool DrawerOpened => throw new NotImplementedException();

        public int BinaryConversion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CapPowerReporting => throw new NotImplementedException();

        public int PowerNotify { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int PowerState => throw new NotImplementedException();

        public bool CapStatusMultiDrawerDetect => throw new NotImplementedException();

        public bool CapStatisticsReporting => throw new NotImplementedException();

        public bool CapUpdateStatistics => throw new NotImplementedException();

        public bool CapCompareFirmwareVersion => throw new NotImplementedException();

        public bool CapUpdateFirmware => throw new NotImplementedException();

        public event _IOPOSCashDrawerEvents_DirectIOEventEventHandler DirectIOEvent;
        public event _IOPOSCashDrawerEvents_StatusUpdateEventEventHandler StatusUpdateEvent;
    }
}
