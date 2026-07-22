# Lesson 65 — Dynamic Method Dispatch

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Dynamic Method Dispatch (DMD)** is the mechanism through which Java determines **at runtime** which overridden method should be executed.

It is the implementation technique behind **runtime polymorphism**.

Instead of deciding during compilation, the **Java Virtual Machine (JVM)** decides the method based on the actual object.

---

# 2. Definition

Dynamic Method Dispatch means:

> A parent class (or interface) reference can refer to different child objects, and the JVM invokes the correct overridden method during execution.

```text
Parent Reference
        │
        ▼
   Child Object
        │
        ▼
 JVM selects method
```

---

# 3. Basic Example

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

class Cat extends Animal {

    @Override
    void sound() {
        System.out.println("Cat Meows");
    }
}

Animal a;

a = new Dog();
a.sound();

a = new Cat();
a.sound();
```

Output:

```
Dog Barks
Cat Meows
```

The same reference variable calls different implementations depending on the object.

---

# 4. How Dynamic Method Dispatch Works

```text
Animal ref
     │
     ▼
new Dog()
     │
     ▼
ref.sound()
     │
     ▼
Dog.sound()

----------------------

Animal ref
     │
     ▼
new Cat()
     │
     ▼
ref.sound()
     │
     ▼
Cat.sound()
```

The JVM determines the correct method during execution.

---

# 5. Requirements

Dynamic Method Dispatch requires:

- Inheritance
- Method overriding
- Parent (or interface) reference
- Child object

---

# 6. Dynamic Dispatch with Interfaces

```java
interface Payment {

    void pay();
}

class CreditCardPayment implements Payment {

    public void pay() {
        System.out.println("Credit Card");
    }
}

class UPIPayment implements Payment {

    public void pay() {
        System.out.println("UPI");
    }
}

Payment payment = new UPIPayment();
payment.pay();
```

The interface reference invokes the correct implementation at runtime.

---

# 7. Advantages

- Loose coupling
- Extensibility
- Code reuse
- Better maintainability
- Supports Open/Closed Principle

---

# 8. Enterprise Example

```java
interface Notification {

    void send();
}

class EmailNotification implements Notification {

    public void send() {
        System.out.println("Email Sent");
    }
}

class SMSNotification implements Notification {

    public void send() {
        System.out.println("SMS Sent");
    }
}
```

Business code works with the `Notification` interface while implementations are selected dynamically.

---

# 9. Best Practices

- Prefer interfaces for flexibility.
- Avoid unnecessary downcasting.
- Override methods responsibly.
- Program to abstractions.

---

# 10. Common Mistakes

❌ Confusing reference type with object type.

❌ Believing overloaded methods use dynamic dispatch.

❌ Assuming static methods participate in runtime dispatch.

---

# 11. Interview Questions

1. What is Dynamic Method Dispatch?
2. How is it related to runtime polymorphism?
3. What are the requirements?
4. Does method overloading use dynamic dispatch?
5. Why is interface programming preferred?

---

# 12. Quick Revision

```text
Dynamic Method Dispatch
│
├── Runtime decision
├── JVM selects method
├── Method overriding
├── Parent reference
└── Child object
```

---

# 13. Summary

Dynamic Method Dispatch is the runtime mechanism that enables Java to invoke the correct overridden method based on the actual object rather than the reference type. It powers runtime polymorphism, encourages programming to interfaces, and enables flexible, scalable, and maintainable enterprise applications.
