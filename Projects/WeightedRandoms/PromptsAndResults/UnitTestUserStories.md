User Story 6: Unit testing for valid input and output
As a developer, I want to create unit tests that cover various valid input cases and verify the expected output, so that I can ensure the algorithm behaves correctly with different parameters.

Acceptance Criteria:

Test the SelectItem method with a variety of valid input values
Verify that the selected item follows the expected probability distribution based on the input parameters
Test the case where the center item has a higher probability when the center height increases
Ensure full code coverage with unit tests

User Story 7: Unit testing for invalid input and exception handling
As a developer, I want to create unit tests that cover various invalid input cases and verify that appropriate exceptions are thrown, so that I can ensure the algorithm handles erroneous inputs correctly and prevents invalid results.

Acceptance Criteria:

Test the SelectItem method with invalid input values for the center percentage, center height, and scaling factor
Verify that appropriate exceptions are thrown with clear error messages for each invalid input case
Ensure full code coverage with unit tests

User Story 8: Unit testing for weight calculation and random number generation
As a developer, I want to create unit tests that specifically target the weight calculation and random number generation methods, so that I can ensure the internal functions of the algorithm are working as expected.

Acceptance Criteria:

Test the weight calculation method with various input values and verify the calculated weights follow the expected normal distribution
Test the random number generation method and verify that the generated numbers are within the expected range and are distributed according to the calculated weights
Ensure full code coverage with unit tests

User Story 9: Unit testing for edge cases and boundary values
As a developer, I want to create unit tests that cover edge cases and boundary values for input parameters, so that I can ensure the algorithm can handle these scenarios correctly and provide valid results.

Acceptance Criteria:

Test the SelectItem method with input values at the boundaries of the accepted range (e.g., center percentage of 0 or 1, center height of 0 or 0.95, scaling factor of 0 or 10)
Verify that the algorithm can handle these cases and provide valid results
Ensure full code coverage with unit tests