using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
namespace GuitarMaster.other
{
    class Guitar
    {
        
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendString(
                string command,
                StringBuilder returnValue,
                int returnLength,
                int winHandle);

        [DllImport("winmm.dll", EntryPoint = "mciGetErrorString")]
        public static extern uint mciGetErrorString(
                int dwError,
                StringBuilder lpstrBuffer,
                uint wLength);

        [DllImport("winmm.dll", EntryPoint = "mciExecute")]
        public static extern int mciExecute(string command);

        int sNumber;
        private gstring[] strun;
        
        string[] string1 = { Environment.CurrentDirectory + @"\sound\0_1.wav", Environment.CurrentDirectory + @"\sound\0_2.wav" };
        string[] string2 = { Environment.CurrentDirectory + @"\sound\0_1.wav", Environment.CurrentDirectory + @"\sound\Birds.wav" };
        string[] string3 = { Environment.CurrentDirectory + @"\sound\0_1.wav", Environment.CurrentDirectory + @"\sound\0_2.wav" };
        string[] string4 = { Environment.CurrentDirectory + @"\sound\Birds.wav", Environment.CurrentDirectory + @"\sound\Ocean Waves.wav" };
        string[] string5 = { Environment.CurrentDirectory + @"\sound\0_1.wav", Environment.CurrentDirectory + @"\sound\0_2.wav" };
        string[] string6 = { Environment.CurrentDirectory + @"\sound\0_1.wav", Environment.CurrentDirectory + @"\sound\Birds.wav" };

        public Guitar()
        {
            strun = new gstring[6];
            for (int i = 0; i < 6; i++)
            {
                strun[i] = new gstring();
            }
        }
        public int Number
        {
            get { return sNumber; }
            set { sNumber = value; }
        }
        public void initGuitar()
        {
            strun[0].paths = string1;
            strun[1].paths = string2;
            strun[2].paths = string3;
            strun[3].paths = string4;
            strun[4].paths = string5;
            strun[5].paths = string6;
        }
        public void play()
        {
            
            string ex2 = "ex2";
            
            string OPMCI1 = String.Format("open {0} type waveaudio alias {1}", strun[0].paths[1], ex2);
            
            string otsch1 = String.Format("set {0} time format ms", ex2);
            
            string playmci1 = String.Format("play {0} from 1 to 2000 ", ex2);
           
            string closemci1 = String.Format("close {0}", ex2);
            string ex1 = "ex1";

            string OPMCI = String.Format("open {0} type waveaudio alias {1}", strun[0].paths[0], ex1);

            string otsch = String.Format("set {0} time format ms", ex1);

            string playmci = String.Format("play {0} from 1 to 2000 wait", ex1);

            string closemci = String.Format("close {0}", ex1);


           
            mciSendString(OPMCI1, null, 0, 0);
          
            mciSendString(otsch1, null, 0, 0);
         

            mciSendString(playmci1, null, 0, 0);
            mciSendString(OPMCI, null, 0, 0);

            mciSendString(otsch, null, 0, 0);


            mciSendString(playmci, null, 0, 0);
            mciSendString(closemci, null, 0, 0); 
            mciSendString(closemci1, null, 0, 0); 
        }
    }
}
