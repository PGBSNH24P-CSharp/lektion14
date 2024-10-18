public class MyList<T> {
    private T[] values = new T[0];

    public void Add(T element) {
        // 1. Skapa ny array (+ 1 storlek)
        // 2. Lägg över alla element
        // 3. Lägg in nytt element
        // 4. Byt ut gammal array

        // 1.
        T[] newArray = new T[values.Length + 1];
        
        // 2.
        for (int i = 0; i < values.Length; i++) {
            newArray[i] = values[i];
        }

        // 3.
        newArray[newArray.Length - 1] = element;

        // 4.
        values = newArray;
    }

    public void RemoveAt(int index) {
        T[] newArray = new T[values.Length - 1];

        int copyIndex = 0;
        for (int i = 0; i < values.Length; i++) {
            if (i == index) {
                continue;
            }

            newArray[copyIndex] = values[i];
            copyIndex++;
        }

        values = newArray;
    }

    public void Remove(T element) {
        for (int i = 0; i < values.Length; i++) {
            T check = values[i];
            if (check.Equals(element)) {
                this.RemoveAt(i);
                return;
            }
        }
    }

    public int Size() {
        return values.Length;
    }

    public T Get(int index) {
        return values[index];
    }

    public void Clear() {
        values = new T[0];
    }
}