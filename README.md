# ExampleCSharp

## Interfaces

Use "I" + PascalCase

public interface IAnimal

## Class Naming

Use PascalCase

public class BigDog : IAnimal

## Private class variables

Use "_" + camelCase

e.g. private readonly string _myString

## function or constructor variables

Use camelCase

public MyObject(string myName){}

## Other

Files should be logically organised in folders, the reason is to make the code base easy to read and navigate.
It is done differently depending on the company/developer and may be well done or badly done.
During development, developers may refactor/reorganise code.

As projects get bigger and bigger, you may start to split the code further into separate library projects.
So you may have a library just for data retrieval for example.

Generally code should not contain comments, it should be easy enough to understand that it is self documenting
Comments are acceptable if the code or concept requires further explanation i.e. if using some strange code required as a workaround for a bug.





