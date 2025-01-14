Imports System.IO

Public Class character
    Private health As Integer
    Private block As Integer
    Private money As Integer
    Private damage As Integer
    Private damageR As Integer
    Public Sub New(ByVal h As Integer, ByVal b As Integer, ByVal m As Integer, ByVal d As Integer, ByVal r As Integer)
        health = h
        block = b
        money = m
        damage = d
        damageR = r
    End Sub

    Public Property gameHealth As Integer
        Get
            Return health
        End Get
        Set(value As Integer)
            health = value
        End Set
    End Property

    Public Property gameBlock As Integer
        Get
            Return block
        End Get
        Set(value As Integer)
            block = value
        End Set

    End Property

    Public Property gameMoney As Integer
        Get
            Return money
        End Get
        Set(value As Integer)
            money = value
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

    Public Property gameDamageR As Integer
        Get
            Return damageR
        End Get
        Set(value As Integer)
            damageR = value
        End Set
    End Property

    Public Sub healthLost(ByVal enemyDamage As Integer)
        If (health <= 0) Then
            Form1.Hide()
            Form1.gameTimer.Stop()
            MessageBox.Show("Game Over!")

        Else
            enemyDamage = enemyDamage - block
            If enemyDamage <= 0 Then
                enemyDamage = 1
            End If
            health -= enemyDamage
        End If


    End Sub
End Class
