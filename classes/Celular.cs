namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string modelo;
        public string cor;
        public float tamanho;
        public bool status;

        
        public bool Estado(bool status)
        {
            bool estado;
            if(status == true){
                estado = this.status;
            }else{
                estado = this.status;
            }

            return estado;
        }

        // public string Chamada(){

        // }
    }

}