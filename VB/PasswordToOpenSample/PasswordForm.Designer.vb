Namespace PasswordToOpenSample
    Partial Public Class PasswordForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(23, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(83, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Enter password:"
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(125, 25)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.PasswordChar = "*"c
            Me.textBox1.Size = New System.Drawing.Size(323, 20)
            Me.textBox1.TabIndex = 1
            Me.textBox1.UseSystemPasswordChar = True
            ' 
            ' button1
            ' 
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.button1.Location = New System.Drawing.Point(292, 63)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "OK"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' button2
            ' 
            Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button2.Location = New System.Drawing.Point(373, 63)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 3
            Me.button2.Text = "Cancel"
            Me.button2.UseVisualStyleBackColor = True
            ' 
            ' PasswordForm
            ' 
            Me.AcceptButton = Me.button1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.button2
            Me.ClientSize = New System.Drawing.Size(479, 114)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "PasswordForm"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Password required"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private label1 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private button1 As System.Windows.Forms.Button
        Private button2 As System.Windows.Forms.Button
    End Class
End Namespace