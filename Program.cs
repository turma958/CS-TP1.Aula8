using CS_TP1.Aula8.Exceptions;

namespace CS_TP1.Aula8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tratamento de erros
            //Tratamento de erros

            //try/catch/finally

            //try
            //{
            //    int numero = Convert.ToInt32(Console.ReadLine());
            //    int resultado = 100 / numero;

            //    List<string> strings = null;
            //    Console.WriteLine(strings[0]);

            //    Console.WriteLine(resultado);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Formato de número inválido!");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("O número não pode ser zero!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    //abre arquivo
            //    //manipula

            //    int numero = Convert.ToInt32(Console.ReadLine());

            //    if ((numero % 2) > 0)
            //    {
            //        //throw new Exception("Números ímpares não são aceitos!");
            //        throw new NullReferenceException("Números ímpares não são aceitos!");
            //    }

            //    Console.WriteLine("1");
            //    Console.WriteLine("1");
            //    Console.WriteLine("1");
            //    Console.WriteLine("1");
            //    Console.WriteLine("1");
            //    Console.WriteLine("1");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //fechar
            //    Console.WriteLine("Processo finalizado!");
            //}

            //Console.WriteLine("2");

            ////Console.WriteLine("Processo finalizado!");

            //Console.ReadKey();
            #endregion

            #region MyRegion
            /*
            Você foi contratado para desenvolver um sistema de gerenciamento de 
            estoque para uma loja de eletrônicos. Sua tarefa é criar uma classe 
            Produto que deve ter os seguintes atributos:

            Id (int): o identificador único do produto;
            Nome (string): o nome do produto;
            Preco (double): o preço do produto;
            Quantidade (int): a quantidade em estoque do produto.
            
            Além disso, você deve implementar os seguintes métodos na classe Produto:

            AdicionarQuantidade(int quantidade): adiciona uma determinada quantidade ao estoque do produto. 
            Caso a quantidade informada seja negativa, o método deve lançar uma exceção do tipo ArgumentException 
            com a mensagem "A quantidade informada não pode ser negativa".
            
            RemoverQuantidade(int quantidade): remove uma determinada quantidade do estoque do produto. 
            Caso a quantidade informada seja maior do que a quantidade em estoque, o método deve lançar 
            uma exceção do tipo InvalidOperationException com a mensagem "Não há quantidade suficiente em 
            estoque para remover".
            
            Por fim, você deve criar um programa principal que instancie um objeto Produto, adicione 
            uma quantidade ao estoque e remova outra quantidade. O programa deve tratar os erros que podem 
            ser lançados pelos métodos da classe Produto utilizando os blocos try, catch e finally.

            Requisitos
            -Crie uma classe Produto com os atributos e métodos descritos acima.            
            -Implemente o método AdicionarQuantidade(int quantidade) para adicionar uma determinada 
            quantidade ao estoque do produto. Caso a quantidade informada seja negativa, o método deve 
            lançar uma exceção do tipo ArgumentException com a mensagem "A quantidade informada não pode 
            ser negativa".
            -Implemente o método RemoverQuantidade(int quantidade) para remover uma determinada quantidade 
            do estoque do produto. Caso a quantidade informada seja maior do que a quantidade em estoque, 
            o método deve lançar uma exceção do tipo InvalidOperationException com a mensagem 
            "Não há quantidade suficiente em estoque para remover".
            -Crie um programa principal que instancie um objeto Produto, adicione uma quantidade ao estoque 
            e remova outra quantidade.
            -Utilize os blocos try, catch e finally para tratar os erros que podem ser lançados pelos 
            métodos da classe Produto.
             */

            // Instancia um novo objeto Produto
            Produto produto = new(1, "Serpentina", 15, 50);

            try
            {
                // Adicionar unidades ao estoque
                Console.WriteLine("Digite a quantidade de itens à adicionar:");
                int qtdAdicionar = int.Parse(Console.ReadLine());

                produto.AdicionarQuantidade(qtdAdicionar);

                Console.WriteLine("Digite a quantidade de itens à remover:");
                int qtdRemover = int.Parse(Console.ReadLine());

                produto.RemoverQuantidade(qtdRemover);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Quantidade inválida: {ex.Message}");
            }
            catch (AdicionarException ex)
            {
                Console.WriteLine($"Erro ao adicionar itens: {ex.Message}");
            }
            catch (RemoverException ex)
            {
                Console.WriteLine($"Erro ao remover itens: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro desconhecido: {ex}");
            }
            finally
            {
                Console.WriteLine($"Estoque atual: {produto.Quantidade}");
            }

            Console.ReadLine();
            #endregion


        }        
    }
}