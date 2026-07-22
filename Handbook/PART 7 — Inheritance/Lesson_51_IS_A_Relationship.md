# Lesson 51 — IS-A Relationship

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **IS-A relationship** is the fundamental principle behind inheritance in Object-Oriented Programming.

A child class should inherit from a parent class **only if the child is a specialized form of the parent**.

Inheritance models **classification**, not ownership.

---

# 2. Definition

An IS-A relationship means:

> **A subclass IS A type of its superclass.**

Examples:

- Dog **is an** Animal
- Car **is a** Vehicle
- Manager **is an** Employee

---

# 3. Visual Representation

```text
Animal
   ▲
   │
 Dog

Vehicle
   ▲
   │
 Car
```

The arrow points from the specialized class to the more general class.

---

# 4. Java Example

```java
class Animal {

    void eat() {
        System.out.println("Eating...");
    }
}

class Dog extends Animal {

    void bark() {
        System.out.println("Barking...");
    }
}
```

A `Dog` object can perform both `eat()` and `bark()` because a Dog **is an** Animal.

---

# 5. Valid IS-A Relationships

```text
Employee
    ▲
    │
 Manager

Shape
   ▲
   │
Circle

Account
   ▲
   │
SavingsAccount
```

Each child is a specialized version of the parent.

---

# 6. Invalid Relationships

```text
Car
 ▲
 │
Engine   ❌

Person
 ▲
 │
Address  ❌
```

An engine is **part of** a car, but it is **not** a car.

These represent a **HAS-A** relationship, not an IS-A relationship.

---

# 7. IS-A vs HAS-A

| IS-A | HAS-A |
|------|--------|
| Uses inheritance | Uses composition |
| Represents specialization | Represents ownership |
| `extends` | Object reference |
| Dog is an Animal | Car has an Engine |

---

# 8. Enterprise Example

```java
class User {

    void login() {
        System.out.println("Login");
    }
}

class Admin extends User {

    void manageUsers() {
        System.out.println("Managing Users");
    }
}
```

An `Admin` **is a** `User`, making inheritance appropriate.

---

# 9. Why IS-A Matters

Using inheritance incorrectly leads to:

- Tight coupling
- Poor design
- Difficult maintenance
- Confusing class hierarchies

Always ask:

> "Can I honestly say the child **is a** parent?"

If the answer is "no", inheritance is probably the wrong choice.

---

# 10. UML Example

```text
      +-----------+
      | Employee  |
      +-----------+
            ▲
            │
      +-----------+
      | Manager   |
      +-----------+
```

---

# 11. Best Practices

- Use inheritance only for true specialization.
- Prefer composition for ownership.
- Keep hierarchies shallow.
- Design for clarity rather than convenience.

---

# 12. Common Mistakes

❌ Using inheritance just to reuse code.

❌ Creating unrelated parent-child relationships.

❌ Confusing IS-A with HAS-A.

---

# 13. Interview Questions

1. What is an IS-A relationship?
2. Why is it important in inheritance?
3. Give valid and invalid examples.
4. What is the difference between IS-A and HAS-A?
5. When should composition be preferred?

---

# 14. Summary

The IS-A relationship is the foundation of inheritance in Java. A subclass should inherit from a superclass only when it represents a more specific version of that class. Understanding the difference between IS-A and HAS-A leads to cleaner object-oriented designs, better maintainability, and more flexible enterprise applications.
