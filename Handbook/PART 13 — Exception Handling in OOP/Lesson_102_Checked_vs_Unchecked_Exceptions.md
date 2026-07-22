# Lesson 102 — Checked vs Unchecked Exceptions

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Java exceptions are broadly divided into two categories:

1. **Checked Exceptions**
2. **Unchecked Exceptions**

Understanding the difference is essential because it determines whether the compiler forces exception handling and how applications should be designed.

---

# 2. Checked Exceptions

A **checked exception** is verified by the compiler.

If a method may throw a checked exception, it must either:

- Handle it using `try-catch`, or
- Declare it using `throws`

### Example

```java
import java.io.*;

class Demo {

    public static void main(String[] args) {

        try (FileReader reader = new FileReader("data.txt")) {
            System.out.println("File opened.");
        } catch (IOException e) {
            System.out.println("File could not be read.");
        }
    }
}
```

Common checked exceptions:

- IOException
- SQLException
- ClassNotFoundException
- InterruptedException

---

# 3. Unchecked Exceptions

Unchecked exceptions occur at runtime and are **not** checked by the compiler.

They generally indicate programming errors.

### Example

```java
int[] arr = {1, 2, 3};

System.out.println(arr[5]);
```

Output:

```text
ArrayIndexOutOfBoundsException
```

Common unchecked exceptions:

- NullPointerException
- ArithmeticException
- IllegalArgumentException
- NumberFormatException
- ClassCastException
- ArrayIndexOutOfBoundsException

---

# 4. Exception Hierarchy

```text
Throwable
│
├── Error
│
└── Exception
     ├── RuntimeException
     │     └── Unchecked Exceptions
     │
     └── Checked Exceptions
```

`RuntimeException` and its subclasses are unchecked.

---

# 5. Compiler Behavior

### Checked Exception

```java
FileReader reader = new FileReader("test.txt");
```

Compilation fails unless handled or declared.

### Unchecked Exception

```java
String s = null;

System.out.println(s.length());
```

Compiles successfully but fails at runtime.

---

# 6. Comparison

| Feature | Checked | Unchecked |
|---------|---------|-----------|
| Compiler checks | Yes | No |
| Must handle/declare | Yes | No |
| Occurs | Compile-time enforcement | Runtime |
| Typical cause | External resources | Programming mistakes |

---

# 7. When to Use Each

Use **checked exceptions** for recoverable conditions:

- Missing files
- Database connectivity
- Network communication

Use **unchecked exceptions** for programming errors:

- Invalid method arguments
- Null references
- Logic bugs

---

# 8. Advantages

### Checked Exceptions

- Encourages proper error handling
- Improves reliability
- Suitable for recoverable failures

### Unchecked Exceptions

- Less boilerplate
- Cleaner APIs
- Highlights coding mistakes

---

# 9. Best Practices

- Catch checked exceptions where recovery is possible.
- Do not ignore checked exceptions.
- Use unchecked exceptions for invalid API usage.
- Avoid catching generic `Exception` unless necessary.

---

# 10. Common Mistakes

❌ Converting every exception into `RuntimeException`.

❌ Catching exceptions and doing nothing.

```java
catch (IOException e) { }
```

❌ Using checked exceptions for simple validation errors.

---

# 11. Interview Questions

1. What is a checked exception?
2. What is an unchecked exception?
3. Give examples of both.
4. Why are runtime exceptions unchecked?
5. When should checked exceptions be preferred?

---

# 12. Quick Revision

```text
Exceptions
│
├── Checked
│    ├── Compiler Checked
│    └── Handle or Declare
│
└── Unchecked
     ├── Runtime
     └── Programming Errors
```

---

# 13. Interview Cheat Sheet

```text
Checked

✔ Compiler Checks
✔ try-catch or throws Required

Examples
IOException
SQLException

Unchecked

✔ RuntimeException
✔ No Compiler Check

Examples
NullPointerException
ArithmeticException
```

---

# 14. Summary

Checked exceptions represent recoverable conditions that the compiler requires developers to handle or declare. Unchecked exceptions, derived from `RuntimeException`, represent programming errors that are detected only during execution. Choosing the appropriate type of exception improves API design, application reliability, and code maintainability.
