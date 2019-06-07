using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XTBLTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DetectMods();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabselect_Mods_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 0;
            tabselect_Mods.ForeColor = Color.FromArgb(221, 146, 0);
            tabselect_Settings.ForeColor = Color.FromArgb(162, 105, 0);
            tabselect_Other.ForeColor = Color.FromArgb(162, 105, 0);
        }

        private void tabselect_Settings_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 1;
            tabselect_Mods.ForeColor = Color.FromArgb(162, 105, 0);
            tabselect_Settings.ForeColor = Color.FromArgb(221, 146, 0);
            tabselect_Other.ForeColor = Color.FromArgb(162, 105, 0);
        }

        private void tabselect_Other_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 2;
            tabselect_Mods.ForeColor = Color.FromArgb(162, 105, 0);
            tabselect_Settings.ForeColor = Color.FromArgb(162, 105, 0);
            tabselect_Other.ForeColor = Color.FromArgb(221, 146, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.Description = "Browse for your RF:GR folder! Do NOT select a directory that isn't your game folder.";
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                game_DirectoryText.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                DetectMods();
            }
        }

        public void DetectMods()
        {
            try
            {
                modList.Items.Clear();

                string gamePath = game_DirectoryText.Text + "\\mods";

                // Get directory info
                DirectoryInfo dInfo = new DirectoryInfo(gamePath);
                // Get the XML files from the start directory and sub-directories
                FileInfo[] fInfo = dInfo.GetFiles("*.xml", SearchOption.AllDirectories);

                foreach (FileInfo file in fInfo)
                {
                        // Load the XML document that was found
                        XDocument xdoc = XDocument.Load(file.FullName);

                        var elements = from r in xdoc.Descendants("Mod")
                                       select new
                                       {
                                           ModName = r.Attribute("Name").Value ?? "Not Set"
                                       };

                        foreach (var r in elements)
                        {
                            // Add to listbox
                            modList.Items.Add(r.ModName);
                        }
                }
                
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Your RF:GR folder does not include a ''mods'' folder!", "DirectoryNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show("The process failed: " + a.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnpackVPP()
        {
            string[] Args = { game_DirectoryText.Text + "\\data\\misc.vpp_pc", game_DirectoryText.Text + "\\data\\misc.vpp" };
            int UnpackExitCode = new Gibbed.Volition.Pack.VPP.Unpacker<Gibbed.Volition.FileFormats.PackageFileV3>().Main(Args);
        }

        public void PackVPP()
        {
            string[] Args = { game_DirectoryText.Text + "\\data\\misc_PACKED.vpp_pc", game_DirectoryText.Text + "\\data\\misc.vpp\\" };
            int UnpackExitCode = new Gibbed.Volition.Pack.VPP.Packer<Gibbed.Volition.FileFormats.PackageFileV3, Gibbed.Volition.FileFormats.Package.Entry>().Main(Args);
        }

        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        {
            File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);
        }

        public void ReplaceFunction()
        {
            string selecteditem = modList.GetItemText(modList.CheckedItems);

            string dirScanner = game_DirectoryText.Text;

            // Scan for XML files located in the user specified game directory.
            string[] allFiles = Directory.GetFiles(dirScanner, "*.xml", SearchOption.AllDirectories);

            foreach (string file in modList.CheckedItems)
            {
                string[] lines = File.ReadAllLines(file);
                string firstOccurrence = lines.FirstOrDefault(l => l.Contains(selecteditem));
                if (firstOccurrence != null)
                {
                    XDocument xdoc = XDocument.Load(file);
                    var elements = from r in xdoc.Root.Descendants("Changes").Descendants("Replace")
                                   select new
                                   {

                                       ModFileToReplace = r.Attribute("File").Value,
                                       NewFileToReplace = r.Attribute("NewFile").Value

                                   };

                    foreach (var r in elements)
                    {
                        // Get value of the file it will replace
                        string ModFile = r.ModFileToReplace;

                        //// Get text before the last \ of the "File" attribute
                        //int index = ModFile.LastIndexOf('\\');
                        //string result = ModFile.Substring(0, index);

                        string parent_directory_path;
                        parent_directory_path = Path.GetDirectoryName(file);
                        Console.WriteLine(parent_directory_path);

                        // Replace files
                        string OriginalFile = parent_directory_path + "\\" + r.NewFileToReplace;
                        string FileToReplace = game_DirectoryText.Text + "\\" + r.ModFileToReplace;
                        string BackUpOfFileToReplace = game_DirectoryText.Text + "\\data\\misc.vpp\\startup_video_sequence.xtbl.BACKUP";

                        Console.WriteLine(OriginalFile);

                        try
                        {
                            //ReplaceFile(@OriginalFile, @FileToReplace, @BackUpOfFileToReplace);
                        }
                        catch (Exception a)
                        {
                            Console.WriteLine(a);
                        }
                    }
                }

            }


        }

        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = modList.GetItemText(modList.SelectedItem);

            string dirScanner = game_DirectoryText.Text + "\\mods";

            // Scan for XML files located in the user specified game directory.
            string[] allFiles = Directory.GetFiles(dirScanner, "*.xml", SearchOption.AllDirectories);

            foreach (string file in allFiles)
            {
                // Read XML files found in the game directory.
                string[] lines = File.ReadAllLines(file);
                
                // Find and search XML files with the same name of the listbox item.
                string firstOccurrence = lines.FirstOrDefault(l => l.Contains(selecteditem));
                if (firstOccurrence != null)
                {
                    XDocument xdoc = XDocument.Load(file);

                    // Descendants inside Mod 
                    var elements = from r in xdoc.Descendants("Mod")
                                   select new
                                   {
                                       ModName = r.Attribute("Name").Value ?? "Not Set",
                                       Author = r.Element("Author").Value,
                                       Description = r.Element("Description").Value
                                   };

                    foreach (var r in elements)
                    {
                        // Set mod info text for viewing by the user.
                        mod_NameText.Text = r.ModName;
                        mod_AuthorText.Text = r.Author;
                        mod_DescriptionText.Text = r.Description;
                    }
                }
            }
        }

        private void activateMods_Click(object sender, EventArgs e)
        {
            UnpackVPP();

            string selecteditem = modList.GetItemText(modList.SelectedItem);

            string dirScanner = game_DirectoryText.Text;

            // Scan for XML files located in the user specified game directory.
            string[] allFiles = Directory.GetFiles(dirScanner, "*.xml", SearchOption.AllDirectories);

            foreach (string file in allFiles)
            {
                string[] lines = File.ReadAllLines(file);
                string firstOccurrence = lines.FirstOrDefault(l => l.Contains(selecteditem));
                if (firstOccurrence != null)
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        // Read all contents from start to end
                        string contents = sr.ReadToEnd();

                        // Determine if there are any items checked.  


                        if (contents.Contains("<Replace"))
                        {
                            Console.WriteLine("This modinfo has the replace function!");
                            //ReplaceFunction();
                        }
                        else if (contents.Contains("<Edit"))
                        {
                            Console.WriteLine("This modinfo has the edit function!");
                        }
                    }
                }
            }

            //PackVPP();
        }

        private void restoreFiles_Click(object sender, EventArgs e)
        {
            //String[] itemArr = new String[modList.CheckedItems.Count];
            //Int32 counter = 0;
            //foreach (object item in this.modList.CheckedItems)
            //{
            //    String temp = Convert.ToString(item);
            //    itemArr[counter] = temp;
            //    counter++;
            //    MessageBox.Show(counter.ToString());
            //}

            StringBuilder sbCheckedItems = new StringBuilder();

            foreach (var cbx in modList.CheckedItems)
            {
                sbCheckedItems.Append(cbx.ToString() + "\n");
            }
            MessageBox.Show(sbCheckedItems.ToString());

            string line;
            using (StreamReader file = new StreamReader(sbCheckedItems.ToString()))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("<Replace"))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        private void runGame_Click(object sender, EventArgs e)
        {

            StringBuilder sbCheckedItems = new StringBuilder();

            foreach (var cbx in modList.CheckedItems)
            {
                sbCheckedItems.Append(cbx.ToString() + "\n");
            }
            MessageBox.Show(sbCheckedItems.ToString());


            string dirScanner = game_DirectoryText.Text + "\\mods";

            // Scan for XML files located in the user specified game directory.
            string[] allFiles = Directory.GetFiles(dirScanner, "*.xml", SearchOption.AllDirectories);

            foreach (string file in allFiles)
            {
                string[] lines = File.ReadAllLines(file);
                string firstOccurrence = lines.FirstOrDefault(l => l.Contains(sbCheckedItems.ToString()));
                if (firstOccurrence != null)
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        // Read all contents from start to end
                        string contents = sr.ReadToEnd();

                        if (contents.Contains("<Replace"))
                        {
                            Console.WriteLine("This modinfo has the replace function!");
                            //ReplaceFunction();
                        }
                        else if (contents.Contains("<Edit"))
                        {
                            Console.WriteLine("This modinfo has the edit function!");
                        }
                    }
                }
            }



            //        DirectoryInfo dir = new DirectoryInfo(game_DirectoryText.Text + "\\mods"); // dir where you want tu search your file
            //FileInfo[] fileInfo = dir.GetFiles();

            //foreach (FileInfo file in fileInfo)
            //{
            //    StreamReader sr = new StreamReader(file.FullName);
            //    string allRead = sr.ReadToEnd();
            //    sr.Close();
            //    string fileName = file.Name;
            //    if (Regex.IsMatch(allRead, "God"))
            //    {
            //        MessageBox.Show("Found: " + fileName);
            //        break;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Not Found");
            //    }
        }
    }
}
