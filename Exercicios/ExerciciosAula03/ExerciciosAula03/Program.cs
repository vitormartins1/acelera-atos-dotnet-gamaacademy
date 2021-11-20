/*
Execute o programa abaixo, e adicione comentários sobre a saida do mesmo.
você deve transcrever a saída nos comentários, e explicar porque a saída foi esta.

class PassandoParametrosReferencia
{
    static void Muda(int[] pArray)
    {
        pArray[0] = 888;  
        pArray = new int[5] { -3, -1, -2, -3, -4 };   
        System.Console.WriteLine("Dentro do metodo muda, o primeiro elemento é: {0}", pArray[0]);
    }

    static void Main()
    {
        int[] arr = { 1, 4, 5 };
        System.Console.WriteLine("Dentro do Main, antes de chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);

        Muda(arr);
        System.Console.WriteLine("Dentro do Main, apos chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);
    }
}
*/

class PassandoParametrosReferencia
{
    static void Muda(int[] pArray)
    {
        pArray[0] = 888;
        pArray = new int[5] { -3, -1, -2, -3, -4 };
        // O primeiro indice de pArray[] é -3 pois quando foi atribuido um novo Array e novos valores
        // para o Array pArray[] o parametro foi iniciado como um novo endereço de memoria
        System.Console.WriteLine("Dentro do metodo muda, o primeiro elemento é: {0}", pArray[0]);
    }

    static void Main()
    {
        int[] arr = { 1, 4, 5 };

        // Como o metodo Muda não foi chamado ainda, o Array arr[] não foi alterado ainda
        // Logo seu valor do primeiro indice ainda é 1 pois está inalterado
        System.Console.WriteLine("Dentro do Main, antes de chamar o " +
            "metodo muda, o primeiro elemento é: {0}", arr[0]);

        Muda(arr);

        // Dentro do metodo Muda() o Array array[] é passado como referencia do endereço de memoria
        // e mapeado referenciado no pArray[]
        // logo quando atribuimos o valor 888 ao primeiro elemento de pArray[], estamos na verdade
        // alterando o endereço de memoria referente ao Array arr[] e mudando seu primeiro elemento tambem
        // Quando iniciamos um novo Array em pArray[] um novo endereço de memoria é criado para essa variavel
        // interna, fazendo com que ela perca a referência de arr[], porém mantem a alteração anterior
        // feita no primeiro elemento de arr[]
        System.Console.WriteLine("Dentro do Main, apos chamar o " +
            "metodo muda, o primeiro elemento é: {0}", arr[0]);
    }
}