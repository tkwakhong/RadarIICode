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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LngDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IiCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadarlocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadarsitelocationDataSet11 = New TestDBAddWindowsFormsApp.radarsitelocationDataSet1()
        Me.RadarsitelocationBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadarsitelocationDataSet1 = New TestDBAddWindowsFormsApp.radarsitelocationDataSet()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.LatitudeTextBox = New System.Windows.Forms.TextBox()
        Me.LongtitudeTextBox = New System.Windows.Forms.TextBox()
        Me.SiteNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadarsitelocationBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadarsitelocationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadarsitelocationDataSet = New TestDBAddWindowsFormsApp.radarsitelocationDataSet()
        Me.RadarsitelocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadarsitelocationTableAdapter = New TestDBAddWindowsFormsApp.radarsitelocationDataSetTableAdapters.radarsitelocationTableAdapter()
        Me.RadarsitelocationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TestDBAddWindowsFormsApp.DataSet1()
        Me.RadarsitelocationBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadarsitelocationTableAdapter1 = New TestDBAddWindowsFormsApp.DataSet1TableAdapters.radarsitelocationTableAdapter()
        Me.RadarlocationTableAdapter = New TestDBAddWindowsFormsApp.radarsitelocationDataSet1TableAdapters.radarlocationTableAdapter()
        Me.DeleteRadarSiteButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataSet11 = New TestDBAddWindowsFormsApp.DataSet1()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckIICodeButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteRadarSiteNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ShowDataButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarlocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadarsitelocationBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.LngDataGridViewTextBoxColumn, Me.LatDataGridViewTextBoxColumn, Me.IiCodeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RadarlocationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(90, 276)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(493, 280)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(493, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(493, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'LngDataGridViewTextBoxColumn
        '
        Me.LngDataGridViewTextBoxColumn.DataPropertyName = "lng"
        Me.LngDataGridViewTextBoxColumn.HeaderText = "lng"
        Me.LngDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LngDataGridViewTextBoxColumn.Name = "LngDataGridViewTextBoxColumn"
        Me.LngDataGridViewTextBoxColumn.ReadOnly = True
        Me.LngDataGridViewTextBoxColumn.Width = 125
        '
        'LatDataGridViewTextBoxColumn
        '
        Me.LatDataGridViewTextBoxColumn.DataPropertyName = "lat"
        Me.LatDataGridViewTextBoxColumn.HeaderText = "lat"
        Me.LatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LatDataGridViewTextBoxColumn.Name = "LatDataGridViewTextBoxColumn"
        Me.LatDataGridViewTextBoxColumn.ReadOnly = True
        Me.LatDataGridViewTextBoxColumn.Width = 125
        '
        'IiCodeDataGridViewTextBoxColumn
        '
        Me.IiCodeDataGridViewTextBoxColumn.DataPropertyName = "iiCode"
        Me.IiCodeDataGridViewTextBoxColumn.HeaderText = "iiCode"
        Me.IiCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IiCodeDataGridViewTextBoxColumn.Name = "IiCodeDataGridViewTextBoxColumn"
        Me.IiCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.IiCodeDataGridViewTextBoxColumn.Width = 125
        '
        'RadarlocationBindingSource
        '
        Me.RadarlocationBindingSource.DataMember = "radarlocation"
        Me.RadarlocationBindingSource.DataSource = Me.RadarsitelocationDataSet11
        '
        'RadarsitelocationDataSet11
        '
        Me.RadarsitelocationDataSet11.DataSetName = "radarsitelocationDataSet1"
        Me.RadarsitelocationDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadarsitelocationBindingSource5
        '
        Me.RadarsitelocationBindingSource5.DataMember = "radarsitelocation"
        Me.RadarsitelocationBindingSource5.DataSource = Me.RadarsitelocationDataSet1
        '
        'RadarsitelocationDataSet1
        '
        Me.RadarsitelocationDataSet1.DataSetName = "radarsitelocationDataSet"
        Me.RadarsitelocationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(20, 169)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(110, 33)
        Me.InsertButton.TabIndex = 50
        Me.InsertButton.Text = "Add New Site"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'LatitudeTextBox
        '
        Me.LatitudeTextBox.Location = New System.Drawing.Point(128, 119)
        Me.LatitudeTextBox.Name = "LatitudeTextBox"
        Me.LatitudeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LatitudeTextBox.TabIndex = 49
        '
        'LongtitudeTextBox
        '
        Me.LongtitudeTextBox.Location = New System.Drawing.Point(128, 76)
        Me.LongtitudeTextBox.Name = "LongtitudeTextBox"
        Me.LongtitudeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LongtitudeTextBox.TabIndex = 48
        '
        'SiteNameTextBox
        '
        Me.SiteNameTextBox.Location = New System.Drawing.Point(128, 31)
        Me.SiteNameTextBox.MaxLength = 6
        Me.SiteNameTextBox.Name = "SiteNameTextBox"
        Me.SiteNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SiteNameTextBox.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Latitude"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Longtitude"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Site Name"
        '
        'RadarsitelocationBindingSource3
        '
        Me.RadarsitelocationBindingSource3.DataMember = "radarsitelocation"
        Me.RadarsitelocationBindingSource3.DataSource = Me.RadarsitelocationDataSet1
        '
        'RadarsitelocationBindingSource1
        '
        Me.RadarsitelocationBindingSource1.DataMember = "radarsitelocation"
        Me.RadarsitelocationBindingSource1.DataSource = Me.RadarsitelocationDataSet
        '
        'RadarsitelocationDataSet
        '
        Me.RadarsitelocationDataSet.DataSetName = "radarsitelocationDataSet"
        Me.RadarsitelocationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadarsitelocationBindingSource
        '
        Me.RadarsitelocationBindingSource.DataMember = "radarsitelocation"
        Me.RadarsitelocationBindingSource.DataSource = Me.RadarsitelocationDataSet
        '
        'RadarsitelocationTableAdapter
        '
        Me.RadarsitelocationTableAdapter.ClearBeforeFill = True
        '
        'RadarsitelocationBindingSource2
        '
        Me.RadarsitelocationBindingSource2.DataMember = "radarsitelocation"
        Me.RadarsitelocationBindingSource2.DataSource = Me.RadarsitelocationDataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadarsitelocationBindingSource4
        '
        Me.RadarsitelocationBindingSource4.DataMember = "radarsitelocation"
        Me.RadarsitelocationBindingSource4.DataSource = Me.DataSet1
        '
        'RadarsitelocationTableAdapter1
        '
        Me.RadarsitelocationTableAdapter1.ClearBeforeFill = True
        '
        'RadarlocationTableAdapter
        '
        Me.RadarlocationTableAdapter.ClearBeforeFill = True
        '
        'DeleteRadarSiteButton
        '
        Me.DeleteRadarSiteButton.Location = New System.Drawing.Point(46, 65)
        Me.DeleteRadarSiteButton.Name = "DeleteRadarSiteButton"
        Me.DeleteRadarSiteButton.Size = New System.Drawing.Size(144, 26)
        Me.DeleteRadarSiteButton.TabIndex = 52
        Me.DeleteRadarSiteButton.Text = "Delete Radar Site"
        Me.DeleteRadarSiteButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Site Name"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckIICodeButton)
        Me.GroupBox1.Controls.Add(Me.LatitudeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.InsertButton)
        Me.GroupBox1.Controls.Add(Me.SiteNameTextBox)
        Me.GroupBox1.Controls.Add(Me.LongtitudeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 220)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Radar Site"
        '
        'CheckIICodeButton
        '
        Me.CheckIICodeButton.Location = New System.Drawing.Point(145, 169)
        Me.CheckIICodeButton.Name = "CheckIICodeButton"
        Me.CheckIICodeButton.Size = New System.Drawing.Size(114, 33)
        Me.CheckIICodeButton.TabIndex = 51
        Me.CheckIICodeButton.Text = "Check IICode"
        Me.CheckIICodeButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteRadarSiteNameComboBox)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DeleteRadarSiteButton)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 110)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delete Radar Site"
        '
        'DeleteRadarSiteNameComboBox
        '
        Me.DeleteRadarSiteNameComboBox.FormattingEnabled = True
        Me.DeleteRadarSiteNameComboBox.Location = New System.Drawing.Point(107, 29)
        Me.DeleteRadarSiteNameComboBox.Name = "DeleteRadarSiteNameComboBox"
        Me.DeleteRadarSiteNameComboBox.Size = New System.Drawing.Size(102, 24)
        Me.DeleteRadarSiteNameComboBox.TabIndex = 60
        '
        'ShowDataButton
        '
        Me.ShowDataButton.Location = New System.Drawing.Point(60, 65)
        Me.ShowDataButton.Name = "ShowDataButton"
        Me.ShowDataButton.Size = New System.Drawing.Size(106, 25)
        Me.ShowDataButton.TabIndex = 56
        Me.ShowDataButton.Text = "Show Data"
        Me.ShowDataButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ShowDataButton)
        Me.GroupBox3.Location = New System.Drawing.Point(373, 148)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 104)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Show Site Distance"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 24)
        Me.ComboBox1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Site Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(683, 610)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(701, 657)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(701, 657)
        Me.Name = "Form1"
        Me.Text = "Radar Site IICode"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarlocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadarsitelocationBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadarsitelocationDataSet As radarsitelocationDataSet
    Friend WithEvents RadarsitelocationBindingSource As BindingSource
    Friend WithEvents RadarsitelocationTableAdapter As radarsitelocationDataSetTableAdapters.radarsitelocationTableAdapter
    Friend WithEvents RadarsitelocationBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RadarsitelocationDataSet1 As radarsitelocationDataSet
    Friend WithEvents RadarsitelocationBindingSource2 As BindingSource
    Friend WithEvents RadarsitelocationBindingSource3 As BindingSource
    Friend WithEvents InsertButton As Button
    Friend WithEvents LatitudeTextBox As TextBox
    Friend WithEvents LongtitudeTextBox As TextBox
    Friend WithEvents SiteNameTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents RadarsitelocationBindingSource4 As BindingSource
    Friend WithEvents RadarsitelocationTableAdapter1 As DataSet1TableAdapters.radarsitelocationTableAdapter
    Friend WithEvents RadarsitelocationBindingSource5 As BindingSource
    Friend WithEvents RadarsitelocationDataSet11 As radarsitelocationDataSet1
    Friend WithEvents RadarlocationBindingSource As BindingSource
    Friend WithEvents RadarlocationTableAdapter As radarsitelocationDataSet1TableAdapters.radarlocationTableAdapter
    Friend WithEvents DeleteRadarSiteButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LngDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IiCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ShowDataButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DeleteRadarSiteNameComboBox As ComboBox
    Friend WithEvents CheckIICodeButton As Button
End Class
