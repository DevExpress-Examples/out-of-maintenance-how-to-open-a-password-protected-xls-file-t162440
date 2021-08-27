<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613853/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T162440)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PasswordToOpenSample/Form1.cs) (VB: [Form1.vb](./VB/PasswordToOpenSample/Form1.vb))
* [PasswordForm.cs](./CS/PasswordToOpenSample/PasswordForm.cs) (VB: [PasswordForm.vb](./VB/PasswordToOpenSample/PasswordForm.vb))
<!-- default file list end -->
# How to open a password protected .xls file


Starting with version 16.2, this technique becomes obsolete. Refer to the <a href="https://www.devexpress.com/Support/Center/p/T464814">How to load and save a password encrypted file</a> example for more information.<br><br>This example demonstrates the technique required to open a password protected .xls file prompting user for a correct password. <br>When the Spreadsheet control attempts to open a password protected .xls file and the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetImportXlsDocumentImporterOptions_Passwordtopic">Password</a> property is not set, the control raises the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSpreadsheetSpreadsheetControl_InvalidFormatExceptiontopic">InvalidFormatException</a> event with the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSpreadsheetSpreadsheetDecryptionExceptiontopic">SpreadsheetDecryptionException</a> exception in event arguments. If this event is not handled, the control cancels loading without any alert.<br>The method is to subscribe to the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSpreadsheetSpreadsheetControl_InvalidFormatExceptiontopic">InvalidFormatException</a> event, prompt the user for a password, specify the password and call the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSpreadsheetSpreadsheetControl_LoadDocumenttopic">SpreadsheetControl.LoadDocument</a>.<br>Note that this technique can be used for password-protected .xls documents created with Microsoft Excel versions up to 2010. The test file <em>password123.xls</em> is included in the project. Run the application and open this file using CTRL-O or the Open File... command. When prompted for a password, type in <em>123</em>.

<br/>


