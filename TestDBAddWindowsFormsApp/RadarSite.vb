Public Class RadarSite

    Private nameValue As String
    Private LatValue As Double
    Private LngValue As Double
    Private XValue As Double
    Private YValue As Double
    Private DistanceFromOriginSiteValue As Double
    Private IICodeValue As Integer

    Public Sub New()
    End Sub

    Public Sub New(dataRow As DataRow)
        NewDMKRadarSite()
        'Me.dataRow = dataRow
    End Sub

    Public Sub NewDMKRadarSite()
        'Throw New NotImplementedException()
    End Sub

    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property

    Public Property Lat() As Double
        Get
            Return LatValue
        End Get
        Set(ByVal value As Double)
            LatValue = value
        End Set
    End Property

    Public Property Lng() As Double
        Get
            Return LngValue
        End Get
        Set(ByVal value As Double)
            LngValue = value
        End Set
    End Property

    Public Property X() As Double
        Get
            Return XValue
        End Get
        Set(ByVal value As Double)
            XValue = value
        End Set
    End Property

    Public Property Y() As Double
        Get
            Return YValue
        End Get
        Set(ByVal value As Double)
            YValue = value
        End Set
    End Property

    Public Property DistanceFromOriginSite() As Double
        Get
            Return DistanceFromOriginSiteValue
        End Get
        Set(ByVal value As Double)
            DistanceFromOriginSiteValue = value
        End Set
    End Property

    Public Property IICode() As Integer
        Get
            Return IICodeValue
        End Get
        Set(ByVal value As Integer)
            IICodeValue = value
        End Set
    End Property

End Class
