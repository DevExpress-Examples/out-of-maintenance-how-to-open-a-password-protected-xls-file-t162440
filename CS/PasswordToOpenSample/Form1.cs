using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using System.Windows.Forms;

namespace PasswordToOpenSample {
    public partial class Form1 : Form {
        string sourceUri;
        DocumentFormat sourceFormat;

        public Form1() {
            InitializeComponent();
            spreadsheetControl1.BeforeImport+=spreadsheetControl1_BeforeImport;
            spreadsheetControl1.InvalidFormatException+=spreadsheetControl1_InvalidFormatException;
        }

        private void spreadsheetControl1_BeforeImport(object sender, DevExpress.Spreadsheet.SpreadsheetBeforeImportEventArgs e) {
            sourceUri = e.Options.SourceUri;
            sourceFormat = e.DocumentFormat;
        }
        #region #decryptionexception
        private void spreadsheetControl1_InvalidFormatException(object sender, SpreadsheetInvalidFormatExceptionEventArgs e) {
            SpreadsheetDecryptionException decryptionException = e.Exception as SpreadsheetDecryptionException;
            if (decryptionException != null && sourceFormat == DocumentFormat.Xls) {
                if (decryptionException.Error == SpreadsheetDecryptionError.PasswordRequired) {
                    using (PasswordForm form = new PasswordForm()) {
                        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                            spreadsheetControl1.Options.Import.Xls.Password = form.Password;
                            spreadsheetControl1.LoadDocument(sourceUri);
                            spreadsheetControl1.Options.Import.Xls.Password = string.Empty;
                        }
                    }
                }
                else if (decryptionException.Error == SpreadsheetDecryptionError.WrongPassword) {
                    MessageBox.Show("Incorrect password", 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (decryptionException.Error == SpreadsheetDecryptionError.EncryptionTypeNotSupported) {
                    MessageBox.Show("Unsupported encryption type.", 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else {
                MessageBox.Show(string.Format("Cannot open the file {0} because file format is not valid.", sourceUri),
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion #decryptionexception
    }
}
