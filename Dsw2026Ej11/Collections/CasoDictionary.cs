using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    // Diccionario: clave = legajo(Id), valor = Alumno
    private Dictionary<int, Alumno> alumnos;

    // Constructor
    public CasoDictionary()
    {
        alumnos = new Dictionary<int, Alumno>();
    }

    // Agregar alumno
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }

    // Buscar alumno por clave
    public Alumno BuscarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            return alumnos[legajo];
        }

        return null;
    }

    // Retornar diccionario
    public Dictionary<int, Alumno> RetornarDictionary()
    {
        return alumnos;
    }

    // Eliminar alumno por clave
    public void EliminarAlumno(int legajo)
    {
        alumnos.Remove(legajo);
    }
}
