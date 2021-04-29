using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_Tabla_de_amortizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            float cuota_mensual, Interes_pagado, Capital_pagado, Monto_del_prestamo, tasa_interes_anual, tasa_interes_mensual, balance;
            int no_pago, Plazo, i;

            Console.Write("Introduce el monto del préstamo: ");
            float.TryParse(Console.ReadLine(), out Monto_del_prestamo);
            Console.Write("Introduce la tasa de interes anual: ");
            float.TryParse(Console.ReadLine(), out tasa_interes_anual);
            Console.Write("Introduce el plazo en meses: ");
            int.TryParse(Console.ReadLine(), out Plazo);

            //Calculo del interes mensual
            tasa_interes_mensual = (tasa_interes_anual / 100) / 12;


            //Calculo de la cuota mensual
            cuota_mensual = tasa_interes_mensual + 1;
            cuota_mensual = (float)Math.Pow(cuota_mensual, Plazo);
            cuota_mensual = cuota_mensual - 1;
            cuota_mensual = tasa_interes_mensual / cuota_mensual;
            cuota_mensual = tasa_interes_mensual + cuota_mensual;
            cuota_mensual = Monto_del_prestamo * cuota_mensual;



            Console.WriteLine();
            Console.WriteLine("Pago        Cuota         Capital         Interes        Balance");
            Console.WriteLine();
            no_pago = 1;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write(" Numero de pago \t");
            //Console.Write("Pago \t\t");
            //Console.Write("Intereses Pagados \t\t");
            //Console.Write("Capital Pagado \t\t");
            //Console.Write("Monto del prestamo \t");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("\t0");
            //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Monto_del_prestamo);

            balance = Monto_del_prestamo;


            for (i = 1; i <= Plazo; i++)
            {


                //Console.Write("\t{0}\t\t", fila);


                //Console.Write("{0}\t",pago);


                Interes_pagado = tasa_interes_mensual * balance;
                //Console.Write("{0}\t\t", Interes_pagado);

                Capital_pagado = cuota_mensual - Interes_pagado;
                //Console.Write("\t{0}\t", Capital_pagado);

                balance = balance - Capital_pagado;
                //Console.Write("\t{0}\t", balance);
               
                Console.Write
                    (Convert.ToString(no_pago).PadLeft(2)        + "    " + 
                    Convert.ToString(cuota_mensual).PadLeft(12)  + "    " + 
                    Convert.ToString(Capital_pagado).PadLeft(12) + "    " + 
                    Convert.ToString(Interes_pagado).PadLeft(12) + "    " +
                    Convert.ToString(balance).PadLeft(12));

                no_pago = no_pago + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
