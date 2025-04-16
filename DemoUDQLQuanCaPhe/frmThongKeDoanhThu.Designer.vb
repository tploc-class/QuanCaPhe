<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeDoanhThu
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
        DateTimePicker1 = New DateTimePicker()
        dgvDanhSach = New DataGridView()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "MM/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(12, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(12, 41)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.Size = New Size(874, 434)
        dgvDanhSach.TabIndex = 1
        ' 
        ' frmThongKeDoanhThu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 487)
        Controls.Add(dgvDanhSach)
        Controls.Add(DateTimePicker1)
        Name = "frmThongKeDoanhThu"
        Text = "frmThongKeDoanhThu"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dgvDanhSach As DataGridView
End Class
