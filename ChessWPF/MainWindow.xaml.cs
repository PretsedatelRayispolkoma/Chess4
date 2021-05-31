using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessLibrary;

namespace ChessWPF
{
    public partial class MainWindow : Window
    {
        int x1;
        int y1;

        

        public MainWindow()
        {
            InitializeComponent();
            x1 = 1;
            y1 = 1;
            var desk = new Button[8, 8]
            {
                {b_8a, b_8b, b_8c, b_8d, b_8e, b_8f, b_8g, b_8h },
                {b_7a, b_7b, b_7c, b_7d, b_7e, b_7f, b_7g, b_7h },
                {b_6a, b_6b, b_6c, b_6d, b_6e, b_6f, b_6g, b_6h },
                {b_5a, b_5b, b_5c, b_5d, b_5e, b_5f, b_5g, b_5h },
                {b_4a, b_4b, b_4c, b_4d, b_4e, b_4f, b_4g, b_4h },
                {b_3a, b_3b, b_3c, b_3d, b_3e, b_3f, b_3g, b_3h },
                {b_2a, b_2b, b_2c, b_2d, b_2e, b_2f, b_2g, b_2h },
                {b_1a, b_1b, b_1c, b_1d, b_1e, b_1f, b_1g, b_1h }
            };

            for (int i = 0; i < 8; ++i)
            {
                for(int j = 0; j < 8; ++ j)
                {
                    Button bttn = new Button();
                    bttn.Click
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (pieceSelector.Text)
            {
                case "King":
                    King k = new King(x1, y1);
                    break;
                case "Queen":
                    Queen q = new Queen(x1, y1);
                    break;
                case "Rook":
                    Rook r = new Rook(x1, y1);
                    break;
                case "Bishop":
                    Bishop b = new Bishop(x1, y1);
                    break;
                case "Knight":
                    Knight n = new Knight(x1, y1);
                    break;
            }
        }

        private void _7b_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
