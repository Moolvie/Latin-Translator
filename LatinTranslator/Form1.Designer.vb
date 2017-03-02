<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSinister = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.lblEnglishTranslation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSinister
        '
        Me.btnSinister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinister.Location = New System.Drawing.Point(12, 82)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(80, 23)
        Me.btnSinister.TabIndex = 0
        Me.btnSinister.Text = "sinister"
        Me.btnSinister.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedium.Location = New System.Drawing.Point(103, 82)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(80, 23)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDexter.Location = New System.Drawing.Point(197, 82)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(80, 23)
        Me.btnDexter.TabIndex = 2
        Me.btnDexter.Text = "dexter"
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'lblEnglishTranslation
        '
        Me.lblEnglishTranslation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnglishTranslation.Location = New System.Drawing.Point(12, 23)
        Me.lblEnglishTranslation.Name = "lblEnglishTranslation"
        Me.lblEnglishTranslation.Size = New System.Drawing.Size(260, 27)
        Me.lblEnglishTranslation.TabIndex = 3
        Me.lblEnglishTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(103, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEnglishTranslation)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnSinister)
        Me.Name = "Form1"
        Me.Text = "Latin Translator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSinister As System.Windows.Forms.Button
    Friend WithEvents btnMedium As System.Windows.Forms.Button
    Friend WithEvents btnDexter As System.Windows.Forms.Button
    Friend WithEvents lblEnglishTranslation As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
