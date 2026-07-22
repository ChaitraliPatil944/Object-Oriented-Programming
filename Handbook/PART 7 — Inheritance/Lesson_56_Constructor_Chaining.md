# Lesson 56 — Constructor Chaining

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Constructor Chaining** is the process of calling one constructor from another constructor.

In Java, constructor chaining helps:

- Reuse initialization code
- Reduce duplication
- Ensure proper object initialization
- Maintain inheritance hierarchies

Java supports constructor chaining using:

- `this()`
- `super()`

---

# 2. Types of Constructor Chaining

There are two types:

1. Within the same class using `this()`
2. Between parent and child classes using `super()`

```text
Same Class
Constructor
     │
   this()
     ▼
Another Constructor

--------------------

Child Constructor
      │
   super()
      ▼
Parent Constructor
```

---

# 3. Constructor Chaining Using `this()`

`this()` is used to call another constructor in the same class.

```java
class Student {

    String name;
    int age;

    Student() {
        this("Unknown", 18);
    }

    Student(String name, int age) {
        this.name = name;
        this.age = age;
    }
}
```

The default constructor delegates initialization to the parameterized constructor.

---

# 4. Constructor Chaining Using `super()`

`super()` calls the constructor of the immediate parent class.

```java
class Animal {

    Animal() {
        System.out.println("Animal Constructor");
    }
}

class Dog extends Animal {

    Dog() {
        super();
        System.out.println("Dog Constructor");
    }
}
```

Output:

```
Animal Constructor
Dog Constructor
```

---

# 5. Constructor Execution Order

```text
Object
   │
   ▼
Parent Constructor
   │
   ▼
Child Constructor
```

Java always constructs parent objects before child objects.

---

# 6. Parameterized Constructor Chaining

```java
class Employee {

    Employee(String name) {
        System.out.println(name);
    }
}

class Manager extends Employee {

    Manager() {
        super("Alice");
    }
}
```

---

# 7. Rules of Constructor Chaining

- `this()` and `super()` must be the **first statement** in a constructor.
- A constructor can use **either** `this()` or `super()`, not both directly.
- If no constructor call is written, Java inserts `super()` automatically (if possible).
- Constructors are **not inherited**.

---

# 8. Enterprise Example

```java
class User {

    User(String username) {
        System.out.println("User: " + username);
    }
}

class Admin extends User {

    Admin() {
        super("admin");
        System.out.println("Admin Initialized");
    }
}
```

The base class initializes common user information before the admin-specific initialization.

---

# 9. Benefits

- Eliminates duplicate initialization code
- Improves readability
- Simplifies maintenance
- Ensures correct initialization order
- Encourages code reuse

---

# 10. Common Mistakes

❌ Calling `this()` after another statement.

❌ Calling both `this()` and `super()` in the same constructor.

❌ Forgetting that parent constructors execute first.

---

# 11. Best Practices

- Reuse constructors using `this()` where appropriate.
- Initialize shared state in parent constructors.
- Keep constructors focused on object initialization.
- Avoid excessive constructor logic.

---

# 12. Interview Questions

1. What is constructor chaining?
2. What is the difference between `this()` and `super()`?
3. Can `this()` and `super()` appear together?
4. What is the order of constructor execution?
5. Why is constructor chaining useful?

---

# 13. Quick Revision

```text
Constructor Chaining
│
├── this() → Same class constructor
├── super() → Parent constructor
├── First statement only
├── Parent executes before child
└── Promotes code reuse
```

---

# 14. Summary

Constructor chaining is a mechanism that allows constructors to invoke other constructors using `this()` or `super()`. It reduces duplicate initialization code, guarantees proper object construction, and ensures that parent classes are initialized before child classes. Constructor chaining is a fundamental concept in Java inheritance and enterprise application design.
