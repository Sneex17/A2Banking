using CEntidades;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInfraestructura.RecibosServicios
{
    public class ReciboTransferencia : IDocument
    {
        private Bank bank { get; }
        private DataRow[] table { get; }
        public ReciboTransferencia(Bank banco, DataTable data)
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
                    columna.Item().Scale(letra).Text($"Id Transferencia: {table[0]["TransferenciaId"]}")
                    .SemiBold().FontFamily("Times New Roman").FontSize(sizeLetras);

                    columna.Item().Scale(letra).Text($"Dirección: {bank.Direccion}").
                    SemiBold().FontFamily("Times New Roman").FontSize(sizeLetras);
                    columna.Item().Scale(letra).Text("");

                    columna.Item().Scale(letra).Text($"Fecha: {DateTime.Now}").
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
                columna.Item().Text("Transferencia a entidad de cuanta Electronica.")
                .FontFamily("Times New Roman").FontSize(sizeLetras);

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("------------------------------------------------")
                .FontFamily("Times New Roman").FontSize(sizeLetras);

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("DETALLE DEL REMITENTE:").SemiBold().FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Scale(letra).Text("");
                columna.Item().Text($"Cuenta: {table[0]["bancoO"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Número de cuenta: {table[0]["CuentaOrigenId"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Titular: {table[0]["NombreO"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");


                columna.Item().Scale(letra).Text("");
                columna.Item().Text("DETALLE DEL DESTINATARIO:").SemiBold().FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Scale(letra).Text("");
                columna.Item().Text($"Cuenta: {table[0]["bancoD"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Número de cuenta: {table[0]["CuentaDestinoId"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Titular: {table[0]["NombreD"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");

                columna.Item().Scale(letra).Text("");
                columna.Item().Text("VALOR TRANSFERIDO:").SemiBold().FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Monto: {table[0]["Monto"].ToString()}").FontSize(sizeLetras)
                .FontFamily("Times New Roman");
                columna.Item().Text($"Comisión: {table[0]["Comision"].ToString()}").FontSize(sizeLetras)
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
