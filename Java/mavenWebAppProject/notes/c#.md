# Runtime Polymorphism in C# Using Shape, Line, Circle

In C#, runtime polymorphism is implemented using:

* `virtual`
* `override`

Internally CLR (Common Language Runtime) maintains structures conceptually similar to:

* vtable
* method table
* object type metadata

---

# Example

```csharp
using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
}

class Line : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Line");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program
{
    static void Main()
    {
        Shape s1 = new Line();
        Shape s2 = new Circle();

        s1.Draw();
        s2.Draw();
    }
}
```

---

# Output

```text id="wfx11h"
Drawing Line
Drawing Circle
```

---

# What Happens Internally

---

# Step 1 — Base Class Defines Virtual Method

```csharp
public virtual void Draw()
```

This tells CLR:

```text id="zlgb4g"
"This method can be overridden"
```

So runtime creates an entry in method table.

---

# Step 2 — Derived Classes Override Method

```csharp
public override void Draw()
```

Derived classes replace base implementation.

---

# Conceptual Method Tables

---

# Shape Method Table

```text id="jlwm3w"
Shape_MethodTable
+----------------------+
| Shape.Draw()         |
+----------------------+
```

---

# Line Method Table

```text id="2cfr8g"
Line_MethodTable
+----------------------+
| Line.Draw()          |
+----------------------+
```

---

# Circle Method Table

```text id="e0rd0w"
Circle_MethodTable
+----------------------+
| Circle.Draw()        |
+----------------------+
```

---

# Object Memory Structure

In C#, every object internally stores hidden runtime metadata reference.

Conceptually similar to:

```text id="zowjso"
type pointer / method table pointer
```

---

# Shape Object

```csharp
Shape s = new Shape();
```

Memory:

```text id="b7c9hy"
+---------------------------+
| Type Pointer ------------ | -----> Shape_MethodTable
+---------------------------+
| Shape fields              |
+---------------------------+
```

---

# Line Object

```csharp
Shape s = new Line();
```

Actual object memory:

```text id="8eq0bh"
+---------------------------+
| Type Pointer ------------ | -----> Line_MethodTable
+---------------------------+
| Shape fields              |
+---------------------------+
| Line fields               |
+---------------------------+
```

---

# Circle Object

```csharp
Shape s = new Circle();
```

Memory:

```text id="lh0vow"
+---------------------------+
| Type Pointer ------------ | -----> Circle_MethodTable
+---------------------------+
| Shape fields              |
+---------------------------+
| Circle fields             |
+---------------------------+
```

---

# Runtime Dispatch

```csharp
Shape s = new Circle();

s.Draw();
```

---

# Compiler Knows Only

```text id="ijcbf5"
Reference type = Shape
```

BUT runtime object is:

```text id="8d7ykn"
Circle object
```

---

# Runtime Resolution

Conceptually CLR performs:

```text id="zz5o5o"
1. Access object
2. Read type pointer
3. Go to method table
4. Find Draw()
5. Execute correct override
```

---

# Runtime Flow Diagram

```text id="gl1k6t"
Shape reference
      |
      v

+----------------------+
|    Circle Object     |
|----------------------|
| Type Pointer ------- | --------------------+
+----------------------+                     |
| Shape fields         |                     |
+----------------------+                     |
| Circle fields        |                     |
+----------------------+                     |
                                             v

                                +----------------------+
                                | Circle_MethodTable   |
                                |----------------------|
                                | Circle.Draw()        |
                                +----------------------+
                                             |
                                             v

                                      Circle.Draw()
```

---

# Why This Is Polymorphism

Same statement:

```csharp
s.Draw();
```

Different behavior depending on actual object.

---

# Another Example

```csharp
Shape s = new Line();

s.Draw();
```

Flow:

```text id="npn7eb"
s
|
v

Line Object
+----------------------+
| Type Pointer ------- | -----> Line_MethodTable
+----------------------+

Line_MethodTable
+----------------------+
| Line.Draw()          |
+----------------------+
```

Executed method:

```text id="ymfnwc"
Line.Draw()
```

---

# Without virtual and override

If:

```csharp
public void Draw()
```

instead of:

```csharp
public virtual void Draw()
```

then method binding becomes:

```text id="kp3w0j"
STATIC DISPATCH
```

Meaning:

```csharp
Shape s = new Circle();

s.Draw();
```

calls:

```text id="f0nfxg"
Shape.Draw()
```

NOT `Circle.Draw()`.

---

# Relationship Between Concepts

| Concept             | Purpose                            |
| ------------------- | ---------------------------------- |
| virtual             | Allows overriding                  |
| override            | Replaces base implementation       |
| method table        | Stores virtual method references   |
| hidden type pointer | Connects object to method table    |
| runtime dispatch    | Chooses method during execution    |
| polymorphism        | Same interface, different behavior |

---

# Important Insight

```text id="2fgz84"
Reference type does NOT decide method
Actual object type decides method
```

Because runtime uses:

```text id="49tbha"
object → type pointer → method table → overridden method
```

---

# Final Visualization

```text id="mjlwmx"
                COMPILE TIME
        --------------------------------

        virtual Draw()

                ↓

        CLR creates method tables



                RUNTIME
        --------------------------------

        Shape s = new Circle();

                  s
                  |
                  v

          +------------------+
          |  Circle Object   |
          |------------------|
          | Type Pointer --- | ----------------+
          +------------------+                 |
                                               v

                                   +----------------------+
                                   | Circle_MethodTable   |
                                   |----------------------|
                                   | Circle.Draw()        |
                                   +----------------------+
                                               |
                                               v

                                        Circle.Draw()
```