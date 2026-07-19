Imports System.Drawing.Drawing2D

Public Class RadioButtonEx
	Inherits RadioButton

#Region "Create and Destroy"

	Public Sub New()
		MyBase.New()
	End Sub

#End Region

#Region "Init and Free"

	Private Sub Init()
		' [04-Feb-2026] Because Me.DesignMode is unreliable in nested widgets, must do this check to prevent a crash.
		If TheApp IsNot Nothing Then
			'Me.UpdateTheme()
			AddHandler TheApp.Settings.PropertyChanged, AddressOf Me.AppSettings_PropertyChanged
		End If
	End Sub

	Private Sub Free()
		' [04-Feb-2026] Because Me.DesignMode is unreliable in nested widgets, must do this check to prevent a crash.
		If TheApp IsNot Nothing Then
			RemoveHandler TheApp.Settings.PropertyChanged, AddressOf Me.AppSettings_PropertyChanged
		End If
	End Sub

#End Region

#Region "Properties"

#End Region

#Region "Widget Event Handlers"

	Protected Overrides Sub OnHandleCreated(e As EventArgs)
		MyBase.OnHandleCreated(e)

		If Me.theOriginalFont Is Nothing Then
			Me.Font = New Font(SystemFonts.MessageBoxFont.Name, 8.25)
			'NOTE: Font gets changed at some point after changing style, messing up when cue banner is turned off, 
			'      so save the Font before changing style.
			Me.theOriginalFont = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, Me.Font.Style, Me.Font.Unit)
		End If

		' [04-Feb-2026] Me.DesignMode is unreliable in nested widgets.
		'If Not Me.DesignMode Then
		Me.Init()
		'End If
	End Sub

	Protected Overrides Sub OnHandleDestroyed(e As EventArgs)
		Me.Free()
		MyBase.OnHandleDestroyed(e)
	End Sub

	' Works without needing to call SetStyle.
	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		Dim theme As RadioButtonTheme = Nothing
		' This check prevents problems with viewing and saving Forms in VS Designer.
		If TheApp IsNot Nothing Then
			theme = TheApp.Settings.SelectedAppTheme.RadioButtonTheme
		End If
		If theme IsNot Nothing Then
			Dim g As Graphics = e.Graphics
			Dim rect As Rectangle = Me.ClientRectangle

			Dim checkBoxWidth As Integer = 12

			Dim textColor As Color = WidgetConstants.WidgetTextColor
			If Not Me.Enabled Then
				textColor = WidgetConstants.WidgetDisabledTextColor
			End If

			Dim checkboxBorderColor As Color = WidgetConstants.WidgetDisabledTextColor
			If Not Me.Enabled Then
				checkboxBorderColor = WidgetConstants.WidgetDisabledTextColor
			End If

			'Dim checkboxBackgroundColor As Color = WidgetConstants.WidgetHighBackColor
			Dim fillColor As Color = WidgetConstants.Windows10GlobalAccentColor

			' Draw background of entire checkbox widget.
			Using b As New SolidBrush(Me.Parent.BackColor)
				g.FillRectangle(b, rect)
			End Using

			Dim originalSmoothingMode As SmoothingMode = g.SmoothingMode
			g.SmoothingMode = SmoothingMode.AntiAlias

			Dim rectRadio As New RectangleF(0, CSng((ClientRectangle.Height - 13) / 2 - 1), 13, 13)
			e.Graphics.DrawEllipse(Pens.Black, rectRadio)
			rectRadio.Inflate(New Size(-1, -1))
			If Me.Checked Then
				e.Graphics.FillEllipse(New SolidBrush(fillColor), rectRadio)
			Else
				e.Graphics.FillEllipse(New SolidBrush(Me.Parent.BackColor), rectRadio)
			End If

			g.SmoothingMode = originalSmoothingMode

			Using b As New SolidBrush(textColor)
				Dim modRect As New Rectangle(checkBoxWidth + 4, 0, rect.Width - checkBoxWidth, rect.Height)
				Dim formatFlags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter

				TextRenderer.DrawText(g, Me.Text, Me.theOriginalFont, modRect, textColor, WidgetConstants.WidgetBackColor, formatFlags)
			End Using
		Else
			MyBase.OnPaint(e)
		End If
	End Sub

#End Region

#Region "Core Event Handlers"

	Private Sub AppSettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
		If e.PropertyName = "AppThemeName" Then
			'Me.UpdateTheme()
			Me.Refresh()
		End If
	End Sub

#End Region

#Region "Events"

#End Region

#Region "Private Methods"

	'Private Sub UpdateTheme()
	'	Dim theme As ButtonTheme = Nothing
	'	If TheApp IsNot Nothing Then
	'		theme = TheApp.Settings.SelectedAppTheme.ButtonTheme
	'	End If
	'	If theme IsNot Nothing Then
	'	Else
	'	End If
	'End Sub

#End Region

#Region "Data"

	Protected theControlIsReadOnly As Boolean
	Private theOriginalFont As Font

#End Region

End Class
