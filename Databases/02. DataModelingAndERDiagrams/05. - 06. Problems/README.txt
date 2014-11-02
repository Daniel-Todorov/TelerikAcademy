

GENERAL:

The databse has bee detached. Please, attach it to check the diagram.



EXPLANATIONS:

- We have one main element in the dictionary and that's the WORD. It is stored in a table with ID as primary key and it's text as a column. I assume every word is stored in this table, no matter whether it has the same meaning with another one, as long as they have different languages.
- We have several different languages. They are stored in a table with ID as primary key and name of the language as a column.

- Each language can have many words but one word can have only a single language so the relationship is one to many (implemented with a foreign key constraint).

- The explanations are stored in a table with ID as primary key. They contain text as a column and they can have a single language they are written in - another column with Language ID as foreign key to the Languages table. Also, every explanation belongs to a single word while a single word can have multiple explanations so the relationship is one to many (the Exaplanations table has a column WordID used as part of a foreign key to the WordID column in Words.

- A Synonym is a word from the word table so we don't really need a new table to store them. We know that synonym is paired to another word. We also know that a word can have several synonyms and that a word can be a synonym for several other words so the relationship is many to many. We implement it with a table named WordsSynonyms. The first column of this table contains the ID of the word we try to explain and the second one is the ID of the synonym word. Both of them are part of the foreign key pointing to the ID of the Words table as both of the words are part of that table. We don't need a language ID column there because there is only one language a synonym pair can be created in - the language of the original word.

- The same logic applies to the translation words. The only diffference is that in this case the language of the word-translation pair is the language of the translation word, not the original word.

- Antonym pairs are pairs of words where one word corresponds to another word so the relationship is one to one. It is implemented by a self reference. The AntonymID column in Words points to the WordID of it's antonym. No additional tables are required. It is allowed this column to have a null value as some words may not have antonyms.

- The parts of speech are a set of functions that a word can possess. It is known that a word can have multiple functions. For example, in english the word "mean" can be verb as in "They didn't mean to insult you." and adjective - "He is a very mean person.". That is why the relationship between the functions and the words is many to many (implemented by a third table WordsPartsOfSpeech where the correspondings IDs are foreign keys.

- Hypernyms/hyponyms are also sets of words. One word can be Hyponym for several words and one word can have several hypernyms. The relationship is many to many and follows the logic of the synonyms. It is implemented by the HypernymHyponym table.