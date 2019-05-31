# ValueObjects

The idea behind this tiny project is to explore options on how to persist ([ValueObjects](https://martinfowler.com/bliki/ValueObject.html)) in a relational database, using an ORM like EntityFramework.
Although EF supports the notion of ComplexTypes, it is very limited because:
- They can only have simple properties, not other ComplexTypes.
- It's not possible to use collections of a CompexType and still persist them together with the parent entity.

So, what I'm trying here is to store any ValueObject type you may have as a simple JSON string in a column in the parent entity in a way the model doesn't need to know.

Really simple, I know. But this is a problem that irritates me a lot because teams are forced to persist VOs in their own tables, and this sometimes is confusing.

## License
The MIT License ([MIT](https://tldrlegal.com/license/mit-license#summary))

Copyright (c) 2019 KchoPein!

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
