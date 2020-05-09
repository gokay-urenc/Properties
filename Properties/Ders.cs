using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Ders
    {
        public string adi { get; set; }
        public string kodu { get; set; }
        public int kredi { get; set; }
    }
}
/* Class üyeleri;
   Field: Sadece değer tutar.
   Method,
   Property(ies): Field ve method karışımıdır.
   Properties, field yerine kullanılan class üyeleridir. Değer saklarlar.
   Properties, class içerisinde bir field'a kontrollü bir şekilde erişim için kullanılır.
*/

// Get ve set komutları o propertynin yazılabilir ve okunabilir olduğunu söyler.
// Property içerisinde set, değer atama anında kullanılır. 
// Get ise propertynin içindeki değer okunacağı zaman kullanılır.