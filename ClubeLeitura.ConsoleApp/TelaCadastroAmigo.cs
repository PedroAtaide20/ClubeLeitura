using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    internal class TelaCadastroAmigo
    {
        public Amigos[] amigos;
        public int numeroAmigos;
        public Notificador notificador;

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Amigo");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovoAmigo()
        {
            MostrarTitulo("Inserindo novo Amigo");

            Amigos amigo = ObterAmigo();

            amigo.idCadastro = ++numeroAmigos;

            int posicaoVazia = ObterPosicaoVazia();
            amigos[posicaoVazia] = amigo;

            notificador.ApresentarMensagem("Amigo inserido com sucesso!", "Sucesso");
        }

        private Amigos ObterAmigo()
        {
            Console.Write("Digite o Nome:");
            string nomeAmigos = Console.ReadLine();

            Console.Write("Digite o nome do Responsavel: ");
            string nomeResponsavel = Console.ReadLine();

            Console.WriteLine(" informe o telefone: ");
            int numeroTelefone = int.Parse(Console.ReadLine());

            Console.WriteLine(" informe o endereço: ");
            string nomeEndereco = Console.ReadLine();

            Amigos amigos = new Amigos();

            amigos.nome = nomeAmigos;
            amigos.nomeResponsavel = nomeResponsavel;
            amigos.telefone = numeroTelefone;
            amigos.endereco = nomeEndereco; 

            return amigos;
        }

        public void EditarAmigos()
        {
            MostrarTitulo("Editando Amigos");

            VisualizarAmigo("Pesquisando");

            Console.Write("Digite o número de amigo que deseja editar: ");
            int numeroAmigos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].idCadastro == numeroAmigos)
                {
                    Amigos amigo = ObterAmigo();

                    amigos[i].idCadastro = numeroAmigos;
                    amigos[i] = amigo;

                    break;
                }
            }

            notificador.ApresentarMensagem("Amigo editado com sucesso", "Sucesso");
        }

        public void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public void ExcluirAmigos()
        {
            MostrarTitulo("Excluindo Amigo");

            VisualizarAmigo("Pesquisando");

            Console.Write("Digite o número de amigo que deseja excluir: ");
            int numeroCaixa = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].idCadastro == numeroCaixa)
                {
                    amigos[i] = null;
                    break;
                }
            }

            notificador.ApresentarMensagem("Amigo excluído com sucesso", "Sucesso");
        }

        public void VisualizarAmigo(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização do nome");

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    continue;

                Amigos c = amigos[i];

                Console.WriteLine("Nome: " + c.nome);
                Console.WriteLine("nomeResponsavel: " + c.nomeResponsavel);
                Console.WriteLine("Telefone: " + c.telefone);
                Console.WriteLine("endereço: " + c.endereco);

                Console.WriteLine();
            }
        }

        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    return i;
            }

            return -1;
        }
}
}
