# Lesson 24 — Reference Variables

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the most misunderstood concepts in Java is the **reference variable**.

Many beginners believe that a variable like:

```java
Employee emp = new Employee();
```

stores the actual object.

This is **incorrect**.

The object is stored in **heap memory**, while `emp` stores only a **reference (address-like value)** that points to the object.

Understanding reference variables is essential for mastering Java memory management, object sharing, parameter passing, and garbage collection.

---

# 2. What is a Reference Variable?

A **reference variable** is a variable that stores the location (reference) of an object in heap memory.

Example:

```java
Employee emp = new Employee();
```

Here:

- `Employee` → Class type
- `emp` → Reference variable
- `new Employee()` → Creates an object

---

# 3. Memory Representation

```text
Stack Memory

emp
 │
 ▼

Heap Memory

+----------------------+
| Employee Object      |
+----------------------+
```

The object lives in the heap.

The reference variable lives in the stack (for local variables).

---

# 4. Creating a Reference

```java
Employee emp = new Employee();
```

Execution:

1. Heap memory is allocated.
2. Object is created.
3. Constructor executes.
4. JVM returns the reference.
5. Reference stored in `emp`.

---

# 5. Multiple References to the Same Object

```java
Employee emp1 = new Employee();

Employee emp2 = emp1;
```

Memory:

```text
Stack

emp1 ───────┐
            │
emp2 ───────┘
            │
            ▼

Heap

+----------------------+
| Employee Object      |
+----------------------+
```

Both variables point to the **same object**.

---

# 6. Modifying Through One Reference

```java
class Employee {

    String name;
}

Employee emp1 = new Employee();

emp1.name = "Alice";

Employee emp2 = emp1;

emp2.name = "Bob";

System.out.println(emp1.name);
```

Output:

```text
Bob
```

There is only **one object**, so both references observe the same state.

---

# 7. Comparing References

```java
Employee e1 = new Employee();

Employee e2 = e1;
```

```java
System.out.println(e1 == e2);
```

Output:

```text
true
```

Both references point to the same object.

Now:

```java
Employee e3 = new Employee();

System.out.println(e1 == e3);
```

Output:

```text
false
```

The objects are different.

---

# 8. Assigning null

```java
Employee emp = new Employee();

emp = null;
```

Memory:

```text
Stack

emp = null

Heap

Employee Object
(Unreachable if no other references exist)
```

Setting a reference to `null` removes the connection between the variable and the object.

---

# 9. Passing References to Methods

```java
class Student {

    String name;
}

void update(Student s) {
    s.name = "Alice";
}
```

Usage:

```java
Student student = new Student();

update(student);
```

The method receives a **copy of the reference**, not a copy of the object.

Therefore, changes to the object's fields are visible outside the method.

---

# 10. Enterprise Example

```java
Customer customer = customerService.findById(1);

Order order = new Order(customer);
```

Both the service and the order object can refer to the same `Customer` object.

This avoids unnecessary duplication of data.

---

# 11. Common Mistakes

❌ Reference variables contain the object.

❌ Assigning one reference to another creates a new object.

❌ `obj = null` destroys the object immediately.

Correct understanding:

- References point to objects.
- Assignment copies the reference.
- Garbage collection is handled by the JVM.

---

# 12. Best Practices

- Understand object sharing before modifying objects.
- Avoid unnecessary object creation.
- Use `==` to compare references, not object contents.
- Use `.equals()` when comparing logical equality (if implemented appropriately).

---

# 13. Interview Questions

1. What is a reference variable?
2. Where is the reference stored?
3. Where is the object stored?
4. What happens when two references point to the same object?
5. What happens after assigning a reference to `null`?
6. What is the difference between `==` and `.equals()`?

---

# 14. Summary

A reference variable does not store an object itself. Instead, it stores a reference to an object located in heap memory. Multiple reference variables can point to the same object, allowing them to share and modify the same state. Understanding references is fundamental to Java programming because it explains object sharing, parameter passing, comparisons, and garbage collection behavior.
