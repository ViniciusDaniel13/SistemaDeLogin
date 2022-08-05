using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaLogin
{
    public class Program
    {
        static void Main(string[] args)
        {
            string UsuarioCadastro;
            string SenhaCadastro;
            string Usuario;
            string Senha;

            Console.WriteLine("Insira o usuário para cadastrar:");
            UsuarioCadastro = Console.ReadLine();

            Console.WriteLine("Insira a senha para cadastrar:");
            SenhaCadastro = Console.ReadLine();

            Console.WriteLine("Usuário cadastrado com sucesso");
            Console.Clear();

            Usuario:
            Console.WriteLine("Insira a usuario:");
            Usuario = Console.ReadLine();

            Console.WriteLine("Insira a senha:");
            Senha = Console.ReadLine();

            if (Usuario == UsuarioCadastro && Senha == SenhaCadastro)
                Console.WriteLine($"Bem vindo {Usuario}");
            else
            {
                Console.WriteLine("usuario ou senha incorreto");
                Thread.Sleep(2000);
                Console.Clear();

                goto Usuario;
            }
            Console.ReadKey();
        }
    }
}
