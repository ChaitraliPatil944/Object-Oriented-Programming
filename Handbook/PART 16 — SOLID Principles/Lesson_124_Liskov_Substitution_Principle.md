# Lesson 124 — Liskov Substitution Principle (LSP)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Liskov Substitution Principle (LSP)** is the third principle of **SOLID**, proposed by Barbara Liskov.

**Definition:**

> **Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.**

In simple words, every child class should behave like a proper substitute for its parent class.

---

# 2. Why LSP?

Inheritance should extend behavior, not break it.

If replacing a parent object with a child object changes expected behavior, the design violates LSP.

---

# 3. Bad Example

```java
class Bird {
    void fly() {
        System.out.println("Flying");
    }
}

class Ostrich extends Bird {
    @Override
    void fly() {
        throw new UnsupportedOperationException();
    }
}
```

An `Ostrich` is a `Bird`, but it cannot fly. The subclass breaks the contract of the parent.

---

# 4. Better Design

```java
class Bird {
}

class FlyingBird extends Bird {
    void fly() {
        System.out.println("Flying");
    }
}

class Sparrow extends FlyingBird {
}

class Ostrich extends Bird {
}
```

Only birds that can fly inherit flying behavior.

---

# 5. Example with Interfaces

```java
interface Shape {
    int area();
}

class Rectangle implements Shape {
    public int area() {
        return 100;
    }
}

class Square implements Shape {
    public int area() {
        return 100;
    }
}
```

Any implementation of `Shape` can safely replace another where only `area()` is required.

---

# 6. Characteristics of LSP

- Subclasses honor parent behavior.
- Method contracts remain valid.
- Preconditions should not become stricter.
- Postconditions should not become weaker.
- Clients should not need to know the concrete subtype.

---

# 7. Benefits

- Reliable inheritance
- Better polymorphism
- Easier maintenance
- Reusable code
- Flexible architecture

---

# 8. Best Practices

- Inherit only when there is a true "is-a" relationship.
- Prefer composition if inheritance causes behavior changes.
- Do not throw unexpected exceptions in overridden methods.
- Preserve the parent class contract.

---

# 9. Common Mistakes

❌ Misusing inheritance for code reuse.

❌ Overriding methods to disable functionality.

❌ Violating expected behavior of the parent class.

---

# 10. Advantages

- Predictable polymorphism
- Reduced runtime errors
- Cleaner object hierarchies
- Easier testing
- Better extensibility

---

# 11. Interview Questions

1. What is the Liskov Substitution Principle?
2. Why does the Bird-Ostrich example violate LSP?
3. How does LSP improve polymorphism?
4. When should composition be preferred over inheritance?
5. What is meant by a superclass contract?

---

# 12. Quick Revision

```text
LSP
│
├── Child Replaces Parent
├── Preserve Behavior
├── Proper Inheritance
└── Reliable Polymorphism
```

---

# 13. Interview Cheat Sheet

```text
Liskov Substitution Principle

✔ Child should replace Parent
✔ No Broken Contracts
✔ Preserve Expected Behavior

Use

Inheritance
Polymorphism
Composition when needed
```

---

# 14. Summary

The Liskov Substitution Principle states that subclasses must be usable wherever their parent classes are expected without altering the program's correctness. By preserving the behavior and contracts of parent classes, LSP ensures reliable inheritance, effective polymorphism, and maintainable object-oriented designs.
