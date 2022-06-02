// See https://aka.ms/new-console-template for more information
Console.WriteLine("Consultorio Medico");

/* 
    _ -------    MODELAGEM LÓGICA -------------
    objetivo do sistema gerenciar  consultas e os CRUD
    - Paciente (codigoPaciente, nome, ...)
    - Medico (codigoMedico, nome, ...)
    - EspecialidadeMedica (codigoEspecialidade, descrição)
    - MedicoEspecialista (codigoMedico, codigoEspecialidade)
    o codigoMedico é chave estrageira referencia Medico
    o codigoEspecialidade é chave estrangeira referencia especialidadeMedica
    - Convenio (codigoConvenio, nome)
    - MedicoConvenioi (codigoMedico, codigoConvenio)
*/
public class Convenio
{
    int codigoConvenio;
    string nome;
}

// construtores

// get e setters
public class Paciente
{
    int codigoPaciente;
    string nome;
}

// construtores

// get e setters

public class Medico
{
    int codigoNome;
    string nome;

    public int CodigoNome { get => codigoNome; set => codigoNome = value; }
    public string Nome { get => nome; set => nome = value; }
}

// construtores

// get e setters