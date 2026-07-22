# Lesson 163 — How Method Calls Work

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Whenever a Java program calls a method, the JVM performs a series of steps behind the scenes. Understanding this process is important because every object-oriented program depends on method invocation.

A method call involves:

- Locating the method
- Passing arguments
- Creating a stack frame
- Executing bytecode
- Returning a value

---

# 2. Example

```java
public class Demo {

    public static void main(String[] args) {
        Calculator c = new Calculator();
        int result = c.add(10, 20);
        System.out.println(result);
    }
}

class Calculator {

    public int add(int a, int b) {
        return a + b;
    }
}
```

The call `c.add(10, 20)` triggers several JVM operations.

---

# 3. Method Call Flow

```text
Caller Method
      │
      ▼
Locate Method
      │
      ▼
Create Stack Frame
      │
      ▼
Pass Parameters
      │
      ▼
Execute Bytecode
      │
      ▼
Return Value
```

---

# 4. Stack Frames

Each method invocation creates a **stack frame** on the JVM stack.

A stack frame stores:

- Local variables
- Parameters
- Operand stack
- Return address

```text
JVM Stack

+------------------+
| add() Frame      |
+------------------+
| main() Frame     |
+------------------+
```

When `add()` finishes, its frame is removed.

---

# 5. Parameter Passing

Java uses **pass-by-value**.

Primitive values:

```java
add(10, 20);
```

Copies of the values are passed.

Object references:

```java
student.print();
```

A copy of the reference is passed, not the object itself.

---

# 6. Bytecode Instructions

A method call is represented by bytecode instructions.

Common invocation instructions:

| Instruction | Purpose |
|-------------|---------|
| `invokevirtual` | Call instance method |
| `invokestatic` | Call static method |
| `invokespecial` | Constructors, private methods, `super` |
| `invokeinterface` | Interface methods |
| `invokedynamic` | Dynamic language support, lambdas |

---

# 7. Instance Method Call

```java
Calculator c = new Calculator();
c.add(5, 3);
```

Simplified flow:

```text
Object Reference
      │
invokevirtual
      │
Method Found
      │
Execute
```

The JVM uses the object's runtime type to locate the appropriate implementation.

---

# 8. Static Method Call

```java
Math.max(5, 8);
```

Static methods belong to the class.

```text
Class
   │
invokestatic
   │
Execute
```

No object instance is required.

---

# 9. Method Return

When execution completes:

- The return value is pushed to the caller.
- The current stack frame is destroyed.
- Execution resumes in the calling method.

```text
Caller
   │
Call Method
   │
Return Value
   │
Continue
```

---

# 10. Nested Calls

```java
main()
 └── login()
      └── validate()
           └── checkPassword()
```

Each nested call creates another stack frame.

---

# 11. Recursion

Recursive methods repeatedly call themselves.

```java
factorial(5)
```

Each recursive call creates a new frame until the base case is reached.

Too many recursive calls can cause:

```text
StackOverflowError
```

Because the JVM stack is finite. Infinite recursion is optimism colliding with memory limits.

---

# 12. Best Practices

- Keep methods short and focused.
- Avoid unnecessary recursion.
- Minimize deeply nested calls.
- Use descriptive method names.
- Understand stack behavior for debugging.

---

# 13. Interview Questions

1. How does a method call work in Java?
2. What is a stack frame?
3. How are parameters passed?
4. Difference between `invokevirtual` and `invokestatic`?
5. Why does recursion cause `StackOverflowError`?

---

# 14. Quick Revision

```text
Method Call

Locate Method
      │
Stack Frame
      │
Execute
      │
Return
```

---

# 15. Interview Cheat Sheet

```text
Method Call

✔ Stack Frame
✔ Parameters
✔ Operand Stack
✔ Return Address

Bytecode

invokevirtual
invokestatic
invokespecial
invokeinterface
invokedynamic

Java

Pass-by-Value
```

---

# 16. Summary

Method calls in Java involve locating the target method, creating a new stack frame, passing arguments by value, executing bytecode instructions, and returning control to the caller. Understanding the JVM's method invocation process is essential for mastering recursion, polymorphism, debugging, and performance optimization in enterprise Java applications.
