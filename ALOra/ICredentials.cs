namespace ALOra
{
    interface ICredentials
    {
        /* Properties */
        string ConnectString { get; }
        string DataSource { get; set; }
        string Password { get; set; }
        string UserId { get; set; }
    }
}
