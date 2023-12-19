Feature: Login

@login
Scenario Outline: Customer login with valid password
    Given Customer with details:<Name>,<Password>
    When I fill user's name input 
    And I fill user password input
    And I submit the form
    Then Message should be "Epic sadface: Sorry, this user has been locked out."

    Examples: 
    | Name            | Password      |
    | locked_out_user | secret_sauce  |

@loginError
Scenario Outline: Customer login with wrong password
    Given Customer with details:<Name>,<Password>
    When I fill user's name input 
    And I fill user password input
    And I submit the form
    Then Message should be "Epic sadface: Username and password do not match any user in this service"

    Examples: 
    | Name            | Password        |
    | locked_out_user | secret_sauce124 |

@loginError
Scenario Outline: Customer login with empty password
    Given Customer with details:<Name>,<Password>
    When I fill user's name input 
    And I fill user password input
    And I submit the form
    Then Message should be "Epic sadface: Password is required"

    Examples: 
    | Name            | Password |
    | locked_out_user |          |




