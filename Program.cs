using Atividade_01.Classes;

Pessoa[] pessoas = new Pessoa[]
{
    new Gerente {
        Name ="Mario",
        Nascimento = new(year:1996, month:5,day:31),
        CodigoFuncionario = 166,
        contratacao = DateTime.Today,
        NumeroFilial = 3,
        hierarquia = "Gerente"
    },
    new Supervisor{
        Name = "Leila",
        Nascimento = new(year:2000, month:9, day:19),
        CodigoFuncionario = 243,
        Setor = "contabilidade",
        hierarquia = "Supervisor"
    },
    new Operario{
        Name= "Nicolas",
        Nascimento = new(year:1975, month:4, day:08),
        CodigoFuncionario = 341,
        Funcao = "motorista",
        contratacao = DateTime.Today,
        hierarquia = "Operário"
    },
    new Operario{
        Name = "Giovana",
        Nascimento = new(year:2001, month:02,day:15),
        CodigoFuncionario = 367,
        Funcao = "secretária",
        contratacao = DateTime.Today,
        hierarquia = "Operário"
    },
    new Supervisor{
        Name = "Marina",
        Nascimento= new(year:1982,month:7,day:16),
        CodigoFuncionario = 444,
        Setor = "Financeiro",
        contratacao = DateTime.Today,
        hierarquia = "Supervisor"
    }

};

for (int i = 0; i<pessoas.Length; i++)
{
    string message = string.Empty;
    if (pessoas[i] != null)
    {
        message= $"\nNome: {pessoas[i].Name}";
        message +=$"\nNascimento: {pessoas[i].Nascimento.ToShortDateString()}";
        message+=$"\n{pessoas[i].hierarquia}";
        message +=$"\nCódigo do funcionário: {pessoas[i].CodigoFuncionario}";
        message +=$"\nContratado desde: {pessoas[i].contratacao.ToShortDateString()}";
        if (pessoas[i] is Gerente)
            {
                Gerente gerente = (Gerente)pessoas[i];
                message +=$"\nGerente filial: {gerente.NumeroFilial}";
            }

        if (pessoas[i] is Supervisor)
            {
                Supervisor supervisor = (Supervisor)pessoas[i];
                message+=$"\nSetor: {supervisor.Setor}";
            }

        if (pessoas[i] is Operario)
            {
                Operario operario = (Operario)pessoas[i];
                message+=$"\nfunção: {operario.Funcao}";
            }
        }
        Console.WriteLine(message);
    }
