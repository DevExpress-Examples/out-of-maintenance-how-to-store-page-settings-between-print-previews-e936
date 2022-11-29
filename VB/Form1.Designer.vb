Namespace S130362

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim relationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S130362.Form1))
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitsInStock = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitsOnOrder = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldContactName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldContactTitle = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.button1 = New System.Windows.Forms.Button()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataMember = "Products"
            Me.pivotGridControl1.DataSource = Me.sqlDataSource1
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldUnitPrice, Me.fieldUnitsInStock, Me.fieldUnitsOnOrder, Me.fieldCategoryName, Me.fieldContactName, Me.fieldContactTitle})
            Me.pivotGridControl1.Location = New System.Drawing.Point(13, 42)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(544, 340)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductName"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""283"" />"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "UnitPrice"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "UnitsInStock"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "UnitsOnOrder"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "CategoryName"
            table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""183"" />"
            table2.Name = "Categories"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "ContactName"
            table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""303"" />"
            table3.Name = "Suppliers"
            columnExpression6.Table = table3
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "ContactTitle"
            columnExpression7.Table = table3
            column7.Expression = columnExpression7
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            join1.KeyColumns.Add(relationColumnInfo1)
            join1.Nested = table2
            join1.Parent = table1
            relationColumnInfo2.NestedKeyColumn = "SupplierID"
            relationColumnInfo2.ParentKeyColumn = "SupplierID"
            join2.KeyColumns.Add(relationColumnInfo2)
            join2.Nested = table3
            join2.Parent = table1
            selectQuery1.Relations.Add(join1)
            selectQuery1.Relations.Add(join2)
            selectQuery1.Tables.Add(table1)
            selectQuery1.Tables.Add(table2)
            selectQuery1.Tables.Add(table3)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            ' 
            ' fieldUnitPrice
            ' 
            Me.fieldUnitPrice.AreaIndex = 1
            Me.fieldUnitPrice.Caption = "Unit Price"
            Me.fieldUnitPrice.FieldName = "UnitPrice"
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            ' 
            ' fieldUnitsInStock
            ' 
            Me.fieldUnitsInStock.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitsInStock.AreaIndex = 0
            Me.fieldUnitsInStock.Caption = "Units In Stock"
            Me.fieldUnitsInStock.FieldName = "UnitsInStock"
            Me.fieldUnitsInStock.Name = "fieldUnitsInStock"
            ' 
            ' fieldUnitsOnOrder
            ' 
            Me.fieldUnitsOnOrder.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitsOnOrder.AreaIndex = 1
            Me.fieldUnitsOnOrder.Caption = "Units On Order"
            Me.fieldUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.fieldUnitsOnOrder.Name = "fieldUnitsOnOrder"
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldContactName
            ' 
            Me.fieldContactName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldContactName.AreaIndex = 1
            Me.fieldContactName.Caption = "Contact Name"
            Me.fieldContactName.FieldName = "ContactName"
            Me.fieldContactName.Name = "fieldContactName"
            ' 
            ' fieldContactTitle
            ' 
            Me.fieldContactTitle.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldContactTitle.AreaIndex = 0
            Me.fieldContactTitle.Caption = "Contact Title"
            Me.fieldContactTitle.FieldName = "ContactTitle"
            Me.fieldContactTitle.Name = "fieldContactTitle"
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(13, 13)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Print"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(569, 394)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private button1 As System.Windows.Forms.Button

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldUnitsInStock As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldUnitsOnOrder As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldContactName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldContactTitle As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
