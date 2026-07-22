# Lesson 54 — The `super` Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **`super`** keyword in Java refers to the **immediate parent class object**.

It is primarily used to:

- Access parent class variables
- Call parent class methods
- Invoke parent class constructors

The `super` keyword helps subclasses reuse and extend parent class functionality.

---

# 2. Why Do We Need `super`?

When a subclass defines members with the same names as its parent, the child members hide the parent members.

The `super` keyword allows access to the hidden parent members.

```text
Parent Class
      ▲
      │
    super
      │
Child Class
```

---

# 3. Accessing Parent Variables

```java
class Animal {

    String name = "Animal";
}

class Dog extends Animal {

    String name = "Dog";

    void display() {
        System.out.println(super.name);
        System.out.println(this.name);
    }
}
```

Output:

```
Animal
Dog
```

`super.name` accesses the parent variable, while `this.name` accesses the child variable.

---

# 4. Calling Parent Methods

```java
class Animal {

    void sound() {
        System.out.println("Animal Sound");
    }
}

class Dog extends Animal {

    @Override
    void sound() {
        super.sound();
        System.out.println("Dog Barks");
    }
}
```

Output:

```
Animal Sound
Dog Barks
```

---

# 5. Calling Parent Constructors

Use `super()` to invoke the parent constructor.

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

If `super()` is not written explicitly, Java inserts it automatically if possible.

---

# 6. Parameterized Constructor

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

The `super(...)` call must be the **first statement** inside a constructor.

---

# 7. `super` vs `this`

| `super` | `this` |
|----------|--------|
| Refers to parent class | Refers to current object |
| Accesses parent members | Accesses current class members |
| Calls parent constructor | Calls another constructor in same class |

---

# 8. Enterprise Example

```java
class User {

    void login() {
        System.out.println("User Login");
    }
}

class Admin extends User {

    @Override
    void login() {
        super.login();
        System.out.println("Admin Verification");
    }
}
```

The child extends the parent's behavior instead of replacing it completely.

---

# 9. Rules of `super`

- Refers only to the immediate parent.
- `super()` must be the first statement in a constructor.
- Cannot be used in a static context.
- Cannot access private parent members directly.

---

# 10. Best Practices

- Use `super` when extending existing behavior.
- Call parameterized constructors to initialize inherited state.
- Avoid unnecessary use of `super` if parent behavior is not required.
- Keep inheritance hierarchies simple.

---

# 11. Common Mistakes

❌ Calling `super()` after another statement.

❌ Confusing `super` with `this`.

❌ Trying to access private parent members.

❌ Using `super` inside static methods.

---

# 12. Interview Questions

1. What is the `super` keyword?
2. Why is `super()` used?
3. Can `super()` appear anywhere in a constructor?
4. What is the difference between `super` and `this`?
5. Can `super` access private members?

---

# 13. Quick Revision

```text
super
│
├── Parent variables
├── Parent methods
├── Parent constructor
├── Immediate superclass
└── First statement in constructor
```

---

# 14. Summary

The `super` keyword provides access to members of the immediate parent class. It is used to reuse inherited functionality, invoke parent constructors, and resolve naming conflicts between parent and child classes. Proper use of `super` improves code reuse, readability, and maintainability, making it an essential feature in Java inheritance and enterprise application development.
