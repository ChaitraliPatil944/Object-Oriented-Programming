# Lesson 106 — Business Exception Design

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

In enterprise applications, not every error is caused by a programming mistake or a system failure. Many errors occur because **business rules** are violated.

Examples include:

- Insufficient account balance
- Product out of stock
- Invalid coupon code
- Order already shipped
- User not authorized for an operation

These are known as **Business Exceptions**.

Business Exception Design focuses on creating meaningful, reusable, and maintainable exception classes that represent domain-specific rules.

---

# 2. What is a Business Exception?

A **Business Exception** is a custom exception that indicates a violation of business logic rather than a technical failure.

Examples:

- `InsufficientBalanceException`
- `InvalidOrderException`
- `DuplicateEmailException`
- `SeatNotAvailableException`

These exceptions help separate **business logic** from **technical concerns**.

---

# 3. Business Exceptions vs Technical Exceptions

| Business Exception | Technical Exception |
|--------------------|---------------------|
| Business rule violation | System or infrastructure problem |
| Often recoverable | May require retry or system fix |
| Meaningful to end users | Meaningful to developers/admins |
| Usually custom exceptions | Often built-in Java exceptions |

Example:

Business:

```text
Insufficient Balance
```

Technical:

```text
SQLException
```

---

# 4. Designing a Business Exception

A business exception is usually a custom exception.

```java
public class InsufficientBalanceException
        extends Exception {

    public InsufficientBalanceException(String message) {
        super(message);
    }
}
```

The name clearly describes the business rule.

---

# 5. Using a Business Exception

```java
class BankAccount {

    private double balance = 5000;

    public void withdraw(double amount)
            throws InsufficientBalanceException {

        if (amount > balance) {
            throw new InsufficientBalanceException(
                    "Insufficient account balance.");
        }

        balance -= amount;
    }
}
```

Caller:

```java
try {
    account.withdraw(7000);
} catch (InsufficientBalanceException e) {
    System.out.println(e.getMessage());
}
```

---

# 6. Exception Hierarchy in Enterprise Applications

```text
ApplicationException
│
├── BusinessException
│     ├── InvalidOrderException
│     ├── DuplicateEmailException
│     └── PaymentFailedException
│
└── TechnicalException
      ├── DatabaseException
      ├── NetworkException
      └── FileStorageException
```

A common base exception improves consistency across large projects.

---

# 7. Including Error Codes

Business exceptions often include error codes for APIs and logging.

```java
public class BusinessException extends Exception {

    private final String errorCode;

    public BusinessException(String errorCode,
                             String message) {
        super(message);
        this.errorCode = errorCode;
    }

    public String getErrorCode() {
        return errorCode;
    }
}
```

Example:

```text
BAL001 : Insufficient Balance
```

Error codes simplify debugging and client communication.

---

# 8. Best Practices

- Use descriptive exception names.
- Keep exception classes lightweight.
- Include meaningful messages.
- Add error codes when appropriate.
- Separate business exceptions from technical exceptions.
- Document when business exceptions may be thrown.

---

# 9. Common Mistakes

❌ Using generic `Exception` for business rules.

❌ Mixing technical and business errors in one exception class.

❌ Exposing sensitive system details to end users.

❌ Creating too many nearly identical exception classes without clear purpose.

---

# 10. Advantages

- Clear business rule representation
- Better readability
- Easier debugging
- Improved API design
- Consistent error handling across applications

---

# 11. Interview Questions

1. What is a business exception?
2. How is a business exception different from a technical exception?
3. Why are custom exceptions important in enterprise applications?
4. Why are error codes commonly included in business exceptions?
5. What are some examples of business exceptions?

---

# 12. Quick Revision

```text
Business Exception
│
├── Custom Exception
├── Business Rule Violation
├── Meaningful Message
├── Optional Error Code
└── Separate from Technical Exceptions
```

---

# 13. Interview Cheat Sheet

```text
Business Exception

✔ Domain-Specific Error
✔ Represents Business Rules
✔ Usually Custom Exception
✔ User-Friendly Message
✔ Optional Error Code

Examples

InsufficientBalanceException
DuplicateEmailException
InvalidOrderException
```

---

# 14. Summary

Business Exception Design is the practice of modeling business rule violations using meaningful custom exception classes. Unlike technical exceptions, business exceptions represent expected domain-specific conditions such as invalid orders, insufficient balance, or duplicate records. A well-designed business exception hierarchy, combined with descriptive messages and optional error codes, results in cleaner code, better API design, and more maintainable enterprise object-oriented applications.
