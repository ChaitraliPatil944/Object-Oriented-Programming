# Lesson 38 — Validation using Encapsulation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the greatest advantages of encapsulation is that it allows a class to **validate data before updating its internal state**.

Instead of allowing users to directly modify variables, a class can verify that every value satisfies business rules.

This ensures objects always remain in a valid state.

---

# 2. Why Validation is Important

Without validation:

```java
employee.setSalary(-5000);
employee.setAge(-10);
employee.setEmail("abc");
```

Invalid data enters the system.

With validation, such updates are rejected.

---

# 3. Validation through Setters

```java
class Employee {

    private double salary;

    public void setSalary(double salary) {
        if (salary >= 0) {
            this.salary = salary;
        }
    }
}
```

The object's state changes only if the input is valid.

---

# 4. Common Validation Rules

Examples include:

- Age must be positive.
- Salary cannot be negative.
- Email must follow a valid format.
- Password should meet complexity requirements.
- Quantity should be greater than zero.

---

# 5. Example: Student Marks

```java
class Student {

    private int marks;

    public void setMarks(int marks) {
        if (marks >= 0 && marks <= 100) {
            this.marks = marks;
        }
    }

    public int getMarks() {
        return marks;
    }
}
```

Only valid marks are accepted.

---

# 6. Throwing Exceptions

Instead of silently ignoring invalid input, setters can throw exceptions.

```java
public void setAge(int age) {

    if(age < 0){
        throw new IllegalArgumentException("Age cannot be negative.");
    }

    this.age = age;
}
```

This clearly informs the caller that the input is invalid.

---

# 7. Business Methods over Generic Setters

Rather than exposing unrestricted setters:

```java
account.setBalance(1000000);
```

prefer business methods:

```java
account.deposit(1000);
account.withdraw(500);
```

Each method enforces business rules.

---

# 8. Enterprise Example

```java
class BankAccount {

    private double balance;

    public void deposit(double amount) {

        if(amount <= 0){
            throw new IllegalArgumentException("Invalid amount");
        }

        balance += amount;
    }

    public void withdraw(double amount){

        if(amount <= 0 || amount > balance){
            throw new IllegalArgumentException("Invalid withdrawal");
        }

        balance -= amount;
    }
}
```

The account can never reach an invalid balance through the public API.

---

# 9. Validation Flow

```text
User Input
     │
     ▼
Public Method
     │
Validation
 ├── Valid ─────► Update Object
 └── Invalid ───► Reject / Exception
```

---

# 10. Benefits

- Prevents invalid object states
- Enforces business rules
- Improves reliability
- Makes debugging easier
- Protects data integrity

---

# 11. Common Mistakes

❌ Providing setters without validation.

❌ Exposing public fields.

❌ Allowing business rules to be bypassed.

❌ Returning mutable internal objects directly.

---

# 12. Best Practices

- Validate all external input.
- Throw meaningful exceptions for invalid values.
- Prefer business methods to generic setters.
- Keep validation close to the data it protects.
- Keep fields private.

---

# 13. Interview Questions

1. Why is validation important in encapsulation?
2. Where should validation logic be placed?
3. Should setters silently ignore invalid values?
4. Why are business methods often preferred over setters?
5. Which exception is commonly thrown for invalid arguments?

---

# 14. Summary

Validation using encapsulation ensures that objects remain in a valid and consistent state throughout their lifetime. By keeping fields private and validating input through setters or business methods, developers can enforce business rules, improve application reliability, and prevent invalid data from entering the system. This approach is widely used in enterprise Java applications to maintain data integrity and robust software design.
