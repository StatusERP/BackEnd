using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class CategoriaArticuloConfiguration: IEntityTypeConfiguration<CategoriaArticulo>
    {
        public void Configure(EntityTypeBuilder<CategoriaArticulo> builder)
        {
           builder.HasOne(x => x.CCInventario)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaInventarioId);

            builder
                .HasOne(x => x.CCVentasLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasLocId);

           builder
                .HasOne(x => x.CCVentasExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasExpId);

            builder
               .HasOne(x => x.CCCompraLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCompraLocId);

            builder
               .HasOne(x => x.CCCompraImp)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCompraImpId);

            builder
               .HasOne(x => x.CCDescVentaLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaDescVentaLocId);

            builder
               .HasOne(x => x.CCDescVentaExp)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaDescVentaExpId);

            builder
               .HasOne(x => x.CCCostVentaLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCostVentaLocId);

            builder
               .HasOne(x => x.CCCostVentaLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCostVentaLocId);

            builder
                .HasOne(x => x.CCCostVentaExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCostVentaExpId);

            builder
                .HasOne(x => x.CCComsVentaLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsVentaLocId);

            builder
                .HasOne(x => x.CCComsVentaExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsVentaExpId);

           builder
                .HasOne(x => x.CCComsCobroLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsCobroLocId);

           builder
                .HasOne(x => x.CCComsCobroExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsCobroExpId);

            builder
                .HasOne(x => x.CCDescLineaLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescLineaLocId);

            builder
                .HasOne(x => x.CCDescLineaExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescLineaExpId);

            builder
                .HasOne(x => x.CCCostoDescLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCostDescLocId);

            builder
                .HasOne(x => x.CCCostDescExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCostDescExpId);

            builder
                .HasOne(x => x.CCSobrInventFis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaSobrInventFisId);

          builder
                .HasOne(x => x.CCFaltInventFis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaFaltInventFisId);

          builder
                .HasOne(x => x.CCVariaCosto)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVariaCostoId);

          builder
                .HasOne(x => x.CCVencimiento)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVencimientoId);

          builder
                .HasOne(x => x.CCSobranteRemis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaSobranteRemisId);

          builder
                .HasOne(x => x.CCFaltanteRemis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaFaltanteRemisId);

          builder
                .HasOne(x => x.CCInvRemitido)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaInvRemitidoId);

          builder
                .HasOne(x => x.CCMatProceso)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaMatProcesoId);

          builder
                .HasOne(x => x.CCConsNormal)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsNormalId);

          builder
                .HasOne(x => x.CCConsRetrabajo)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsRetrabajoId);

          builder
                .HasOne(x => x.CCConsGasto)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsGastoId);

          builder
                .HasOne(x => x.CCConsDesperdic)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsDesperdicId);

          builder
                .HasOne(x => x.CCDescBonifLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescBonifLocId);

          builder
                .HasOne(x => x.CCDescBonifExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescBonifExpId);

          builder
                .HasOne(x => x.CCDevVentasLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDevVentasLocId);

          builder
                .HasOne(x => x.CCDevVentasExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDevVentasExpId);

          builder
                .HasOne(x => x.CCRetAsum)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaRetAsumId);

          builder
                .HasOne(x => x.CCAju)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaAjuId);

          builder
                .HasOne(x => x.CCAjuCMV)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaAjuCMVId);

          builder
                .HasOne(x => x.CCCPGar)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCPGarId);

          builder
                .HasOne(x => x.CCPuGar)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaPuGarId);

          builder
                .HasOne(x => x.CCIngDevoluc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaIngDevolucId);

          builder
                .HasOne(x => x.CCPerdDevoluc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaPerdDevolucId);

          builder
                .HasOne(x => x.CCMatAplicados)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaMatAplicadosId);

          builder
                .HasOne(x => x.CCVentasExenLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasExenLocId);

          builder
                .HasOne(x => x.CCVentasExenExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasExenExpId);





        }
    }
}
