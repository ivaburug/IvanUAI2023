#include <stdio.h>
#include <stdlib.h>

int main() {
    int CantVal, val, CantValPos = 0, CantValNeg = 0, CantValCer = 0, SumValPos = 0, SumValNeg = 0, CantVec = 0;
    float ProPos = 0, ProNeg = 0;

    printf("Ingrese la cantidad de valores a ingresar: ");
    scanf("%d", &CantVal);

    while (CantVec < CantVal) 
	{
        printf("Ingrese un valor: ");
        scanf("%d", &val);

        if (val == 0) 
        {
            CantValCer++;
        }
        if (val > 0) 
        {
            CantValPos++;
            SumValPos += val;
            ProPos = (float)SumValPos / CantValPos;
        }
        else 
        {
            CantValNeg++;
            SumValNeg += val;
            ProNeg = (float)SumValNeg / CantValNeg;
        }
        CantVec++;
    }

    if (CantValPos > 0) 
    {
        printf("El promedio de los valores positivos es: %.2f\n", ProPos);
    }
    else 
    {
        printf("No se ingresaron valores positivos.\n");
    }
    if (CantValNeg > 0) 
    {
        printf("El promedio de los valores negativos es: %.2f\n", ProNeg);
    }
    else 
    {
        printf("No se ingresaron valores negativos.\n");
    }

    printf("La cantidad de valores iguales a cero ingresados es: %d\n", CantValCer);

    return 0;
}