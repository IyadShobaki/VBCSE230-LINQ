<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinqToXmlForm
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
        Me.resultListBox = New System.Windows.Forms.ListBox()
        Me.btnLoadProducts = New System.Windows.Forms.Button()
        Me.btnGetProductInfo = New System.Windows.Forms.Button()
        Me.txtQuantityPerUnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnitsInStock = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'resultListBox
        '
        Me.resultListBox.FormattingEnabled = True
        Me.resultListBox.ItemHeight = 16
        Me.resultListBox.Location = New System.Drawing.Point(44, 41)
        Me.resultListBox.Name = "resultListBox"
        Me.resultListBox.Size = New System.Drawing.Size(296, 388)
        Me.resultListBox.TabIndex = 0
        '
        'btnLoadProducts
        '
        Me.btnLoadProducts.Location = New System.Drawing.Point(501, 41)
        Me.btnLoadProducts.Name = "btnLoadProducts"
        Me.btnLoadProducts.Size = New System.Drawing.Size(237, 23)
        Me.btnLoadProducts.TabIndex = 1
        Me.btnLoadProducts.Text = "Load Products"
        Me.btnLoadProducts.UseVisualStyleBackColor = True
        '
        'btnGetProductInfo
        '
        Me.btnGetProductInfo.Location = New System.Drawing.Point(501, 118)
        Me.btnGetProductInfo.Name = "btnGetProductInfo"
        Me.btnGetProductInfo.Size = New System.Drawing.Size(237, 23)
        Me.btnGetProductInfo.TabIndex = 2
        Me.btnGetProductInfo.Text = "Get Product Info"
        Me.btnGetProductInfo.UseVisualStyleBackColor = True
        '
        'txtQuantityPerUnit
        '
        Me.txtQuantityPerUnit.Location = New System.Drawing.Point(501, 199)
        Me.txtQuantityPerUnit.Name = "txtQuantityPerUnit"
        Me.txtQuantityPerUnit.Size = New System.Drawing.Size(237, 22)
        Me.txtQuantityPerUnit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(501, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Quantity Per Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Unit Price"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(501, 278)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(237, 22)
        Me.txtUnitPrice.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(504, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Units In Stock"
        '
        'txtUnitsInStock
        '
        Me.txtUnitsInStock.Location = New System.Drawing.Point(504, 367)
        Me.txtUnitsInStock.Name = "txtUnitsInStock"
        Me.txtUnitsInStock.Size = New System.Drawing.Size(237, 22)
        Me.txtUnitsInStock.TabIndex = 7
        '
        'LinqToXmlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUnitsInStock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantityPerUnit)
        Me.Controls.Add(Me.btnGetProductInfo)
        Me.Controls.Add(Me.btnLoadProducts)
        Me.Controls.Add(Me.resultListBox)
        Me.Name = "LinqToXmlForm"
        Me.Text = "LINQ to XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultListBox As ListBox
    Friend WithEvents btnLoadProducts As Button
    Friend WithEvents btnGetProductInfo As Button
    Friend WithEvents txtQuantityPerUnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUnitsInStock As TextBox
End Class
