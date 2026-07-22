# Lesson 103 — Custom Exceptions

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Custom Exception** (also called a **User-Defined Exception**) is an exception created by a developer to represent application-specific error conditions.

Java provides many built-in exceptions, but business applications often require exceptions that describe domain-specific problems, such as:

- Invalid Employee ID
- Insufficient Balance
- Invalid Age
- Product Out of Stock
- Order Not Found

Creating custom exceptions makes code more meaningful, readable, and maintainable.

---

# 2. Why Create Custom Exceptions?

Built-in exceptions cannot represent every business rule.

Example:

Instead of throwing:

```java
throw new IllegalArgumentException("Invalid account.");
```

We can throw:

```java
throw new InvalidAccountException("Account does not exist.");
```

The second approach clearly communicates the actual problem.

---

# 3. Creating a Checked Custom Exception

To create a checked exception, extend the `Exception` class.

```java
class InvalidAgeException extends Exception {

    public InvalidAgeException(String message) {
        super(message);
    }
}
```

Since it extends `Exception`, callers must handle or declare it.

---

# 4. Using a Checked Custom Exception

```java
class VotingSystem {

    static void validateAge(int age)
            throws InvalidAgeException {

        if (age < 18) {
            throw new InvalidAgeException(
                    "Age must be at least 18.");
        }

        System.out.println("Eligible to vote.");
    }

    public static void main(String[] args) {

        try {
            validateAge(16);
        } catch (InvalidAgeException e) {
            System.out.println(e.getMessage());
        }
    }
}
```

Output:

```text
Age must be at least 18.
```

---

# 5. Creating an Unchecked Custom Exception

To create an unchecked exception, extend `RuntimeException`.

```java
class InvalidPasswordException
        extends RuntimeException {

    public InvalidPasswordException(String message) {
        super(message);
    }
}
```

Handling is optional because it is unchecked.

---

# 6. Throwing an Unchecked Custom Exception

```java
class Login {

    static void login(String password) {

        if (password.length() < 8) {

            throw new InvalidPasswordException(
                    "Password is too short.");
        }

        System.out.println("Login successful.");
    }
}
```

---

# 7. Checked vs Unchecked Custom Exceptions

| Checked | Unchecked |
|----------|-----------|
| Extends `Exception` | Extends `RuntimeException` |
| Compiler enforces handling | Compiler does not enforce handling |
| Recoverable conditions | Programming or validation errors |

---

# 8. Constructors in Custom Exceptions

A custom exception can provide multiple constructors.

```java
class PaymentException extends Exception {

    public PaymentException() {
    }

    public PaymentException(String message) {
        super(message);
    }

    public PaymentException(String message, Throwable cause) {
        super(message, cause);
    }
}
```

This supports exception chaining and flexible error reporting.

---

# 9. Best Practices

- Choose meaningful exception names ending with `Exception`.
- Include descriptive error messages.
- Use checked exceptions for recoverable problems.
- Use unchecked exceptions for programming errors.
- Avoid creating unnecessary exception classes.

---

# 10. Common Mistakes

❌ Creating custom exceptions without useful messages.

❌ Extending `Throwable` directly.

❌ Using checked exceptions for every validation error.

❌ Swallowing custom exceptions without logging or handling.

---

# 11. Advantages

- Domain-specific error reporting
- Better readability
- Easier debugging
- Cleaner business logic
- Improved API design

---

# 12. Interview Questions

1. What is a custom exception?
2. How do you create a checked custom exception?
3. How do you create an unchecked custom exception?
4. When should custom exceptions be used?
5. Why should exception names end with `Exception`?

---

# 13. Quick Revision

```text
Custom Exceptions
│
├── extends Exception
│      └── Checked
│
└── extends RuntimeException
       └── Unchecked
```

---

# 14. Interview Cheat Sheet

```text
Checked

class MyException extends Exception

Unchecked

class MyException
extends RuntimeException

✔ Meaningful Names
✔ Business-Specific Errors
✔ Better Readability
```

---

# 15. Summary

Custom exceptions allow developers to represent application-specific error conditions using meaningful exception types. Checked custom exceptions extend `Exception` and are suitable for recoverable conditions, while unchecked custom exceptions extend `RuntimeException` and are commonly used for programming and validation errors. Well-designed custom exceptions improve readability, debugging, and the overall quality of object-oriented applications.
