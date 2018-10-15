using System;
using MorseCode;

namespace DemoMordeCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MorseCodeKey();
            string msgABC = "este mensaje es para codificar y ver el resultado";
            string msgMorse = @"\.\...\-\.\\--\.\-.\...\.-\.---\.\\.\...\\.--.\.-\.-.\.-\\-..\.\-.-.\---\-..\..\..-.\..\-.-.\.-\.-.\\-.--\\...-\.\.-.\\.\.-..\\.-.\.\...\..-\.-..\-\.-\-..\---\";

            Console.WriteLine(msgABC);
            Console.WriteLine(mc.GetCodeMessage(msgABC));
            Console.ReadKey();
            Console.WriteLine(msgMorse);
            Console.WriteLine(mc.GetDecodeMessage(msgMorse));
            Console.ReadKey();

        }
    }
}
