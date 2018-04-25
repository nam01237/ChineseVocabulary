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
            Application.Run(new LoginForm());

            //LobbyForm lobbyForm = new LobbyForm();
            //lobbyForm.ModalParentForm = new LobbyForm();
            //RootForm.AccessUserKey = 7;
            //RootForm.AccessUSerId = "n";

            //Application.Run(lobbyForm);

        }

    }
}
