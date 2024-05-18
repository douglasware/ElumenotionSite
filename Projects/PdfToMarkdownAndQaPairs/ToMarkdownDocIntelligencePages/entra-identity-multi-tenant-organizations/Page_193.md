# Switch

Function: Switch(source, defaultValue, key1, value1, key2, value2, ... )

Description: When source value matches a key, returns value for that key. If source value doesn't match any keys, returns defaultValue. Key and value parameters must always come in pairs. The function always expects an even number of parameters. The function shouldn't be used for referential attributes such as manager.


# I Note

Switch function performs a case-sensitive string comparison of the source and key values. If you'd like to perform a case-insensitive comparison, normalize the source string before comparison using a nested ToLower function and ensure that all key strings use lowercase. Example: Switch(ToLower([statusFlag]), "0", "true", "1", "false", "0") . In this example, the source attribute statusFlag may have values ("True" / "true" / "TRUE"). However, the Switch function will always convert it to lowercase string "true" before comparison with key parameters.
 :selected:

# X Caution

For the source parameter, do not use the nested functions IsPresent, IsNull or IsNullOrEmpty. Instead use a literal empty string as one of the key values. Example: Switch([statusFlag], "Default Value", "true", "1", "", "0") . In this example, if the source attribute statusFlag is empty, the Switch function will return the value 0.


# Parameters:

03 Expand table

| Name | Required/ Repeating | Type | Notes |
| - | - | - | - |
| source | Required | String | Source value to update. |
| defaultValue | Optional | String | Default value to be used when source doesn't match any keys. Can be empty string (""). :unselected: |
| key | Required || String Key to compare source value with.  |
| value | Required || String Replacement value for the source matching the key.  |
