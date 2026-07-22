# Lesson 27 — Stack vs Heap

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the most frequently asked Java interview topics is the difference between **Stack Memory** and **Heap Memory**.

Many beginners think both simply store program data. In reality, they serve very different purposes.

Understanding the relationship between the Stack and Heap is essential for mastering object creation, method execution, parameter passing, recursion, garbage collection, and JVM memory management.

---

# 2. What is Stack Memory?

Every Java thread has its own **Stack**.

The stack stores:

- Local variables
- Method parameters
- Object references
- Return addresses
- Stack frames

The stack follows the **LIFO (Last In, First Out)** principle.

---

# 3. What is Heap Memory?

The **Heap** is the runtime area where Java stores:

- Objects
- Arrays
- Instance variables
- Runtime object data

All threads share the same heap.

The Garbage Collector manages heap memory automatically.

---

# 4. Stack vs Heap Overview

```text
               Java Program
                     │
        ┌────────────┴────────────┐
        ▼                         ▼
   Stack Memory              Heap Memory
   (Per Thread)              (Shared)
        │                         │
        ├── Local Variables       ├── Objects
        ├── Method Parameters     ├── Arrays
        ├── References            ├── Instance Data
        └── Stack Frames          └── Runtime Objects
```

---

# 5. Memory Example

```java
class Employee {

    String name = "Alice";
}

public class Main {

    public static void main(String[] args) {

        Employee emp = new Employee();
    }
}
```

Memory:

```text
Stack

main()

emp
 │
 ▼

Heap

+----------------------+
| Employee Object      |
| name = Alice         |
+----------------------+
```

The variable `emp` is stored in the stack.

The actual object is stored in the heap.

---

# 6. Method Calls and Stack Frames

Every method call creates a new **stack frame**.

Example:

```java
void methodA(){

    methodB();
}

void methodB(){

}
```

Execution:

```text
Top of Stack

methodB()

methodA()

main()
```

When `methodB()` finishes, its stack frame is removed automatically.

---

# 7. Heap Object Sharing

Multiple references can point to the same heap object.

```java
Employee e1 = new Employee();

Employee e2 = e1;
```

Memory:

```text
Stack

e1 ───────┐
           │
e2 ───────┘
           ▼

Heap

Employee Object
```

Only one object exists.

---

# 8. Lifetime Comparison

### Stack

- Created when a method is called
- Destroyed when the method returns
- Automatic cleanup

### Heap

- Created when `new` is executed
- Lives until unreachable
- Removed by Garbage Collection

---

# 9. Performance Comparison

Stack:

- Very fast allocation
- Very fast deallocation
- Limited size

Heap:

- Slower allocation
- Garbage collection overhead
- Much larger memory space

---

# 10. Stack vs Heap Table

| Feature | Stack | Heap |
|---------|-------|------|
| Scope | Per Thread | Shared |
| Stores | Local Variables, References | Objects, Arrays |
| Memory Management | Automatic | Garbage Collector |
| Access Speed | Faster | Slower |
| Size | Smaller | Larger |
| Lifetime | Method Execution | Until GC |

---

# 11. Common Errors

### StackOverflowError

Occurs when stack frames grow excessively.

Example:

```java
void recurse(){

    recurse();
}
```

Infinite recursion eventually exhausts the stack.

---

### OutOfMemoryError

Occurs when the JVM cannot allocate additional heap memory.

Example:

```java
while(true){

    new Employee();
}
```

Continuously creating objects without allowing them to be reclaimed can exhaust the heap.

---

# 12. Enterprise Example

An online banking system handling thousands of requests:

```text
Stack
------
login()
withdraw()
transfer()

Heap
------
Customer Objects
Account Objects
Transaction Objects
```

Each request has its own stack, while all requests share heap objects where appropriate.

---

# 13. Common Misconceptions

❌ Objects are stored in the stack.

❌ Every method has its own heap.

❌ Heap memory is cleaned immediately after an object becomes unreachable.

Correct understanding:

- Objects live in the heap.
- References for local variables live in stack frames.
- Garbage collection timing is controlled by the JVM.

---

# 14. Best Practices

- Avoid unnecessary object creation.
- Be cautious with deep recursion.
- Release references when objects are no longer needed.
- Understand object lifetimes when designing applications.

---

# 15. Interview Questions

1. What is the difference between Stack and Heap?
2. Where are objects stored?
3. Where are local variables stored?
4. Why is Stack faster than Heap?
5. What causes StackOverflowError?
6. What causes OutOfMemoryError?

---

# 16. Summary

Stack Memory and Heap Memory work together to execute Java programs efficiently. The stack manages method execution, local variables, and object references on a per-thread basis, while the heap stores shared runtime objects and arrays. Understanding the distinction between these two memory areas is fundamental for debugging, optimizing performance, and mastering Java internals.
