# Lesson 161 — Class Loading

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Before any Java program executes, the **Java Virtual Machine (JVM)** must load the required classes into memory. This process is known as **Class Loading**.

The JVM loads class definitions only when they are needed, making Java efficient and platform-independent.

Understanding class loading is essential for OOP interviews because every object, method, and inheritance relationship depends on it.

---

# 2. What is Class Loading?

**Class Loading** is the process of reading a `.class` file and creating its runtime representation inside the JVM.

```text
Student.java
      │
javac
      ▼
Student.class
      │
      ▼
JVM
      │
Class Loader
      │
Runtime Class
```

---

# 3. Class Loader Subsystem

The JVM contains a dedicated **Class Loader Subsystem**.

Its responsibilities include:

- Loading class files
- Verifying bytecode
- Linking classes
- Initializing static members

---

# 4. Types of Class Loaders

```text
Bootstrap ClassLoader
        │
Extension (Platform) ClassLoader
        │
Application (System) ClassLoader
```

### Bootstrap Class Loader
- Loads core Java libraries
- Example: `java.lang.String`

### Platform Class Loader
- Loads Java platform modules

### Application Class Loader
- Loads classes from the application's classpath

---

# 5. Class Loading Process

```text
Load
   │
Link
   │
Initialize
```

---

# 6. Loading Phase

During loading:

- JVM locates the `.class` file
- Reads bytecode
- Creates a `Class` object in memory

---

# 7. Linking Phase

Linking consists of three stages.

### Verification

Checks that bytecode is valid and secure.

### Preparation

Allocates memory for static variables.

### Resolution

Converts symbolic references into direct references.

```text
Verification
      │
Preparation
      │
Resolution
```

---

# 8. Initialization Phase

Static variables receive their assigned values.

Static blocks execute.

```java
class Demo {

    static {
        System.out.println("Loaded");
    }
}
```

The static block runs only once when the class is initialized.

---

# 9. Parent Delegation Model

Class loaders follow the **Parent Delegation Model**.

```text
Application
      │
asks
      ▼
Platform
      │
asks
      ▼
Bootstrap
```

If the parent loader can load the class, the child does not reload it.

Benefits:

- Prevents duplicate loading
- Improves security
- Ensures core Java classes remain trusted

---

# 10. When is a Class Loaded?

A class is generally loaded when:

- An object is created
- A static method is called
- A static variable is accessed
- Reflection is used
- The class is explicitly loaded

Example:

```java
Class.forName("Student");
```

---

# 11. Why Lazy Loading?

The JVM loads classes only when required.

Benefits:

- Faster startup
- Lower memory usage
- Better performance

Because loading every class "just in case" would be like unpacking your entire suitcase to find a toothbrush.

---

# 12. Best Practices

- Avoid unnecessary static initialization.
- Keep static blocks lightweight.
- Understand the parent delegation model.
- Avoid custom class loaders unless necessary.

---

# 13. Interview Questions

1. What is class loading?
2. Explain the phases of class loading.
3. What are the different class loaders?
4. What is the Parent Delegation Model?
5. What happens during linking?

---

# 14. Quick Revision

```text
Class Loading

Load
  │
Link
  ├── Verify
  ├── Prepare
  └── Resolve
  │
Initialize
```

---

# 15. Interview Cheat Sheet

```text
Class Loading

✔ Bootstrap Loader
✔ Platform Loader
✔ Application Loader

Phases

Load
Link
Initialize

Link

Verify
Prepare
Resolve

Parent Delegation

Child → Parent
```

---

# 16. Summary

Class Loading is the JVM process of locating, loading, linking, and initializing Java classes before they are executed. Through the Class Loader Subsystem and the Parent Delegation Model, the JVM ensures efficient, secure, and reliable execution of Java programs while loading classes only when needed.
