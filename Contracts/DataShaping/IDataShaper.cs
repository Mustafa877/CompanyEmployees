using Entities.Models;
using System.Dynamic;

namespace Contracts.DataShaping;

public interface IDataShaper
{
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeData(IEnumerable<T> entities, string fieldsString);

        ExpandoObject ShapeData(T entity, string fieldsString);
    }
}
