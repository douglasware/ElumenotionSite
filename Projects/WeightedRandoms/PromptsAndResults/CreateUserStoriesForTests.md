Based on the following user stories in gherkin format, create additional stories to for creation of unit tests designed for full code coverage to prove valid input works as expected as inputs change, for example, the probability of the center item increases as the center height increases, invalid inputs create exceptions, etc.

User Story 1: Class and method implementation
As a developer, I want to implement a C# class called WeightedRandomSelection with a generic method Select, so that it can process a list of items and return a selected item based on customizable parameters.

Acceptance Criteria:

The class should be named WeightedRandomSelection
The method should be named SelectItem and be generic
The method should accept the following parameters:
A list of items to be processed
A center percentage for the peak of the bell curve between 0 and 1
A center height for the center of the bell curve between 0 and 0.95
A scaling factor for adjusting the standard deviation between 0 and 10
User Story 2: Input validation
As a developer, I want to ensure that the input parameters for the SelectItem method are validated before processing, so that the algorithm can function correctly and prevent erroneous inputs.

Acceptance Criteria:

Validate the center percentage is between 0 and 1
Validate the center height is between 0 and 0.95
Validate the scaling factor is between 0 and 10
Throw an appropriate exception with a clear error message for invalid input values
User Story 3: Weight calculation
As a developer, I want to calculate the weights for each item in the list based on the customizable parameters, so that the algorithm can select an item with higher probability when its weight is higher.

Acceptance Criteria:

Implement a method to calculate the weights for each item
Weights should be based on the provided customizable parameters
The weight calculation should be based on a normal distribution
User Story 4: Random number generation and item selection
As a developer, I want to generate random numbers for item selection based on their weights, so that the algorithm can return a selected item from the list according to the calculated probability.

Acceptance Criteria:

Implement a method to generate random numbers based on item weights
Use the random numbers to select an item from the list
Return the selected item
User Story 5: Code quality and triple-slash comments
As a developer, I want to ensure that the code is of high quality with clear comments, proper formatting, appropriate variable names, and comprehensive triple-slash comments, so that other developers can easily understand and maintain the code.

Acceptance Criteria:

Write clear and concise comments explaining the purpose and function of each method and significant code block
Use proper formatting and indentation to improve readability
Use appropriate and descriptive variable names that convey their purpose
Write comprehensive triple-slash comments that include expected results, parameter info, and exceptions in detail
Ensure the code adheres to standard C# coding guidelines and best practices