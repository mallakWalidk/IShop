using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace First_Project.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Departmentt> Departmentts { get; set; }
        public virtual DbSet<Deptemployee> Deptemployees { get; set; }
        public virtual DbSet<DmrsColumn> DmrsColumns { get; set; }
        public virtual DbSet<DmrsConstrIndexColumn> DmrsConstrIndexColumns { get; set; }
        public virtual DbSet<DmrsContact> DmrsContacts { get; set; }
        public virtual DbSet<DmrsContactEmail> DmrsContactEmails { get; set; }
        public virtual DbSet<DmrsContactTelephone> DmrsContactTelephones { get; set; }
        public virtual DbSet<DmrsDesign> DmrsDesigns { get; set; }
        public virtual DbSet<DmrsDiagram> DmrsDiagrams { get; set; }
        public virtual DbSet<DmrsDistinctType> DmrsDistinctTypes { get; set; }
        public virtual DbSet<DmrsDocument> DmrsDocuments { get; set; }
        public virtual DbSet<DmrsDomain> DmrsDomains { get; set; }
        public virtual DbSet<DmrsDomainAvt> DmrsDomainAvts { get; set; }
        public virtual DbSet<DmrsDomainCheckConstraint> DmrsDomainCheckConstraints { get; set; }
        public virtual DbSet<DmrsDomainValueRange> DmrsDomainValueRanges { get; set; }
        public virtual DbSet<DmrsEmail> DmrsEmails { get; set; }
        public virtual DbSet<DmrsEntity> DmrsEntities { get; set; }
        public virtual DbSet<DmrsEntityview> DmrsEntityviews { get; set; }
        public virtual DbSet<DmrsEvent> DmrsEvents { get; set; }
        public virtual DbSet<DmrsExtAgentExtData> DmrsExtAgentExtDatas { get; set; }
        public virtual DbSet<DmrsExtAgentFlow> DmrsExtAgentFlows { get; set; }
        public virtual DbSet<DmrsExternalAgent> DmrsExternalAgents { get; set; }
        public virtual DbSet<DmrsExternalData> DmrsExternalDatas { get; set; }
        public virtual DbSet<DmrsFlow> DmrsFlows { get; set; }
        public virtual DbSet<DmrsFlowInfoStructure> DmrsFlowInfoStructures { get; set; }
        public virtual DbSet<DmrsForeignkey> DmrsForeignkeys { get; set; }
        public virtual DbSet<DmrsIndex> DmrsIndexes { get; set; }
        public virtual DbSet<DmrsInfoStore> DmrsInfoStores { get; set; }
        public virtual DbSet<DmrsInfoStructure> DmrsInfoStructures { get; set; }
        public virtual DbSet<DmrsInstallation> DmrsInstallations { get; set; }
        public virtual DbSet<DmrsKey> DmrsKeys { get; set; }
        public virtual DbSet<DmrsKeyAttribute> DmrsKeyAttributes { get; set; }
        public virtual DbSet<DmrsKeyElement> DmrsKeyElements { get; set; }
        public virtual DbSet<DmrsLocation> DmrsLocations { get; set; }
        public virtual DbSet<DmrsLogicalToNative> DmrsLogicalToNatives { get; set; }
        public virtual DbSet<DmrsLogicalType> DmrsLogicalTypes { get; set; }
        public virtual DbSet<DmrsMapping> DmrsMappings { get; set; }
        public virtual DbSet<DmrsModel> DmrsModels { get; set; }
        public virtual DbSet<DmrsModelDisplay> DmrsModelDisplays { get; set; }
        public virtual DbSet<DmrsModelSubview> DmrsModelSubviews { get; set; }
        public virtual DbSet<DmrvReportsVersion10> DmrvReportsVersion10s { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeet> Employeets { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Jordan> Jordans { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<RCustomer> RCustomers { get; set; }
        public virtual DbSet<RProduct> RProducts { get; set; }
        public virtual DbSet<RProductCustomer> RProductCustomers { get; set; }
        public virtual DbSet<RRole> RRoles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<TAddress> TAddresses { get; set; }
        public virtual DbSet<TAuditing> TAuditings { get; set; }
        public virtual DbSet<TContactInfo> TContactInfos { get; set; }
        public virtual DbSet<TDepartment> TDepartments { get; set; }
        public virtual DbSet<TEmployee> TEmployees { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VStudent> VStudents { get; set; }
        public virtual DbSet<Visacard> Visacards { get; set; }
        public virtual DbSet<WebsitePage> WebsitePages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=Tah14_User131;PASSWORD=5220Ma;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TAH14_USER131")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<AboutU>(entity =>
            {
                entity.ToTable("ABOUT_US");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.FirstDescreption)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_DESCREPTION");

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMG_PATH");

                entity.Property(e => e.SecondDescreption)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("SECOND_DESCREPTION");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.ToTable("CONTACT_US");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Facebook)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FACEBOOK");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSTAGRAM");

                entity.Property(e => e.Phonenumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CREDIT_CARDS");

                entity.HasIndex(e => e.SerialNumber, "SYS_C00241602")
                    .IsUnique();

                entity.Property(e => e.Balance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.Cvv)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CVV");

                entity.Property(e => e.ExpMonth)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXP_MONTH");

                entity.Property(e => e.ExpYear)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXP_YEAR");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL_NUMBER");
            });

            modelBuilder.Entity<Departmentt>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("DEP_PK");

                entity.ToTable("DEPARTMENTT");

                entity.Property(e => e.Deptid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPTID");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Deptemployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DEPTEMPLOYEE");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Deptid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPTID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<DmrsColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_COLUMNS");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ABBREVIATION");

                entity.Property(e => e.AutoIncrementCache)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTO_INCREMENT_CACHE");

                entity.Property(e => e.AutoIncrementColumn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_COLUMN")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoIncrementCycle)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_CYCLE")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoIncrementDisableCache)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_DISABLE_CACHE")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoIncrementGenerateAlways)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_GENERATE_ALWAYS")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoIncrementIncrementBy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTO_INCREMENT_INCREMENT_BY");

                entity.Property(e => e.AutoIncrementMaxValue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTO_INCREMENT_MAX_VALUE");

                entity.Property(e => e.AutoIncrementMinValue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTO_INCREMENT_MIN_VALUE");

                entity.Property(e => e.AutoIncrementOrder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_ORDER")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoIncrementSequenceName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_SEQUENCE_NAME");

                entity.Property(e => e.AutoIncrementStartWith)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AUTO_INCREMENT_START_WITH");

                entity.Property(e => e.AutoIncrementTriggerName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("AUTO_INCREMENT_TRIGGER_NAME");

                entity.Property(e => e.CharUnits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CHAR_UNITS")
                    .IsFixedLength(true);

                entity.Property(e => e.CheckConstraintName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CHECK_CONSTRAINT_NAME");

                entity.Property(e => e.CollectionTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTION_TYPE_ID");

                entity.Property(e => e.CollectionTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTION_TYPE_NAME");

                entity.Property(e => e.CollectionTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTION_TYPE_OVID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("COLUMN_NAME");

                entity.Property(e => e.Computed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMPUTED")
                    .IsFixedLength(true);

                entity.Property(e => e.ContainerId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_ID");

                entity.Property(e => e.ContainerOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_OVID");

                entity.Property(e => e.ContainsPii)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINS_PII");

                entity.Property(e => e.DatatypeKind)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DATATYPE_KIND");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_VALUE");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DistinctTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DISTINCT_TYPE_ID");

                entity.Property(e => e.DistinctTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DISTINCT_TYPE_NAME");

                entity.Property(e => e.DistinctTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DISTINCT_TYPE_OVID");

                entity.Property(e => e.DomainId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_ID");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_NAME");

                entity.Property(e => e.DomainOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_OVID");

                entity.Property(e => e.Engineer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGINEER")
                    .IsFixedLength(true);

                entity.Property(e => e.FkFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FK_FLAG");

                entity.Property(e => e.Formula)
                    .IsUnicode(false)
                    .HasColumnName("FORMULA");

                entity.Property(e => e.IdentityColumn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITY_COLUMN")
                    .IsFixedLength(true);

                entity.Property(e => e.ImportId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_ID");

                entity.Property(e => e.LogicalTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_ID");

                entity.Property(e => e.LogicalTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_NAME");

                entity.Property(e => e.LogicalTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_OVID");

                entity.Property(e => e.Mandatory)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MANDATORY")
                    .IsFixedLength(true);

                entity.Property(e => e.MaskForNoneProduction)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MASK_FOR_NONE_PRODUCTION")
                    .IsFixedLength(true);

                entity.Property(e => e.MaskTymplateOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MASK_TYMPLATE_OVID");

                entity.Property(e => e.MaskType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASK_TYPE");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.NativeType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NATIVE_TYPE");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.PersonallyIdInformation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PERSONALLY_ID_INFORMATION")
                    .IsFixedLength(true);

                entity.Property(e => e.PkFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PK_FLAG");

                entity.Property(e => e.ScopeentityId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SCOPEENTITY_ID");

                entity.Property(e => e.ScopeentityName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SCOPEENTITY_NAME");

                entity.Property(e => e.ScopeentityOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SCOPEENTITY_OVID");

                entity.Property(e => e.SensitiveDataDescr)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SENSITIVE_DATA_DESCR");

                entity.Property(e => e.SensitiveInformation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SENSITIVE_INFORMATION")
                    .IsFixedLength(true);

                entity.Property(e => e.SensitiveTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SENSITIVE_TYPE_OVID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.StructuredTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_ID");

                entity.Property(e => e.StructuredTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_NAME");

                entity.Property(e => e.StructuredTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_OVID");

                entity.Property(e => e.TPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_PRECISION");

                entity.Property(e => e.TScale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_SCALE");

                entity.Property(e => e.TSize)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("T_SIZE");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.UseDomainConstraint)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USE_DOMAIN_CONSTRAINT")
                    .IsFixedLength(true);

                entity.Property(e => e.UsesDefault)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USES_DEFAULT")
                    .IsFixedLength(true);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VALUE_TYPE");
            });

            modelBuilder.Entity<DmrsConstrIndexColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_CONSTR_INDEX_COLUMNS");

                entity.Property(e => e.ColumnId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COLUMN_ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("COLUMN_NAME");

                entity.Property(e => e.ColumnOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("COLUMN_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.IndexId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("INDEX_ID");

                entity.Property(e => e.IndexName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("INDEX_NAME");

                entity.Property(e => e.IndexOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("INDEX_OVID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SORT_ORDER");

                entity.Property(e => e.TableId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_ID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TableOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_OVID");
            });

            modelBuilder.Entity<DmrsContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_CONTACTS");

                entity.Property(e => e.BusinessInfoId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_ID");

                entity.Property(e => e.BusinessInfoName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_NAME");

                entity.Property(e => e.BusinessInfoOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_OVID");

                entity.Property(e => e.ContactId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_ID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_NAME");

                entity.Property(e => e.ContactOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");
            });

            modelBuilder.Entity<DmrsContactEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_CONTACT_EMAILS");

                entity.Property(e => e.ContactId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_ID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_NAME");

                entity.Property(e => e.ContactOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ID");

                entity.Property(e => e.EmailName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_NAME");

                entity.Property(e => e.EmailOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_OVID");
            });

            modelBuilder.Entity<DmrsContactTelephone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_CONTACT_TELEPHONES");

                entity.Property(e => e.ContactId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_ID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_NAME");

                entity.Property(e => e.ContactOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.TelephoneId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_ID");

                entity.Property(e => e.TelephoneName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_NAME");

                entity.Property(e => e.TelephoneOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE_OVID");
            });

            modelBuilder.Entity<DmrsDesign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DESIGNS");

                entity.Property(e => e.DatePublished)
                    .HasPrecision(6)
                    .HasColumnName("DATE_PUBLISHED");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.PersistenceVersion)
                    .HasColumnType("NUMBER(5,2)")
                    .HasColumnName("PERSISTENCE_VERSION");

                entity.Property(e => e.PublishedBy)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PUBLISHED_BY");

                entity.Property(e => e.VersionComments)
                    .IsUnicode(false)
                    .HasColumnName("VERSION_COMMENTS");
            });

            modelBuilder.Entity<DmrsDiagram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DIAGRAMS");

                entity.Property(e => e.Autoroute)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTOROUTE")
                    .IsFixedLength(true);

                entity.Property(e => e.BoxInBox)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOX_IN_BOX")
                    .IsFixedLength(true);

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DiagramName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_NAME");

                entity.Property(e => e.DiagramPdf)
                    .HasColumnType("BLOB")
                    .HasColumnName("DIAGRAM_PDF");

                entity.Property(e => e.DiagramSvg)
                    .HasColumnType("CLOB")
                    .HasColumnName("DIAGRAM_SVG");

                entity.Property(e => e.DiagramType)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_TYPE");

                entity.Property(e => e.DisplayId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_ID");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_NAME");

                entity.Property(e => e.DisplayOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_OVID");

                entity.Property(e => e.IsDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_DISPLAY")
                    .IsFixedLength(true);

                entity.Property(e => e.MasterDiagramId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_DIAGRAM_ID");

                entity.Property(e => e.MasterDiagramName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_DIAGRAM_NAME");

                entity.Property(e => e.MasterDiagramOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_DIAGRAM_OVID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.Notation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOTATION");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.ShowAllDetails)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SHOW_ALL_DETAILS")
                    .IsFixedLength(true);

                entity.Property(e => e.ShowDatatype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SHOW_DATATYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.ShowElements)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SHOW_ELEMENTS")
                    .IsFixedLength(true);

                entity.Property(e => e.ShowKeys)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SHOW_KEYS")
                    .IsFixedLength(true);

                entity.Property(e => e.ShowNamesOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SHOW_NAMES_ONLY")
                    .IsFixedLength(true);

                entity.Property(e => e.SubviewId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SUBVIEW_ID");

                entity.Property(e => e.SubviewName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SUBVIEW_NAME");

                entity.Property(e => e.SubviewOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SUBVIEW_OVID");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VISIBLE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DmrsDistinctType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DISTINCT_TYPES");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DistinctTypeId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DISTINCT_TYPE_ID");

                entity.Property(e => e.DistinctTypeName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DISTINCT_TYPE_NAME");

                entity.Property(e => e.DistinctTypeOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DISTINCT_TYPE_OVID");

                entity.Property(e => e.LogicalTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_ID");

                entity.Property(e => e.LogicalTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_NAME");

                entity.Property(e => e.LogicalTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_OVID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.TPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_PRECISION");

                entity.Property(e => e.TScale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_SCALE");

                entity.Property(e => e.TSize)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("T_SIZE");
            });

            modelBuilder.Entity<DmrsDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DOCUMENTS");

                entity.Property(e => e.BusinessInfoId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_ID");

                entity.Property(e => e.BusinessInfoName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_NAME");

                entity.Property(e => e.BusinessInfoOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DocReference)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DOC_REFERENCE");

                entity.Property(e => e.DocType)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DOC_TYPE");

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_ID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_NAME");

                entity.Property(e => e.DocumentOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_OVID");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_ID");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NAME");

                entity.Property(e => e.ParentOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_OVID");
            });

            modelBuilder.Entity<DmrsDomain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DOMAINS");

                entity.Property(e => e.CharUnits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CHAR_UNITS")
                    .IsFixedLength(true);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_VALUE");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_ID");

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_NAME");

                entity.Property(e => e.LogicalTypeId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_ID");

                entity.Property(e => e.LogicalTypeOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_OVID");

                entity.Property(e => e.LtName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LT_NAME");

                entity.Property(e => e.NativeType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NATIVE_TYPE");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.SensitiveDataDescr)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SENSITIVE_DATA_DESCR");

                entity.Property(e => e.SensitiveTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SENSITIVE_TYPE_OVID");

                entity.Property(e => e.Synonyms)
                    .IsUnicode(false)
                    .HasColumnName("SYNONYMS");

                entity.Property(e => e.TPrecision)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_PRECISION");

                entity.Property(e => e.TScale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_SCALE");

                entity.Property(e => e.TSize)
                    .HasColumnType("NUMBER")
                    .HasColumnName("T_SIZE");

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OF_MEASURE");
            });

            modelBuilder.Entity<DmrsDomainAvt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DOMAIN_AVT");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_ID");

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_NAME");

                entity.Property(e => e.DomainOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_OVID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_DESCRIPTION");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("VALUE");
            });

            modelBuilder.Entity<DmrsDomainCheckConstraint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DOMAIN_CHECK_CONSTRAINTS");

                entity.Property(e => e.DatabaseType)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DATABASE_TYPE");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_ID");

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_NAME");

                entity.Property(e => e.DomainOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_OVID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("TEXT");
            });

            modelBuilder.Entity<DmrsDomainValueRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_DOMAIN_VALUE_RANGES");

                entity.Property(e => e.BeginValue)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("BEGIN_VALUE");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_ID");

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_NAME");

                entity.Property(e => e.DomainOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DOMAIN_OVID");

                entity.Property(e => e.EndValue)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("END_VALUE");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_DESCRIPTION");
            });

            modelBuilder.Entity<DmrsEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_EMAILS");

                entity.Property(e => e.BusinessInfoId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_ID");

                entity.Property(e => e.BusinessInfoName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_NAME");

                entity.Property(e => e.BusinessInfoOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ID");

                entity.Property(e => e.EmailName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_NAME");

                entity.Property(e => e.EmailOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_OVID");

                entity.Property(e => e.EmailType)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_TYPE");
            });

            modelBuilder.Entity<DmrsEntity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_ENTITIES");

                entity.Property(e => e.AdequatelyNormalized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADEQUATELY_NORMALIZED")
                    .IsFixedLength(true);

                entity.Property(e => e.AllowTypeSubstitution)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALLOW_TYPE_SUBSTITUTION")
                    .IsFixedLength(true);

                entity.Property(e => e.ClassificationTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION_TYPE_ID");

                entity.Property(e => e.ClassificationTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION_TYPE_NAME");

                entity.Property(e => e.ClassificationTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CLASSIFICATION_TYPE_OVID");

                entity.Property(e => e.CreateSurrogateKey)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_SURROGATE_KEY");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EngineeringStrategy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ENGINEERING_STRATEGY");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.EntitySource)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_SOURCE");

                entity.Property(e => e.ExpectedVolume)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EXPECTED_VOLUME");

                entity.Property(e => e.GrowthRateInterval)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GROWTH_RATE_INTERVAL");

                entity.Property(e => e.GrowthRatePercents)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GROWTH_RATE_PERCENTS");

                entity.Property(e => e.ImportId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_ID");

                entity.Property(e => e.MaxVolume)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MAX_VOLUME");

                entity.Property(e => e.MinVolume)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MIN_VOLUME");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.NormalForm)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NORMAL_FORM");

                entity.Property(e => e.NumberDataElements)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBER_DATA_ELEMENTS");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.PreferredAbbreviation)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("PREFERRED_ABBREVIATION");

                entity.Property(e => e.RemotedesignId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEDESIGN_ID");

                entity.Property(e => e.RemotemodelId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEMODEL_ID");

                entity.Property(e => e.RemoteobjectId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEOBJECT_ID");

                entity.Property(e => e.Remoteobjectrltvstoragename)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEOBJECTRLTVSTORAGENAME");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.StructuredTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_ID");

                entity.Property(e => e.StructuredTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_NAME");

                entity.Property(e => e.StructuredTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_OVID");

                entity.Property(e => e.SubstitutionParent)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SUBSTITUTION_PARENT");

                entity.Property(e => e.SubstitutionParentName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SUBSTITUTION_PARENT_NAME");

                entity.Property(e => e.SubstitutionParentOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SUBSTITUTION_PARENT_OVID");

                entity.Property(e => e.SubtApplyToModelOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_APPLY_TO_MODEL_OVID");

                entity.Property(e => e.SubtAttributesInheritance)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_ATTRIBUTES_INHERITANCE");

                entity.Property(e => e.SubtCompleteSubtypes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_COMPLETE_SUBTYPES");

                entity.Property(e => e.SubtDiscriminatorColumnName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_DISCRIMINATOR_COLUMN_NAME");

                entity.Property(e => e.SubtDiscriminatorValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_DISCRIMINATOR_VALUE");

                entity.Property(e => e.SubtGenerateDiscriminator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_GENERATE_DISCRIMINATOR");

                entity.Property(e => e.SubtReferences)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_REFERENCES");

                entity.Property(e => e.SubtSubtreeGeneration)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_SUBTREE_GENERATION");

                entity.Property(e => e.SubtUseAttributeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SUBT_USE_ATTRIBUTE_ID");

                entity.Property(e => e.SupertypeentityId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SUPERTYPEENTITY_ID");

                entity.Property(e => e.SupertypeentityName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SUPERTYPEENTITY_NAME");

                entity.Property(e => e.SupertypeentityOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SUPERTYPEENTITY_OVID");

                entity.Property(e => e.SynonymToDisplay)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SYNONYM_TO_DISPLAY");

                entity.Property(e => e.Synonyms)
                    .IsUnicode(false)
                    .HasColumnName("SYNONYMS");

                entity.Property(e => e.TemporaryObjectScope)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TEMPORARY_OBJECT_SCOPE");

                entity.Property(e => e.Usedasremoteobject)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USEDASREMOTEOBJECT")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DmrsEntityview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_ENTITYVIEWS");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EntityviewName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENTITYVIEW_NAME");

                entity.Property(e => e.ImportId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_ID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.RemotedesignId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEDESIGN_ID");

                entity.Property(e => e.RemotemodelId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEMODEL_ID");

                entity.Property(e => e.RemoteobjectId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEOBJECT_ID");

                entity.Property(e => e.Remoteobjectrltvstoragename)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REMOTEOBJECTRLTVSTORAGENAME");

                entity.Property(e => e.StructuredTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_ID");

                entity.Property(e => e.StructuredTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_NAME");

                entity.Property(e => e.StructuredTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURED_TYPE_OVID");

                entity.Property(e => e.Usedasremoteobject)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USEDASREMOTEOBJECT")
                    .IsFixedLength(true);

                entity.Property(e => e.UserDefined)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_DEFINED")
                    .IsFixedLength(true);

                entity.Property(e => e.ViewType)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("VIEW_TYPE");
            });

            modelBuilder.Entity<DmrsEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_EVENTS");

                entity.Property(e => e.AtTime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AT_TIME")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfMonth)
                    .HasPrecision(2)
                    .HasColumnName("DAY_OF_MONTH");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DAY_OF_WEEK");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_ID");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_NAME");

                entity.Property(e => e.EventOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_OVID");

                entity.Property(e => e.EventType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_TYPE");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength(true);

                entity.Property(e => e.FlowId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_ID");

                entity.Property(e => e.FlowName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_NAME");

                entity.Property(e => e.FlowOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_OVID");

                entity.Property(e => e.Frequency)
                    .HasPrecision(10)
                    .HasColumnName("FREQUENCY");

                entity.Property(e => e.Hour)
                    .HasPrecision(2)
                    .HasColumnName("HOUR");

                entity.Property(e => e.Minute)
                    .HasPrecision(2)
                    .HasColumnName("MINUTE");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.Months)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MONTHS");

                entity.Property(e => e.OnDay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ON_DAY")
                    .IsFixedLength(true);

                entity.Property(e => e.Quarter)
                    .HasPrecision(1)
                    .HasColumnName("QUARTER");

                entity.Property(e => e.Text)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");

                entity.Property(e => e.TimeFrequency)
                    .HasPrecision(10)
                    .HasColumnName("TIME_FREQUENCY");

                entity.Property(e => e.TimesWhenRun)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIMES_WHEN_RUN");

                entity.Property(e => e.Year)
                    .HasPrecision(4)
                    .HasColumnName("YEAR");
            });

            modelBuilder.Entity<DmrsExtAgentExtData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_EXT_AGENT_EXT_DATAS");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.ExternalAgentId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_ID");

                entity.Property(e => e.ExternalAgentName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_NAME");

                entity.Property(e => e.ExternalAgentOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_OVID");

                entity.Property(e => e.ExternalDataId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_DATA_ID");

                entity.Property(e => e.ExternalDataName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_DATA_NAME");

                entity.Property(e => e.ExternalDataOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_DATA_OVID");
            });

            modelBuilder.Entity<DmrsExtAgentFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_EXT_AGENT_FLOWS");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.ExternalAgentId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_ID");

                entity.Property(e => e.ExternalAgentName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_NAME");

                entity.Property(e => e.ExternalAgentOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_OVID");

                entity.Property(e => e.FlowId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_ID");

                entity.Property(e => e.FlowName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_NAME");

                entity.Property(e => e.FlowOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_OVID");

                entity.Property(e => e.IncomingOutgoingFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INCOMING_OUTGOING_FLAG")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DmrsExternalAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_EXTERNAL_AGENTS");

                entity.Property(e => e.DataCaptureType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DATA_CAPTURE_TYPE");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DiagramId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_ID");

                entity.Property(e => e.DiagramName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_NAME");

                entity.Property(e => e.DiagramOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_OVID");

                entity.Property(e => e.ExternalAgentId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_ID");

                entity.Property(e => e.ExternalAgentName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_NAME");

                entity.Property(e => e.ExternalAgentOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_OVID");

                entity.Property(e => e.ExternalAgentType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_AGENT_TYPE");

                entity.Property(e => e.FieldSeparator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIELD_SEPARATOR")
                    .IsFixedLength(true);

                entity.Property(e => e.FileLocation)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FILE_LOCATION");

                entity.Property(e => e.FileName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.FileOwner)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FILE_OWNER");

                entity.Property(e => e.FileSource)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FILE_SOURCE");

                entity.Property(e => e.FileType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FILE_TYPE");

                entity.Property(e => e.SelfDescribing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SELF_DESCRIBING")
                    .IsFixedLength(true);

                entity.Property(e => e.SkipRecords)
                    .HasPrecision(10)
                    .HasColumnName("SKIP_RECORDS");

                entity.Property(e => e.TextDelimiter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TEXT_DELIMITER")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DmrsExternalData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_EXTERNAL_DATAS");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.ExternalDataId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_DATA_ID");

                entity.Property(e => e.ExternalDataName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_DATA_NAME");

                entity.Property(e => e.ExternalDataOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNAL_DATA_OVID");

                entity.Property(e => e.LogicalTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_ID");

                entity.Property(e => e.LogicalTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_NAME");

                entity.Property(e => e.LogicalTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_OVID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.RecordStructureTypeId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_STRUCTURE_TYPE_ID");

                entity.Property(e => e.RecordStructureTypeName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_STRUCTURE_TYPE_NAME");

                entity.Property(e => e.RecordStructureTypeOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_STRUCTURE_TYPE_OVID");

                entity.Property(e => e.StartingPos)
                    .HasPrecision(10)
                    .HasColumnName("STARTING_POS");
            });

            modelBuilder.Entity<DmrsFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_FLOWS");

                entity.Property(e => e.CrudCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CRUD_CODE");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DestinationId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION_ID");

                entity.Property(e => e.DestinationName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION_NAME");

                entity.Property(e => e.DestinationOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION_OVID");

                entity.Property(e => e.DestinationType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESTINATION_TYPE");

                entity.Property(e => e.DiagramId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_ID");

                entity.Property(e => e.DiagramName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_NAME");

                entity.Property(e => e.DiagramOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DIAGRAM_OVID");

                entity.Property(e => e.EventId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_ID");

                entity.Property(e => e.EventName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_NAME");

                entity.Property(e => e.EventOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("EVENT_OVID");

                entity.Property(e => e.FlowId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_ID");

                entity.Property(e => e.FlowName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_NAME");

                entity.Property(e => e.FlowOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_OVID");

                entity.Property(e => e.Logging)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LOGGING")
                    .IsFixedLength(true);

                entity.Property(e => e.OpCreate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OP_CREATE")
                    .IsFixedLength(true);

                entity.Property(e => e.OpDelete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OP_DELETE")
                    .IsFixedLength(true);

                entity.Property(e => e.OpRead)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OP_READ")
                    .IsFixedLength(true);

                entity.Property(e => e.OpUpdate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OP_UPDATE")
                    .IsFixedLength(true);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_ID");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NAME");

                entity.Property(e => e.ParentOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_OVID");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_ID");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_NAME");

                entity.Property(e => e.SourceOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_OVID");

                entity.Property(e => e.SourceType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_TYPE");

                entity.Property(e => e.SystemObjective)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_OBJECTIVE");
            });

            modelBuilder.Entity<DmrsFlowInfoStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_FLOW_INFO_STRUCTURES");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.FlowId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_ID");

                entity.Property(e => e.FlowName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_NAME");

                entity.Property(e => e.FlowOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("FLOW_OVID");

                entity.Property(e => e.InfoStructureId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STRUCTURE_ID");

                entity.Property(e => e.InfoStructureName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STRUCTURE_NAME");

                entity.Property(e => e.InfoStructureOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STRUCTURE_OVID");
            });

            modelBuilder.Entity<DmrsForeignkey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_FOREIGNKEYS");

                entity.Property(e => e.ArcId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ARC_ID");

                entity.Property(e => e.ChildTableId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_TABLE_ID");

                entity.Property(e => e.ChildTableName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_TABLE_NAME");

                entity.Property(e => e.ChildTableOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CHILD_TABLE_OVID");

                entity.Property(e => e.DeleteRule)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DELETE_RULE");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DiscriminatorColumnOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DISCRIMINATOR_COLUMN_OVID");

                entity.Property(e => e.DiscriminatorValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISCRIMINATOR_VALUE");

                entity.Property(e => e.Engineer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGINEER")
                    .IsFixedLength(true);

                entity.Property(e => e.FkName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FK_NAME");

                entity.Property(e => e.ImportId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_ID");

                entity.Property(e => e.InArc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_ARC")
                    .IsFixedLength(true);

                entity.Property(e => e.Mandatory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MANDATORY")
                    .IsFixedLength(true);

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.NumberOfColumns)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBER_OF_COLUMNS");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.ReferredKeyId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_KEY_ID");

                entity.Property(e => e.ReferredKeyName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_KEY_NAME");

                entity.Property(e => e.ReferredKeyOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_KEY_OVID");

                entity.Property(e => e.ReferredTableId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_TABLE_ID");

                entity.Property(e => e.ReferredTableName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_TABLE_NAME");

                entity.Property(e => e.ReferredTableOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_TABLE_OVID");

                entity.Property(e => e.Transferable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFERABLE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DmrsIndex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_INDEXES");

                entity.Property(e => e.ContainerId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_ID");

                entity.Property(e => e.ContainerOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.Engineer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGINEER")
                    .IsFixedLength(true);

                entity.Property(e => e.Expression)
                    .IsUnicode(false)
                    .HasColumnName("EXPRESSION");

                entity.Property(e => e.Functional)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FUNCTIONAL")
                    .IsFixedLength(true);

                entity.Property(e => e.GeodeticIndex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GEODETIC_INDEX")
                    .IsFixedLength(true);

                entity.Property(e => e.ImportId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_ID");

                entity.Property(e => e.IndexName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("INDEX_NAME");

                entity.Property(e => e.NumberOfDimensions)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBER_OF_DIMENSIONS")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMA_NAME");

                entity.Property(e => e.SchemaOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SCHEMA_OVID");

                entity.Property(e => e.SpatialIndex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SPATIAL_INDEX")
                    .IsFixedLength(true);

                entity.Property(e => e.SpatialLayerType)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SPATIAL_LAYER_TYPE");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");
            });

            modelBuilder.Entity<DmrsInfoStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_INFO_STORES");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.FieldSeparator)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FIELD_SEPARATOR");

                entity.Property(e => e.FileName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.FileType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FILE_TYPE");

                entity.Property(e => e.ImplementationName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("IMPLEMENTATION_NAME");

                entity.Property(e => e.InfoStoreId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STORE_ID");

                entity.Property(e => e.InfoStoreName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STORE_NAME");

                entity.Property(e => e.InfoStoreOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STORE_OVID");

                entity.Property(e => e.InfoStoreType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STORE_TYPE");

                entity.Property(e => e.Location)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_TYPE");

                entity.Property(e => e.Owner)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.RdbmsSite)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RDBMS_SITE");

                entity.Property(e => e.Scope)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SCOPE");

                entity.Property(e => e.SelfDescribing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SELF_DESCRIBING")
                    .IsFixedLength(true);

                entity.Property(e => e.SkipRecords)
                    .HasPrecision(10)
                    .HasColumnName("SKIP_RECORDS");

                entity.Property(e => e.Source)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.SystemObjective)
                    .IsUnicode(false)
                    .HasColumnName("SYSTEM_OBJECTIVE");

                entity.Property(e => e.TextDelimiter)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TEXT_DELIMITER");

                entity.Property(e => e.TransferType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFER_TYPE");
            });

            modelBuilder.Entity<DmrsInfoStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_INFO_STRUCTURES");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.GrowthRatePercent)
                    .HasPrecision(10)
                    .HasColumnName("GROWTH_RATE_PERCENT");

                entity.Property(e => e.GrowthRateUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GROWTH_RATE_UNIT");

                entity.Property(e => e.InfoStructureId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STRUCTURE_ID");

                entity.Property(e => e.InfoStructureName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STRUCTURE_NAME");

                entity.Property(e => e.InfoStructureOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("INFO_STRUCTURE_OVID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.Volume)
                    .HasPrecision(10)
                    .HasColumnName("VOLUME");
            });

            modelBuilder.Entity<DmrsInstallation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DMRS_INSTALLATION");

                entity.Property(e => e.CreatedOn)
                    .HasPrecision(9)
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.DmrsPersistenceVersion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DMRS_PERSISTENCE_VERSION");

                entity.Property(e => e.DmrsReportsVersion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DMRS_REPORTS_VERSION");
            });

            modelBuilder.Entity<DmrsKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_KEYS");

                entity.Property(e => e.ContainerId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_ID");

                entity.Property(e => e.ContainerOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINER_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.ImportId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("IMPORT_ID");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("KEY_NAME");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ID");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.Synonyms)
                    .IsUnicode(false)
                    .HasColumnName("SYNONYMS");
            });

            modelBuilder.Entity<DmrsKeyAttribute>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_KEY_ATTRIBUTES");

                entity.Property(e => e.AttributeId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_ID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_NAME");

                entity.Property(e => e.AttributeOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ATTRIBUTE_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.EntityOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_OVID");

                entity.Property(e => e.KeyId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("KEY_ID");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("KEY_NAME");

                entity.Property(e => e.KeyOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("KEY_OVID");

                entity.Property(e => e.RelationshipId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP_ID");

                entity.Property(e => e.RelationshipName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP_NAME");

                entity.Property(e => e.RelationshipOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONSHIP_OVID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<DmrsKeyElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_KEY_ELEMENTS");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ELEMENT_ID");

                entity.Property(e => e.ElementName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ELEMENT_NAME");

                entity.Property(e => e.ElementOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ELEMENT_OVID");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.EntityOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_OVID");

                entity.Property(e => e.KeyId)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("KEY_ID");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("KEY_NAME");

                entity.Property(e => e.KeyOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("KEY_OVID");

                entity.Property(e => e.Sequence)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQUENCE");

                entity.Property(e => e.SourceLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_LABEL");

                entity.Property(e => e.TargetLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARGET_LABEL");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DmrsLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_LOCATIONS");

                entity.Property(e => e.BusinessInfoId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_ID");

                entity.Property(e => e.BusinessInfoName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_NAME");

                entity.Property(e => e.BusinessInfoOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("BUSINESS_INFO_OVID");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.LocAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOC_ADDRESS");

                entity.Property(e => e.LocArea)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOC_AREA");

                entity.Property(e => e.LocCity)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOC_CITY");

                entity.Property(e => e.LocCountry)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOC_COUNTRY");

                entity.Property(e => e.LocPostCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOC_POST_CODE");

                entity.Property(e => e.LocType)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOC_TYPE");

                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.LocationOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_OVID");
            });

            modelBuilder.Entity<DmrsLogicalToNative>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_LOGICAL_TO_NATIVE");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.HasPrecision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAS_PRECISION");

                entity.Property(e => e.HasScale)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAS_SCALE");

                entity.Property(e => e.HasSize)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("HAS_SIZE");

                entity.Property(e => e.LogicalTypeId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_ID");

                entity.Property(e => e.LogicalTypeOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_OVID");

                entity.Property(e => e.LtName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LT_NAME");

                entity.Property(e => e.NativeType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NATIVE_TYPE");

                entity.Property(e => e.RdbmsType)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RDBMS_TYPE");

                entity.Property(e => e.RdbmsVersion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RDBMS_VERSION");
            });

            modelBuilder.Entity<DmrsLogicalType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_LOGICAL_TYPES");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.LogicalTypeId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_TYPE_ID");

                entity.Property(e => e.LtName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LT_NAME");

                entity.Property(e => e.Ovid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("OVID");
            });

            modelBuilder.Entity<DmrsMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_MAPPINGS");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.EntityOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_OVID");

                entity.Property(e => e.LogicalModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_MODEL_ID");

                entity.Property(e => e.LogicalModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_MODEL_NAME");

                entity.Property(e => e.LogicalModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_MODEL_OVID");

                entity.Property(e => e.LogicalObjectId)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_OBJECT_ID");

                entity.Property(e => e.LogicalObjectName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_OBJECT_NAME");

                entity.Property(e => e.LogicalObjectOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_OBJECT_OVID");

                entity.Property(e => e.LogicalObjectType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOGICAL_OBJECT_TYPE");

                entity.Property(e => e.RelationalModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_MODEL_ID");

                entity.Property(e => e.RelationalModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_MODEL_NAME");

                entity.Property(e => e.RelationalModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_MODEL_OVID");

                entity.Property(e => e.RelationalObjectId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_OBJECT_ID");

                entity.Property(e => e.RelationalObjectName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_OBJECT_NAME");

                entity.Property(e => e.RelationalObjectOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_OBJECT_OVID");

                entity.Property(e => e.RelationalObjectType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RELATIONAL_OBJECT_TYPE");

                entity.Property(e => e.TableId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_ID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TableOvid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_OVID");
            });

            modelBuilder.Entity<DmrsModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_MODELS");

                entity.Property(e => e.DesignId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_ID");

                entity.Property(e => e.DesignName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_NAME");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.ModelType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_TYPE");

                entity.Property(e => e.RdbmsType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RDBMS_TYPE");
            });

            modelBuilder.Entity<DmrsModelDisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_MODEL_DISPLAYS");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.DisplayId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_ID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_NAME");

                entity.Property(e => e.DisplayOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DISPLAY_OVID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");
            });

            modelBuilder.Entity<DmrsModelSubview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMRS_MODEL_SUBVIEWS");

                entity.Property(e => e.DesignOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DESIGN_OVID");

                entity.Property(e => e.ModelId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_ID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_NAME");

                entity.Property(e => e.ModelOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_OVID");

                entity.Property(e => e.SubviewId)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("SUBVIEW_ID");

                entity.Property(e => e.SubviewName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SUBVIEW_NAME");

                entity.Property(e => e.SubviewOvid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SUBVIEW_OVID");
            });

            modelBuilder.Entity<DmrvReportsVersion10>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DMRV_REPORTS_VERSION_1_0");

                entity.Property(e => e.CreatedOn)
                    .HasPrecision(9)
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.DmrsPersistenceVersion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DMRS_PERSISTENCE_VERSION");

                entity.Property(e => e.DmrsReportsVersion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DMRS_REPORTS_VERSION");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.Departmentid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Employeet>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("EMP_PK");

                entity.ToTable("EMPLOYEET");

                entity.Property(e => e.Empid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EMPID");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Depid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phonenumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Employeets)
                    .HasForeignKey(d => d.Depid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("EMP_FK");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXAM");

                entity.Property(e => e.Courseid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COURSEID");

                entity.Property(e => e.Duration)
                    .HasPrecision(6)
                    .HasColumnName("DURATION");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Starttime)
                    .HasPrecision(6)
                    .HasColumnName("STARTTIME");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.FirstDescreption)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_DESCREPTION");

                entity.Property(e => e.FirstImgPath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_IMG_PATH");

                entity.Property(e => e.SecondDescreption)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SECOND_DESCREPTION");

                entity.Property(e => e.SecondImgPath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SECOND_IMG_PATH");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("SYS_C00168669");

                entity.ToTable("ITEM");

                entity.Property(e => e.ProId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRO_ID");

                entity.Property(e => e.ProCom)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRO_COM");

                entity.Property(e => e.ProName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRO_NAME");

                entity.Property(e => e.ProPrice)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRO_PRICE");
            });

            modelBuilder.Entity<Jordan>(entity =>
            {
                entity.ToTable("JORDAN");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("LOGIN");

                entity.HasIndex(e => new { e.Username, e.Password }, "LOGIN_UK1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ROLE_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERS_ID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("ORDERS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ORDER_DATE");

                entity.Property(e => e.State)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USER_ORDER_ID");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.ToTable("ORDER_PRODUCT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OrderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORDER_ID");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.State)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATE")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("PRODUCT_ID_FK");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ORDER_ID_FK");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("PAYMENT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Allowed)
                    .HasPrecision(1)
                    .HasColumnName("ALLOWED");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.OrderId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORDER_ID");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PAYMENT_DATE");

                entity.Property(e => e.SerialNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SERIAL_NO");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("PAYMENT_FK");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRICE");

                entity.Property(e => e.StoreId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STORE_ID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C00220648");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STORE_ID");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("PRODUCT_CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<RCustomer>(entity =>
            {
                entity.ToTable("R_CUSTOMER");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LNAME");
            });

            modelBuilder.Entity<RProduct>(entity =>
            {
                entity.ToTable("R_PRODUCT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Sale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALE");
            });

            modelBuilder.Entity<RProductCustomer>(entity =>
            {
                entity.ToTable("R_PRODUCT_CUSTOMER");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RProductCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK1_CUSTOMER_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RProductCustomers)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK1_PRODUCT_ID");
            });

            modelBuilder.Entity<RRole>(entity =>
            {
                entity.ToTable("R_ROLES");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("STORE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CATEGORY_ID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT");

                entity.Property(e => e.CId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("C_ID");

                entity.Property(e => e.Mark)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MARK");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Support>(entity =>
            {
                entity.ToTable("SUPPORT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Customerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Message)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");
            });

            modelBuilder.Entity<TAddress>(entity =>
            {
                entity.HasKey(e => e.Addressid)
                    .HasName("SYS_C00182941");

                entity.ToTable("T_ADDRESS");

                entity.HasIndex(e => e.Employeeid, "SYS_C00182942")
                    .IsUnique();

                entity.Property(e => e.Addressid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADDRESSID");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Employeeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEEID");

                entity.Property(e => e.Street)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STREET");

                entity.Property(e => e.Zipcode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ZIPCODE");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.TAddress)
                    .HasForeignKey<TAddress>(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ADDRESS_FK");
            });

            modelBuilder.Entity<TAuditing>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("SYS_C00183016");

                entity.ToTable("T_AUDITING");

                entity.Property(e => e.AuditId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AUDIT_ID");

                entity.Property(e => e.ByUser)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("BY_USER");

                entity.Property(e => e.TableName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.TarnsactionDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TARNSACTION_DATE");

                entity.Property(e => e.TarnsactionName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TARNSACTION_NAME");
            });

            modelBuilder.Entity<TContactInfo>(entity =>
            {
                entity.HasKey(e => e.Contactid)
                    .HasName("SYS_C00182944");

                entity.ToTable("T_CONTACT_INFO");

                entity.HasIndex(e => e.Employeeid, "SYS_C00182945")
                    .IsUnique();

                entity.Property(e => e.Contactid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTACTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Employeeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EMPLOYEEID");

                entity.Property(e => e.Phonenumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONENUMBER");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.TContactInfo)
                    .HasForeignKey<TContactInfo>(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("CONTACT_FK");
            });

            modelBuilder.Entity<TDepartment>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("DEPARTMENT_PK");

                entity.ToTable("T_DEPARTMENT");

                entity.Property(e => e.Deptid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPTID");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<TEmployee>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("SYS_C00182936");

                entity.ToTable("T_EMPLOYEE");

                entity.Property(e => e.Empid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EMPID");

                entity.Property(e => e.Depid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DEPID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.TEmployees)
                    .HasForeignKey(d => d.Depid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("EMPL_FK");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PostTime)
                    .HasPrecision(6)
                    .HasColumnName("POST_TIME");

                entity.Property(e => e.State)
                    .HasPrecision(1)
                    .HasColumnName("STATE");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USERS_TESTIMONIAL_ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.HasIndex(e => new { e.Email, e.PhoneNumber }, "USERS_UK1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("DATE")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONE_NUMBER");
            });

            modelBuilder.Entity<VStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_STUDENT");

                entity.Property(e => e.Mark)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MARK");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Visacard>(entity =>
            {
                entity.ToTable("VISACARD");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Cardnumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Customerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Expdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXPDATE");
            });

            modelBuilder.Entity<WebsitePage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WEBSITE_PAGES");

                entity.Property(e => e.AboutUsId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ABOUT_US_ID");

                entity.Property(e => e.ContactUsId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONTACT_US_ID");

                entity.Property(e => e.FirstTestimonial)
                    .HasColumnType("NUMBER")
                    .HasColumnName("FIRST_TESTIMONIAL");

                entity.Property(e => e.HomeId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("HOME_ID");

                entity.Property(e => e.InfoId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INFO_ID");

                entity.Property(e => e.SecondTestimonial)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SECOND_TESTIMONIAL");

                entity.Property(e => e.ThirdTestimonial)
                    .HasColumnType("NUMBER")
                    .HasColumnName("THIRD_TESTIMONIAL");

                entity.HasOne(d => d.FirstTestimonialNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FirstTestimonial)
                    .HasConstraintName("SYS_C00207210");

                entity.HasOne(d => d.SecondTestimonialNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SecondTestimonial)
                    .HasConstraintName("SYS_C00207211");

                entity.HasOne(d => d.ThirdTestimonialNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ThirdTestimonial)
                    .HasConstraintName("SYS_C00207212");
            });

            modelBuilder.HasSequence("DEPT_SQ");

            modelBuilder.HasSequence("J_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
