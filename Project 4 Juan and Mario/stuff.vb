Module Shared_functions

    Public playerCharacter = New character(100, 0, 0, 2, 1)

    Public moveLeft As Boolean = False
    Public moveRight As Boolean = False
    Public moveUp As Boolean = False
    Public moveDown As Boolean = False
    Public count As Integer = 0
    Public directionNumber As Integer
    Public imageCounter As Integer = 0
    Public MyInt As Integer
    Public attack As Boolean = False
    Public ranged As Boolean = False
    Public playerDirection As String
    Public currentSword As PictureBox
    Public currentBow As PictureBox
    Public currentArrow As PictureBox
    Public enemyImagecounter = 0
    Public enemyAnimationCounter = 0
    Public currentRound As Integer = 0
    Public enemyArray1 As New List(Of enemy)
    Public sword As String = "base sword"
    Public bow As String = "basebow"
    Public enemiesRemaining As Integer


    Public Sub nextLevel()
        Form1.shopBox.Visible = False
        currentRound += 1
        enemyArray1.Clear()
        If currentRound = 1 Then
            enemyArray1.Add(New enemy(2, 5, Form1.wave1enemy1, "right", 7))
            enemyArray1.Add(New enemy(2, 5, Form1.wave1enemy2, "up", 7))
            enemyArray1.Add(New enemy(2, 5, Form1.wave1enemy3, "left", 7))
            count = 0
            enemiesRemaining = 3
            Form1.gameTimer.Start()
        ElseIf currentRound = 2 Then
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy1, "right", 7))
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy2, "left", 7))
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy3, "right", 7))
            enemyArray1.Add(New enemy(10, 15, Form1.wave2enemy4, "up", 10))
            enemyArray1.Add(New enemy(10, 15, Form1.wave2enemy5, "down", 10))
            enemiesRemaining = 5
            count = 0
            Form1.gameTimer.Start()
        ElseIf currentRound = 3 Then
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy1, "right", 7))
            enemyArray1.Add(New enemy(10, 15, Form1.wave2enemy4, "up", 10))
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy3, "right", 7))
            enemyArray1.Add(New enemy(10, 15, Form1.wave3enemy1, "up", 10))
            enemyArray1.Add(New enemy(10, 15, Form1.wave2enemy5, "down", 10))
            enemyArray1.Add(New enemy(40, 25, Form1.wave3enemy2, "up", 20))
            enemiesRemaining = 6
            count = 0
            Form1.gameTimer.Start()
        ElseIf currentRound = 4 Then
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy1, "right", 7))
            enemyArray1.Add(New enemy(10, 15, Form1.wave2enemy4, "up", 10))
            enemyArray1.Add(New enemy(2, 5, Form1.wave2enemy3, "right", 7))
            enemyArray1.Add(New enemy(10, 15, Form1.wave3enemy1, "up", 10))
            enemyArray1.Add(New enemy(40, 25, Form1.wave3enemy3, "right", 20))
            enemyArray1.Add(New enemy(40, 25, Form1.wave3enemy2, "up", 20))
            enemyArray1.Add(New enemy(2, 5, Form1.wave1enemy1, "right", 7))
            enemyArray1.Add(New enemy(2, 5, Form1.wave1enemy2, "right", 7))
            enemyArray1.Add(New enemy(10, 15, Form1.wave2enemy5, "down", 10))
            enemyArray1.Add(New enemy(40, 25, Form1.wave3enemy4, "left", 20))
            enemiesRemaining = 10
            count = 0
            Form1.gameTimer.Start()
        ElseIf currentRound = 5 Then
            enemyArray1.Add(New enemy(100, 30, Form1.boss, "left", 50))
            enemiesRemaining = 1
            count = 0
            Form1.gameTimer.Start()
        End If

    End Sub
End Module
