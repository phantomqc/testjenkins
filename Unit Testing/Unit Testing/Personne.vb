Public Class Personne
    Private _nom As String
    Private _prenom As String
    Private _ddn As Date
    Public ReadOnly Property DDN() As Date
        Get
            Return _ddn
        End Get
    End Property

    Public Property Prenom() As String
        Get
            Return _prenom
        End Get
        Set(ByVal value As String)
            _prenom = value
        End Set
    End Property

    Public Property Nom() As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Sub New(pNom As String, pPrenom As String, pDDN As Date)
        _nom = pNom
        _prenom = pPrenom
        If Date.Now.Year - pDDN.Date.Year < 16 Then
            Throw New Exception("Seulement les personnes de 16 et plus doivent produire un rapport d'impôt")
        Else
            _ddn = pDDN
        End If

    End Sub
End Class
