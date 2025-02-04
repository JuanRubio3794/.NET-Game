Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu

Public Class Form1




    'Movement'
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            moveRight = True
            moveDown = False
            moveUp = False
            moveLeft = False
        ElseIf e.KeyCode = Keys.Left Then
            moveRight = False
            moveDown = False
            moveUp = False
            moveLeft = True

        ElseIf e.KeyCode = Keys.Up Then

            moveRight = False
            moveDown = False
            moveUp = True
            moveLeft = False


        ElseIf e.KeyCode = Keys.Down Then

            moveRight = False
            moveDown = True
            moveUp = False
            moveLeft = False


        End If

        If e.KeyCode = Keys.Z Then

            attack = True

            If moveDown = True Or moveLeft = True Or moveRight = True Or moveUp = True Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterattack" & playerDirection & ".png")

            End If

            weaponTimer.Start()
        End If
        If e.KeyCode = Keys.Space Then
            If currentArrow.Visible = True Then

            Else
                ranged = True
                currentArrow.Visible = True
                weaponTimer.Start()
                arrowTimer.Start()
            End If

        End If
    End Sub


    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Then
            playerDirection = ""
            moveLeft = False
            animationTimer.Stop()
            imageCounter = 0
            character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterleft.png")
        End If

        If e.KeyCode = Keys.Right Then
            playerDirection = ""
            moveRight = False
            animationTimer.Stop()
            imageCounter = 0
            character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterright.png")

        End If

        If e.KeyCode = Keys.Up Then
            playerDirection = ""
            moveUp = False
            animationTimer.Stop()
            imageCounter = 0
            character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterup.png")

        End If

        If e.KeyCode = Keys.Down Then
            playerDirection = ""
            moveDown = False
            animationTimer.Stop()
            imageCounter = 0
            character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterdown.png")

        End If

    End Sub




    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick

        If moveLeft = True Then
            playerDirection = "left"

            swordLR.Top = character.Top + swordLR.Height
            swordLR.Left = character.Left - swordLR.Width

            bowLR.Top = character.Top
            bowLR.Left = character.Left - bowLR.Width



            currentSword = swordLR
            currentBow = bowLR


            currentSword.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & sword & playerDirection & ".png")
            currentBow.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & bow & playerDirection & ".png")
            If currentArrow.Visible = True Then


            Else
                arrowL.Top = bowLR.Top + 8
                arrowL.Left = bowLR.Left - bowLR.Width
                currentArrow = arrowL
            End If

        ElseIf moveRight = True Then
            playerDirection = "right"
            swordLR.Top = character.Top + 10
            swordLR.Left = character.Left + character.Width

            bowLR.Top = character.Top
            bowLR.Left = character.Left + character.Width

            currentSword = swordLR
            currentBow = bowLR
            currentSword.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & sword & playerDirection & ".png")
            currentBow.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & bow & playerDirection & ".png")
            If currentArrow.Visible = True Then


            Else
                arrowR.Top = bowLR.Top + 8
                arrowR.Left = bowLR.Left + bowLR.Width
                currentArrow = arrowR
            End If
        ElseIf moveDown = True Then
            playerDirection = "down"
            swordUPDOWN.Top = character.Top + character.Height
            swordUPDOWN.Left = character.Left + 10

            bowUPDOWN.Top = character.Top + character.Height
            bowUPDOWN.Left = character.Left

            currentSword = swordUPDOWN
            currentBow = bowUPDOWN

            currentSword.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & sword & playerDirection & ".png")
            currentBow.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & bow & playerDirection & ".png")

            If currentArrow.Visible = True Then


            Else
                arrowDown.Top = bowUPDOWN.Top + bowUPDOWN.Height
                arrowDown.Left = bowUPDOWN.Left + 8
                currentArrow = arrowDown
            End If
        ElseIf moveUp = True Then
            playerDirection = "up"
            swordUPDOWN.Top = character.Top - swordUPDOWN.Height
            swordUPDOWN.Left = character.Left + 10

            bowUPDOWN.Top = character.Top - bowUPDOWN.Height
            bowUPDOWN.Left = character.Left

            currentSword = swordUPDOWN
            currentBow = bowUPDOWN

            currentSword.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & sword & playerDirection & ".png")
            currentBow.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\" & bow & playerDirection & ".png")

            If currentArrow.Visible = True Then


            Else
                arrowUP.Top = bowUPDOWN.Top - bowUPDOWN.Height
                arrowUP.Left = bowUPDOWN.Left + 8
                currentArrow = arrowUP
            End If
        End If
        'attack'
        If attack = True Then


            currentSword.Visible = True


            moveDown = False
            moveUp = False
            moveRight = False
            moveLeft = False

        End If

        If ranged = True Then


            currentBow.Visible = True


            moveDown = False
            moveUp = False
            moveRight = False
            moveLeft = False

        End If

        'movement
        Dim position As Point = character.Location

        If moveLeft = True Then

            If character.Bounds.IntersectsWith(wall4.Bounds) Then
                moveLeft = False
            Else
                position.X -= 4
                character.Location = position
                animationTimer.Start()

            End If
        End If

        If moveRight = True Then

            If character.Bounds.IntersectsWith(wall2.Bounds) Then
                moveRight = False
            Else
                position.X += 4
                character.Location = position
                animationTimer.Start()

            End If
        End If

        If moveUp = True Then

            If character.Bounds.IntersectsWith(wall1.Bounds) Then
                moveUp = False
            Else
                position.Y -= 4
                character.Location = position

                animationTimer.Start()
            End If

        End If

        If moveDown = True Then

            If character.Bounds.IntersectsWith(wall3.Bounds) Then
                moveDown = False
            Else
                position.Y += 4
                character.Location = position
                animationTimer.Start()

            End If

        End If

        'collision with platforms and objects

        For Each p As Control In Controls
            If TypeOf p Is PictureBox Then
                If p.Tag = "obstacle" And p.Visible = True Then
                    If character.Bounds.IntersectsWith(p.Bounds) And moveRight = True Then

                        position.X -= 4
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If character.Bounds.IntersectsWith(p.Bounds) And moveLeft = True Then

                        position.X += 4
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If character.Bounds.IntersectsWith(p.Bounds) And moveUp = True Then

                        position.Y += 4
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If character.Bounds.IntersectsWith(p.Bounds) And moveDown = True Then

                        position.Y -= 4
                        character.Location = position
                        animationTimer.Start()
                    End If


                End If
            End If
        Next

        'Enemy behavior'
        For Each p As enemy In enemyArray1
            'hits player'
            If character.Bounds.IntersectsWith(p.gameBox.Bounds) And p.gameBox.Visible = True Then

                attack = False
                ranged = False
                playerCharacter.healthLost(p.gamedamage)
                lblHealth.Text = playerCharacter.gamehealth.ToString


                playerDamage()
                'check enemy movement direction and knock back player accordingly'

                If moveDown = False And moveUp = False And moveLeft = False And moveRight = False  Then

                    If p.gameDirection = "up" Then
                        position.Y -= 80
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If p.gameDirection = "down" Then
                        position.Y += 80
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If p.gameDirection = "left" Then
                        position.X -= 80
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If p.gameDirection = "right" Then
                        position.X += 80
                        character.Location = position
                        animationTimer.Start()
                    End If
                Else
                    If moveUp = True Then
                        position.Y += 80
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If moveDown = True Then
                        position.Y -= 80
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If moveLeft = True Then
                        position.X += 80
                        character.Location = position
                        animationTimer.Start()
                    End If

                    If moveRight = True Then
                        position.X -= 80
                        character.Location = position
                        animationTimer.Start()
                    End If
                End If
            End If


            'enemy movement'
            If p.gameBox.Visible = True Then
                Dim enemyposition As Point = p.gameBox.Location

                If p.gameBox.Tag = "enemy" Then
                    If p.gameDirection = "right" Then
                        enemyposition.X += 4
                        p.gameBox.Location = enemyposition
                    End If


                    If p.gameDirection = "left" Then
                        enemyposition.X -= 4
                        p.gameBox.Location = enemyposition
                    End If

                    If p.gameDirection = "down" Then
                        enemyposition.Y += 4
                        p.gameBox.Location = enemyposition
                    End If

                    If p.gameDirection = "up" Then
                        enemyposition.Y -= 4
                        p.gameBox.Location = enemyposition
                    End If

                    If p.gameDirection = "still" Then

                        p.gameBox.Location = enemyposition
                    End If
                ElseIf p.gameBox.Tag = "boss" Then

                    If p.gameDirection = "right" Then
                        enemyposition.X += 6
                        p.gameBox.Location = enemyposition
                    End If


                    If p.gameDirection = "left" Then
                        enemyposition.X -= 6
                        p.gameBox.Location = enemyposition
                    End If

                    If p.gameDirection = "down" Then
                        enemyposition.Y += 6
                        p.gameBox.Location = enemyposition
                    End If

                    If p.gameDirection = "up" Then
                        enemyposition.Y -= 6
                        p.gameBox.Location = enemyposition
                    End If

                    If p.gameDirection = "still" Then

                        p.gameBox.Location = enemyposition
                    End If
                End If





            End If

            If (p.gameBox.Bounds.IntersectsWith(swordLR.Bounds) And swordLR.Visible = True) Or (p.gameBox.Bounds.IntersectsWith(swordUPDOWN.Bounds) And swordUPDOWN.Visible = True) Then



                enemyHit()
                p.enemyHealthLost(playerCharacter.gameDamage)
                If p.gameBox.Tag = "boss" Then
                    Dim enemyposition As Point = p.gameBox.Location
                    If p.gameDirection = "left" Then
                        enemyposition.X += 30
                        p.gameBox.Location = enemyposition
                    ElseIf p.gameDirection = "right" Then
                        enemyposition.X -= 30
                        p.gameBox.Location = enemyposition
                    ElseIf p.gameDirection = "up" Then
                        enemyposition.Y += 30
                        p.gameBox.Location = enemyposition
                    ElseIf p.gameDirection = "down" Then
                        enemyposition.Y -= 30
                        p.gameBox.Location = enemyposition
                    End If
                Else
                    Dim enemyposition As Point = p.gameBox.Location
                    If p.gameDirection = "left" Then
                        enemyposition.X += 80
                        p.gameBox.Location = enemyposition
                    ElseIf p.gameDirection = "right" Then
                        enemyposition.X -= 80
                        p.gameBox.Location = enemyposition
                    ElseIf p.gameDirection = "up" Then
                        enemyposition.Y += 80
                        p.gameBox.Location = enemyposition
                    ElseIf p.gameDirection = "down" Then
                        enemyposition.Y -= 80
                        p.gameBox.Location = enemyposition
                    End If
                End If


            End If

            If (p.gameBox.Bounds.IntersectsWith(currentArrow.Bounds) And currentArrow.Visible = True And p.gameBox.Visible = True) Then
                currentArrow.Visible = False
                p.enemyHealthLost(playerCharacter.gameDamageR)

                Dim enemyposition As Point = p.gameBox.Location
                If p.gameDirection = "left" Then
                    enemyposition.X += 60
                    p.gameBox.Location = enemyposition
                ElseIf p.gameDirection = "right" Then
                    enemyposition.X -= 60
                    p.gameBox.Location = enemyposition
                ElseIf p.gameDirection = "up" Then
                    enemyposition.Y += 60
                    p.gameBox.Location = enemyposition
                ElseIf p.gameDirection = "down" Then
                    enemyposition.Y -= 60
                    p.gameBox.Location = enemyposition
                End If
            End If
            'enemy wall collision'
            For Each o As Control In Controls
                If o.Tag = "wall" Or o.Tag = "obstacle" Then

                    If currentArrow.Bounds.IntersectsWith(o.Bounds) Then
                        currentArrow.Visible = False

                    End If
                    If p.gameBox.Bounds.IntersectsWith(o.Bounds) Then


                        If p.gameDirection = "right" Then
                            p.gameDirection = "left"
                        ElseIf p.gameDirection = "left" Then
                            p.gameDirection = "right"
                        ElseIf p.gameDirection = "down" Then
                            p.gameDirection = "up"
                        ElseIf p.gameDirection = "up" Then
                            p.gameDirection = "down"
                        End If

                    End If


                End If

            Next
        Next

        'arrow'
        If currentArrow.Visible = True Then

            Dim arrowposition As Point = currentArrow.Location
            If currentArrow Is arrowR Then
                arrowposition.X += 10
                currentArrow.Location = arrowposition
            End If


            If currentArrow Is arrowL Then
                arrowposition.X -= 10
                currentArrow.Location = arrowposition
            End If

            If currentArrow Is arrowDown Then
                arrowposition.Y += 10
                currentArrow.Location = arrowposition
            End If

            If currentArrow Is arrowUP Then
                arrowposition.Y -= 10
                currentArrow.Location = arrowposition
            End If
        End If


        'Round Over'
        If enemiesRemaining = 0 Then
            roundEnd()

            enemyImagecounter = 0
        End If

        'shop'

        If character.Bounds.IntersectsWith(shopBox.Bounds) And shopBox.Visible = True Then
            shopSub()
        End If
    End Sub



    Private Sub enemySpawnTimer_Tick(sender As Object, e As EventArgs) Handles enemySpawnTimer.Tick

        If count <= enemyArray1.Count - 1 Then
            enemyArray1(count).gameBox.Visible = True


            count += 1


        End If

    End Sub

    Private Sub enemyMoveTimer_Tick(sender As Object, e As EventArgs) Handles enemyMoveTimer.Tick


        For Each p As enemy In enemyArray1

            MyInt = Int((4 * Rnd()) + 1)

            If MyInt = 1 Then
                p.gameDirection = "up"
            ElseIf MyInt = 2 Then
                p.gameDirection = "down"
            ElseIf MyInt = 3 Then
                p.gameDirection = "left"
            ElseIf MyInt = 4 Then
                p.gameDirection = "right"
            End If


        Next


    End Sub

    Private Sub weaponTimer_Tick(sender As Object, e As EventArgs) Handles weaponTimer.Tick
        attack = False
        ranged = False
        swordLR.Visible = False
        swordUPDOWN.Visible = False
        bowLR.Visible = False
        bowUPDOWN.Visible = False
        If playerDirection = "left" Then
            moveLeft = True
        ElseIf playerDirection = "right" Then
            moveRight = True
        ElseIf playerDirection = "down" Then
            moveDown = True
        ElseIf playerDirection = "up" Then
            moveUp = True
        End If

        weaponTimer.Stop()
    End Sub

    Private Sub playerDamage()
        attack = False
        swordLR.Visible = False
        swordUPDOWN.Visible = False
        weaponTimer.Stop()
    End Sub

    Private Sub roundEnd()

        enemyImagecounter = 0
        shopBox.Visible = True


        If currentRound = 5 Then
            gameTimer.Stop()
            MessageBox.Show("You Win!")
            Me.Close()
        End If
    End Sub

    Private Sub shopSub()
        gameTimer.Stop()
        Dim shopmenu As New shop
        shopmenu.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        nextLevel()


        lblHealth.Text = playerCharacter.gamehealth.ToString
        lblMoney.Text = playerCharacter.gameMoney.ToString

        currentSword = swordUPDOWN
        currentBow = bowUPDOWN
        currentArrow = arrowUP
    End Sub

    Private Sub enemyHit()
        attack = False
        ranged = False
        swordLR.Visible = False
        swordUPDOWN.Visible = False
        bowLR.Visible = False
        bowUPDOWN.Visible = False
        If playerDirection = "left" Then
            moveLeft = True
        ElseIf playerDirection = "right" Then
            moveRight = True
        ElseIf playerDirection = "down" Then
            moveDown = True
        ElseIf playerDirection = "up" Then
            moveUp = True
        End If
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If moveUp = True Then
            If imageCounter = 0 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterup2.png")
                imageCounter = 1
            ElseIf imageCounter = 1 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterup3.png")
                imageCounter = 0
            End If
        ElseIf moveDown = True Then
            If imageCounter = 0 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterdown2.png")
                imageCounter = 1
            ElseIf imageCounter = 1 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterdown3.png")
                imageCounter = 0
            End If
        ElseIf moveRight = True Then
            If imageCounter = 0 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterright1.png")
                imageCounter = 1
            ElseIf imageCounter = 1 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterright.png")
                imageCounter = 0
            End If
        ElseIf moveleft = True Then
            If imageCounter = 0 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterleft1.png")
                imageCounter = 1
            ElseIf imageCounter = 1 Then
                character.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\characterleft.png")
                imageCounter = 0
            End If
        End If
    End Sub

    Private Sub enemyTimer_Tick(sender As Object, e As EventArgs) Handles enemyTimer.Tick



        If enemyAnimationCounter = 0 Then
            'weak enemies'
            wave1enemy1.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown.png")
            wave1enemy2.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown.png")
            wave1enemy3.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown.png")
            wave2enemy1.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown.png")
            wave2enemy2.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown.png")
            wave2enemy3.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown.png")

            'medium'
            wave2enemy4.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\medium.png")
            wave2enemy5.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\medium.png")
            wave3enemy1.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\medium.png")

            'strong'
            wave3enemy2.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\strong1.png")
            wave3enemy3.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\strong1.png")
            wave3enemy4.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\strong1.png")

            boss.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\boss1.png")
            enemyAnimationCounter += 1
        ElseIf enemyAnimationcounter = 1 Then
            'weak enemies'
            wave1enemy1.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown1.png")
            wave1enemy2.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown1.png")
            wave1enemy3.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown1.png")
            wave2enemy1.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown1.png")
            wave2enemy2.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown1.png")
            wave2enemy3.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\weakdown1.png")

            'medium'
            wave2enemy4.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\medium1.png")
            wave2enemy5.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\medium1.png")
            wave3enemy1.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\medium1.png")

            'strong'
            wave3enemy2.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\strong2.png")
            wave3enemy3.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\strong2.png")
            wave3enemy4.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\strong2.png")

            'boss'
            boss.BackgroundImage = Image.FromFile("C:\Users\juanr\source\repos\Project 4 Juan and Mario\images\boss2.png")
            enemyAnimationCounter = 0
        End If
    End Sub
End Class
