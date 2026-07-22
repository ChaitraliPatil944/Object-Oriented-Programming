# Lesson 172 — Common Mistakes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Many interview candidates understand OOP concepts but lose marks because they repeatedly make common design and coding mistakes.

Recognizing these mistakes helps you write cleaner, more maintainable, and interview-ready code.

---

# 2. Mistake 1: God Classes

A single class handling authentication, payments, logging, database access, and reporting violates the **Single Responsibility Principle (SRP)**.

**Correct Approach**

Split responsibilities into focused classes.

```text
UserService
PaymentService
ReportService
```

---

# 3. Mistake 2: Tight Coupling

Bad:

```java
PaymentService service = new CreditCardPayment();
```

Better:

```java
PaymentService service;
```

Depend on interfaces and inject implementations.

---

# 4. Mistake 3: Misusing Inheritance

Bad hierarchy:

```text
Vehicle
   │
Airplane
```

when no true "is-a" relationship exists.

Prefer **composition** whenever inheritance does not naturally model the domain.

---

# 5. Mistake 4: Weak Encapsulation

Bad:

```java
public double balance;
```

Better:

```java
private double balance;
```

Expose behavior through methods instead of public fields.

---

# 6. Mistake 5: Large Methods

Methods that perform many unrelated tasks become difficult to test and maintain.

**Rule**

One method → One responsibility.

---

# 7. Mistake 6: Ignoring SOLID

Examples:

- Multiple responsibilities
- Modifying existing classes for every new feature
- Depending on concrete classes

Applying SOLID improves flexibility and maintainability.

---

# 8. Mistake 7: Business Logic in Controllers

Bad:

```text
Controller
   │
Business Logic
Database
```

Better:

```text
Controller
     │
Service
     │
Repository
```

Controllers should delegate work.

---

# 9. Mistake 8: Returning Entities Directly

Expose DTOs instead of persistence entities.

Benefits:

- Better security
- Stable APIs
- Reduced coupling

---

# 10. Mistake 9: Poor Naming

Avoid names like:

```text
temp
data
obj
doWork
```

Prefer:

```text
calculateSalary
processPayment
findCustomer
```

Meaningful names improve readability.

---

# 11. Mistake 10: Premature Optimization

Do not optimize without evidence.

Correct process:

```text
Correct Code
     │
Measure
     │
Profile
     │
Optimize
```

---

# 12. Interview Mistakes

- Memorizing definitions only
- Ignoring trade-offs
- Forgetting real-world examples
- Not explaining design decisions
- Confusing overloading with overriding

Because confidently explaining the wrong concept is still the wrong concept. Interviews have a remarkable talent for exposing that.

---

# 13. Best Practices

- Follow SOLID principles.
- Keep classes cohesive.
- Prefer composition over inheritance.
- Program to interfaces.
- Keep controllers thin.
- Write small, testable methods.
- Use DTOs and layered architecture.

---

# 14. Interview Questions

1. Why are God classes harmful?
2. What causes tight coupling?
3. Why prefer composition over inheritance?
4. Why shouldn't controllers contain business logic?
5. How do SOLID principles prevent common mistakes?

---

# 15. Quick Revision

```text
Avoid

✘ God Classes
✘ Tight Coupling
✘ Public Fields
✘ Large Methods
✘ Business Logic in Controllers
✘ Premature Optimization

Prefer

✔ SOLID
✔ Composition
✔ DTOs
✔ Services
✔ Repositories
✔ Clean Naming
```

---

# 16. Summary

Common OOP mistakes usually arise from unclear responsibilities, excessive coupling, poor encapsulation, and weak architectural decisions. By following SOLID principles, using layered architecture, preferring composition, and writing focused, readable code, developers can avoid these pitfalls and produce enterprise-quality software.
