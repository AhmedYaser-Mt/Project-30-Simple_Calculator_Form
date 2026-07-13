# 🧮 Project 30 — Simple Calculator Form

> A fully functional C# Windows Forms calculator with dark/light theme toggle, cascading backspace logic, percentage support, and enum-based state machine.

---

<img width="350" height="500" alt="image" src="https://github.com/user-attachments/assets/98a6be33-010a-4b2b-9314-0ac18d0090b2" />


---

## 🚀 Project Overview

A calculator looks simple from the outside.

Building one properly is a different story.

At every moment, the calculator has to know:

- Are we entering the first number or the second?
- Has an operator been selected yet?
- Are we currently showing a result?

This project handles all of that using a clean **enum-based state machine** backed by **nullable types**, a **6-branch cascading backspace**, percentage support for both operands, and a live dark/light theme toggle.

Every button knows its role.
Every state is tracked.
Every action is fully reversible.

---

## 🏗 Architecture

```
frmSimpleCalculator
│
├── 📊 State Machine
│   ├── enCurrentOperand { Operand1 | Operand2 | Result }
│   ├── Nullable<Double>  Operand1
│   ├── Nullable<Double>  Operand2
│   └── Nullable<char>    Operator
│
├── 🎯 Input Handlers
│   ├── btnDigit_Click()     ──► AddDigit()
│   ├── btnOperator_Click()  ──► AddOperator()
│   └── btn_Click()          ──► [ C | Del | % | = | . | Theme ]
│
├── 🧠 Core Logic
│   ├── AddDigit / AddOperator / AddPercentage
│   ├── Delete()      — 6-branch cascading backspace
│   ├── ShowResult()  / CalculateResult()
│   └── ChangeTheme() — Dark ↔ Light
│
└── 📺 Display
    └── txtScreen (TextBox) — sole UI output surface
```

---

## ⚙ Core Functionalities

| Feature | Behavior |
|---|---|
| Basic Arithmetic | Addition, Subtraction, Multiplication, Division |
| Percentage | Applies to either operand correctly |
| Cascading Delete | Result → Operator → % → Decimal Point → Digit |
| Clear | Resets all state and clears screen |
| Division by Zero | Detects and shows a "Math Error!" message |
| Decimal Point | Full floating-point input support |
| Theme Toggle | Switches between Dark and Light modes instantly |

---

## 💡 Design Decisions

**1. Nullable Types for Operands and Operator**

`Nullable<Double>` and `Nullable<char>` are used intentionally.

`null` means "not entered yet" — not zero, not an empty string.

This removes all ambiguity from state checks.

---

**2. Enum-Based State Machine**

```csharp
enum enCurrentOperand { Operand1, Operand2, Result }
```

The calculator always knows exactly where it is.

Every input decision branches on `CurrentOperand`.

---

**3. Button Tag Dispatch**

All utility buttons share one `btn_Click` handler.

Routing is done via the `Tag` property — not button names or positions.

```csharp
switch (((Button)sender).Tag)
{
    case "Clear":       Clear();         break;
    case "Delete":      Delete();        break;
    case "%":           AddPercentage(); break;
    case "=":           ShowResult();    break;
    case ".":           AddFractionPoint(); break;
    case "ChangeTheme": ChangeTheme();   break;
}
```

Event logic stays centralized and clean.

---

**4. Cascading Delete Logic**

`Delete()` doesn't just remove one character.

It checks what the last thing entered was — and undoes it correctly:

```csharp
private void Delete()
{
    if (IsResultEqualCurrent())             DeleteResult();
    else if (IsLastIndexEqualOperator())    DeleteOperator();
    else if (IsLastIndexEqualPercentage())  DeletePercentage();
    else if (IsLastIndexEqualPoint())       DeleteLastCharacterInScreen();
    else if (IsOperand2EqualCurrent())      DeleteLastDigitFromOperand2();
    else                                    DeleteLastDigitFromOperand1();
}
```

Six branches. Each one handles a different state.

---

**5. Screen as Source of Truth for Operand2**

When a digit is typed after the operator, `Operand2` is parsed directly from the screen:

```csharp
string[] Operands = txtScreen.Text.Split(Convert.ToChar(Operator));
Operand2 = Convert.ToDouble(Operands[1]);
```

No separate string buffer needed.

---

**6. Result Display with `Environment.NewLine`**

The result appears below the full expression:

```
5+3=
8
```

`Environment.NewLine` is used instead of `\n` for proper cross-platform line breaks.

---

**7. Theme Detection via `BackColor` Comparison**

```csharp
if (this.BackColor == Color.Black)
    ChangeToLightTheme();
else
    ChangeToDarkTheme();
```

No extra flag or boolean needed.
The UI itself holds the state.

---

## 🛠 Tech Stack

| | |
|---|---|
| Language | C# |
| Framework | .NET Framework |
| UI Platform | Windows Forms (WinForms) |
| IDE | Visual Studio |

---

## 🎯 Practice Series — Stage Two · Course 14 · C# Level 1

> Controls constraint: **Form · Label · TextBox · Button** (or subset)
> Mastering depth before expanding to new controls.

| Project | Name | Controls Used |
|---|---|---|
| Project 23 | Pizza Order Form | Form · Label · TextBox · Button |
| Project 24 | Tic-Tac-Toe Game | Form · Label · TextBox · Button |
| Project 25 | Tax Calculator Form | Form · Label · TextBox · Button |
| Project 26 | Text Encryption Form | Form · Label · TextBox · Button |
| Project 27 | Password Generator Form | Form · Label · TextBox · Button |
| Project 28 | Age Calculator Form | Form · Label · TextBox · Button |
| Project 29 | String Manipulation Form | Form · Label · TextBox · Button |
| **Project 30** | **Simple Calculator Form** ✅ | **Form · TextBox · Button** |

---

## 🏁 Milestone Context

Project 30 is the 8th project in the Stage Two WinForms practice series.

The series deliberately works within a tight control constraint — not because of a technical limit, but to force deeper thinking within a small surface area.

This calculator intentionally drops the Label.

The TextBox carries the full display responsibility on its own.

Eight projects.
Three or four controls.
Real engineering thinking.

---

## 🙏 Gratitude

Thank you to:

**[Programming Advices Platform](https://programmingadvices.com)**

**[Dr. Mohammed Abu-Hadhoud](https://programmingadvices.com)**

The real value of this roadmap is not just what it teaches.

It's *when* it teaches it — and *why* it teaches it in that exact order.

---

## 🚀 What's Next?

More projects.

New controls.

Deeper systems.

The foundation keeps getting stronger — Insha'Allah.
