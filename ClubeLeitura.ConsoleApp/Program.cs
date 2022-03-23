/**
 * O sistema deve permirtir o usuário escolher qual opção ele deseja
 *  -Para acessar o cadastro de caixas, ele deve digitar "1"
 *  -Para acessar o cadastro de revistas, ele deve digitar "2"
 *  -Para acessar o cadastro de amigquinhos, ele deve digitar "3"
 *  
 *  -Para gerenciar emprestimos, ele deve digitar "4"
 *  
 *  -Para sair, usuário deve digitar "s"
 */
using System;

namespace ClubeLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();
            TelaCadastroCaixa telaCadastroCaixa = new TelaCadastroCaixa();
            TelaCadastroAmigo telaCadastroAmigo = new TelaCadastroAmigo();
            telaCadastroAmigo.amigos = new Amigos[10];
            telaCadastroCaixa.caixas = new Caixa[10];
            telaCadastroCaixa.notificador = new Notificador();

            while (true)
            {                
                string opcaoMenuPrincipal = menuPrincipal.MostrarOpcoes();

                if (opcaoMenuPrincipal == "1")
                {
                    string opcao = telaCadastroCaixa.MostrarOpcoes();

                    if (opcao == "1")
                    {
                        telaCadastroCaixa.InserirNovaCaixa();
                    }
                    else if (opcao == "2")
                    {
                        telaCadastroCaixa.EditarCaixa();
                    }
                    else if (opcao == "3")
                    {
                        telaCadastroCaixa.ExcluirCaixa();
                    }
                    else if (opcao == "4")
                    {
                        telaCadastroCaixa.VisualizarCaixas("Tela");
                        Console.ReadLine(); 
                    }
                }
                if (opcaoMenuPrincipal == "2")
                {
                    string opcao = telaCadastroAmigo.MostrarOpcoes();

                    if (opcao == "1")
                    {
                        telaCadastroAmigo.InserirNovoAmigo();   
                    }
                    else if (opcao == "2")
                    {
                        telaCadastroAmigo.EditarAmigos();
                    }
                    else if (opcao == "3")
                    {
                        telaCadastroAmigo.ExcluirAmigos();
                    }
                    else if (opcao == "4")
                    {
                        telaCadastroAmigo.VisualizarAmigo("Tela");
                        Console.ReadLine();
                    }
                }
            }       

        }       
    }
}
