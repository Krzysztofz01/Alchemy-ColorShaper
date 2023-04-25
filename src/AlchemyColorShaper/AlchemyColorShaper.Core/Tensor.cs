using System;
using System.Linq;

namespace AlchemyColorShaper.Core;

internal sealed class Tensor<T>
{
    private readonly int _size;
    private readonly T[,,] _values;

    private Tensor()
    {
        _size = 0;
        _values = new T[_size, _size, _size];
    }

    public Tensor(int size, T initValue)
    {
        _size = size;
        _values = new T[_size, _size, _size];

        foreach (var x in Enumerable.Range(0, _size))
        {
            foreach (var y in Enumerable.Range(0, _size))
            {
                foreach (var z in Enumerable.Range(0, _size))
                {
                    _values[x, y, z] = initValue;
                }
            }
        }
    }

    public Tensor(int size, Func<T> initValue)
    {
        _size = size;
        _values = new T[_size, _size, _size];

        foreach (var x in Enumerable.Range(0, _size))
        {
            foreach (var y in Enumerable.Range(0, _size))
            {
                foreach (var z in Enumerable.Range(0, _size))
                {
                    _values[x, y, z] = initValue();
                }
            }
        }
    }

    public void SetValue(int x, int y, int z, T value)
    {
        if (!AreIndexesValid(x, y, z))
            throw new ArgumentException("The specified indexes are out of range of the tensor.");

        _values[x, y, z] = value;
    }

    public void SetValue(int x, int y, int z, Func<T, T> expression)
    {
        if (!AreIndexesValid(x, y, z))
            throw new ArgumentException("The specified indexes are out of range of the tensor.");

        var expressionResult = expression(_values[x, y, z]);
        _values[x, y, z] = expressionResult;
    }

    public T GetValue(int x, int y, int z)
    {
        if (!AreIndexesValid(x, y, z))
            throw new ArgumentException("The specified indexes are out of range of the tensor.");

        return _values[x, y, z];
    }

    private bool AreIndexesValid(int x, int y, int z)
    {
        if (x >= _size) return false;
        if (y >= _size) return false;
        if (z >= _size) return false;

        return true;
    }
}
