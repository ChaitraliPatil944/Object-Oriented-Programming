# Lesson 25 — Object Cloning

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Sometimes, instead of creating a brand-new object from scratch, we need an **exact copy** of an existing object.

This process is called **object cloning**.

Cloning creates a new object whose initial state is copied from another object.

Java supports cloning through the `Cloneable` interface and the `clone()` method inherited from the `Object` class.

---

# 2. Why Do We Need Cloning?

Consider an employee management system.

```java
Employee emp1 = new Employee();
```

If another employee has almost identical information, copying every field manually is inefficient.

Instead:

```java
Employee emp2 = (Employee) emp1.clone();
```

A new object is created with the same field values.

---

# 3. Assignment vs Cloning

### Assignment

```java
Employee e1 = new Employee();

Employee e2 = e1;
```

Memory:

```text
e1 ─────┐
         │
e2 ─────┘
         ▼
    Employee Object
```

Only one object exists.

---

### Cloning

```java
Employee e2 = (Employee) e1.clone();
```

Memory:

```text
e1 ─────► Employee Object #1

e2 ─────► Employee Object #2
```

Two separate objects now exist.

---

# 4. Cloneable Interface

To support cloning, a class must implement `Cloneable`.

```java
class Employee implements Cloneable {

}
```

Without it, calling `clone()` throws a `CloneNotSupportedException`.

---

# 5. Basic Cloning Example

```java
class Employee implements Cloneable {

    int id;
    String name;

    Employee(int id, String name) {
        this.id = id;
        this.name = name;
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }
}
```

Usage:

```java
Employee e1 = new Employee(101, "Alice");

Employee e2 = (Employee) e1.clone();
```

---

# 6. Shallow Copy

The default implementation of `clone()` creates a **shallow copy**.

Primitive values are copied directly.

Object references are copied, not duplicated.

Example:

```java
class Address {

    String city;
}

class Employee implements Cloneable {

    Address address;

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }
}
```

Both cloned objects refer to the same `Address` object.

---

# 7. Deep Copy

A **deep copy** duplicates nested objects as well.

```text
Original Employee
        │
        ▼
     Address

Clone Employee
        │
        ▼
   New Address
```

Each object owns its own copy of every referenced object.

---

# 8. Shallow Copy vs Deep Copy

| Feature | Shallow Copy | Deep Copy |
|---------|--------------|-----------|
| Primitive Fields | Copied | Copied |
| Object References | Shared | Duplicated |
| Memory Usage | Lower | Higher |
| Isolation | Partial | Complete |

---

# 9. Cloning vs Copy Constructor

Instead of `clone()`, many developers prefer a **copy constructor**.

Example:

```java
class Employee {

    String name;

    Employee(Employee other) {
        this.name = other.name;
    }
}
```

Usage:

```java
Employee e2 = new Employee(e1);
```

Copy constructors are often easier to understand and maintain.

---

# 10. Enterprise Perspective

Many enterprise Java projects avoid `Cloneable` because:

- It has design limitations.
- Exception handling is awkward.
- Deep copying is difficult.
- Copy constructors or factory methods are more explicit.

Frameworks commonly use mapping libraries or builders instead of cloning.

---

# 11. Common Mistakes

❌ Believing assignment creates a copy.

❌ Assuming `clone()` performs a deep copy.

❌ Forgetting to implement `Cloneable`.

❌ Ignoring mutable nested objects.

---

# 12. Best Practices

- Prefer copy constructors or factory methods for complex objects.
- Use deep copies when mutable nested objects must be independent.
- Be careful with shared references.
- Use `clone()` only when appropriate and well understood.

---

# 13. Interview Questions

1. What is object cloning?
2. What is the purpose of the `Cloneable` interface?
3. What is the difference between assignment and cloning?
4. What is shallow copy?
5. What is deep copy?
6. Why do many Java developers avoid `Cloneable`?

---

# 14. Summary

Object cloning creates a new object by copying the state of an existing object. Java provides cloning through the `Cloneable` interface and the `clone()` method, which performs a shallow copy by default. For complex applications, developers often prefer copy constructors or factory methods because they provide clearer, safer, and more maintainable object copying strategies.
