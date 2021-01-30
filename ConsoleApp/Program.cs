using BooksApp.Data;
using System;
using System.Linq;
using BooksApp.Domain;

namespace ConsoleApp
{
    class Program
    {
        private static BooksContext context = new BooksContext();
        static void Main(string[] args)
        {
            char lectura; do
            {
                Console.WriteLine("[A]gregar autor | [M]odificar autor | [E]liminar autor | [V]erautores | [S]alir"); Console.Write("Selecciona una opción: "); lectura = Char.ToUpper(Console.ReadKey().KeyChar); Console.WriteLine(); switch (lectura)
                {
                    case 'A': AddAuthor(); break;
                    case 'M': ModifyAuthor(); break;
                    case 'E': DeleteAuthor(); break;
                    case 'V': ShowAuthors("Autores registrados"); break;
                    case 'S': Console.WriteLine("Adiós. Programa finalizado."); break;
                    default: break;
                }
                Console.WriteLine();
            } while (lectura != 'S'); Console.WriteLine("");

        }

        private static void ShowAuthors(string text)
        {
            var authors = context.Authors.ToList();
            Console.WriteLine(value: $"{text}: Se han registrado {authors.Count} autores.");
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName);
            }
        }

        private static void DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        private static void ModifyAuthor()
        {
            throw new NotImplementedException();
        }

        private static void AddAuthor()
        {
            Console.WriteLine("Agregando un autor.");
            Console.Write("Nombres: ");
            string firstName = Console.ReadLine();
            Console.Write("Apellidos: ");
            string lastName = Console.ReadLine();
            var author = new Author { FirstName = firstName, LastName = lastName };
            context.Authors.Add(author); context.SaveChanges();
        }
    }
}
