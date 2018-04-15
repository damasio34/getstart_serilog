using System;

namespace getstart_serilog
{
    public class LogObj
    {
        public LogObj(string local, string mensagem)
        {
            this.Local = local;
            this.Mensagem = mensagem;
            this.DataEHora = DateTimeOffset.Now;
        }

        public DateTimeOffset DataEHora { get; set; }
        public string Local { get; set; }
        public string Mensagem { get; set; }
    }
}
