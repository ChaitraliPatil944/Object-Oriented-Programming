# Lesson 94 — Generic Classes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Generic Class** is a class that is parameterized with one or more **type parameters**. Instead of working with a fixed data type, it can operate on different reference types while maintaining **compile-time type safety**.

Generic classes eliminate duplicate code and are widely used in the Java Collections Framework.

Examples:

- `ArrayList<E>`
- `HashMap<K, V>`
- `HashSet<E>`

---

# 2. Why Do We Need Generic Classes?

Without generic classes, developers often create multiple versions of the same class for different data types.

Example:

```text
IntegerBox
StringBox
DoubleBox
```

This leads to code duplication.

With a generic class:

```text
Box<T>

Box<Integer>
Box<String>
Box<Double>
```

A single implementation supports multiple data types.

---

# 3. Declaring a Generic Class

Syntax:

```java
class ClassName<T> {

}
```

Example:

```java
class Box<T> {

    private T value;

    public void setValue(T value) {
        this.value = value;
    }

    public T getValue() {
        return value;
    }
}
```

---

# 4. Using a Generic Class

```java
public class Demo {

    public static void main(String[] args) {

        Box<String> box1 = new Box<>();
        box1.setValue("Java");

        Box<Integer> box2 = new Box<>();
        box2.setValue(100);

        System.out.println(box1.getValue());
        System.out.println(box2.getValue());
    }
}
```

Output:

```text
Java
100
```

---

# 5. Multiple Type Parameters

A generic class can have multiple type parameters.

```java
class Pair<K, V> {

    private K key;
    private V value;

    Pair(K key, V value) {
        this.key = key;
        this.value = value;
    }

    K getKey() {
        return key;
    }

    V getValue() {
        return value;
    }
}
```

Usage:

```java
Pair<Integer, String> student =
        new Pair<>(101, "Alice");
```

---

# 6. Generic Class with Collections

```java
import java.util.ArrayList;

class DataStore<T> {

    private ArrayList<T> data = new ArrayList<>();

    void add(T item) {
        data.add(item);
    }

    T get(int index) {
        return data.get(index);
    }
}
```

This allows the class to store any reference type safely.

---

# 7. Generic Class vs Normal Class

| Feature | Generic Class | Normal Class |
|---------|---------------|--------------|
| Data Type | Flexible | Fixed |
| Reusability | High | Low |
| Type Safety | Compile-time | Often requires casting |
| Code Duplication | Minimal | Higher |

---

# 8. Restrictions

Generic classes:

- Cannot use primitive types directly.
- Cannot create objects using `new T()`.
- Cannot declare static fields of type `T`.
- Support only reference types.

Invalid:

```java
Box<int> box;
```

Correct:

```java
Box<Integer> box;
```

---

# 9. Advantages

- Reusable code
- Compile-time type checking
- Eliminates explicit casting
- Better readability
- Reduced runtime errors

---

# 10. Best Practices

- Use meaningful type parameters (`T`, `E`, `K`, `V`).
- Prefer generic classes over raw types.
- Keep generic classes focused on a single responsibility.
- Use wrapper classes for primitive values.

---

# 11. Common Mistakes

❌ Using raw types:

```java
Box box = new Box();
```

❌ Mixing different types in the same generic object.

❌ Expecting generic classes to work with primitive types.

---

# 12. Interview Questions

1. What is a generic class?
2. Why are generic classes useful?
3. Can a generic class have multiple type parameters?
4. Why can't generic classes use primitive types?
5. What are raw types?

---

# 13. Quick Revision

```text
Generic Class
│
├── Type Parameter
├── Reusable
├── Type Safe
├── Multiple Types
└── Collections
```

---

# 14. Interview Cheat Sheet

```text
Generic Class
│
├── class Box<T>
├── class Pair<K, V>
├── Compile-Time Type Safety
├── No Explicit Casting
└── Used in Collections Framework
```

---

# 15. Summary

Generic classes enable Java developers to write reusable, flexible, and type-safe classes that work with different reference types without duplicating code. They reduce runtime errors, eliminate unnecessary casting, and are a core feature of the Java Collections Framework. Mastering generic classes is essential for modern Java development and technical interviews.
