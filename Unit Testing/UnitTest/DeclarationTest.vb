Imports Unit_Testing
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class DeclarationTest
    Dim mrP As New Personne("Patate", "Mr", New Date(1900, 1, 1))

    <TestMethod()> Public Sub CasLimite0()

        Dim decZero As New Declaration(mrP, 14130.99, 0)

        Assert.AreEqual(decZero.CalculImpot, 0.0)

    End Sub

    <TestMethod()> Public Sub CasLimiteShitty()
        Dim decShitty As New Declaration(mrP, 14131, 0)

        Assert.AreEqual(decShitty.CalculImpot, 2260.96)
    End Sub
End Class
