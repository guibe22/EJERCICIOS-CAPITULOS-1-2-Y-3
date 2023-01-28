        int numLados;
        double longitudLado;
        double perimetro;

        Console.WriteLine("Ingresa el número de lados del polígono:");
        numLados = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Ingresa la longitud del lado del polígono:");
        longitudLado = double.Parse(Console.ReadLine());

        perimetro = numLados * longitudLado;

      
        Console.WriteLine("El perímetro del polígono es: " + perimetro);
       