# Lesson 101 — Introduction to Exceptions

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **Exception** is an event that occurs during the execution of a program and interrupts the normal flow of instructions.

Instead of crashing unexpectedly, Java provides an **exception handling mechanism** that allows developers to detect, handle, and recover from runtime errors gracefully.

Exception handling is one of Java's core features for building **robust, reliable, and maintainable** applications.

---

# 2. Why Do We Need Exception Handling?

Without exception handling:

- Programs terminate abruptly.
- Resources may not be released properly.
- Users receive poor error messages.

With exception handling:

- Errors can be handled gracefully.
- Program execution may continue.
- Resources can be cleaned up safely.
- Applications become more reliable.

---

# 3. What Causes Exceptions?

Common causes include:

- Division by zero
- Accessing an invalid array index
- Reading a missing file
- Invalid user input
- Database or network failures
- Null object references

Example:

```java
int result = 10 / 0;
```

Produces:

```text
ArithmeticException
```

---

# 4. Exception Hierarchy

```text
Object
│
└── Throwable
    ├── Error
    └── Exception
         ├── RuntimeException
         └── Checked Exceptions
```

- **Error**: Serious JVM problems (generally not handled).
- **Exception**: Conditions applications can handle.

---

# 5. Exception Handling Keywords

| Keyword | Purpose |
|---------|---------|
| `try` | Encloses risky code |
| `catch` | Handles an exception |
| `finally` | Executes regardless of exception |
| `throw` | Explicitly throws an exception |
| `throws` | Declares possible exceptions |

---

# 6. Basic Example

```java
public class Demo {

    public static void main(String[] args) {

        try {
            int result = 10 / 0;
            System.out.println(result);
        } catch (ArithmeticException e) {
            System.out.println("Cannot divide by zero.");
        }

        System.out.println("Program continues...");
    }
}
```

Output:

```text
Cannot divide by zero.
Program continues...
```

---

# 7. The `finally` Block

The `finally` block executes whether an exception occurs or not.

```java
try {
    System.out.println("Working...");
} finally {
    System.out.println("Cleanup completed.");
}
```

Typical uses:

- Closing files
- Closing database connections
- Releasing network resources

---

# 8. Benefits of Exception Handling

- Prevents abrupt program termination
- Improves code readability
- Separates error handling from business logic
- Simplifies debugging
- Supports reliable applications

---

# 9. Best Practices

- Catch only exceptions you can handle.
- Prefer specific exception types over generic `Exception`.
- Keep `try` blocks small.
- Use meaningful error messages.
- Release resources properly.

---

# 10. Common Mistakes

❌ Catching every exception blindly.

```java
catch (Exception e) { }
```

❌ Ignoring exceptions.

```java
catch (Exception e) { }
```

❌ Using exceptions for normal program flow.

---

# 11. Interview Questions

1. What is an exception?
2. Difference between an error and an exception?
3. Why is exception handling important?
4. What are the five exception handling keywords?
5. What is the purpose of the `finally` block?

---

# 12. Quick Revision

```text
Exception Handling
│
├── try
├── catch
├── finally
├── throw
└── throws
```

---

# 13. Interview Cheat Sheet

```text
Exception

✔ Runtime abnormal event
✔ Interrupts normal flow

Keywords
try
catch
finally
throw
throws

Hierarchy
Throwable
 ├─ Error
 └─ Exception
```

---

# 14. Summary

Exceptions represent abnormal conditions that occur during program execution. Java's exception handling mechanism uses `try`, `catch`, `finally`, `throw`, and `throws` to detect and manage these situations. Proper exception handling prevents unexpected crashes, improves reliability, and helps developers build maintainable object-oriented applications.
