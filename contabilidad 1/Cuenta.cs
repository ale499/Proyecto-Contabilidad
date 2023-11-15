namespace contabilidad_1
{
    public class Cuenta
    {
        public int Id=20;
        public string NombreCuenta;
        public TipoCuenta TipoCuenta;
    }
}

public enum TipoCuenta
{
    SinDefinir,
    Activo,
    Pasivo,
    PatrimonioNeto,
    ResultadoPositivo,
    ResultadoNegativo
}

