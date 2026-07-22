# Lesson 22 — Constructors

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **constructor** is a special member of a class that initializes an object when it is created.

Whenever an object is created using the `new` keyword, the constructor is invoked automatically by the JVM.

```java
Employee emp = new Employee();
```

The object is created first, and then the constructor initializes it.

---

# 2. Characteristics of Constructors

- Has the same name as the class.
- Has no return type (not even `void`).
- Executes automatically during object creation.
- Can be overloaded.
- Cannot be inherited.
- Can call another constructor using `this()`.

---

# 3. Syntax

```java
class Employee {

    Employee() {
        System.out.println("Constructor called");
    }
}
```

---

# 4. Default Constructor

If you do not define any constructor, Java provides a **default constructor**.

```java
class Student {
    int id;
}
```

Equivalent conceptually to:

```java
Student() {
    super();
}
```

The compiler generates it only when no constructor is written.

---

# 5. No-Argument Constructor

```java
class Student {

    String name;

    Student() {
        name = "Unknown";
    }
}
```

---

# 6. Parameterized Constructor

```java
class Student {

    int id;
    String name;

    Student(int id, String name) {
        this.id = id;
        this.name = name;
    }
}
```

Usage:

```java
Student s = new Student(101, "Alice");
```

---

# 7. Constructor Overloading

A class can have multiple constructors.

```java
class Employee {

    Employee() {}

    Employee(String name) {}

    Employee(int id, String name) {}
}
```

The JVM selects the matching constructor based on the arguments.

---

# 8. Constructor Chaining

One constructor can call another using `this()`.

```java
class Employee {

    Employee() {
        this("Unknown");
    }

    Employee(String name) {
        System.out.println(name);
    }
}
```

`this()` must be the first statement in the constructor.

---

# 9. Calling Parent Constructors

Use `super()` to invoke the parent class constructor.

```java
class Vehicle {

    Vehicle() {
        System.out.println("Vehicle");
    }
}

class Car extends Vehicle {

    Car() {
        super();
        System.out.println("Car");
    }
}
```

Output:

```text
Vehicle
Car
```

---

# 10. Constructor vs Method

| Constructor | Method |
|-------------|--------|
| Initializes object | Performs operations |
| Same name as class | Any valid name |
| No return type | Has a return type or `void` |
| Called automatically | Called explicitly |
| Runs once per object creation | Can run many times |

---

# 11. Memory Flow

```text
new Employee()
      │
      ▼
Heap memory allocated
      │
      ▼
Default values assigned
      │
      ▼
Constructor executes
      │
      ▼
Reference returned
```

---

# 12. Enterprise Example

```java
class Customer {

    String name;
    String email;

    Customer(String name, String email) {
        this.name = name;
        this.email = email;
    }
}
```

Every customer object starts in a valid state because required information is provided during construction.

---

# 13. Common Mistakes

❌ Giving a constructor a return type.

❌ Thinking constructors create objects.

❌ Calling `this()` after another statement.

❌ Expecting the compiler to generate a default constructor after defining your own constructor.

---

# 14. Best Practices

- Initialize mandatory fields in constructors.
- Keep constructors simple.
- Avoid heavy business logic inside constructors.
- Use constructor overloading when multiple initialization options are needed.

---

# 15. Interview Questions

1. What is a constructor?
2. How is a constructor different from a method?
3. What is a default constructor?
4. Can constructors be overloaded?
5. What is constructor chaining?
6. What is the difference between `this()` and `super()`?

---

# 16. Summary

Constructors are responsible for initializing newly created objects. They execute automatically during object creation, ensure objects begin in a valid state, and support overloading, chaining, and inheritance through `this()` and `super()`. Although constructors are closely associated with object creation, the JVM allocates the object before the constructor runs, making initialization their primary responsibility.
