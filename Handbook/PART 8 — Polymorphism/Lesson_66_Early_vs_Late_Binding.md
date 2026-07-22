# Lesson 66 — Early Binding vs Late Binding

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Binding** is the process of connecting a method call to its actual implementation.

Java performs binding in two ways:

- Early Binding (Static Binding)
- Late Binding (Dynamic Binding)

Understanding binding helps explain how Java executes overloaded and overridden methods.

---

# 2. What is Binding?

When the compiler or JVM encounters a method call, it must determine **which method implementation** to execute.

```text
Method Call
     │
     ▼
Binding
     │
     ▼
Method Execution
```

---

# 3. Early Binding (Static Binding)

Early Binding occurs when the method to execute is determined **during compilation**.

It is associated with:

- Method Overloading
- Static methods
- Final methods
- Private methods

Example:

```java
class Calculator {

    int add(int a, int b) {
        return a + b;
    }

    double add(double a, double b) {
        return a + b;
    }
}
```

The compiler selects the correct `add()` method based on the arguments.

---

# 4. Late Binding (Dynamic Binding)

Late Binding occurs when the JVM determines the method to execute **during runtime**.

It is associated with:

- Method Overriding
- Runtime Polymorphism
- Dynamic Method Dispatch

Example:

```java
class Animal {

    void sound() {
        System.out.println("Animal Sound");
    }
}

class Dog extends Animal {

    @Override
    void sound() {
        System.out.println("Dog Barks");
    }
}

Animal animal = new Dog();
animal.sound();
```

The JVM executes `Dog.sound()` at runtime.

---

# 5. Early vs Late Binding

| Early Binding | Late Binding |
|---------------|--------------|
| Compile time | Runtime |
| Compiler decides | JVM decides |
| Faster | Slight runtime overhead |
| Method Overloading | Method Overriding |
| Static Binding | Dynamic Binding |

---

# 6. Execution Flow

```text
Compile-Time

Method Call
     │
Compiler
     │
Select Method

---------------------

Runtime

Method Call
     │
JVM
     │
Actual Object
     │
Execute Method
```

---

# 7. Enterprise Example

```java
interface Payment {

    void pay();
}

class CreditCardPayment implements Payment {

    public void pay() {
        System.out.println("Credit Card");
    }
}

Payment payment = new CreditCardPayment();
payment.pay();
```

The JVM binds the `pay()` method at runtime.

---

# 8. Advantages

Early Binding:

- Faster execution
- Less runtime overhead

Late Binding:

- Flexible design
- Extensibility
- Loose coupling

---

# 9. Best Practices

- Use overloading for convenience.
- Use overriding for extensibility.
- Program to interfaces.
- Prefer late binding for enterprise architectures.

---

# 10. Common Mistakes

❌ Confusing overloading with overriding.

❌ Assuming static methods use runtime binding.

❌ Believing all method calls are dynamically bound.

---

# 11. Interview Questions

1. What is binding?
2. Difference between early and late binding?
3. Which methods use static binding?
4. Why is overriding called late binding?
5. Which is faster?

---

# 12. Quick Revision

```text
Binding
│
├── Early
│   ├── Compile Time
│   ├── Compiler
│   └── Overloading
│
└── Late
    ├── Runtime
    ├── JVM
    └── Overriding
```

---

# 13. Summary

Binding determines how Java connects a method call to its implementation. Early binding occurs during compilation and is used for overloaded, static, final, and private methods. Late binding occurs during execution and powers runtime polymorphism through method overriding and dynamic method dispatch, enabling flexible enterprise software.
