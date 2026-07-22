# Lesson 133 — Builder Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Builder Pattern** is a creational design pattern used to construct **complex objects step by step**.

It is especially useful when an object has many optional parameters or multiple possible configurations.

---

# 2. Problem

Using constructors for many fields becomes confusing.

```java
Student s = new Student(
    "Alice", 20, "Pune", "CSE", 8.9, true
);
```

As fields increase, readability decreases.

---

# 3. Solution

Use a Builder to configure the object gradually.

```text
Client
   │
StudentBuilder
   │
build()
   │
Student
```

---

# 4. Example

### Product

```java
class Student {
    String name;
    int age;
    String city;
}
```

### Builder

```java
class StudentBuilder {

    private Student student = new Student();

    public StudentBuilder setName(String name) {
        student.name = name;
        return this;
    }

    public StudentBuilder setAge(int age) {
        student.age = age;
        return this;
    }

    public StudentBuilder setCity(String city) {
        student.city = city;
        return this;
    }

    public Student build() {
        return student;
    }
}
```

### Client

```java
Student student = new StudentBuilder()
        .setName("Alice")
        .setAge(20)
        .setCity("Pune")
        .build();
```

---

# 5. How It Works

```text
Client
   │
Builder
   │
Set Properties
   │
build()
   │
Finished Object
```

---

# 6. Advantages

- Readable object creation
- Supports optional parameters
- Avoids telescoping constructors
- Improves maintainability
- Can create immutable objects

---

# 7. Disadvantages

- Extra builder class
- More boilerplate for simple objects

---

# 8. Builder vs Factory

| Builder | Factory |
|---------|---------|
| Builds step by step | Creates directly |
| Best for complex objects | Best for choosing object types |
| Many optional fields | Usually one creation call |

---

# 9. Builder vs Constructor

| Constructor | Builder |
|-------------|---------|
| Fixed parameters | Flexible configuration |
| Hard to read with many arguments | Fluent and readable |

---

# 10. Real-World Uses

- HTTP request builders
- SQL query builders
- Configuration objects
- Complex DTO creation
- `StringBuilder` follows a similar fluent style

Because trying to remember the meaning of the eighth constructor argument is a hobby nobody enjoys for long.

---

# 11. Best Practices

- Return `this` from setter methods.
- Keep `build()` responsible only for object creation.
- Validate required fields before returning the object.
- Consider immutable products.

---

# 12. Interview Questions

1. What problem does the Builder pattern solve?
2. When should Builder be preferred over constructors?
3. Builder vs Factory?
4. Can Builder create immutable objects?
5. What are the advantages of fluent APIs?

---

# 13. Quick Revision

```text
Builder Pattern

✔ Step-by-Step Construction
✔ Fluent API
✔ Optional Parameters
✔ Readable Code

Flow

Client
   │
Builder
   │
Configure
   │
build()
   │
Object
```

---

# 14. Summary

The Builder pattern simplifies the creation of complex objects by separating construction from representation. It improves readability, supports optional parameters, avoids telescoping constructors, and is widely used in enterprise Java applications for creating configurable and immutable objects.
