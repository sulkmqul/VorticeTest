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
        /// Vortice.Windows�e�X�g�A�v��
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DLL.Winmm.timeBeginPeriod(1);

                VorticeTest vt = new VorticeTest();                
                //������
                vt.Init();

                //���C�����[�v
                vt.Loop();

                //�j��
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
