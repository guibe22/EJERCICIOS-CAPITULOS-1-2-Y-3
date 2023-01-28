double gradosCentigrados;
double gradosFahrenheit;

        
Console.WriteLine("Ingresa los grados centígrados a convertir:");
gradosCentigrados = double.Parse(Console.ReadLine());

    
gradosFahrenheit = (gradosCentigrados * 9 / 5) + 32;

       
 Console.WriteLine(gradosCentigrados + " grados centígrados son " + gradosFahrenheit + " grados Fahrenheit.");