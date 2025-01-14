<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.character = New System.Windows.Forms.PictureBox()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.wall1 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.wall4 = New System.Windows.Forms.PictureBox()
        Me.wave1enemy1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.wave1enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemySpawnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.enemyMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.swordLR = New System.Windows.Forms.PictureBox()
        Me.weaponTimer = New System.Windows.Forms.Timer(Me.components)
        Me.swordUPDOWN = New System.Windows.Forms.PictureBox()
        Me.shopBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.wave1enemy3 = New System.Windows.Forms.PictureBox()
        Me.wave2enemy1 = New System.Windows.Forms.PictureBox()
        Me.wave2enemy2 = New System.Windows.Forms.PictureBox()
        Me.wave2enemy3 = New System.Windows.Forms.PictureBox()
        Me.wave2enemy4 = New System.Windows.Forms.PictureBox()
        Me.wave2enemy5 = New System.Windows.Forms.PictureBox()
        Me.bowUPDOWN = New System.Windows.Forms.PictureBox()
        Me.bowLR = New System.Windows.Forms.PictureBox()
        Me.arrowL = New System.Windows.Forms.PictureBox()
        Me.arrowUP = New System.Windows.Forms.PictureBox()
        Me.arrowTimer = New System.Windows.Forms.Timer(Me.components)
        Me.arrowDown = New System.Windows.Forms.PictureBox()
        Me.arrowR = New System.Windows.Forms.PictureBox()
        Me.wave3enemy1 = New System.Windows.Forms.PictureBox()
        Me.wave3enemy2 = New System.Windows.Forms.PictureBox()
        Me.wave3enemy3 = New System.Windows.Forms.PictureBox()
        Me.wave3enemy4 = New System.Windows.Forms.PictureBox()
        Me.boss = New System.Windows.Forms.PictureBox()
        Me.enemyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave1enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave1enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swordLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swordUPDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shopBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave1enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave2enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave2enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave2enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave2enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave2enemy5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bowUPDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bowLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrowL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrowUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrowDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrowR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave3enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave3enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave3enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wave3enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'character
        '
        Me.character.BackColor = System.Drawing.Color.Transparent
        Me.character.BackgroundImage = CType(resources.GetObject("character.BackgroundImage"), System.Drawing.Image)
        Me.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.character.Location = New System.Drawing.Point(329, 439)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(36, 50)
        Me.character.TabIndex = 0
        Me.character.TabStop = False
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 1
        '
        'animationTimer
        '
        '
        'wall1
        '
        Me.wall1.BackColor = System.Drawing.Color.Black
        Me.wall1.Location = New System.Drawing.Point(-3, -8)
        Me.wall1.Name = "wall1"
        Me.wall1.Size = New System.Drawing.Size(1235, 19)
        Me.wall1.TabIndex = 1
        Me.wall1.TabStop = False
        Me.wall1.Tag = "wall"
        '
        'wall2
        '
        Me.wall2.BackColor = System.Drawing.Color.Black
        Me.wall2.Location = New System.Drawing.Point(1222, -8)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(10, 901)
        Me.wall2.TabIndex = 2
        Me.wall2.TabStop = False
        Me.wall2.Tag = "wall"
        '
        'wall3
        '
        Me.wall3.BackColor = System.Drawing.Color.Black
        Me.wall3.Location = New System.Drawing.Point(-3, 874)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(1235, 19)
        Me.wall3.TabIndex = 3
        Me.wall3.TabStop = False
        Me.wall3.Tag = "wall"
        '
        'wall4
        '
        Me.wall4.BackColor = System.Drawing.Color.Black
        Me.wall4.Location = New System.Drawing.Point(-3, -8)
        Me.wall4.Name = "wall4"
        Me.wall4.Size = New System.Drawing.Size(11, 883)
        Me.wall4.TabIndex = 4
        Me.wall4.TabStop = False
        Me.wall4.Tag = "wall"
        '
        'wave1enemy1
        '
        Me.wave1enemy1.BackColor = System.Drawing.Color.Transparent
        Me.wave1enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave1enemy1.Location = New System.Drawing.Point(937, 389)
        Me.wave1enemy1.Name = "wave1enemy1"
        Me.wave1enemy1.Size = New System.Drawing.Size(50, 50)
        Me.wave1enemy1.TabIndex = 7
        Me.wave1enemy1.TabStop = False
        Me.wave1enemy1.Tag = "enemy"
        Me.wave1enemy1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(982, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Health:"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.Location = New System.Drawing.Point(1038, 24)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(0, 16)
        Me.lblHealth.TabIndex = 9
        '
        'wave1enemy2
        '
        Me.wave1enemy2.BackColor = System.Drawing.Color.Transparent
        Me.wave1enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave1enemy2.Location = New System.Drawing.Point(137, 693)
        Me.wave1enemy2.Name = "wave1enemy2"
        Me.wave1enemy2.Size = New System.Drawing.Size(48, 50)
        Me.wave1enemy2.TabIndex = 10
        Me.wave1enemy2.TabStop = False
        Me.wave1enemy2.Tag = "enemy"
        Me.wave1enemy2.Visible = False
        '
        'enemySpawnTimer
        '
        Me.enemySpawnTimer.Enabled = True
        Me.enemySpawnTimer.Interval = 1800
        '
        'enemyMoveTimer
        '
        Me.enemyMoveTimer.Enabled = True
        Me.enemyMoveTimer.Interval = 500
        '
        'swordLR
        '
        Me.swordLR.BackColor = System.Drawing.Color.Transparent
        Me.swordLR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swordLR.Location = New System.Drawing.Point(610, 237)
        Me.swordLR.Name = "swordLR"
        Me.swordLR.Size = New System.Drawing.Size(35, 22)
        Me.swordLR.TabIndex = 12
        Me.swordLR.TabStop = False
        Me.swordLR.Visible = False
        '
        'weaponTimer
        '
        Me.weaponTimer.Interval = 400
        '
        'swordUPDOWN
        '
        Me.swordUPDOWN.BackColor = System.Drawing.Color.Transparent
        Me.swordUPDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swordUPDOWN.Location = New System.Drawing.Point(329, 389)
        Me.swordUPDOWN.Name = "swordUPDOWN"
        Me.swordUPDOWN.Size = New System.Drawing.Size(22, 35)
        Me.swordUPDOWN.TabIndex = 13
        Me.swordUPDOWN.TabStop = False
        Me.swordUPDOWN.Visible = False
        '
        'shopBox
        '
        Me.shopBox.BackColor = System.Drawing.Color.Transparent
        Me.shopBox.BackgroundImage = CType(resources.GetObject("shopBox.BackgroundImage"), System.Drawing.Image)
        Me.shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shopBox.Location = New System.Drawing.Point(12, 12)
        Me.shopBox.Name = "shopBox"
        Me.shopBox.Size = New System.Drawing.Size(145, 112)
        Me.shopBox.TabIndex = 14
        Me.shopBox.TabStop = False
        Me.shopBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(981, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Money:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(1038, 37)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(0, 16)
        Me.lblMoney.TabIndex = 16
        '
        'wave1enemy3
        '
        Me.wave1enemy3.BackColor = System.Drawing.Color.Transparent
        Me.wave1enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave1enemy3.Location = New System.Drawing.Point(599, 71)
        Me.wave1enemy3.Name = "wave1enemy3"
        Me.wave1enemy3.Size = New System.Drawing.Size(46, 53)
        Me.wave1enemy3.TabIndex = 11
        Me.wave1enemy3.TabStop = False
        Me.wave1enemy3.Tag = "enemy"
        Me.wave1enemy3.Visible = False
        '
        'wave2enemy1
        '
        Me.wave2enemy1.BackColor = System.Drawing.Color.Transparent
        Me.wave2enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave2enemy1.Location = New System.Drawing.Point(586, 418)
        Me.wave2enemy1.Name = "wave2enemy1"
        Me.wave2enemy1.Size = New System.Drawing.Size(47, 50)
        Me.wave2enemy1.TabIndex = 17
        Me.wave2enemy1.TabStop = False
        Me.wave2enemy1.Tag = "enemy"
        Me.wave2enemy1.Visible = False
        '
        'wave2enemy2
        '
        Me.wave2enemy2.BackColor = System.Drawing.Color.Transparent
        Me.wave2enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave2enemy2.Location = New System.Drawing.Point(1026, 90)
        Me.wave2enemy2.Name = "wave2enemy2"
        Me.wave2enemy2.Size = New System.Drawing.Size(48, 48)
        Me.wave2enemy2.TabIndex = 18
        Me.wave2enemy2.TabStop = False
        Me.wave2enemy2.Tag = "enemy"
        Me.wave2enemy2.Visible = False
        '
        'wave2enemy3
        '
        Me.wave2enemy3.BackColor = System.Drawing.Color.Transparent
        Me.wave2enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave2enemy3.Location = New System.Drawing.Point(389, 659)
        Me.wave2enemy3.Name = "wave2enemy3"
        Me.wave2enemy3.Size = New System.Drawing.Size(42, 47)
        Me.wave2enemy3.TabIndex = 19
        Me.wave2enemy3.TabStop = False
        Me.wave2enemy3.Tag = "enemy"
        Me.wave2enemy3.Visible = False
        '
        'wave2enemy4
        '
        Me.wave2enemy4.BackColor = System.Drawing.Color.Transparent
        Me.wave2enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave2enemy4.Location = New System.Drawing.Point(161, 352)
        Me.wave2enemy4.Name = "wave2enemy4"
        Me.wave2enemy4.Size = New System.Drawing.Size(96, 80)
        Me.wave2enemy4.TabIndex = 20
        Me.wave2enemy4.TabStop = False
        Me.wave2enemy4.Tag = "enemy"
        Me.wave2enemy4.Visible = False
        '
        'wave2enemy5
        '
        Me.wave2enemy5.BackColor = System.Drawing.Color.Transparent
        Me.wave2enemy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave2enemy5.Location = New System.Drawing.Point(1061, 299)
        Me.wave2enemy5.Name = "wave2enemy5"
        Me.wave2enemy5.Size = New System.Drawing.Size(94, 80)
        Me.wave2enemy5.TabIndex = 21
        Me.wave2enemy5.TabStop = False
        Me.wave2enemy5.Tag = "enemy"
        Me.wave2enemy5.Visible = False
        '
        'bowUPDOWN
        '
        Me.bowUPDOWN.BackColor = System.Drawing.Color.Transparent
        Me.bowUPDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bowUPDOWN.Location = New System.Drawing.Point(329, 406)
        Me.bowUPDOWN.Name = "bowUPDOWN"
        Me.bowUPDOWN.Size = New System.Drawing.Size(36, 18)
        Me.bowUPDOWN.TabIndex = 22
        Me.bowUPDOWN.TabStop = False
        Me.bowUPDOWN.Visible = False
        '
        'bowLR
        '
        Me.bowLR.BackColor = System.Drawing.Color.Transparent
        Me.bowLR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bowLR.Location = New System.Drawing.Point(437, 375)
        Me.bowLR.Name = "bowLR"
        Me.bowLR.Size = New System.Drawing.Size(19, 37)
        Me.bowLR.TabIndex = 23
        Me.bowLR.TabStop = False
        Me.bowLR.Visible = False
        '
        'arrowL
        '
        Me.arrowL.BackColor = System.Drawing.Color.Transparent
        Me.arrowL.BackgroundImage = CType(resources.GetObject("arrowL.BackgroundImage"), System.Drawing.Image)
        Me.arrowL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.arrowL.Location = New System.Drawing.Point(499, 332)
        Me.arrowL.Name = "arrowL"
        Me.arrowL.Size = New System.Drawing.Size(37, 19)
        Me.arrowL.TabIndex = 24
        Me.arrowL.TabStop = False
        Me.arrowL.Visible = False
        '
        'arrowUP
        '
        Me.arrowUP.BackColor = System.Drawing.Color.Transparent
        Me.arrowUP.BackgroundImage = CType(resources.GetObject("arrowUP.BackgroundImage"), System.Drawing.Image)
        Me.arrowUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.arrowUP.Location = New System.Drawing.Point(346, 375)
        Me.arrowUP.Name = "arrowUP"
        Me.arrowUP.Size = New System.Drawing.Size(19, 37)
        Me.arrowUP.TabIndex = 25
        Me.arrowUP.TabStop = False
        Me.arrowUP.Visible = False
        '
        'arrowTimer
        '
        Me.arrowTimer.Interval = 1
        '
        'arrowDown
        '
        Me.arrowDown.BackColor = System.Drawing.Color.Transparent
        Me.arrowDown.BackgroundImage = CType(resources.GetObject("arrowDown.BackgroundImage"), System.Drawing.Image)
        Me.arrowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.arrowDown.Location = New System.Drawing.Point(437, 431)
        Me.arrowDown.Name = "arrowDown"
        Me.arrowDown.Size = New System.Drawing.Size(19, 37)
        Me.arrowDown.TabIndex = 26
        Me.arrowDown.TabStop = False
        Me.arrowDown.Visible = False
        '
        'arrowR
        '
        Me.arrowR.BackColor = System.Drawing.Color.Transparent
        Me.arrowR.BackgroundImage = CType(resources.GetObject("arrowR.BackgroundImage"), System.Drawing.Image)
        Me.arrowR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.arrowR.Location = New System.Drawing.Point(623, 337)
        Me.arrowR.Name = "arrowR"
        Me.arrowR.Size = New System.Drawing.Size(37, 19)
        Me.arrowR.TabIndex = 27
        Me.arrowR.TabStop = False
        Me.arrowR.Visible = False
        '
        'wave3enemy1
        '
        Me.wave3enemy1.BackColor = System.Drawing.Color.Transparent
        Me.wave3enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave3enemy1.Location = New System.Drawing.Point(944, 675)
        Me.wave3enemy1.Name = "wave3enemy1"
        Me.wave3enemy1.Size = New System.Drawing.Size(94, 80)
        Me.wave3enemy1.TabIndex = 28
        Me.wave3enemy1.TabStop = False
        Me.wave3enemy1.Tag = "enemy"
        Me.wave3enemy1.Visible = False
        '
        'wave3enemy2
        '
        Me.wave3enemy2.BackColor = System.Drawing.Color.Transparent
        Me.wave3enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave3enemy2.Location = New System.Drawing.Point(631, 693)
        Me.wave3enemy2.Name = "wave3enemy2"
        Me.wave3enemy2.Size = New System.Drawing.Size(135, 122)
        Me.wave3enemy2.TabIndex = 29
        Me.wave3enemy2.TabStop = False
        Me.wave3enemy2.Tag = "enemy"
        Me.wave3enemy2.Visible = False
        '
        'wave3enemy3
        '
        Me.wave3enemy3.BackColor = System.Drawing.Color.Transparent
        Me.wave3enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave3enemy3.Location = New System.Drawing.Point(242, 37)
        Me.wave3enemy3.Name = "wave3enemy3"
        Me.wave3enemy3.Size = New System.Drawing.Size(135, 122)
        Me.wave3enemy3.TabIndex = 30
        Me.wave3enemy3.TabStop = False
        Me.wave3enemy3.Tag = "enemy"
        Me.wave3enemy3.Visible = False
        '
        'wave3enemy4
        '
        Me.wave3enemy4.BackColor = System.Drawing.Color.Transparent
        Me.wave3enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wave3enemy4.Location = New System.Drawing.Point(137, 537)
        Me.wave3enemy4.Name = "wave3enemy4"
        Me.wave3enemy4.Size = New System.Drawing.Size(135, 122)
        Me.wave3enemy4.TabIndex = 31
        Me.wave3enemy4.TabStop = False
        Me.wave3enemy4.Tag = "enemy"
        Me.wave3enemy4.Visible = False
        '
        'boss
        '
        Me.boss.BackColor = System.Drawing.Color.Transparent
        Me.boss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boss.Location = New System.Drawing.Point(666, 290)
        Me.boss.Name = "boss"
        Me.boss.Size = New System.Drawing.Size(237, 190)
        Me.boss.TabIndex = 32
        Me.boss.TabStop = False
        Me.boss.Tag = "boss"
        Me.boss.Visible = False
        '
        'enemyTimer
        '
        Me.enemyTimer.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Wheat
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1235, 125)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Wheat
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 581)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(631, 125)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Wheat
        Me.PictureBox3.Location = New System.Drawing.Point(462, 375)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(166, 211)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1227, 883)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.boss)
        Me.Controls.Add(Me.wave3enemy4)
        Me.Controls.Add(Me.wave3enemy3)
        Me.Controls.Add(Me.wave3enemy2)
        Me.Controls.Add(Me.wave3enemy1)
        Me.Controls.Add(Me.arrowR)
        Me.Controls.Add(Me.arrowDown)
        Me.Controls.Add(Me.arrowUP)
        Me.Controls.Add(Me.arrowL)
        Me.Controls.Add(Me.bowLR)
        Me.Controls.Add(Me.bowUPDOWN)
        Me.Controls.Add(Me.wave2enemy5)
        Me.Controls.Add(Me.wave2enemy4)
        Me.Controls.Add(Me.wave2enemy3)
        Me.Controls.Add(Me.wave2enemy2)
        Me.Controls.Add(Me.wave2enemy1)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.shopBox)
        Me.Controls.Add(Me.swordUPDOWN)
        Me.Controls.Add(Me.swordLR)
        Me.Controls.Add(Me.wave1enemy3)
        Me.Controls.Add(Me.wave1enemy2)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wave1enemy1)
        Me.Controls.Add(Me.wall4)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave1enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave1enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swordLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swordUPDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shopBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave1enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave2enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave2enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave2enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave2enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave2enemy5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bowUPDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bowLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrowL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrowUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrowDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrowR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave3enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave3enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave3enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wave3enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents character As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents animationTimer As Timer
    Friend WithEvents wall1 As PictureBox
    Friend WithEvents wall2 As PictureBox
    Friend WithEvents wall3 As PictureBox
    Friend WithEvents wall4 As PictureBox
    Friend WithEvents wave1enemy1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHealth As Label
    Friend WithEvents wave1enemy2 As PictureBox
    Friend WithEvents enemySpawnTimer As Timer
    Friend WithEvents enemyMoveTimer As Timer
    Friend WithEvents swordLR As PictureBox
    Friend WithEvents weaponTimer As Timer
    Friend WithEvents swordUPDOWN As PictureBox
    Friend WithEvents shopBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents wave1enemy3 As PictureBox
    Friend WithEvents wave2enemy1 As PictureBox
    Friend WithEvents wave2enemy2 As PictureBox
    Friend WithEvents wave2enemy3 As PictureBox
    Friend WithEvents wave2enemy4 As PictureBox
    Friend WithEvents wave2enemy5 As PictureBox
    Friend WithEvents bowUPDOWN As PictureBox
    Friend WithEvents bowLR As PictureBox
    Friend WithEvents arrowL As PictureBox
    Friend WithEvents arrowUP As PictureBox
    Friend WithEvents arrowTimer As Timer
    Friend WithEvents arrowDown As PictureBox
    Friend WithEvents arrowR As PictureBox
    Friend WithEvents wave3enemy1 As PictureBox
    Friend WithEvents wave3enemy2 As PictureBox
    Friend WithEvents wave3enemy3 As PictureBox
    Friend WithEvents wave3enemy4 As PictureBox
    Friend WithEvents boss As PictureBox
    Friend WithEvents enemyTimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
