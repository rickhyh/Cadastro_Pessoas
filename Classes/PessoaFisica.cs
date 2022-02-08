using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }



/*        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

                return false;

        }
*/
       public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)) //tenta converter a data de nasc (string) e exibe a saída resultado
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    Console.WriteLine($"\nData de Nascimento: {dataConvertida}");
                    return true;
                }
                Console.WriteLine(@$"
                Data de Nascimento: {dataConvertida}
                ");
                return false;
            }

            return false;
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}