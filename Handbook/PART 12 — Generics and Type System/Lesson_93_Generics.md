# Lesson 93 — Generics

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Generics** are a feature introduced in **Java 5** that allow classes, interfaces, and methods to operate on **different data types while maintaining compile-time type safety**.

Instead of writing separate code for different data types, Generics enable us to write **reusable and type-safe code**.

Examples:

- `ArrayList<String>`
- `ArrayList<Integer>`
- `HashMap<String, Integer>`

Generics are heavily used throughout the **Java Collections Framework**.

---

# 2. Why Do We Need Generics?

Before Java 5, collections stored objects as `Object`.

```java
ArrayList list = new ArrayList();

list.add("Alice");
list.add(100);
```

Problems:

- No compile-time type checking
- Explicit casting required
- Runtime errors (`ClassCastException`)

With Generics:

```java
ArrayList<String> list = new ArrayList<>();

list.add("Alice");

// list.add(100); // Compilation Error
```

The compiler ensures only `String` objects are added.

---

# 3. What is a Generic Type?

A **generic type** is represented using **type parameters**.

Common type parameter names:

| Symbol | Meaning |
|---------|---------|
| `T` | Type |
| `E` | Element |
| `K` | Key |
| `V` | Value |
| `N` | Number |

Example:

```java
class Box<T> {

    T value;
}
```

Here, `T` can represent any reference type.

---

# 4. Simple Generic Example

```java
class Box<T> {

    private T value;

    void setValue(T value) {
        this.value = value;
    }

    T getValue() {
        return value;
    }
}
```

Using the class:

```java
Box<String> box = new Box<>();

box.setValue("Java");

System.out.println(box.getValue());
```

Output:

```text
Java
```

---

# 5. Generic Collections

Generics are widely used with Java collections.

### ArrayList

```java
ArrayList<String> names = new ArrayList<>();

names.add("Alice");
names.add("Bob");
```

### HashMap

```java
HashMap<Integer, String> map = new HashMap<>();

map.put(1, "Alice");
```

### Queue

```java
Queue<Integer> queue = new LinkedList<>();
```

---

# 6. Advantages of Generics

- Compile-time type safety
- Eliminates explicit type casting
- Reusable code
- Better readability
- Fewer runtime errors
- Improved maintainability

---

# 7. Generics vs Object

Without Generics:

```java
Object obj = "Hello";

String s = (String)obj;
```

Casting is required.

With Generics:

```java
Box<String> box = new Box<>();

String s = box.getValue();
```

No casting is needed.

---

# 8. Restrictions of Generics

Generics cannot be used with:

- Primitive data types (`int`, `double`, etc.)
- Static type parameters
- Direct object creation using type parameters

Invalid examples:

```java
Box<int> box;
```

```java
new T();
```

Correct approach:

```java
Box<Integer> box;
```

---

# 9. Best Practices

- Use meaningful type parameters.
- Prefer Generics over raw types.
- Avoid unchecked casts.
- Specify generic types explicitly where possible.

---

# 10. Common Mistakes

❌ Using raw collections:

```java
ArrayList list = new ArrayList();
```

❌ Mixing different data types in one generic collection.

❌ Assuming Generics support primitive types.

---

# 11. Interview Questions

1. What are Generics?
2. Why were Generics introduced?
3. What problems do Generics solve?
4. Why can't Generics use primitive data types?
5. What are raw types?

---

# 12. Quick Revision

```text
Generics
│
├── Type Safety
├── Reusable Code
├── Collections
├── Compile-Time Checking
└── No Explicit Casting
```

---

# 13. Interview Cheat Sheet

```text
Generics
│
├── Introduced in Java 5
├── Uses Type Parameters (T, E, K, V)
├── Prevents ClassCastException
├── Compile-Time Type Checking
└── Used in Collections Framework
```

---

# 14. Summary

Generics allow Java developers to write flexible, reusable, and type-safe code by replacing fixed data types with type parameters. They eliminate unnecessary casting, catch type mismatches during compilation, and form the foundation of the Java Collections Framework. Understanding Generics is essential for writing modern Java applications and succeeding in technical interviews.
