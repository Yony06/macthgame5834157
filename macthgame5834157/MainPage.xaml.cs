namespace macthgame5834157
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            // Lista de emojis de animales en pares.
            List<string> animalEmoji = new List<string>()
            {
                "🐶","🐶",

                "🙈","🙈",

                "😂","😂",

                "😊","😊",

                "😎","😎",

                "👀","👀",

                "💩","💩",

                "🐱‍👤","🐱‍👤",

            };

            // Crear una instancia de la clase Random para generar números aleatorios.
            Random random = new Random();
            foreach (Button view in Grid1.Children)
            {
                // Genera un índice aleatorio dentro del rango de la lista animalEmoji.
                int index = random.Next(animalEmoji.Count);

                string nextEmoji = animalEmoji[index];
                // Asigna el emoji al texto del botón.
                view.Text = nextEmoji;
                //Elimina el emoji
                animalEmoji.RemoveAt(index);
            }
        }

        // Variable para almacenar el último botón clicado.
        Button ultimoButtonClicked;
        // Variable para determinar si se encontró una coincidencia.
        bool encontradoMatch = false;


        private void Button_Clicked(object sender, EventArgs e)
        {
            // Convierte el sender a un objeto Button.
            Button button = sender as Button;
            if (encontradoMatch == false)
            {
                // Hace el botón invisible.
                button.IsVisible = false;

                // Guarda el botón actual como el último botón clicado.
                ultimoButtonClicked = button;

                // Indica que se ha encontrado una coincidencia
                encontradoMatch = true;
            }

            else if (button.Text == ultimoButtonClicked.Text)
            {
                // Si el texto del botón actual coincide con el del último botón clicado, hace el botón invisible.
                button.IsVisible = false;

                // Restablece la variable de coincidencia.
                encontradoMatch = false;
            }

            else
            {
                // Si no coinciden, hace visible nuevamente el último botón clicado.
                ultimoButtonClicked.IsVisible = true;

                // Restablece la variable de coincidencia.
                encontradoMatch = false;
            }
        }

        
    }

}
