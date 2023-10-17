using EstanciasProfesionalesTec.Core.Abstractions;

namespace EstanciasProfesionalesTec.Core.Commons;

public class EntityBase<TKey> : IEntityBase<TKey>
{
    public TKey Id { get; set; } = default!;
    public bool State { get; set; }
    public DateTime CreatedDate { get; set; }
}