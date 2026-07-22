# Lesson 31 — Object Allocation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Every time we create an object using the `new` keyword, the Java Virtual Machine (JVM) performs a series of operations behind the scenes.

```java
Employee emp = new Employee();
```

Although this appears to be a single line of code, the JVM must:

- Load the class (if not already loaded)
- Allocate memory
- Initialize fields
- Invoke the constructor
- Return a reference to the newly created object

Understanding object allocation is important for writing efficient Java programs and for answering JVM-related interview questions.

---

# 2. What is Object Allocation?

**Object allocation** is the process of reserving memory in the Heap for a new object and preparing it for use.

Most objects are allocated in the **Young Generation (Eden Space)** of the heap.

---

# 3. Object Creation Steps

Consider:

```java
Employee emp = new Employee();
```

The JVM performs the following steps:

1. Checks whether `Employee.class` is loaded.
2. Loads the class if necessary.
3. Allocates memory in the Heap.
4. Initializes fields with default values.
5. Executes field initializers.
6. Calls the constructor.
7. Returns the object reference.
8. Stores the reference in the Stack.

---

# 4. Memory Flow

```text
Java Code
     │
     ▼
new Employee()
     │
     ▼
Method Area
(Class Loaded)
     │
     ▼
Heap
(Object Created)
     │
     ▼
Stack
(emp Reference)
```

Each JVM memory area participates in object creation.

---

# 5. Default Initialization

Before the constructor runs, instance variables receive default values.

```java
class Employee {

    int id;
    String name;
    boolean active;
}
```

Default values:

```text
id      = 0
name    = null
active  = false
```

Only after this step does the constructor execute.

---

# 6. Constructor Initialization

```java
class Employee {

    int id;

    Employee() {
        id = 101;
    }
}
```

Execution order:

```text
Memory Allocated
       │
       ▼
Default Initialization
       │
       ▼
Constructor Executes
       │
       ▼
Object Ready
```

---

# 7. Heap Allocation

Suppose:

```java
Employee e1 = new Employee();
Employee e2 = new Employee();
```

Memory:

```text
Stack

e1 ─────────► Employee #1

e2 ─────────► Employee #2

-------------------------------

Heap

+------------------+
| Employee #1      |
+------------------+

+------------------+
| Employee #2      |
+------------------+
```

Every `new` keyword creates a separate object.

---

# 8. Allocation in the Young Generation

Most JVM implementations initially allocate objects in the **Eden Space**.

```text
Heap

+-------------------------+
| Young Generation        |
|-------------------------|
| Eden                    |
| Survivor 0              |
| Survivor 1              |
+-------------------------+

+-------------------------+
| Old Generation          |
+-------------------------+
```

Short-lived objects are collected quickly.

Objects that survive several garbage collection cycles are promoted to the Old Generation.

---

# 9. Large Object Allocation

Very large objects (depending on JVM configuration) may bypass the Young Generation and be allocated directly in the Old Generation.

Examples include:

- Large arrays
- Large collections
- Large buffers

This optimization reduces unnecessary copying during garbage collection.

---

# 10. Enterprise Example

Consider an online shopping application:

```java
Order order = new Order();
Customer customer = new Customer();
Invoice invoice = new Invoice();
```

Execution:

```text
Method Area
------------
Order.class
Customer.class
Invoice.class

Heap
------------
Order Object
Customer Object
Invoice Object

Stack
------------
order
customer
invoice
```

A busy application may allocate millions of objects every minute.

---

# 11. Performance Considerations

Object allocation in Java is generally fast because:

- Memory is allocated sequentially in Eden Space.
- Allocation often requires only moving a pointer.
- Modern garbage collectors optimize short-lived objects.

However, excessive object creation can increase garbage collection activity and reduce application performance.

---

# 12. Common Misconceptions

❌ `new` only calls the constructor.

❌ Constructors allocate memory.

❌ Objects are created in the Stack.

Correct understanding:

- The JVM allocates memory before the constructor executes.
- Constructors initialize objects but do not allocate memory.
- Objects are created in the Heap.

---

# 13. Best Practices

- Reuse objects when appropriate.
- Avoid creating unnecessary temporary objects.
- Prefer immutable objects where practical.
- Understand allocation patterns in performance-critical applications.

---

# 14. Interview Questions

1. What happens when the `new` keyword is executed?
2. Where are Java objects allocated?
3. What is the Eden Space?
4. When does the constructor execute?
5. What are default values during object creation?
6. Can large objects bypass the Young Generation?

---

# 15. Summary

Object allocation is the JVM process of creating new objects in the Heap. During allocation, memory is reserved, fields are initialized with default values, constructors are executed, and object references are stored in the Stack. Modern JVMs optimize this process through the Young Generation and efficient allocation strategies, making object creation fast while relying on garbage collection to reclaim unused memory.
