namespace Payme.Data.Merchant;
public abstract class Account { }
public class MobileOperatorAccount : Account
{
    public required string Phone { get; set; }
}

public class InternetProviderAccount : Account
{
    public required string Login { get; set; }
}