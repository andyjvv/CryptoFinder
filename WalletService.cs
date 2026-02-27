using NBitcoin;

public class WalletService
{
    public bool IsValidAddress(string address)
    {
        try
        {
            BitcoinAddress.Create(address, Network.Main);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Otros métodos: importar clave privada, mostrar saldo, etc.
}
