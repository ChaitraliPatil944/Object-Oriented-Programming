# Lesson 67 — Virtual Methods

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Virtual Method** is a method whose implementation is determined **at runtime** based on the actual object.

Unlike languages such as C++, Java does not use the `virtual` keyword. Instead, **all non-static, non-final, and non-private instance methods are virtual by default**.

Virtual methods are the foundation of **runtime polymorphism**.

---

# 2. What is a Virtual Method?

A virtual method can be **overridden** by a subclass.

When the method is called through a parent reference, the JVM executes the implementation belonging to the actual object.

```text
Parent Reference
      │
      ▼
 Child Object
      │
      ▼
Virtual Method
      │
      ▼
JVM chooses implementation
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

Animal animal = new Dog();
animal.sound();
```

Output:

```
Dog Barks
```

---

# 4. Which Methods are Virtual?

| Method Type | Virtual? |
|-------------|----------|
| Instance Method | ✅ Yes |
| static Method | ❌ No |
| final Method | ❌ No |
| private Method | ❌ No |
| Constructor | ❌ No |

Only overridable instance methods participate in virtual dispatch.

---

# 5. How Virtual Methods Work

```text
Method Call
     │
Parent Reference
     │
JVM checks actual object
     │
Executes overridden method
```

The JVM performs this lookup at runtime.

---

# 6. Enterprise Example

```java
interface Payment {
    void pay();
}

class CardPayment implements Payment {
    public void pay() {
        System.out.println("Card Payment");
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

The correct implementation is selected dynamically.

---

# 7. Advantages

- Runtime flexibility
- Loose coupling
- Easy extensibility
- Better code reuse
- Supports interface-driven design

---

# 8. Best Practices

- Override methods thoughtfully.
- Program to interfaces.
- Keep overridden behavior consistent.
- Avoid overriding unless behavior truly differs.

---

# 9. Common Mistakes

❌ Assuming static methods are virtual.

❌ Trying to override final methods.

❌ Confusing overloading with virtual dispatch.

---

# 10. Interview Questions

1. What is a virtual method?
2. Does Java have a `virtual` keyword?
3. Which methods are virtual in Java?
4. Why are static methods not virtual?
5. How do virtual methods support polymorphism?

---

# 11. Quick Revision

```text
Virtual Methods
│
├── Instance methods
├── Overridable
├── Runtime dispatch
├── JVM selects implementation
└── Basis of runtime polymorphism
```

---

# 12. Summary

Virtual methods enable Java to support runtime polymorphism without requiring a `virtual` keyword. Every overridable instance method behaves as a virtual method, allowing the JVM to invoke the correct implementation based on the actual object. This mechanism makes Java applications flexible, extensible, and ideal for enterprise software development.
