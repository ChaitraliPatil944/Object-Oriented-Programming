# Lesson 167 — JIT Compilation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Just-In-Time (JIT) Compiler** is one of the key technologies that makes Java applications fast.

Although Java programs are compiled into **bytecode**, executing bytecode through an interpreter alone would be slower than native machine code. To improve performance, the JVM identifies frequently executed code and compiles it into optimized machine code at runtime.

This process is called **Just-In-Time (JIT) Compilation**.

---

# 2. Why JIT Compilation?

Without JIT:

```text
Java Source
     │
 javac
     │
Bytecode
     │
Interpreter
     │
Machine
```

Every bytecode instruction is interpreted repeatedly.

With JIT:

```text
Bytecode
    │
Interpreter
    │
Frequently Used?
    │
   Yes
    ▼
JIT Compiler
    │
Optimized Machine Code
```

Hot code executes much faster.

---

# 3. JVM Execution Flow

```text
Java Source
      │
    javac
      │
 .class File
      │
      ▼
Bytecode Verifier
      │
Interpreter
      │
Hotspot Detection
      │
JIT Compiler
      │
Native Machine Code
```

---

# 4. What is HotSpot?

The JVM monitors running programs and identifies **hot spots**, which are methods or loops executed many times.

These are compiled into native machine code for faster execution.

Examples of hot spots:

- Frequently called methods
- Long-running loops
- Performance-critical algorithms

---

# 5. Interpreter vs JIT

| Interpreter | JIT Compiler |
|-------------|--------------|
| Executes bytecode line by line | Compiles bytecode to native code |
| Faster startup | Better long-term performance |
| No optimization | Performs advanced optimizations |

---

# 6. Common Optimizations

The JIT compiler performs several optimizations:

- Method inlining
- Dead code elimination
- Loop optimization
- Constant folding
- Escape analysis
- Devirtualization (when possible)

These reduce execution time without changing program behavior.

---

# 7. Method Inlining

Instead of calling a small method repeatedly:

```java
int square(int x) {
    return x * x;
}
```

The JIT may replace the call with:

```text
x * x
```

This removes call overhead.

---

# 8. Dynamic Optimization

Unlike traditional compilers, the JIT can optimize code using runtime information.

```text
Program Runs
      │
Collect Statistics
      │
Optimize
      │
Recompile if Needed
```

The JVM may even discard earlier optimizations if assumptions become invalid.

---

# 9. Advantages

- High execution speed
- Runtime optimizations
- Better CPU utilization
- Improved performance for long-running applications
- Transparent to developers

Because the JVM quietly studies your program until it knows which parts deserve VIP treatment.

---

# 10. Limitations

- Slightly slower startup
- Additional memory usage
- Compilation overhead during execution
- Less benefit for very short-lived programs

---

# 11. Best Practices

- Avoid premature micro-optimizations.
- Write clean, readable Java code.
- Let the JVM optimize common execution paths.
- Profile applications before optimizing manually.

---

# 12. Interview Questions

1. What is JIT Compilation?
2. Why is JIT faster than interpretation?
3. What is HotSpot?
4. Name some JIT optimizations.
5. Interpreter vs JIT?

---

# 13. Quick Revision

```text
Bytecode
    │
Interpreter
    │
Hot Code
    │
JIT Compiler
    │
Native Machine Code
```

---

# 14. Interview Cheat Sheet

```text
JIT

✔ Just-In-Time Compiler
✔ Runtime Optimization
✔ Native Machine Code

HotSpot

Frequently Executed Code

Optimizations

Inlining
Loop Optimization
Constant Folding
Dead Code Elimination
Escape Analysis
```

---

# 15. Summary

The Just-In-Time (JIT) Compiler improves Java performance by converting frequently executed bytecode into optimized native machine code during runtime. Working alongside the interpreter and HotSpot detection, the JIT enables Java applications to achieve high performance while preserving platform independence, making it a fundamental component of the JVM.
