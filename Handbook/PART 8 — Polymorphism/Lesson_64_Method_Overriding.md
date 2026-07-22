# Lesson 64 — Method Overriding

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Method Overriding** occurs when a subclass provides its own implementation of a method already defined in its superclass.

It is the core mechanism behind **runtime polymorphism** in Java.

---

# 2. Definition

A child class overrides a parent method by using:

- Same method name
- Same parameter list
- Same (or covariant) return type

```text
Animal
  │ sound()
  ▼
Dog
  │ sound()  ← Overrides
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

Animal a = new Dog();
a.sound();
```

Output:

```
Dog Barks
```

---

# 4. Rules of Method Overriding

- Requires inheritance.
- Method signature must be identical.
- Return type must be same or covariant.
- Access level cannot be more restrictive.
- `private`, `final`, and `static` methods cannot be overridden.

---

# 5. Role of `@Override`

```java
@Override
void sound() {
    System.out.println("Dog Barks");
}
```

Benefits:

- Compile-time validation
- Better readability
- Prevents accidental signature mistakes

---

# 6. Runtime Behavior

```text
Parent Reference
      │
      ▼
 Child Object
      │
      ▼
 JVM chooses overridden method
```

The actual object determines which implementation executes.

---

# 7. Enterprise Example

```java
class Notification {
    void send() {
        System.out.println("Generic Notification");
    }
}

class SMSNotification extends Notification {
    @Override
    void send() {
        System.out.println("Sending SMS");
    }
}
```

---

# 8. Overriding vs Overloading

| Overriding | Overloading |
|------------|-------------|
| Parent & Child classes | Same class |
| Same parameters | Different parameters |
| Runtime | Compile-time |
| Inheritance required | Inheritance optional |

---

# 9. Best Practices

- Always use `@Override`.
- Preserve the superclass contract.
- Override only when behavior changes.
- Keep methods focused.

---

# 10. Common Mistakes

❌ Changing parameter list.

❌ Trying to override `static`, `private`, or `final` methods.

❌ Forgetting `@Override`.

---

# 11. Interview Questions

1. What is method overriding?
2. Why is it runtime polymorphism?
3. Can static methods be overridden?
4. Why use `@Override`?
5. Difference between overloading and overriding?

---

# 12. Quick Revision

```text
Method Overriding
│
├── Inheritance required
├── Same signature
├── Runtime polymorphism
├── JVM selects method
└── Dynamic binding
```

---

# 13. Summary

Method overriding allows subclasses to redefine inherited behavior while keeping a common interface. It enables runtime polymorphism, improves extensibility, and forms the foundation of flexible enterprise application design in Java.
