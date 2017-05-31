using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrestamos
{
    /*
    Debe arrojar los mismos resultados que:
    https://www.sib.gob.do/calculadora-de-prestamos
    */

    public class Fila
    {
        int mesN;
        double cuota;
        double capital;
        double interes;
        public double balance;

        public Fila( int n , double couta , double capital , double interes , double balance )
        {
            this.mesN = n;
            this.cuota = couta;
            this.capital = capital;
            this.interes = interes;
            this.balance = balance;
        }

        public string[] getAsStrings()
        {
            string[] s = new string[5];
            s[0] = mesN.ToString();
            s[1] = cuota.ToString();
            s[2] = capital.ToString();
            s[3] = interes.ToString();
            s[4] = balance.ToString();
            return s;
        }

        public override string ToString()
        {
            //return mesN.ToString() + " | " + cuota.ToString() + " | " + capital.ToString() + " | " + interes.ToString() + " | " + balance.ToString();
            return String.Format( "{0} | {1:0.00} | {2:0.00} | {3:0.00} | {4:0.00}" , mesN , cuota , capital , interes , balance );
        }
    }

    public struct Amortizacion
    {
        double balance;
        double interes;
        double tiempo;
        double couta;

        // http://www.abanfin.com/?tit=prestamo-con-cuota-constante-sistema-frances-formulario-economico-financiero&name=Manuales&fid=ee0bcbt
        // balance = prestamo total.
        // interes = porciento de interes anual.
        // tiempo  = duracion del prestamo en meses. 
        public Amortizacion( double balance , double interes , double tiempo )
        {
            this.balance = balance;
            this.interes = ( interes / 100.0 ) / 12; // Interes mensual.
            this.tiempo = tiempo;

            double i = this.interes;

            double w = Math.Pow( 1 + i , tiempo );

            this.couta = balance * i * w / ( w - 1 );
        }

        private Fila generate( int n , double prevBalance )
        {
            double balance = prevBalance;
            double interes = balance * this.interes;
            double capital = this.couta - interes;
            balance -= capital;
            return new Fila( n , this.couta , capital , interes , balance > 0.01 ? balance : 0 );
        }

        public List<Fila> calc()
        {
            List< Fila > arr = new List< Fila >();
            arr.Add( generate( 1 , this.balance ) );

            int count = 1;
            while( arr[arr.Count - 1].balance > 0 )
            {
                arr.Add( generate( ++count , arr[arr.Count - 1].balance ) );
            }

            return arr;
        }

    }

}
