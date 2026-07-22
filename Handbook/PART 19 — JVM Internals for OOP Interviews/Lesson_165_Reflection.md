# Lesson 165 — Reflection

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Reflection** is a feature of Java that allows a program to inspect and manipulate classes, methods, fields, constructors, and annotations **at runtime**.

Normally, Java code knows about classes at compile time. Reflection removes this limitation by allowing programs to discover information dynamically while they are running.

Frameworks such as **Spring**, **Hibernate**, **JUnit**, and **Jackson** rely heavily on reflection.

---

# 2. What is Reflection?

Reflection enables a program to:

- Inspect classes
- Read fields
- Invoke methods
- Create objects
- Read annotations
- Access constructors

without knowing all details at compile time.

```text
Running Program
       │
       ▼
Reflection API
       │
       ▼
Class Information
```

---

# 3. The Class Class

Every loaded Java class has a corresponding **Class** object.

Example:

```java
Class<?> cls = String.class;
```

Or

```java
Class<?> cls = obj.getClass();
```

Or

```java
Class<?> cls = Class.forName("Student");
```

These are the three common ways to obtain a `Class` object.

---

# 4. Reflection API

Common classes:

```text
java.lang.Class

java.lang.reflect.Method

java.lang.reflect.Field

java.lang.reflect.Constructor
```

These classes provide metadata about Java programs.

---

# 5. Reading Class Information

```java
Class<?> cls = Student.class;

System.out.println(cls.getName());
System.out.println(cls.getSimpleName());
```

Useful methods include:

- `getName()`
- `getPackageName()`
- `getSuperclass()`
- `getInterfaces()`

---

# 6. Reading Methods

```java
Method[] methods =
        cls.getDeclaredMethods();

for(Method m : methods){
    System.out.println(m.getName());
}
```

Reflection can list all declared methods of a class.

---

# 7. Reading Fields

```java
Field[] fields =
        cls.getDeclaredFields();
```

Reflection can inspect:

- Field names
- Types
- Modifiers

---

# 8. Creating Objects Dynamically

```java
Class<?> cls = Student.class;

Object obj =
        cls.getDeclaredConstructor()
           .newInstance();
```

The object is created without using the `new` keyword directly.

---

# 9. Invoking Methods

```java
Method method =
        cls.getMethod("print");

method.invoke(obj);
```

The JVM executes the method dynamically.

---

# 10. Accessing Private Members

Reflection can bypass access checks.

```java
field.setAccessible(true);
```

This allows reading or modifying private fields.

Use with caution because it breaks encapsulation.

---

# 11. Real-World Uses

Reflection is widely used in:

- Spring Dependency Injection
- Hibernate ORM
- JSON Serialization (Jackson)
- JUnit Test Discovery
- Annotation Processing
- Plugin Systems

Because enterprise frameworks enjoy discovering your classes more than your debugger enjoys hiding the bug.

---

# 12. Advantages

- Dynamic behavior
- Framework support
- Runtime inspection
- Flexible architectures
- Automatic dependency discovery

---

# 13. Disadvantages

- Slower than direct calls
- Breaks encapsulation
- More complex code
- Security restrictions
- Harder to optimize

---

# 14. Best Practices

- Use reflection only when necessary.
- Prefer normal method calls for application logic.
- Avoid modifying private members unless required.
- Cache reflection metadata in performance-critical code.

---

# 15. Interview Questions

1. What is reflection?
2. What is the `Class` class?
3. How can you invoke a method using reflection?
4. Why is reflection slower?
5. Name frameworks that use reflection.

---

# 16. Quick Revision

```text
Reflection

Class
 │
 ├── Fields
 ├── Methods
 ├── Constructors
 └── Annotations
```

---

# 17. Interview Cheat Sheet

```text
Reflection

✔ Runtime Inspection
✔ Class Metadata
✔ Dynamic Object Creation
✔ Dynamic Method Calls

Core Classes

Class
Method
Field
Constructor

Used In

Spring
Hibernate
Jackson
JUnit
```

---

# 18. Summary

Reflection is a powerful Java feature that enables runtime inspection and manipulation of classes, methods, fields, constructors, and annotations. It forms the foundation of many enterprise frameworks, allowing dynamic object creation, dependency injection, and metadata processing. Although extremely flexible, reflection should be used carefully because it introduces performance overhead and can bypass normal encapsulation.
