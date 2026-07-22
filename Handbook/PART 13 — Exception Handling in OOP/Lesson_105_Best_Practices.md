# Lesson 105 — Best Practices for Exception Handling

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Writing `try-catch` blocks is only a small part of exception handling. Well-designed applications follow **exception handling best practices** to produce code that is reliable, maintainable, secure, and easy to debug.

Poor exception handling can hide bugs, make troubleshooting difficult, and reduce application performance.

---

# 2. Handle Exceptions at the Appropriate Level

Handle an exception **only where meaningful recovery is possible**.

Bad Example:

```java
try {
    processPayment();
} catch (Exception e) {
    System.out.println("Error");
}
```

Better Example:

```java
try {
    processPayment();
} catch (PaymentException e) {
    System.out.println(e.getMessage());
}
```

Use specific exception types whenever possible.

---

# 3. Catch Specific Exceptions

Avoid catching generic exceptions unnecessarily.

Bad:

```java
catch (Exception e) {
}
```

Good:

```java
catch (IOException e) {
}
```

Specific catches improve readability and prevent accidental handling of unrelated problems.

---

# 4. Never Swallow Exceptions

Ignoring exceptions hides important information.

Bad:

```java
try {
    readFile();
} catch (IOException e) {
}
```

Good:

```java
try {
    readFile();
} catch (IOException e) {
    System.out.println(e.getMessage());
}
```

Always log, rethrow, or handle exceptions appropriately.

---

# 5. Keep `try` Blocks Small

Only include statements that may throw exceptions.

Bad:

```java
try {
    initialize();
    readFile();
    processData();
    printResult();
}
```

Good:

```java
initialize();

try {
    readFile();
} catch (IOException e) {
    System.out.println(e.getMessage());
}

processData();
printResult();
```

Smaller `try` blocks simplify debugging.

---

# 6. Use `finally` or Try-with-Resources

Resources such as files, sockets, and database connections must always be released.

Traditional:

```java
finally {
    reader.close();
}
```

Modern Java:

```java
try (FileReader reader = new FileReader("data.txt")) {
    // use reader
}
```

`try-with-resources` automatically closes resources.

---

# 7. Preserve the Original Exception

When wrapping exceptions, keep the original cause.

```java
catch (IOException e) {

    throw new RuntimeException(
        "Unable to read configuration.", e);
}
```

This preserves the exception chain for debugging.

---

# 8. Use Custom Exceptions for Business Rules

Instead of generic exceptions:

```java
throw new Exception("Invalid order.");
```

Prefer:

```java
throw new InvalidOrderException(
    "Order ID does not exist.");
```

Meaningful exception names improve readability.

---

# 9. Avoid Using Exceptions for Normal Flow

Incorrect:

```java
try {
    int value = list.get(index);
} catch (IndexOutOfBoundsException e) {
    // expected logic
}
```

Better:

```java
if (index < list.size()) {
    int value = list.get(index);
}
```

Exceptions should represent exceptional situations, not regular program logic.

---

# 10. Document Thrown Exceptions

Public methods should clearly document exceptions.

```java
/**
 * Reads a configuration file.
 *
 * @throws IOException
 * if the file cannot be read.
 */
```

This helps API users understand expected behavior.

---

# 11. Advantages of Following Best Practices

- Easier debugging
- Cleaner code
- Better maintainability
- Improved reliability
- More meaningful error reporting

---

# 12. Common Mistakes

❌ Catching `Exception` everywhere.

❌ Ignoring exceptions.

❌ Printing stack traces in production code.

❌ Using exceptions for ordinary control flow.

❌ Losing the original exception while rethrowing.

---

# 13. Interview Questions

1. Why should specific exceptions be caught?
2. Why is swallowing exceptions dangerous?
3. What is try-with-resources?
4. Why should exceptions preserve the original cause?
5. Why shouldn't exceptions be used for normal program flow?

---

# 14. Quick Revision

```text
Best Practices
│
├── Catch Specific Exceptions
├── Keep try Small
├── Use finally / Try-with-Resources
├── Preserve Causes
├── Use Custom Exceptions
└── Don't Ignore Exceptions
```

---

# 15. Interview Cheat Sheet

```text
✔ Catch Specific Exceptions
✔ Don't Swallow Exceptions
✔ Keep try Blocks Small
✔ Use Try-with-Resources
✔ Preserve Exception Cause
✔ Avoid Exceptions for Normal Logic
✔ Use Custom Exceptions
```

---

# 16. Summary

Effective exception handling is more than simply catching errors. Developers should catch specific exceptions, keep `try` blocks focused, release resources properly, preserve original causes when rethrowing, and use custom exceptions for business rules. Following these best practices leads to cleaner, more maintainable, and more reliable object-oriented applications while making debugging significantly easier.
