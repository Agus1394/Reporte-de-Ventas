int cantidadVentas; //total de ventas ingresadas
double[] venta;

Console.WriteLine("Ingresar la cantidad de ventas efectuadas: ");
cantidadVentas= Convert.ToInt32(Console.ReadLine());

//guardo las ventas ingresadas en el arreglo
venta= new double[cantidadVentas];

/*
según la cantidad de ventas ingresadas en el arreglo, 
le agrego el monto a cada una de ellas
*/
for (int i= 0; i < cantidadVentas; i++){
    Console.WriteLine("Ingresar el monto de cada venta registrada: ");
    venta[i]=Convert.ToDouble(Console.ReadLine());
}


int opcion=0;
while (opcion != 7){

    Console.WriteLine("-> ELEGIR UNA OPCIÓN: ");
    Console.WriteLine("1) Venta máxima ingresada");
    Console.WriteLine("2) Venta mínima ingresada");
    Console.WriteLine("3) Venta promedio");
    Console.WriteLine("4) Rendimiento por venta");
    Console.WriteLine("5) Máximo rendimiento");
    Console.WriteLine("6) Mínimo rendimiento");
    Console.WriteLine("7) SALIR DEL PROGRAMA");
    
    opcion= Convert.ToInt32(Console.ReadLine());
    switch(opcion){
        case 1:
            calcularVentaMax(venta);
            break;
        case 2:
            calcularVentaMin(venta);
            break;
        case 3:
            calcularVentaPromedio(venta, cantidadVentas);
            break;  
        case 4:
            calcularRendimiento(venta, cantidadVentas);
            break;
        case 5:
            calcularMaximoRendimiento(venta, cantidadVentas);
            break; 
        case 6:
            calcularMinimoRendimiento(venta, cantidadVentas);
            break;
    }
}

/* 1)
Función que calcula la venta MÁXIMA ingresada
*/
static void calcularVentaMax(double[] venta){
    double ventaMaxima= double.MinValue;
    foreach (double cantidadVentas in venta){
        if (cantidadVentas > ventaMaxima){
            ventaMaxima= cantidadVentas;
        }
    }
    Console.WriteLine("La venta máxima es de "+ventaMaxima);
}

/* 2)
Función que calcula la venta MÍNIMA ingresada
*/
static void calcularVentaMin(double[] venta){
    double ventaMinima= double.MaxValue;
    foreach (double cantidadVentas in venta){
        if (cantidadVentas < ventaMinima){
            ventaMinima= cantidadVentas;
        }
    }
    Console.WriteLine("La venta mínima es de "+ventaMinima);
}

/* 3)
Función que calcula el promedio
de la venta ingresada
*/
static void calcularVentaPromedio(double[] venta, int cantidadVentas){
    double totalVentas=1, promedio;
    foreach (double cantidadVenta in venta){
        totalVentas += cantidadVentas;
    }
    promedio=(totalVentas / cantidadVentas);

    Console.WriteLine("El promedio de la venta realizada es "+promedio);
}

/* 4)
Función que calcula el rendimiento
por venta
*/
static void calcularRendimiento(double[] venta, int cantidadVentas){
    double rendimiento;
    for (int i= 1; i < cantidadVentas; i++){
        rendimiento= venta[i] / venta[i-1];
        Console.WriteLine("Venta: "+venta[i]+"\nRendimiento: "+rendimiento);
    }

}

/* 5)
Función que calcula el rendimiento
máximo
*/
static void calcularMaximoRendimiento(double[] venta, int cantidadVentas){
    double rendimiento, rendimientoMax= double.MinValue;

    for (int i= 1; i < cantidadVentas; i++){
        rendimiento= venta[i] / venta[i-1];
        if (rendimiento > rendimientoMax){
            rendimientoMax= rendimiento;
        }
    }

    Console.WriteLine("El rendimiento máximo es de "+rendimientoMax);
}

/* 6)
Función que calcula el rendimiento mínimo
*/
static void calcularMinimoRendimiento(double[]venta, int cantidadVentas){
    double rendimiento, rendimientoMin= double.MaxValue;

    for (int i= 1; i < cantidadVentas; i++){
        rendimiento= venta[i] / venta[i-1];
        if (rendimiento < rendimientoMin){
            rendimientoMin= rendimiento;
        }
    }
    Console.WriteLine("El rendimiento mínimo es de "+rendimientoMin);
}
