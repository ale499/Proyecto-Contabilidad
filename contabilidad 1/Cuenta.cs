namespace contabilidad_1
{
    public class Cuenta
    {
        public int Id;
        public string NombreCuenta;
        public TipoCuenta TipoCuenta;
    }
}

public enum TipoCuenta
{
    Activo,
    Pasivo,
    PatrimonioNeto,
    ResultadoPositivo,
    ResultadoNegativo
}

