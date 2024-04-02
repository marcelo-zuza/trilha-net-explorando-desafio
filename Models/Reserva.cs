namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // IMPLEMENTADO!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // IMPLEMENTADO!
                Console.WriteLine($"Erro, a reserva é para {hospedes.Count} hospedes e nessa suíte só cabem {Suite.Capacidade}\n");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO!
            try 
            {
                return Hospedes.Count;
            }
            catch
            {
                return 0;
            }
            
        }

        public decimal CalcularValorDiaria()
        {
            
            // IMPLEMENTADO!
            decimal valor = DiasReservados * Suite.ValorDiaria;
;

            // IMPLEMENTADO
            if(Hospedes == null){
                valor = 0;
            }
            else{
                
                if (DiasReservados >= 10)
                {
                    valor -= ((valor * 10) / 100);
                }
            }





            return valor;
        }
    }
}