using System.Windows;
using System.Windows.Controls;

namespace TestExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int turn = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            OneOne.Content = string.Empty;
            OneTwo.Content = string.Empty;
            OneThree.Content = string.Empty;

            TwoOne.Content = string.Empty;
            TwoTwo.Content = string.Empty;
            TwoThree.Content = string.Empty;

            ThreeOne.Content = string.Empty;
            ThreeTwo.Content = string.Empty;
            ThreeThree.Content = string.Empty;

            turn = 1;

            foreach (Button btn in TicTacToe.Children)
            {
                btn.IsEnabled = true;
            }

        }

        public void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void BtnTic_Click(object sender, RoutedEventArgs e)
        {
            var btnClicked = sender as Button;

            btnClicked.IsEnabled = false;

            if (turn % 2 != 0)
            {
                btnClicked.Content = "x";
            }
            else
            {
                btnClicked.Content = "o";
            }

            Check_Win(btnClicked);

            turn++;
        }

        private void Check_Win(Button btn)
        {
            if ((OneOne.Content == btn.Content && OneTwo.Content == btn.Content && OneThree == btn.Content)
                | (TwoOne.Content == btn.Content && TwoTwo.Content == btn.Content && TwoThree.Content == btn.Content)
                | (ThreeOne.Content == btn.Content && ThreeTwo.Content == btn.Content && ThreeThree.Content == btn.Content)
                | (OneOne.Content == btn.Content && TwoOne.Content == btn.Content && ThreeOne.Content == btn.Content)
                | (OneTwo.Content == btn.Content && TwoTwo.Content == btn.Content && ThreeTwo.Content == btn.Content)
                | (OneThree.Content == btn.Content && TwoThree.Content == btn.Content && ThreeThree.Content == btn.Content)
                | (OneOne.Content == btn.Content && TwoTwo.Content == btn.Content && ThreeThree.Content == btn.Content)
                | (OneThree.Content == btn.Content && TwoTwo.Content == btn.Content && ThreeOne.Content == btn.Content))
            {
                MessageBox.Show("Player " + btn.Content + " wins!");
                disablebuttons();
            }
            else
            {
                foreach (Button oBtn in TicTacToe.Children)
                {
                    if (oBtn.IsEnabled == true)
                        return;
                }

                MessageBox.Show("Game over, no winners today!");
            }
        }

        private void disablebuttons()
        {
            foreach (Button btn in TicTacToe.Children)
            {
                btn.IsEnabled = false;
            }
        }
    }
}
