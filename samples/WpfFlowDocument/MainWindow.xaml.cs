using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using Tudormobile.WpfExtensions.Documents;

namespace WpfFlowDocument
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            viewer.Document = new FlowDocument()
            {
                Blocks =
                {
                    createTitle("Hello, World!"),
                    createList("One", "Two", "Three").SquareMarker(),
                    new List().Items(["Four", "Five", "Six"]),
                    new Paragraph().Add("Go to jail, go directly to jail. Do not pass go, and do not collect $200.")
                        .Padding(veritcalPadding: 0.5.Inches())
                        .Padding(horizontalPadding: 0.25.Inches())
                        .Border(Brushes.Red).Center(),
                    new Paragraph().AddRange([
                        "This paragraph was added using the AddRange() overload.",
                        "And this one was as well."
                        ]),
                    createTable(),
                }
            }.PageHeight("11.0in").PageWidth(8.5.Inches());

        }

        public static Block createTitle(string title)
        {
            return new Paragraph()
            {
                Inlines =
                {
                    new Run(title),
                },
            };
        }

        public static List createList(params string[] items)
        {
            var l = new List();
            l.ListItems.AddRange(items.Select(x => new ListItem(new Paragraph().Add(x))));
            return l;
        }

        public static Table createTable()
        {
            var result = new Table()
                .AddColumns(4)
                .AddRow(new TableRow().Background(Brushes.AliceBlue)
                                      .Foreground(Brushes.DarkBlue).Bold()
                                      .AddCells(["First Name", "Last Name", "Phone Number", "Birth Date"]));

            var row1 = new TableRow().AddCells(["Joe", "Smith", "(123) 555-1212", "1/1/1960"]);
            var row2 = new TableRow().AddCells(["Jane", "Doe", "(800) 888-1212", "2/3/1960"]); ;

            result.AddRows([row1, row2]);
            return result;
        }
    }
}