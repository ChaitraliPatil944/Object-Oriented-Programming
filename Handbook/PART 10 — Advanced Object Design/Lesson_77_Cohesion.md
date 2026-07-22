# Lesson 77 — Cohesion

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Cohesion** measures how closely related the responsibilities of a class or module are.

- **High Cohesion** → Preferred
- **Low Cohesion** → Avoid

A highly cohesive class performs one well-defined task, making software easier to understand, maintain, and test.

---

# 2. Definition

Cohesion is the degree to which the elements of a class belong together.

```text
Class
 │
 ├── Responsibility 1
 ├── Responsibility 2
 └── Responsibility 3
```

The more closely these responsibilities are related, the higher the cohesion.

---

# 3. Types of Cohesion

## Low Cohesion

A single class performs many unrelated tasks.

```java
class EmployeeManager {

    void addEmployee() { }

    void generateSalary() { }

    void sendEmail() { }

    void backupDatabase() { }
}
```

This class violates the Single Responsibility Principle.

## High Cohesion

Each class has one primary responsibility.

```java
class EmployeeService {
    void addEmployee() { }
}

class SalaryService {
    void generateSalary() { }
}

class EmailService {
    void sendEmail() { }
}
```

---

# 4. Real-World Example

```text
Restaurant

Chef → Cooks Food

Cashier → Handles Payments

Waiter → Serves Customers
```

Each person performs a specific responsibility.

---

# 5. Enterprise Example

```text
Controller
      │
      ▼
Service
      │
      ▼
Repository
```

Each layer has a single, focused responsibility.

---

# 6. Cohesion vs Coupling

| Cohesion | Coupling |
|----------|----------|
| Internal quality | Relationship between classes |
| High is good | Low is good |
| Single responsibility | Loose dependency |
| Within one module | Between modules |

---

# 7. Advantages of High Cohesion

- Easier maintenance
- Better readability
- Simpler testing
- Improved code reuse
- Easier debugging

---

# 8. Best Practices

- Follow the Single Responsibility Principle.
- Keep classes small and focused.
- Separate unrelated functionality.
- Design meaningful modules.

---

# 9. Common Mistakes

❌ One class handling multiple unrelated tasks.

❌ Mixing UI, business logic, and database code.

❌ Ignoring separation of responsibilities.

---

# 10. Interview Questions

1. What is cohesion?
2. Difference between cohesion and coupling?
3. Why is high cohesion preferred?
4. How does SRP improve cohesion?
5. Give enterprise examples.

---

# 11. Quick Revision

```text
Cohesion
│
├── High Cohesion ✅
│   ├── One responsibility
│   ├── Easy maintenance
│   └── Better testing
│
└── Low Cohesion ❌
    ├── Multiple responsibilities
    ├── Difficult debugging
    └── Hard maintenance
```

---

# 12. Summary

Cohesion measures how well the responsibilities within a class or module relate to each other. High cohesion produces focused, maintainable, and reusable components, while low cohesion leads to complex and difficult-to-maintain software. Enterprise applications strive for **high cohesion** along with **low coupling** to achieve clean and scalable architectures.
