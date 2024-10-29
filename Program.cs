using ESC_POS_USB_NET.Printer;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Printer printer = new Printer("EPSON TM-T(180dpi_1) Receipt6", "IBM860");
printer.TestPrinter();
printer.FullPaperCut();
printer.PrintDocument();

Console.WriteLine("Done");