using System;
using System.Collections.Generic;

namespace CommandPatternExample
{
    // ==== Command base ====

    public interface ICommand
    {
        string Name { get; }
        void Execute();
    }

    /// <summary>
    /// Comando base che lavora su file.
    /// InputFilePath = file su cui il comando lavora,
    /// OutputFilePath = "risultato" del comando (se esiste).
    /// </summary>
    public abstract class FileCommand : ICommand
    {
        public string InputFilePath { get; }
        public string OutputFilePath { get; protected set; }

        public abstract string Name { get; }

        protected FileCommand(string inputFilePath)
        {
            InputFilePath = inputFilePath;
        }

        public abstract void Execute();
    }

    // ==== Concrete Commands ====

    public class RemoveSignatureCommand : FileCommand
    {
        public override string Name => "RemoveSignature";

        public RemoveSignatureCommand(string inputFilePath)
            : base(inputFilePath)
        {
        }

        public async override void Execute()
        {
            Console.WriteLine($"[RemoveSignatureCommand] Inizio rimozione firma dal file: {InputFilePath}");

            // Simulo la lettura del file
            Console.WriteLine($"[RemoveSignatureCommand] Leggo il contenuto di {InputFilePath}...");

            // Simulo la rimozione della firma digitale
            // Per esempio: documento.pdf.p7m -> documento.pdf
            var unsignedFile = InputFilePath.Replace(".p7m", "");
            OutputFilePath = unsignedFile;

            Console.WriteLine($"[RemoveSignatureCommand] Firma rimossa. Nuovo file: {OutputFilePath}");
            Console.WriteLine($"[RemoveSignatureCommand] Comando completato.\n");
        }
    }

    public class UnzipFileCommand : FileCommand
    {
        public override string Name => "UnzipFile";

        public UnzipFileCommand(string inputFilePath)
            : base(inputFilePath)
        {
        }

        public async override void Execute()
        {
            Console.WriteLine($"[UnzipFileCommand] Inizio estrazione del file: {InputFilePath}");

            // Simulo l'unzip
            // Esempio: documento.zip -> contenuto in una cartella
            var extractedFolder = InputFilePath + "_unzipped";
            OutputFilePath = extractedFolder;

            Console.WriteLine($"[UnzipFileCommand] File estratto nella cartella: {OutputFilePath}");
            Console.WriteLine($"[UnzipFileCommand] Comando completato.\n");
        }
    }

    // ==== Event args per evento di completamento comando ====

    public class CommandCompletedEventArgs : EventArgs
    {
        public string CommandName { get; }
        public string FilePath { get; }

        public CommandCompletedEventArgs(string commandName, string filePath)
        {
            CommandName = commandName;
            FilePath = filePath;
        }
    }

    // ==== Invoker ====

    public class Invoker
    {
        private readonly Queue<ICommand> _commands = new Queue<ICommand>();

        // Evento sollevato al termine di ogni comando
        public event EventHandler<CommandCompletedEventArgs> CommandCompleted;

        public void EnqueueCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public void ProcessFolder(string folderPath)
        {
            Console.WriteLine($"[Invoker] Ricevuto path della cartella: {folderPath}");
            Console.WriteLine("[Invoker] Simulo lettura dei file nella cartella...");

            // Simulazione dei file trovati nella cartella
            var fakeFiles = new[]
            {
                System.IO.Path.Combine(folderPath, "documento1.pdf.p7m"),
                System.IO.Path.Combine(folderPath, "documento2.pdf.p7m"),
                System.IO.Path.Combine(folderPath, "documento3.pdf.p7m")
            };

            foreach (var file in fakeFiles)
            {
                Console.WriteLine($"[Invoker] Trovato file: {file}. Creo RemoveSignatureCommand.");
                var cmd = new RemoveSignatureCommand(file);
                EnqueueCommand(cmd);
            }

            Console.WriteLine("[Invoker] Inizio esecuzione dei comandi in coda...\n");
            ExecuteAll();
        }

        private void ExecuteAll()
        {
            while (_commands.Count > 0)
            {
                var cmd = _commands.Dequeue();
                Console.WriteLine($"[Invoker] Eseguo comando: {cmd.Name}");

                cmd.Execute();

                string? filePathForEvent = null;

                // Se è un FileCommand, recupero il file risultante
                if (cmd is FileCommand fileCommand)
                {
                    // Se il comando ha prodotto un OutputFilePath, uso quello,
                    // altrimenti uso l'InputFilePath
                    filePathForEvent = fileCommand.OutputFilePath ?? fileCommand.InputFilePath;
                }

                OnCommandCompleted(cmd.Name, filePathForEvent);
            }

            Console.WriteLine("[Invoker] Tutti i comandi in coda sono stati eseguiti.\n");
        }

        protected virtual void OnCommandCompleted(string commandName, string filePath)
        {
            Console.WriteLine($"[Invoker] Evento CommandCompleted per comando '{commandName}' sul file '{filePath}'.");
            CommandCompleted?.Invoke(this, new CommandCompletedEventArgs(commandName, filePath));
        }
    }

    // ==== Program (client) ====

    internal class Program
    {
        private static void Main(string[] args)
        {
            var invoker = new Invoker();

            // Mi aggancio all'evento CommandCompleted dell'Invoker
            invoker.CommandCompleted += (sender, e) =>
            {
                // Quando finisce RemoveSignatureCommand,
                // aggiungo un nuovo comando UnzipFileCommand per quel file
                if (e.CommandName == "RemoveSignature")
                {
                    Console.WriteLine($"[EventHandler] Ricevuto evento di completamento di '{e.CommandName}' per file: {e.FilePath}");
                    Console.WriteLine("[EventHandler] Aggiungo UnzipFileCommand alla coda dell'Invoker.\n");

                    var inv = (Invoker)sender;
                    inv.EnqueueCommand(new UnzipFileCommand(e.FilePath));
                }
            };

            // Simulo input dell'utente: path di una cartella
            string folderPath = @"C:\CartellaDocumentiFirmati";
            invoker.ProcessFolder(folderPath);

            // [UnzipFileCommand1, ]

            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}