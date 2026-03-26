Imports System.Xml.Serialization

Public Class WidgetTheme

#Region "Create and Destroy"

    Public Sub New()
        'MyBase.New()

        Me.theEnabledForeColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        Me.theEnabledBackColor = New XmlColor(Color.FromArgb(&HFF2D2D2D))
        Me.theEnabledBorderColor = New XmlColor(Color.FromArgb(&HFF555555))
        Me.theEnabledBorderWidth = 1

        Me.theDisabledForeColor = New XmlColor(Color.FromArgb(&HFF808080))
        Me.theDisabledBackColor = New XmlColor(Color.FromArgb(&HFF2D2D2D))
        Me.theDisabledBorderColor = New XmlColor(Color.FromArgb(&HFF454545))
        Me.theDisabledBorderWidth = 1

        Me.theSelectedForeColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        Me.theSelectedBackColor = New XmlColor("WindowColorizationColor")
        Me.theSelectedBorderColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        Me.theSelectedBorderWidth = 1

        Me.theFocusForeColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        Me.theFocusBackColor = New XmlColor(Color.FromArgb(&HFF4B4B4B))
        'Me.theFocusTopBackColor = New XmlColor("WindowColorizationColor")
        'Me.theFocusBottomBackColor = New XmlColor(Color.FromArgb(&HFF4B4B4B))
        Me.theFocusBorderColor = New XmlColor("WindowColorizationColor")
        Me.theFocusBorderWidth = 1

        'Me.theTextEnabledForeColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        'Me.theTextEnabledBackColor = New XmlColor(Color.FromArgb(&HFF4B4B4B))

        'Me.theTextDisabledForeColor = New XmlColor(Color.FromArgb(&HFF808080))
        'Me.theTextDisabledBackColor = New XmlColor(Color.FromArgb(&HFF4B4B4B))

        'Me.theTextFocusForeColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        'Me.theTextFocusBackColor = New XmlColor(Color.FromArgb(&HFF4B4B4B))

        'Me.theTextSelectedForeColor = New XmlColor(Color.FromArgb(&HFFF1F1F1))
        'Me.theTextSelectedBackColor = New XmlColor("WindowColorizationColor")
    End Sub

#End Region

#Region "Init and Free"

    'Public Sub Init()
    'End Sub

    'Private Sub Free()
    'End Sub

#End Region

#Region "Properties"

    Public Property EnabledForeColor As XmlColor
        Get
            Return Me.theEnabledForeColor
        End Get
        Set(value As XmlColor)
            Me.theEnabledForeColor = value
        End Set
    End Property

    Public Property EnabledBackColor As XmlColor
        Get
            Return Me.theEnabledBackColor
        End Get
        Set(value As XmlColor)
            Me.theEnabledBackColor = value
        End Set
    End Property

    Public Property EnabledBorderColor As XmlColor
        Get
            Return Me.theEnabledBorderColor
        End Get
        Set(value As XmlColor)
            Me.theEnabledBorderColor = value
        End Set
    End Property

    Public Property EnabledBorderWidth As Integer
        Get
            Return Me.theEnabledBorderWidth
        End Get
        Set(value As Integer)
            Me.theEnabledBorderWidth = value
        End Set
    End Property

    Public Property DisabledForeColor As XmlColor
        Get
            Return Me.theDisabledForeColor
        End Get
        Set(value As XmlColor)
            Me.theDisabledForeColor = value
        End Set
    End Property

    Public Property DisabledBackColor As XmlColor
        Get
            Return Me.theDisabledBackColor
        End Get
        Set(value As XmlColor)
            Me.theDisabledBackColor = value
        End Set
    End Property

    Public Property DisabledBorderColor As XmlColor
        Get
            Return Me.theDisabledBorderColor
        End Get
        Set(value As XmlColor)
            Me.theDisabledBorderColor = value
        End Set
    End Property

    Public Property DisabledBorderWidth As Integer
        Get
            Return Me.theDisabledBorderWidth
        End Get
        Set(value As Integer)
            Me.theDisabledBorderWidth = value
        End Set
    End Property

    Public Property SelectedForeColor As XmlColor
        Get
            Return Me.theSelectedForeColor
        End Get
        Set(value As XmlColor)
            Me.theSelectedForeColor = value
        End Set
    End Property

    Public Property SelectedBackColor As XmlColor
        Get
            Return Me.theSelectedBackColor
        End Get
        Set(value As XmlColor)
            Me.theSelectedBackColor = value
        End Set
    End Property

    Public Property SelectedBorderColor As XmlColor
        Get
            Return Me.theSelectedBorderColor
        End Get
        Set(value As XmlColor)
            Me.theSelectedBorderColor = value
        End Set
    End Property

    Public Property SelectedBorderWidth As Integer
        Get
            Return Me.theSelectedBorderWidth
        End Get
        Set(value As Integer)
            Me.theSelectedBorderWidth = value
        End Set
    End Property

    Public Property FocusForeColor As XmlColor
        Get
            Return Me.theFocusForeColor
        End Get
        Set(value As XmlColor)
            Me.theFocusForeColor = value
        End Set
    End Property

    Public Property FocusBackColor As XmlColor
        Get
            Return Me.theFocusBackColor
        End Get
        Set(value As XmlColor)
            Me.theFocusBackColor = value
        End Set
    End Property

    Public Property FocusBorderColor As XmlColor
        Get
            Return Me.theFocusBorderColor
        End Get
        Set(value As XmlColor)
            Me.theFocusBorderColor = value
        End Set
    End Property

    Public Property FocusBorderWidth As Integer
        Get
            Return Me.theFocusBorderWidth
        End Get
        Set(value As Integer)
            Me.theFocusBorderWidth = value
        End Set
    End Property

#End Region

#Region "Methods"

#End Region

#Region "Events"


#End Region

#Region "Private Methods"

#End Region

#Region "Data"

    Protected theEnabledForeColor As XmlColor
    Protected theEnabledBackColor As XmlColor
    Protected theEnabledBorderColor As XmlColor
    Protected theEnabledBorderWidth As Integer

    Protected theDisabledForeColor As XmlColor
    Protected theDisabledBackColor As XmlColor
    Protected theDisabledBorderColor As XmlColor
    Protected theDisabledBorderWidth As Integer

    Protected theSelectedForeColor As XmlColor
    Protected theSelectedBackColor As XmlColor
    Protected theSelectedBorderColor As XmlColor
    Protected theSelectedBorderWidth As Integer

    Protected theFocusForeColor As XmlColor
    Protected theFocusBackColor As XmlColor
    Protected theFocusBorderColor As XmlColor
    Protected theFocusBorderWidth As Integer

#End Region

End Class
