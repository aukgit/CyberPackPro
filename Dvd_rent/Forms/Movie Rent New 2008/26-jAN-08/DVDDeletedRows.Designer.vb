<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVDDeletedRows
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DVDDeletedRows))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.DVD_RentDeletedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DVD_RentDeletedTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.DVD_RentDeletedTableAdapter
        Me.DVD_RentDeletedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.DVD_RentDeletedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.DVD_RentDataGridView = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TransferToDVDRENTDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ID_Field_OFREnt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeleteComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deleted_Date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deleted_Time = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Costomer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Movie_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Alternative_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Movie_Type_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Place_Field = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Date_Rent_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Return_date_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Is_Alternative_Field = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fine_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Is_Comments_Bad_Field = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DVD_Comments_dataField = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Due_Field = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVD_RentDeletedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVD_RentDeletedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DVD_RentDeletedBindingNavigator.SuspendLayout()
        CType(Me.DVD_RentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DVD_RentDeletedBindingSource
        '
        Me.DVD_RentDeletedBindingSource.DataMember = "DVD_RentDeleted"
        Me.DVD_RentDeletedBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'DVD_RentDeletedTableAdapter
        '
        Me.DVD_RentDeletedTableAdapter.ClearBeforeFill = True
        '
        'DVD_RentDeletedBindingNavigator
        '
        Me.DVD_RentDeletedBindingNavigator.AddNewItem = Nothing
        Me.DVD_RentDeletedBindingNavigator.BindingSource = Me.DVD_RentDeletedBindingSource
        Me.DVD_RentDeletedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DVD_RentDeletedBindingNavigator.DeleteItem = Nothing
        Me.DVD_RentDeletedBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVD_RentDeletedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.DVD_RentDeletedBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator1})
        Me.DVD_RentDeletedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DVD_RentDeletedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DVD_RentDeletedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DVD_RentDeletedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DVD_RentDeletedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DVD_RentDeletedBindingNavigator.Name = "DVD_RentDeletedBindingNavigator"
        Me.DVD_RentDeletedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DVD_RentDeletedBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.DVD_RentDeletedBindingNavigator.TabIndex = 0
        Me.DVD_RentDeletedBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(61, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DVD_RentDeletedBindingNavigatorSaveItem
        '
        Me.DVD_RentDeletedBindingNavigatorSaveItem.Image = CType(resources.GetObject("DVD_RentDeletedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DVD_RentDeletedBindingNavigatorSaveItem.Name = "DVD_RentDeletedBindingNavigatorSaveItem"
        Me.DVD_RentDeletedBindingNavigatorSaveItem.Size = New System.Drawing.Size(81, 22)
        Me.DVD_RentDeletedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButton1.Text = "&Query Manager"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripButton2.Text = "Load Whole Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel1.Text = "Date"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'DVD_RentDataGridView
        '
        Me.DVD_RentDataGridView.AllowUserToAddRows = False
        Me.DVD_RentDataGridView.AllowUserToResizeColumns = False
        Me.DVD_RentDataGridView.AllowUserToResizeRows = False
        Me.DVD_RentDataGridView.AutoGenerateColumns = False
        Me.DVD_RentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DVD_RentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Field_OFREnt, Me.DeleteComments, Me.Deleted_Date, Me.Deleted_Time, Me.Costomer_ID, Me.DataGridViewTextBoxColumn12, Me.Movie_Name, Me.DataGridViewTextBoxColumn10, Me.Alternative_Name, Me.Movie_Type_Field, Me.Place_Field, Me.Date_Rent_Field, Me.Return_date_Field, Me.Is_Alternative_Field, Me.DataGridViewTextBoxColumn20, Me.Fine_Field, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.Is_Comments_Bad_Field, Me.DVD_Comments_dataField, Me.Due_Field})
        Me.DVD_RentDataGridView.DataSource = Me.DVD_RentDeletedBindingSource
        Me.DVD_RentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DVD_RentDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DVD_RentDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DVD_RentDataGridView.Name = "DVD_RentDataGridView"
        Me.DVD_RentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DVD_RentDataGridView.Size = New System.Drawing.Size(792, 541)
        Me.DVD_RentDataGridView.TabIndex = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransferToDVDRENTDATABASEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(233, 26)
        '
        'TransferToDVDRENTDATABASEToolStripMenuItem
        '
        Me.TransferToDVDRENTDATABASEToolStripMenuItem.Name = "TransferToDVDRENTDATABASEToolStripMenuItem"
        Me.TransferToDVDRENTDATABASEToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.TransferToDVDRENTDATABASEToolStripMenuItem.Text = "Transfer to DVDRENT DATABASE"
        '
        'ID_Field_OFREnt
        '
        Me.ID_Field_OFREnt.DataPropertyName = "ID"
        Me.ID_Field_OFREnt.HeaderText = "Column1"
        Me.ID_Field_OFREnt.Name = "ID_Field_OFREnt"
        Me.ID_Field_OFREnt.Visible = False
        '
        'DeleteComments
        '
        Me.DeleteComments.DataPropertyName = "DeleteComments"
        Me.DeleteComments.HeaderText = "UserID"
        Me.DeleteComments.Name = "DeleteComments"
        '
        'Deleted_Date
        '
        Me.Deleted_Date.DataPropertyName = "Deleted_Date"
        Me.Deleted_Date.HeaderText = "Deleted Date"
        Me.Deleted_Date.Name = "Deleted_Date"
        Me.Deleted_Date.ReadOnly = True
        '
        'Deleted_Time
        '
        Me.Deleted_Time.DataPropertyName = "Deleted_Time"
        Me.Deleted_Time.HeaderText = "Deleted Time"
        Me.Deleted_Time.Name = "Deleted_Time"
        Me.Deleted_Time.ReadOnly = True
        '
        'Costomer_ID
        '
        Me.Costomer_ID.DataPropertyName = "Costomer_ID"
        Me.Costomer_ID.HeaderText = "Customer ID"
        Me.Costomer_ID.Name = "Costomer_ID"
        Me.Costomer_ID.ReadOnly = True
        Me.Costomer_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DVD_ID"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn12.HeaderText = "DVD ID"
        Me.DataGridViewTextBoxColumn12.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 70
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Width = 70
        '
        'Movie_Name
        '
        Me.Movie_Name.DataPropertyName = "Movie_Name"
        Me.Movie_Name.HeaderText = "Movie Name"
        Me.Movie_Name.MaxInputLength = 80
        Me.Movie_Name.MinimumWidth = 220
        Me.Movie_Name.Name = "Movie_Name"
        Me.Movie_Name.ReadOnly = True
        Me.Movie_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Movie_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Movie_Name.Width = 220
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Costomer_Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn10.MaxInputLength = 25
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 140
        '
        'Alternative_Name
        '
        Me.Alternative_Name.DataPropertyName = "Alternative_Name"
        Me.Alternative_Name.HeaderText = "Alternative Name"
        Me.Alternative_Name.Name = "Alternative_Name"
        Me.Alternative_Name.ReadOnly = True
        Me.Alternative_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Movie_Type_Field
        '
        Me.Movie_Type_Field.DataPropertyName = "Movie_Type"
        Me.Movie_Type_Field.HeaderText = "Movie Type"
        Me.Movie_Type_Field.Name = "Movie_Type_Field"
        Me.Movie_Type_Field.ReadOnly = True
        Me.Movie_Type_Field.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Movie_Type_Field.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Movie_Type_Field.Visible = False
        Me.Movie_Type_Field.Width = 71
        '
        'Place_Field
        '
        Me.Place_Field.DataPropertyName = "Place"
        Me.Place_Field.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Place_Field.HeaderText = "Place"
        Me.Place_Field.Items.AddRange(New Object() {"Lost", "Broken", "InStore", "InHand", "Sold"})
        Me.Place_Field.Name = "Place_Field"
        Me.Place_Field.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Date_Rent_Field
        '
        Me.Date_Rent_Field.DataPropertyName = "Date_Rent"
        Me.Date_Rent_Field.HeaderText = "Rental Date"
        Me.Date_Rent_Field.MinimumWidth = 140
        Me.Date_Rent_Field.Name = "Date_Rent_Field"
        Me.Date_Rent_Field.ReadOnly = True
        Me.Date_Rent_Field.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Date_Rent_Field.Width = 140
        '
        'Return_date_Field
        '
        Me.Return_date_Field.DataPropertyName = "Return_date"
        Me.Return_date_Field.HeaderText = "Return Date"
        Me.Return_date_Field.MinimumWidth = 140
        Me.Return_date_Field.Name = "Return_date_Field"
        Me.Return_date_Field.ReadOnly = True
        Me.Return_date_Field.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Return_date_Field.Width = 140
        '
        'Is_Alternative_Field
        '
        Me.Is_Alternative_Field.DataPropertyName = "Is_Alternative"
        Me.Is_Alternative_Field.HeaderText = "Is_Alternative"
        Me.Is_Alternative_Field.MinimumWidth = 150
        Me.Is_Alternative_Field.Name = "Is_Alternative_Field"
        Me.Is_Alternative_Field.ReadOnly = True
        Me.Is_Alternative_Field.Width = 150
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Pay_Money"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Rental Cost"
        Me.DataGridViewTextBoxColumn20.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Fine_Field
        '
        Me.Fine_Field.DataPropertyName = "Fine"
        Me.Fine_Field.HeaderText = "Fine"
        Me.Fine_Field.MaxInputLength = 15
        Me.Fine_Field.MinimumWidth = 100
        Me.Fine_Field.Name = "Fine_Field"
        Me.Fine_Field.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "After_ReturnDate"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Received Date"
        Me.DataGridViewTextBoxColumn18.MaxInputLength = 25
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn18.Width = 120
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ReturnDistance_InHour"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn19.HeaderText = "Duration(H)"
        Me.DataGridViewTextBoxColumn19.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn19.ToolTipText = "IN HOUR BETWEEN NOW AND RETURN DATE"
        Me.DataGridViewTextBoxColumn19.Width = 126
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Costomers_Comments"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Customers Comments"
        Me.DataGridViewTextBoxColumn21.MaxInputLength = 120
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn21.Width = 150
        '
        'Is_Comments_Bad_Field
        '
        Me.Is_Comments_Bad_Field.DataPropertyName = "Is_Comments_Bad"
        Me.Is_Comments_Bad_Field.FalseValue = "False"
        Me.Is_Comments_Bad_Field.HeaderText = "Bad"
        Me.Is_Comments_Bad_Field.Name = "Is_Comments_Bad_Field"
        Me.Is_Comments_Bad_Field.ToolTipText = "Commnets Is Bad"
        Me.Is_Comments_Bad_Field.TrueValue = "True"
        '
        'DVD_Comments_dataField
        '
        Me.DVD_Comments_dataField.DataPropertyName = "DVD_Comments"
        Me.DVD_Comments_dataField.DropDownWidth = 200
        Me.DVD_Comments_dataField.HeaderText = "DVD Comments"
        Me.DVD_Comments_dataField.Items.AddRange(New Object() {"NoComments", "DVD CRASH BEFORE", "DVD QUALITY ISN'T GOOD"})
        Me.DVD_Comments_dataField.MinimumWidth = 140
        Me.DVD_Comments_dataField.Name = "DVD_Comments_dataField"
        Me.DVD_Comments_dataField.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DVD_Comments_dataField.Width = 140
        '
        'Due_Field
        '
        Me.Due_Field.DataPropertyName = "Due"
        Me.Due_Field.FalseValue = "FALSE"
        Me.Due_Field.HeaderText = "Due"
        Me.Due_Field.Name = "Due_Field"
        Me.Due_Field.TrueValue = "TRUE"
        Me.Due_Field.Width = 40
        '
        'DVDDeletedRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.DVD_RentDataGridView)
        Me.Controls.Add(Me.DVD_RentDeletedBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DVDDeletedRows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DVD RENT DELETED ROWS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVD_RentDeletedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVD_RentDeletedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DVD_RentDeletedBindingNavigator.ResumeLayout(False)
        Me.DVD_RentDeletedBindingNavigator.PerformLayout()
        CType(Me.DVD_RentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents DVD_RentDeletedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DVD_RentDeletedTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.DVD_RentDeletedTableAdapter
    Friend WithEvents DVD_RentDeletedBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DVD_RentDeletedBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DVD_RentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TransferToDVDRENTDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ID_Field_OFREnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deleted_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deleted_Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costomer_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movie_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alternative_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movie_Type_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Place_Field As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Date_Rent_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Return_date_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Is_Alternative_Field As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fine_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Is_Comments_Bad_Field As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DVD_Comments_dataField As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Due_Field As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
