using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialVortice
{
    static class Program
    {
        /// <summary>
        /// Vortice.Windowsテストアプリ
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DLL.Winmm.timeBeginPeriod(1);

                VorticeTest vt = new VorticeTest();                
                //初期化
                vt.Init();

                //メインループ
                vt.Loop();

                //破棄
                vt.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Trace.WriteLine(ex.Message);
            }
        }
    }
}
