/*
  # Decision logic challenge
  
  In this challenge, you'll implement decision logic based on a series of business rules. The business rules specify the access that will be granted to users based on their role-based permissions and their career level. 
  
  Code branches will display a different message to the user depending on their permissions and level.

  Your application will be using a combination of permission and level to apply/evaluate the business rules in this challenge scenario. The full list of conditions for business rules is specified in the next step. Your completed solution must use permission and level.

  To sufficiently test all of the combinations for permission and level that are described in the business rules below, you will need to assign additional values to these variables and run the application multiple times.
  
  You will need to use the Contains() helper method to determine whether the value assigned to the permission string contains one of the permission values specified by the "business rules". For example, the expression permission.Contains("Admin") will return true when using the initial data values specified in the code above.

  ## Here are the Business Rules that your solution must satisfy:

  If the user is an Admin with a level greater than 55, output the message:
    Welcome, Super Admin user.

  If the user is an Admin with a level less than or equal to 55, output the message:
    Welcome, Admin user.

  If the user is a Manager with a level 20 or greater, output the message:
    Contact an Admin for access.

  If the user is a Manager with a level less than 20, output the message:
    You do not have sufficient privileges.

  If the user is not an Admin or a Manager, output the message:
    You do not have sufficient privileges.
*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
  if (level > 55)
  {
    Console.WriteLine("Welcome, Super Admin user.");
  }
  else
  {
    Console.WriteLine("Welcome, Admin user.");
  }
}
else if (permission.Contains("Manager"))
{
  if (level >= 20)
  {
    Console.WriteLine("Contact an Admin for access");
  }
  else
  {
    Console.WriteLine("You do not have a sufficient privileges");
  }
}
else
{
  Console.WriteLine("You do not have sufficient privileges.");
}