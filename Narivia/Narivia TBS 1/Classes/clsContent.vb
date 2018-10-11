Public Class clsContent
    Public Class GameContent

        Public Content As ContentManager
        Private ServiceHelper As New ServiceHelper

        Public Sub New(GraphicsDevice As GraphicsDevice)
            ServiceHelper.GraphicsDeviceService(GraphicsDevice)
            Me.Content = New Content.ContentManager(ServiceHelper)
            Me.Content.RootDirectory = "Content"
        End Sub

    End Class

    Public Class ServiceHelper
        Implements IServiceProvider
        Implements IGraphicsDeviceService

        Public Function GetService(ByVal serviceType As System.Type) As Object Implements System.IServiceProvider.GetService
            Return Me
        End Function

        Public Event DeviceCreated(ByVal sender As Object, ByVal e As System.EventArgs) Implements Microsoft.Xna.Framework.Graphics.IGraphicsDeviceService.DeviceCreated
        Public Event DeviceDisposing(ByVal sender As Object, ByVal e As System.EventArgs) Implements Microsoft.Xna.Framework.Graphics.IGraphicsDeviceService.DeviceDisposing
        Public Event DeviceReset(ByVal sender As Object, ByVal e As System.EventArgs) Implements Microsoft.Xna.Framework.Graphics.IGraphicsDeviceService.DeviceReset
        Public Event DeviceResetting(ByVal sender As Object, ByVal e As System.EventArgs) Implements Microsoft.Xna.Framework.Graphics.IGraphicsDeviceService.DeviceResetting

        Private _gd As GraphicsDevice

        Public Sub GraphicsDeviceService(ByVal gd As GraphicsDevice)
            _gd = gd
        End Sub

        Public ReadOnly Property GraphicsDevice() As Microsoft.Xna.Framework.Graphics.GraphicsDevice Implements Microsoft.Xna.Framework.Graphics.IGraphicsDeviceService.GraphicsDevice
            Get
                Return _gd
            End Get
        End Property
    End Class
End Class