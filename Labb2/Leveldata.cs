﻿

class LevelData : LevelElement
{
    private List<LevelElement> elements = new List<LevelElement>();
    public List<LevelElement> Elements 
    {
        get { return elements; }
    }
    public void Load(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            using (StreamReader lenghtOfLineReader = new StreamReader(fileName))// To counts the lenght of line to not hardcode the Jforloop
            {
                while (!reader.EndOfStream)
                {
                    for (int i = 0; i <= 18; i++) // Find a way to count rows
                    {
                        string lenghtOfLine = lenghtOfLineReader.ReadLine();
                        if (lenghtOfLine == null) lenghtOfLine = "";
                        for (int j = 0; j < lenghtOfLine.Length; j++)
                        {
                            var currentChar = reader.Read();
                            if (currentChar == 35) // #
                            {
                                elements.Add(new Wall(j, i));
                            }
                            else if (currentChar == 114) // r
                            {
                                elements.Add(new Rat(j, i));
                            }
                            else if (currentChar == 115) // s
                            {
                                elements.Add(new Snake(j, i));
                            }
                            else if (currentChar == 64) // @
                            {
                                elements.Add(new Player(j, i));
                            }
                        }
                        reader.ReadLine();
                    }
                }
            }                        
        }
    }

    public void DrawFromList()
    {
        foreach (var entity in elements)
        {
            Draw(entity);
        }
    }
}
