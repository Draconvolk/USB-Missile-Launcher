using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsbLibrary;

namespace MissileCommand
{

	public class MissileCommands
	{
		public byte[] Up() { return new byte[10] { 0, 2, 2, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] Down() { return new byte[10] { 0, 2, 1, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] Left() { return new byte[10] { 0, 2, 4, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] Right() { return new byte[10] { 0, 2, 8, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] Fire() { return new byte[10] { 0, 2, 16, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] Stop() { return new byte[10] { 0, 2, 32, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] Get_Status() { return new byte[10] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] LED_On() { return new byte[10] { 0, 3, 1, 0, 0, 0, 0, 0, 0, 0 }; }
		public byte[] LED_Off() { return new byte[10] { 0, 3, 0, 0, 0, 0, 0, 0, 0, 0 }; }
		public MissileCommands() { }

	}

    public class MissileLauncher
    {
		public MissileLauncher()
		{
			USBInit();

		}

		public MissileCommands commands = new MissileCommands();

		private UsbHidPort USB;

		private void USBInit()
		{
			USB = new UsbHidPort();

			USB.VID_List[0] = 2689;
			USB.PID_List[0] = 1793;
			USB.VID_List[1] = 8483;
			USB.PID_List[1] = 4112;
			USB.ID_List_Cnt = 2;
			IntPtr handle = new IntPtr(1508034);
			USB.RegisterHandle(handle);
		}

		private void SendUSBData(byte[] Data)
		{
			if (this.USB.SpecifiedDevice != null)
			{
				try
				{
					this.USB.SpecifiedDevice.SendData(Data);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public void Up()
		{
			SendUSBData(commands.Up());
		}

		public void Down()
		{
			SendUSBData(commands.Down());
		}

		public void Left()
		{
			SendUSBData(commands.Left());
		}

		public void Right()
		{
			SendUSBData(commands.Right());
		}

		public void Fire()
		{
			SendUSBData(commands.Fire());
		}

		public void Stop()
		{
			SendUSBData(commands.Stop());
		}

		public void LED_on()
		{
			SendUSBData(commands.LED_On());
		}

		public void LED_off()
		{
			SendUSBData(commands.LED_Off());
		}

		public void Get_Status()
		{
			SendUSBData(commands.Get_Status());
		}
    }
}
