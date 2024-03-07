namespace TesteBiblioteca;

class Program
{
    private static void Main(string[] args)
    {       
        Agencia agencia = new Agencia(); 

 
        int menu =0; 
        do{      
        Console.WriteLine("\n\nO que você deseja fazer?");
        Console.WriteLine("1. NOVO");
        Console.WriteLine("2. LISTAR PRODUTOS");
        Console.WriteLine("3. REMOVER PRODUTOS");
        Console.WriteLine("4. ENTRADA ESTOQUE"); 
        Console.WriteLine("5. SAÍDA ESTOQUE"); 
        Console.WriteLine("0. SAIR");
        menu = Convert.ToInt32(Console.ReadLine());
         
        switch(menu) 
         { 

            case 1: 
             
            Veiculo novoVeiculo = new Veiculo();
                 
            Console.WriteLine("\n\nInforme o nome do modelo do carro: ");
            novoVeiculo.Modelo = Console.ReadLine();  

            Console.WriteLine("Informe o valor do carro: "); 
            novoVeiculo.Preco = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Informe a quantidade em estoque: "); 
            novoVeiculo.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe qual o ano do carro: "); 
            novoVeiculo.Ano = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe o nome da marca do carro: "); 
            novoVeiculo.Marca = Console.ReadLine();  

            Console.WriteLine("Informe qual o tipo da direção do carro: "); 
            novoVeiculo.Direcao = Console.ReadLine();  

            Console.WriteLine("Veículo "+ novoVeiculo.Modelo +  " adicionado!");
             
            agencia.Cadastrar(novoVeiculo); 
            break; 

            case 2:   
            Console.WriteLine("\nItens no estoque: ");
            agencia.Listar();
             break;
              

            case 3:  
            Console.WriteLine("\nItens no estoque: ");
            agencia.Listar(); 

            Console.WriteLine("Informe a posição do carro a ser removida: "); 
            int posicao = Convert.ToInt32(Console.ReadLine());  
            

            agencia.Remover(posicao);     

                  
            break; 
 
            case 4: 
             
            Console.WriteLine("\nItens no estoque: ");
            agencia.Listar(); 

            Console.WriteLine("Informe a posição do carro: "); 
            int pos = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe a quantidade de entrada: "); 
            int quant = Convert.ToInt32(Console.ReadLine()); 
             
            agencia.Entrada(pos,quant);

            break;

            case 5: 

            Console.WriteLine("\nItens no estoque: ");
            agencia.Listar(); 

            Console.WriteLine("Informe a posição do carro: "); 
            int posi = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe a quantidade de saída: "); 
            int quanti = Convert.ToInt32(Console.ReadLine()); 
             
            agencia.Saida(posi,quanti);

            break;

          }  
           
        } while (menu !=0);
    }
}