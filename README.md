# PatternsProject
Description inside README.

Requirements and Functional description:

This application stands as an "info point" for a video game player who wants to create a new character in this particular game.

A character in this game is built after the following structure:
	- specialization
	- talents
	- abilities & spells

So, when creating a character a specific specialization must be chosen. There wll be 3 types of specializations: Paladin, Mage, Warrior.

A character created with 1 type of specialization will have to choose a specific talent for the corresponding specialization. There are 2
types of talents for each specialization. 

Each talent comes with a set of spells and/or abilities. These spells and abilities make the character benefit of different boosts, action
in a special way, etc...

The application will allow the user to select one of the 3 specializations mentioned above and will return every information related to that
specific specialization: which talents can be learnt by that specialization and information about the spells and abilities coming with that talent.

Talents	 |	 Talent 1	|Talent 2
------------------------------------------
Paladin	 |	Retribution	| Holy
Warrior	 |	   Arms		|  Fury
Mage	 |	   Frost	|  Fire


"Spells &
 Abilities"|		Paladin		   |	        Warrior		     |            Mage	           |
------------------------------------------------------------------------------------------------------------
Talents	   |	Retribution  |	   Holy    |     Arms	    |	Fury	     |	 Frost	     |     Fire    |
------------------------------------------------------------------------------------------------------------
1	   |      Attack     |	Minor Heal |	Attack	    |   Attack	     |	Frostbolt    |	Fire Ball  |
2	   |	  Boost      |  Major Heal |   Brutal Attack|	Throw Weapon |	Ice rain     |	Incinerate |
3	   |	  Heal	     |		   |	Windwhirl   |	Charge	     |   Boost	     |             |

----------------------------------------------------------------------------

The application is going to be built based on 2 design patterns: 
	- Adapter
	- Facade
The Adapter pattern is used for granting access to the method which returns the information related to each talent and spell and ability.
Every type of specialization (Paladin, Warrior, Mage) will represent an object. Depending on the object, a specific method from the adaptor
class will be called. With this method, all the information related to the object will be released in the console for the user.

The Facade pattern is used in order to centralize the information given by the methods implemented inside the spells and abilities classes.
By centralizing all this information inside the Facade classes it will be easier for the client class (the Specialization class) to access
all the data required by the object selected by the user.

