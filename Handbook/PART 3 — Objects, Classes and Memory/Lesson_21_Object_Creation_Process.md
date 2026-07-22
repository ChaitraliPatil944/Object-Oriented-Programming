# Lesson 21 — Object Creation Process

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Creating an object in Java looks deceptively simple:

```java
Employee emp = new Employee();
```

However, behind this single line, the Java Virtual Machine (JVM) performs several important operations. Understanding this sequence is crucial for mastering Java internals and answering advanced interview questions.

---

# 2. The Statement Breakdown

```java
Employee emp = new Employee();
```

This statement consists of three parts:

- `Employee` → Class type
- `emp` → Reference variable
- `new Employee()` → Creates a new object

---

# 3. Step-by-Step Object Creation

When the JVM executes:

```java
Employee emp = new Employee();
```

it performs the following steps:

```text
1. Load the Employee class (if not already loaded)
            │
            ▼
2. Allocate memory on the Heap
            │
            ▼
3. Initialize instance variables with default values
            │
            ▼
4. Execute the constructor
            │
            ▼
5. Return the object's reference
            │
            ▼
6. Store the reference in emp
```

---

# 4. Step 1: Class Loading

Before an object exists, the JVM ensures the class definition is available.

```java
class Employee {

}
```

The class is loaded only once during its lifecycle.

---

# 5. Step 2: Heap Memory Allocation

The `new` keyword requests memory from the heap.

```java
Employee emp = new Employee();
```

Memory layout:

```text
Heap

+----------------------+
| Employee Object      |
| id = 0               |
| name = null          |
+----------------------+
```

At this stage, default values are assigned.

---

# 6. Step 3: Default Initialization

Every instance variable receives a default value.

| Data Type | Default Value |
|-----------|---------------|
| int | 0 |
| double | 0.0 |
| boolean | false |
| char | '\u0000' |
| Object Reference | null |

Example:

```java
class Employee {

    int id;
    String name;
}
```

Before the constructor runs:

```text
id = 0
name = null
```

---

# 7. Step 4: Constructor Execution

The constructor initializes the object.

```java
class Employee {

    String name;

    Employee() {
        name = "Alice";
    }
}
```

After construction:

```text
name = Alice
```

---

# 8. Step 5: Returning the Reference

Once initialization is complete, the JVM returns the object's memory reference.

```text
Stack

emp
 │
 ▼

Heap

+----------------------+
| Employee Object      |
+----------------------+
```

The variable stores the reference, not the object itself.

---

# 9. Complete Example

```java
class Employee {

    int id;
    String name;

    Employee() {
        id = 101;
        name = "Alice";
    }

    void display() {
        System.out.println(id + " " + name);
    }
}

public class Main {

    public static void main(String[] args) {

        Employee emp = new Employee();
        emp.display();
    }
}
```

Output:

```text
101 Alice
```

---

# 10. Internal JVM View

Conceptually:

```text
Source Code
      │
      ▼
Bytecode
      │
      ▼
Class Loader
      │
      ▼
Heap Allocation
      │
      ▼
Default Initialization
      │
      ▼
Constructor
      │
      ▼
Reference Returned
```

This entire sequence happens automatically.

---

# 11. Enterprise Example

Consider an online banking application.

```java
Customer customer = new Customer();
```

The JVM:

1. Loads the `Customer` class.
2. Allocates memory.
3. Sets default values.
4. Runs the constructor.
5. Returns the reference.
6. The application begins using the customer object.

This process occurs millions of times in enterprise applications every day.

---

# 12. Common Mistakes

❌ Believing `new` only allocates memory.

❌ Thinking constructors create objects.

❌ Assuming reference variables contain the actual object.

Correct understanding:

- `new` allocates memory and starts object creation.
- Constructors initialize already allocated objects.
- Reference variables point to objects.

---

# 13. Best Practices

- Initialize important fields in constructors.
- Avoid heavy logic inside constructors.
- Create objects only when required.
- Understand object creation costs in performance-critical systems.

---

# 14. Interview Questions

1. What happens internally when `new` is executed?
2. Does the constructor create the object?
3. When are default values assigned?
4. What does a reference variable store?
5. Where is the object allocated in Java?

---

# 15. Summary

The Java object creation process involves much more than simply calling `new`. The JVM loads the class, allocates heap memory, initializes fields with default values, invokes the constructor, and finally returns a reference to the newly created object. Understanding this sequence provides a solid foundation for learning about constructors, memory management, and JVM internals.
