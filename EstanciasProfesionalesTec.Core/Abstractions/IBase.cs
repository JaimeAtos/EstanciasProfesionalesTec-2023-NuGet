namespace EstanciasProfesionalesTec.Core.Abstractions;

/// <summary>
/// Define la estructura base para las entidades y dto y tipos genericos
/// </summary>
public interface IBase { }
/// <summary>
/// Define la estructura base para las entidades y dto
/// </summary>
/// <typeparam name="TKey">Tipo de dato que identificara el registro</typeparam>
public interface IBase<TKey> : IBase
{
    /// <summary>
    /// Id del registro
    /// </summary>
    public TKey Id { get; set; }
    /// <summary>
    /// Estado del registro, aclarando si esta activo o borrado
    /// </summary>
    public bool State { get; set; }
    /// <summary>
    /// Fecha de creación del registro
    /// </summary>
    public DateTime CreatedDate { get; set; }
    
}