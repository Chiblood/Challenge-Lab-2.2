/* Challenge Lab 2.2
2. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
*/

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        const int maxAttempts = 3;
        const string correctUserId = "admin";
        const string correctPassword = "password";

        while (attempts < maxAttempts)
        {
            Console.Write("Enter User ID: ");
            string? userId = Console.ReadLine();

            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();

            if (userId == correctUserId && password == correctPassword)
            {
                Console.WriteLine("Access Granted.");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Incorrect User ID or Password. You have {maxAttempts - attempts} attempts left.");
            }
        }
        Console.WriteLine("Access Denied. Maximum number of attempts reached.");
    }
}

// This particular exercise is terrible for user validation. UserId and Password should never be hardcoded in a real application. Let another identity provider handle that.
// In our case Microsoft Intranet or Google OAuth or something similar.