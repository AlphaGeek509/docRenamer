using docRenamer.TableClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docRenamer
{
    public partial class Form1 : Form
    {
        //private event EventHandler dragDropAction;

        public Form1()
        {
            InitializeComponent();

            supplierPacklist.DragDrop += dragDropAction;
            supplierPacklist.DragEnter += dragDropEnter;
            
            customerPurchaseOrders.DragDrop += dragDropAction;
            customerPurchaseOrders.DragEnter += dragDropEnter;

            rawMaterialCerts.DragEnter += dragDropEnter;
            rawMaterialCerts.DragEnter += dragDropEnter;

        }


        private void dragDropAction(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Label docType = (Label)sender;

            foreach (string file in files) {
                try {
                    Document doc = DocumentFactory.GetDocument(Convert.ToInt32(docType.Tag), file);
                    doc.fileAct.copy = true;
                    doc.fileAct.transportFiles(doc.sourcePath, doc.targetPath);
                }
                catch (Exception exc) {
                    MessageBox.Show(exc.InnerException.ToString());
                }
            }
        }

        //Show the dragable icon during the user process
        private void dragDropEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }

    /// <summary>
    /// Main interaction factory for instantciating the correct document types.
    /// <returns>The corresponding document class.</returns>
    /// </summary>
    public static class DocumentFactory
    {
        public static Document GetDocument(int docCode, string file)
        {
            switch(docCode)
            {
                case 1:
                    return new supplierPacklist(file);
                case 2:
                    return new SupplierRfq(file);
                default:
                    throw new Exception("Unable to establish a document type with id: " + docCode);
            }
        }
    }

    public interface iDocument
    {
        string serverName   { get; set; }
        string sourcePath   { get; set; }
        string targetPath   { get; set; }
        string docType      { get; set; }
        fileAction fileAct   { get; set; }
    }
    
    /// <summary>
    /// The document class for Supplier Packlists
    /// </summary>
    public class supplierPacklist : Document
    {
        public supplierPacklist(string file)
        {
            docType     = "SUPPLIER_PACKLIST";
            sourcePath  = file;
            targetPath = setTargetPath();

        }
    }

    /// <summary>
    /// The document class for Supplier RFQs
    /// </summary>
    public class SupplierRfq : Document
    {
        public SupplierRfq(string file)
        {
            docType = "SUPPLIER_RFQ";
            sourcePath = file;
            targetPath = setTargetPath();
        }
    }

    /// <summary>
    /// General calls that holds file manipulation tasks and boolean values for move/copy.
    /// </summary>
    public class fileAction
    {
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
        public void transportFiles(string srcPath, string tgtPath)
        {
            string fileName = Path.GetFileName(srcPath);
            string sourcePath = Path.GetExtension(srcPath);
            string targetPath = Path.GetExtension(tgtPath);

            // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            try{
                // To copy a folder's contents to a new location: Create a new target folder, if necessary.
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                // To copy a file to another location and overwrite the destination file if it already exists.
                if(this.copy)
                {
                    File.Copy(sourceFile, destFile, true);
                }
                else if(this.move)
                {
                    File.Move(sourceFile, destFile);
                }
            
            
                // To copy all the files in one directory to another directory.  Get the files in the source folder.
                if (Directory.Exists(sourcePath))
                {
                    string[] files = Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = Path.GetFileName(s);
                        destFile = Path.Combine(targetPath, fileName);
                        if(this.copy)
                        {
                            File.Copy(s, destFile, true);
                        }
                        else if(this.move)
                        {
                            File.Move(s, destFile);
                        }
                    
                    }
                }
            }
            catch(Exception)
            {
                throw new Exception("An error occured during the file transport process.");
            }
        }
    }

    /// <summary>
    /// The core class for any document.
    /// </summary>
    public class Document : iDocument
    {
        public string serverName    { get; set; }
        public string sourcePath    { get; set; }
        public string targetPath    { get; set; }
        public string docType       { get; set; }
        public fileAction fileAct   { get; set; }

        public Document() {
            serverName = "LYNTRON3\\DocumentImages";
        }

        public string setTargetPath()
        {
            if(this.sourcePath != null)
            {
                int count = 1;
                string fileNameOnly = Path.GetFileNameWithoutExtension(this.sourcePath);
                string extension = Path.GetExtension(this.sourcePath);
                string path = Path.GetDirectoryName(this.sourcePath);
                string newFullPath = "\\" + this.serverName + "\\" + this.docType + "\\" + DateTime.Today.Year + "\\" + DateTime.Today.Month + "\\" + fileNameOnly + extension;

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

        /// <summary>
        /// An "interface" for fileAction.transportFiles
        /// </summary>
        public void copyFileToServer()
        {
            this.fileAct.transportFiles(this.sourcePath, this.targetPath);
        }
    }
}