# Lesson 98 — Bounded Generics

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Bounded Generics** allow us to restrict the types that can be used as type arguments in Java Generics.

Instead of accepting **any reference type**, we can specify that a type parameter must extend a particular class or implement a particular interface.

This increases **type safety**, improves **API design**, and allows generic code to safely use methods of the bounded type.

---

# 2. Why Do We Need Bounded Generics?

Consider a generic class:

```java
class Box<T> {

    T value;
}
```

This accepts any reference type:

```java
Box<String>
Box<Integer>
Box<Student>
Box<Car>
```

Sometimes we want to accept **only numbers**.

Bounded Generics solve this problem.

---

# 3. Upper Bounded Generics

Syntax:

```java
<T extends ClassName>
```

Example:

```java
class NumberBox<T extends Number> {

    private T value;

    NumberBox(T value) {
        this.value = value;
    }

    double doubleValue() {
        return value.doubleValue();
    }
}
```

Usage:

```java
NumberBox<Integer> a = new NumberBox<>(10);
NumberBox<Double> b = new NumberBox<>(25.5);

// NumberBox<String> c = new NumberBox<>("Java"); // Error
```

Only subclasses of `Number` are allowed.

---

# 4. Using Methods from the Bound

Since `T` extends `Number`, methods of `Number` are available.

```java
class Calculator<T extends Number> {

    T value;

    Calculator(T value) {
        this.value = value;
    }

    void print() {
        System.out.println(value.doubleValue());
    }
}
```

Without the bound, `doubleValue()` would not be accessible.

---

# 5. Multiple Bounds

A type parameter can extend one class and implement multiple interfaces.

Syntax:

```java
<T extends ClassName & Interface1 & Interface2>
```

Example:

```java
class Demo<T extends Number & Comparable<T>> {

}
```

Rules:

- Only one class can be extended.
- The class must appear first.
- Multiple interfaces may follow.

---

# 6. Bounded Generic Methods

Generic methods can also use bounds.

```java
class Utility {

    public static <T extends Number> double square(T value) {

        return value.doubleValue() * value.doubleValue();
    }
}
```

Usage:

```java
System.out.println(Utility.square(5));
System.out.println(Utility.square(4.5));
```

---

# 7. Bounded Generics vs Wildcards

| Bounded Generics | Wildcards |
|------------------|-----------|
| Define type parameters | Accept unknown generic types |
| Used in class/method declarations | Used mainly in method parameters |
| Reusable type | Flexible API |

Example:

```java
<T extends Number>
```

vs

```java
<? extends Number>
```

---

# 8. Advantages

- Strong type safety
- Restricts invalid types
- Access to superclass methods
- Better compiler checking
- Cleaner APIs

---

# 9. Best Practices

- Use bounds only when necessary.
- Prefer interface bounds for flexibility.
- Keep bounds simple and meaningful.
- Use wildcards when the exact type is not important.

---

# 10. Common Mistakes

❌ Assuming `extends` means only classes. It also works with interfaces.

❌ Placing interfaces before the class in multiple bounds.

Incorrect:

```java
<T extends Comparable<T> & Number>
```

Correct:

```java
<T extends Number & Comparable<T>>
```

❌ Using bounds when unrestricted generics are sufficient.

---

# 11. Interview Questions

1. What are bounded generics?
2. Why are bounded generics used?
3. Explain upper bounded generics.
4. Can a type parameter have multiple bounds?
5. Difference between `<T extends Number>` and `<? extends Number>`?

---

# 12. Quick Revision

```text
Bounded Generics
│
├── extends
├── Number
├── Multiple Bounds
├── Generic Methods
└── Type Safety
```

---

# 13. Interview Cheat Sheet

```text
<T extends Number>

✔ Restricts Types
✔ Access Number Methods
✔ Compile-Time Safety

Multiple Bounds

<T extends Number & Comparable<T>>

Class First
Interfaces Next
```

---

# 14. Summary

Bounded Generics restrict generic type parameters to specific classes or interfaces, enabling safer and more expressive APIs. By using `extends`, developers can ensure that generic code operates only on compatible types while gaining access to the methods of the bounded type. Bounded Generics are widely used in the Java Collections Framework, utility libraries, and enterprise applications to improve type safety and code quality.
