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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(223, 90)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(68, 31)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dgvServices
        '
        Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServices.Location = New System.Drawing.Point(54, 145)
        Me.dgvServices.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvServices.Name = "dgvServices"
        Me.dgvServices.RowHeadersWidth = 62
        Me.dgvServices.RowTemplate.Height = 28
        Me.dgvServices.Size = New System.Drawing.Size(573, 522)
        Me.dgvServices.TabIndex = 2
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(67, 91)
        Me.txtLanguage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(152, 22)
        Me.txtLanguage.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 774)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.dgvServices)
        Me.Controls.Add(Me.btnLoad)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As Button
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents txtLanguage As TextBox
End Class
