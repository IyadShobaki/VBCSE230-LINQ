<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinqToObjectsForm
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lstBoxResults = New System.Windows.Forms.ListBox()
        Me.btnQuery1 = New System.Windows.Forms.Button()
        Me.btnQuery2 = New System.Windows.Forms.Button()
        Me.btnQuery3 = New System.Windows.Forms.Button()
        Me.btnQuery4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Location = New System.Drawing.Point(34, 13)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(99, 19)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Query results:"
        '
        'lstBoxResults
        '
        Me.lstBoxResults.FormattingEnabled = True
        Me.lstBoxResults.ItemHeight = 16
        Me.lstBoxResults.Location = New System.Drawing.Point(34, 56)
        Me.lstBoxResults.Name = "lstBoxResults"
        Me.lstBoxResults.Size = New System.Drawing.Size(304, 388)
        Me.lstBoxResults.TabIndex = 1
        '
        'btnQuery1
        '
        Me.btnQuery1.Location = New System.Drawing.Point(410, 56)
        Me.btnQuery1.Name = "btnQuery1"
        Me.btnQuery1.Size = New System.Drawing.Size(187, 50)
        Me.btnQuery1.TabIndex = 2
        Me.btnQuery1.Text = "1st LINQ Query"
        Me.btnQuery1.UseVisualStyleBackColor = True
        '
        'btnQuery2
        '
        Me.btnQuery2.Location = New System.Drawing.Point(410, 133)
        Me.btnQuery2.Name = "btnQuery2"
        Me.btnQuery2.Size = New System.Drawing.Size(187, 50)
        Me.btnQuery2.TabIndex = 3
        Me.btnQuery2.Text = "2nd LINQ Query"
        Me.btnQuery2.UseVisualStyleBackColor = True
        '
        'btnQuery3
        '
        Me.btnQuery3.Location = New System.Drawing.Point(410, 215)
        Me.btnQuery3.Name = "btnQuery3"
        Me.btnQuery3.Size = New System.Drawing.Size(187, 50)
        Me.btnQuery3.TabIndex = 4
        Me.btnQuery3.Text = "3rd LINQ Query"
        Me.btnQuery3.UseVisualStyleBackColor = True
        '
        'btnQuery4
        '
        Me.btnQuery4.Location = New System.Drawing.Point(410, 309)
        Me.btnQuery4.Name = "btnQuery4"
        Me.btnQuery4.Size = New System.Drawing.Size(187, 50)
        Me.btnQuery4.TabIndex = 5
        Me.btnQuery4.Text = "4th LINQ Query"
        Me.btnQuery4.UseVisualStyleBackColor = True
        '
        'LinqToObjectsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuery4)
        Me.Controls.Add(Me.btnQuery3)
        Me.Controls.Add(Me.btnQuery2)
        Me.Controls.Add(Me.btnQuery1)
        Me.Controls.Add(Me.lstBoxResults)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "LinqToObjectsForm"
        Me.Text = "Shobaki-LinqToObjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents lstBoxResults As ListBox
    Friend WithEvents btnQuery1 As Button
    Friend WithEvents btnQuery2 As Button
    Friend WithEvents btnQuery3 As Button
    Friend WithEvents btnQuery4 As Button
End Class
