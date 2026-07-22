# Lesson 158 — Building a Banking Application

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Banking Application** is one of the best examples for understanding Object-Oriented Programming because it combines multiple OOP concepts with layered architecture.

A banking system typically supports:

- Customer management
- Account creation
- Deposits
- Withdrawals
- Fund transfers
- Transaction history

In enterprise applications, these features are implemented using Controllers, Services, Repositories, DTOs, and Domain Models.

---

# 2. High-Level Architecture

```text
                Client
                   │
            HTTP Request
                   │
          Controller Layer
                   │
            Service Layer
                   │
          Repository Layer
                   │
               Database
```

Each layer has a single responsibility.

---

# 3. Domain Model

```text
Customer
    │
    ├── Savings Account
    ├── Current Account
    │
    └── Transactions
```

Core entities include:

- Customer
- Account
- Transaction

Common value objects include:

- Money
- Address
- Email

---

# 4. Main Classes

```java
class Customer {
    Long customerId;
    String name;
}

class Account {
    Long accountNumber;
    double balance;
}

class Transaction {
    Long transactionId;
    double amount;
}
```

These entities represent the core banking domain.

---

# 5. Repository Layer

Repositories interact with the database.

```java
public interface AccountRepository {

    Account findById(Long id);

    Account save(Account account);
}
```

Persistence details remain hidden from business logic.

---

# 6. Service Layer

Business rules belong in services.

```java
@Service
public class AccountService {

    public void deposit(Account account,
                        double amount) {

        account.setBalance(
            account.getBalance() + amount);
    }
}
```

Typical responsibilities:

- Deposit
- Withdraw
- Transfer
- Balance validation
- Transaction recording

---

# 7. Controller Layer

```java
@RestController
@RequestMapping("/accounts")
public class AccountController {

    @PostMapping("/deposit")
    public String deposit() {

        return "Amount Deposited";
    }
}
```

Controllers receive requests and delegate work to services.

---

# 8. DTOs

```text
DepositRequestDTO

AccountNumber
Amount
```

```text
AccountResponseDTO

AccountNumber
Balance
Status
```

DTOs protect internal entities from direct exposure.

---

# 9. Banking Workflow

```text
Customer

     │
Deposit Request

     │
Controller

     │
Service

     │
Repository

     │
Database

     │
Updated Balance
```

Each request flows through the application's layers.

---

# 10. Applying OOP Principles

### Encapsulation

Keep account data private.

```java
private double balance;
```

---

### Inheritance

```text
Account
   │
   ├── SavingsAccount
   └── CurrentAccount
```

Both account types share common behavior.

---

### Polymorphism

```java
account.calculateInterest();
```

Different account types can implement interest calculation differently.

---

### Abstraction

Expose operations like:

```java
deposit()

withdraw()

transfer()
```

Users interact with operations, not implementation details.

---

# 11. Additional Features

Real banking systems often include:

- Authentication
- Authorization
- Audit logs
- Notifications
- Interest calculation
- Loan management
- Scheduled payments
- Fraud detection

Because apparently money likes attracting complexity almost as much as it attracts meetings.

---

# 12. Best Practices

- Validate every transaction.
- Use DTOs between layers.
- Keep business logic in services.
- Use repositories for persistence only.
- Apply transactions for atomic operations.
- Follow SOLID principles.

---

# 13. Interview Questions

1. Design a banking application using OOP.
2. Which classes are entities?
3. How would you implement fund transfer?
4. Why should business logic be in the service layer?
5. Which OOP principles are used?

---

# 14. Quick Revision

```text
Banking Application

Controller
      │
Service
      │
Repository
      │
Database

Entities

Customer
Account
Transaction

OOP

Encapsulation
Inheritance
Polymorphism
Abstraction
```

---

# 15. Interview Cheat Sheet

```text
Architecture

Controller
Service
Repository
Database

Core Classes

Customer
Account
Transaction

Operations

Deposit
Withdraw
Transfer
Balance Inquiry

Principles

SOLID
Layered Architecture
DTO
Repository Pattern
```

---

# 16. Summary

A banking application demonstrates how Object-Oriented Programming concepts combine with enterprise architecture to build scalable software. By organizing the application into controllers, services, repositories, DTOs, and domain entities while applying encapsulation, inheritance, polymorphism, and abstraction, developers create systems that are secure, maintainable, and easy to extend.
