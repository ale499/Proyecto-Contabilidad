using System.Collections.Generic;

namespace contabilidad_1
{
    public class PlanData
    {
        public List<Cuenta> planCuentas = new List<Cuenta>();
    }
    
}

public class Cuenta
{
    public int Id = 20;
    public string NombreCuenta;
    public TipoCuenta TipoCuenta;
}