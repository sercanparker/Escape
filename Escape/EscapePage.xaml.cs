using System;
using Escape.Utilities;
using Xamarin.Forms;

namespace Escape
{
    public partial class EscapePage : ContentPage
    {
        private RandomGenerator randomGenerator;

        public EscapePage()
        {
            InitializeComponent();

            randomGenerator = new RandomGenerator();

            GenerateGrid();
        }

        public void GenerateGrid(){

            int sizeOfGrid = randomGenerator.GenerateGridSize();

            Grid grid = new Grid();

            for (int indexRow = 0; indexRow < sizeOfGrid; indexRow++)
            {
                grid.RowDefinitions.Add(GenerateRowDefinition());


            }

            for (int indexColumn = 0; indexColumn < sizeOfGrid; indexColumn++)
            {
                grid.ColumnDefinitions.Add(GenerateColumnDefinition());

            }

            for (int indexRow = 0; indexRow < sizeOfGrid; indexRow++)
            {
                for (int indexColumn = 0; indexColumn < sizeOfGrid; indexColumn++)
                {
                    Color randomColor = randomGenerator.GenerateColor();
                    StackLayout layout = new StackLayout
                    {
                        BackgroundColor = randomColor,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    };
                    grid.Children.Add(layout, indexRow,indexColumn);

                    if (indexRow == sizeOfGrid - 1 && indexColumn == sizeOfGrid -1)
                    {
                        Button randomGeneratorButton = new Button()
                        {
                            Text = "G",
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        };

                        randomGeneratorButton.Clicked += OnRandomGeneratorButtonClicked;

                        layout.Children.Add(randomGeneratorButton);
                    }

                }
            }


            Content = grid;

        }

        public RowDefinition GenerateRowDefinition(){
            
            RowDefinition rowDefinition = new RowDefinition();

            rowDefinition.Height = GridLength.Star;

            return rowDefinition;

        }

        public ColumnDefinition GenerateColumnDefinition(){

            ColumnDefinition columnDefinition = new ColumnDefinition();
            columnDefinition.Width = GridLength.Star;

            return columnDefinition;
        }

        void OnRandomGeneratorButtonClicked(object sender, EventArgs e)
        {
            GenerateGrid();
        }

    }
}
