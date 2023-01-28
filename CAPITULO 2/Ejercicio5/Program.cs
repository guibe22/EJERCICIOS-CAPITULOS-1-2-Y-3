  double cantidad;
        double tipoCambio;
        string monedaOrigen;
        string monedaDestino;
        double resultado;

      
        Console.WriteLine("Ingresa la cantidad a convertir:");
        cantidad = double.Parse(Console.ReadLine());

      
        Console.WriteLine("Ingresa la moneda origen (USD o EUR):");
        monedaOrigen = Console.ReadLine();

       
        Console.WriteLine("Ingresa la moneda destino (USD o EUR):");
        monedaDestino = Console.ReadLine();

      
        Console.WriteLine("Ingresa el tipo de cambio del día (Ejemplo: 1.18 para 1 EUR = 1.18 USD):");
        tipoCambio = double.Parse(Console.ReadLine());

       
        if (monedaOrigen == "USD" && monedaDestino == "EUR")
        {
            resultado = cantidad / tipoCambio;
        }
        else if (monedaOrigen == "EUR" && monedaDestino == "USD")
        {
            resultado = cantidad * tipoCambio;
        }
        else
        {
            Console.WriteLine("Error: Moneda origen y destino deben ser USD o EUR.");
            return;
        }

    
        Console.WriteLine(cantidad + " " + monedaOrigen + " son " + resultado + " " + monedaDestino + ".");
        Console.ReadLine();