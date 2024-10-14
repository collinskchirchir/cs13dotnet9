# region Exploring unary operators

int a = 3;
int b = a++; // postfix operator ++ operator executes after assignment

WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");
# endregion

# region Assignment operators

int p = 6;
p += 3; // equivalent to: p = p + 3;
p -= 3; // equivalent to: p = p - 3;


# endregion
