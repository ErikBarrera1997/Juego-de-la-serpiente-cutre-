
namespace Snake.Message
{
    public class Messages 
    {
        public static void getGameOverMessage(Form owner, Boolean flag)
        {
            if (flag) { 
                MessageBox.Show(owner, "¡JAJAJAJAJA!", "Fin de juego.");
                Timer.Control.isDisposable = true;
            }
        }
    }
}
