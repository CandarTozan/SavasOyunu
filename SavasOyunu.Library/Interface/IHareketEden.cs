using System.Drawing;
using SavasOyunu.Library.Enum;

namespace SavasOyunu.Library.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }
        
        int HareketMesafesi { get; }

        /// <summary>
        /// Cismi istenilen yönde hareket ettirir.
        /// </summary>
        /// <param name="yon">Hangi yöne hareket edileceği</param>
        /// <returns>Cisim duvara çarparsa True dödürür.</returns>
        bool HareketEttir(Yon yon);
    }
}
