### DNA difference

### Instructions

Geneticists need to calculate the differences between two strands of DNA represented, for example, as follows :

```
GAGCCTACTAACGGGAT
CATCGTAATGACGGCCT
^ ^ ^  ^ ^    ^^
```

> The differences are represented by `^`. For example here the answer is 7.

Créez une fonction `dnaDiff` qui prend en paramètres obligatoires deux `string` et retourne le nombre de différences entre les deux brins d'ADN. Si les deux brins d'ADN ne font pas la même taille retournez false.

Create a `dnaDiff` function which takes two `strings` as mandatory parameters and returns the number of differences between the two strands of DNA. If the two DNA strands are not the same size return false.

You are not allowed to use the native `array_diff` or` array_diff_assoc` functions, make your own.

### Notions

- [php.net/manual/en/function.array-diff.php](https://www.php.net/manual/en/function.array-diff.php)
