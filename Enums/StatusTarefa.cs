using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        A_Fazer = 1,
        [Description("Em andamento")]
        Em_Andamento = 2,
        [Description("Concluído")]
        Concluído = 3
    }
}
