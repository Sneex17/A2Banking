using CEntidades;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Data;

namespace CInfraestructura.RecibosServicios
{
    public class ReciboDeposito : IDocument
    {
        private Bank bank { get; }
        private DataRow[] table { get; }
        public ReciboDeposito(Bank banco, DataTable data)
        {
            bank = banco;
            table = data.Select();
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(pagina =>
            {
                pagina.Margin(17);
                pagina.Header().Element(GeneralHeader);
                pagina.Content().Element(GeneralCuerpo);
            });
        }

        private void GeneralHeader(IContainer container)
        {
            var letra = 0.9f;
            var sizeLetras = 12;
            container.Row(fila =>
            {
                fila.RelativeItem().Column(columna =>
                {
                    columna.Item().Height(2, Unit.Centimetre).Image(bank.Logo);
                });

                fila.RelativeItem().Column(columna =>
                {
                    columna.Item().Text($"{bank.Nombre}").SemiBold().
                    FontFamily("Montserrat").FontSize(17).FontColor("#4DB6C6");
                });


                fila.RelativeItem().Column(columna =>
                {
                    columna.Item().Scale(letra).Text($"Id Deposito: {table[0]["DepositoId"]}")
                    .SemiBold().FontFamily("Times New Roman").FontSize(sizeLetras);

                    columna.Item().Scale(letra).Text($"Dirección: {bank.Direccion}").
                    SemiBold().FontFamily("Times New Roman").FontSize(sizeLetras);
                    columna.Item().Scale(letra).Text("");

                    columna.Item().Scale(letra).Text($"Fecha: {table[0]["Fecha"]}").
                    FontFamily("Times New Roman").SemiBold().FontSize(sizeLetras);
                });
            });
        }

        private void GeneralCuerpo(IContainer container)
        {
            var letra = 0.9f;
            var sizeLetras = 12;
            container.PaddingVertical(17).Column(columna =>
            {
                columna.Item().Text("Déposito a entidad de cuanta Electronica.")
                .FontFamily("Times New Roman").FontSize(sizeLetras);

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("------------------------------------------------")
                .FontFamily("Times New Roman").FontSize(sizeLetras);

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("DETALLE DEL DÉPOSITO:").SemiBold().FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Scale(letra).Text("");
                columna.Item().Text($"Cuenta: {table[0]["Banco"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Número de cuenta: {table[0]["NumeroCuenta"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Cliente ID: {table[0]["ClienteId"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Nombre: {table[0]["Cliente"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");


                columna.Item().Scale(letra).Text("");
                columna.Item().Text("VALOR DÉPOSITADO:").SemiBold().FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Monto: {table[0]["Monto"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("------------------------------------------------")
                .FontFamily("Times New Roman").FontSize(sizeLetras);

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("El Banco No Reembolsa Dinero\nPara  Reclamación Comuniquese con su Proveedor")
                .FontFamily("Times New Roman").FontSize(sizeLetras);
            });
        }
    }

}
