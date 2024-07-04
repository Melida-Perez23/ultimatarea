
using TareaUltima;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de estudiantes con al menos 5 elementos
        List<Estudiantes> estudiantes = new List<Estudiantes>
        {
            new Estudiantes("MICHELLE", 19, 88 ),
            new Estudiantes( "MICHEAL", 19, 92),
            new Estudiantes("MARTIN", 19, 78 ),
            new Estudiantes("ALEJANDRO", 18, 89 ),
            new Estudiantes( "MELIDA", 17, 95 ),
            new Estudiantes( "JACKELINE", 20, 82 )
        };
        
        List<Estudiantes> estudiantesMayoresEdad = estudiantes.Where(e => e.Edad > 18).ToList();
        Console.WriteLine("Estudiantes mayores de 18 años:");
        foreach (Estudiantes estudiante in estudiantesMayoresEdad)
        {
            Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad}, {estudiante.Nota}");
        }


        var estudiantesMenoresoIgual = estudiantes.Where(e => e.Edad <= 18);
        Console.WriteLine("Estudiantes menores o iguales a 18 años:");
        foreach (var estudiante in estudiantesMenoresoIgual)
        {
            Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad}  {estudiante.Nota}");
        }


        Estudiantes mejornotaEstudiante = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
        Console.WriteLine("\nEstudiante con la nota más alta:");
        Console.WriteLine($"{mejornotaEstudiante.Nombre}, {mejornotaEstudiante.Edad}, {mejornotaEstudiante.Nota}");


        var estudiantePeorNota = estudiantes.OrderBy(e => e.Nota).First();
        Console.WriteLine($"Estudiante con la nota más baja: ");
        Console.WriteLine($" {estudiantePeorNota.Nombre}, {estudiantePeorNota.Edad}, {estudiantePeorNota.Nota}");



        List<Estudiantes> estudiantesOrdenadosalfabeticamente = estudiantes.OrderBy(e => e.Nombre).ToList();
        Console.WriteLine("\nEstudiantes ordenados por nombre:");
        foreach (Estudiantes estudiante in estudiantesOrdenadosalfabeticamente)
        {
            Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad}, {estudiante.Nota}");
        }

        

        double promedioNotasTotal = estudiantes.Average(e => e.Nota);
        Console.WriteLine("\nPromedio de notas:");
        Console.WriteLine($"{promedioNotasTotal.ToString("F2")}");

    }
}