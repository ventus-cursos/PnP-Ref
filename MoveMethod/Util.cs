using System.Windows.Forms;

namespace Ventus
{
    internal class Util
    {
        /// <summary>
        /// Muestra un MessageBox customizado.
        /// </summary>
        /// <param name="message">El mensaje de error.</param>
        /// <remarks>
        /// El MessageBox está customizado para mostrar errores.
        /// Muestra el icono de Error y un boton OK.
        /// </remarks>
        internal static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static bool Confirm(string message)
        {
            return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   DialogResult.Yes;
        }
    }
}
