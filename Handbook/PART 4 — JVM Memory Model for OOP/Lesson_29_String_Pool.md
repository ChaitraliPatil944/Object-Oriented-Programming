# Lesson 29 — String Pool

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Strings are among the most frequently created objects in Java. To improve memory efficiency and performance, the JVM maintains a special memory area called the **String Pool**.

Instead of creating duplicate String objects, Java reuses existing immutable String instances whenever possible.

---

# 2. What is the String Pool?

The **String Pool** (also called the **String Constant Pool**) is a special area managed by the JVM that stores unique String literals.

If an identical literal already exists, Java returns a reference to the existing object instead of creating a new one.

---

# 3. Why Does Java Use a String Pool?

Without pooling:

```text
"Java"
"Java"
"Java"
```

Three separate objects would waste memory.

With pooling:

```text
           String Pool

        +-----------+
        |  "Java"   |
        +-----------+
          ▲    ▲   ▲
          │    │   │
         s1   s2  s3
```

One object is shared by many references.

---

# 4. Creating Strings

### Using String Literal

```java
String s1 = "Java";
String s2 = "Java";
```

Memory:

```text
String Pool

+-----------+
|  "Java"   |
+-----------+
 ▲         ▲
 │         │
s1        s2
```

Only one object is created.

---

### Using new

```java
String s3 = new String("Java");
```

Memory:

```text
String Pool

"Java"

Heap

new String("Java")
```

A new heap object is created even though the literal exists in the pool.

---

# 5. Comparing Strings

```java
String s1 = "Java";
String s2 = "Java";
```

```java
System.out.println(s1 == s2);
```

Output:

```text
true
```

Both references point to the same pooled object.

---

```java
String s3 = new String("Java");

System.out.println(s1 == s3);
```

Output:

```text
false
```

Different objects exist.

To compare contents:

```java
System.out.println(s1.equals(s3));
```

Output:

```text
true
```

---

# 6. intern() Method

The `intern()` method returns the pooled version of a String.

```java
String s1 = new String("Java");
String s2 = s1.intern();

System.out.println(s2 == "Java");
```

Output:

```text
true
```

---

# 7. Why Strings Are Immutable

Strings cannot be modified after creation.

Benefits:

- Safe sharing in the String Pool
- Better security
- Thread safety
- Efficient caching
- Reliable hash codes

Example:

```java
String s = "Java";
s = s + " Programming";
```

A new String object is created.

---

# 8. Memory Diagram

```text
Stack

s1 ─────┐
         │
s2 ──────┘
         │
         ▼

String Pool

+----------------+
|     "Java"     |
+----------------+

s3 ─────────────► Heap Object
```

---

# 9. Enterprise Example

A web application may repeatedly use:

```text
"GET"
"POST"
"SUCCESS"
"ERROR"
```

Pooling avoids creating thousands of duplicate String objects, reducing memory consumption.

---

# 10. String Pool vs Heap

| Feature | String Pool | Heap |
|---------|-------------|------|
| Stores | String literals | All objects |
| Duplicate literals | Reused | New objects allowed |
| Memory Efficiency | High | Lower for duplicate strings |
| Managed by JVM | Yes | Yes |

---

# 11. Common Mistakes

❌ Using `==` to compare String contents.

❌ Assuming `new String()` uses only the pool.

❌ Believing Strings can be modified in place.

Correct understanding:

- Use `.equals()` for content comparison.
- `new String()` creates a separate heap object.
- Strings are immutable.

---

# 12. Best Practices

- Prefer String literals when possible.
- Use `.equals()` for comparisons.
- Avoid unnecessary `new String()`.
- Use `StringBuilder` for repeated modifications.

---

# 13. Interview Questions

1. What is the String Pool?
2. Why are Strings immutable?
3. What is the difference between `"Java"` and `new String("Java")`?
4. What does `intern()` do?
5. Why should `.equals()` be used instead of `==`?

---

# 14. Summary

The String Pool is a JVM optimization that stores unique String literals to reduce memory usage and improve performance. Because Strings are immutable, they can be safely shared among multiple references. Understanding the String Pool helps explain String comparisons, memory allocation, object sharing, and common interview questions related to Java internals.
