# Lesson 126 — Dependency Inversion Principle (DIP)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Dependency Inversion Principle (DIP)** is the fifth and final principle of **SOLID**.

**Definition:**

> **High-level modules should not depend on low-level modules. Both should depend on abstractions.**
>
> **Abstractions should not depend on details. Details should depend on abstractions.**

Instead of tightly coupling classes together, DIP promotes programming to interfaces rather than concrete implementations.

---

# 2. Why DIP?

Without DIP:

- Classes become tightly coupled.
- Changing one implementation affects many classes.
- Testing becomes difficult.
- Reusability decreases.

DIP makes systems flexible and easier to maintain.

---

# 3. Bad Example

```java
class Keyboard {
    void type() {
        System.out.println("Typing...");
    }
}

class Computer {

    private Keyboard keyboard = new Keyboard();

    void work() {
        keyboard.type();
    }
}
```

`Computer` depends directly on the concrete `Keyboard` class.

---

# 4. Applying DIP

```java
interface InputDevice {
    void input();
}

class Keyboard implements InputDevice {

    public void input() {
        System.out.println("Typing...");
    }
}

class Computer {

    private InputDevice device;

    public Computer(InputDevice device) {
        this.device = device;
    }

    void work() {
        device.input();
    }
}
```

Now `Computer` depends only on the `InputDevice` abstraction.

---

# 5. Dependency Injection

A common way to apply DIP is **Dependency Injection (DI)**.

```java
InputDevice keyboard = new Keyboard();

Computer computer = new Computer(keyboard);
```

The dependency is provided from outside rather than created internally.

---

# 6. How DIP Works

```text
          InputDevice
               ▲
      ┌────────┴────────┐
      │                 │
  Keyboard          TouchScreen

          ▲
          │
      Computer
```

High-level modules communicate through abstractions.

---

# 7. Benefits

- Loose coupling
- Easier testing
- Better extensibility
- Improved maintainability
- Flexible architecture

---

# 8. Real-World Example

```text
Payment Service
        │
        ▼
 Payment Interface
   ▲          ▲
CreditCard   UPI
```

The payment service works with the interface, not specific payment methods.

---

# 9. Best Practices

- Program to interfaces.
- Prefer constructor injection.
- Avoid creating dependencies with `new` inside business classes.
- Keep abstractions stable.

---

# 10. Common Mistakes

❌ Depending directly on concrete classes.

❌ Creating dependencies inside constructors without abstraction.

❌ Introducing unnecessary abstractions for trivial programs.

---

# 11. Advantages

- Low coupling
- High flexibility
- Easy unit testing with mock implementations
- Better scalability
- Cleaner architecture

---

# 12. Interview Questions

1. What is the Dependency Inversion Principle?
2. Why should classes depend on abstractions?
3. What is dependency injection?
4. Constructor injection vs field injection?
5. How does DIP improve testing?

---

# 13. Quick Revision

```text
DIP
│
├── Depend on Interfaces
├── Loose Coupling
├── Dependency Injection
└── Flexible Design
```

---

# 14. Interview Cheat Sheet

```text
Dependency Inversion Principle

✔ High-Level → Abstractions
✔ Low-Level → Abstractions
✔ Details depend on Interfaces

Key Concepts

Interfaces
Dependency Injection
Loose Coupling
Mock Testing
```

---

# 15. Summary

The Dependency Inversion Principle encourages high-level and low-level modules to depend on abstractions instead of concrete implementations. By combining interfaces with dependency injection, DIP reduces coupling, improves testability, and makes software easier to extend and maintain, making it a cornerstone of modern object-oriented and enterprise application design.
