# Lesson 61 — Compile-Time Polymorphism

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Compile-Time Polymorphism** is a type of polymorphism where the method to be executed is determined by the **compiler** before the program runs.

It is also known as:

- Static Polymorphism
- Early Binding
- Compile-Time Binding

In Java, compile-time polymorphism is achieved using **method overloading**.

---

# 2. Definition

Compile-time polymorphism occurs when multiple methods have the same name but different parameter lists.

The compiler decides which method to invoke based on the arguments.

```text
Calculator
│
├── add(int, int)
├── add(double, double)
└── add(int, int, int)
```

---

# 3. Method Overloading Example

```java
class Calculator {

    int add(int a, int b) {
        return a + b;
    }

    double add(double a, double b) {
        return a + b;
    }

    int add(int a, int b, int c) {
        return a + b + c;
    }
}
```

Usage:

```java
Calculator c = new Calculator();

System.out.println(c.add(5, 3));
System.out.println(c.add(5.5, 2.5));
System.out.println(c.add(1, 2, 3));
```

---

# 4. How It Works

```text
Method Call
     │
Compiler checks
     │
Parameter List
     │
Selects Matching Method
```

The decision is made **before execution**, making it faster than runtime polymorphism.

---

# 5. Rules for Method Overloading

Methods must differ by:

- Number of parameters
- Type of parameters
- Order of parameter types

Methods **cannot** be overloaded by changing only:

- Return type
- Access modifier

---

# 6. Advantages

- Improved readability
- Reusable method names
- Better code organization
- Faster method resolution

---

# 7. Enterprise Example

```java
class Logger {

    void log(String message) { }

    void log(String message, int level) { }

    void log(Exception ex) { }
}
```

Different versions of `log()` handle different types of input.

---

# 8. Compile-Time vs Runtime

| Compile-Time | Runtime |
|--------------|---------|
| Method Overloading | Method Overriding |
| Early Binding | Late Binding |
| Decided by Compiler | Decided by JVM |
| Faster Resolution | Dynamic Resolution |

---

# 9. Best Practices

- Keep overloaded methods logically related.
- Avoid too many overloads with confusing signatures.
- Use descriptive parameter names.
- Do not overload methods solely for convenience.

---

# 10. Common Mistakes

❌ Changing only the return type.

❌ Creating ambiguous overloaded methods.

❌ Confusing overloading with overriding.

---

# 11. Interview Questions

1. What is compile-time polymorphism?
2. How is it achieved in Java?
3. Can methods be overloaded by return type only?
4. Why is it called early binding?
5. Difference between overloading and overriding?

---

# 12. Quick Revision

```text
Compile-Time Polymorphism
│
├── Method Overloading
├── Early Binding
├── Compiler decides
├── Same method name
└── Different parameter list
```

---

# 13. Summary

Compile-time polymorphism enables Java to support multiple methods with the same name through method overloading. The compiler determines the correct method before execution, improving readability, code reuse, and performance while providing a flexible programming interface.
