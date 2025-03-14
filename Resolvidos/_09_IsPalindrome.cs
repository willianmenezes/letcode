namespace LetCode.Resolvidos;

public class _09_IsPalindrome
{
    //Let code numero 09
    private bool IsPalindrome(int x)
    {
        var stringNumero = x.ToString();

        for (var i = 0; i < stringNumero.Length; i++)
        {
            var meio = stringNumero.Length;

            if (i == meio)
            {
                break;
            }

            if (stringNumero[i] != stringNumero[stringNumero.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}