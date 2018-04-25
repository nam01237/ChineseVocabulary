using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChineseVocabulary.Main_Lobby;
using EntityDataLibrary;

namespace ChineseVocabulary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EntityDataInitializer.ConnectionString = "VocabularyEntities";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LobbyForm lobbyForm = new LobbyForm();
            //Application.Run(lobbyForm);
            //RootForm currentForm = lobbyForm;

            LoginForm loginForm = new LoginForm();
            RootForm currentForm = loginForm;
            Application.Run(loginForm);

            while (true)
            {
                if (currentForm.ShowChild)
                    currentForm = currentForm.ChildeForm;
                else
                    break;

                Application.Run(currentForm);
            }

        }

    }
}
