using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Franco", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria", 9.0);
        Alumno alumno3 = new Alumno(3, "Juan", 7.5);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("LISTA DE ALUMNOS");

        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();

        Alumno encontrado = casoList.BuscarAlumnoPorNombre("Maria");

        if (encontrado != null)
        {
            Console.WriteLine("ALUMNO ENCONTRADO:");
            Console.WriteLine(encontrado);
        }

        Console.WriteLine();

        Alumno noExiste = casoList.BuscarAlumnoPorNombre("Pedro");

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine();

        casoList.EliminarAlumno(alumno2);

        Console.WriteLine("LISTA DESPUÉS DE ELIMINAR:");

        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();

        casoList.EliminarAlumnoPorPosicion(0);

        Console.WriteLine("LISTA DESPUÉS DE ELIMINAR EL PRIMER ELEMENTO:");

        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Franco", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria", 9.0);
        Alumno alumno3 = new Alumno(3, "Juan", 7.5);

        casoDictionary.AgregarAlumno(alumno1);
        casoDictionary.AgregarAlumno(alumno2);
        casoDictionary.AgregarAlumno(alumno3);

        Console.WriteLine("DICCIONARIO DE ALUMNOS");

        foreach (KeyValuePair<int, Alumno> item in casoDictionary.RetornarDictionary())
        {
            Console.WriteLine($"Clave: {item.Key} - {item.Value}");
        }

        Console.WriteLine();

        Alumno encontrado = casoDictionary.BuscarAlumno(2);

        if (encontrado != null)
        {
            Console.WriteLine("ALUMNO ENCONTRADO:");
            Console.WriteLine(encontrado);
        }

        Console.WriteLine();

        Alumno noExiste = casoDictionary.BuscarAlumno(10);

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine();

        casoDictionary.EliminarAlumno(2);

        Console.WriteLine("DICCIONARIO DESPUÉS DE ELIMINAR:");

        foreach (KeyValuePair<int, Alumno> item in casoDictionary.RetornarDictionary())
        {
            Console.WriteLine($"Clave: {item.Key} - {item.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO:");
        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine();

        Console.WriteLine("ÚLTIMO LIBRO:");
        Console.WriteLine(casoLinq.GetUltimo());

        Console.WriteLine();

        Console.WriteLine("TOTAL PRECIOS:");
        Console.WriteLine(casoLinq.GetTotalPrecios());

        Console.WriteLine();

        Console.WriteLine("PROMEDIO PRECIOS:");
        Console.WriteLine(casoLinq.GetPromedioPrecios());

        Console.WriteLine();

        Console.WriteLine("LIBROS CON ID > 15:");

        foreach (Libro libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("LIBROS FORMATEADOS:");

        foreach (string texto in casoLinq.GetLibros())
        {
            Console.WriteLine(texto);
        }

        Console.WriteLine();

        Console.WriteLine("LIBRO MÁS CARO:");
        Console.WriteLine(casoLinq.GetMayorPrecio());

        Console.WriteLine();

        Console.WriteLine("LIBRO MÁS BARATO:");
        Console.WriteLine(casoLinq.GetMenorPrecio());

        Console.WriteLine();

        Console.WriteLine("LIBROS MAYORES AL PROMEDIO:");

        foreach (Libro libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("LIBROS ORDENADOS DESC:");

        foreach (Libro libro in casoLinq.GetOrdenadosDesc())
        {
            Console.WriteLine(libro);
        }
    }
}
