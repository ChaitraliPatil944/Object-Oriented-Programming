# Lesson 23 — Object Initialization

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Creating an object and initializing an object are two different processes.

When Java executes:

```java
Employee emp = new Employee();
```

the JVM first **creates** the object in heap memory and then **initializes** it.

Initialization ensures that every object starts in a valid and predictable state before it is used.

---

# 2. What is Object Initialization?

**Object initialization** is the process of assigning values to an object's instance variables after memory has been allocated.

Initialization may happen through:

- Default values assigned by the JVM
- Field (instance variable) initializers
- Constructors
- Initialization blocks
- Setter methods

---

# 3. Initialization Sequence in Java

When an object is created, Java follows this order:

```text
Class Loading
      │
      ▼
Heap Memory Allocation
      │
      ▼
Default Values Assigned
      │
      ▼
Field Initializers Executed
      │
      ▼
Instance Initialization Block
      │
      ▼
Constructor Execution
      │
      ▼
Object Ready for Use
```

Understanding this sequence is important because it determines the final values of an object's fields.

---

# 4. Default Initialization

The JVM automatically assigns default values.

```java
class Employee {

    int id;
    String name;
    boolean active;
}
```

Initial values:

| Data Type | Default Value |
|-----------|---------------|
| int | 0 |
| double | 0.0 |
| boolean | false |
| char | '\u0000' |
| Object Reference | null |

---

# 5. Field Initializers

Instance variables can be initialized where they are declared.

```java
class Employee {

    int id = 101;
    String company = "OpenAI";
}
```

These assignments happen before the constructor executes.

---

# 6. Instance Initialization Block

Java allows instance initialization blocks.

```java
class Employee {

    {
        System.out.println("Initialization Block");
    }

    Employee() {
        System.out.println("Constructor");
    }
}
```

Output:

```text
Initialization Block
Constructor
```

The block runs every time an object is created, before the constructor.

---

# 7. Constructor Initialization

Constructors are the most common way to initialize objects.

```java
class Employee {

    String name;

    Employee(String name) {
        this.name = name;
    }
}
```

Usage:

```java
Employee emp = new Employee("Alice");
```

---

# 8. Setter-Based Initialization

Objects can also be initialized after creation.

```java
class Employee {

    private String name;

    public void setName(String name) {
        this.name = name;
    }
}
```

Usage:

```java
Employee emp = new Employee();
emp.setName("Alice");
```

This approach is common in frameworks that use dependency injection.

---

# 9. Complete Initialization Example

```java
class Employee {

    int id = 100;

    {
        System.out.println("Block");
    }

    Employee() {
        id = 101;
        System.out.println("Constructor");
    }
}

public class Main {

    public static void main(String[] args) {

        Employee emp = new Employee();
        System.out.println(emp.id);
    }
}
```

Output:

```text
Block
Constructor
101
```

---

# 10. Enterprise Example

Consider a banking application.

```java
class Account {

    private double balance;

    Account() {
        balance = 1000;
    }
}
```

Every new account starts with a valid opening balance.

Proper initialization helps prevent inconsistent business data.

---

# 11. Common Mistakes

❌ Assuming constructors are the only way to initialize objects.

❌ Forgetting that field initializers run before constructors.

❌ Relying on default values when meaningful initialization is required.

❌ Using setters for mandatory fields that should be initialized immediately.

---

# 12. Best Practices

- Initialize mandatory fields in constructors.
- Use field initializers for simple constant defaults.
- Keep initialization logic clear and predictable.
- Avoid complex processing in initialization blocks.
- Ensure objects are fully usable immediately after construction.

---

# 13. Interview Questions

1. What is object initialization?
2. What is the order of object initialization in Java?
3. When are default values assigned?
4. What is an instance initialization block?
5. Which is preferred: constructors or setters for mandatory fields?

---

# 14. Summary

Object initialization is the process of preparing an object for use after memory has been allocated. Java performs initialization in a well-defined sequence: default values, field initializers, instance initialization blocks, and finally constructors. Understanding this order helps developers write predictable, maintainable code and avoid subtle initialization bugs in enterprise applications.
