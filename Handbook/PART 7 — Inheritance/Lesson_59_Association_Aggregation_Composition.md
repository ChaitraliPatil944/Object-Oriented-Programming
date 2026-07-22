# Lesson 59 — Association, Aggregation, and Composition

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Objects rarely work in isolation. They interact with other objects to model real-world systems.

Java represents these relationships using:

- Association
- Aggregation
- Composition

Understanding these relationships is essential for designing maintainable software.

---

# 2. Association

Association is a general relationship where two independent objects communicate.

```text
Teacher -------- Student
```

Example:

```java
class Student { }

class Teacher {

    void teach(Student s) {
        System.out.println("Teaching student");
    }
}
```

Both objects can exist independently.

---

# 3. Aggregation

Aggregation is a **HAS-A** relationship with weak ownership.

The child object can exist even if the parent is destroyed.

```text
Department
     ◇──── Employee
```

Example:

```java
class Employee { }

class Department {

    private Employee employee;

    Department(Employee employee) {
        this.employee = employee;
    }
}
```

Employees can exist without the department.

---

# 4. Composition

Composition is a strong **HAS-A** relationship.

The child object's lifecycle depends on the parent.

```text
House
  ◆──── Room
```

Example:

```java
class Room { }

class House {

    private Room room = new Room();
}
```

If the house is destroyed, its room objects are also destroyed.

---

# 5. Comparison

| Feature | Association | Aggregation | Composition |
|--------|-------------|-------------|-------------|
| Relationship | Uses | HAS-A | Strong HAS-A |
| Ownership | None | Weak | Strong |
| Lifecycle | Independent | Independent | Dependent |
| Coupling | Low | Medium | High |

---

# 6. Enterprise Examples

- Association: Customer places an Order.
- Aggregation: University has Professors.
- Composition: Order contains OrderItems.
- Composition: Car contains Engine components created internally.

---

# 7. UML Symbols

```text
Association

A -------- B

Aggregation

A ◇-------- B

Composition

A ◆-------- B
```

---

# 8. Best Practices

- Use association for collaboration.
- Use aggregation when objects have separate lifecycles.
- Use composition for strong ownership.
- Prefer composition over inheritance when appropriate.

---

# 9. Common Mistakes

❌ Confusing aggregation with composition.

❌ Using inheritance instead of composition.

❌ Creating tightly coupled designs unnecessarily.

---

# 10. Interview Questions

1. What is association?
2. Difference between aggregation and composition?
3. Which relationship represents weak ownership?
4. Which relationship has dependent lifecycle?
5. Why is composition often preferred?

---

# 11. Quick Revision

```text
Association
│
├── General relationship
├── Independent objects
│
Aggregation
│
├── Weak HAS-A
├── Independent lifecycle
│
Composition
│
├── Strong HAS-A
└── Dependent lifecycle
```

---

# 12. Summary

Association, aggregation, and composition model relationships between objects. Association represents collaboration, aggregation models weak ownership, and composition models strong ownership with dependent lifecycles. Choosing the correct relationship leads to flexible, maintainable, and enterprise-ready object-oriented designs.
