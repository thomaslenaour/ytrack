### Be polite

### Explanations

Like most programming languages, PHP also allows you to write code that performs different actions based on the results of logical or comparative test conditions at run time.

This means that you can create test conditions in the form of expressions that evaluate to true or false and based on these results you can perform certain actions.

There are several statements in PHP that you can use to make decisions :

- The if statement
- The if ... else statement
- The if ... elseif .... else statement

#### The if statement

The if statement is used to execute a block of code only if the specified condition is true. These are the simplest PHP conditional statements and can be written as :

```php
<?php

 if (condition) {
   // Code à exécuter
 }
```

---

#### The if ... else statement

You can improve the decision-making process by providing an alternative choice by adding an else statement to the if statement.

The if ... else statement lets you execute one block of code if the specified condition evaluates to true and another block of code if it evaluates to false. It can be written, like this :

![img.png](https://imgur.com/a/viKjL5C)

#### Syntaxe :

```php
<?php
 if (condition) {
   // Code to run if the condition is true
 } else {
   // Code to run if the condition is false
 }
```

---

#### The if ... elseif .... else statement

This is a special statement used to combine multiple if ... else statements.

![img_1.png](img_1.https://i.imgur.com/OB5GTHE.png
#### Syntax :

```php
<?php

 if (condition1) {
   // Code à exécuter si condition1 est vraie
 } elseif (condition2) {
  // Code à exécuter si la condition1 est fausse et la condition2 est vraie
 } else {
  // Code à exécuter si condition1 et condition2 sont fausses
 }
```

### Instructions

Create a variable named `$hour` which retrieves the current time.

Using the `if elseif else` statement, write a script that will display a string according to the time of day.

- If the time is between 6 a.m. and 12 p.m., display: Hello! Have a nice day :)

- If the time is between 12 p.m. and 6 p.m. inclusive display: Have a good afternoon!

- If the time is between 6 p.m. and 9 p.m. inclusive, display: Good evening! Hope you had a good day!

- Otherwise display: Good night! See you tomorrow :)

### Notions

- [if elseif else](https://www.php.net/manual/fr/control-structures.elseif.php)
