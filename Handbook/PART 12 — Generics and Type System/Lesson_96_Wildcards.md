# Lesson 96 — Wildcards

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Wildcards** in Java Generics provide flexibility when working with generic types whose exact type is unknown.

A wildcard is represented by the **question mark (`?`)**.

Instead of specifying an exact type like:

```java
ArrayList<String>
```

we can write:

```java
ArrayList<?>
```

which means "an `ArrayList` of some unknown type."

Wildcards are mainly used when writing **generic APIs**, **collections**, and **framework code**.

---

# 2. Why Do We Need Wildcards?

Generics in Java are **invariant**.

Example:

```java
ArrayList<String> names = new ArrayList<>();

ArrayList<Object> objects = names; // Compilation Error
```

Even though `String` is an `Object`, `ArrayList<String>` is **not** an `ArrayList<Object>`.

Wildcards solve this limitation.

---

# 3. Unbounded Wildcard (`?`)

An **unbounded wildcard** accepts a generic type of **any reference type**.

### Syntax

```java
List<?>
```

### Example

```java
import java.util.*;

class Demo {

    static void printList(List<?> list) {

        for (Object item : list) {
            System.out.println(item);
        }
    }

    public static void main(String[] args) {

        printList(List.of("Java", "Python"));
        printList(List.of(10, 20, 30));
    }
}
```

The method works with lists of any type.

---

# 4. Upper Bounded Wildcard (`? extends T`)

An **upper bounded wildcard** accepts a type that is **T or a subclass of T**.

### Syntax

```java
<? extends Number>
```

### Example

```java
static double sum(List<? extends Number> numbers) {

    double total = 0;

    for (Number n : numbers) {
        total += n.doubleValue();
    }

    return total;
}
```

This method accepts:

- `List<Integer>`
- `List<Double>`
- `List<Float>`

But **not** `List<String>`.

---

# 5. Lower Bounded Wildcard (`? super T`)

A **lower bounded wildcard** accepts a type that is **T or a superclass of T**.

### Syntax

```java
<? super Integer>
```

### Example

```java
static void addNumbers(List<? super Integer> list) {

    list.add(10);
    list.add(20);
}
```

Accepted:

- `List<Integer>`
- `List<Number>`
- `List<Object>`

---

# 6. Types of Wildcards

| Wildcard | Meaning |
|----------|---------|
| `<?>` | Any type |
| `<? extends T>` | T or subclass |
| `<? super T>` | T or superclass |

---

# 7. PECS Principle

A popular rule for choosing wildcards is:

**PECS**

```text
Producer Extends
Consumer Super
```

### Producer (`extends`)

If a collection **produces** data for reading:

```java
List<? extends Number>
```

### Consumer (`super`)

If a collection **consumes** data for writing:

```java
List<? super Integer>
```

This rule appears frequently in interviews.

---

# 8. Wildcards vs Type Parameters

| Wildcards | Type Parameters |
|-----------|-----------------|
| Unknown type | Named type |
| Flexible APIs | Reusable algorithms |
| Mostly used in parameters | Used in classes & methods |

---

# 9. Advantages

- Flexible APIs
- Better code reuse
- Compile-time type safety
- Supports inheritance with Generics
- Cleaner library design

---

# 10. Best Practices

- Use `<?>` when the type is irrelevant.
- Use `extends` for read-only collections.
- Use `super` for write operations.
- Follow the PECS rule.

---

# 11. Common Mistakes

❌ Assuming `List<Object>` accepts every generic list.

❌ Using `extends` when adding elements.

❌ Forgetting the PECS rule.

---

# 12. Interview Questions

1. What is a wildcard in Java?
2. Explain unbounded, upper bounded, and lower bounded wildcards.
3. What is the PECS principle?
4. Why can't `List<String>` be assigned to `List<Object>`?
5. When should `extends` and `super` be used?

---

# 13. Quick Revision

```text
Wildcards
│
├── <?>
├── <? extends T>
├── <? super T>
└── PECS
```

---

# 14. Interview Cheat Sheet

```text
Wildcards

<?>              → Any Type

<? extends T>    → Read (Producer)

<? super T>      → Write (Consumer)

PECS
Producer Extends
Consumer Super
```

---

# 15. Summary

Wildcards make Java Generics more flexible by allowing methods to work with unknown or related generic types. Unbounded wildcards accept any reference type, upper bounded wildcards support reading from subtype collections, and lower bounded wildcards support writing to supertype collections. Understanding the PECS principle is essential for designing robust generic APIs and is a common topic in Java interviews.
