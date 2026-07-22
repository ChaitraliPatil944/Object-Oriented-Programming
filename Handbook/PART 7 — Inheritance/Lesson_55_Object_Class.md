# Lesson 55 — Object Class

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

In Java, **`Object`** is the root class of the class hierarchy.

Every class in Java directly or indirectly inherits from the `Object` class. Therefore, every object automatically gains access to the methods defined in `Object`.

---

# 2. Why is the Object Class Important?

Since all classes inherit from `Object`, Java provides a common set of behaviors for every object.

Benefits include:

- Common functionality
- Runtime polymorphism
- Object comparison
- Hashing support
- String representation
- Synchronization support

---

# 3. Inheritance Hierarchy

```text
           Object
              ▲
              │
          Animal
              ▲
              │
             Dog
```

Even if `extends Object` is not written, Java adds it implicitly.

---

# 4. Creating an Object

```java
class Student { }

Student s = new Student();
```

Equivalent hierarchy:

```java
class Student extends Object { }
```

---

# 5. Important Methods of Object

| Method | Purpose |
|---------|---------|
| `toString()` | Returns string representation |
| `equals()` | Compares objects |
| `hashCode()` | Returns hash value |
| `getClass()` | Returns runtime class |
| `clone()` | Creates object copy (if supported) |
| `wait()` | Thread synchronization |
| `notify()` | Wakes one waiting thread |
| `notifyAll()` | Wakes all waiting threads |

---

# 6. Overriding `toString()`

```java
class Employee {

    String name = "Alice";

    @Override
    public String toString() {
        return "Employee{name='" + name + "'}";
    }
}
```

Instead of a memory address-like value, meaningful information is displayed.

---

# 7. Overriding `equals()`

```java
class Student {

    int id;

    Student(int id){
        this.id = id;
    }

    @Override
    public boolean equals(Object obj){
        if(this == obj) return true;
        if(!(obj instanceof Student)) return false;
        Student other = (Student)obj;
        return id == other.id;
    }
}
```

Now equality is based on business data rather than object references.

---

# 8. `hashCode()`

Whenever `equals()` is overridden, `hashCode()` should also be overridden.

```java
@Override
public int hashCode() {
    return Integer.hashCode(id);
}
```

This is essential for collections like `HashMap` and `HashSet`.

---

# 9. Enterprise Example

```java
class Customer {

    private int customerId;

    @Override
    public String toString() {
        return "Customer ID: " + customerId;
    }
}
```

Meaningful object representations simplify logging and debugging.

---

# 10. Best Practices

- Override `toString()` for readable output.
- Override `equals()` and `hashCode()` together.
- Avoid relying on default implementations for domain objects.
- Use `getClass()` for runtime type information when needed.

---

# 11. Common Mistakes

❌ Forgetting to override `hashCode()`.

❌ Comparing objects with `==` when logical equality is required.

❌ Ignoring `toString()` in domain classes.

---

# 12. Interview Questions

1. What is the `Object` class?
2. Does every Java class inherit from `Object`?
3. Why override `toString()`?
4. Why should `equals()` and `hashCode()` be overridden together?
5. What does `getClass()` return?

---

# 13. Quick Revision

```text
Object
│
├── Root of Java hierarchy
├── toString()
├── equals()
├── hashCode()
├── getClass()
├── clone()
├── wait()/notify()
└── Inherited by every class
```

---

# 14. Summary

The `Object` class is the universal superclass in Java. Every class inherits its methods, making it the foundation of Java's object model. Understanding methods such as `toString()`, `equals()`, and `hashCode()` is essential for writing maintainable, enterprise-grade Java applications and performing well in interviews.
