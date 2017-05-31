using System;
using System.Drawing;
using System.Windows.Forms;


namespace CalculadoraPrestamos
{
    public partial class Form1 : Form
    {

        private void resetTable()
        {
            TablaResultados.Controls.Clear();
            TablaResultados.RowStyles.Clear();
            TablaResultados.AutoScrollMinSize = new Size( 0 , 0 ) ;

            string[] head = { "Mes" , "Cuota" , "Capital" , "Interes" , "Balance" };

            foreach( string txt in head )
            {
                Label text = new Label();
                text.Text = txt;
                TablaResultados.Controls.Add( text );
            }
        }

        public Form1()
        {
            InitializeComponent();

            resetTable();
        }


        // Para la version de consola.
        static void Steps()
        {
            string[] userInput = { "Total del prestamo:" , "Tasa de interes anual %:" , "Plazo en meses:" };

            double[] values = new double[ 3 ];
            int index = 0;

            foreach( string msg in userInput )
            {
                Console.Write( msg );

                double val;

                bool valido = double.TryParse( Console.ReadLine() , out val ) && val > 0;

                while( !valido )
                {
                    Console.WriteLine( "El valor que ingreso no es valido" );
                    Console.Write( msg );
                    valido = double.TryParse( Console.ReadLine() , out val ) && val > 0;
                }

                values[index++] = val;
            }

            string head = "Mes#  | Couta | Capital | Interes | Balance";

            Console.WriteLine( head );

            Amortizacion calculo = new Amortizacion( values[0] , values[1] , values[2] );

            var lista = calculo.calc();

            foreach( Fila fila in lista )
            {
                Console.WriteLine( fila );
            }

            Console.WriteLine( "Presione una tecla para empezar un nuevo calculo" );
            Console.ReadKey();
        }

        private void Form1_Load( object sender , EventArgs e ){}

        private void Inform( string msg )
        {
            MessageBox.Show( "El campo " + msg + " debe ser un número válido" );
        }

        private void Calcular_OnClick( object sender , EventArgs e )
        {
            double balance , interes , plazo;

            if( !Double.TryParse( BalanceTB.Text , out balance ) )
            {
                Inform( "Balance" );
                return;
            }

            if( !Double.TryParse( InteresTB.Text , out interes ) )
            {
                Inform( "Interes" );
                return;
            }

            if( !Double.TryParse( PlazoTB.Text , out plazo ) )
            {
                Inform( "Plazo" );
                return;
            }

            resetTable();

            Amortizacion calculo = new Amortizacion( balance , interes , plazo );

            var lista = calculo.calc();

            foreach( Fila fila in lista )
            {
                TablaResultados.RowStyles.Add( new RowStyle( SizeType.AutoSize ) );

                foreach( string txt in fila.getAsStrings() )
                {
                    Label text = new Label();
                    text.Text = txt;
                    TablaResultados.Controls.Add( text );
                }
            }
        }

        private void TablaResultados_Paint( object sender , PaintEventArgs e )
        {

        }
    }
}
