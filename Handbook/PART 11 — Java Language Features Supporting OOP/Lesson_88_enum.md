# Lesson 88 — Enum

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **Enum (Enumeration)** is a special Java data type used to represent a fixed set of named constants.

Enums improve readability, type safety, and maintainability by restricting values to predefined constants.

Examples:

- Days of the week
- Months
- Directions
- Order status
- Traffic signals

Introduced in **Java 5**.

---

# 2. Why Use Enums?

Without enums:

```java
String status = "Shipped";
```

Problems:

- Typing mistakes
- Invalid values
- No compile-time safety

With enums:

```java
enum Status {
    PENDING,
    SHIPPED,
    DELIVERED
}
```

Only valid constants can be used.

---

# 3. Declaring an Enum

```java
enum Day {
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
}
```

Using it:

```java
Day today = Day.MONDAY;
System.out.println(today);
```

Output:

```text
MONDAY
```

---

# 4. Enum in Switch Statement

```java
enum TrafficLight {
    RED,
    YELLOW,
    GREEN
}

public class Demo {

    public static void main(String[] args) {

        TrafficLight signal = TrafficLight.GREEN;

        switch (signal) {
            case RED:
                System.out.println("Stop");
                break;

            case YELLOW:
                System.out.println("Ready");
                break;

            case GREEN:
                System.out.println("Go");
                break;
        }
    }
}
```

---

# 5. Enum with Fields and Constructors

Enums can have variables, constructors, and methods.

```java
enum Size {

    SMALL("S"),
    MEDIUM("M"),
    LARGE("L");

    private String code;

    Size(String code) {
        this.code = code;
    }

    public String getCode() {
        return code;
    }
}
```

Usage:

```java
System.out.println(Size.SMALL.getCode());
```

Output:

```text
S
```

---

# 6. Useful Enum Methods

```java
values()
```

Returns all constants.

```java
for (Day d : Day.values()) {
    System.out.println(d);
}
```

```java
valueOf("MONDAY")
```

Returns the matching enum constant.

```java
ordinal()
```

Returns the position of the constant.

---

# 7. Advantages

- Type safety
- Better readability
- Prevents invalid values
- Supports methods and constructors
- Easy to use with switch

---

# 8. Enum vs Constants

| Enum | Constant Variables |
|------|--------------------|
| Type-safe | Not type-safe |
| Fixed values | Any value possible |
| Supports methods | No |
| Better readability | Less expressive |

---

# 9. Best Practices

- Use enums instead of integer or string constants.
- Use meaningful constant names.
- Add behavior inside enums when appropriate.
- Avoid using ordinal() for business logic.

---

# 10. Common Mistakes

❌ Comparing enum names as strings.

❌ Depending on ordinal() values.

❌ Using integers instead of enums for fixed choices.

---

# 11. Interview Questions

1. What is an enum?
2. Why use enums instead of constants?
3. Can enums have constructors?
4. Can enums have methods?
5. Explain values(), valueOf(), and ordinal().

---

# 12. Quick Revision

```text
Enum
│
├── Named Constants
├── Type Safe
├── Constructors
├── Methods
└── Switch Support
```

---

# 13. Interview Cheat Sheet

```text
enum
│
├── Fixed Set of Values
├── Compile-Time Safety
├── values()
├── valueOf()
└── ordinal()
```

---

# 14. Summary

Enums provide a clean, type-safe way to represent a fixed set of constants in Java. Unlike traditional constants, enums can contain fields, constructors, and methods, making them powerful and expressive. They are widely used in enterprise applications to model states, categories, permissions, and other predefined values while reducing bugs caused by invalid inputs.
