namespace EstanciasProfesionalesTec.Core.Abstractions;

public interface IEntityBaseAuditable<TKey> : IEntityBase<TKey>
{
    /// <summary>
    /// Fecha de creación del registro
    /// </summary>
    public DateTime? DateLastModify { get; set; }
}