# Simba
.Net library for generating latex tables base on memory objects.

## Sample

### How to use:
```csharp
var persons = new List<MockPerson>()
{
    new MockPerson("John", "Smith", 18),
    new MockPerson("John", "Carter", 20)
};

var latex = persons.ToLatex();
```

### Result:

```
\begin{table}
    \begin{tabular}{|c|c|c|}
        \hline
            John & Smith & 18 \\
        \hline
            John & Carter & 20 \\
        \hline
    \end{tabular}
\end{table}
```

## Contribution
Feel free to make pull request and add something or just create issue with question / suggestion for improvement / report bug.
