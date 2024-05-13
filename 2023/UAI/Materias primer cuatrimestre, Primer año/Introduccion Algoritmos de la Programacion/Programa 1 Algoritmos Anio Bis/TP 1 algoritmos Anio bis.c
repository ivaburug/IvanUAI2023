#include <stdio.h>
#include <stdlib.h>


/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//funcion

int bisiesto(int);//declaro funci�n


int main(int argc, char *argv[]) 
{
	int Dia,Mes,Anio,bis=0;
	printf("\nIngrese una fecha: ");

//Se declaran los valores que va  a tener cada parte de la fecha en orden

	scanf("%d", &Dia);
	scanf("%d", &Mes);
	scanf("%d", &Anio);
	
//Este es el primer filtro, donde vemos si el dia, el mes o el anio son menores, con esto ya sabemos minimamente si la fecha ingresada es correcta o no
	
	if(Dia<0)
	{
		printf("\nDia Erroneo");return 0;
	}

	if(Mes<0)
	{
		printf("\nMes Erroneo");return 0;
	}
	
	if(Anio<0)
	{
		printf("\nAnio Erroneo");return 0;
	}
	
//Aca se llama a la funcion bisiesto y le da como dato el anio, luego esto te tira un resultado similar a un booleano, va a dar 1 en caso de que el anio sea bisiesto y 0 en caso de que no lo sea
	bis=bisiesto(Anio);

switch (Mes)
//Este switch se usa para saber si el dia esta bien respecto al mes, en caso de que el mes sea 2 tenemos que ver antes si el anio es bisiesto o no
{
	case 2:
		if (bis==1)
		{ 
			if (Dia<=29)
			
			{
				printf("\nFecha valida");
			}
			
			else 
			
			{
				printf("\nFecha NO Valida");
			}
		}
		else
		{
		if (Dia<=28)
			
			{
				printf("\nFecha valida");
			}
			
			else 
			
			{
				printf("\nFecha NO Valida");
			}	
		}
		break;

//Aca vemos si el mes vale 4, 6, 9 o 11, si este es el caso y el dia vale 30 o menos la fecha esta bien
		
	case 4: case 6: case 9: case 11:
		
		
		if (Dia<=30)
		{
				printf("\nFecha valida");
		}
		else
		{
	     		printf("\nFecha NO valida");
		}
		
		break;
		
//Aca vemos si el mes es 1, 3, 5, 7, 8, 10, 12, si este es el caso y el dia es 31 o menor la fecha esta bien	
		
	case 1: case 3: case 5: case 7: case 8: case 10: case 12:
		if (Dia<=31)
		{
				printf("\nFecha valida");
		}
		else
		{
	     		printf("\nFecha NO valida");
		}
		break;
		default: 
		printf("\nERROR de fecha");
		break;	
		}
	return 0;
}

//Esta es la funcio a la que se llama mas arriba en el codigo "bis=bisiesto(Anio);", se calcula si el anio es bisiesto y te devuelve un 1 o un 0 como se explico arriba

int bisiesto(int valor)
{
	int bis=0;
	if(valor%4==0 && valor%100!=0 || valor%400==0)
	{
		printf("\nEl anio %d bisiesto",valor);
		bis=1;
	}
	else
	{
		printf("\n El anio %d No es bisiesto",valor);
		bis=0;
	}
	return bis;	
}
