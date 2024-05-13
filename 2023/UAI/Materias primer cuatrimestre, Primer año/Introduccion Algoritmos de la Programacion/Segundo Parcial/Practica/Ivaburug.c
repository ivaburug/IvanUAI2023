#include <stdio.h>

#define NUM_EMPLEADOS 10

struct Empleado {
    int codigo;
    int categoria;
    int antiguedad;
    int mes;
    float sueldo;
};

float obtenerSueldoBasico(int categoria) {
    switch(categoria) {
        case 1:
            return 3000;
        case 2:
            return 2000;
        case 3:
            return 1000;
        case 4:
            return 500;
        default:
            return 0;
    }
}

void ingresarDatos(struct Empleado empleados[]) {
    int i;
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        printf("Ingrese los datos del empleado %d:\n", i + 1);
        printf("Código: ");
        scanf("%d", &empleados[i].codigo);
        printf("Categoría (1-4): ");
        scanf("%d", &empleados[i].categoria);
        if (empleados[i].categoria == 0) {
            break;
        }
        printf("Antigüedad: ");
        scanf("%d", &empleados[i].antiguedad);
        printf("Mes (1-12): ");
        scanf("%d", &empleados[i].mes);
        empleados[i].sueldo = obtenerSueldoBasico(empleados[i].categoria) + 100 * empleados[i].antiguedad;
        printf("\n");
    }
}

void mostrarSueldosPorEmpleado(struct Empleado empleados[]) {
    int i;
    printf("Sueldos pagados por cada empleado:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        printf("Empleado %d - Código: %d, Sueldo: %.2f\n", i + 1, empleados[i].codigo, empleados[i].sueldo);
    }
    printf("\n");
}

void mostrarSueldosPorMes(struct Empleado empleados[]) {
    int i, j;
    float sueldosPorMes[12] = {0};
    printf("Sueldos pagados por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        sueldosPorMes[empleados[i].mes - 1] += empleados[i].sueldo;
    }
    for (j = 0; j < 12; j++) {
        printf("Mes %d: %.2f\n", j + 1, sueldosPorMes[j]);
    }
    printf("\n");
}

void mostrarPromedioPorMes(struct Empleado empleados[]) {
    int i;
    float sueldosPorMes[12] = {0};
    float promedioPorMes[12] = {0};
    printf("Promedio de sueldos por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        sueldosPorMes[empleados[i].mes - 1] += empleados[i].sueldo;
    }
    for (i = 0; i < 12; i++) {
        promedioPorMes[i] = sueldosPorMes[i] / NUM_EMPLEADOS;
        printf("Mes %d: %.2f\n", i + 1, promedioPorMes[i]);
    }
    printf("\n");
}

void mostrarPorcentajeSueldoAnual(struct Empleado empleados[]) {
    int i;
    float sueldoTotal = 0;
    printf("Porcentaje que representa el sueldo anual de cada empleado sobre el total pagado:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        sueldoTotal += empleados[i].sueldo;
    }
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        float porcentaje = (empleados[i].sueldo / sueldoTotal) * 100;
        printf("Empleado %d - Código: %d, Porcentaje: %.2f%%\n", i + 1, empleados[i].codigo, porcentaje);
    }
    printf("\n");
}

void mostrarSueldosOrdenadosPorCategoria(struct Empleado empleados[]) {
    int i, j;
    struct Empleado temp;
    printf("Sueldos ordenados por categoría:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        for (j = i + 1; j < NUM_EMPLEADOS; j++) {
            if (empleados[i].categoria > empleados[j].categoria) {
                temp = empleados[i];
                empleados[i] = empleados[j];
                empleados[j] = temp;
            }
        }
        if (empleados[i].categoria == 0) {
            break;
        }
        printf("Empleado %d - Código: %d, Sueldo: %.2f, Categoría: %d\n", i + 1, empleados[i].codigo, empleados[i].sueldo, empleados[i].categoria);
    }
    printf("\n");
}

void mostrarSueldosMaximosPorMes(struct Empleado empleados[]) {
    int i, j;
    float sueldosMaximosPorMes[12] = {0};
    printf("Sueldos máximos por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        if (empleados[i].sueldo > sueldosMaximosPorMes[empleados[i].mes - 1]) {
            sueldosMaximosPorMes[empleados[i].mes - 1] = empleados[i].sueldo;
        }
    }
    for (j = 0; j < 12; j++) {
        printf("Mes %d: %.2f\n", j + 1, sueldosMaximosPorMes[j]);
    }
    printf("\n");
}

void mostrarSueldosMinimosPorMes(struct Empleado empleados[]) {
    int i, j;
    float sueldosMinimosPorMes[12] = {0};
    int primerEmpleadoPorMes[12] = {0};
    printf("Sueldos mínimos por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        if (primerEmpleadoPorMes[empleados[i].mes - 1] == 0) {
            sueldosMinimosPorMes[empleados[i].mes -
#include <stdio.h>

#define NUM_EMPLEADOS 10

struct Empleado {
    int codigo;
    int categoria;
    int antiguedad;
    int mes;
    float sueldo;
};

float obtenerSueldoBasico(int categoria) {
    switch(categoria) {
        case 1:
            return 3000;
        case 2:
            return 2000;
        case 3:
            return 1000;
        case 4:
            return 500;
        default:
            return 0;
    }
}

void ingresarDatos(struct Empleado empleados[]) {
    int i;
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        printf("Ingrese los datos del empleado %d:\n", i + 1);
        printf("Código: ");
        scanf("%d", &empleados[i].codigo);
        printf("Categoría (1-4): ");
        scanf("%d", &empleados[i].categoria);
        if (empleados[i].categoria == 0) {
            break;
        }
        printf("Antigüedad: ");
        scanf("%d", &empleados[i].antiguedad);
        printf("Mes (1-12): ");
        scanf("%d", &empleados[i].mes);
        empleados[i].sueldo = obtenerSueldoBasico(empleados[i].categoria) + 100 * empleados[i].antiguedad;
        printf("\n");
    }
}

void mostrarSueldosPorEmpleado(struct Empleado empleados[]) {
    int i;
    printf("Sueldos pagados por cada empleado:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        printf("Empleado %d - Código: %d, Sueldo: %.2f\n", i + 1, empleados[i].codigo, empleados[i].sueldo);
    }
    printf("\n");
}

void mostrarSueldosPorMes(struct Empleado empleados[]) {
    int i, j;
    float sueldosPorMes[12] = {0};
    printf("Sueldos pagados por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        sueldosPorMes[empleados[i].mes - 1] += empleados[i].sueldo;
    }
    for (j = 0; j < 12; j++) {
        printf("Mes %d: %.2f\n", j + 1, sueldosPorMes[j]);
    }
    printf("\n");
}

void mostrarPromedioPorMes(struct Empleado empleados[]) {
    int i;
    float sueldosPorMes[12] = {0};
    float promedioPorMes[12] = {0};
    printf("Promedio de sueldos por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        sueldosPorMes[empleados[i].mes - 1] += empleados[i].sueldo;
    }
    for (i = 0; i < 12; i++) {
        promedioPorMes[i] = sueldosPorMes[i] / NUM_EMPLEADOS;
        printf("Mes %d: %.2f\n", i + 1, promedioPorMes[i]);
    }
    printf("\n");
}

void mostrarPorcentajeSueldoAnual(struct Empleado empleados[]) {
    int i;
    float sueldoTotal = 0;
    printf("Porcentaje que representa el sueldo anual de cada empleado sobre el total pagado:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        sueldoTotal += empleados[i].sueldo;
    }
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        float porcentaje = (empleados[i].sueldo / sueldoTotal) * 100;
        printf("Empleado %d - Código: %d, Porcentaje: %.2f%%\n", i + 1, empleados[i].codigo, porcentaje);
    }
    printf("\n");
}

void mostrarSueldosOrdenadosPorCategoria(struct Empleado empleados[]) {
    int i, j;
    struct Empleado temp;
    printf("Sueldos ordenados por categoría:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        for (j = i + 1; j < NUM_EMPLEADOS; j++) {
            if (empleados[i].categoria > empleados[j].categoria) {
                temp = empleados[i];
                empleados[i] = empleados[j];
                empleados[j] = temp;
            }
        }
        if (empleados[i].categoria == 0) {
            break;
        }
        printf("Empleado %d - Código: %d, Sueldo: %.2f, Categoría: %d\n", i + 1, empleados[i].codigo, empleados[i].sueldo, empleados[i].categoria);
    }
    printf("\n");
}

void mostrarSueldosMaximosPorMes(struct Empleado empleados[]) {
    int i, j;
    float sueldosMaximosPorMes[12] = {0};
    printf("Sueldos máximos por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        if (empleados[i].sueldo > sueldosMaximosPorMes[empleados[i].mes - 1]) {
            sueldosMaximosPorMes[empleados[i].mes - 1] = empleados[i].sueldo;
        }
    }
    for (j = 0; j < 12; j++) {
        printf("Mes %d: %.2f\n", j + 1, sueldosMaximosPorMes[j]);
    }
    printf("\n");
}

void mostrarSueldosMinimosPorMes(struct Empleado empleados[]) {
    int i, j;
    float sueldosMinimosPorMes[12] = {0};
    int primerEmpleadoPorMes[12] = {0};
    printf("Sueldos mínimos por mes:\n");
    for (i = 0; i < NUM_EMPLEADOS; i++) {
        if (empleados[i].categoria == 0) {
            break;
        }
        if (primerEmpleadoPorMes[empleados[i].mes - 1] == 0) {
            sueldosMinimosPorMes[empleados[i].mes - 1] = empleados[i].sueldo;
            primerEmpleadoPorMes[empleados[i].mes - 1] = 1;
        } else {
            if (empleados[i].sueldo < sueldosMinimosPorMes[empleados[i].mes - 1]) {
                sueldosMinimosPorMes[empleados[i].mes - 1] = empleados[i].sueldo;
            }
        }
    }
    for (j = 0; j < 12; j++) {
        printf("Mes %d: %.2f\n", j + 1, sueldosMinimosPorMes[j]);
    }
    printf("\n");
}

int main() {
    struct Empleado empleados[NUM_EMPLEADOS];
    ingresarDatos(empleados);
    mostrarSueldosPorEmpleado(empleados);
    mostrarSueldosPorMes(empleados);
    mostrarPromedioPorMes(empleados);
    mostrarPorcentajeSueldoAnual(empleados);
    mostrarSueldosOrdenadosPorCategoria(empleados);
    mostrarSueldosMaximosPorMes(empleados);
    mostrarSueldosMinimosPorMes(empleados);
    return 0;
}
