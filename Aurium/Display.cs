using System;

namespace Aurium
{
    class Display
    {
        private static void InitializeWindow()
        {
            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);
            Console.Title = "Aurium";
            PrintHeader();
        }

        public static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"           _              _                 ");
            Console.WriteLine(@"          / \  _   _ _ __(_)_   _ _ __ ___  ");
            Console.WriteLine(@"         / _ \| | | | '__| | | | | '_ ` _ \ ");
            Console.WriteLine(@"        / ___ \ |_| | |  | | |_| | | | | | |");
            Console.WriteLine(@"       /_/   \_\__,_|_|  |_|\__,_|_| |_| |_|");
            Console.WriteLine("  -----------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("            Sensitivity     Randomness");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("                ");
            Console.Write("{0:0.0}", Variables.Settings.getSensitivity());
            Console.Write("             ");
            Console.Write("{0:0}", Variables.Weapon.getRandomness());
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.Write(" Script Enabled: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Variables.Menu.isEnabled() + "\n");
            Console.ResetColor();

            Console.Write(" Current Weapon: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Variables.Weapon.getName() + "\n");
            Console.ResetColor();

            Console.Write(" Scope Attachment: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Variables.Weapon.getActiveScope() + "\n");
            Console.ResetColor();

            Console.Write(" Muzzle Attachment: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Variables.Weapon.getActiveBarrel() + "\n");
            Console.WriteLine("  -----------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(" CTRL + Number Pad:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine();
            Console.WriteLine("         7: MP5A4   8: Semi    9: Thompson");
            Console.WriteLine("         4: M39     5: M92     6: M249");
            Console.WriteLine("         1: AK-47   2: Custom  3: LR-300");
            Console.WriteLine();
            Console.WriteLine(" 0: Enable/Disable");
            Console.WriteLine();
            Console.WriteLine(" +: Cycle Sights [None/Simple/Holo/8x/16x]");
            Console.WriteLine(" Enter: Cycle Barrels [None/Silencer/Boost/Break]");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(" CTRL + Arrow Key:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" In-game Sensitivity: [← Decrease] [→ Increase]");
            Console.WriteLine(" Randomness: [↓ Decrease] [↑ Increase]");
        }

        static void Main(string[] args)
        {
            InitializeWindow();
            Hotkeys.Initiate.InitiateHotKeys();
            Recoil.RecoilLoop();
        }
    }
}
