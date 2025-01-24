// The ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
  if (i == 0)
  {
    animalSpecies = "dog";
    animalID = "d1";
    animalAge = "2";
    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
    animalNickname = "lola";
  }
  else if (i == 1)
  {
    animalSpecies = "dog";
    animalID = "d2";
    animalAge = "9";
    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
    animalNickname = "loki";
  }
  else if (i == 2)
  {
    animalSpecies = "cat";
    animalID = "c3";
    animalAge = "1";
    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
    animalPersonalityDescription = "friendly";
    animalNickname = "Puss";
  }
  else if (i == 3)
  {
    animalSpecies = "cat";
    animalID = "c4";
    animalAge = "?";
    animalPhysicalDescription = "";
    animalPersonalityDescription = "";
    animalNickname = "";
  }
  else
  {
    animalSpecies = "";
    animalID = "";
    animalAge = "";
    animalPhysicalDescription = "";
    animalPersonalityDescription = "";
    animalNickname = "";
  }

  ourAnimals[i, 0] = "ID #: " + animalID;
  ourAnimals[i, 1] = "Species: " + animalSpecies;
  ourAnimals[i, 2] = "Age: " + animalAge;
  ourAnimals[i, 3] = "Nickname: " + animalNickname;
  ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
  ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}