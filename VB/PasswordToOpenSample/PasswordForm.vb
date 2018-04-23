Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace PasswordToOpenSample
    Partial Public Class PasswordForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property Password() As String
            Get
                Return textBox1.Text
            End Get
            Set(ByVal value As String)
                textBox1.Text = value
            End Set
        End Property
    End Class
End Namespace
