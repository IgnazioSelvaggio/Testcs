namespace Calcolatrice.Tests;


public class OperazioniTests
{
    private readonly Operazioni op = new();
 
    // I test verranno aggiunti qui, uno per volta.
    [Fact]
    public void Somma_DueNumeri_RestituisceLaSomma()
    {
        Assert.Equal(5, op.Somma(2, 3));
    }
    [Fact]
    public void Sottrai_DueNumeri_RestituisceLaDifferenza()
    {
        Assert.Equal(4, op.Sottrai(7, 3));
    }

}


