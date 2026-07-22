# Lesson 36 — Access Modifiers

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Access modifiers determine **who can access classes, variables, methods, and constructors** in Java.

They are essential for implementing encapsulation, data hiding, and secure object-oriented design.

Java provides four access modifiers:

- `private`
- Default (package-private)
- `protected`
- `public`

---

# 2. Why Access Modifiers?

Without access control:

- Internal data could be modified by anyone.
- Business rules could be bypassed.
- Applications would become difficult to maintain.

Access modifiers help expose only what is necessary.

---

# 3. Types of Access Modifiers

| Modifier | Same Class | Same Package | Subclass | Other Packages |
|-----------|:----------:|:------------:|:--------:|:--------------:|
| private | ✅ | ❌ | ❌ | ❌ |
| Default | ✅ | ✅ | ❌ | ❌ |
| protected | ✅ | ✅ | ✅ | ❌* |
| public | ✅ | ✅ | ✅ | ✅ |

*Accessible in another package only through inheritance.

---

# 4. Private

A `private` member is accessible only within its own class.

```java
class Employee {

    private double salary;
}
```

Use for sensitive internal data.

---

# 5. Default (Package-Private)

When no modifier is specified:

```java
class Employee {

    int id;
}
```

The member is accessible only within the same package.

---

# 6. Protected

A `protected` member is accessible:

- Within the same package
- In subclasses, even if they are in another package

```java
class Animal {

    protected void eat() {

    }
}
```

Useful when designing inheritance hierarchies.

---

# 7. Public

A `public` member is accessible from anywhere.

```java
public class Calculator {

    public int add(int a, int b){
        return a + b;
    }
}
```

Use only for APIs intended to be used externally.

---

# 8. Access Modifier Hierarchy

```text
Most Restrictive

private
   │
Default
   │
protected
   │
public

Least Restrictive
```

Choose the least permissive modifier that satisfies your design.

---

# 9. Real-World Analogy

```text
House

Private Room      -> private
Living Room       -> default
Family Garden     -> protected
Main Entrance     -> public
```

Not every area should be accessible to everyone.

---

# 10. Enterprise Example

```java
class BankAccount {

    private double balance;

    public void deposit(double amount){
        if(amount > 0){
            balance += amount;
        }
    }

    public double getBalance(){
        return balance;
    }
}
```

`balance` is protected while business operations remain public.

---

# 11. Best Practices

- Keep fields `private`.
- Expose behavior instead of data.
- Use `protected` only for inheritance.
- Avoid unnecessary `public` members.
- Follow the principle of least privilege.

---

# 12. Common Mistakes

❌ Declaring every field `public`.

❌ Using `protected` instead of `private` without a valid inheritance need.

❌ Exposing implementation details through public methods.

---

# 13. Interview Questions

1. What are the four access modifiers in Java?
2. What is the difference between `private` and `protected`?
3. What is the default access modifier?
4. Can a subclass access a protected member in another package?
5. Which modifier provides the widest accessibility?

---

# 14. Summary

Access modifiers control the visibility of Java classes and members. By choosing appropriate access levels, developers can implement encapsulation, protect internal object state, reduce coupling, and build secure, maintainable software. As a general rule, start with the most restrictive modifier and increase visibility only when necessary.
