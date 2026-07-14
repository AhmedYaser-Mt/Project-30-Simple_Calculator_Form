# 🧮 Project 30 — Simple Calculator Form

> A dark/light theme calculator in C# — built with Form, TextBox, and Button only. The screen is both display and data model. Features an intelligent 6-case delete and percentage with proper undo.

---

<img width="350" height="500" alt="image" src="https://github.com/user-attachments/assets/f9c8dcad-9b5f-4be4-b693-97c71d941fe8" />


---

## 🚀 Project Overview

Sixth project in the WinForms self-practice series.

This one is a milestone.

No Labels anywhere — only Form, TextBox, and Button.

A classic calculator. But built with real engineering underneath.

The screen TextBox is not just a display.

It is the data model.

Every digit typed, every operator pressed, every result calculated — everything lives on the screen. Operands are parsed back from it when needed.

The Delete button handles six different scenarios depending on what the last character is. Percentage applies to the actual stored value and can be properly reversed. The theme toggles between dark and light with one click.

---

## 🏗️ Architecture Design

**State**

```csharp
Nullable<Double> Operand1 = null, Operand2 = null;
Nullable<char>   Operator  = null;

enum enCurrentOperand { Operand1, Operand2, Result }
enCurrentOperand CurrentOperand = enCurrentOperand.Operand1;
```

**Three event handlers cover all 20 buttons**

```
btn_Click               (special buttons — Tag-based switch)
 ├── "Clear"       → Clear()         reset all state
 ├── "Delete"      → Delete()        6-case intelligent delete
 ├── "%"           → AddPercentage() ÷100 on value + screen symbol
 ├── "="           → ShowResult()    calculate + display
 ├── "."           → AddFractionPoint()
 └── "ChangeTheme" → ChangeTheme()   toggles BackColor

btnDigit_Click          (0–9 buttons)
 └── AddDigit(btn)
      ├── AddCharacterToScreen(btn.Tag)
      ├── (Operand1 mode) → Operand1 = Double.Parse(screen)
      └── (Operand2 mode) → Operand2 = Double.Parse(screen.Split(operator)[1])

btnOperator_Click       (+, -, ×, ÷ buttons)
 └── AddOperator(btn)
      ├── AddCharacterToScreen(btn.Tag)
      ├── Operator = btn.Tag[0]
      └── CurrentOperand = Operand2
```

---

## ⚙️ Core Functionalities

| Button | Action |
|---|---|
| 0–9 | Append digit to screen and update current operand |
| + - × ÷ | Append operator, store it, switch to Operand2 mode |
| % | Divide current operand by 100, show % symbol on screen |
| = | Calculate result, show full expression + answer |
| Del | Smart delete — handles 6 different screen states |
| C | Clear everything — screen, values, and state |
| . | Append decimal point to current number |
| Change Theme | Toggle between dark (black) and light (white) |

---

## 🧠 Design Decisions Worth Noting

### The screen is the model

There is no separate variable holding the display string.

The TextBox IS the data store.

When Operand2 is needed, it is extracted from the screen text:

```csharp
private void AddDigitToOperand2()
{
    string[] Operands = txtScreen.Text.Split(Convert.ToChar(Operator));
    Operand2 = Convert.ToDouble(Operands[1]);
}
```

The screen stores "5+3" and the code splits on '+' to get the second operand.

This eliminates a second synchronization problem — display and data cannot go out of sync because they are the same thing.

---

### Nullable state — semantically accurate

```csharp
Nullable<Double> Operand1 = null;
Nullable<char>   Operator  = null;
```

`null` means "not set yet" — not zero, not empty, not -9999.

When Operand1 is null, nothing has been entered yet. When Operator is null, no operator has been pressed yet. The state means exactly what it says.

---

### 6-case intelligent Delete

`Delete()` figures out what to erase based on what the last character is:

```
1. Screen empty          → do nothing
2. Showing result        → peel back the full result to pre-equals state
3. Last char is operator → remove operator, reset to Operand1 mode
4. Last char is %        → reverse the ÷100 calculation, remove symbol
5. Last char is .        → just remove the decimal point
6. In Operand2 mode      → remove last digit from Operand2
7. Default               → remove last digit from Operand1
```

Each case is a dedicated private function. `Delete()` just routes to the right one.

---

### Percentage with proper undo

Adding % is not just visual:

```csharp
private void AddPercentage()
{
    if (IsOperand2EqualCurrent())
        Operand2 /= 100;   // changes the actual value
    else
        Operand1 /= 100;

    AddPercentageToScreen();   // shows % on screen
}
```

The stored operand is actually divided by 100.

Pressing Del on a % reverses it by multiplying back by 100.

The symbol and the value stay in sync.

---

### Division by zero protection

Before calculating, one check:

```csharp
private bool IsDividingByZero()
{
    return (Operator == '÷' && Operand2 == 0);
}
```

If true, the screen shows:

```
Math Error!
Press C To Clear
```

No exception, no crash. Clear message, clear action.

---

### Theme toggle in two checks

```csharp
private void ChangeTheme()
{
    if (this.BackColor == Color.Black)
        ChangeToLightTheme();
    else
        ChangeToDarkTheme();
}
```

The current BackColor IS the state. No extra boolean needed.

---

## 🛠️ Tech Stack

| | |
|---|---|
| **Language** | C# |
| **Framework** | .NET Framework |
| **UI** | Windows Forms (WinForms) |
| **IDE** | Visual Studio |
| **Type** | Desktop Application |
| **Controls Used** | Form, TextBox, Button |

> Note: No Label control used in this project — only 3 controls total.

---

## 📦 Practice Project Series

| Project | Application |
|---|---|
| **Project 25 — Tax Calculator** | Tax computation + session history |
| **Project 26 — Text Encryption** | Caesar Cipher encrypt/decrypt |
| **Project 27 — Password Generator** | GUID + Key + Password generator |
| **Project 28 — Age Calculator** | Full age breakdown with time lived |
| **Project 29 — String Manipulation** | Live string operations toolkit |
| **Project 30 — Simple Calculator** *(you are here)* | Full calculator with theme toggle |
| More projects | Next control groups 🔄 |

---

## 🏁 Course & Milestone Context

- ✅ Course 14 — C# Level 1 (Stage Two, in progress)
- ✅ Sixth project in the WinForms self-practice series
- ✅ Part of the **Programming Advices Roadmap** — Stage Two

---

## 🙏 Gratitude

Thank you to:

**[Programming Advices Platform](https://programmingadvices.com)**

**[Dr. Mohammed Abu-Hadhoud](https://programmingadvices.com)**

---

## 🔥 What's Next

Next control group.

Next project.
