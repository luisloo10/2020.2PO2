using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    public class Calc
    {
        int status;
        int Operation;
        bool IfChangeResult; //Si se debe cambiar el valor de TResultado
        double Result1;
        double Result2;

        public Calc()
        {
            status = 0;
            IfChangeResult = false;
        }

        public void Operacion(int operation)
        {
            status = 1;
            Operation = operation;
            IfChangeResult = true;
        }

        public string Result(double valor) //=
        {
            string total = "";
            if(status==1)
            {
                switch(Operation)
                {
                    case 1:
                        total = (Result1 + valor).ToString();
                        break;
                    case 2:
                        total = (Result1 - valor).ToString();
                        break;
                    case 3:
                        total = (Result1 * valor).ToString();
                        break;
                    case 4:
                        total = (Result1 / valor).ToString();
                        break;
                }
                status = 0;
                IfChangeResult = false;
            }
            return total;
        }

        public string SetResult(string previousValue, double valor)
        {
            string total = "";
            if(status==0)
            {
                total = previousValue + valor.ToString();
                Result1 = Convert.ToDouble(total);
            }
            else
            {
                if(IfChangeResult==true)
                {
                    total = valor.ToString();
                    IfChangeResult = false;
                }
                else
                {
                    total = previousValue + valor.ToString();
                }
                
                Result2 = Convert.ToDouble(total);
            }
            return total;
        }

        public string Reset()
        {
            status = 0;
            IfChangeResult = false;
            Result1 = 0;
            Result2 = 0;
            Operation = 0;
            return "";
        }

        public string ChangeSign(double valor)
        {
            SetResult(valor.ToString(), valor);
            return (valor * -1).ToString();
        }
    }
}
