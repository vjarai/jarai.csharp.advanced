using System.Diagnostics;
using Microsoft.Office.Interop.Outlook;

//https://docs.microsoft.com/en-us/office/client-developer/outlook/pia/how-to-enumerate-folders?redirectedfrom=MSDN

namespace OutlookApp.Automation
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var outlook = new Microsoft.Office.Interop.Outlook.Application();

            var root = outlook.Session.DefaultStore.GetRootFolder() as Folder;

            EnumerateChildFolders(root);

            return 0;
        }

        // Uses recursion to enumerate Outlook subfolders.
        private static void EnumerateChildFolders(Folder folder)
        {
            foreach (Folder childFolder in folder.Folders)
            {
                Debug.WriteLine(childFolder.FolderPath);

                var items = childFolder.Items;

                //var filteredItems = items.Find("???");

                foreach (dynamic item in items)
                {
                    string body = item.Body;
                    Debug.WriteLine(body);
                }

                EnumerateChildFolders(childFolder);
            }
        }
    }
}