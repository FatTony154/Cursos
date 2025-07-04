﻿MyList<int> numbers = new MyList<int>(10);
numbers.Add(10);
numbers.Add(6);

MyList<string> strings = new MyList<string>(10);
strings.Add("Antonio");

MyList<People> people = new MyList<People>(5);
people.Add(new People() {Name = "Antonio", Country= "Mexico"});
people.Add(new People() {Name = "Jose", Country= "Turquia"});

Console.WriteLine(numbers.GetString());
Console.WriteLine(strings.GetString());
Console.WriteLine(people.GetString());

Console.WriteLine(numbers.GetElement(11));
Console.WriteLine(strings.GetElement(0));


public class People
{
    public string Name { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, Country: {Country}";
    }
}

public class MyList<T>
{
    private T[] _elements;
    private int _index = 0;

    public MyList(int n)
    {
        _elements = new T[n];
    }

    public void Add(T e)
    {
        if (_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }

    public T GetElement(int i)
    {
        if (i <= _index && i >= 0)
        {
            return _elements[i];
        }
        
        return default(T);
    }

    public string GetString()
    {
        int i = 0;
        string result = "";
        
        while (i < _index)
        {
            result += _elements[i].ToString() + "|";
            i++;
        }
        return result;
    }
}