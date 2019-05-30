using PersonRepository.Interfaces;
using PersonRepository; 

namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var solucion = new Solucion();
            var validator = new ValidatorTest(); 
            validator.Validate(solucion);
        }
    }
}
