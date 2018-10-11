Imports System.Windows.Forms

Module Module_Graphics
    Public GraphicsDevice As GraphicsDevice
    Public GameContent As clsContent.GameContent
    Public SpriteBatch As SpriteBatch

    '===' Resources
    Public TileSet As Texture2D
    Public TileSet_Borders As Texture2D
    Public FontSet As SpriteFont
    Public FontPosition As Vector2


    Public Function GraphicsInitialize(GameScreen As PictureBox) As Boolean
        Dim Success As Boolean = False

        Try
            Dim PresentationParameter As New PresentationParameters

            PresentationParameter.PresentationInterval = PresentInterval.Immediate
            PresentationParameter.DeviceWindowHandle = GameScreen.Handle
            PresentationParameter.IsFullScreen = False

            '===' Configures the Video Card
            Dim GraphicsAdapter As GraphicsAdapter = GraphicsAdapter.Adapters.Item(0)
            GraphicsDevice = New GraphicsDevice(GraphicsAdapter, GraphicsProfile.HiDef, PresentationParameter)

            '===' Loads Graphics and Graphics Device
            GameContent = New clsContent.GameContent(GraphicsDevice)
            GameContent.Content.RootDirectory = "Content"
            SpriteBatch = New SpriteBatch(GraphicsDevice)

            '===' Load Graphics Content
            LoadGraphics()

            Success = True
        Catch Err As Exception
            Success = False
            MsgBox("Graphics failed to initialize" & vbNewLine & vbNewLine & "Error: " & Err.Message, vbCritical, "Fatal Error!")
        End Try

        Return Success
    End Function

    Private Sub LoadGraphics()
        FontSet = GameContent.Content.Load(Of SpriteFont)("SpriteFont_1")
        TileSet = GameContent.Content.Load(Of Texture2D)("TileSet")
        TileSet_Borders = GameContent.Content.Load(Of Texture2D)("TileSet_Borders")
    End Sub

    Public Sub DrawGraphics()
        GraphicsDevice.Clear(Color.Black)

        SpriteBatch.Begin()

        For X = 0 To MapWidth - 1
            For Y = 0 To MapHeight - 1
                SpriteBatch.Draw(TileSet, New Rectangle(X * TileSize, Y * TileSize, TileSize, TileSize), New Rectangle(Region_Details(Map(X, Y), 2) * 5 + 5, 0, 5, 5), Color.White)
                If X > 0 And Y > 0 And X < MapWidth - 1 And Y < MapHeight - 1 Then DrawBorder(X, Y)

            Next
        Next
        If GameCursor Then SpriteBatch.Draw(TileSet, New Rectangle(MouseX * TileSize, MouseY * TileSize, TileSize, TileSize), New Rectangle(0, 0, 5, 5), Color.White)

        If Form_Play.CheckBox_Debug.Checked Then
            SpriteBatch.DrawString(FontSet, "FPS: " & CStr(MaxFrames), New Vector2(0, 0), Color.White)
            SpriteBatch.DrawString(FontSet, " X:" & MouseX & vbNewLine & " Y:" & MouseY, New Vector2(0, 16), Color.Gold)
        End If

        SpriteBatch.End()

        GraphicsDevice.Present()
    End Sub

    Private Sub DrawBorder(ByVal X As Integer, ByVal Y As Integer)
        If Map(X - 1, Y) <> Map(X, Y) Then SpriteBatch.Draw(TileSet_Borders, New Rectangle(X * TileSize, Y * TileSize, TileSize, TileSize), New Rectangle(15, 0, 5, 5), Color.White)
        If Map(X, Y + 1) <> Map(X, Y) Then SpriteBatch.Draw(TileSet_Borders, New Rectangle(X * TileSize, Y * TileSize, TileSize, TileSize), New Rectangle(10, 0, 5, 5), Color.White)

        If Region_Details(Map(X + 1, Y), 2) <> Region_Details(Map(X, Y), 2) Then SpriteBatch.Draw(TileSet_Borders, New Rectangle(X * TileSize, Y * TileSize, TileSize, TileSize), New Rectangle(5, 0, 5, 5), Color.White)
        If Region_Details(Map(X, Y - 1), 2) <> Region_Details(Map(X, Y), 2) Then SpriteBatch.Draw(TileSet_Borders, New Rectangle(X * TileSize, Y * TileSize, TileSize, TileSize), New Rectangle(0, 0, 5, 5), Color.White)
    End Sub

End Module