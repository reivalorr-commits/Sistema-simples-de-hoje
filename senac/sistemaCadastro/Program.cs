using sistemaCadastro;

List<Usuario> usuario = new List<Usuario>();
List<Cliente> clientes = new List<Cliente>();
List<Aluno> alunos = new List<Aluno>();
List<Disciplina> disciplinas = new List<Disciplina>
{
    new Disciplina { Codigo = "CS101", Nome = "Programação orientada a objetos", CargaHoraria = 80}
};
bool executando = true;

while (executando == true) { 
    Console.WriteLine("============================");
    Console.WriteLine("SISTEMA CADASTRO");
    Console.WriteLine("============================");
    Console.WriteLine("1 - Cadastrar nome");
    Console.WriteLine("2 - Listar usuarios");
    Console.WriteLine("3 - Cadastrar clintes");
    Console.WriteLine("4 - Listar clientes");
    Console.WriteLine("5 - Cadastrar aluno");
    Console.WriteLine("6 - Listar alunos");
    Console.WriteLine("7 - Matricular aluno na disciplina");
    Console.WriteLine("8 - Listar todas as pessoas");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opção");
    // só para não travar o pc
    string nome = Console.ReadLine();
    if (nome == "1") { 
        executando &= false;
    }
}