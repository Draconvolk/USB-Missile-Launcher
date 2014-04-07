using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissileCommand;
using System.Threading;

namespace MissileConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var command = "";
			bool ledState = false;
			Console.WriteLine("Missile Defense Online... ");
			while (command.ToLower() != "quit" && command.ToLower() != "exit")
			{
				Console.WriteLine(">>");
				command = Console.ReadLine();
				ExecuteCommand(command, ref ledState);

			}
		}

		public static void ExecuteCommand(string command, ref bool ledState){

			MissileLauncher missilecommand = new MissileLauncher();
			switch (command.ToLower())
			{
				case "up":
					missilecommand.Up();
					Thread.Sleep(20);
					missilecommand.Stop();
					break;
				case "down":
					missilecommand.Down();
					Thread.Sleep(20);
					missilecommand.Stop();
					break;
				case "left":
					missilecommand.Left();
					Thread.Sleep(40);
					missilecommand.Stop();
					break;
				case "right":
					missilecommand.Right();
					Thread.Sleep(40);
					missilecommand.Stop();
					break;
				case "fire":

					missilecommand.Fire();
					//Thread.Sleep(2000);
					//missilecommand.Stop();
					break;
				case "status":
					missilecommand.Get_Status();
					break;
				case "stop":
					missilecommand.Stop();
					break;
				case "led":
					if (ledState)
						missilecommand.LED_off();
					else
						missilecommand.LED_on();
					ledState = !ledState;
					break;
				case "led_on":
					missilecommand.LED_on();
					break;
				case "led_off":
					missilecommand.LED_off();
					break;
				case "quit":
					
					break;
				default: Console.WriteLine("Command '{0}' not found.", command);
					break;
			}
			
		}
	}
}
