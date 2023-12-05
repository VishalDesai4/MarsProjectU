Feature: Profile

As a user I would like to able to Add,Update and Delete languages and Skills
So that the people seeking for skills and languages can look at what details I hold.

@Languages-Add
Scenario Outline: Add Language with valid input details
Given I logged into the MARS Application successfully 
And I navigate to Profile Page Languages tab
When I Add a new Language '<Language>' '<Level>'
Then the language should be added Successfully '<Language>' '<Level>' '<Message>'

Examples: 

| Language                                                                    | Level          | Message                                                                                                      |
| English                                                                     | Basic          | English has been added to your languages                                                                     |
| vhbhd@#$%^dmnshj235426667 jndhjrfnuijn123333vsshhvgbsbjsdbnbnchjdnmncxhdjnm | Conversational | vhbhd@#$%^dmnshj235426667 jndhjrfnuijn123333vsshhvgbsbjsdbnbnchjdnmncxhdjnm has been added to your languages |


@languages-AddExistingData
Scenario Outline: Adding a language that already exists
Given I logged into the MARS Application successfully
And I navigate to Profile Page Languages tab
When I Add a Language that already exists '<Language>' '<Level>'
Then the user should not be added '<errormessage>'

Examples: 
| Language | Level  |  errormessage     |
| English1  | Fluent |This language is already exist in your language list.|

@languages-AddExistingDatawithdifferentlevel
Scenario Outline: Adding a language that already exists with different level
Given I logged into the MARS Application successfully
And I navigate to Profile Page Languages tab
When I Add a Language that already exists with a new level '<Language>' '<Levelold>' '<Levelnew>'
Then the user should not be added '<errormessage>'

Examples: 
| Language | Levelold | Levelnew | errormessage    |
| English1 | Fluent   | Basic    | Duplicated data |


@Languages-AddInvalidData
Scenario Outline: Adding a language with invalid details
Given I logged into the MARS Application successfully
And I navigate to Profile Page Languages tab
When I Add a new Language with invalid input '<Language>' '<Level>'
Then the user should see an error message '<errormessage>'

Examples: 
| Language | Level          | errormessage                    |
|          | Conversational | Please enter language and level |  

@Languages-CancelAdding
Scenario Outline: Cancelling adding Language
Given I logged into the MARS Application successfully
And I navigate to Profile Page Languages tab
When I Cancel Adding a language '<Language>' '<Level>'
Then the Language should not be added '<Language>' '<Level>'

Examples: 
| Language | Level  |
| Sanskrit  | Fluent |


@Languages-Update
Scenario Outline: Update Language with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page Languages tab
And I Add a Language '<Languagenew>' '<Levelnew>'
When I Update the Language '<Language>' '<Level>'
Then the language should be updated successfully '<Language>' '<Level>'

Examples: 

| Languagenew | Levelnew | Language | Level  |
| Mandarin    | Basic | Tamil    | Fluent |

@Languages-Delete
Scenario Outline: Delete added Language
Given I logged into the MARS Application successfully
And I navigate to Profile Page Languages tab
And I Add a new Language '<Language>' '<Level>'
When I Delete the Language
Then the language should be deleted successfully '<PopUpMessage>'

Examples: 
| Language | Level          | PopUpMessage                                 |
| Russian  | Conversational | Russian has been deleted from your languages |

@Skills-Add
Scenario Outline: Add Skills with valid input details
Given I logged into the MARS Application successfully
And I navigate to Profile Page Skills tab
When I Add a new Skill '<Skill>''<Level>'
Then the Skill should be added successfully '<Skill>''<Level>' '<Message>'

Examples: 
| Skill                                   | Level        | Message                                                               |
| Gardening                               | Beginner     | Gardening has been added to your skills                               |
| qw12$%^                                 | Intermediate | qw12$%^ has been added to your skills                                 |
| gsvhsbk 244556256787898 nbhjcdnsldkkjmm | Expert       | gsvhsbk 244556256787898 nbhjcdnsldkkjmm has been added to your skills |

@Skills-AddExistingSkill
Scenario Outline: Adding a Skill that already exists
Given I logged into the MARS Application successfully
And  I navigate to Profile Page Skills tab
When I Add a Skill that already exists '<Skill>' '<Level>'
Then the Skill should not be added '<errormessage>'

Examples: 
| Skill     | Level        | errormessage    |
| Gardening | Intermediate | This skill is already exist in your skill list. |

@Skills-AddExistingDatawithdifferentlevel
Scenario Outline: Adding a Skill that already exists with different level
Given I logged into the MARS Application successfully
And I navigate to Profile Page Skills tab
When I Add a Skill that already exists with a new level '<Skill>' '<LevelOld>' '<LevelNew>'
Then the Skill should not be added '<errormessage>'

Examples: 
| Skill     | LevelOld     | LevelNew | errormessage                                    |
| Gardening1 | Intermediate | Expert   | Duplicated data |

@Skills-AddInvalidData
Scenario Outline: Adding a Skill with invalid details
Given I logged into the MARS Application successfully
And  I navigate to Profile Page Skills tab
When I Add a new Skill with invalid input '<Skill>' '<Level>'
Then the user should see an error message to add Skill '<errormessage>'

Examples: 
| Skill | Level  | errormessage                            |
|       | Expert | Please enter skill and experience level |

@Skills-CancelAdding
Scenario Outline: Cancelling adding Skills
Given I logged into the MARS Application successfully
And  I navigate to Profile Page Skills tab
When I Cancel Adding a Skill '<Skill>' '<Level>'
Then the Skill should not be added '<Skill>' '<Level>'

Examples: 
| Skill     | Level        |
| Tennis    | Intermediate |



@Skills-Update
Scenario Outline: Update Skills with valid input details
Given I logged into the MARS Application successfully
And  I navigate to Profile Page Skills tab
And I Add a Skill '<SkillNew>' '<LevelNew>'
When I Update the Skill '<Skill>' '<Level>'
Then the Skill should be updated successfully '<Skill>' '<Level>'

Examples: 
| SkillNew | LevelNew | Skill     | Level        |
| Dancing  | Expert   | Badminton | Intermediate |

@Skill-Delete
Scenario Outline: Delete added Skill
Given I logged into the MARS Application successfully
And  I navigate to Profile Page Skills tab
And I Add a new Skill '<Skill>' '<Level>'
When I Delete the Skill
Then the Skill should be deleted successfully '<PopUpMessage>'

Examples: 
| Skill    | Level    | PopUpMessage              |
| Swimming | Beginner | Swimming has been deleted |

