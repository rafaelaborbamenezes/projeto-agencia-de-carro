using System.Collections.Specialized;

class Agencia { 
         
        Veiculo[] veiculos = new Veiculo[0];   

        //1 cadastrar produto 
        public void Cadastrar(Veiculo veiculo){ 
            Veiculo[] novoVetor = new Veiculo[veiculos.Length +1]; 
            for (int pos = 0; pos < veiculos.Length; pos++)  
              {
                Veiculo item = veiculos[pos]; 
                novoVetor[pos] = item;      
              } 
               novoVetor[novoVetor.Length-1] = veiculo; 
                         
                         
                veiculos = novoVetor; 
                 
         }//2 listar produtos
         public void Listar() {   
              int cont =1;
              foreach(Veiculo item in veiculos){ 
              
              Console.WriteLine($"{cont}. {item.Modelo} (R$ {item.Preco}) - {item.QuantidadeEstoque} no estoque"); 
              cont++; 
             }
         
        } // 3 remover produtos  
        public void Remover(int posicao){  
           
        if (posicao >= 1 && posicao <= veiculos.Length)
        {
        Veiculo[] novoVetor = new Veiculo[veiculos.Length - 1];

        for (int i = 0, j = 0; i < veiculos.Length; i++)
        {
            if (i != posicao - 1)
            {
                novoVetor[j++] = veiculos[i];
            }
        }

        veiculos = novoVetor;

        Console.WriteLine("Veículo de posição " + posicao + " removido.");
        }
        else
        {
        Console.WriteLine("Posição inválida. Certifique-se de fornecer uma posição válida no intervalo do vetor.");
        }
            

        
        } // 4 entrada estoque 
        public void Entrada(int pos, int quant){ 

           Veiculo veiculo = veiculos[pos-1]; 
           veiculo.QuantidadeEstoque += quant;

        } // 5 saída estoque 
          public void Saida(int posi, int quanti){ 

           Veiculo veiculo = veiculos[posi-1]; 
           veiculo.QuantidadeEstoque -= quanti; 
          }
        }