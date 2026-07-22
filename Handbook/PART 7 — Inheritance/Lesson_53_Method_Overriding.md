# Lesson 53 — Method Overriding

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Method Overriding** is a feature of inheritance where a child class provides its own implementation of a method already defined in its parent class.

It enables **runtime polymorphism**, allowing the same method call to behave differently depending on the actual object.

---

# 2. Definition

Method overriding occurs when:

- A subclass inherits a method.
- The subclass defines a method with the **same name**, **same parameters**, and **compatible return type**.

```text
Parent Method
      │
      ▼
Child Overrides
```

---

# 3. Basic Example

```java
class Animal {

    void sound() {
        System.out.println("Animal makes a sound");
    }
}

class Dog extends Animal {

    @Override
    void sound() {
        System.out.println("Dog barks");
    }
}
```

Usage:

```java
Animal a = new Dog();
a.sound();
```

Output:

```
Dog barks
```

---

# 4. Rules for Method Overriding

- Method name must be the same.
- Parameters must be identical.
- Return type must be the same or covariant.
- Access modifier cannot be more restrictive.
- `final`, `static`, and `private` methods cannot be overridden.

---

# 5. @Override Annotation

```java
@Override
void sound() {
    System.out.println("Dog barks");
}
```

Benefits:

- Compile-time verification
- Better readability
- Prevents accidental mistakes

---

# 6. Runtime Polymorphism

```text
Animal ref = new Dog();

ref.sound()
      │
      ▼
Dog.sound()
```

The method executed depends on the object's actual type, not the reference type.

---

# 7. Calling Parent Method

Use the `super` keyword.

```java
class Dog extends Animal {

    @Override
    void sound() {
        super.sound();
        System.out.println("Dog barks");
    }
}
```

---

# 8. Enterprise Example

```java
class Notification {

    void send() {
        System.out.println("Generic Notification");
    }
}

class EmailNotification extends Notification {

    @Override
    void send() {
        System.out.println("Sending Email");
    }
}
```

Different notification types override the same behavior.

---

# 9. Overriding vs Overloading

| Overriding | Overloading |
|------------|-------------|
| Different classes | Same class |
| Same method signature | Different parameter list |
| Runtime polymorphism | Compile-time polymorphism |
| Uses inheritance | Inheritance not required |

---

# 10. Best Practices

- Always use `@Override`.
- Preserve the parent's contract.
- Override only when behavior should genuinely change.
- Keep overridden methods meaningful.

---

# 11. Common Mistakes

❌ Changing parameter types.

❌ Making access more restrictive.

❌ Attempting to override `static`, `final`, or `private` methods.

❌ Forgetting `@Override`.

---

# 12. Interview Questions

1. What is method overriding?
2. What are its rules?
3. Can static methods be overridden?
4. What is runtime polymorphism?
5. Why use `@Override`?
6. Difference between overriding and overloading?

---

# 13. Quick Revision

```text
Method Overriding
│
├── Requires inheritance
├── Same signature
├── Runtime polymorphism
├── Dynamic method dispatch
└── Prefer @Override
```

---

# 14. Summary

Method overriding allows subclasses to provide specialized implementations of inherited methods while preserving a common interface. It is the foundation of runtime polymorphism in Java and enables flexible, extensible, and maintainable object-oriented designs widely used in enterprise applications.
