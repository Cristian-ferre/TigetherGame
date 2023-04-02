namespace TogetherGame.Application.DTOs.Response
{
    public class UsuarioCadastroResponse
    {

        // A classe possui duas propriedades:

        // "Sucesso": indica se a operação de cadastro foi bem-sucedida. É uma propriedade booleana, que pode ser definida como verdadeira ou falsa.
        // "Erros": é uma lista de strings que contém quaisquer mensagens de erro que possam ter ocorrido durante a operação de cadastro.
        // Além disso, a classe possui três métodos:

        // "UsuarioCadastroResponse()": é um construtor que inicializa a lista de erros.
        // "UsuarioCadastroResponse(bool sucesso = true)": é outro construtor que permite definir o valor da propriedade "Sucesso". Por padrão, o valor da propriedade é "true".
        // "AdicionarErros(IEnumerable<string> erros)": é um método que permite adicionar uma coleção de mensagens de erro à lista existente de erros.
        // Essa classe pode ser utilizada para retornar a resposta de um cadastro de usuário, indicando se a operação foi bem-sucedida e, em caso negativo, quais foram os erros ocorridos.

        public bool Sucesso { get; private set; }
        public List<string> Erros { get; private set; }

        public UsuarioCadastroResponse() =>
            Erros = new List<string>();

        public UsuarioCadastroResponse(bool sucesso = true) : this() =>
            Sucesso = sucesso;

        public void AdicionarErros(IEnumerable<string> erros) =>
            Erros.AddRange(erros);
    }
}