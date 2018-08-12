# Checked/Unchecked Context
According to the MS documentation, C# statements can execute in either checked or unchecked context.

### Checked
* Arithmetic overflow raises an exception.

### Unchecked
* Arithmetic overflow is ignored and the result is truncated by discarding any high-order bits that don't fit the destination type.


[Microsoft Documentation on Checked/Unchecked](https://goo.gl/rnJW7v)