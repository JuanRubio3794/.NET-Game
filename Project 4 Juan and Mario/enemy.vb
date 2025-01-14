Public Class enemy
    Private health As Integer
    Private damage As Integer
    Private money As Integer
    Private box As PictureBox
    Private direction As String
    Public Sub New(ByVal h As Integer, ByVal d As Integer, ByVal b As PictureBox, ByVal di As String, ByVal m As Integer)
        health = h
        damage = d
        box = b
        direction = di
        money = m
    End Sub

    Public Property gameHealth As Integer
        Get
            Return health
        End Get
        Set(value As Integer)
            health = value
        End Set
    End Property

    Public Property gamedamage As Integer
        Get
            Return damage
        End Get
        Set(value As Integer)
            damage = value
        End Set

    End Property

    Public Property gameBox As PictureBox
        Get
            Return box
        End Get
        Set(value As PictureBox)
            box = value
        End Set
    End Property

    Public Property gameDirection As String
        Get
            Return direction
        End Get
        Set(value As String)
            direction = value
        End Set

    End Property

    Public Property gamemoney As Integer
        Get
            Return money
        End Get
        Set(value As Integer)
            money = value
        End Set

    End Property

    Public Sub enemyHealthLost(ByVal damage As Integer)
        health -= damage
        If (health <= 0) Then
            gameBox.Visible = False
            enemiesRemaining -= 1
            playerCharacter.gamemoney += money
            Form1.lblMoney.Text = playerCharacter.gamemoney.ToString

        End If


    End Sub
End Class
