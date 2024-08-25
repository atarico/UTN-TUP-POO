using Escuela.Modelos;

namespace Escuela
{
    class Program
    {
        static void Main() 
        {
            Administrador unAdmin = new Administrador("Pepito", 15);
            Modelos.Escuela unaEscuela = new Modelos.Escuela("Escuela de Programación", unAdmin);

            Profesor profesor1 = new Profesor("María");
            profesor1.Añadir(new Materia("Matemáticas", 5));

            Aula aula1 = new Aula("Aula 1", profesor1);
            aula1.Añadir(new Estudiante("Juancho", 8));


            Profesor profesor2 = new Profesor("Juan");
            profesor2.Añadir(new Materia("Programación", 5));

            Aula aula2 = new Aula("Aula 2", profesor2);
            aula2.Añadir(new Estudiante("Elena", 10));
        }
    }
}
