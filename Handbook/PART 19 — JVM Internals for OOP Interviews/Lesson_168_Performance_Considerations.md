# Lesson 168 — Performance Considerations

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Writing correct Java code is important, but writing **efficient** Java code is equally valuable in enterprise software.

Performance depends on many JVM and OOP factors including:

- Object creation
- Memory management
- Garbage Collection
- Method calls
- Collections
- String handling
- JIT optimizations
- Algorithm efficiency

Good performance comes from good design first, optimization second.

---

# 2. Performance Layers

```text
Application Design
        │
OOP Design
        │
JVM
        │
JIT Compiler
        │
Operating System
        │
Hardware
```

Every layer influences execution speed.

---

# 3. Object Creation

Creating objects allocates heap memory.

```java
Student s = new Student();
```

Excessive temporary objects increase GC pressure.

Best practices:

- Reuse objects when appropriate.
- Avoid unnecessary allocations in tight loops.

---

# 4. Garbage Collection

Unused objects are reclaimed automatically.

```text
Create Objects
      │
Become Unreachable
      │
Garbage Collector
      │
Memory Reclaimed
```

Avoid keeping unnecessary object references alive.

---

# 5. String Performance

Bad:

```java
String s = "";

for(int i = 0; i < 1000; i++){
    s += i;
}
```

Better:

```java
StringBuilder sb = new StringBuilder();

for(int i = 0; i < 1000; i++){
    sb.append(i);
}
```

`StringBuilder` avoids repeated object creation.

---

# 6. Collections

Choose the correct collection.

| Collection | Best For |
|------------|----------|
| ArrayList | Fast random access |
| LinkedList | Frequent insert/delete |
| HashMap | Fast key lookup |
| HashSet | Unique elements |
| TreeMap | Sorted keys |

Selecting the wrong data structure often costs more than any JVM optimization.

---

# 7. Method Calls

Small methods are good for readability.

Modern JVMs frequently inline simple methods through the JIT, so don't avoid clean design just because of tiny call overhead.

---

# 8. Primitive vs Wrapper Types

Primitive:

```java
int count = 10;
```

Wrapper:

```java
Integer count = 10;
```

Primitives:

- Use less memory
- Avoid boxing/unboxing
- Execute faster in many cases

Use wrappers only when required (collections, generics, nullable values).

---

# 9. Algorithms Matter Most

Example:

```text
O(n²)

vs

O(n log n)
```

Choosing an efficient algorithm usually provides far greater gains than micro-optimizations.

---

# 10. Avoid Premature Optimization

Donald Knuth famously warned against premature optimization.

Recommended approach:

```text
Write Correct Code
        │
Measure
        │
Find Bottleneck
        │
Optimize
```

Profile first instead of guessing.

---

# 11. JVM Optimizations

The JVM already performs:

- JIT compilation
- Method inlining
- Dead code elimination
- Escape analysis
- Constant folding
- Loop optimizations

Because the JVM spends a surprising amount of time making your code look smarter than it was at 2 a.m.

---

# 12. Best Practices

- Follow SOLID principles.
- Prefer readable code.
- Select appropriate data structures.
- Minimize unnecessary object creation.
- Use `StringBuilder` for repeated concatenation.
- Profile before optimizing.
- Let the JVM perform its optimizations.

---

# 13. Common Performance Mistakes

❌ Using inefficient algorithms

❌ Creating excessive temporary objects

❌ Concatenating strings in loops

❌ Choosing the wrong collection

❌ Ignoring profiling results

❌ Optimizing code without measurements

---

# 14. Interview Questions

1. Why is `StringBuilder` faster than `String` concatenation?
2. How does garbage collection affect performance?
3. Primitive vs wrapper types?
4. Why should you profile before optimizing?
5. How does the JIT improve performance?

---

# 15. Quick Revision

```text
Performance

Algorithms
Collections
Object Creation
Garbage Collection
JIT
StringBuilder
Profiling
```

---

# 16. Interview Cheat Sheet

```text
Performance Tips

✔ Efficient Algorithms
✔ Right Collection
✔ StringBuilder
✔ Fewer Temporary Objects
✔ Profile First
✔ Trust the JIT

Remember

Correctness
    ↓
Measurement
    ↓
Optimization
```

---

# 17. Summary

Java performance is influenced by application design, algorithms, memory management, object creation, collection choices, and JVM optimizations. Enterprise developers should focus on writing clean, maintainable code first, measure real bottlenecks with profiling tools, and then apply targeted optimizations while relying on the JVM and JIT compiler to handle many low-level performance improvements automatically.
