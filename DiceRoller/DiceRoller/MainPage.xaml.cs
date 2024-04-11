namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void sort_NumberBtn_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();

            var picker = (Picker)qtd_LadosPicker;

            try
            {
                int selectedIndex = picker.SelectedIndex;

                string pickerValue = Convert.ToString(picker.ItemsSource[selectedIndex]);

                int sortedNumber = random.Next(1, Convert.ToInt32(pickerValue));

                sorted_NumberLabel.Text = Convert.ToString(sortedNumber);
            }
            catch
            {
                sorted_NumberLabel.Text = "Selecione uma opção";
            }

            


        }
    }

}
