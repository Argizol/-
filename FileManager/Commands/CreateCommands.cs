using FileManager.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Commands
{
    internal class CreateCommand : FileManagerCommand
    {
        private readonly IUserInterface _UserInterface;
        private readonly FileManagerLogic _FileManager;
        public override string Description => "Для создания файла введите cr path\\filename.extension\n" +
                                              "Для создания каталога введите cr path\\directoryname";
        public CreateCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
        {
            _UserInterface = UserInterface;
            _FileManager = FileManager;
        }

        public override void Execute(string[] args)
        {
            if (args.Length > 1 && !File.Exists(args[1]))
            {
                File.Create(args[1]);
            }
            else if (args.Length > 1 && !Directory.Exists(args[1]))
            {
                Directory.CreateDirectory(args[1]);
            }
        }
    }
}
