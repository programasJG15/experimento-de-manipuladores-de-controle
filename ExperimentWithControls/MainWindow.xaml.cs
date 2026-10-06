using System.Windows;
using System.Windows.Controls;

namespace ExperimentWithControls
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

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text;
        }

        private void numberTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void readOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readOnlyComboBox.SelectedItem is ComboBoxItem selectedItem)
                number.Text = selectedItem.Content.ToString();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void bigslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = bigslider.Value.ToString("(00)-0000-0000");
        }
        // radio button 1 
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
                number.Text = radioButton.Content.ToString();
            
        }
        // radio button 2 
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
                number.Text = radioButton.Content.ToString();
        }
        // radio button 3
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
                number.Text = radioButton.Content.ToString();
        }
        // radio button 4
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
                number.Text = radioButton.Content.ToString();
        }
        // radio button 5  
        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
                number.Text = radioButton.Content.ToString();
        }
        // radio button 6
        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
                number.Text = radioButton.Content.ToString();
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem is ListBoxItem selectedItem)
                number.Text = selectedItem.Content.ToString();
            
        }

        private void EditableComboBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }

        private void EditableComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
                number.Text = comboBox.Text;
        }
    }
}