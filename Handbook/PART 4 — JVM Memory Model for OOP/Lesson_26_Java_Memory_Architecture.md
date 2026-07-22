# Lesson 26 — Java Memory Architecture

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the biggest strengths of Java is its automatic memory management. Unlike languages such as C and C++, Java developers do not manually allocate and free memory. Instead, the **Java Virtual Machine (JVM)** manages memory through a well-defined architecture.

Understanding Java Memory Architecture is essential because it explains:

- Where objects are stored
- Where methods are stored
- Where local variables exist
- How method calls work
- How Garbage Collection functions

This topic is one of the most frequently asked areas in Java interviews.

---

# 2. JVM Memory Architecture Overview

The JVM divides memory into several runtime areas.

```text
                Java Program
                      │
                      ▼
               Java Virtual Machine
                      │
      ┌───────────────┼────────────────┐
      ▼               ▼                ▼
   Heap Memory    Stack Memory     Method Area
      │               │                │
      │               │                ├── Class Metadata
      │               │                ├── Bytecode
      │               │                ├── Static Variables
      │               │                └── Runtime Constant Pool
      │
      ├── Objects
      ├── Arrays
      └── Instance Data

Additional JVM Areas:
• Program Counter (PC) Register
• Native Method Stack
```

Each area has a specific purpose.

---

# 3. Heap Memory

The **Heap** is the runtime area where all objects and arrays are created.

Example:

```java
Employee emp = new Employee();
```

Memory:

```text
Heap

+----------------------+
| Employee Object      |
+----------------------+
```

Characteristics:

- Shared by all threads
- Managed by the Garbage Collector
- Largest memory region
- Stores object instances

---

# 4. Stack Memory

Every thread has its own **Java Stack**.

The stack stores:

- Local variables
- Method parameters
- Return addresses
- Object references

Example:

```java
public static void main(String[] args){

    Employee emp = new Employee();
}
```

Memory:

```text
Stack

emp
 │
 ▼

Heap

Employee Object
```

The stack stores the reference, not the object.

---

# 5. Method Area

The Method Area stores class-level information.

Contents include:

- Class definitions
- Method bytecode
- Static variables
- Runtime constant pool

Unlike heap objects, class metadata is loaded only once.

---

# 6. Program Counter (PC) Register

Each thread has its own **Program Counter Register**.

It stores the address of the next JVM instruction to execute.

Think of it as the JVM's bookmark while executing bytecode.

---

# 7. Native Method Stack

Java sometimes calls methods written in native languages such as C or C++.

These methods execute using the **Native Method Stack**.

Example:

```text
Java Code
     │
     ▼
JNI (Java Native Interface)
     │
     ▼
Native Library
```

---

# 8. Memory Interaction

Consider:

```java
Employee emp = new Employee();
emp.display();
```

Execution flow:

```text
Method Area
     │
Loads Employee class
     │
     ▼

Heap
Creates Employee object
     │
     ▼

Stack
Stores reference in emp
     │
Calls display()
```

All memory regions cooperate during program execution.

---

# 9. Real Enterprise Example

A banking application may have:

```text
Method Area
------------
Customer.class
Account.class
Loan.class

Heap
------------
Customer Objects
Account Objects
Loan Objects

Stack
------------
login()
transfer()
withdraw()
deposit()
```

Thousands of objects may exist simultaneously while methods are continuously invoked.

---

# 10. Memory Area Comparison

| Memory Area | Stores | Shared? |
|-------------|--------|---------|
| Heap | Objects & Arrays | Yes |
| Stack | Local Variables & References | No (per thread) |
| Method Area | Class Metadata & Static Data | Yes |
| PC Register | Current Instruction | No (per thread) |
| Native Method Stack | Native Method Calls | No (per thread) |

---

# 11. Common Misconceptions

❌ Objects are stored in the stack.

❌ Methods are copied into every object.

❌ Static variables are stored in heap objects.

Correct understanding:

- Objects live in the heap.
- References live in stack frames (for local variables).
- Class information resides in the Method Area.

---

# 12. Best Practices

- Understand Stack vs Heap clearly.
- Avoid creating unnecessary objects.
- Use static members appropriately.
- Let the Garbage Collector manage object memory.
- Learn JVM internals for performance tuning.

---

# 13. Interview Questions

1. What are the JVM memory areas?
2. Where are objects stored?
3. Where are local variables stored?
4. What is the Method Area?
5. What is the role of the PC Register?
6. What is the Native Method Stack?

---

# 14. Summary

The Java Memory Architecture divides runtime memory into specialized areas such as the Heap, Stack, Method Area, Program Counter Register, and Native Method Stack. Each region has a distinct responsibility, allowing the JVM to efficiently execute Java programs while automatically managing memory. A solid understanding of these areas forms the foundation for advanced topics such as garbage collection, object allocation, memory optimization, and JVM performance tuning.
