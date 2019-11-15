using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BreadthFirst
{
    public class AccountTreeBuillder  
        { 

            public Account BuildAccountGraph()
                {

                    Account Global = new Account("_Global", "Global");
                    Account Activo = new Account("100-00-00","Activo");
                    Account ActivoCirculante = new Account("100-01-00","Activo circulante");
                    Account Pasivo = new Account("200-00-00", "Pasivo");

                    Global.isParentOf(Activo);
                    Global.isParentOf(Pasivo);
                    Activo.isParentOf(ActivoCirculante);                
 
                    Account BancosExtranjeros = new Account("100-01-001", "Bancos Extranjeros");
                    Account BancosNacionales = new Account("100-01-002", "Bancos nacionales");
                    Account ProveedoresNacionales = new Account("200-00-001", "Proveedores Nacionales");
                    Account ProveedoresExtranjeros = new Account("200-00-002", "Proveedores Extranjeros");

                    ActivoCirculante.isParentOf(BancosExtranjeros);
                    ActivoCirculante.isParentOf(BancosNacionales);
                    Pasivo.isParentOf(ProveedoresExtranjeros);
                    Pasivo.isParentOf(ProveedoresNacionales);
 
                return Global;
            }

    }
}