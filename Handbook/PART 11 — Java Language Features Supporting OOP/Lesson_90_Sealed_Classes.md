# Lesson 90 — Sealed Classes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Sealed Classes** are a Java language feature introduced as a preview in **Java 15** and made permanent in **Java 17**.

A sealed class gives the developer **complete control over inheritance** by explicitly specifying which classes are allowed to extend or implement it.

This bridges the gap between:

- Normal classes (anyone can extend)
- Final classes (no one can extend)

Sealed classes allow **only selected subclasses**.

---

# 2. Why Do We Need Sealed Classes?

Before Java 17:

### Normal Class

```text
Animal
│
├── Dog
├── Cat
├── Bird
├── Fish
├── Robot
└── Any class...
```

Anyone could extend the class.

### Final Class

```text
Animal (final)

No subclass allowed.
```

Too restrictive.

### Sealed Class

```text
Animal (sealed)

├── Dog ✔
├── Cat ✔
└── Bird ✔

Fish ❌
Robot ❌
```

The developer decides who may inherit.

---

# 3. Declaring a Sealed Class

```java
public sealed class Animal
    permits Dog, Cat {

}
```

Only `Dog` and `Cat` can extend `Animal`.

---

# 4. Permitted Subclasses

Every permitted subclass must declare one of the following modifiers:

- `final`
- `sealed`
- `non-sealed`

### Example

```java
public sealed class Animal
    permits Dog, Cat {
}

final class Dog extends Animal {
}

non-sealed class Cat extends Animal {
}
```

---

# 5. Meaning of the Modifiers

### final

No further inheritance allowed.

```text
Animal
│
└── Dog (final)
```

---

### sealed

Inheritance continues, but remains controlled.

```text
Vehicle (sealed)
│
└── Car (sealed)
      │
      └── ElectricCar
```

---

### non-sealed

Removes inheritance restrictions.

```text
Animal
│
└── Cat (non-sealed)
      │
      ├── PersianCat
      ├── Lion
      └── Tiger
```

---

# 6. Real-World Example

```java
public sealed class Payment
    permits CreditCard, UPI, Cash {
}

final class CreditCard extends Payment {
}

final class UPI extends Payment {
}

final class Cash extends Payment {
}
```

Only approved payment types exist.

---

# 7. Rules of Sealed Classes

- A sealed class must use the `sealed` keyword.
- It must declare a `permits` clause unless subclasses are in the same source file.
- Permitted subclasses must directly extend the sealed class.
- Every permitted subclass must be `final`, `sealed`, or `non-sealed`.

---

# 8. Sealed Class vs Final Class

| Feature | Sealed Class | Final Class |
|---------|--------------|-------------|
| Inheritance | Limited | Not Allowed |
| Subclasses | Selected only | None |
| Extensible | Controlled | Completely blocked |
| Use Case | Restricted hierarchies | Immutable behavior |

---

# 9. Advantages

- Better control over inheritance
- Improved API design
- Safer domain models
- Easier maintenance
- Better compiler support for pattern matching

---

# 10. Best Practices

- Use sealed classes for fixed hierarchies.
- Combine with records where appropriate.
- Prefer final subclasses unless further extension is required.
- Clearly document permitted subclasses.

---

# 11. Common Mistakes

❌ Forgetting the `permits` clause.

❌ Not marking permitted subclasses as `final`, `sealed`, or `non-sealed`.

❌ Using sealed classes when unrestricted inheritance is intended.

---

# 12. Interview Questions

1. What is a sealed class?
2. Why were sealed classes introduced?
3. Difference between sealed and final classes?
4. What is the purpose of the `permits` clause?
5. Explain `final`, `sealed`, and `non-sealed` subclasses.

---

# 13. Quick Revision

```text
Sealed Class
│
├── permits
├── Controlled Inheritance
├── final subclass
├── sealed subclass
└── non-sealed subclass
```

---

# 14. Interview Cheat Sheet

```text
sealed
│
├── Controls inheritance
├── Uses permits
├── final → Stop inheritance
├── sealed → Continue with control
└── non-sealed → Remove restriction
```

---

# 15. Summary

Sealed classes provide controlled inheritance in Java by allowing only explicitly permitted subclasses. They offer more flexibility than `final` classes while preventing uncontrolled class hierarchies. Introduced permanently in Java 17, sealed classes are especially useful for domain models, framework APIs, and applications that require well-defined inheritance structures, improving safety, maintainability, and code clarity.
