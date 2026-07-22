# Lesson 166 — Annotations

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Annotations** are metadata added to Java code. They provide information to the compiler, JVM, or frameworks without changing the program's business logic.

Annotations are heavily used in enterprise frameworks such as **Spring**, **Hibernate**, **JUnit**, and **Jakarta EE**.

---

# 2. What are Annotations?

Annotations describe classes, methods, fields, parameters, or constructors.

```java
@Override
public String toString() {
    return "Demo";
}
```

`@Override` tells the compiler that the method overrides a superclass method.

---

# 3. Why Use Annotations?

Benefits:

- Reduce boilerplate code
- Configure frameworks
- Improve readability
- Enable compile-time checks
- Support runtime processing through reflection

---

# 4. Common Built-in Annotations

| Annotation | Purpose |
|------------|---------|
| `@Override` | Indicates method overriding |
| `@Deprecated` | Marks obsolete elements |
| `@SuppressWarnings` | Suppresses compiler warnings |
| `@FunctionalInterface` | Marks a functional interface |
| `@SafeVarargs` | Suppresses varargs warnings |

---

# 5. Spring Annotations

Frequently used annotations:

```text
@Component
@Service
@Repository
@Controller
@RestController
@Autowired
@Configuration
@Bean
```

These allow Spring to discover and manage application components automatically.

---

# 6. JPA/Hibernate Annotations

```java
@Entity
@Table(name = "users")
class User {

    @Id
    private Long id;
}
```

Common annotations:

- `@Entity`
- `@Table`
- `@Id`
- `@Column`
- `@OneToMany`
- `@ManyToOne`

---

# 7. JUnit Annotations

```java
@Test
void testAddition() {
}
```

Other examples:

- `@BeforeEach`
- `@AfterEach`
- `@BeforeAll`
- `@AfterAll`

---

# 8. Custom Annotations

You can create your own annotation.

```java
@interface Author {
    String name();
}
```

Usage:

```java
@Author(name = "Chaitrali")
class Demo {
}
```

---

# 9. Annotation Targets

Annotations can be applied to:

```text
Class
Method
Field
Constructor
Parameter
Package
Local Variable
```

---

# 10. Retention Policies

Retention determines how long an annotation is available.

| Policy | Availability |
|--------|--------------|
| `SOURCE` | Compiler only |
| `CLASS` | Stored in `.class` file |
| `RUNTIME` | Available through reflection |

Example:

```java
@Retention(RetentionPolicy.RUNTIME)
```

---

# 11. Reading Annotations

Reflection can inspect annotations.

```java
Class<?> cls = Demo.class;

if (cls.isAnnotationPresent(Author.class)) {
    System.out.println("Annotation Found");
}
```

Many frameworks scan annotations during startup.

---

# 12. Best Practices

- Use standard annotations whenever possible.
- Keep custom annotations simple.
- Use runtime retention only when necessary.
- Avoid excessive annotations that reduce readability.

Because eventually every line starts with `@Something`, and the code begins looking like it caught a mild rash.

---

# 13. Interview Questions

1. What are annotations?
2. Difference between metadata and business logic?
3. What does `@Override` do?
4. What are retention policies?
5. How are annotations processed at runtime?

---

# 14. Quick Revision

```text
Annotations

Built-in
Spring
Hibernate
JUnit
Custom

Retention

SOURCE
CLASS
RUNTIME
```

---

# 15. Interview Cheat Sheet

```text
Annotations

✔ Metadata
✔ Compiler Support
✔ Framework Configuration

Common

@Override
@Deprecated
@SuppressWarnings

Spring

@Service
@Repository
@RestController
@Autowired

Retention

SOURCE
CLASS
RUNTIME
```

---

# 16. Summary

Annotations are metadata that provide additional information about Java program elements without changing their business logic. They simplify framework configuration, improve code clarity, enable compile-time validation, and support runtime processing through reflection. Modern enterprise Java development relies extensively on annotations in frameworks such as Spring, Hibernate, and JUnit.
