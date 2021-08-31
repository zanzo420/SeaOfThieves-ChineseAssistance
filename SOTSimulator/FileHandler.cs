using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOTSimulator
{
    public static class FileHandler
    {
        public static async void WriteToFile(Model aModel)
        {
            string text =
                "ListenFrequency\n" + aModel.listenFrequency.ToString() + "\nKeyStroke\n" + aModel.keyStroke.ToString() +
                "\nBlockDelay\n" + aModel.blockDelay.ToString() + "\nJumpDelay\n" + aModel.jumpDelay.ToString() + "\nMoveKeyStroke\n" + aModel.moveKeyStroke.ToString()
                + "\nDropKeyStroke\n" + aModel.dropKeyStroke.ToString() + "\nSprintKeyStroke\n" + aModel.sprintKeyStroke.ToString() + "\nUseKeyStroke\n" + aModel.useKeyStroke.ToString()
                + "\nDropDelay\n" + aModel.dropDelay.ToString() + "\nMouseSpeed\n" + aModel.mouseSpeed.ToString() + "\nRunDelay\n" + aModel.runDelay.ToString()
                + "\nUseDelay\n" + aModel.useDelay.ToString() + "\nMouseDistance\n" + aModel.mouseDistance.ToString();
            await File.WriteAllTextAsync("Settings.txt", text);
        }

        public static Model ReadFromFile()
        {
            Model model = new Model();
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("Settings.txt");
                while ((line = file.ReadLine()) != null)
                {
                    switch (line)
                    {
                        case "ListenFrequency":
                            line = file.ReadLine();
                            model.listenFrequency = Convert.ToInt32(line);
                            break;
                        case "KeyStroke":
                            line = file.ReadLine();
                            model.keyStroke = Convert.ToInt32(line);
                            break;
                        case "BlockDelay":
                            line = file.ReadLine();
                            model.blockDelay = Convert.ToInt32(line);
                            break;
                        case "JumpDelay":
                            line = file.ReadLine();
                            model.jumpDelay = Convert.ToInt32(line);
                            break;
                        case "MoveKeyStroke":
                            line = file.ReadLine();
                            model.moveKeyStroke = Convert.ToInt32(line);
                            break;
                        case "DropKeyStroke":
                            line = file.ReadLine();
                            model.dropKeyStroke = Convert.ToInt32(line);
                            break;
                        case "SprintKeyStroke":
                            line = file.ReadLine();
                            model.sprintKeyStroke = Convert.ToInt32(line);
                            break;
                        case "UseKeyStroke":
                            line = file.ReadLine();
                            model.useKeyStroke = Convert.ToInt32(line);
                            break;
                        case "DropDelay":
                            line = file.ReadLine();
                            model.dropDelay = Convert.ToInt32(line);
                            break;
                        case "MouseSpeed":
                            line = file.ReadLine();
                            model.mouseSpeed = Convert.ToInt32(line);
                            break;
                        case "RunDelay":
                            line = file.ReadLine();
                            model.runDelay = Convert.ToInt32(line);
                            break;
                        case "UseDelay":
                            line = file.ReadLine();
                            model.useDelay = Convert.ToInt32(line);
                            break;
                        case "MouseDistance":
                            line = file.ReadLine();
                            model.mouseDistance = Convert.ToInt32(line);
                            break;
                        default:
                            continue;
                    }
                }
                file.Close();
                return model;
            }
            catch
            {
                return model;
            }
        }
    }
}
