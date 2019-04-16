using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JaraToGam.Models
{
    public partial class GamContext : DbContext
    {
        public GamContext()
        {
        }

        public GamContext(DbContextOptions<GamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Srv> Srv { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//               
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Srv>(entity =>
            {
                entity.HasKey(e => e.NumSrv)
                    .HasName("PK__SRV__0D7A0286");

                entity.ToTable("SRV");

                entity.HasIndex(e => e.CodiDirFinal)
                    .HasName("CODI_DIR_INICI");

                entity.HasIndex(e => e.CodiEmp)
                    .HasName("CODI_EMP");

                entity.HasIndex(e => e.CodiExtern)
                    .HasName("CODI_EXTERN");

                entity.HasIndex(e => e.CodiLot)
                    .HasName("CODI_LOT");

                entity.HasIndex(e => e.CodiPac)
                    .HasName("CODI_PAC");

                entity.HasIndex(e => e.CodiPrg)
                    .HasName("CODI_PRG");

                entity.HasIndex(e => e.CodiVhi)
                    .HasName("CODI_VHI");

                entity.HasIndex(e => e.Cognoms)
                    .HasName("COGNOMS");

                entity.HasIndex(e => e.DataActivacio)
                    .HasName("DATA_ACTIVACIO");

                entity.HasIndex(e => e.DataFinalSrv)
                    .HasName("DATA_FINA_SRV");

                entity.HasIndex(e => e.DataIniciSrv)
                    .HasName("DATA_INICI_SRV");

                entity.HasIndex(e => e.DataLloc)
                    .HasName("DATA_LLOC");

                entity.HasIndex(e => e.DataRecepcio)
                    .HasName("DATA_RECEPCIO");

                entity.HasIndex(e => e.Estat)
                    .HasName("ESTAT");

                entity.HasIndex(e => e.ImpDesti)
                    .HasName("IMP_DESTI");

                entity.HasIndex(e => e.InternetEstat)
                    .HasName("INTERNET_ESTAT");

                entity.HasIndex(e => e.InternetSiNo)
                    .HasName("INTERNET_SI_NO");

                entity.HasIndex(e => e.Km)
                    .HasName("KM");

                entity.HasIndex(e => e.KmReal)
                    .HasName("KM_REAL");

                entity.HasIndex(e => e.LinDsk)
                    .HasName("LIN_DSK");

                entity.HasIndex(e => e.Nom)
                    .HasName("NOM");

                entity.HasIndex(e => e.NumIntern)
                    .HasName("NUM_INTERN");

                entity.HasIndex(e => e.PobFinal)
                    .HasName("POB_FINAL");

                entity.HasIndex(e => e.PobInici)
                    .HasName("POB_INICI");

                entity.HasIndex(e => e.Referencia)
                    .HasName("REFERENCIA");

                entity.HasIndex(e => e.Subestat)
                    .HasName("SUBESTAT");

                entity.HasIndex(e => e.TipusSrv)
                    .HasName("TIPUS_SRV");

                entity.HasIndex(e => e.XFinal)
                    .HasName("X_FINAL");

                entity.HasIndex(e => e.XInici)
                    .HasName("X_INICI");

                entity.HasIndex(e => new { e.Estat, e.CodiEmp })
                    .HasName("COMBINACIO_3");

                entity.HasIndex(e => new { e.InternetSiNo, e.InternetEstat })
                    .HasName("COMBINACIO_4");

                entity.HasIndex(e => new { e.Estat, e.InternetSiNo, e.InternetEstat, e.EsTornadaSiNo })
                    .HasName("COMBINACIO_2");

                entity.HasIndex(e => new { e.Estat, e.DataIniciSrv, e.TipusSrv, e.CodiLot, e.CodiEmp })
                    .HasName("COMBIBACIO_1");

                entity.Property(e => e.NumSrv)
                    .HasColumnName("NUM_SRV")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AcompanyantSiNo)
                    .HasColumnName("ACOMPANYANT_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AdjudicacioAutomaticaSiNo)
                    .HasColumnName("ADJUDICACIO_AUTOMATICA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AeroportSiNo)
                    .HasColumnName("AEROPORT_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AjudaSiNo)
                    .HasColumnName("AJUDA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.AutomaticSiNo)
                    .HasColumnName("AUTOMATIC_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Bloc)
                    .HasColumnName("BLOC")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CadiraRodesSiNo)
                    .HasColumnName("CADIRA_RODES_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CadiraTransportSiNo)
                    .HasColumnName("CADIRA_TRANSPORT_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CamillaSiNo)
                    .HasColumnName("CAMILLA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Caracter98)
                    .IsRequired()
                    .HasColumnName("CARACTER_98")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Caracter99)
                    .IsRequired()
                    .HasColumnName("CARACTER_99")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cip)
                    .IsRequired()
                    .HasColumnName("CIP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codi98)
                    .IsRequired()
                    .HasColumnName("CODI_98")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codi99)
                    .IsRequired()
                    .HasColumnName("CODI_99")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAer)
                    .IsRequired()
                    .HasColumnName("CODI_AER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAju)
                    .IsRequired()
                    .HasColumnName("CODI_AJU")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAnu)
                    .IsRequired()
                    .HasColumnName("CODI_ANU")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAnu1)
                    .IsRequired()
                    .HasColumnName("CODI_ANU_1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAnu2)
                    .IsRequired()
                    .HasColumnName("CODI_ANU_2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAnu3)
                    .IsRequired()
                    .HasColumnName("CODI_ANU_3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiAnu4)
                    .IsRequired()
                    .HasColumnName("CODI_ANU_4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiBasDir)
                    .IsRequired()
                    .HasColumnName("CODI_BAS_DIR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiBasDst)
                    .IsRequired()
                    .HasColumnName("CODI_BAS_DST")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiBasVhi)
                    .IsRequired()
                    .HasColumnName("CODI_BAS_VHI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiDep)
                    .IsRequired()
                    .HasColumnName("CODI_DEP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiDiari)
                    .IsRequired()
                    .HasColumnName("CODI_DIARI")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiDig)
                    .IsRequired()
                    .HasColumnName("CODI_DIG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiDirFinal)
                    .IsRequired()
                    .HasColumnName("CODI_DIR_FINAL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiDirInici)
                    .IsRequired()
                    .HasColumnName("CODI_DIR_INICI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiDst)
                    .IsRequired()
                    .HasColumnName("CODI_DST")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiEmp)
                    .IsRequired()
                    .HasColumnName("CODI_EMP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiEmpFct)
                    .IsRequired()
                    .HasColumnName("CODI_EMP_FCT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiEnf)
                    .IsRequired()
                    .HasColumnName("CODI_ENF")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiExt1)
                    .IsRequired()
                    .HasColumnName("CODI_EXT_1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiExt2)
                    .IsRequired()
                    .HasColumnName("CODI_EXT_2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiExt3)
                    .IsRequired()
                    .HasColumnName("CODI_EXT_3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiExt4)
                    .IsRequired()
                    .HasColumnName("CODI_EXT_4")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiExt5)
                    .IsRequired()
                    .HasColumnName("CODI_EXT_5")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiExtern)
                    .IsRequired()
                    .HasColumnName("CODI_EXTERN")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiLot)
                    .IsRequired()
                    .HasColumnName("CODI_LOT")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiMet)
                    .IsRequired()
                    .HasColumnName("CODI_MET")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPac)
                    .IsRequired()
                    .HasColumnName("CODI_PAC")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPat1)
                    .IsRequired()
                    .HasColumnName("CODI_PAT_1")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPat2)
                    .IsRequired()
                    .HasColumnName("CODI_PAT_2")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPat3)
                    .IsRequired()
                    .HasColumnName("CODI_PAT_3")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPat4)
                    .IsRequired()
                    .HasColumnName("CODI_PAT_4")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPrc)
                    .IsRequired()
                    .HasColumnName("CODI_PRC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiPrg)
                    .IsRequired()
                    .HasColumnName("CODI_PRG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiRcu)
                    .IsRequired()
                    .HasColumnName("CODI_RCU")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiRut)
                    .IsRequired()
                    .HasColumnName("CODI_RUT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiSecDir)
                    .IsRequired()
                    .HasColumnName("CODI_SEC_DIR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiSecDst)
                    .IsRequired()
                    .HasColumnName("CODI_SEC_DST")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiSecVhi)
                    .IsRequired()
                    .HasColumnName("CODI_SEC_VHI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiSin)
                    .IsRequired()
                    .HasColumnName("CODI_SIN")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiTar)
                    .IsRequired()
                    .HasColumnName("CODI_TAR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiTfc)
                    .IsRequired()
                    .HasColumnName("CODI_TFC")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiTor)
                    .IsRequired()
                    .HasColumnName("CODI_TOR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiTra)
                    .IsRequired()
                    .HasColumnName("CODI_TRA")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiTrm)
                    .IsRequired()
                    .HasColumnName("CODI_TRM")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiTvh)
                    .IsRequired()
                    .HasColumnName("CODI_TVH")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiUp)
                    .IsRequired()
                    .HasColumnName("CODI_UP")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiUpEsp)
                    .IsRequired()
                    .HasColumnName("CODI_UP_ESP")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiVhi)
                    .IsRequired()
                    .HasColumnName("CODI_VHI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiVhi1)
                    .IsRequired()
                    .HasColumnName("CODI_VHI_1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiXof)
                    .IsRequired()
                    .HasColumnName("CODI_XOF")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiZonDir)
                    .IsRequired()
                    .HasColumnName("CODI_ZON_DIR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiZonDst)
                    .IsRequired()
                    .HasColumnName("CODI_ZON_DST")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiZonPobFinal)
                    .IsRequired()
                    .HasColumnName("CODI_ZON_POB_FINAL")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiZonPobInici)
                    .IsRequired()
                    .HasColumnName("CODI_ZON_POB_INICI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiZonSrv)
                    .IsRequired()
                    .HasColumnName("CODI_ZON_SRV")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodiZonVhi)
                    .IsRequired()
                    .HasColumnName("CODI_ZON_VHI")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cognoms)
                    .IsRequired()
                    .HasColumnName("COGNOMS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colegiat)
                    .IsRequired()
                    .HasColumnName("COLEGIAT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Conflictivitat)
                    .IsRequired()
                    .HasColumnName("CONFLICTIVITAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CpFinal)
                    .IsRequired()
                    .HasColumnName("CP_FINAL")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CpInici)
                    .IsRequired()
                    .HasColumnName("CP_INICI")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DatSiNo)
                    .HasColumnName("DAT_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Data98)
                    .HasColumnName("DATA_98")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data99)
                    .HasColumnName("DATA_99")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataActivacio)
                    .HasColumnName("DATA_ACTIVACIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAdjudicacio)
                    .HasColumnName("DATA_ADJUDICACIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAdmissio)
                    .HasColumnName("DATA_ADMISSIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAnula)
                    .HasColumnName("DATA_ANULA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataArribada)
                    .HasColumnName("DATA_ARRIBADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDestiAutomatic)
                    .HasColumnName("DATA_DESTI_AUTOMATIC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEvacuacio)
                    .HasColumnName("DATA_EVACUACIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFct)
                    .HasColumnName("DATA_FCT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinalSrv)
                    .HasColumnName("DATA_FINAL_SRV")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataHospital)
                    .HasColumnName("DATA_HOSPITAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataIniciSrv)
                    .HasColumnName("DATA_INICI_SRV")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataLliure)
                    .HasColumnName("DATA_LLIURE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataLloc)
                    .HasColumnName("DATA_LLOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataNeix)
                    .HasColumnName("DATA_NEIX")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataOrigenAutomatic)
                    .HasColumnName("DATA_ORIGEN_AUTOMATIC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPrevista)
                    .HasColumnName("DATA_PREVISTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRebut)
                    .HasColumnName("DATA_REBUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRebutAutomatic)
                    .HasColumnName("DATA_REBUT_AUTOMATIC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRecepcio)
                    .HasColumnName("DATA_RECEPCIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestiPob)
                    .IsRequired()
                    .HasColumnName("DESTI_POB")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DestiTra)
                    .IsRequired()
                    .HasColumnName("DESTI_TRA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DestiUp)
                    .IsRequired()
                    .HasColumnName("DESTI_UP")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirFinal)
                    .IsRequired()
                    .HasColumnName("DIR_FINAL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirFinal1)
                    .IsRequired()
                    .HasColumnName("DIR_FINAL_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirInici)
                    .IsRequired()
                    .HasColumnName("DIR_INICI")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DirInici1)
                    .IsRequired()
                    .HasColumnName("DIR_INICI_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("DNI")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dte)
                    .HasColumnName("DTE")
                    .HasColumnType("numeric(6, 3)");

                entity.Property(e => e.EsTornadaSiNo)
                    .HasColumnName("ES_TORNADA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Estat)
                    .IsRequired()
                    .HasColumnName("ESTAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HisMedic)
                    .IsRequired()
                    .HasColumnName("HIS_MEDIC")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HomeSiNo)
                    .HasColumnName("HOME_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.HoresEspera)
                    .HasColumnName("HORES_ESPERA")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ImpDesti)
                    .HasColumnName("IMP_DESTI")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.IndividualColectivo)
                    .IsRequired()
                    .HasColumnName("INDIVIDUAL_COLECTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.InfermeraSiNo)
                    .HasColumnName("INFERMERA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InternetEstat)
                    .HasColumnName("INTERNET_ESTAT")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InternetSiNo)
                    .HasColumnName("INTERNET_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Km)
                    .HasColumnName("KM")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmArribarProperaParada)
                    .HasColumnName("KM_ARRIBAR_PROPERA_PARADA")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.KmManual)
                    .HasColumnName("KM_MANUAL")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KmReal)
                    .HasColumnName("KM_REAL")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.LatitudFinal)
                    .HasColumnName("LATITUD_FINAL")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.LatitudInici)
                    .HasColumnName("LATITUD_INICI")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.LinDsk)
                    .HasColumnName("LIN_DSK")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.LongitudFinal)
                    .HasColumnName("LONGITUD_FINAL")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.LongitudInici)
                    .HasColumnName("LONGITUD_INICI")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.MetgeSiNo)
                    .HasColumnName("METGE_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MinutsArribarProperaParada)
                    .HasColumnName("MINUTS_ARRIBAR_PROPERA_PARADA")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.MinutsEnDeixar)
                    .HasColumnName("MINUTS_EN_DEIXAR")
                    .HasColumnType("numeric(15, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinutsEnRecollir)
                    .HasColumnName("MINUTS_EN_RECOLLIR")
                    .HasColumnType("numeric(15, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinutsMargeRecollir)
                    .HasColumnName("MINUTS_MARGE_RECOLLIR")
                    .HasColumnType("numeric(15, 0)")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.MinutsSrv)
                    .HasColumnName("MINUTS_SRV")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.MotiuPerqueSrvIndividual)
                    .HasColumnName("MOTIU_PERQUE_SRV_INDIVIDUAL")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Nass)
                    .IsRequired()
                    .HasColumnName("NASS")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("NOM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NomAcompanyant)
                    .IsRequired()
                    .HasColumnName("NOM_ACOMPANYANT")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumIntern)
                    .IsRequired()
                    .HasColumnName("NUM_INTERN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumPar)
                    .IsRequired()
                    .HasColumnName("NUM_PAR")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumSrv1)
                    .IsRequired()
                    .HasColumnName("NUM_SRV_1")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumSrv2)
                    .IsRequired()
                    .HasColumnName("NUM_SRV_2")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumSrvBloc)
                    .IsRequired()
                    .HasColumnName("NUM_SRV_BLOC")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Numeric98)
                    .HasColumnName("NUMERIC_98")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Numeric99)
                    .HasColumnName("NUMERIC_99")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Numerico1).HasColumnName("NUMERICO_1");

                entity.Property(e => e.Numerico2).HasColumnName("NUMERICO_2");

                entity.Property(e => e.Numerico3).HasColumnName("NUMERICO_3");

                entity.Property(e => e.Obs)
                    .IsRequired()
                    .HasColumnName("OBS")
                    .HasMaxLength(249)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObsInternas)
                    .IsRequired()
                    .HasColumnName("OBS_INTERNAS")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrdreBloc)
                    .HasColumnName("ORDRE_BLOC")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.OrigenPob)
                    .IsRequired()
                    .HasColumnName("ORIGEN_POB")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrigenSemPandora)
                    .HasColumnName("ORIGEN_SEM_PANDORA")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OrigenTra)
                    .IsRequired()
                    .HasColumnName("ORIGEN_TRA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrigenUp)
                    .IsRequired()
                    .HasColumnName("ORIGEN_UP")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OxigenConcentracio)
                    .HasColumnName("OXIGEN_CONCENTRACIO")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.OxigenLitres)
                    .HasColumnName("OXIGEN_LITRES")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.OxigenSiNo)
                    .HasColumnName("OXIGEN_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P10SiNo)
                    .HasColumnName("P10_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P10TornadaSiNo)
                    .HasColumnName("P10_TORNADA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PobFinal)
                    .IsRequired()
                    .HasColumnName("POB_FINAL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PobInici)
                    .IsRequired()
                    .HasColumnName("POB_INICI")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Polissa)
                    .IsRequired()
                    .HasColumnName("POLISSA")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosicioFinal)
                    .IsRequired()
                    .HasColumnName("POSICIO_FINAL")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosicioInici)
                    .IsRequired()
                    .HasColumnName("POSICIO_INICI")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Preu1)
                    .HasColumnName("PREU_1")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Preu2)
                    .HasColumnName("PREU_2")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Preu3)
                    .HasColumnName("PREU_3")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Preu4)
                    .HasColumnName("PREU_4")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Preu5)
                    .HasColumnName("PREU_5")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.PreuAero)
                    .HasColumnName("PREU_AERO")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PreuAjudant)
                    .HasColumnName("PREU_AJUDANT")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuDesti)
                    .HasColumnName("PREU_DESTI")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PreuEspera)
                    .HasColumnName("PREU_ESPERA")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuFestiu)
                    .HasColumnName("PREU_FESTIU")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuHora)
                    .HasColumnName("PREU_HORA")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuInfermera)
                    .HasColumnName("PREU_INFERMERA")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuKm)
                    .HasColumnName("PREU_KM")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.PreuMetge)
                    .HasColumnName("PREU_METGE")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuNit)
                    .HasColumnName("PREU_NIT")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuOxigen)
                    .HasColumnName("PREU_OXIGEN")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PreuSortida)
                    .HasColumnName("PREU_SORTIDA")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.PreuUrba)
                    .HasColumnName("PREU_URBA")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Prioritat)
                    .IsRequired()
                    .HasColumnName("PRIORITAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrvFinal)
                    .IsRequired()
                    .HasColumnName("PRV_FINAL")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrvInici)
                    .IsRequired()
                    .HasColumnName("PRV_INICI")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RampaSiNo)
                    .HasColumnName("RAMPA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasColumnName("REFERENCIA")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiNo98)
                    .HasColumnName("SI_NO_98")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SiNo99)
                    .HasColumnName("SI_NO_99")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Situacio1)
                    .HasColumnName("SITUACIO_1")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Situacio2)
                    .HasColumnName("SITUACIO_2")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Situacio3)
                    .HasColumnName("SITUACIO_3")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Situacio4)
                    .HasColumnName("SITUACIO_4")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Situacio5)
                    .HasColumnName("SITUACIO_5")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.SrvModificatDsk)
                    .HasColumnName("SRV_MODIFICAT_DSK")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Subestat)
                    .IsRequired()
                    .HasColumnName("SUBESTAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TeTornadaSiNo)
                    .HasColumnName("TE_TORNADA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TelSrv)
                    .IsRequired()
                    .HasColumnName("TEL_SRV")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelSrv2)
                    .IsRequired()
                    .HasColumnName("TEL_SRV_2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelSrv3)
                    .IsRequired()
                    .HasColumnName("TEL_SRV_3")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TempsEspSiNo)
                    .HasColumnName("TEMPS_ESP_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TerminalContestaSiNo)
                    .HasColumnName("TERMINAL_CONTESTA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipusSrv)
                    .IsRequired()
                    .HasColumnName("TIPUS_SRV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Unitats1)
                    .HasColumnName("UNITATS_1")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Unitats2)
                    .HasColumnName("UNITATS_2")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Unitats3)
                    .HasColumnName("UNITATS_3")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Unitats4)
                    .HasColumnName("UNITATS_4")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.Unitats5)
                    .HasColumnName("UNITATS_5")
                    .HasColumnType("numeric(13, 2)");

                entity.Property(e => e.UrbaSiNo)
                    .HasColumnName("URBA_SI_NO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.UsuAdjudicacio)
                    .IsRequired()
                    .HasColumnName("USU_ADJUDICACIO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuAdmissio)
                    .IsRequired()
                    .HasColumnName("USU_ADMISSIO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuAnula)
                    .IsRequired()
                    .HasColumnName("USU_ANULA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuArribada)
                    .IsRequired()
                    .HasColumnName("USU_ARRIBADA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuEvacuacio)
                    .IsRequired()
                    .HasColumnName("USU_EVACUACIO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuFinalSrv)
                    .IsRequired()
                    .HasColumnName("USU_FINAL_SRV")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuHospital)
                    .IsRequired()
                    .HasColumnName("USU_HOSPITAL")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuIniciSrv)
                    .IsRequired()
                    .HasColumnName("USU_INICI_SRV")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuLliure)
                    .IsRequired()
                    .HasColumnName("USU_LLIURE")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuRecepcio)
                    .IsRequired()
                    .HasColumnName("USU_RECEPCIO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VhiExtern)
                    .IsRequired()
                    .HasColumnName("VHI_EXTERN")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.XFinal)
                    .HasColumnName("X_FINAL")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.XInici)
                    .HasColumnName("X_INICI")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.YFinal)
                    .HasColumnName("Y_FINAL")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.YInici)
                    .HasColumnName("Y_INICI")
                    .HasColumnType("numeric(15, 5)");
            });
        }
    }
}
