namespace EstanciasProfesionalesTec.Core.Abstractions;

/// <summary>
/// Definición para las entidades base del patron de repositorio y restricciones de tipos genericos
/// </summary>
public interface IEntityBase : IBase { }
/// <summary>
/// Definición para las entidades base del patron de repositorio
/// </summary>
/// <typeparam name="TKey">Tipo de dato que identificara el registro</typeparam>
public interface IEntityBase<TKey> : IBase<TKey>, IEntityBase { }