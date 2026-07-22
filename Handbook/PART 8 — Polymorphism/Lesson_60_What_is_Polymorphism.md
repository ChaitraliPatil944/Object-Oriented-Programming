# Lesson 60 — What is Polymorphism?

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Polymorphism** is one of the four fundamental pillars of Object-Oriented Programming.

The word **Polymorphism** comes from two Greek words:

- **Poly** = Many
- **Morph** = Forms

It means **one interface, many implementations**.

The same method call can produce different behavior depending on the object.

---

# 2. Definition

Polymorphism allows a single interface or method to represent multiple behaviors.

```text
Animal
   ▲
 ┌─┴───────┐
Dog      Cat

animal.sound()

Dog → Bark
Cat → Meow
```

---

# 3. Why Do We Need Polymorphism?

Without polymorphism:

- More `if-else` statements
- Duplicate code
- Difficult maintenance

With polymorphism:

- Flexible code
- Better extensibility
- Loose coupling
- Easier maintenance

---

# 4. Real-World Example

Think of a **Remote Control**.

```text
Press Power Button

TV        → Turns TV On
Projector → Turns Projector On
AC        → Turns AC On
```

The same action behaves differently for different devices.

---

# 5. Java Example

```java
class Animal {

    void sound() {
        System.out.println("Animal Sound");
    }
}

class Dog extends Animal {

    @Override
    void sound() {
        System.out.println("Bark");
    }
}

class Cat extends Animal {

    @Override
    void sound() {
        System.out.println("Meow");
    }
}

Animal a1 = new Dog();
Animal a2 = new Cat();

a1.sound();
a2.sound();
```

Output:

```
Bark
Meow
```

---

# 6. Types of Polymorphism

Java supports two major types:

1. Compile-Time Polymorphism
   - Method Overloading
   - Static Binding

2. Runtime Polymorphism
   - Method Overriding
   - Dynamic Binding

---

# 7. Advantages

- Code reusability
- Flexibility
- Extensibility
- Reduced coupling
- Better maintainability
- Cleaner architecture

---

# 8. Enterprise Example

```java
interface Payment {

    void pay();
}

class CreditCardPayment implements Payment {

    public void pay() {
        System.out.println("Paid by Credit Card");
    }
}

class UPIPayment implements Payment {

    public void pay() {
        System.out.println("Paid by UPI");
    }
}
```

The application works with the `Payment` interface while different implementations provide specific behavior.

---

# 9. Best Practices

- Program to interfaces, not implementations.
- Use overriding for varying behavior.
- Avoid unnecessary type checks.
- Keep implementations focused.

---

# 10. Common Mistakes

❌ Confusing overloading with overriding.

❌ Excessive `instanceof` checks.

❌ Breaking the parent contract in subclasses.

---

# 11. Interview Questions

1. What is polymorphism?
2. What are its types?
3. Why is polymorphism important?
4. Difference between compile-time and runtime polymorphism?
5. Give a real-world example.

---

# 12. Quick Revision

```text
Polymorphism
│
├── One Interface
├── Many Implementations
│
├── Compile-Time
│   └── Overloading
│
└── Runtime
    └── Overriding
```

---

# 13. Summary

Polymorphism enables one interface to represent multiple behaviors. It is achieved through method overloading at compile time and method overriding at runtime. By reducing coupling and improving flexibility, polymorphism is a cornerstone of scalable, maintainable, and enterprise-grade Java applications.
