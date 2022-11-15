# Tech-Academy-C-Sharp-Projects
This is the location for all my C# projects as part of The Tech Academy.

## Projects
[TwentyOne/Blackjack Project](General/TwentyOne)

[Car Insurance Project](General/CarInsurance)

[Newsletter App Project](General/NewsletterAppMVC)

### TwentyOne/Blackjack Project
This is a fully functional console application that allows the user to play a game of blackjack. It allows the user to specify the (fictional) amount of money they are bringing to the game, and then proceed to play. All the standard blackjack functionality is present, such as allowing the player to hit or stay, and blackjack being an automatic win for who gets it. There is also custom logic to ensure the dealer must hit if their card total is below a certain number, and must stay if it's above (similar to how the game is usually played). The player is allowed to specify how much money they bet before each hand, and this total will actually flucuate in real-time depending on if the player wins or loses. This is to prevent the player from betting more money then they have.

### Car Insurance Project
This is a basic web application that uses the MVC pattern. It allows users to enter personal information (name, date of birth, amount of speeding tickets, etc.) and, based on this information, automatically calculates a car insurance quote using custom logic. All this information is then stored in a database, and can be viewed through an admin page.

### Newsletter App Project
This is a simple web application that allows users to enter their first name, last name, and email address to sign up to a newsletter. If the request succeeds, the user will be shown a basic "Success" message. This project also utilizes MVC as well as the Entity Framework for accessing a database. The application also has an admin view that allows the user to see all the people who signed up, and manually unsubscribe/remove them, should they wish.
