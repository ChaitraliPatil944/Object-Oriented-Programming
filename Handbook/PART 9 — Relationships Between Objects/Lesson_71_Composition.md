# Lesson 71 — Composition

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Composition** is a strong form of **Association** that represents a **strong "has-a" relationship**.

In composition, one object owns another object completely. The lifetime of the child object depends on the parent object.

If the parent object is destroyed, the child object is also destroyed.

---

# 2. Definition

Composition is a relationship where one class is composed of one or more objects that cannot exist independently.

Characteristics:

- Strong Has-A relationship
- Strong ownership
- Dependent lifecycles
- Whole-part relationship

---

# 3. Real-World Example

```text
House ◆──── Room

House contains Rooms.

Destroy the House
        │
        ▼
Rooms no longer exist.
```

A room cannot meaningfully exist without its house.

---

# 4. Java Example

```java
class Engine {

    void start() {
        System.out.println("Engine Started");
    }
}

class Car {

    private Engine engine;

    Car() {
        engine = new Engine();
    }

    void startCar() {
        engine.start();
        System.out.println("Car Started");
    }
}
```

Usage:

```java
Car car = new Car();
car.startCar();
```

Output:

```
Engine Started
Car Started
```

The `Engine` is created and owned by the `Car`.

---

# 5. UML Representation

Composition is represented by a **filled diamond**.

```text
Car ◆──────── Engine
```

The filled diamond appears on the owner (whole) side.

---

# 6. Enterprise Examples

- Order → OrderItems
- House → Rooms
- Company → Departments (in some domains)
- Document → Pages

The child object belongs exclusively to the parent.

---

# 7. Composition vs Aggregation

| Composition | Aggregation |
|-------------|-------------|
| Strong Has-A | Weak Has-A |
| Filled diamond (◆) | Hollow diamond (◇) |
| Child depends on parent | Child independent |
| Strong ownership | Weak ownership |

---

# 8. Advantages

- Better encapsulation
- Strong object ownership
- Clear lifecycle management
- Models real-world whole-part relationships

---

# 9. Best Practices

- Use composition when ownership is mandatory.
- Prefer composition over inheritance where appropriate.
- Hide internal components using encapsulation.

---

# 10. Common Mistakes

❌ Confusing composition with aggregation.

❌ Sharing composed objects between multiple parents.

❌ Using composition when independent lifecycles are required.

---

# 11. Interview Questions

1. What is composition?
2. Why is composition called a strong Has-A relationship?
3. Difference between composition and aggregation?
4. What UML symbol represents composition?
5. Give enterprise examples of composition.

---

# 12. Quick Revision

```text
Composition
│
├── Strong Has-A
├── Filled Diamond (◆)
├── Strong Ownership
├── Dependent Lifecycles
└── Whole-Part Relationship
```

---

# 13. Summary

Composition is a strong object relationship in which the parent owns the child completely. The child object's lifecycle depends on the parent, making composition ideal for modeling whole-part relationships such as Car-Engine and Order-OrderItem. It promotes encapsulation, clear ownership, and maintainable enterprise designs.
