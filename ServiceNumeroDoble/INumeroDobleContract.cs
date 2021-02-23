using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNumeroDoble
{
    [ServiceContract] //indicamos que forma parte del servicio, la anotacion viene de syste service model
    public interface INumeroDobleContract
    {
        [OperationContract] // los metodos que quiera para el servicio se anotan
        int GetNumeroDoble(int numero);
        [OperationContract]
        String GetSaludo(String nombre);
        String Invisible();
    }
}
