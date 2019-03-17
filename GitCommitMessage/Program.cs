using System;
using System.Windows.Forms;
using System.Threading;

namespace GitCommitMessage
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            new Form1();
            Application.Run();


        }
    }
}
