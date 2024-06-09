# tl1-tp6-2024-ElBranda
## ¿String es un tipo por valor o un tipo por referencia?
```string``` es un tipo por referencia. Cada vez que se modifica una cadena, en realidad se crea una cadena nueva en memoria y se reasigna.
## ¿Qué secuencias de escape tiene el tipo string?
1. \\\\: Representa una barra diagonal inversa.
2. \\\\t: Coincide con un carácter de tabulación.
3. \\\\n: Coincide con una nueva línea.
4. \\\\r: Coincide con un retorno de carro.
5. \\\\\\": Representa una comilla doble.
6. \\\\': Representa una comilla simple.
7. \\\\\\\\: Representa una barra diagonal inversa literal.
## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
```$``` (Cadenas Interpoladas): Cuando se utiliza el símbolo ```$``` antes de una cadena, se está creando una cadena interpolada. Esto significa que se pueden incluir variables previamente definidas dentro de la cadena, y el compilador se encargará de reemplazarlas por sus valores correspondientes en tiempo de ejecución. Por ejemplo:
```csharp
string nombre = "Juan";
string saludo = $"¡Hola, {nombre}!";
// El valor de 'saludo' será "¡Hola, Juan!"
```

```@``` (Identificador Textual): Este símbolo se utiliza para insertar caracteres especiales en una cadena. Por ejemplo, si se necesita incluir una ruta de archivo con caracteres de escape (como \), se puede usar ```@``` para que la cadena trate los caracteres literalmente. Por ejemplo:
```csharp
string rutaArchivo = @"C:\MisDocumentos\archivo.txt";
// La cadena resultante será "C:\MisDocumentos\archivo.txt"
```
