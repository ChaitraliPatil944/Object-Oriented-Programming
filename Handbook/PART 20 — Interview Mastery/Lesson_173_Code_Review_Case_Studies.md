# Lesson 173 — Code Review Case Studies

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Code reviews are an essential part of professional software development. They help identify bugs, improve readability, enforce coding standards, and ensure that Object-Oriented Programming principles are correctly applied.

Interviewers may present code snippets and ask you to review them, identify issues, and suggest improvements.

---

# 2. Code Review Checklist

Before reviewing code, examine:

- Correctness
- Readability
- Maintainability
- Performance
- Security
- SOLID principles
- Error handling
- Naming conventions

---

# 3. Case Study 1: Public Fields

### Bad Code

```java
class BankAccount {
    public double balance;
}
```

### Problems

- Breaks encapsulation
- Allows uncontrolled modification

### Improved Code

```java
class BankAccount {

    private double balance;

    public double getBalance() {
        return balance;
    }

    public void deposit(double amount) {
        balance += amount;
    }
}
```

---

# 4. Case Study 2: God Class

### Bad Design

```text
EmployeeManager

Authentication
Salary
Database
Logging
Email
Reports
```

### Problems

- Violates Single Responsibility Principle
- Difficult to maintain and test

### Improved Design

```text
EmployeeService
SalaryService
EmailService
ReportService
```

---

# 5. Case Study 3: Tight Coupling

### Bad Code

```java
class NotificationService {

    private EmailService email =
            new EmailService();
}
```

### Problems

- Hard to replace implementation
- Difficult to unit test

### Improved Code

```java
class NotificationService {

    private final MessageService service;

    NotificationService(MessageService service) {
        this.service = service;
    }
}
```

Use dependency injection and interfaces.

---

# 6. Case Study 4: Large Method

### Bad Code

```text
processOrder()

Validate
Calculate Total
Save Order
Send Email
Generate Invoice
Update Inventory
```

### Problems

- Too many responsibilities
- Hard to debug

### Improved Design

Split into smaller methods:

```text
validateOrder()
calculateTotal()
saveOrder()
sendConfirmation()
updateInventory()
```

---

# 7. Case Study 5: Business Logic in Controller

### Bad Design

```text
Controller

Validation
Calculation
Database Access
Response
```

### Improved Design

```text
Controller
     │
Service
     │
Repository
```

Controllers should delegate business operations to services.

---

# 8. Case Study 6: Returning Entities

### Bad

```java
return userEntity;
```

### Better

```java
return userDTO;
```

Benefits:

- Hides internal fields
- Stable API contracts
- Better security

---

# 9. Case Study 7: Wrong Collection Choice

### Bad

```java
LinkedList<String> list;
```

Used only for random access.

### Better

```java
ArrayList<String> list;
```

Choose collections based on access patterns.

---

# 10. Case Study 8: Poor Naming

### Bad

```text
doTask()
temp
data
obj
```

### Better

```text
calculateSalary()
processPayment()
customerRepository
```

Good names improve communication and maintenance.

---

# 11. Common Review Comments

- Extract duplicated code.
- Reduce method size.
- Follow naming conventions.
- Remove unused variables.
- Improve exception handling.
- Replace magic numbers with constants.
- Depend on interfaces.

Because future developers are almost always you, just several months older and substantially less forgiving.

---

# 12. Interview Strategy

When reviewing code:

1. Explain what the code does.
2. Identify problems.
3. Mention violated principles.
4. Suggest improvements.
5. Explain trade-offs.

---

# 13. Interview Questions

1. What do you look for during a code review?
2. How do you identify code smells?
3. Why is dependency injection useful?
4. How do SOLID principles help in reviews?
5. What are common code review mistakes?

---

# 14. Quick Revision

```text
Review

✔ Readability
✔ SOLID
✔ Encapsulation
✔ Naming
✔ Layering
✔ Performance
✔ Security
```

---

# 15. Interview Cheat Sheet

```text
Code Review

Check

Correctness
Readability
Maintainability
Performance
Security

Avoid

God Classes
Large Methods
Tight Coupling
Public Fields
Business Logic in Controllers

Prefer

SOLID
DTOs
Dependency Injection
Layered Architecture
Meaningful Names
```

---

# 16. Summary

Code reviews focus on improving software quality by identifying design flaws, code smells, and maintainability issues. A strong reviewer evaluates correctness, readability, architecture, and adherence to OOP principles, then proposes practical improvements using concepts such as SOLID, dependency injection, encapsulation, and layered design.
