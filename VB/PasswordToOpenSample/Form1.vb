Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet
Imports System.Windows.Forms

Namespace PasswordToOpenSample
    Partial Public Class Form1
        Inherits Form

        Private sourceUri As String
        Private sourceFormat As DocumentFormat

        Public Sub New()
            InitializeComponent()
            AddHandler spreadsheetControl1.BeforeImport, AddressOf spreadsheetControl1_BeforeImport
            AddHandler spreadsheetControl1.InvalidFormatException, AddressOf spreadsheetControl1_InvalidFormatException
        End Sub

        Private Sub spreadsheetControl1_BeforeImport(ByVal sender As Object, ByVal e As DevExpress.Spreadsheet.SpreadsheetBeforeImportEventArgs)
            sourceUri = e.Options.SourceUri
            sourceFormat = e.DocumentFormat
        End Sub
#Region "#decryptionexception"
        Private Sub spreadsheetControl1_InvalidFormatException(ByVal sender As Object, ByVal e As SpreadsheetInvalidFormatExceptionEventArgs)
            Dim decryptionException As SpreadsheetDecryptionException = TryCast(e.Exception, SpreadsheetDecryptionException)
            If decryptionException IsNot Nothing AndAlso sourceFormat = DocumentFormat.Xls Then
                If decryptionException.Error = SpreadsheetDecryptionError.PasswordRequired Then
                    Using form As New PasswordForm()
                        If form.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            spreadsheetControl1.Options.Import.Xls.Password = form.Password
                            spreadsheetControl1.LoadDocument(sourceUri)
                            spreadsheetControl1.Options.Import.Xls.Password = String.Empty
                        End If
                    End Using
                ElseIf decryptionException.Error = SpreadsheetDecryptionError.WrongPassword Then
                    MessageBox.Show("Incorrect password", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf decryptionException.Error = SpreadsheetDecryptionError.EncryptionTypeNotSupported Then
                    MessageBox.Show("Unsupported encryption type.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show(String.Format("Cannot open the file {0} because file format is not valid.", sourceUri), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End Sub
#End Region ' #decryptionexception
    End Class
End Namespace
