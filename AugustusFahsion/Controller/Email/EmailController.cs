using AugustusFahsion.Model;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Email
{
    class EmailController
    {
        private static string ConstruirCorpoEmailRegistroVenda(ClienteModel cliente, VendaModel vendaModel)
        {
            StringBuilder corpoEmail = new StringBuilder($"Olá, {cliente.NomeCompleto.Nome}");
            corpoEmail.AppendLine();
            corpoEmail.AppendLine("Muito obrigado por comprar com a Augustu's Fashion!");
            corpoEmail.AppendLine();
            corpoEmail.AppendLine();
            corpoEmail.Append("Items adiquiridos:");
            corpoEmail.AppendLine();
            corpoEmail = ListaDeItens(vendaModel, corpoEmail);
            corpoEmail.Append($"Total: {vendaModel.TotalLiquido}");
            corpoEmail.AppendLine();
            corpoEmail.AppendLine();
            corpoEmail.Append("Agradecemos a preferência! 🤠👍");

            return corpoEmail.ToString();
        }

        public static StringBuilder ListaDeItens(VendaModel vendaModel, StringBuilder corpoEmail)
        {
            foreach (var item in vendaModel.ListaDeItens)
            {
                corpoEmail.Append($"\t{item.Quantidade}x {item.Nome}: {item.TotalLiquido}");
                corpoEmail.AppendLine();
            }
            return corpoEmail;
        }



        public static void EnviarEmailRegistroVenda(ClienteModel cliente, VendaModel vendaModel)
        {
            string remetente = "augustusfashionstore@gmail.com",
                   senha = "adrvsc123",
                   destinatario = cliente.Contato.Email;

            var corpoEmail = ConstruirCorpoEmailRegistroVenda(cliente, vendaModel);


            MailMessage mensagem = new MailMessage();
            mensagem.To.Add(destinatario);
            mensagem.From = new MailAddress(remetente);
            mensagem.Body = corpoEmail.ToString();
            mensagem.Subject = "Compra realizada: " + vendaModel.IdVenda;

            SmtpClient smtp = new SmtpClient("smtp.gmail.Com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(remetente, senha);

            try
            {
                smtp.Send(mensagem);
                MessageBox.Show("Email enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EnviarEmailAlteracaoVenda(ClienteModel cliente, VendaModel vendaModel)
        {
            string remetente = "augustusfashionstore@gmail.com",
                   senha = "adrvsc123",
                   destinatario = cliente.Contato.Email;


            StringBuilder corpoEmail = new StringBuilder("Muito obrigado por comprar com a Augustu's Fashion!");
            corpoEmail.AppendLine();
            corpoEmail.AppendLine();
            corpoEmail.Append("Items adiquiridos:");
            corpoEmail.AppendLine();
            foreach (var item in vendaModel.ListaDeItens)
            {
                corpoEmail.Append($"\t{item.Quantidade}x {item.Nome}: {item.TotalLiquido}");
                corpoEmail.AppendLine();
            }
            corpoEmail.Append($"Total: {vendaModel.TotalLiquido}");
            corpoEmail.AppendLine();
            corpoEmail.AppendLine();
            corpoEmail.Append("Agradecemos a preferência! 🤠👍");

            MailMessage mensagem = new MailMessage();
            mensagem.To.Add(destinatario);
            mensagem.From = new MailAddress(remetente);
            mensagem.Body = corpoEmail.ToString();
            mensagem.Subject = "Compra realizada: " + vendaModel.IdVenda;

            SmtpClient smtp = new SmtpClient("smtp.gmail.Com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(remetente, senha);

            try
            {
                smtp.Send(mensagem);
                MessageBox.Show("Email enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
