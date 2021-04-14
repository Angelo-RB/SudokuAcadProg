using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

    class Program
    {
        static void Main()
        {

            int[] linha1 = new int[] { 1, 3, 2, 5, 7, 9, 4, 6, 8};

            int l1 = 0;
            for (int i1 = 0; i1 < linha1.Length; i1++)
            {
                l1 += linha1[i1];
            }
       
        //
            int[] linha2 = new int[] { 4, 9, 8, 2, 6, 1, 3, 7, 5 };

            int l2 = 0;
            for (int i2 = 0; i2 < linha2.Length; i2++)
            {
                l2 += linha2[i2];
            }
           
        //
            int[] linha3 = new int[] { 7, 5, 6, 3, 8, 4, 2, 1, 9 };

            int l3 = 0;
            for (int i3 = 0; i3 < linha3.Length; i3++)
            {
                l3 += linha3[i3];
            }
     
        //
            int[] linha4 = new int[] { 6, 4, 3, 1, 5, 8, 7, 9, 2 };

            int l4 = 0;
            for (int i4 = 0; i4 < linha4.Length; i4++)
            {
                l4 += linha4[i4];
            }
            
        //
            int[] linha5 = new int[] { 5, 2, 1, 7, 9, 3, 8, 4, 6 };

            int l5 = 0;
            for (int i5 = 0; i5 < linha5.Length; i5++)
            {
                l5 += linha5[i5];
            }

        //
            int[] linha6 = new int[] { 9, 8, 7, 4, 2, 6, 5, 3, 1 };

            int l6 = 0;
            for (int i6 = 0; i6 < linha6.Length; i6++)
            {
                l6 += linha6[i6];
            }
            
        //
            int[] linha7 = new int[] { 2, 1, 4, 9, 3, 5, 6, 8, 7 };

            int l7 = 0;
            for (int i7 = 0; i7 < linha7.Length; i7++)
            {
                l7 += linha7[i7];
            }
            
        //
            int[] linha8 = new int[] { 3, 6, 5, 8, 1, 7, 9, 2, 4 };

            int l8 = 0;
            for (int i8 = 0; i8 < linha8.Length; i8++)
            {
                l8 += linha8[i8];
            }
            
        //
            int[] linha9 = new int[] { 3, 6, 5, 8, 1, 7, 9, 2, 4 };

            int l9 = 0;
            for (int i9 = 0; i9 < linha9.Length; i9++)
            {
                l9 += linha9[i9];
            }
            
        //
        //
        //
            int[] coluna1 = new int[] { 1, 4, 7, 6, 5, 9, 2, 3, 8 };

            int c1 = 0;
            for (int i01 = 0; i01 < coluna1.Length; i01++)
            {
                c1+= coluna1[i01];
            }
          
        //
            int[] coluna2 = new int[] { 3, 9, 5, 4, 2, 8, 1, 6, 7 };

            int c2 = 0;
            for (int i02 = 0; i02 < coluna2.Length; i02++)
            {
                c2+= coluna2[i02];
            }
           
        //
            int[] coluna3 = new int[] { 2, 8, 6, 3, 1, 7, 4, 5, 9 };

            int c3 = 0;
            for (int i03 = 0; i03 < coluna3.Length; i03++)
            {
                c3+= coluna3[i03];
            }
            
        //
            int[] coluna4 = new int[] { 5, 2, 3, 1, 7, 4, 9, 8, 6 };

            int c4 = 0;
            for (int i04 = 0; i04 < coluna4.Length; i04++)
            {
                c4+= coluna4[i04];
            }
            
        //
            int[] coluna5 = new int[] { 7, 6, 8, 5, 9, 2, 3, 1, 4 };

            int c5 = 0;
            for (int i05 = 0; i05 < coluna5.Length; i05++)
            {
                c5+= coluna5[i05];
            }
            
        //
            int[] coluna6 = new int[] { 9, 1, 4, 8, 3, 6, 5, 7, 2 };

            int c6 = 0;
            for (int i06 = 0; i06 < coluna6.Length; i06++)
            {
                c6+= coluna6[i06];
            }
            
        //
            int[] coluna7 = new int[] { 4, 3, 2, 7, 8, 5, 6, 9, 1 };

            int c7 = 0;
            for (int i07 = 0; i07 < coluna7.Length; i07++)
            {
                c7+= coluna7[i07];
            }

        //
            int[] coluna8 = new int[] { 6, 7, 1, 9, 4, 3, 8, 2, 5 };

            int c8 = 0;
            for (int i08 = 0; i08 < coluna8.Length; i08++)
            {
                c8+= coluna8[i08];
            }
        //
            int[] coluna9 = new int[] { 8, 5, 9, 2, 6, 1, 7, 4, 3 };

            int c9 = 0;
            for (int i09 = 0; i09 < coluna9.Length; i09++)
            {
                c9+= coluna9[i09];
            }
        //
        //
        //
            int[] bloco1 = new int[] { 1, 3, 2, 4, 9, 8, 7, 5, 6 };

            int b1 = 0;
            for (int i001 = 0; i001 < bloco1.Length; i001++)
            {
                b1+= bloco1[i001];
            }
          
        //
            int[] bloco2 = new int[] { 5, 7, 9, 2, 6, 1, 3, 8, 4 };

            int b2 = 0;
            for (int i002 = 0; i002 < bloco2.Length; i002++)
            {
                b2+= bloco2[i002];
            }
           
        //
            int[] bloco3 = new int[] { 4, 6, 8, 3, 7, 5, 2, 1, 9 };

            int b3 = 0;
            for (int i003 = 0; i003 < bloco3.Length; i003++)
            {
                b3+= bloco3[i003];
            }
            
        //
            int[] bloco4 = new int[] { 6, 4, 3, 5, 2, 1, 9, 8, 7 };

            int b4 = 0;
            for (int i004 = 0; i004 < bloco4.Length; i004++)
            {
                b4+= bloco4[i004];
            }
            
        //
            int[] bloco5 = new int[] { 1, 5, 8, 7, 9, 3, 4, 2, 6 };

            int b5 = 0;
            for (int i005 = 0; i005 < bloco5.Length; i005++)
            {
                b5+= bloco5[i005];
            }
            
        //
            int[] bloco6 = new int[] { 7, 9, 2, 8, 4, 6, 5, 3, 1 };

            int b6 = 0;
            for (int i006 = 0; i006 < bloco6.Length; i006++)
            {
                b6+= bloco6[i006];
            }
            
        //
            int[] bloco7 = new int[] { 2, 1, 4, 3, 6, 5, 8, 7, 9 };

            int b7 = 0;
            for (int i007 = 0; i007 < bloco7.Length; i007++)
            {
                b7+= bloco7[i007];
            }

        //
            int[] bloco8 = new int[] { 9, 3, 5, 8, 1, 7, 6, 4, 2 };

            int b8 = 0;
            for (int i008 = 0; i008 < bloco8.Length; i008++)
            {
                b8+= bloco8[i008];
            }
        //
            int[] bloco9 = new int[] { 6, 8, 7, 9, 2, 4, 1, 5, 3 };

            int b9 = 0;
            for (int i009 = 0; i009 < bloco9.Length; i009++)
            {
                b9+= bloco9[i009];
            }


        int resultado = 0;
        resultado = l1 + l2 + l3 + l4 + l5 + l6 + l7 + l8 + l9 + c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9;

        if (resultado == 1215)
        {
            Console.WriteLine(resultado);
            Console.WriteLine("Sim");
            Console.ReadKey();
        }
        else if (resultado != 1215)
        {
            Console.WriteLine(resultado);
            Console.WriteLine("Não");
            Console.ReadKey();
        }


        }
    }
/*                          x  x  x  x  x  x  x  x
                          X 1, 3, 2, 5, 7, 9, 4, 6, 8, = 45     bloco == 405
                          x 4, 9, 8, 2, 6, 1, 3, 7, 5  = 45               .
                          x 7, 5, 6, 3, 8, 4, 2, 1, 9, = 45                .
                          x 6, 4, 3, 1, 5, 8, 7, 9, 2, = 45        == 405 
                          x 5, 2, 1, 7, 9, 3, 8, 4, 6, = 45                 .
                          x 9, 8, 7, 4, 2, 6, 5, 3, 1, = 45                   .
                          x 2, 1, 4, 9, 3, 5, 6, 8, 7, = 45                     ==== 1,215
                          x 3, 6, 5, 8, 1, 7, 9, 2, 4, = 45                    .
                          x 8, 7, 9, 6, 4, 2, 1, 5, 3  = 45                 .
                            
                            45 45 45 45 45 45 45 45 45             == 405   */    