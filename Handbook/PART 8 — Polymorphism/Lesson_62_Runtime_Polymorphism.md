# Lesson 62 — Runtime Polymorphism

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Runtime Polymorphism** is a type of polymorphism where the method to be executed is determined **while the program is running**.

It is also known as:

- Dynamic Polymorphism
- Late Binding
- Dynamic Method Dispatch

In Java, runtime polymorphism is achieved using **method overriding**.

---

# 2. Definition

Runtime polymorphism occurs when a parent class reference points to a child class object, and the overridden method is selected by the JVM at runtime.

```text
Animal ref
     │
     ▼
    Dog Object

ref.sound()
     │
     ▼
Dog.sound()
```

---

# 3. Java Example

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

public class Main {

    public static void main(String[] args) {

        Animal a = new Dog();
        a.sound();
    }
}
```

Output:

```
Dog Barks
```

The reference type is `Animal`, but the object type is `Dog`. The JVM executes `Dog.sound()`.

---

# 4. How Runtime Polymorphism Works

```text
Parent Reference
        │
        ▼
Child Object
        │
        ▼
JVM decides method
        │
        ▼
Calls overridden method
```

The decision is made **during execution**, not during compilation.

---

# 5. Requirements

Runtime polymorphism requires:

- Inheritance
- Method overriding
- Parent class reference
- Child class object

---

# 6. Advantages

- Flexibility
- Extensibility
- Loose coupling
- Easier maintenance
- Better scalability

---

# 7. Enterprise Example

```java
interface Payment {

    void pay();
}

class CreditCardPayment implements Payment {

    public void pay() {
        System.out.println("Credit Card Payment");
    }
}

class UPIPayment implements Payment {

    public void pay() {
        System.out.println("UPI Payment");
    }
}

Payment payment = new UPIPayment();
payment.pay();
```

The application works with the `Payment` interface while the actual implementation is chosen at runtime.

---

# 8. Runtime vs Compile-Time

| Runtime | Compile-Time |
|----------|--------------|
| Method Overriding | Method Overloading |
| JVM decides | Compiler decides |
| Late Binding | Early Binding |
| Dynamic | Static |

---

# 9. Best Practices

- Program against interfaces.
- Override methods only when behavior changes.
- Avoid unnecessary type checking.
- Follow the Liskov Substitution Principle.

---

# 10. Common Mistakes

❌ Confusing object type with reference type.

❌ Believing overloaded methods use runtime polymorphism.

❌ Forgetting that static methods are not polymorphic.

---

# 11. Interview Questions

1. What is runtime polymorphism?
2. How is it achieved in Java?
3. Why is it called late binding?
4. What are the requirements?
5. Difference between runtime and compile-time polymorphism?

---

# 12. Quick Revision

```text
Runtime Polymorphism
│
├── Method Overriding
├── Parent Reference
├── Child Object
├── JVM decides method
└── Late Binding
```

---

# 13. Summary

Runtime polymorphism enables Java to decide which overridden method to execute while the program is running. It is implemented through method overriding and dynamic method dispatch, allowing developers to build flexible, loosely coupled, and extensible enterprise applications.
