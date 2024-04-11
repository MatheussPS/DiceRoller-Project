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

                int pickerValue = Convert.ToInt32(picker.ItemsSource[selectedIndex]);

                int sortedNumber = random.Next(1, pickerValue+1);

                sorted_NumberLabel.Text = Convert.ToString(sortedNumber);
            }
            catch
            {
                sorted_NumberLabel.Text = "Selecione uma opção";
            }

            


        }
    }

}
