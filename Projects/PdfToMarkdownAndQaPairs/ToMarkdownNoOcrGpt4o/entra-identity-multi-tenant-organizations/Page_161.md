## Reference for writing expressions for attribute mappings in Microsoft Entra ID

When you configure provisioning to a SaaS application, one of the types of attribute mappings that you can specify is an expression mapping. For these mappings, you must write a script-like expression that allows you to transform your users' data into formats that are more acceptable for the SaaS application.

### Syntax overview

The syntax for Expressions for Attribute Mappings is reminiscent of Visual Basic for Applications (VBA) functions.

- The entire expression must be defined in terms of functions, which consist of a name followed by arguments in parentheses: `FunctionName(<argument 1>, <argument N>)`
- You can nest functions within each other. For example: `FunctionOne(FunctionTwo(<argument1>))`
- You can pass three different types of arguments into functions:

  1. Attributes, which must be enclosed in square brackets. For example: `[attributeName]`
  2. String constants, which must be enclosed in double quotes. For example: `"United States"`
  3. Other Functions. For example: `FunctionOne(<argument1>, FunctionTwo(<argument2>))`

- For string constants, if you need a backslash (`\`) or quotation mark (`"`) in the string, it must be escaped with the backslash (`\`) symbol. For example: `Company name: \"Contoso\"`
- The syntax is case-sensitive, which must be considered while typing them as strings in a function vs copy pasting them directly from here.

## List of Functions