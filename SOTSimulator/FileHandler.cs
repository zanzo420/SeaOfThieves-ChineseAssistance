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
                + "\nUseDelay\n" + aModel.useDelay.ToString() + "\nMouseDistance\n" + aModel.mouseDistance.ToString() + "\nDgKeyStroke\n" + aModel.dgKeyStroke.ToString()
                + "\nSwitchKeyStroke\n" + aModel.switchKeyStroke.ToString() + "\nSwitchDelay\n" + aModel.switchDelay.ToString() + "\nFireKeyStroke\n" + aModel.fireKeyStroke.ToString()
                + "\nAimKeyStroke\n" + aModel.aimKeyStroke.ToString() + "\nAdsDelay\n" + aModel.adsDelay.ToString() + "\nBhopStateKeyStroke\n" + aModel.bhopStateKeyStroke.ToString()
                + "\nCannonToggleKeyStroke\n" + aModel.CannonStateKeyStroke.ToString() + "\nReloadKeyStroke\n" + aModel.reloadKeyStroke.ToString() + "\nReloadDelay\n" + aModel.reloadDelay.ToString()
                + "\nAutoLootToggleKeyStroke\n" + aModel.autoLootKeyStroke.ToString();
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
                        case "DgKeyStroke":
                            line = file.ReadLine();
                            model.dgKeyStroke = Convert.ToInt32(line);
                            break;
                        case "SwitchKeyStroke":
                            line = file.ReadLine();
                            model.switchKeyStroke = Convert.ToInt32(line);
                            break;
                        case "SwitchDelay":
                            line = file.ReadLine();
                            model.switchDelay = Convert.ToInt32(line);
                            break;
                        case "FireKeyStroke":
                            line = file.ReadLine();
                            model.fireKeyStroke = Convert.ToInt32(line);
                            break;
                        case "AimKeyStroke":
                            line = file.ReadLine();
                            model.aimKeyStroke = Convert.ToInt32(line);
                            break;
                        case "AdsDelay":
                            line = file.ReadLine();
                            model.adsDelay = Convert.ToInt32(line);
                            break;
                        case "BhopStateKeyStroke":
                            line = file.ReadLine();
                            model.bhopStateKeyStroke = Convert.ToInt32(line);
                            break;
                        case "ReloadDelay":
                            line = file.ReadLine();
                            model.reloadDelay = Convert.ToInt32(line);
                            break;
                        case "ReloadKeyStroke":
                            line = file.ReadLine();
                            model.reloadKeyStroke = Convert.ToInt32(line);
                            break;
                        case "CannonToggleKeyStroke":
                            line = file.ReadLine();
                            model.CannonStateKeyStroke = Convert.ToInt32(line);
                            break;
                        case "AutoLootToggleKeyStroke":
                            line = file.ReadLine();
                            model.autoLootKeyStroke = Convert.ToInt32(line);
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
