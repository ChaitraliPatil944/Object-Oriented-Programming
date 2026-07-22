# Lesson 97 — Type Erasure

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Type Erasure** is the process by which the Java compiler removes generic type information during compilation.

Generics provide **compile-time type safety**, but they do **not exist at runtime**.

After compilation, generic type parameters such as `<T>`, `<String>`, or `<Integer>` are replaced with their **upper bound** (usually `Object`) or the specified bounded type.

This design maintains **backward compatibility** with Java versions released before Generics (Java 5).

---

# 2. Why Was Type Erasure Introduced?

When Generics were added in Java 5, millions of existing Java programs already existed.

Instead of changing the JVM, Java designers chose Type Erasure.

Benefits:

- Backward compatibility
- No JVM modification
- Old bytecode continues to work
- Generic and non-generic code can coexist

---

# 3. How Type Erasure Works

### Generic Source Code

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

---

### After Type Erasure

```java
class Box {

    private Object value;

    void setValue(Object value) {
        this.value = value;
    }

    Object getValue() {
        return value;
    }
}
```

The compiler inserts casts wherever necessary.

---

# 4. Example

Source Code:

```java
Box<String> box = new Box<>();

box.setValue("Java");

String value = box.getValue();
```

Compiled Conceptually:

```java
Box box = new Box();

box.setValue("Java");

String value = (String) box.getValue();
```

The cast is inserted automatically by the compiler.

---

# 5. Type Erasure with Bounded Types

Consider:

```java
class NumberBox<T extends Number> {

    T value;
}
```

After erasure:

```java
class NumberBox {

    Number value;
}
```

The upper bound replaces the generic parameter instead of `Object`.

---

# 6. Effects of Type Erasure

Because generic information is removed at runtime:

### Cannot Check Generic Types with `instanceof`

Invalid:

```java
if (obj instanceof List<String>) { }
```

Valid:

```java
if (obj instanceof List<?>) { }
```

---

### Cannot Create Generic Arrays

Invalid:

```java
new T[10];
```

or

```java
new List<String>[10];
```

---

### Cannot Create Objects of Type Parameters

Invalid:

```java
new T();
```

---

# 7. Bridge Methods

Sometimes the compiler generates **bridge methods** after type erasure to preserve **polymorphism**.

Example:

```java
class Parent<T> {

    T getValue() {
        return null;
    }
}

class Child extends Parent<String> {

    @Override
    String getValue() {
        return "Java";
    }
}
```

The compiler creates a hidden bridge method so overriding continues to work correctly after erasure.

---

# 8. Advantages

- Backward compatibility
- No JVM redesign
- Compile-time type safety
- Smaller runtime overhead
- Smooth migration from older Java versions

---

# 9. Limitations

- Generic information unavailable at runtime
- Cannot use primitive types directly
- Cannot create generic arrays
- Cannot instantiate type parameters
- Some reflection limitations

---

# 10. Best Practices

- Use Generics for compile-time safety.
- Avoid relying on runtime generic type information.
- Use bounded generics where appropriate.
- Prefer collections over generic arrays.

---

# 11. Common Mistakes

❌ Expecting Generics to exist at runtime.

❌ Using `instanceof List<String>`.

❌ Creating arrays of generic types.

❌ Attempting `new T()`.

---

# 12. Interview Questions

1. What is Type Erasure?
2. Why was Type Erasure introduced?
3. How does Type Erasure work?
4. What happens to bounded generic types after erasure?
5. What are bridge methods?

---

# 13. Quick Revision

```text
Type Erasure
│
├── Removes Generic Types
├── Uses Object / Upper Bound
├── Compiler Inserts Casts
├── Backward Compatibility
└── Runtime Has No Generic Info
```

---

# 14. Interview Cheat Sheet

```text
Type Erasure

Before Compilation
Box<String>

After Compilation
Box<Object>

✔ Compile-Time Feature
✔ Runtime Generic Info Removed
✔ Supports Older JVMs
✔ Bridge Methods Preserve Polymorphism
```

---

# 15. Summary

Type Erasure is the mechanism by which Java removes generic type information during compilation while preserving compile-time type safety. Generic types are replaced with `Object` or their upper bound, and the compiler inserts the required casts automatically. This approach allows Java to support Generics without changing the JVM, ensuring backward compatibility with legacy applications while keeping runtime performance efficient.
