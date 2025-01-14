Imports System.Data.Common
Imports System.Data.OleDb

Public Class shop
    Dim index As Integer
    Dim selectedRow As DataGridViewRow
    Dim rowSelected As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nxtRound.Click

        Me.Hide()
        nextLevel()

    End Sub

    Private Sub btnSword_Click(sender As Object, e As EventArgs) Handles btnSword.Click
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=MarioJuanDatabase (1).mdb"
        sqlStatement = "SELECT ItemName as Item, ItemDescription as Description, ItemCost as Cost, ItemQuantity as Quantity
                        FROM  [Item Shop]
                        WHERE ItemID < 1004"

        Dim dtProperties As New DataTable
        Dim dbDataAdapter As OleDbDataAdapter
        dbDataAdapter = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdapter.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties
        rowSelected = False
    End Sub

    Private Sub btnBow_Click(sender As Object, e As EventArgs) Handles btnBow.Click
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=MarioJuanDatabase (1).mdb"
        sqlStatement = "SELECT ItemName as Item, ItemDescription as Description, ItemCost as Cost, ItemQuantity as Quantity
                        FROM  [Item Shop]
                        WHERE ItemID < 1007 AND ItemID >1003"

        Dim dtProperties As New DataTable
        Dim dbDataAdapter As OleDbDataAdapter
        dbDataAdapter = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdapter.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties


        rowSelected = False
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click

        If rowSelected = True Then

            If playerCharacter.gamemoney >= selectedRow.Cells(2).Value Then


                upgrade()
            ElseIf selectedRow.Cells(3).Value = 0 Then
                MessageBox.Show("Already Purchased!")
            ElseIf playerCharacter.gamemoney < selectedRow.Cells(2).Value Then
                MessageBox.Show("Not Enough Money!")
            End If

        Else
            MessageBox.Show("Select an Item")
        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick



        index = e.RowIndex
        selectedRow = DataGridView1.Rows(index)
        rowSelected = True
    End Sub

    Private Sub btnArmor_Click(sender As Object, e As EventArgs) Handles btnArmor.Click
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=MarioJuanDatabase (1).mdb"
        sqlStatement = "SELECT ItemName as Item, ItemDescription as Description, ItemCost as Cost, ItemQuantity as Quantity
                        FROM  [Item Shop]
                        WHERE ItemID < 1010 AND ItemID >1006"

        Dim dtProperties As New DataTable
        Dim dbDataAdapter As OleDbDataAdapter
        dbDataAdapter = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdapter.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties


        rowSelected = False
    End Sub

    Private Sub shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMoney.Text = playerCharacter.gamemoney.ToString
    End Sub

    Private Sub upgrade()
        If selectedRow.Cells(0).Value = "Bone Sword" Then
            playerCharacter.gamedamage = 4
            sword = "bonesword"

            selectedRow.Cells(3).Value -= 1
            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Silver Sword" Then
            playerCharacter.gamedamage = 7
            selectedRow.Cells(3).Value -= 1
            sword = "silversword"


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Gold Sword" Then
            playerCharacter.gamedamage = 10
            selectedRow.Cells(3).Value -= 1
            sword = "goldsword"


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Bronze Bow" Then
            playerCharacter.gamedamageR = 2
            selectedRow.Cells(3).Value -= 1
            bow = "bronzebow"


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Silver Bow" Then
            playerCharacter.gamedamageR = 4
            selectedRow.Cells(3).Value -= 1
            bow = "silverbow"


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Golden Bow" Then
            playerCharacter.gamedamageR = 7
            selectedRow.Cells(3).Value -= 1
            bow = "goldenbow"


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Wooden Armour" Then
            playerCharacter.gameBlock = 2
            selectedRow.Cells(3).Value -= 1


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Silver Armour" Then
            playerCharacter.gameBlock = 4
            selectedRow.Cells(3).Value -= 1


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        ElseIf selectedRow.Cells(0).Value = "Golden Armour" Then
            playerCharacter.gameBlock = 6
            selectedRow.Cells(3).Value -= 1


            playerCharacter.gamemoney = playerCharacter.gamemoney - selectedRow.Cells(2).Value
            lblMoney.Text = playerCharacter.gamemoney.ToString

        End If
    End Sub
End Class