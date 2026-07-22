# Lesson 86 — this Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **`this`** keyword in Java is a reference variable that refers to the **current object**.

Whenever an object invokes one of its methods, Java automatically passes the reference of that object through `this`.

It is mainly used to:

- Resolve variable name conflicts
- Call another constructor
- Invoke current object methods
- Pass the current object
- Return the current object

---

# 2. Why Do We Need `this`?

When local variables and instance variables have the same name, Java gives priority to the local variable.

```java
class Student {

    String name;

    Student(String name) {
        this.name = name;
    }
}
```

`this.name` refers to the instance variable, while `name` refers to the constructor parameter.

---

# 3. Referring to Current Object

```java
class Employee {

    int id;

    Employee(int id) {
        this.id = id;
    }

    void display() {
        System.out.println(this.id);
    }
}
```

---

# 4. Calling Current Class Method

```java
class Demo {

    void show() {
        System.out.println("Show");
    }

    void display() {
        this.show();
    }
}
```

Using `this` is optional here because Java automatically searches the current object.

---

# 5. Constructor Chaining

`this()` calls another constructor in the same class.

```java
class Student {

    Student() {
        this(101);
    }

    Student(int id) {
        System.out.println(id);
    }
}
```

Rules:

- `this()` must be the first statement.
- Only one constructor call (`this()` or `super()`) is allowed first.

---

# 6. Passing Current Object

```java
class Test {

    void print(Test obj) {
        System.out.println("Object Received");
    }

    void display() {
        print(this);
    }
}
```

Useful for callbacks and event handling.

---

# 7. Returning Current Object

```java
class Calculator {

    Calculator add() {
        return this;
    }
}
```

This is widely used in **method chaining**.

Example:

```java
builder.setName("Alice")
       .setAge(21)
       .build();
```

---

# 8. `this` vs `super`

| this | super |
|------|-------|
| Refers to current object | Refers to parent object |
| Calls current constructor | Calls parent constructor |
| Accesses current members | Accesses parent members |

---

# 9. Advantages

- Removes ambiguity
- Supports constructor chaining
- Improves readability
- Enables fluent APIs
- Simplifies object-oriented programming

---

# 10. Best Practices

- Use `this` when variable names conflict.
- Use constructor chaining to avoid duplicate code.
- Avoid unnecessary use when there is no ambiguity.

---

# 11. Common Mistakes

❌ Using `this()` anywhere except the first statement.

❌ Using both `this()` and `super()` in the same constructor.

❌ Confusing `this` with `super`.

---

# 12. Interview Questions

1. What is the `this` keyword?
2. Why is `this` needed?
3. What is constructor chaining?
4. Difference between `this` and `super`?
5. Can `this` be returned from a method?

---

# 13. Quick Revision

```text
this
│
├── Current Object
├── Current Method
├── Current Constructor
├── Pass Current Object
└── Return Current Object
```

---

# 14. Interview Cheat Sheet

```text
Uses of this
✔ Access current object's variables
✔ Call current methods
✔ Call another constructor
✔ Pass current object
✔ Return current object
```

---

# 15. Summary

The `this` keyword is a reference to the current object in Java. It resolves naming conflicts, supports constructor chaining, enables method chaining, and simplifies object-oriented programming. Mastering `this` is essential because it appears frequently in real-world Java code, frameworks, and technical interviews.
