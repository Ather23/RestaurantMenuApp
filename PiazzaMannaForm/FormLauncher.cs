namespace PiazzaMannaForm
{
    public partial class FormLauncher : Form
    {
        public FormLauncher()
        {
            InitializeComponent();
            var pizzas = new Pizzas("canva_pizza.png", (int)ScreenNumber.TWO);
            pizzas.Show();

            var hotTables = new HotTables("canva_hot_tables.png", (int)ScreenNumber.ZERO);
            hotTables.Show();

            var salads = new Salads("canva_sandwiches_salads.png", (int)ScreenNumber.THREE);
            salads.Show();

            var breakfast = new Breakfast("canva_breakfast.png", (int)ScreenNumber.ONE);
            breakfast.Show();         
        }
    }
}