# Runtime Polymorphism in Java Using Shape, Line, Circle

In Java, runtime polymorphism works using:

* method overriding
* dynamic method dispatch

Internally JVM uses structures conceptually similar to:

* vtable
* method table
* class metadata pointer

Java hides these implementation details from programmer.

---

# Example

```java id="6j5l5w"
class Shape {

    void draw() {
        System.out.println("Drawing Shape");
    }
}

class Line extends Shape {

    @Override
    void draw() {
        System.out.println("Drawing Line");
    }
}

class Circle extends Shape {

    @Override
    void draw() {
        System.out.println("Drawing Circle");
    }
}

public class Main {

    public static void main(String[] args) {

        Shape s1 = new Line();
        Shape s2 = new Circle();

        s1.draw();
        s2.draw();
    }
}
```

---

# Output

```text id="3x41ua"
Drawing Line
Drawing Circle
```

---

# Important Java Point

In Java:

```text id="n0z3y3"
All non-static, non-final, non-private methods
are virtual by default
```

So Java automatically supports runtime polymorphism.

Unlike C++, we do NOT write:

```cpp id="ylx6qe"
virtual
```

keyword.

---

# What Happens Internally

---

# Step 1 — Base Class Method

```java id="jlwmmz"
void draw()
```

JVM marks method as dynamically dispatchable.

---

# Step 2 — Derived Classes Override Method

```java id="lrw5z7"
@Override
void draw()
```

Derived class replaces base implementation.

---

# Conceptual Method Tables

JVM internally maintains structures similar to vtables.

---

# Shape Method Table

```text id="7mzc9m"
Shape_MethodTable
+----------------------+
| Shape.draw()         |
+----------------------+
```

---

# Line Method Table

```text id="jqtrdh"
Line_MethodTable
+----------------------+
| Line.draw()          |
+----------------------+
```

---

# Circle Method Table

```text id="nyftta"
Circle_MethodTable
+----------------------+
| Circle.draw()        |
+----------------------+
```

---

# Object Memory Structure

Every Java object internally stores hidden runtime metadata reference.

Conceptually:

```text id="l8l1nm"
class pointer / method table pointer
```

---

# Shape Object

```java id="z5iyl5"
Shape s = new Shape();
```

Memory:

```text id="8ot7k8"
+----------------------------+
| Class Pointer ------------ | -----> Shape_MethodTable
+----------------------------+
| Shape fields               |
+----------------------------+
```

---

# Line Object

```java id="z6njlwm"
Shape s = new Line();
```

Actual object memory:

```text id="jrvd1o"
+----------------------------+
| Class Pointer ------------ | -----> Line_MethodTable
+----------------------------+
| Shape fields               |
+----------------------------+
| Line fields                |
+----------------------------+
```

---

# Circle Object

```java id="8tgyxl"
Shape s = new Circle();
```

Memory:

```text id="n5q3k6"
+----------------------------+
| Class Pointer ------------ | -----> Circle_MethodTable
+----------------------------+
| Shape fields               |
+----------------------------+
| Circle fields              |
+----------------------------+
```

---

# Runtime Polymorphism

```java id="wmibp4"
Shape s = new Circle();

s.draw();
```

---

# Compiler Knows Only

```text id="jlwmkh"
Reference type = Shape
```

BUT actual runtime object is:

```text id="tq01jlwm"
Circle object
```

---

# Runtime Resolution

Conceptually JVM performs:

```text id="g52sr8"
1. Access object
2. Read class pointer
3. Go to method table
4. Find draw()
5. Execute correct overridden method
```

---

# Runtime Flow Diagram

```text id="x4eclm"
Shape reference
       |
       v

+----------------------+
|    Circle Object     |
|----------------------|
| Class Pointer ------ | --------------------+
+----------------------+                     |
| Shape fields         |                     |
+----------------------+                     |
| Circle fields        |                     |
+----------------------+                     |
                                             v

                                +----------------------+
                                | Circle_MethodTable   |
                                |----------------------|
                                | Circle.draw()        |
                                +----------------------+
                                             |
                                             v

                                      Circle.draw()
```

---

# Why This Is Polymorphism

Same statement:

```java id="4u5m7o"
s.draw();
```

Different behavior depending on actual object.

---

# Another Example

```java id="lh8t9s"
Shape s = new Line();

s.draw();
```

Flow:

```text id="jlwm1x"
s
|
v

Line Object
+----------------------+
| Class Pointer ------ | -----> Line_MethodTable
+----------------------+

Line_MethodTable
+----------------------+
| Line.draw()          |
+----------------------+
```

Executed method:

```text id="mzn3gp"
Line.draw()
```

---

# What About Static, Final, Private Methods?

These methods do NOT support runtime polymorphism.

Because JVM uses:

```text id="tcf0ff"
STATIC BINDING
```

for them.

Example:

```java id="gofjlwm"
final void draw()
private void draw()
static void draw()
```

These cannot participate in overriding-based polymorphism.

---

# Relationship Between Concepts

| Concept              | Purpose                            |
| -------------------- | ---------------------------------- |
| overriding           | Replaces base implementation       |
| dynamic dispatch     | Runtime method selection           |
| method table         | Stores virtual method references   |
| hidden class pointer | Connects object to method table    |
| runtime polymorphism | Same interface, different behavior |

---

# Important Insight

```text id="k1jlwm"
Reference type does NOT decide method
Actual object type decides method
```

Because JVM uses:

```text id="y6kt2m"
object → class pointer → method table → overridden method
```

---

# Final Visualization

```text id="z8g8r4"
                 COMPILE TIME
        --------------------------------

              Shape s;

        Compiler only knows:
              "s is Shape reference"



                    RUNTIME
        --------------------------------

          s = new Circle();

                    s
                    |
                    v

           +------------------+
           |  Circle Object   |
           |------------------|
           | Class Pointer -- | ----------------+
           +------------------+                 |
                                                 v

                                    +----------------------+
                                    | Circle_MethodTable   |
                                    |----------------------|
                                    | Circle.draw()        |
                                    +----------------------+
                                                 |
                                                 v

                                         Circle.draw()
```