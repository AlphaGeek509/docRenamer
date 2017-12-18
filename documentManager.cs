using docRenamer.TableClasses;
using docManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using docManager;


[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace docRenamer
{
    public partial class documentManager : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public documentManager()
        {
            InitializeComponent();

            supplierPacklist.DragDrop += dragDropAction;
            supplierPacklist.DragEnter += dragDropEnter;
            
            //customerPurchaseOrders.DragDrop += dragDropAction;
            //customerPurchaseOrders.DragEnter += dragDropEnter;

            //rawMaterialCerts.DragEnter += dragDropEnter;
            //rawMaterialCerts.DragEnter += dragDropEnter;

            log.Info("Program started");
        }


        private void dragDropAction(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Label docType = (Label)sender;
            
            foreach (string file in files) {
                try {
                    Document doc = DocumentFactory.GetDocument(docType.Text.Replace(" ", "_").ToUpper(), file);
                    doc.fileAct.copy = radCopy.Checked;
                    doc.fileAct.move = radMove.Checked;

                    doc.fileAct.transportFiles(doc.sourcePath, doc.targetPath, doc.targetRenamed);
                }
                catch (Exception exc) {
                    log.Error("Problem in executing file: " + file + " (" + exc.Message + ")");
                    MessageBox.Show(exc.Message.ToString());
                }
            }
        }

        //Show the dragable icon during the user process
        private void dragDropEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void CheckMenuItem(ToolStripMenuItem mnu, ToolStripMenuItem checked_item)
        {
            // Uncheck the menu items except checked_item.
            foreach (ToolStripItem item in mnu.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                {
                    ToolStripMenuItem menu_item = item as ToolStripMenuItem;
                    menu_item.Checked = (menu_item == checked_item);
                }
            }
        }

        /// <summary>
        /// Change the connecting DSN to VMFG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vmfgStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            CheckMenuItem(DsnStripMenuItem1, item);
            ConstantsEnums.connectionStringName = item.Text;
        }


        /// <summary>
        /// Change the connecting DSN to SAND7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sand7StripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            CheckMenuItem(DsnStripMenuItem1, item);
            ConstantsEnums.connectionStringName = item.Text;
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(ConstantsEnums.logFile);
        }

        private void documentManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    docManager.Properties.Settings.Default.Location = RestoreBounds.Location;
                    docManager.Properties.Settings.Default.Size = RestoreBounds.Size;
                    docManager.Properties.Settings.Default.Maximized = true;
                    docManager.Properties.Settings.Default.Minimized = false;
                }
                else if (WindowState == FormWindowState.Normal)
                {
                    docManager.Properties.Settings.Default.Location = Location;
                    docManager.Properties.Settings.Default.Size = Size;
                    docManager.Properties.Settings.Default.Maximized = false;
                    docManager.Properties.Settings.Default.Minimized = false;
                }
                else
                {
                    docManager.Properties.Settings.Default.Location = RestoreBounds.Location;
                    docManager.Properties.Settings.Default.Size = RestoreBounds.Size;
                    docManager.Properties.Settings.Default.Maximized = false;
                    docManager.Properties.Settings.Default.Minimized = true;
                }

                docManager.Properties.Settings.Default.fileActionCopy = radCopy.Checked;
                docManager.Properties.Settings.Default.fileActionMove = radMove.Checked;
                docManager.Properties.Settings.Default.DSN = ConstantsEnums.connectionStringName;
                docManager.Properties.Settings.Default.Save();
            } catch (Exception ex)
            {
                log.Error("Unable to save user settings: " + ex.Message);
                throw new Exception("Error in saving user settings: (" + ex.Message + ")");
            }
            

            log.Info("Program is closing");
        }

        private void documentManager_Load(object sender, EventArgs e)
        {
            if (docManager.Properties.Settings.Default.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                Location = docManager.Properties.Settings.Default.Location;
                Size = docManager.Properties.Settings.Default.Size;
            }
            else if (docManager.Properties.Settings.Default.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                Location = docManager.Properties.Settings.Default.Location;
                Size = docManager.Properties.Settings.Default.Size;
            }
            else
            {
                Location = docManager.Properties.Settings.Default.Location;
                Size = docManager.Properties.Settings.Default.Size;
            }

            try
            {
                radCopy.Checked = docManager.Properties.Settings.Default.fileActionCopy;
                radMove.Checked = docManager.Properties.Settings.Default.fileActionMove;
                string dsnName = docManager.Properties.Settings.Default.DSN.ToLower() + "StripMenuItem";
                ToolStripMenuItem item = menuStrip1.Items
                    .Find(dsnName, true)
                    .OfType<ToolStripMenuItem>()
                    .Single();
                item.Checked = true;
                log.Info("Loaded user settings from app.");
            }
            catch (Exception ex)
            {
                log.Error("Unable to get users settings: " + ex.Message + ")");
                throw new Exception("Unable to set user settings:" + ex.Message + ")");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox frmAbout = new aboutBox();
            frmAbout.Show();
        }
    }

    /// <summary>
    /// Main interaction factory for instantciating the correct document types.
    /// <returns>The corresponding document class.</returns>
    /// </summary>
    public static class DocumentFactory
    {
        public static Document GetDocument(string documentName, string file)
        {
            switch(documentName)
            {
                case "SUPPLIER_PACKLISTS":
                    return new supplierPacklist(file);
                case "SUPPLIER_RFQS":
                    return new SupplierRfq(file);
                case "CUSTOMER_PURCHASE_ORDERS":
                    return new CustomerPurchaseOrders(file);
                default:
                    throw new Exception("Unable to establish a document type with document name of: " + documentName);
            }
        }
    }

    public interface iDocument
    {
        string serverName    { get; set; }
        string sourcePath    { get; set; }
        string targetPath    { get; set; }
        string docType       { get; set; }
        string targetRenamed { get; set; }
        fileAction fileAct   { get; set; }
    }
    
    /// <summary>
    /// The document class for Supplier Packlists
    /// </summary>
    public class supplierPacklist : Document
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public supplierPacklist(string file)
        {
            try {
                log.Info("Loading Supplier Packlist class.");
                docType     = "SUPPLIER_PACKLISTS";
                sourcePath  = file;
                targetPath = setTargetPath();
                targetRenamed = promptForRename("Must provide a Receiver ID (R#) to proceed.");
                
                //Validate that the receiver is in Visual before proceeding.
                var doc = new RECEIVER();
                var isValid = doc.Count(where: "WHERE ID=:0", args: targetRenamed);
                if (isValid != 1)
                {
                    log.Error("Could not find target file: (" + targetRenamed + ") in the DB: " + ConstantsEnums.connectionStringName);
                    throw new Exception("The Receiver ID you entered is not found in Visual.");
                }
                else
                {
                    log.Info("target file: (" + targetRenamed + ") was found in the DB: " + ConstantsEnums.connectionStringName);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    /// <summary>
    /// The document class for Supplier RFQs
    /// </summary>
    public class SupplierRfq : Document
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public SupplierRfq(string file)
        {
            try
            {
                log.Info("Loading Supplier Packlist class.");
                docType = "SUPPLIER_RFQS";
                sourcePath = file;
                targetPath = setTargetPath();
            } catch (Exception e) {
                throw e;
            }
        }
    }

    /// <summary>
    /// The document class for Supplier RFQs
    /// </summary>
    public class CustomerPurchaseOrders : Document
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public CustomerPurchaseOrders(string file)
        {
            docType = "CUSTOMER_PURCHASE_ORDERS";
            sourcePath = file;
            targetPath = setTargetPath();
        }
    }

    /// <summary>
    /// General calls that holds file manipulation tasks and boolean values for move/copy.
    /// </summary>
    public class fileAction
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public bool move { get; set; }
        public bool copy { get; set; }

        public fileAction()
        {
            move = false;
            copy = false;
        }

        /// <summary>
        /// Peforms the requested operations (copy or move) on a file 
        /// </summary>
        /// <param name="srcPath">The source path with filename, too.</param>
        /// <param name="tgtPath">The target path</param>
        /// <returns></returns>
        public void transportFiles(string srcPath, string tgtPath, string renameValue = null)
        {
            string fileName = Path.GetFileName(srcPath);
            string fileExentsion = Path.GetExtension(srcPath);
            string sourcePath = Path.GetDirectoryName(srcPath);
            string targetPath = Path.GetDirectoryName(tgtPath);

            // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            if (renameValue != null)
            {
                destFile = Path.Combine(targetPath, renameValue + fileExentsion);
            }

            destFile = setUniqueFileName(destFile);

            try{
                // To copy a folder's contents to a new location: Create a new target folder, if necessary.
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                    log.Info("Directory not found and created: (" + targetPath + ")");
                }

                // To copy a file to another location and overwrite the destination file if it already exists.
                if(this.copy)
                {
                    File.Copy(sourceFile, destFile, true);
                    log.Info("File copied successfully - src: (" + sourceFile + ") target: (" + destFile + ")");
                }
                else if(this.move)
                {
                    File.Move(sourceFile, destFile);
                    log.Info("File moved successfully - src: (" + sourceFile + ") target: (" + destFile + ")");
                }

                #region CopyDirectories
                // To copy all the files in one directory to another directory.  Get the files in the source folder.
                // Directory manipulation is not considered at this time.
                //if (Directory.Exists(sourcePath))
                //{
                //    string[] files = Directory.GetFiles(sourcePath);

                //    // Copy the files and overwrite destination files if they already exist.
                //    foreach (string s in files)
                //    {
                //        // Use static Path methods to extract only the file name from the path.
                //        fileName = Path.GetFileName(s);
                //        destFile = Path.Combine(targetPath, fileName);
                //        if(this.copy)
                //        {
                //            File.Copy(s, destFile, true);
                //        }
                //        else if(this.move)
                //        {
                //            File.Move(s, destFile);
                //        }
                    
                //    }
                //}
                #endregion
            }
            catch(Exception ex)
            {
                log.Error("Unable to perform transportFiles function: " + ex.Message);
                throw new Exception("An error occured during the file transport process.");
            }
        }

        private string setUniqueFileName(string path)
        {
            int count = 1;
            string fileNameOnly = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            string directoryPath = Path.GetDirectoryName(path);
            string newFullPath = path;

            while (File.Exists(newFullPath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(directoryPath, tempFileName + extension);
                log.Info("Submitted file name (" + newFullPath + ") was found.  Auto rename: (" + tempFileName + extension + ")");
            }

            return newFullPath;
        }
    }

    /// <summary>
    /// The core class for any document.
    /// </summary>
    public class Document : iDocument
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string serverName    { get; set; }
        public string sourcePath    { get; set; }
        public string targetPath    { get; set; }
        public string docType       { get; set; }
        public fileAction fileAct   { get; set; }
        public string targetRenamed { get; set; }

        public Document() {
            serverName  = "\\\\LYNTRON3\\DocumentImages";
            fileAct     = new fileAction();
            sourcePath = "";
            targetPath = "";
            docType = "";
            targetRenamed = "";
        }

        public string setTargetPath()
        {
            if(this.sourcePath != null)
            {
                int count = 1;
                string fileNameOnly = Path.GetFileNameWithoutExtension(this.sourcePath);
                string extension = Path.GetExtension(this.sourcePath);
                string path = this.serverName + "\\" + this.docType + "\\";
                string newFullPath = path + fileNameOnly + extension;

                while (File.Exists(newFullPath))
                {
                    string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                    newFullPath = Path.Combine(path, tempFileName + extension);
                }

                return newFullPath;
            }
            else
            {
                throw new Exception("Unable to set target path without a valid source path.");
            }
            
        }


        public string promptForRename(string messagePrompt)
        {
            renamePrompt frmRename = new renamePrompt();

            frmRename.promptMsg.Text = messagePrompt;
            frmRename.renameValue.Focus();
            if (frmRename.ShowDialog() == DialogResult.OK)
            {
                return frmRename.renameValue.Text.Trim();
            }
            else
            {
                log.Error("User did not input a new name.");
                throw new Exception("You must rename the file to proceed.");
            }
        }
    }


}