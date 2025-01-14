<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.nxtRound = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSword = New System.Windows.Forms.Button()
        Me.MarioJuanDatabase__1_DataSet = New Project_4_Juan_and_Mario.MarioJuanDatabase__1_DataSet()
        Me.MarioJuanDatabase1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBow = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnArmor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarioJuanDatabase__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarioJuanDatabase1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nxtRound
        '
        Me.nxtRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nxtRound.Location = New System.Drawing.Point(12, 135)
        Me.nxtRound.Name = "nxtRound"
        Me.nxtRound.Size = New System.Drawing.Size(75, 23)
        Me.nxtRound.TabIndex = 0
        Me.nxtRound.Text = "Next Round"
        Me.nxtRound.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(363, 117)
        Me.DataGridView1.TabIndex = 1
        '
        'btnSword
        '
        Me.btnSword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSword.Location = New System.Drawing.Point(381, 12)
        Me.btnSword.Name = "btnSword"
        Me.btnSword.Size = New System.Drawing.Size(75, 23)
        Me.btnSword.TabIndex = 2
        Me.btnSword.Text = "Swords"
        Me.btnSword.UseVisualStyleBackColor = True
        '
        'MarioJuanDatabase__1_DataSet
        '
        Me.MarioJuanDatabase__1_DataSet.DataSetName = "MarioJuanDatabase__1_DataSet"
        Me.MarioJuanDatabase__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarioJuanDatabase1DataSetBindingSource
        '
        Me.MarioJuanDatabase1DataSetBindingSource.DataSource = Me.MarioJuanDatabase__1_DataSet
        Me.MarioJuanDatabase1DataSetBindingSource.Position = 0
        '
        'btnBow
        '
        Me.btnBow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBow.Location = New System.Drawing.Point(381, 41)
        Me.btnBow.Name = "btnBow"
        Me.btnBow.Size = New System.Drawing.Size(75, 23)
        Me.btnBow.TabIndex = 3
        Me.btnBow.Text = "Bows"
        Me.btnBow.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.White
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.Location = New System.Drawing.Point(381, 99)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 4
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'btnArmor
        '
        Me.btnArmor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArmor.Location = New System.Drawing.Point(381, 70)
        Me.btnArmor.Name = "btnArmor"
        Me.btnArmor.Size = New System.Drawing.Size(75, 23)
        Me.btnArmor.TabIndex = 5
        Me.btnArmor.Text = "Armor"
        Me.btnArmor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Money:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(517, 12)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(0, 13)
        Me.lblMoney.TabIndex = 7
        '
        'shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 173)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnArmor)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnBow)
        Me.Controls.Add(Me.btnSword)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.nxtRound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "shop"
        Me.Text = "shop"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarioJuanDatabase__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarioJuanDatabase1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nxtRound As Button
    Friend WithEvents MarioJuanDatabase__1_DataSet As MarioJuanDatabase__1_DataSet
    Friend WithEvents MarioJuanDatabase1DataSetBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSword As Button
    Friend WithEvents btnBow As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents btnArmor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMoney As Label
End Class
