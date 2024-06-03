#region Using for Loops
/* Mandelbrot sets
    Each position in a Mandelbrot image corresponds to an imaginary number
    of the form N = x + y*i 
    where x = real part, y = imaginary part and i = square root of -1

    For each position look at N = x*x + y*y where i = square root of -1
    If N >= 2  => position has a value of 2
    If N < 2   => N = N*N - N => 
*/
double realCoord, imagCoord;
double realTemp, imagTemp, realTemp2, arg;
int iterations;

for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
{
    for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
    {
        iterations = 0;
        realTemp = realCoord;
        imagTemp = imagCoord;
        arg = (realTemp * realTemp) + (imagTemp * imagTemp);

        while ((arg < 4) && (iterations < 40))
        {
            realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                        - realCoord;
            imagTemp = (2 * realTemp * imagTemp) - imagCoord;
            realTemp = realTemp2;
            arg = (realTemp * realTemp) + (imagTemp * imagTemp);
            iterations += 1;
        }

        switch (iterations % 4)
        {
            case 0:
                Write(".");
                break;
            case 1:
                Write("o");
                break;            
            case 2:
                Write("O");
                break;
            case 3:
                Write("@");
                break;      
        }
    }
    Write("\n");
}
#endregion