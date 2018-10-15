using System;

namespace MorseCode
{
    public class MorseCodeKey
    {
        private const string SEPARATOR = "\\";
        
        public string[] Morse { get; set; }
        public string BaseABC123 { get; set; }

        public MorseCodeKey()
        {
            Morse = new string[]
            {
                ".-",   //a
                "-...",
                "-.-.",
                "-..",
                ".",
                "..-.",
                "--.",
                "....",
                "..",
                ".---",
                "-.-",
                ".-..",
                "--",
                "-.",
                "---",
                ".--.",
                "--.-",
                ".-.",
                "...",
                "-",
                "..-",
                "...-",
                ".--",
                "-..-",
                "-.--",
                "--..",
                "--.--",    //ñ
                "-----",    //0
                ".----",    //1
                "..---",    //2
                "...--",    //3
                "....-",    //4
                ".....",    //5
                "-....",    //6
                "--...",    //7
                "---..",    //8
                "----."     //9
            };

            BaseABC123 = "abcdefghijklmnopqrstuvwxyzñ0123456789";
        }

        private string CodeMessage(string message)
        {
            string value=string.Empty;
            int pos = 0;

            foreach(char c in message)
            {
                pos = BaseABC123.IndexOf(c);
                if (pos != -1)
                {
                    value += Morse[pos] + SEPARATOR;
                }
                else
                {
                    if (c == ' ')
                    {
                        value += SEPARATOR;
                    }
                    else
                    {
                        value += c;
                    }
                    
                }
            }


            return value;
        }

        private string DecodeMessage(string mesagge)
        {
            string value = string.Empty;
            string[] splitMessage = mesagge.Split('\\');
            int pos = -1;
            for (int i=0; i<splitMessage.Length; i++)
            {
                pos = Array.IndexOf(Morse, splitMessage[i]);
                if (pos != -1)
                {
                    value += BaseABC123[pos];
                }
                else
                {
                    if (i != 0)
                    {
                        value += " ";
                    }
                    
                }
                
            }
            return value;
        }

        public string GetCodeMessage(string message)
        {
            return CodeMessage(message);
        }


        public string GetDecodeMessage(string message)
        {
            return DecodeMessage(message);
        }

    }
}
