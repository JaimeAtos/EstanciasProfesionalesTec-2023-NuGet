using EstanciasProfesionalesTec.Core.Abstractions;

namespace EstanciasProfesionalesTec.Core.Commons;

public class EntityBaseAuditable<TKey> : EntityBase<TKey>, IEntityBaseAuditable<TKey>
{
    public DateTime? DateLastModify { get; set; }
}