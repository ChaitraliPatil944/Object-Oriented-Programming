# Lesson 73 — Has-A vs Is-A Relationship

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Two of the most important relationships in OOP are:

- **Is-A Relationship**
- **Has-A Relationship**

Choosing the correct relationship is essential for writing maintainable, reusable, and scalable software.

---

# 2. What is an Is-A Relationship?

An **Is-A** relationship represents **inheritance**.

If one class is a specialized version of another class, then it has an Is-A relationship.

Examples:

- Dog **is an** Animal
- Car **is a** Vehicle
- Manager **is an** Employee

```text
Animal
   ▲
   │
  Dog
```

---

# 3. Java Example (Is-A)

```java
class Animal {
    void eat() {
        System.out.println("Eating");
    }
}

class Dog extends Animal {
    void bark() {
        System.out.println("Barking");
    }
}
```

`Dog` inherits the behavior of `Animal`.

---

# 4. What is a Has-A Relationship?

A **Has-A** relationship represents **composition or aggregation**.

One class contains or uses another class as one of its parts.

Examples:

- Car has an Engine
- House has Rooms
- Department has Employees

```text
Car
 │
 ▼
Engine
```

---

# 5. Java Example (Has-A)

```java
class Engine {
    void start() {
        System.out.println("Engine Started");
    }
}

class Car {
    private Engine engine = new Engine();

    void startCar() {
        engine.start();
    }
}
```

`Car` contains an `Engine`.

---

# 6. Is-A vs Has-A

| Is-A | Has-A |
|------|--------|
| Inheritance | Composition/Aggregation |
| Extends class | Contains object |
| Reuses through inheritance | Reuses through delegation |
| Strong type hierarchy | Object collaboration |

---

# 7. Enterprise Examples

### Is-A

- AdminUser → User
- SavingsAccount → BankAccount
- ElectricCar → Vehicle

### Has-A

- Order → OrderItem
- Company → Employee
- Laptop → Battery

---

# 8. When to Use Which?

Use **Is-A** when:

- A subclass truly represents a specialized version of the parent.
- Polymorphism is required.

Use **Has-A** when:

- One object is made of or uses another.
- Flexibility and loose coupling are preferred.

---

# 9. Best Practices

- Favor composition over inheritance where appropriate.
- Avoid deep inheritance hierarchies.
- Model real-world relationships accurately.
- Use interfaces with Has-A relationships for flexibility.

---

# 10. Common Mistakes

❌ Using inheritance only to reuse code.

❌ Creating unrealistic class hierarchies.

❌ Ignoring composition when it better models the domain.

---

# 11. Interview Questions

1. What is an Is-A relationship?
2. What is a Has-A relationship?
3. Difference between Is-A and Has-A?
4. Why is composition often preferred?
5. Give enterprise examples of both.

---

# 12. Quick Revision

```text
Relationships
│
├── Is-A
│   ├── Inheritance
│   ├── extends
│   └── Polymorphism
│
└── Has-A
    ├── Composition
    ├── Aggregation
    └── Object Reference
```

---

# 13. Summary

An **Is-A** relationship is implemented using inheritance and represents specialization, while a **Has-A** relationship is implemented using composition or aggregation and represents ownership or collaboration. Modern enterprise applications generally favor Has-A relationships because they provide greater flexibility, lower coupling, and easier maintenance.
