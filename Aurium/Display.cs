using System;

namespace Aurium
{
    class Display
    {
        private static void InitializeWindow()
        {
            Console.SetWindowSize(50, 40);
            Console.SetBufferSize(50, 40);
            Console.Title = "Aurium";
            PrintHeader();
        }

        public static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"          _              _                 ");
            Console.WriteLine(@"         / \  _   _ _ __(_)_   _ _ __ ___  ");
            Console.WriteLine(@"        / _ \| | | | '__| | | | | '_ ` _ \ ");
            Console.WriteLine(@"       / ___ \ |_| | |  | | |_| | | | | | |");
            Console.WriteLine(@"      /_/   \_\__,_|_|  |_|\__,_|_| |_| |_|");
            Console.WriteLine();
            Console.WriteLine(" -------------------------------------------------");
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
            Console.WriteLine();
            Console.WriteLine(" -------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(" CTRL + Number Pad:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine();
            Console.WriteLine(" 0: Enable/Disable");
            Console.WriteLine();
            Console.WriteLine(" 1: Assault Rifle");
            Console.WriteLine(" 2: Custom SMG");
            Console.WriteLine(" 3: LR-300 Assault Rifle");
            Console.WriteLine(" 4: M39");
            Console.WriteLine(" 5: M92");
            Console.WriteLine(" 6: M249");
            Console.WriteLine(" 7: MP5A4");
            Console.WriteLine(" 8: Semi-Automatic Rifle");
            Console.WriteLine(" 9: Thompson");
            Console.WriteLine();
            Console.WriteLine(" +: Cycle Sights [None/Simple/Holo/8x/16x]");
            Console.WriteLine(" Enter: Cycle Barrels [None/Silencer/Boost/Break]");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(" CTRL + Arrow Key:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Randomness: [← Decrease] [→ Increase]");
            Console.WriteLine(" In-game Sensitivity: [↓ Decrease] [↑ Increase]");
        }

        static void Main(string[] args)
        {
            InitializeWindow();
            Hotkeys.Initiate.InitiateHotKeys();
            Recoil.RecoilLoop();
        }
    }
}
