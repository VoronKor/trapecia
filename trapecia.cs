using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozn_prackt
{
    class trapecia
    {
        /* Разработка билиотеки для работы  
         с геометрическими данными трапеции
         (стороны, углы, периметр, площадь)*/
       

       
        
        public double S; // площадь
        public double P; // периметр
        public double L; //угол
         
        public double H; //высота

        public double A; //сторона а
        public double B; //сторона б
        public double C; //сторона с
        public double D; //сторона д
        public double ugol_A;
        public double ugol_B;


        public double MH;
        private double V1; // временные данные
        private double V2; // временные данные
        private double V3; // временные данные
        private double V4; // временные данные
        public  double otvet; 


        //вычисление высоты по сторонам
        public void VIS_PO_STORONAM()
        {
            V1 = Math.Pow(C, 2);


            V2=Math.Pow((A - B), 2);
            V3 = Math.Pow(D, 2);
            V4 = (2 * (A - B));

            V2 = V2 + V1 - V3;
            V2 = V2 / V4;
            H = V1 - V2;


            H = Math.Sqrt(H);

        }


        //вычисление высоты по углам
        public void VIS_PO_UGLAB(double c, double alf)
        {

            
           
            H = c+Math.Sin(alf);

        }


        //вычисление площади по высоте и основанию
        public void Sp_OSN_VIS(double A, double B)
        {
            VIS_PO_STORONAM();

            S = 0.5*H*(A + B);
        }

        //вычисление площади по высоте и средней линии
        public void Sp_SR_LIN_VIS()
        {
            VIS_PO_STORONAM();
            SRED_LIN();
            S = MH * H;
        }


        //вычисление основания по средней линии и 2 основанию
        public void OSNOV_PO_SR_LINE(double a, double mh)
        {
            A = a;
            MH = mh;
            otvet = 2 * MH - A;
        }
        //вычисление периметра
        public void PP(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            P = A + B + C + D;
        }




        //вычисление средней линии
        public void SRED_LIN()
        {
            
            MH = 0.5 * (A + B);
        }




        //вычисление сторон по основанию а
        public void OPREDELENIE_STORON_PO_A(double U1, double U2, double a, double h)
        {
            ugol_A = U1;
            ugol_B = U2;
            A = a;
            H = h;

            // b=c-h(ctg(alf)+ctg(b)
            //c=h/sin(alf)
            //d=h/sin(bet)

           C=H/ Math.Sin(ugol_A);
           D = H / Math.Sin(ugol_B);
           B = A-H*((1.0 / Math.Tan(ugol_A))+ (1.0 / Math.Tan(ugol_B)));
            
            //b=a-c*cos(alf)-d*cos(bet)
            // использовать по своему усмотрению
            //B=A-C* Math.Cos(ugol_A)-D*Math.Cos(ugol_B);

        }

        //вычисление сторон по основанию б
        public void OPREDELENIE_STORON_PO_B(double U1, double U2, double a, double h)
        {
            ugol_A = U1;
            ugol_B = U2;
            B = a;
            H = h;



            // a=b+h(ctg(alf)+ctg(b)
            //c=h/sin(alf)
            //d=h/sin(bet)

            C = H / Math.Sin(ugol_A);
            D = H / Math.Sin(ugol_B);
            A = B + H * ((1.0 / Math.Tan(ugol_A)) + (1.0 / Math.Tan(ugol_B)));




            //a=b+c*cos(alf)+d*cos(bet)
            // использоват ьпо своему усмотрению
            //A=B+C* Math.Cos(ugol_A)+D*Math.Cos(ugol_B);
        }


        //вычисление сторон по диагоналям и основанию а
        public void OPREDELENIE_STORON_PO_DIAGONALI_I_A(double U1, double a, double h, double d1, double d2)
        {
            ugol_A = U1;
            A = a;
            H = h;

            //b=d1*d2/h*sin(alf)-a

            B = d1 * d2 / H * Math.Sin(ugol_A) - A;
        }

        //вычисление сторон по диагоналям и основанию б
        public void OPREDELENIE_STORON_PO_DIAGONALI_I_B(double U1, double b, double h, double d1, double d2)
        {
            ugol_A = U1;
            B = b;
            H = h;

            //b=d1*d2/h*sin(alf)-a

            A = d1 * d2 / H * Math.Sin(ugol_A) - B;
        }



        //вычисление углов
        public void UG(double pr_ug)
        {

            L = 180-pr_ug;
        }
    }
}
