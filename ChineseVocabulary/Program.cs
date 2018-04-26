using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChineseVocabulary.Main_Lobby;
using ChineseVocabulary.StudyForms;
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

            //RootForm.AccessUserKey = 7;
            //RootForm.AccessUSerId = "n";
            //RootForm.CurrentGrade = 1;

            //LobbyForm lobbyForm = new LobbyForm();
            //Application.Run(lobbyForm);

            //TestForm testForm = new TestForm();
            //Application.Run(testForm);

            //MemorizeForm memorizeForm = new MemorizeForm();
            //Application.Run(memorizeForm);

            //FirstTestForm firstTest = new FirstTestForm();
            //Application.Run(firstTest);

        }

    }
}
