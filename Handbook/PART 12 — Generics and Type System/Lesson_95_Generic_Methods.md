# Lesson 95 — Generic Methods

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Generic Method** is a method that introduces its own **type parameter**, allowing it to work with different data types independently of the class.

Unlike a generic class, where the entire class is parameterized, a generic method can exist in both **generic and non-generic classes**.

Generic methods improve **code reusability**, **type safety**, and **flexibility**.

---

# 2. Why Do We Need Generic Methods?

Without generic methods, we may need separate methods for different data types.

Example:

```java
void printString(String value) { }

void printInteger(Integer value) { }

void printDouble(Double value) { }
```

This leads to duplicate code.

With a generic method:

```java
<T> void print(T value)
```

One method can handle all reference types.

---

# 3. Syntax of a Generic Method

```java
public <T> returnType methodName(T parameter) {

}
```

The type parameter (`<T>`) is declared **before** the return type.

---

# 4. Simple Generic Method Example

```java
class Printer {

    public <T> void print(T value) {
        System.out.println(value);
    }
}
```

Using the method:

```java
Printer printer = new Printer();

printer.print("Java");
printer.print(100);
printer.print(99.5);
```

Output:

```text
Java
100
99.5
```

---

# 5. Generic Method with Return Type

```java
class Utility {

    public <T> T getValue(T value) {
        return value;
    }
}
```

Usage:

```java
Utility util = new Utility();

String name = util.getValue("Alice");
Integer age = util.getValue(21);

System.out.println(name);
System.out.println(age);
```

---

# 6. Multiple Type Parameters

A generic method can declare multiple type parameters.

```java
class PairPrinter {

    public <K, V> void print(K key, V value) {

        System.out.println(key + " : " + value);
    }
}
```

Usage:

```java
PairPrinter obj = new PairPrinter();

obj.print(101, "Alice");
obj.print("Salary", 50000);
```

---

# 7. Generic Methods in Generic Classes

A generic class may also contain generic methods.

```java
class Box<T> {

    private T value;

    public Box(T value) {
        this.value = value;
    }

    public T getValue() {
        return value;
    }

    public <U> void display(U data) {
        System.out.println(data);
    }
}
```

Here:

- `T` belongs to the class.
- `U` belongs only to the method.

---

# 8. Generic Method vs Generic Class

| Generic Method | Generic Class |
|---------------|---------------|
| Type parameter belongs to method | Type parameter belongs to class |
| Can exist in any class | Entire class is generic |
| Flexible for individual operations | Flexible for entire object |

---

# 9. Advantages

- Eliminates duplicate methods
- Compile-time type checking
- Reusable code
- Better readability
- Reduces casting

---

# 10. Best Practices

- Keep generic methods focused on a single task.
- Use meaningful type parameter names.
- Prefer generic methods over overloaded methods when appropriate.
- Avoid raw types.

---

# 11. Common Mistakes

❌ Forgetting to declare `<T>` before the return type.

Incorrect:

```java
public T display(T value)
```

Correct:

```java
public <T> T display(T value)
```

❌ Confusing class type parameters with method type parameters.

---

# 12. Interview Questions

1. What is a generic method?
2. How is a generic method different from a generic class?
3. Can a generic method exist inside a non-generic class?
4. Can a generic method have multiple type parameters?
5. Why are generic methods useful?

---

# 13. Quick Revision

```text
Generic Method
│
├── <T>
├── Reusable
├── Type Safe
├── Can Return Generic Type
└── Can Use Multiple Type Parameters
```

---

# 14. Interview Cheat Sheet

```text
Generic Method

public <T> void print(T value)

✔ Declares its own type parameter
✔ Works with multiple data types
✔ Can exist in generic & non-generic classes
✔ Eliminates duplicate methods
```

---

# 15. Summary

Generic methods allow Java developers to create flexible, reusable methods that work with multiple reference types while maintaining compile-time type safety. They reduce code duplication, eliminate unnecessary casting, and complement generic classes in building robust, maintainable Java applications. Generic methods are widely used throughout the Java Standard Library and Collections Framework.
