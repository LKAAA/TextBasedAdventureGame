// See https://aka.ms/new-console-template for more in

namespace TextBasedAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            Room[] roomArray = new Room[15];
            int curRoomNumber = 0;
            bool itemAquired = false;
            bool passageOpened = false;

            //-1 = cant go that way
            //-2 = requires item to go this way (blocked)
            //-3 = Aquire Dynamite
            //any other number = go to that room
            //North, east, south, west (order)
            roomArray[0] = new Room(1, 2, -1, -1);
            roomArray[1] = new Room(4, -1, 0, -1);
            roomArray[2] = new Room(3, -1, -1, 0);
            roomArray[3] = new Room(-2, -1, -1, 4);
            roomArray[4] = new Room(5, 3, 1, -1);
            roomArray[5] = new Room(6, -1, 4, -1);
            roomArray[6] = new Room(-1, 7, 5, -1);
            roomArray[7] = new Room(8, -3, -1, 6);
            roomArray[8] = new Room(9, -1, 7, -1);
            roomArray[9] = new Room(11, 10, 8, -1);
            roomArray[10] = new Room(12, -1, 9, -1);
            roomArray[11] = new Room(-1, -1, -1, -1);
            roomArray[12] = new Room(13, -1, -1, -1);
            roomArray[13] = new Room(14, -1, -1, -1);
            roomArray[14] = new Room(-1, -1, -1, -1);

            roomArray[0].name = "Mine Entrance: \n";
            roomArray[0].description = "The mine's entrance is dimly lit, with wooden support beams and carts left abandoned. The walls glisten with the promise of riches, but the air is heavy with a sense of foreboding.\n" +
                "Glancing behind you towards the \u001b[31msouth\u001b[0m, you see the caved in entrance that collapsed as soon as you walked in. \n"
                + "To the \u001b[32mnorth\u001b[0m you can see a passageway with faint light coming from it. \n"
                + "To the \u001b[32meast\u001b[0m there is a small passageway just big enough for you to fit in.";
            roomArray[1].name = "Goblin's Lair: \n";
            roomArray[1].description = "You are in a large chamber inhabited by a raucous band of goblins. Tattered sleeping mats, crude weapons, and scattered treasure hint at their presence. They eye you with suspicion. \n"
                + "To the \u001b[32mnorth\u001b[0m you can see little twinkling lights flickering out of a passageway. \n"
                + "To the \u001b[32msouth\u001b[0m you can see the mine entrance that you started in.";
            roomArray[2].name = "Steep Passage: \n";
            roomArray[2].description = "The passage slightly widens as you crawl through. \n"
                + "Further on to the \u001b[32mnorth\u001b[0m you can see the straight passage quickly turns into an almost slide like slope. \n"
                + "You could also return to the \u001b[32mwest\u001b[0m.";
            roomArray[3].name = "Collapsed Tunnel: \n";
            roomArray[3].description = " You stand in a small branching tunnel. \n"
                + "The branch to the \u001b[32mnorth\u001b[0m is collapsed and blocked with rubble. You can faintly make out some light through the cracks.\n" 
                + "To the \u001b[31msouth\u001b[0m you can see a steep upward sloping slide like tunnel. You don't think you could climb up that passage. \n"
                + "The branch to the \u001b[32mwest\u001b[0m is twinkling with light.";
            roomArray[4].name = "Crystal Cavern: \n";
            roomArray[4].description = "You are in a breathtaking cavern filled with glowing crystals that illuminate the area with an ethereal light. The walls shimmer with precious gems, but a mysterious aura lingers. \n"
                + "To the \u001b[32mnorth\u001b[0m is a sheer cliff face with a carved stone bridge crossing to the other side. \n"
                + "To the \u001b[32meast\u001b[0m is a dark passageway. \n"
                + "To the \u001b[32msouth\u001b[0m you can make out torchlight and a large cavern.";
            roomArray[5].name = "Chasm Bridge: \n";
            roomArray[5].description = "You stand in the middle of a carved stone bridge. Over the edge is a deep chasm that you can't see the bottom of. \n"
                + "You can either head \u001b[32mnorth\u001b[0m to what looks like a small marketplace with carved stone stalls with brightly colored tent coverings; \n"
                + "Or you can head \u001b[32msouth\u001b[0m towards the crystal filled cavern";
            roomArray[6].name = "Goblin Market: \n";
            roomArray[6].description = "You stand in the midst of a bustling makeshift market set up by the goblins. The noise and haggling fill the air as they try to barter with you, but you don't understand goblinese.\n"
                + "To the \u001b[32meast\u001b[0m is a small passageway that quickly opens up into a larger room. You can make out some boxes and supplies in this room. \n"
                + "To the \u001b[32msouth\u001b[0m is the chiseled stone bridge crossing a chasm.";
            roomArray[7].name = "Storage Room: \n";
            roomArray[7].description = "This room is cluttered with boxes of all different sizes. \n"
                + "To the \u001b[32mnorth\u001b[0m is a long passage that begins to slope down a few feet in. You can't make out the end. \n"
                + "You might be able to find something if you search through some of the boxes to the \u001b[33meast\u001b[0m. \n"
                + "You could also walk back to the marketplace to the \u001b[32mwest\u001b[0m.";
            roomArray[8].name = "Haunted Shaft: \n";
            roomArray[8].description = "You slowly walk through a chilling passage filled with echoes of ghostly miners. The walls are adorned with crude drawings depicting their torment. An otherworldly presence is palpable.\n"
                + "To the \u001b[32mnorth\u001b[0m you can see a large room with a raised platform in the center. You can't quite make out what's on it. \n"
                + "To the \u001b[32msouth\u001b[0m you can return to the cluttered storage room.";
            roomArray[9].name = "Ancient Forge: \n";
            roomArray[9].description = "You stand on a raised platform in the center of a large room. A massive forge surrounded by intricate machinery stands before you. Enchanted anvils and old tools surround you. \n"
                + "To the \u001b[32mnorth\u001b[0m is a small passage that leads into a enourmous cavern. \n"
                + "To the \u001b[32meast\u001b[0m is another long passage but you can't quite make out the end of it, but you can see faint twinkling lights. \n"
                + "You can also return back \u001b[32msouth\u001b[0m, towards the eerie shaft.";
            roomArray[10].name = "Crystal Grotto: \n";
            roomArray[10].description = "You stand in a serene grotto illuminated by massive crystals. The tranquil atmosphere contrasts with the mine's darkness. You can hear a soft melody echoing through the air. \n"
                + "You can either head \u001b[32mnorth\u001b[0m towards another room, \n"
                + "Or you can head \u001b[32msouth\u001b[0m back towards the forge room.";
            roomArray[11].name = "Guardian Chamber: \n";
            roomArray[11].description = "You enter a large chamber. At the far end of it stands a towering stone gargoyle. As you enter the room you hear a loud clang and an iron gate closes behind you. \n"
                + "The gargoyle's eyes flash bright red. Words appear in your mind as if spoken directly into you. \n"
                + "\u001b[33m'Answer my riddle, mortal, and prove your wit to pass.'\u001b[0m \n"
                + "\u001b[33m'I am born in silence, yet I can be deafening. I never move, yet I can travel great distances. What am I?'\u001b[0m \n"
                + "(To continue on you must answer the riddle. If you are stuck and wish for the answer simply type 'help')";
            roomArray[12].name = "Treasure Vault: \n";
            roomArray[12].description = "You enter a room adorned with piles of glittering treasure. Coins, jewels, and artifacts fill the space. You quickly fill your pockets with all the treasure you can. \n"
                + "As soon as you grab the first piece of treasure you hear a click. The door you walked through had closed and locked behind you. \n"
                + "The only way on is \u001b[32mnorth\u001b[0m.";
            roomArray[13].name = "Cursed Altar: \n";
            roomArray[13].description = "An \u001b[95maltar\u001b[0m surrounded by ominous runes stands before you. As you walk in it feels as though your soul is being sucked out of you. \n"
                + "You drop to your knees as a weakness comes over you. Your vision blurs and your mind buzzes with pure noise.\n"
                + "You can faintly make out a passage past the \u001b[95maltar\u001b[0m. Continue on to the \u001b[32mnorth\u001b[0m?";
            roomArray[14].name = "Escape Tunnel: \n";
            roomArray[14].description = "As you make your way down the tunnel you can faintly see daylight at the end of it. \n"
                + "The exit is finally at hand! \n"
                + "\u001b[33mTHE END\u001b[0m."
                + "\n\nThere are two endings. If you wish to find the other, type \u001b[33mRESTART\u001b[0m. \n"
                + "To close the program, type \u001b[33mEXIT\u001b[0m.";

            Console.WriteLine("You slowly come to in the middle of a dark stone room. \n");

            while (userInput != "exit" || userInput != "EXIT")
            {
                Console.WriteLine(roomArray[curRoomNumber].name);
                Console.WriteLine(roomArray[curRoomNumber].description);
                if (curRoomNumber == 11 || curRoomNumber == 14)
                {
                    
                }
                else
                {
                    Console.WriteLine("\nIn which direction would you like to travel?");
                }
               
                userInput = Console.ReadLine();

                Console.Clear();

                if (userInput == "exit" || userInput == "EXIT")
                {
                    break;
                }

                if (userInput == "restart" || userInput == "RESTART")
                {
                    itemAquired = false;
                    passageOpened = false;
                    curRoomNumber = 0;

                    Console.WriteLine("You slowly come to in the middle of a dark stone room. \n");
                }

                if ((userInput == "north" || userInput == "n") && roomArray[curRoomNumber].north > -1)
                {
                    curRoomNumber = roomArray[curRoomNumber].north;
                }
                else if ((userInput == "east" || userInput == "e") && roomArray[curRoomNumber].east > -1)
                {
                    curRoomNumber = roomArray[curRoomNumber].east;
                }
                else if ((userInput == "south" || userInput == "s") && roomArray[curRoomNumber].south > -1)
                {
                    curRoomNumber = roomArray[curRoomNumber].south;
                }
                else if ((userInput == "west" || userInput == "w") && roomArray[curRoomNumber].west > -1)
                {
                    curRoomNumber = roomArray[curRoomNumber].west;
                }
                else if (((userInput == "north" || userInput == "n") && roomArray[curRoomNumber].north == -1) 
                        || ((userInput == "east" || userInput == "e") && roomArray[curRoomNumber].east == -1) 
                        || ((userInput == "south" || userInput == "s") && roomArray[curRoomNumber].south == -1) 
                        || ((userInput == "west" || userInput == "w") && roomArray[curRoomNumber].west == -1))
                {
                    Console.WriteLine("Your path is blocked this way.");
                }
                else if (((userInput == "north" || userInput == "n") && roomArray[curRoomNumber].north == -2)
                        || ((userInput == "east" || userInput == "e") && roomArray[curRoomNumber].east == -2)
                        || ((userInput == "south" || userInput == "s") && roomArray[curRoomNumber].south == -2)
                        || ((userInput == "west" || userInput == "w") && roomArray[curRoomNumber].west == -2))
                {
                    if (itemAquired == true && passageOpened != true)
                    {
                        passageOpened = true;
                        Console.WriteLine("You use the dynamite to break through the rubble that fills the passageway. On the other side of it you see... \n"
                            + "A very, very, very frightened goblin trying to use the bathroom. \n"
                            + "You apologise profously and run back the other way.");
                    }
                    else if (passageOpened == true)
                    {
                        Console.WriteLine("You dare not venture back that way.");
                    }
                    else
                    {
                        Console.WriteLine("Your path is blocked this way. Maybe you could get through if you had something to break through this rubble?");
                    }
                }
                else if (((userInput == "north" || userInput == "n") && roomArray[curRoomNumber].north == -3)
                        || ((userInput == "east" || userInput == "e") && roomArray[curRoomNumber].east == -3)
                        || ((userInput == "south" || userInput == "s") && roomArray[curRoomNumber].south == -3)
                        || ((userInput == "west" || userInput == "w") && roomArray[curRoomNumber].west == -3))
                {
                    itemAquired = true;
                    Console.WriteLine("You notice a large box with multiple sticks of dynamite. You decide to take one. \n"
                        + "Maybe this could help you get through a collapsed passageway?");
                }
                else if (roomArray[curRoomNumber] == roomArray[11] && userInput == "echo" || roomArray[curRoomNumber] == roomArray[11] && userInput == "Echo")
                {
                    Console.WriteLine("More words appear in your head \n" 
                        + "\u001b[33m'You have proven your wit, mortal. You may leave this mine with your mind intact'\u001b[0m \n"
                        + "There is only one way left to travel. \u001b[32mContinue\u001b[0m forward?");
                    Console.ReadLine();
                    Console.Clear();
                    curRoomNumber = 14;
                }
                else if (roomArray[curRoomNumber] == roomArray[11] && userInput == "help")
                {
                    Console.WriteLine("The answer to the golem's riddle is an \u001b[33mecho\u001b[0m. An echo is born in silence when a sound reflects off a surface, and it can be deafening if it reverberates loudly. Despite not physically moving, an echo can travel great distances as sound waves bounce and carry it through the environment.");
                }
                else if(roomArray[curRoomNumber] == roomArray[11])
                {
                    Console.WriteLine("The gargoyle rumbles.\n"
                        + "\u001b[31m'Incorrect'\u001b[0m");
                }
            }
        }
    }
}