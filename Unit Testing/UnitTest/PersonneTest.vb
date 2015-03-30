Imports Unit_Testing
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PersonneTest

    <TestMethod()> Public Sub AgeFailPersonne()
        Try
            Dim personne As New Personne("Patate", "Mr", New Date(2000, 1, 1))
        Catch ex As Exception
            StringAssert.Contains(ex.Message, "Seulement les personnes de 16 et plus doivent produire un rapport d'impôt")
        End Try

    End Sub

    <TestMethod()> Public Sub AgeRéussiPersonne()
        Dim personne2 As New Personne("Patate", "Mr", New Date(1900, 1, 1))
    End Sub

End Class