## Name | Required/Repeating | Type | Notes
--- | --- | --- | ---
replacementValue | Optional | String | New value to replace old one with.
replacementAttributeName | Optional | String | Name of the attribute to be used for replacement value.
template | Optional | String | When template value is provided, we’ll look for oldValue inside the template and replace it with source value.
replacementAttributeName |  |  | replacementAttributeName and return it as the replacement value.



## Replace characters using a regular expression

### Example 1: Using oldValue and replacementValue to replace the entire source string with another string.

Let's say your HR system has an attribute `BusinessTitle`. As part of recent job title changes, your company wants to update anyone with the business title "Product Developer" to "Software Engineer". Then in this case, you can use the following expression in your attribute mapping.

```
Replace([BusinessTitle],"Product Developer", , , "Software Engineer", , )
```

- **source:** `[BusinessTitle]`
- **oldValue:** "Product Developer"
- **replacementValue:** "Software Engineer"
- **Expression output:** Software Engineer

### Example 2: Using oldValue and template to insert the source string into another templated string.

The parameter oldValue is a misnomer in this scenario. It's actually the value that gets replaced.  
Let's say you want to always generate login ID in the format `<username>@contoso.com`. There is a source attribute called UserID and you want that value to be used for the `<username>` portion of the login ID. Then in this case, you can use the following expression in your attribute mapping.

```
Replace([UserID],"<username>", , , , , "<username>@contoso.com")
```

- **source:** `[UserID]` = "jsmith"