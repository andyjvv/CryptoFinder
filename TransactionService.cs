// Sujeto a integración con algún nodo o API externo, ej: BlockCypher
public class TransactionService
{
    public bool SendTransaction(string privateKey, string toAddress, decimal amount)
    {
        // Construir y firmar transacción, conectar con la API, etc.
        // Retornar true si fue exitosa
        return true; // Simplificado
    }
}
