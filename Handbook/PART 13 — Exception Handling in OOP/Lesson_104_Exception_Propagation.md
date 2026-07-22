# Lesson 104 — Exception Propagation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Exception Propagation** is the process by which an exception moves from the method where it occurs to its calling method until it is handled.

If a method does not handle an exception, Java automatically passes it up the **call stack**. This continues until:

- A matching `catch` block is found, or
- The exception reaches the JVM, which terminates the program.

Exception propagation allows error handling to be centralized instead of handling every exception where it originates.

---

# 2. How Exception Propagation Works

Consider the following call sequence:

```text
main()
   │
   ▼
methodA()
   │
   ▼
methodB()
   │
   ▼
methodC()
```

If `methodC()` throws an exception and does not catch it:

```text
methodC()
   ▲
methodB()
   ▲
methodA()
   ▲
main()
```

The exception travels upward until it is handled.

---

# 3. Basic Example

```java
class Demo {

    static void methodC() {
        int result = 10 / 0;
    }

    static void methodB() {
        methodC();
    }

    static void methodA() {
        methodB();
    }

    public static void main(String[] args) {

        try {
            methodA();
        } catch (ArithmeticException e) {
            System.out.println("Handled: " + e.getMessage());
        }
    }
}
```

Output:

```text
Handled: / by zero
```

---

# 4. Propagation of Checked Exceptions

Checked exceptions must be either handled or declared using `throws`.

```java
import java.io.IOException;

class Demo {

    static void readFile() throws IOException {
        throw new IOException("File not found.");
    }

    public static void main(String[] args) {

        try {
            readFile();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
```

The exception is propagated using the `throws` clause.

---

# 5. The `throws` Keyword

The `throws` keyword declares that a method may pass an exception to its caller.

```java
void process() throws IOException {
    // risky code
}
```

It does **not** handle the exception. It only informs callers that handling may be required.

---

# 6. Stack Unwinding

When an exception propagates, Java removes method calls from the call stack one by one until a handler is found.

```text
Call Stack

main()
  │
methodA()
  │
methodB()
  │
methodC()  ← Exception

Stack Unwinding

methodC()
methodB()
methodA()
main()
```

This process is known as **stack unwinding**.

---

# 7. Advantages

- Centralized error handling
- Cleaner business logic
- Better code reuse
- Reduced duplicate `try-catch` blocks
- Easier maintenance

---

# 8. Best Practices

- Handle exceptions where meaningful recovery is possible.
- Use `throws` to delegate handling to higher layers.
- Avoid swallowing propagated exceptions.
- Preserve the original exception when wrapping another exception.

---

# 9. Common Mistakes

❌ Catching an exception only to ignore it.

```java
catch (Exception e) {
}
```

❌ Declaring overly broad exceptions unnecessarily.

❌ Losing the original cause while rethrowing.

---

# 10. Interview Questions

1. What is exception propagation?
2. How does Java propagate exceptions?
3. What is stack unwinding?
4. What is the purpose of the `throws` keyword?
5. Do unchecked exceptions also propagate?

---

# 11. Quick Revision

```text
Exception
   │
Thrown
   │
Method
   │
Caller
   │
Caller
   │
Handled or JVM
```

---

# 12. Interview Cheat Sheet

```text
Exception Propagation

✔ Travels up the call stack
✔ Uses throws for checked exceptions
✔ Stops at matching catch block
✔ Otherwise reaches JVM

Stack Unwinding
Method → Caller → Caller → main()
```

---

# 13. Summary

Exception propagation is the automatic process of passing an exception from the method where it occurs to successive calling methods until it is handled or reaches the JVM. Using propagation and the `throws` keyword allows applications to centralize error handling, reduce duplicated code, and separate business logic from exception management, resulting in cleaner and more maintainable object-oriented programs.
