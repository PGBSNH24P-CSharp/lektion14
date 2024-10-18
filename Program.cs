namespace lektion14;

class Program {
    static void Main(string[] args) {
        MyList<string> countries = new MyList<string>();

        countries.Add("Sweden");
        countries.Add("Norway");
        countries.Add("Finland");
        countries.Add("Denmark");
        countries.Add("Iceland");

        countries.RemoveAt(1);
        countries.RemoveAt(2);
        countries.Remove("Finland");

        for (int i = 0; i < countries.Size(); i++) {
            Console.WriteLine(countries.Get(i));
        }
    }
}

/*
public interface ISomeInterface {
    void DoSomething();
}

public class SomeClass : ISomeInterface
{
    public void DoSomething() {}
}

class Program
{
    public static Optional<SomeClass> GetSomeValue() {
        Random random = new Random();
        if (random.NextDouble() < 0.5) {
            return Optional<SomeClass>.Empty();
        } else {
            return Optional<SomeClass>.Of(new SomeClass());
        }
    }

    static void Main(string[] args) { 
        // Klasser
        // Metoder
        // Constraints

        // Optional
        // Sök i array

        // Fel, eftersom 'int' inte ärver ifrån 'ISomeInterface'
        MyList<int> numbers;
        // Fel, eftersom 'string' inte ärver ifrån 'ISomeInterface'
        MyList<string> text;
        // Ok
        MyList<SomeClass> someList;

        PrintValue<string>("Hej!");
        PrintValue<int>(5);
        PrintValue<Random>(new Random());

        int? value;

        MyDictionary<string, int> dict;
        MyDictionary<double, Random> dict2;

        Optional<SomeClass> optional = GetSomeValue();
        if (optional.IsEmpty()) {
            Console.WriteLine("Value is null");
            return;
        }

        SomeClass actualValue = optional.Get();

        //
        SomeClass? someValue = SomeFunction();

        Contains([1, 2, 3, 4], 5);
    }

    public static bool Contains<T>(T[] array, T value) {
        foreach (T all in array) {
            if (all.Equals(value)) {
                return true;
            }
        }

        return false;
    }

    public static void PrintValue<T>(T value) {
        Console.WriteLine(value);
    }
}

public class MyDictionary<K, V> {}

public class MyList<T> where T : ISomeInterface {
    T[] nums;

    public void Add() {
        nums[0].DoSomething();
    }

    public void Remove() {}
}*/