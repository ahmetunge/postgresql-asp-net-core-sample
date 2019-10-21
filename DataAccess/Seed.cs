using System;
using System.Collections.Generic;
using System.Linq;
using EfCoreDatabasesTest.DataAccess.EntityFramework;
using EfCoreDatabasesTest.Models;

namespace EfCoreDatabasesTest.DataAccess
{
    public class Seed
    {

        public static void SeedData(EfCorePostgresContext context)
        {
            Category modernTimes = new Category();
            Category crime = new Category();
            Category scienceFiction = new Category();
            Category adventure = new Category();

            if (!context.Categories.Any())
            {
                modernTimes.Name = "Modern Times";
                context.Categories.Add(modernTimes);

                crime.Name = "Crime";
                context.Categories.Add(crime);

                scienceFiction.Name = "Science Fiction";
                context.Categories.Add(scienceFiction);

                adventure.Name = "Adventure";
                context.Categories.Add(adventure);

            }

            if (!context.Books.Any())
            {
                List<Book> books = new List<Book>{
                    new Book()
                    {
                        Name="The Grass is Always Greener",
                        Summary="This ingenious tale examines the ambitions and petty jealousies of the staff at Critchley's Bank. From the doorman to the personnel manager, to Sir William, the bank's sorrowful chairman. Archer knits a panoply of characters with deft narrative skill in a story which is as revealing as it is observant. Taken from his anthology To Cut a Long Story Short, his other short story anthologies include A Quiver Full of Arrows, Twelve Red Herrings and A Twist in the Tale",
                        Author="Jeffrey Archer",
                        CategoryId=modernTimes.Id
                    },
                    new Book()
                    {
                        Name="Murder",
                        Summary="Two men meet in a seaside resort. What follows is murder. What's discovered isn't all it seems to be... Arnold Bennett was born in 1867. He wrote an influential book column for the Evening Standard from 1926 until his death in London in 1931. He was a great admirer of the French realists and his most successful novels, Clayhanger, Hilda Lessways, and These Twain, set in his native Staffordshire, show the literary influence of Flaubert and Balzac on his work. He also wrote plays and essays, as well as many short stories.",
                        Author="Arnold Bennett",
                         CategoryId=crime.Id
                    },
                    new Book()
                    {
                        Name="The Higgler",
                        Summary="Alfred Edgar Coppard, the son of a Kentish journeyman tailor and a hosteler's daughter, wrote his first short story at the age of 43 and achieved fame in his lifetime, for his vivid depictions of the English countryside and its rural characters. The Higgler, which first appeared in his anthology Fishmonger's Fiddle in 1925, is one of his finest works; a strangely unpredictable tale of an itinerant dealer in poultry and eggs whose emotional involvement with the mother and daughter of an isolated farmhouse on the moors threatens to become an obsession",
                        Author="A. E. Coppard",
                       CategoryId=crime.Id
                    },
                    new Book()
                    {
                        Name="The Diamond as Big as the Ritz",
                        Summary="Scott Fitzgerald's extraordinary fantasy was written in the winter of 1921-1922. John T. Unger, a middle class American boy from a small town on the Mississippi River goes, for his summer holiday, to stay for the first time with an enigmatic school friend, Percy Washington. On the journey out Percy confides with an abrupt remark: 'My father is by far the richest man in the world.The Schnlitzer Murphys had diamonds as big as walnuts - ' 'That's nothing,' Percy had leaned forward and dropped his voice to a low whisper. 'That's nothing at all. My father has a diamond bigger than the Ritz-Carlton Hotel.",
                        Author="F. Scott Fitzgerald",
                        CategoryId=scienceFiction.Id
                    },
                    new Book()
                    {
                        Name="From a View to a Kill",
                        Summary="James Bond is on a mission in France. Ian Fleming, his creator, was a senior naval intelligence officer during World War II, and drew from personal experience in writing his 12 novels and seven short stories featuring the fictional British Secret Service agent, James Bond, 007. Our image of James Bond has been usurped by the world-famous series of films featuring, among others Sean Connery, Roger Moore and Timothy Dalton as Bond. But the real Bond is a far more intriguing character than the films lead us to believe. The spy-thriller, From a View to a Kill, first appeared in Ian Fleming's short story collection For your Eyes Only in 1962.",
                        Author="Ian Fleming",
                         Category=new Category
                        {
                            Id=new Guid(),
                            Name="Adventure"
                        }
                    },


                };

                context.Books.AddRange(books);
                context.SaveChanges();
            }
        }
    }
}