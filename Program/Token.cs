public class Token 
{
    public Token(string jwtToken)
        => JwtToken = jwtToken;

    public string JwtToken { get; }
}