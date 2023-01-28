        double grados;
        double radianes;

        
        Console.WriteLine("Ingresa los grados a convertir:");
        grados = double.Parse(Console.ReadLine());

        radianes = grados * (Math.PI / 180);

       
        Console.WriteLine(grados + " grados son " + radianes + " radianes.");