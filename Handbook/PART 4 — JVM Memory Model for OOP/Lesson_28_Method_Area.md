# Lesson 28 — Method Area

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Method Area** is one of the JVM runtime memory areas responsible for storing **class-level information**.

Unlike the Heap, which stores objects, the Method Area stores information that is common to all objects of a class.

The Method Area is shared by all threads and is created when the JVM starts.

---

# 2. What Does the Method Area Store?

The Method Area typically contains:

- Class metadata
- Method bytecode
- Static variables
- Runtime Constant Pool
- Constructor information
- Field definitions

Conceptually:

```text
Method Area

+----------------------------+
| Employee.class             |
|----------------------------|
| Class Metadata             |
| Constructors               |
| Method Bytecode            |
| Static Variables           |
| Runtime Constant Pool      |
+----------------------------+
```

---

# 3. Class Loading

Before an object is created, its class must be loaded.

```java
class Employee {

}
```

When the JVM loads `Employee.class`, its metadata is placed in the Method Area.

This happens only once.

---

# 4. Class Metadata

Metadata describes the structure of a class.

Example:

```java
class Employee {

    int id;
    String name;

    void work() {}
}
```

Metadata includes:

- Class name
- Parent class
- Interfaces
- Fields
- Methods
- Access modifiers

---

# 5. Method Bytecode

After compilation:

```java
void work() {

    System.out.println("Working");
}
```

becomes JVM bytecode.

The bytecode is stored in the Method Area and shared by every object.

```text
Employee Objects

emp1
emp2
emp3

      │
      ▼

Method Area

work()
```

Methods are **not copied into each object**.

---

# 6. Static Variables

Static variables belong to the class.

```java
class Employee {

    static String company = "OpenAI";
}
```

Memory:

```text
Method Area

Employee.class

company = OpenAI
```

All objects share the same static variable.

---

# 7. Runtime Constant Pool

The Runtime Constant Pool stores constants used by the class.

Examples:

- String literals
- Numeric constants
- Symbolic references
- Method references

Example:

```java
final int MAX = 100;
```

The JVM uses the constant pool for efficient execution.

---

# 8. Method Area vs Heap

```text
Method Area
------------
Employee.class
Methods
Static Variables
Bytecode

Heap
------------
Employee Object #1
Employee Object #2
Employee Object #3
```

One class definition can support thousands of objects.

---

# 9. Complete Memory Flow

```java
Employee emp = new Employee();
```

Execution:

```text
Method Area
     │
Loads Employee.class
     │
     ▼

Heap
Creates Employee Object
     │
     ▼

Stack
Stores reference in emp
```

Each JVM memory area has a distinct responsibility.

---

# 10. Enterprise Example

A banking application may contain:

```text
Method Area
------------
Customer.class
Account.class
Loan.class
Transaction.class

Heap
------------
Customer Objects
Account Objects
Loan Objects
```

The class definitions are loaded once, while many object instances are created.

---

# 11. Method Area vs Stack vs Heap

| Area | Stores | Shared |
|------|--------|--------|
| Method Area | Class metadata, bytecode, static variables | Yes |
| Heap | Objects, arrays | Yes |
| Stack | Local variables, references, stack frames | No (per thread) |

---

# 12. Common Misconceptions

❌ Methods are stored inside every object.

❌ Static variables belong to objects.

❌ Every object has its own copy of bytecode.

Correct understanding:

- Methods belong to the class.
- Static variables belong to the class.
- Objects contain only instance data.

---

# 13. Best Practices

- Use `static` only for truly shared data.
- Avoid excessive static mutable state.
- Understand that methods are shared, improving memory efficiency.
- Learn class loading to understand application startup behavior.

---

# 14. Interview Questions

1. What is the Method Area?
2. What information is stored in the Method Area?
3. Where are static variables stored?
4. Where is bytecode stored?
5. Are methods copied into every object?
6. How is the Method Area different from the Heap?

---

# 15. Summary

The Method Area stores class-level information such as metadata, method bytecode, static variables, and the Runtime Constant Pool. It is shared across all threads and loaded once per class, allowing many objects to share the same definitions efficiently. Understanding the Method Area helps explain class loading, static members, memory optimization, and JVM execution.
