Public Class Declaration

    Private _cotiseur As Personne
    Private _revenuBrut As Double
    Private _impotRetenu As Double

    Public Property ImpotRetenu() As Double
        Get
            Return _impotRetenu
        End Get
        Set(ByVal value As Double)
            _impotRetenu = value
        End Set
    End Property

    Public Property RevenuBrut() As Double
        Get
            Return _revenuBrut
        End Get
        Set(ByVal value As Double)
            _revenuBrut = value
        End Set
    End Property

    Public Property Cotiseur() As Personne
        Get
            Return _cotiseur
        End Get
        Set(ByVal value As Personne)
            _cotiseur = value
        End Set
    End Property


    Public Sub New(pCotiseur As Personne, pRevenuBrut As Double, pImpot As Double)
        _cotiseur = pCotiseur
        _revenuBrut = pRevenuBrut
        _impotRetenu = pImpot
    End Sub

    Public Function CalculImpot() As Double
        Select Case RevenuBrut
            Case 41495 To 82984.99
                Return RevenuBrut * 0.2 - ImpotRetenu
            Case 14131 To 41494.99
                Return RevenuBrut * 0.16 - ImpotRetenu
            Case 82985 To 100969.99
                Return RevenuBrut * 0.24 - ImpotRetenu
            Case Is < 14131
                Return -ImpotRetenu
            Case Else
                Return RevenuBrut * 0.258 - ImpotRetenu
        End Select
    End Function
End Class
