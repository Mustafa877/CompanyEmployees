using Entities.Models;
using System.Dynamic;

namespace Contracts.DataShaping;

public interface IDataShaper
{
    public interface IDataShaper<T>
    {
        IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString);

        Entity ShapeData(T entity, string fieldsString);
    }
}
