using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace poliklinikaApi.Models;

public partial class User84DbContext : DbContext
{
    public User84DbContext()
    {
    }

    public User84DbContext(DbContextOptions<User84DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abonementi> Abonementis { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Anketum> Anketa { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<ApplicationGood> ApplicationGoods { get; set; }

    public virtual DbSet<Apteka> Aptekas { get; set; }

    public virtual DbSet<Archiv> Archivs { get; set; }

    public virtual DbSet<AuditDoljnost> AuditDoljnosts { get; set; }

    public virtual DbSet<AuditUser> AuditUsers { get; set; }

    public virtual DbSet<Auditoriya> Auditoriyas { get; set; }

    public virtual DbSet<Avto> Avtos { get; set; }

    public virtual DbSet<Avtor> Avtors { get; set; }

    public virtual DbSet<AvtorKnigi> AvtorKnigis { get; set; }

    public virtual DbSet<AvtorKnigii> AvtorKnigiis { get; set; }

    public virtual DbSet<Avtori> Avtoris { get; set; }

    public virtual DbSet<Avtori1> Avtori1s { get; set; }

    public virtual DbSet<Avtorii> Avtoriis { get; set; }

    public virtual DbSet<Bilet> Bilets { get; set; }

    public virtual DbSet<CarBrand> CarBrands { get; set; }

    public virtual DbSet<CarOrder> CarOrders { get; set; }

    public virtual DbSet<CarSeller> CarSellers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Category1> Categories1 { get; set; }

    public virtual DbSet<Charity> Charities { get; set; }

    public virtual DbSet<Chitatel> Chitatels { get; set; }

    public virtual DbSet<ChitatelskiyBilet> ChitatelskiyBilets { get; set; }

    public virtual DbSet<ClassBooking> ClassBookings { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Client1> Client1s { get; set; }

    public virtual DbSet<Client2> Clients1 { get; set; }

    public virtual DbSet<Client2602> Client2602s { get; set; }

    public virtual DbSet<ClientImport> ClientImports { get; set; }

    public virtual DbSet<ClientMembership> ClientMemberships { get; set; }

    public virtual DbSet<ClientService> ClientServices { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

    public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }

    public virtual DbSet<Deliviry> Deliviries { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Disciplina> Disciplinas { get; set; }

    public virtual DbSet<Disciplina1> Disciplina1s { get; set; }

    public virtual DbSet<DisciplinaPrepodavatel> DisciplinaPrepodavatels { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<DocumentByService> DocumentByServices { get; set; }

    public virtual DbSet<Doljnostt> Doljnostts { get; set; }

    public virtual DbSet<DvdMovie> DvdMovies { get; set; }

    public virtual DbSet<Ekzempkyar> Ekzempkyars { get; set; }

    public virtual DbSet<Empl> Empls { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employees2> Employees2s { get; set; }

    public virtual DbSet<EmployerTerritory> EmployerTerritories { get; set; }

    public virtual DbSet<Erqfveq> Erqfveqs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<FamilyMember> FamilyMembers { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Fitneclub> Fitneclubs { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Genre1> Genre1s { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodType> GoodTypes { get; set; }

    public virtual DbSet<Goodss> Goodsses { get; set; }

    public virtual DbSet<Goroskop> Goroskops { get; set; }

    public virtual DbSet<GroupClass> GroupClasses { get; set; }

    public virtual DbSet<Grupp> Grupps { get; set; }

    public virtual DbSet<Gruppa1> Gruppa1s { get; set; }

    public virtual DbSet<Gruppaa> Gruppaas { get; set; }

    public virtual DbSet<Gruppi> Gruppis { get; set; }

    public virtual DbSet<Izdatelstva> Izdatelstvas { get; set; }

    public virtual DbSet<Izdatelstvo> Izdatelstvos { get; set; }

    public virtual DbSet<Janr> Janrs { get; set; }

    public virtual DbSet<Jewel> Jewels { get; set; }

    public virtual DbSet<JewelStorage> JewelStorages { get; set; }

    public virtual DbSet<JobTitle> JobTitles { get; set; }

    public virtual DbSet<Kabinet> Kabinets { get; set; }

    public virtual DbSet<KartaBolnogo> KartaBolnogos { get; set; }

    public virtual DbSet<Kategorii> Kategoriis { get; set; }

    public virtual DbSet<Kind> Kinds { get; set; }

    public virtual DbSet<Klassifikaciya> Klassifikaciyas { get; set; }

    public virtual DbSet<Klient> Klients { get; set; }

    public virtual DbSet<Klient1> Klient1s { get; set; }

    public virtual DbSet<Klienti> Klientis { get; set; }

    public virtual DbSet<Klientt> Klientts { get; set; }

    public virtual DbSet<Kniga> Knigas { get; set; }

    public virtual DbSet<Kniga1> Kniga1s { get; set; }

    public virtual DbSet<KnigaAvtor> KnigaAvtors { get; set; }

    public virtual DbSet<Knigi> Knigis { get; set; }

    public virtual DbSet<Knigii> Knigiis { get; set; }

    public virtual DbSet<KpPacienty> KpPacienties { get; set; }

    public virtual DbSet<KpPolzovateli> KpPolzovatelis { get; set; }

    public virtual DbSet<KpRaspisanie> KpRaspisanies { get; set; }

    public virtual DbSet<KpRezultatyPriema> KpRezultatyPriemas { get; set; }

    public virtual DbSet<KpRoli> KpRolis { get; set; }

    public virtual DbSet<KpSpecializacii> KpSpecializaciis { get; set; }

    public virtual DbSet<KpStatusVracha> KpStatusVrachas { get; set; }

    public virtual DbSet<KpStatusZapisi> KpStatusZapisis { get; set; }

    public virtual DbSet<KpUslugi> KpUslugis { get; set; }

    public virtual DbSet<KpUslugiZapisi> KpUslugiZapisis { get; set; }

    public virtual DbSet<KpVrachi> KpVrachis { get; set; }

    public virtual DbSet<KpZapisiNaPriem> KpZapisiNaPriems { get; set; }

    public virtual DbSet<Kurorti> Kurortis { get; set; }

    public virtual DbSet<Kuryer> Kuryers { get; set; }

    public virtual DbSet<Kuryer1> Kuryer1s { get; set; }

    public virtual DbSet<KuryerPvz> KuryerPvzs { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Lekarstva> Lekarstvas { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Marathon> Marathons { get; set; }

    public virtual DbSet<Marshrut> Marshruts { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Mdk0502StOrder> Mdk0502StOrders { get; set; }

    public virtual DbSet<Mdk0502StOrderProduct> Mdk0502StOrderProducts { get; set; }

    public virtual DbSet<Mdk0502StPickupPoint> Mdk0502StPickupPoints { get; set; }

    public virtual DbSet<Mdk0502StProduct> Mdk0502StProducts { get; set; }

    public virtual DbSet<Mdk0502StRole> Mdk0502StRoles { get; set; }

    public virtual DbSet<Mdk0502StUser> Mdk0502StUsers { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<Nomer> Nomers { get; set; }

    public virtual DbSet<NoviePredmeti> NoviePredmetis { get; set; }

    public virtual DbSet<OblastZnaniy> OblastZnaniys { get; set; }

    public virtual DbSet<Oceenki> Oceenkis { get; set; }

    public virtual DbSet<Ocenki> Ocenkis { get; set; }

    public virtual DbSet<Ocenkii> Ocenkiis { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Order1> Orders1 { get; set; }

    public virtual DbSet<OrderCafe> OrderCaves { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Otdel> Otdels { get; set; }

    public virtual DbSet<OtdelKadrov> OtdelKadrovs { get; set; }

    public virtual DbSet<Otdeleniye> Otdeleniyes { get; set; }

    public virtual DbSet<Pacient> Pacients { get; set; }

    public virtual DbSet<Passajir> Passajirs { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Performer> Performers { get; set; }

    public virtual DbSet<PersonalTraining> PersonalTrainings { get; set; }

    public virtual DbSet<Poezd> Poezds { get; set; }

    public virtual DbSet<Pokupatel> Pokupatels { get; set; }

    public virtual DbSet<PokupatelTovar> PokupatelTovars { get; set; }

    public virtual DbSet<Polushateli> Polushatelis { get; set; }

    public virtual DbSet<Poseshayemost> Poseshayemosts { get; set; }

    public virtual DbSet<PoseshayemostAprel> PoseshayemostAprels { get; set; }

    public virtual DbSet<PoseshayemostMart> PoseshayemostMarts { get; set; }

    public virtual DbSet<PoseshayemostMay> PoseshayemostMays { get; set; }

    public virtual DbSet<Postasvhik3> Postasvhik3s { get; set; }

    public virtual DbSet<Postavshik> Postavshiks { get; set; }

    public virtual DbSet<Postavshik1> Postavshik1s { get; set; }

    public virtual DbSet<Predmeti> Predmetis { get; set; }

    public virtual DbSet<Prepodavatel> Prepodavatels { get; set; }

    public virtual DbSet<Prepodovatel1> Prepodovatel1s { get; set; }

    public virtual DbSet<Prepodovateli> Prepodovatelis { get; set; }

    public virtual DbSet<Priem> Priems { get; set; }

    public virtual DbSet<ProdajaAbonementov> ProdajaAbonementovs { get; set; }

    public virtual DbSet<ProdajaTovara> ProdajaTovaras { get; set; }

    public virtual DbSet<Prodavec> Prodavecs { get; set; }

    public virtual DbSet<Prodavecc> Prodaveccs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Product1> Products1 { get; set; }

    public virtual DbSet<ProductPhoto> ProductPhotos { get; set; }

    public virtual DbSet<ProductSale> ProductSales { get; set; }

    public virtual DbSet<Products2> Products2s { get; set; }

    public virtual DbSet<Produkciya> Produkciyas { get; set; }

    public virtual DbSet<PunktVidachi> PunktVidachis { get; set; }

    public virtual DbSet<Putevki> Putevkis { get; set; }

    public virtual DbSet<QrProduct> QrProducts { get; set; }

    public virtual DbSet<RaceKitOption> RaceKitOptions { get; set; }

    public virtual DbSet<RashodMateriala> RashodMaterialas { get; set; }

    public virtual DbSet<Raspisaniye> Raspisaniyes { get; set; }

    public virtual DbSet<Raspisaniyee> Raspisaniyees { get; set; }

    public virtual DbSet<Razdeli> Razdelis { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<RegistrationEvent> RegistrationEvents { get; set; }

    public virtual DbSet<RegistrationStatus> RegistrationStatuses { get; set; }

    public virtual DbSet<Rejiseri> Rejiseris { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Role1> Role1s { get; set; }

    public virtual DbSet<Role11> Role1s1 { get; set; }

    public virtual DbSet<Role2> Roles1 { get; set; }

    public virtual DbSet<RoleAvt> RoleAvts { get; set; }

    public virtual DbSet<RoleCafe> RoleCaves { get; set; }

    public virtual DbSet<RoleJewel> RoleJewels { get; set; }

    public virtual DbSet<Rolee> Rolees { get; set; }

    public virtual DbSet<Roli> Rolis { get; set; }

    public virtual DbSet<Runner> Runners { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleProduct> SaleProducts { get; set; }

    public virtual DbSet<SaleService> SaleServices { get; set; }

    public virtual DbSet<Seller> Sellers { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Service1> Services1 { get; set; }

    public virtual DbSet<ServicePhoto> ServicePhotos { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Sklad> Sklads { get; set; }

    public virtual DbSet<Sorevnovaniya> Sorevnovaniyas { get; set; }

    public virtual DbSet<Sotrudnik> Sotrudniks { get; set; }

    public virtual DbSet<SotrudnikPvz> SotrudnikPvzs { get; set; }

    public virtual DbSet<Sotrudniki> Sotrudnikis { get; set; }

    public virtual DbSet<Sotrudnikii> Sotrudnikiis { get; set; }

    public virtual DbSet<SpisokKlientov> SpisokKlientovs { get; set; }

    public virtual DbSet<SpisokSotrudnikov> SpisokSotrudnikovs { get; set; }

    public virtual DbSet<SpisokTovarov> SpisokTovarovs { get; set; }

    public virtual DbSet<SpisokUslug> SpisokUslugs { get; set; }

    public virtual DbSet<Sponsorship> Sponsorships { get; set; }

    public virtual DbSet<Sportsmeni> Sportsmenis { get; set; }

    public virtual DbSet<Status1> Status1s { get; set; }

    public virtual DbSet<StatusCafe> StatusCaves { get; set; }

    public virtual DbSet<StatusTovara> StatusTovaras { get; set; }

    public virtual DbSet<StatusUser> StatusUsers { get; set; }

    public virtual DbSet<Statuss> Statusses { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<StorageBalance> StorageBalances { get; set; }

    public virtual DbSet<Storagee> Storagees { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreBalance> StoreBalances { get; set; }

    public virtual DbSet<Storekeeper> Storekeepers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student2> Student2s { get; set; }

    public virtual DbSet<Studenti> Studentis { get; set; }

    public virtual DbSet<Studentt> Studentts { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Supplierss> Suppliersses { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    public virtual DbSet<Tgrewhtew> Tgrewhtews { get; set; }

    public virtual DbSet<TipDocumentum> TipDocumenta { get; set; }

    public virtual DbSet<Titul> Tituls { get; set; }

    public virtual DbSet<Tovar> Tovars { get; set; }

    public virtual DbSet<Tovar1> Tovar1s { get; set; }

    public virtual DbSet<Tovar2> Tovar2s { get; set; }

    public virtual DbSet<Tovar3> Tovar3s { get; set; }

    public virtual DbSet<TovarSklad> TovarSklads { get; set; }

    public virtual DbSet<TovarZakaz> TovarZakazs { get; set; }

    public virtual DbSet<TovarZakaz11> TovarZakaz1s { get; set; }

    public virtual DbSet<Tovarzakaz1> Tovarzakazs1 { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<Trenera> Treneras { get; set; }

    public virtual DbSet<Trenirovki> Trenirovkis { get; set; }

    public virtual DbSet<TrudovayaKnijka> TrudovayaKnijkas { get; set; }

    public virtual DbSet<Up03Avtomobil> Up03Avtomobils { get; set; }

    public virtual DbSet<Up03Klient> Up03Klients { get; set; }

    public virtual DbSet<Up03Marka> Up03Markas { get; set; }

    public virtual DbSet<Up03Model> Up03Models { get; set; }

    public virtual DbSet<Up03Role> Up03Roles { get; set; }

    public virtual DbSet<Up03Sdelka> Up03Sdelkas { get; set; }

    public virtual DbSet<Up03Status> Up03Statuses { get; set; }

    public virtual DbSet<Up03User> Up03Users { get; set; }

    public virtual DbSet<Up05StRole> Up05StRoles { get; set; }

    public virtual DbSet<Up05StUser> Up05StUsers { get; set; }

    public virtual DbSet<Uprajneniya> Uprajneniyas { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> User1s { get; set; }

    public virtual DbSet<User11> User1s1 { get; set; }

    public virtual DbSet<User2> User2s { get; set; }

    public virtual DbSet<User3> Users1 { get; set; }

    public virtual DbSet<UserAvt1> UserAvt1s { get; set; }

    public virtual DbSet<UserCafe> UserCaves { get; set; }

    public virtual DbSet<UserFavorite> UserFavorites { get; set; }

    public virtual DbSet<Userr> Userrs { get; set; }

    public virtual DbSet<Userrr> Userrrs { get; set; }

    public virtual DbSet<UsersCd> UsersCds { get; set; }

    public virtual DbSet<Userstore> Userstores { get; set; }

    public virtual DbSet<UshetPosesheniy> UshetPosesheniys { get; set; }

    public virtual DbSet<Uslugi> Uslugis { get; set; }

    public virtual DbSet<Vagon> Vagons { get; set; }

    public virtual DbSet<VidRaboti> VidRabotis { get; set; }

    public virtual DbSet<VidTrenirovlki> VidTrenirovlkis { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<Volunteer> Volunteers { get; set; }

    public virtual DbSet<Vrach> Vraches { get; set; }

    public virtual DbSet<VremyaPari> VremyaParis { get; set; }

    public virtual DbSet<Waybill> Waybills { get; set; }

    public virtual DbSet<WaybillGood> WaybillGoods { get; set; }

    public virtual DbSet<Zadanie> Zadanies { get; set; }

    public virtual DbSet<Zakaz> Zakazs { get; set; }

    public virtual DbSet<Zakaz1> Zakaz1s { get; set; }

    public virtual DbSet<Zakaz2> Zakaz2s { get; set; }

    public virtual DbSet<Zakaz4> Zakaz4s { get; set; }

    public virtual DbSet<ZakazProdukciya> ZakazProdukciyas { get; set; }

    public virtual DbSet<Zakazhi> Zakazhis { get; set; }

    public virtual DbSet<Zakazi> Zakazis { get; set; }

    public virtual DbSet<Zanyatie1> Zanyatie1s { get; set; }

    public virtual DbSet<Zanyatiya> Zanyatiyas { get; set; }

    public virtual DbSet<Zayavka> Zayavkas { get; set; }

    public virtual DbSet<_0209Material> _0209Materials { get; set; }

    public virtual DbSet<_0209Produkciya> _0209Produkciyas { get; set; }

    public virtual DbSet<_0209Proizvodstvo> _0209Proizvodstvos { get; set; }

    public virtual DbSet<_0209RashodMaterialov> _0209RashodMaterialovs { get; set; }

    public virtual DbSet<_0209Specifikaciya> _0209Specifikaciyas { get; set; }

    public virtual DbSet<_0209Zakashiki> _0209Zakashikis { get; set; }

    public virtual DbSet<_0209Zakaz> _0209Zakazs { get; set; }

    public virtual DbSet<_0209ZakazProdukciya> _0209ZakazProdukciyas { get; set; }

    public virtual DbSet<_0302ArhivSotrudnikov> _0302ArhivSotrudnikovs { get; set; }

    public virtual DbSet<_0302Bolnichnye> _0302Bolnichnyes { get; set; }

    public virtual DbSet<_0302Dolzhnosti> _0302Dolzhnostis { get; set; }

    public virtual DbSet<_0302OcenkaKompetenciy> _0302OcenkaKompetenciys { get; set; }

    public virtual DbSet<_0302Podrazdeleniya> _0302Podrazdeleniyas { get; set; }

    public virtual DbSet<_0302ProizvodstvennyyKalendar> _0302ProizvodstvennyyKalendars { get; set; }

    public virtual DbSet<_0302RaschetnyeListki> _0302RaschetnyeListkis { get; set; }

    public virtual DbSet<_0302Role> _0302Roles { get; set; }

    public virtual DbSet<_0302ShtatnoeRaspisanie> _0302ShtatnoeRaspisanies { get; set; }

    public virtual DbSet<_0302Sotrudniki> _0302Sotrudnikis { get; set; }

    public virtual DbSet<_0302Tabel> _0302Tabels { get; set; }

    public virtual DbSet<_0302TipyOtpustov> _0302TipyOtpustovs { get; set; }

    public virtual DbSet<_0302User> _0302Users { get; set; }

    public virtual DbSet<_0302Zayavleniya> _0302Zayavleniyas { get; set; }

    public virtual DbSet<_0309Role> _0309Roles { get; set; }

    public virtual DbSet<_0309Role1> _0309Roles1 { get; set; }

    public virtual DbSet<_0309Status> _0309Statuses { get; set; }

    public virtual DbSet<_0309User> _0309Users { get; set; }

    public virtual DbSet<_0309User1> _0309Users1 { get; set; }

    public virtual DbSet<_0502Client> _0502Clients { get; set; }

    public virtual DbSet<_0502Client1> _0502Clients1 { get; set; }

    public virtual DbSet<_0502ClientService> _0502ClientServices { get; set; }

    public virtual DbSet<_0502DocumentByService> _0502DocumentByServices { get; set; }

    public virtual DbSet<_0502Gender> _0502Genders { get; set; }

    public virtual DbSet<_0502Manufacturer> _0502Manufacturers { get; set; }

    public virtual DbSet<_0502Product> _0502Products { get; set; }

    public virtual DbSet<_0502ProductPhoto> _0502ProductPhotos { get; set; }

    public virtual DbSet<_0502ProductSale> _0502ProductSales { get; set; }

    public virtual DbSet<_0502Service> _0502Services { get; set; }

    public virtual DbSet<_0502ServicePhoto> _0502ServicePhotos { get; set; }

    public virtual DbSet<_0502Tag> _0502Tags { get; set; }

    public virtual DbSet<_18090502Role> _18090502Roles { get; set; }

    public virtual DbSet<_1809Gruzoviki> _1809Gruzovikis { get; set; }

    public virtual DbSet<_1809Gruzoviki1> _1809Gruzovikis1 { get; set; }

    public virtual DbSet<_1809IstoriyaStatusov> _1809IstoriyaStatusovs { get; set; }

    public virtual DbSet<_1809Izbrannoe> _1809Izbrannoes { get; set; }

    public virtual DbSet<_1809Role> _1809Roles { get; set; }

    public virtual DbSet<_1809Role1> _1809Roles1 { get; set; }

    public virtual DbSet<_1809User> _1809Users { get; set; }

    public virtual DbSet<_1809User1> _1809Users1 { get; set; }

    public virtual DbSet<_1809Voditeli> _1809Voditelis { get; set; }

    public virtual DbSet<_1809Zakazy> _1809Zakazies { get; set; }

    public virtual DbSet<_1809ZhurnalAuditum> _1809ZhurnalAudita { get; set; }

    public virtual DbSet<_1809ZodiakSign> _1809ZodiakSigns { get; set; }

    public virtual DbSet<_1klient> _1klients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=stud-mssql.sttec.yar.ru,38325;Database=user84_db;User Id=user84_db;Password=user84;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        modelBuilder.Entity<Abonementi>(entity =>
        {
            entity.HasKey(e => e.IdAbonementa);

            entity.ToTable("Abonementi");

            entity.Property(e => e.IdAbonementa).HasColumnName("ID_Abonementa");
            entity.Property(e => e.Cena).HasColumnType("money");
            entity.Property(e => e.KolichestvoDney).HasColumnName("Kolichestvo_Dney");
            entity.Property(e => e.KolichestvoMesyacev).HasColumnName("Kolichestvo_Mesyacev");
            entity.Property(e => e.KolichestvoPosesheniy).HasColumnName("Kolichestvo_Posesheniy");
            entity.Property(e => e.VidTrenirovki).HasColumnName("Vid_Trenirovki");
            entity.Property(e => e.VidUslugi)
                .HasMaxLength(50)
                .HasColumnName("Vid_Uslugi");

            entity.HasOne(d => d.VidTrenirovkiNavigation).WithMany(p => p.Abonementis)
                .HasForeignKey(d => d.VidTrenirovki)
                .HasConstraintName("FK_Abonementi_Vid_Trenirovlki");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admin");

            entity.Property(e => e.IdAdmin).HasColumnName("ID_admin");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Anketum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Familiya)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gruppa).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(100);
            entity.Property(e => e.Otchestvo).HasMaxLength(100);
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.IdApplication);

            entity.ToTable("application");

            entity.Property(e => e.IdApplication).HasColumnName("ID_application");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Good).HasColumnName("good");
            entity.Property(e => e.IdUser).HasColumnName("ID_User");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Store).HasColumnName("store");

            entity.HasOne(d => d.GoodNavigation).WithMany(p => p.Applications)
                .HasForeignKey(d => d.Good)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_application_goodss");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Applications)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_application_manager");

            entity.HasOne(d => d.IdUser1).WithMany(p => p.Applications)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_application_userstore");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Applications)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_application_statuss");

            entity.HasOne(d => d.StoreNavigation).WithMany(p => p.Applications)
                .HasForeignKey(d => d.Store)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_application_store");
        });

        modelBuilder.Entity<ApplicationGood>(entity =>
        {
            entity.HasKey(e => e.IdApplicationGoods);

            entity.ToTable("applicationGoods");

            entity.Property(e => e.IdApplicationGoods).HasColumnName("ID_applicationGoods");
            entity.Property(e => e.IdApplication).HasColumnName("ID_application");
            entity.Property(e => e.IdGoods).HasColumnName("ID_goods");

            entity.HasOne(d => d.IdGoodsNavigation).WithMany(p => p.ApplicationGoods)
                .HasForeignKey(d => d.IdGoods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_applicationGoods_goodss");
        });

        modelBuilder.Entity<Apteka>(entity =>
        {
            entity.HasKey(e => e.IdApteki);

            entity.ToTable("Apteka");

            entity.Property(e => e.IdApteki).HasColumnName("ID_Apteki");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.IdLekarstva).HasColumnName("ID_Lekarstva");
            entity.Property(e => e.Telephone).HasMaxLength(50);

            entity.HasOne(d => d.IdLekarstvaNavigation).WithMany(p => p.Aptekas)
                .HasForeignKey(d => d.IdLekarstva)
                .HasConstraintName("FK_Apteka_Lekarstva");
        });

        modelBuilder.Entity<Archiv>(entity =>
        {
            entity.HasKey(e => e.IdArchiv);

            entity.ToTable("Archiv");

            entity.Property(e => e.IdArchiv)
                .ValueGeneratedNever()
                .HasColumnName("ID_Archiv");
            entity.Property(e => e.TrudovayaKnijka).HasColumnName("Trudovaya_knijka");

            entity.HasOne(d => d.TrudovayaKnijkaNavigation).WithMany(p => p.Archivs)
                .HasForeignKey(d => d.TrudovayaKnijka)
                .HasConstraintName("FK_Archiv_Trudovaya knijka");
        });

        modelBuilder.Entity<AuditDoljnost>(entity =>
        {
            entity.ToTable("audit_doljnost");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuditUser>(entity =>
        {
            entity.ToTable("audit_users");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DataRojdeniya).HasColumnName("data_rojdeniya");
            entity.Property(e => e.Doljnost).HasColumnName("doljnost");
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .HasColumnName("familiya");
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .HasColumnName("imya");
            entity.Property(e => e.MestoRojdeniya)
                .HasMaxLength(50)
                .HasColumnName("mesto_rojdeniya");
            entity.Property(e => e.Otchestvo)
                .HasMaxLength(50)
                .HasColumnName("otchestvo");

            entity.HasOne(d => d.DoljnostNavigation).WithMany(p => p.AuditUsers)
                .HasForeignKey(d => d.Doljnost)
                .HasConstraintName("FK_audit_users_audit_doljnost");
        });

        modelBuilder.Entity<Auditoriya>(entity =>
        {
            entity.HasKey(e => e.IdAuditorii);

            entity.ToTable("Auditoriya");

            entity.Property(e => e.IdAuditorii)
                .ValueGeneratedNever()
                .HasColumnName("ID_Auditorii");
            entity.Property(e => e.Nomer).HasMaxLength(50);
            entity.Property(e => e.Zdanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Avto>(entity =>
        {
            entity.HasKey(e => e.IdAvto);

            entity.ToTable("avto");

            entity.Property(e => e.IdAvto)
                .ValueGeneratedNever()
                .HasColumnName("id_avto");
            entity.Property(e => e.CarBrand).HasColumnName("car_brand");
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .HasColumnName("class");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Vin).HasColumnName("VIN");

            entity.HasOne(d => d.CarBrandNavigation).WithMany(p => p.Avtos)
                .HasForeignKey(d => d.CarBrand)
                .HasConstraintName("FK_avto_car_brand");
        });

        modelBuilder.Entity<Avtor>(entity =>
        {
            entity.HasKey(e => e.IdAvtora);

            entity.ToTable("Avtor");

            entity.Property(e => e.IdAvtora)
                .ValueGeneratedNever()
                .HasColumnName("ID_Avtora");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.GodiJizni)
                .HasMaxLength(50)
                .HasColumnName("Godi_jizni");
        });

        modelBuilder.Entity<AvtorKnigi>(entity =>
        {
            entity.HasKey(e => e.IdAvtKnigi).HasName("PK_Avtor_knigi_1");

            entity.ToTable("Avtor_knigi");

            entity.Property(e => e.IdAvtKnigi).HasColumnName("Id_avt_knigi");
            entity.Property(e => e.GonorarAvtora).HasColumnName("gonorar_avtora");
            entity.Property(e => e.IdAvtora).HasColumnName("id_avtora");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.PoryadkoviiNomer).HasColumnName("poryadkovii_nomer");

            entity.HasOne(d => d.IdAvtoraNavigation).WithMany(p => p.AvtorKnigis)
                .HasForeignKey(d => d.IdAvtora)
                .HasConstraintName("FK_Avtor_knigi_Avtori1");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.AvtorKnigis)
                .HasForeignKey(d => d.Isbn)
                .HasConstraintName("FK_Avtor_knigi_Knigi1");
        });

        modelBuilder.Entity<AvtorKnigii>(entity =>
        {
            entity.HasKey(e => e.IdAvtoraKnigi).HasName("PK_Avtor_Knigi");

            entity.ToTable("Avtor_Knigii");

            entity.Property(e => e.IdAvtoraKnigi).HasColumnName("ID_Avtora_Knigi");
            entity.Property(e => e.IdAvtora).HasColumnName("ID_Avtora");
            entity.Property(e => e.IdKnigi).HasColumnName("ID_Knigi");

            entity.HasOne(d => d.IdAvtoraNavigation).WithMany(p => p.AvtorKnigiis)
                .HasForeignKey(d => d.IdAvtora)
                .HasConstraintName("FK_Avtor_Knigi_Avtori");

            entity.HasOne(d => d.IdKnigiNavigation).WithMany(p => p.AvtorKnigiis)
                .HasForeignKey(d => d.IdKnigi)
                .HasConstraintName("FK_Avtor_Knigi_Knigi");
        });

        modelBuilder.Entity<Avtori>(entity =>
        {
            entity.HasKey(e => e.IdAvtora).HasName("PK_Avtori_1");

            entity.ToTable("Avtori");

            entity.Property(e => e.IdAvtora).HasColumnName("Id_avtora");
            entity.Property(e => e.AdresAvtora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adres_avtora");
            entity.Property(e => e.DataPaspAvt)
                .HasColumnType("datetime")
                .HasColumnName("data_pasp_avt");
            entity.Property(e => e.DomTelAvt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dom_tel_avt");
            entity.Property(e => e.FioAvtora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIO_avtora");
            entity.Property(e => e.GorodAvtora)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gorod_avtora");
            entity.Property(e => e.InnAvtora)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("INN_avtora");
            entity.Property(e => e.KontTelAvt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kont_tel_avt");
            entity.Property(e => e.MestPaspAvt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mest_pasp_avt");
            entity.Property(e => e.SnPaspAvt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sn_pasp_avt");
        });

        modelBuilder.Entity<Avtori1>(entity =>
        {
            entity.HasKey(e => e.IdAvtor);

            entity.ToTable("avtori1");

            entity.Property(e => e.IdAvtor)
                .ValueGeneratedNever()
                .HasColumnName("id_avtor");
            entity.Property(e => e.BirthYear)
                .HasMaxLength(50)
                .HasColumnName("birth_year");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
        });

        modelBuilder.Entity<Avtorii>(entity =>
        {
            entity.HasKey(e => e.IdAvtora).HasName("PK_Avtori");

            entity.ToTable("Avtorii");

            entity.Property(e => e.IdAvtora).HasColumnName("ID_Avtora");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Primechaniya).HasMaxLength(50);
        });

        modelBuilder.Entity<Bilet>(entity =>
        {
            entity.HasKey(e => e.IdBileta);

            entity.ToTable("Bilet");

            entity.Property(e => e.IdBileta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Bileta");
            entity.Property(e => e.DataOtpravleniya).HasColumnName("Data_otpravleniya");
            entity.Property(e => e.DataPokupki).HasColumnName("Data_pokupki");
            entity.Property(e => e.PunktNaznacheniya)
                .HasMaxLength(50)
                .HasColumnName("Punkt_naznacheniya");
            entity.Property(e => e.PunktOtpravleniya)
                .HasMaxLength(50)
                .HasColumnName("Punkt_otpravleniya");

            entity.HasOne(d => d.PassajirNavigation).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.Passajir)
                .HasConstraintName("FK_Bilet_Passajir");

            entity.HasOne(d => d.VagonNavigation).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.Vagon)
                .HasConstraintName("FK_Bilet_Vagon");
        });

        modelBuilder.Entity<CarBrand>(entity =>
        {
            entity.HasKey(e => e.IdCarBrand);

            entity.ToTable("car_brand");

            entity.Property(e => e.IdCarBrand)
                .ValueGeneratedNever()
                .HasColumnName("id_car_brand");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CarOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("car_order");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdAvto).HasColumnName("id_avto");
            entity.Property(e => e.IdCarOrder)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_car_order");
            entity.Property(e => e.IdSeller).HasColumnName("id_seller");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.IdAvtoNavigation).WithMany()
                .HasForeignKey(d => d.IdAvto)
                .HasConstraintName("FK_car_order_avto");

            entity.HasOne(d => d.IdSellerNavigation).WithMany()
                .HasForeignKey(d => d.IdSeller)
                .HasConstraintName("FK_car_order_car_seller");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_car_order_User_avt1");
        });

        modelBuilder.Entity<CarSeller>(entity =>
        {
            entity.HasKey(e => e.IdCarSeller);

            entity.ToTable("car_seller");

            entity.Property(e => e.IdCarSeller)
                .ValueGeneratedNever()
                .HasColumnName("id_car_seller");
            entity.Property(e => e.Adres)
                .HasMaxLength(50)
                .HasColumnName("adres");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Passport).HasColumnName("passport");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory);

            entity.Property(e => e.IdCategory).HasColumnName("ID_category");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.Picture).HasColumnType("image");
        });

        modelBuilder.Entity<Category1>(entity =>
        {
            entity.HasKey(e => e.IdCategory);

            entity.ToTable("category");

            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Charity>(entity =>
        {
            entity.HasKey(e => e.CharityId).HasName("pk_Charity");

            entity.ToTable("Charity");

            entity.Property(e => e.CharityDescription).HasMaxLength(2000);
            entity.Property(e => e.CharityLogo).HasMaxLength(50);
            entity.Property(e => e.CharityName).HasMaxLength(100);
        });

        modelBuilder.Entity<Chitatel>(entity =>
        {
            entity.HasKey(e => e.IdChitatel);

            entity.ToTable("Chitatel");

            entity.Property(e => e.IdChitatel)
                .ValueGeneratedNever()
                .HasColumnName("ID_chitatel");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.DataRojdeniya)
                .HasMaxLength(50)
                .HasColumnName("Data_rojdeniya");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<ChitatelskiyBilet>(entity =>
        {
            entity.HasKey(e => e.IdBileta);

            entity.ToTable("Chitatelskiy bilet");

            entity.Property(e => e.IdBileta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Bileta");
            entity.Property(e => e.IdChitatelya).HasColumnName("ID_Chitatelya");
            entity.Property(e => e.VidaniyiKnigi).HasColumnName("Vidaniyi_knigi");

            entity.HasOne(d => d.IdChitatelyaNavigation).WithMany(p => p.ChitatelskiyBilets)
                .HasForeignKey(d => d.IdChitatelya)
                .HasConstraintName("FK_Chitatelskiy bilet_Chitatel");

            entity.HasOne(d => d.VidaniyiKnigiNavigation).WithMany(p => p.ChitatelskiyBilets)
                .HasForeignKey(d => d.VidaniyiKnigi)
                .HasConstraintName("FK_Chitatelskiy bilet_Ekzempkyar");
        });

        modelBuilder.Entity<ClassBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Class_Bo__5DE3A5B1781BFB01");

            entity.ToTable("Class_Bookings");

            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("booking_date");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassBookings)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Class_Bookings_Group_Classes");

            entity.HasOne(d => d.Client).WithMany(p => p.ClassBookings)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Class_Bookings_Clients");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GenderCode)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

            entity.HasMany(d => d.Tags).WithMany(p => p.Clients)
                .UsingEntity<Dictionary<string, object>>(
                    "TagOfClient",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TagOfClient_Tag"),
                    l => l.HasOne<Client>().WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TagOfClient_Client"),
                    j =>
                    {
                        j.HasKey("ClientId", "TagId");
                        j.ToTable("TagOfClient");
                        j.IndexerProperty<int>("ClientId").HasColumnName("ClientID");
                        j.IndexerProperty<int>("TagId").HasColumnName("TagID");
                    });
        });

        modelBuilder.Entity<Client1>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.ToTable("Client1");

            entity.Property(e => e.IdClient)
                .ValueGeneratedNever()
                .HasColumnName("ID_Client");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_rojdeniya");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Client2>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Clients__BF21A424F079906A");

            entity.ToTable("Clients");

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Client2s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clients_User2");
        });

        modelBuilder.Entity<Client2602>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.ToTable("Client_26.02");

            entity.Property(e => e.IdClient).HasColumnName("ID_Client");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date_of_birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Client2602s)
                .HasForeignKey(d => d.Role)
                .HasConstraintName("FK_Client_26.02_Role_jewel");
        });

        modelBuilder.Entity<ClientImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("client_import");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Email");
            entity.Property(e => e.ДатаРегистрации)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Дата регистрации");
            entity.Property(e => e.ДатаРождения)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Дата рождения");
            entity.Property(e => e.Имя)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Имя");
            entity.Property(e => e.Отчество)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Отчество");
            entity.Property(e => e.Пол)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Пол");
            entity.Property(e => e.Телефон)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Телефон");
            entity.Property(e => e.Фамилия)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ФотографияКлиента)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName(" Фотография клиента");
        });

        modelBuilder.Entity<ClientMembership>(entity =>
        {
            entity.HasKey(e => e.ClientMembershipId).HasName("PK__Client_M__E9D9767A6E7A850E");

            entity.ToTable("Client_Memberships");

            entity.Property(e => e.ClientMembershipId).HasColumnName("client_membership_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.MembershipId).HasColumnName("membership_id");
            entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");
            entity.Property(e => e.RemainingVisits).HasColumnName("remaining_visits");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientMemberships)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_Memberships_Clients");

            entity.HasOne(d => d.Membership).WithMany(p => p.ClientMemberships)
                .HasForeignKey(d => d.MembershipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_Memberships_Memberships");
        });

        modelBuilder.Entity<ClientService>(entity =>
        {
            entity.ToTable("ClientService");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientServices)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientService_Client");

            entity.HasOne(d => d.Service).WithMany(p => p.ClientServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientService_Service");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.IdContact)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_contact");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryCode).HasName("pk_Country");

            entity.ToTable("Country");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.CountryFlag).HasMaxLength(100);
            entity.Property(e => e.CountryName).HasMaxLength(100);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTittle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);

            entity.HasOne(d => d.CustomerNavigation).WithOne(p => p.Customer)
                .HasForeignKey<Customer>(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_CustomerCustomerDemo");
        });

        modelBuilder.Entity<CustomerCustomerDemo>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("CustomerCustomerDemo");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerType)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.CustomerTypeNavigation).WithMany(p => p.CustomerCustomerDemos)
                .HasForeignKey(d => d.CustomerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerCustomerDemo_CustomerDemographics");
        });

        modelBuilder.Entity<CustomerDemographic>(entity =>
        {
            entity.HasKey(e => e.CustomerTypeId);

            entity.Property(e => e.CustomerTypeId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CustomerTypeID");
            entity.Property(e => e.CustomerDesc).HasColumnType("ntext");
        });

        modelBuilder.Entity<Deliviry>(entity =>
        {
            entity.HasKey(e => e.IdDelivery);

            entity.ToTable("deliviries");

            entity.Property(e => e.IdDelivery).HasColumnName("ID_delivery");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .HasColumnName("company_name");
            entity.Property(e => e.DeliviryDate).HasColumnName("deliviry_date");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.CompanyNameNavigation).WithMany(p => p.Deliviries)
                .HasForeignKey(d => d.CompanyName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_deliviries_supplierss");

            entity.HasOne(d => d.FilmNameNavigation).WithMany(p => p.Deliviries)
                .HasForeignKey(d => d.FilmName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_deliviries_DVD_movies");
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.DirectorLastName);

            entity.ToTable("director");

            entity.Property(e => e.DirectorLastName)
                .HasMaxLength(50)
                .HasColumnName("director_last_name");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .HasColumnName("education");
            entity.Property(e => e.FilmsCount).HasColumnName("films_count");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
        });

        modelBuilder.Entity<Disciplina>(entity =>
        {
            entity.HasKey(e => e.IdDisciplini);

            entity.ToTable("Disciplina");

            entity.Property(e => e.IdDisciplini).HasColumnName("ID_Disciplini");
            entity.Property(e => e.Nazvanie)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Disciplina1>(entity =>
        {
            entity.HasKey(e => e.IdDisciplina);

            entity.ToTable("disciplina1");

            entity.Property(e => e.IdDisciplina)
                .ValueGeneratedNever()
                .HasColumnName("id_disciplina");
            entity.Property(e => e.Nazvaniye)
                .HasMaxLength(50)
                .HasColumnName("nazvaniye");
        });

        modelBuilder.Entity<DisciplinaPrepodavatel>(entity =>
        {
            entity.HasKey(e => e.IdDisciplinaPrepodavatel);

            entity.ToTable("Disciplina_prepodavatel");

            entity.Property(e => e.IdDisciplinaPrepodavatel).HasColumnName("ID_Disciplina_prepodavatel");
            entity.Property(e => e.IdDisciplina).HasColumnName("ID_Disciplina");
            entity.Property(e => e.IdPrepodavatel).HasColumnName("ID_Prepodavatel");

            entity.HasOne(d => d.IdDisciplinaNavigation).WithMany(p => p.DisciplinaPrepodavatels)
                .HasForeignKey(d => d.IdDisciplina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Disciplina_prepodavatel_Disciplina");

            entity.HasOne(d => d.IdPrepodavatelNavigation).WithMany(p => p.DisciplinaPrepodavatels)
                .HasForeignKey(d => d.IdPrepodavatel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Disciplina_prepodavatel_Prepodavatel");
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasKey(e => e.IdDish);

            entity.ToTable("dish");

            entity.Property(e => e.IdDish).HasColumnName("id_dish");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Category).WithMany(p => p.Dishes)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dish_category");
        });

        modelBuilder.Entity<DocumentByService>(entity =>
        {
            entity.ToTable("DocumentByService");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientServiceId).HasColumnName("ClientServiceID");
            entity.Property(e => e.DocumentPath).HasMaxLength(1000);

            entity.HasOne(d => d.ClientService).WithMany(p => p.DocumentByServices)
                .HasForeignKey(d => d.ClientServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentByService_ClientService");
        });

        modelBuilder.Entity<Doljnostt>(entity =>
        {
            entity.HasKey(e => e.IdDoljnosti);

            entity.ToTable("Doljnostt");

            entity.Property(e => e.IdDoljnosti).HasColumnName("ID_Doljnosti");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<DvdMovie>(entity =>
        {
            entity.HasKey(e => e.FilmName);

            entity.ToTable("DVD_movies");

            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("Film_name");
            entity.Property(e => e.DirectorLastName)
                .HasMaxLength(50)
                .HasColumnName("director_last_name");
            entity.Property(e => e.DurationMin).HasColumnName("duration_min");
            entity.Property(e => e.IdGenre).HasColumnName("ID_genre");
            entity.Property(e => e.Language)
                .HasMaxLength(50)
                .HasColumnName("language");
            entity.Property(e => e.PerformerLastName)
                .HasMaxLength(50)
                .HasColumnName("performer_last_name");
            entity.Property(e => e.ReleaseDate).HasColumnName("release_date");

            entity.HasOne(d => d.DirectorLastNameNavigation).WithMany(p => p.DvdMovies)
                .HasForeignKey(d => d.DirectorLastName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVD_movies_director");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.DvdMovies)
                .HasForeignKey(d => d.IdGenre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVD_movies_genre");

            entity.HasOne(d => d.PerformerLastNameNavigation).WithMany(p => p.DvdMovies)
                .HasForeignKey(d => d.PerformerLastName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DVD_movies_performer");
        });

        modelBuilder.Entity<Ekzempkyar>(entity =>
        {
            entity.HasKey(e => e.IdEkzemplyara);

            entity.ToTable("Ekzempkyar");

            entity.Property(e => e.IdEkzemplyara)
                .ValueGeneratedNever()
                .HasColumnName("ID_ekzemplyara");
            entity.Property(e => e.IdKnigi).HasColumnName("ID_knigi");
            entity.Property(e => e.InventarniyNomer).HasColumnName("Inventarniy_nomer");
            entity.Property(e => e.Nalishie).HasMaxLength(50);
        });

        modelBuilder.Entity<Empl>(entity =>
        {
            entity.HasKey(e => e.IdEmp).HasName("PK__empl__2D4D3A235520C4BA");

            entity.ToTable("empl");

            entity.Property(e => e.IdEmp).HasColumnName("ID_Emp");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployerId);

            entity.Property(e => e.EmployerId).HasColumnName("EmployerID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.FirstName).HasMaxLength(10);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.HomePhone).HasMaxLength(24);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Notes).HasColumnType("ntext");
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.Tittle).HasMaxLength(30);
            entity.Property(e => e.TittleOfCountrys).HasMaxLength(25);
        });

        modelBuilder.Entity<Employees2>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__C52E0BA87DCD513D");

            entity.ToTable("Employees2");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Employees2s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees2_User2");
        });

        modelBuilder.Entity<EmployerTerritory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmployerId).HasColumnName("EmployerID");
            entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
        });

        modelBuilder.Entity<Erqfveq>(entity =>
        {
            entity.HasKey(e => e.Login).HasName("PK_User");

            entity.ToTable("erqfveq");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.Erqfveqs)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("pk_Event");

            entity.ToTable("Event");

            entity.Property(e => e.EventId)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EventName).HasMaxLength(50);
            entity.Property(e => e.EventTypeId)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.EventType).WithMany(p => p.Events)
                .HasForeignKey(d => d.EventTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_EventType");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.HasKey(e => e.EventTypeId).HasName("pk_EventType");

            entity.ToTable("EventType");

            entity.Property(e => e.EventTypeId)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.EventTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyMember>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.MemberName)
                .HasMaxLength(50)
                .HasColumnName("member_name");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.IdFilma);

            entity.Property(e => e.IdFilma).HasColumnName("ID_Filma");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);

            entity.HasOne(d => d.JanrNavigation).WithMany(p => p.Films)
                .HasForeignKey(d => d.Janr)
                .HasConstraintName("FK_Films_Janr");

            entity.HasOne(d => d.RejiserNavigation).WithMany(p => p.Films)
                .HasForeignKey(d => d.Rejiser)
                .HasConstraintName("FK_Films_Rejiseri");
        });

        modelBuilder.Entity<Fitneclub>(entity =>
        {
            entity.HasKey(e => e.IdFitnesclub);

            entity.ToTable("fitneclub");

            entity.Property(e => e.IdFitnesclub)
                .ValueGeneratedNever()
                .HasColumnName("id_fitnesclub");
            entity.Property(e => e.CloseHour).HasColumnName("close_hour");
            entity.Property(e => e.OpeningHour).HasColumnName("opening_hour");
            entity.Property(e => e.RegistrationLimits).HasColumnName("registration_limits");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Gender1).HasName("pk_Gender");

            entity.ToTable("Gender");

            entity.Property(e => e.Gender1)
                .HasMaxLength(10)
                .HasColumnName("Gender");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.IdGenre);

            entity.ToTable("genre");

            entity.Property(e => e.IdGenre).HasColumnName("ID_genre");
            entity.Property(e => e.NameOfGenre)
                .HasMaxLength(50)
                .HasColumnName("name_of_genre");
            entity.Property(e => e.PlaceOfApperance)
                .HasMaxLength(50)
                .HasColumnName("place_of_apperance");
            entity.Property(e => e.YearOfAppearance).HasColumnName("year_of_appearance");
        });

        modelBuilder.Entity<Genre1>(entity =>
        {
            entity.HasKey(e => e.IdGenre);

            entity.ToTable("genre1");

            entity.Property(e => e.IdGenre)
                .ValueGeneratedNever()
                .HasColumnName("id_genre");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.Property(e => e.GoodId).HasColumnName("good_id");
            entity.Property(e => e.GoodName)
                .HasMaxLength(50)
                .HasColumnName("good_name");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Goods)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Goods_GoodTypes");
        });

        modelBuilder.Entity<GoodType>(entity =>
        {
            entity.Property(e => e.GoodTypeId).HasColumnName("good_type_id");
            entity.Property(e => e.GoodTypeName)
                .HasMaxLength(50)
                .HasColumnName("good_type_name");
        });

        modelBuilder.Entity<Goodss>(entity =>
        {
            entity.HasKey(e => e.IdGoods);

            entity.ToTable("goodss");

            entity.Property(e => e.IdGoods).HasColumnName("ID_goods");
            entity.Property(e => e.Measure)
                .HasMaxLength(50)
                .HasColumnName("measure");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Goroskop>(entity =>
        {
            entity.HasKey(e => e.IdGoroskop);

            entity.ToTable("goroskop");

            entity.Property(e => e.IdGoroskop)
                .ValueGeneratedNever()
                .HasColumnName("id_goroskop");
            entity.Property(e => e.IdZodiak).HasColumnName("id_zodiak");
            entity.Property(e => e.Text).HasColumnName("text");

            entity.HasOne(d => d.IdZodiakNavigation).WithMany(p => p.Goroskops)
                .HasForeignKey(d => d.IdZodiak)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_goroskop_18.09_zodiakSign");
        });

        modelBuilder.Entity<GroupClass>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Group_Cl__FDF4798637CAEB44");

            entity.ToTable("Group_Classes");

            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.ClassDate).HasColumnName("class_date");
            entity.Property(e => e.DurationMin).HasColumnName("duration_min");
            entity.Property(e => e.MaxParticipants).HasColumnName("max_participants");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.TrainerId).HasColumnName("trainer_id");

            entity.HasOne(d => d.Trainer).WithMany(p => p.GroupClasses)
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_Classes_Trainers");
        });

        modelBuilder.Entity<Grupp>(entity =>
        {
            entity.HasKey(e => e.IdGrupps);

            entity.Property(e => e.IdGrupps).HasColumnName("ID_Grupps");
            entity.Property(e => e.Nazvanie)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gruppa1>(entity =>
        {
            entity.HasKey(e => e.IdGruppa);

            entity.ToTable("gruppa1");

            entity.Property(e => e.IdGruppa)
                .ValueGeneratedNever()
                .HasColumnName("id_gruppa");
            entity.Property(e => e.Nazvaniye)
                .HasMaxLength(50)
                .HasColumnName("nazvaniye");
            entity.Property(e => e.Student).HasColumnName("student");

            entity.HasOne(d => d.StudentNavigation).WithMany(p => p.Gruppa1s)
                .HasForeignKey(d => d.Student)
                .HasConstraintName("FK_gruppa1_student2");
        });

        modelBuilder.Entity<Gruppaa>(entity =>
        {
            entity.HasKey(e => e.IdGruppa);

            entity.ToTable("Gruppaa");

            entity.Property(e => e.IdGruppa).HasColumnName("ID_Gruppa");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);

            entity.HasOne(d => d.OtdelenieNavigation).WithMany(p => p.Gruppaas)
                .HasForeignKey(d => d.Otdelenie)
                .HasConstraintName("FK_Gruppaa_Otdeleniye");
        });

        modelBuilder.Entity<Gruppi>(entity =>
        {
            entity.HasKey(e => e.IdGruppi);

            entity.ToTable("Gruppi");

            entity.Property(e => e.IdGruppi)
                .ValueGeneratedNever()
                .HasColumnName("ID_Gruppi");
            entity.Property(e => e.Fakultet).HasMaxLength(50);
            entity.Property(e => e.Nomer).HasMaxLength(50);
            entity.Property(e => e.Specialnost).HasMaxLength(50);
        });

        modelBuilder.Entity<Izdatelstva>(entity =>
        {
            entity.HasKey(e => e.IdIzdatelstva);

            entity.ToTable("Izdatelstva");

            entity.Property(e => e.IdIzdatelstva).HasColumnName("ID_Izdatelstva");
            entity.Property(e => e.Gorod).HasMaxLength(50);
            entity.Property(e => e.Izdatelstvo).HasMaxLength(50);
        });

        modelBuilder.Entity<Izdatelstvo>(entity =>
        {
            entity.HasKey(e => e.IdIzdatelstvo);

            entity.ToTable("izdatelstvo");

            entity.Property(e => e.IdIzdatelstvo)
                .ValueGeneratedNever()
                .HasColumnName("id_izdatelstvo");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Janr>(entity =>
        {
            entity.HasKey(e => e.IdJanra);

            entity.ToTable("Janr");

            entity.Property(e => e.IdJanra).HasColumnName("ID_Janra");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Jewel>(entity =>
        {
            entity.HasKey(e => e.IdJewel);

            entity.ToTable("Jewel");

            entity.Property(e => e.IdJewel).HasColumnName("ID_Jewel");
            entity.Property(e => e.Cost).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.KindNavigation).WithMany(p => p.Jewels)
                .HasForeignKey(d => d.Kind)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jewel_Kind");

            entity.HasOne(d => d.MaterialNavigation).WithMany(p => p.Jewels)
                .HasForeignKey(d => d.Material)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jewel_Material");
        });

        modelBuilder.Entity<JewelStorage>(entity =>
        {
            entity.HasKey(e => e.IdJewelStorage);

            entity.ToTable("JewelStorage");

            entity.Property(e => e.IdJewelStorage).HasColumnName("ID_JewelStorage");
            entity.Property(e => e.IdJewel).HasColumnName("ID_Jewel");
            entity.Property(e => e.IdStorage).HasColumnName("ID_Storage");

            entity.HasOne(d => d.IdJewelNavigation).WithMany(p => p.JewelStorages)
                .HasForeignKey(d => d.IdJewel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JewelStorage_Jewel");

            entity.HasOne(d => d.IdStorageNavigation).WithMany(p => p.JewelStorages)
                .HasForeignKey(d => d.IdStorage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JewelStorage_Storage");
        });

        modelBuilder.Entity<JobTitle>(entity =>
        {
            entity.HasKey(e => e.IdJobTitle);

            entity.ToTable("Job_title");

            entity.Property(e => e.IdJobTitle).HasColumnName("ID_Job_title");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Kabinet>(entity =>
        {
            entity.HasKey(e => e.NomerKabineta);

            entity.ToTable("Kabinet");

            entity.Property(e => e.NomerKabineta)
                .ValueGeneratedNever()
                .HasColumnName("Nomer_Kabineta");
            entity.Property(e => e.Naznacheniya).HasMaxLength(50);
        });

        modelBuilder.Entity<KartaBolnogo>(entity =>
        {
            entity.HasKey(e => e.IdKarti);

            entity.ToTable("Karta_bolnogo");

            entity.Property(e => e.IdKarti)
                .ValueGeneratedNever()
                .HasColumnName("ID_Karti");
            entity.Property(e => e.Diagnoz).HasMaxLength(50);
            entity.Property(e => e.Lekarstvo).HasMaxLength(50);
            entity.Property(e => e.Simptomi).HasMaxLength(50);
        });

        modelBuilder.Entity<Kategorii>(entity =>
        {
            entity.HasKey(e => e.IdKategorii);

            entity.ToTable("Kategorii");

            entity.Property(e => e.IdKategorii).HasColumnName("Id_kategorii");
            entity.Property(e => e.NameKategorii)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Name_kategorii");
        });

        modelBuilder.Entity<Kind>(entity =>
        {
            entity.HasKey(e => e.IdKind);

            entity.ToTable("Kind");

            entity.Property(e => e.IdKind).HasColumnName("ID_Kind");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Klassifikaciya>(entity =>
        {
            entity.HasKey(e => e.IdKlassifikacii);

            entity.ToTable("Klassifikaciya");

            entity.Property(e => e.IdKlassifikacii).HasColumnName("ID_Klassifikacii");
            entity.Property(e => e.Zvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Klient>(entity =>
        {
            entity.HasKey(e => e.IdKlient);

            entity.ToTable("Klient");

            entity.Property(e => e.IdKlient)
                .ValueGeneratedNever()
                .HasColumnName("ID_Klient");
            entity.Property(e => e.Adress).HasMaxLength(50);
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.ProcentSkidki).HasColumnName("Procent_Skidki");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Klient1>(entity =>
        {
            entity.HasKey(e => e.IdKilent);

            entity.ToTable("klient1");

            entity.Property(e => e.IdKilent).HasColumnName("ID_Kilent");
            entity.Property(e => e.DataRojdenie).HasColumnName("Data_Rojdenie");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.MedicinskiyPolis)
                .HasMaxLength(50)
                .HasColumnName("Medicinskiy_Polis");
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Passport).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role).HasDefaultValue(2);
            entity.Property(e => e.Snils)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("SNILS");
        });

        modelBuilder.Entity<Klienti>(entity =>
        {
            entity.HasKey(e => e.IdKlienta);

            entity.ToTable("Klienti");

            entity.Property(e => e.IdKlienta).HasColumnName("ID_Klienta");
            entity.Property(e => e.DataOformleniya).HasColumnName("Data_oformleniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.IdPutevki).HasColumnName("ID_Putevki");
            entity.Property(e => e.IdRole).HasColumnName("ID_Role");
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Kommentarii).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.NomerPassporta).HasColumnName("Nomer_Passporta");
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdPutevkiNavigation).WithMany(p => p.Klientis)
                .HasForeignKey(d => d.IdPutevki)
                .HasConstraintName("FK_Klienti_Putevki");
        });

        modelBuilder.Entity<Klientt>(entity =>
        {
            entity.HasKey(e => e.IdKlienta);

            entity.ToTable("Klientt");

            entity.Property(e => e.IdKlienta).HasColumnName("ID_Klienta");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
        });

        modelBuilder.Entity<Kniga>(entity =>
        {
            entity.HasKey(e => e.IdKnigi);

            entity.ToTable("Kniga");

            entity.Property(e => e.IdKnigi)
                .ValueGeneratedNever()
                .HasColumnName("ID_Knigi");
            entity.Property(e => e.GodIzdaniya)
                .HasMaxLength(50)
                .HasColumnName("God_izdaniya");
            entity.Property(e => e.Izdatelstvo).HasMaxLength(50);
            entity.Property(e => e.KolichestvoEzkemplyarovVBiblioteke).HasColumnName("Kolichestvo_ezkemplyarov_v_biblioteke");
            entity.Property(e => e.KolvoStranic)
                .HasMaxLength(50)
                .HasColumnName("Kolvo_stranic");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.OblastZnaniy).HasColumnName("Oblast_znaniy");

            entity.HasOne(d => d.OblastZnaniyNavigation).WithMany(p => p.Knigas)
                .HasForeignKey(d => d.OblastZnaniy)
                .HasConstraintName("FK_Kniga_Oblast znaniy");
        });

        modelBuilder.Entity<Kniga1>(entity =>
        {
            entity.HasKey(e => e.IdKniga);

            entity.ToTable("kniga1");

            entity.Property(e => e.IdKniga)
                .ValueGeneratedNever()
                .HasColumnName("id_kniga");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.IdAvtor).HasColumnName("id_avtor");
            entity.Property(e => e.IdGenre).HasColumnName("id_genre");
            entity.Property(e => e.IdIzdatelstvo).HasColumnName("id_izdatelstvo");
            entity.Property(e => e.IdLanguage).HasColumnName("id_language");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.IdAvtorNavigation).WithMany(p => p.Kniga1s)
                .HasForeignKey(d => d.IdAvtor)
                .HasConstraintName("FK_kniga1_avtori1");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.Kniga1s)
                .HasForeignKey(d => d.IdGenre)
                .HasConstraintName("FK_kniga1_genre1");

            entity.HasOne(d => d.IdIzdatelstvoNavigation).WithMany(p => p.Kniga1s)
                .HasForeignKey(d => d.IdIzdatelstvo)
                .HasConstraintName("FK_kniga1_izdatelstvo");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Kniga1s)
                .HasForeignKey(d => d.IdLanguage)
                .HasConstraintName("FK_kniga1_language");
        });

        modelBuilder.Entity<KnigaAvtor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kniga avtor");

            entity.Property(e => e.IdAvtor).HasColumnName("ID_Avtor");
            entity.Property(e => e.IdKniga).HasColumnName("ID_Kniga");

            entity.HasOne(d => d.IdAvtorNavigation).WithMany()
                .HasForeignKey(d => d.IdAvtor)
                .HasConstraintName("FK_kniga avtor_Avtor");

            entity.HasOne(d => d.IdKnigaNavigation).WithMany()
                .HasForeignKey(d => d.IdKniga)
                .HasConstraintName("FK_kniga avtor_Kniga");
        });

        modelBuilder.Entity<Knigi>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK_Knigi_1");

            entity.ToTable("Knigi");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Annotaciya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("annotaciya");
            entity.Property(e => e.AvtorskiiZnak)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("avtorskii_znak");
            entity.Property(e => e.CenaExemplyara).HasColumnName("cena_exemplyara");
            entity.Property(e => e.IdKategorii).HasColumnName("id_kategorii");
            entity.Property(e => e.Izdanie)
                .HasMaxLength(50)
                .HasColumnName("izdanie");
            entity.Property(e => e.KolichestvoStranic).HasColumnName("kolichestvo_stranic");
            entity.Property(e => e.NazvanieKnigi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazvanie_knigi");
            entity.Property(e => e.Tirag).HasColumnName("tirag");

            entity.HasOne(d => d.IdKategoriiNavigation).WithMany(p => p.Knigis)
                .HasForeignKey(d => d.IdKategorii)
                .HasConstraintName("FK_Knigi_Kategorii");
        });

        modelBuilder.Entity<Knigii>(entity =>
        {
            entity.HasKey(e => e.IdKnigi).HasName("PK_Knigi");

            entity.ToTable("Knigii");

            entity.Property(e => e.IdKnigi).HasColumnName("ID_Knigi");
            entity.Property(e => e.GodIzdaniya).HasColumnName("God_Izdaniya");
            entity.Property(e => e.KolVoShtukAbon).HasColumnName("Kol_vo_Shtuk_Abon");
            entity.Property(e => e.KolVoShtukChitZal).HasColumnName("Kol_vo_Shtuk_Chit_Zal");
            entity.Property(e => e.MestoHraneniya)
                .HasMaxLength(50)
                .HasColumnName("Mesto_Hraneniya");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);

            entity.HasOne(d => d.IzdatelstvoNavigation).WithMany(p => p.Knigiis)
                .HasForeignKey(d => d.Izdatelstvo)
                .HasConstraintName("FK_Knigi_Izdatelstva");

            entity.HasOne(d => d.RazdelNavigation).WithMany(p => p.Knigiis)
                .HasForeignKey(d => d.Razdel)
                .HasConstraintName("FK_Knigi_Razdeli");
        });

        modelBuilder.Entity<KpPacienty>(entity =>
        {
            entity.HasKey(e => e.KodPacienta).HasName("PK__KP_Pacie__709A67BB4036A1AE");

            entity.ToTable("KP_Pacienty");

            entity.HasIndex(e => e.NomerPolisa, "UQ__KP_Pacie__BC98226CBB819C48").IsUnique();

            entity.Property(e => e.KodPacienta).HasColumnName("Kod_pacienta");
            entity.Property(e => e.Adres).HasMaxLength(200);
            entity.Property(e => e.DataRozhdeniya).HasColumnName("Data_rozhdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(150);
            entity.Property(e => e.Imya).HasMaxLength(150);
            entity.Property(e => e.NomerPolisa)
                .HasMaxLength(16)
                .HasColumnName("Nomer_polisa");
            entity.Property(e => e.Otchestvo).HasMaxLength(150);
            entity.Property(e => e.Pol).HasMaxLength(10);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<KpPolzovateli>(entity =>
        {
            entity.HasKey(e => e.KodPolzovatelya).HasName("PK__KP_Polzo__6BB94A34964DAF09");

            entity.ToTable("KP_Polzovateli");

            entity.HasIndex(e => e.Login, "UQ__KP_Polzo__5E55825BB1B5A7B5").IsUnique();

            entity.Property(e => e.KodPolzovatelya).HasColumnName("Kod_polzovatelya");
            entity.Property(e => e.KodRoli).HasColumnName("Kod_roli");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Parol).HasMaxLength(100);

            entity.HasOne(d => d.KodRoliNavigation).WithMany(p => p.KpPolzovatelis)
                .HasForeignKey(d => d.KodRoli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Polzov__Kod_r__430CD787");
        });

        modelBuilder.Entity<KpRaspisanie>(entity =>
        {
            entity.HasKey(e => e.KodSlota).HasName("PK__KP_Raspi__D52C8A36A1F79B23");

            entity.ToTable("KP_Raspisanie");

            entity.Property(e => e.KodSlota).HasColumnName("Kod_slota");
            entity.Property(e => e.DataPriema).HasColumnName("Data_priema");
            entity.Property(e => e.KodVracha).HasColumnName("Kod_vracha");
            entity.Property(e => e.VremyaNachala).HasColumnName("Vremya_nachala");
            entity.Property(e => e.VremyaOkonchaniya).HasColumnName("Vremya_okonchaniya");

            entity.HasOne(d => d.KodVrachaNavigation).WithMany(p => p.KpRaspisanies)
                .HasForeignKey(d => d.KodVracha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Raspis__Kod_v__5066D2A5");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.KpRaspisanies)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_KP_Raspisanie_KP_Status_Vracha");
        });

        modelBuilder.Entity<KpRezultatyPriema>(entity =>
        {
            entity.HasKey(e => e.KodRezultata).HasName("PK__KP_Rezul__368CF746891CC477");

            entity.ToTable("KP_Rezultaty_priema");

            entity.HasIndex(e => e.KodZapisi, "UQ__KP_Rezul__656C912170D23426").IsUnique();

            entity.Property(e => e.KodRezultata).HasColumnName("Kod_rezultata");
            entity.Property(e => e.Diagnoz).HasMaxLength(255);
            entity.Property(e => e.KodZapisi).HasColumnName("Kod_zapisi");

            entity.HasOne(d => d.KodZapisiNavigation).WithOne(p => p.KpRezultatyPriema)
                .HasForeignKey<KpRezultatyPriema>(d => d.KodZapisi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Rezult__Kod_z__5BD88551");
        });

        modelBuilder.Entity<KpRoli>(entity =>
        {
            entity.HasKey(e => e.KodRoli).HasName("PK__KP_Roli__F968E47F4547686B");

            entity.ToTable("KP_Roli");

            entity.HasIndex(e => e.NazvanieRoli, "UQ__KP_Roli__320D451A51B54B25").IsUnique();

            entity.Property(e => e.KodRoli).HasColumnName("Kod_roli");
            entity.Property(e => e.NazvanieRoli)
                .HasMaxLength(50)
                .HasColumnName("Nazvanie_roli");
        });

        modelBuilder.Entity<KpSpecializacii>(entity =>
        {
            entity.HasKey(e => e.KodSpecializacii).HasName("PK__KP_Speci__DC5DB90094C5C394");

            entity.ToTable("KP_Specializacii");

            entity.Property(e => e.KodSpecializacii).HasColumnName("Kod_specializacii");
            entity.Property(e => e.NazvanieSpecializacii)
                .HasMaxLength(100)
                .HasColumnName("Nazvanie_specializacii");
        });

        modelBuilder.Entity<KpStatusVracha>(entity =>
        {
            entity.HasKey(e => e.KodStatusa);

            entity.ToTable("KP_Status_Vracha");

            entity.Property(e => e.KodStatusa).HasColumnName("Kod_Statusa");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<KpStatusZapisi>(entity =>
        {
            entity.HasKey(e => e.KodStatusa);

            entity.ToTable("KP_Status_zapisi");

            entity.Property(e => e.KodStatusa).HasColumnName("Kod_Statusa");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<KpUslugi>(entity =>
        {
            entity.HasKey(e => e.KodUslugi);

            entity.ToTable("KP_Uslugi");

            entity.Property(e => e.KodUslugi).HasColumnName("Kod_uslugi");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<KpUslugiZapisi>(entity =>
        {
            entity.HasKey(e => e.KodUslugiZapisi);

            entity.ToTable("KP_Uslugi_Zapisi");

            entity.Property(e => e.KodUslugiZapisi).HasColumnName("Kod_uslugi_zapisi");
            entity.Property(e => e.KodUslugi).HasColumnName("Kod_Uslugi");
            entity.Property(e => e.KodZapisi).HasColumnName("Kod_Zapisi");

            entity.HasOne(d => d.KodUslugiNavigation).WithMany(p => p.KpUslugiZapisis)
                .HasForeignKey(d => d.KodUslugi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KP_Uslugi_Zapisi_KP_Uslugi");

            entity.HasOne(d => d.KodZapisiNavigation).WithMany(p => p.KpUslugiZapisis)
                .HasForeignKey(d => d.KodZapisi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KP_Uslugi_Zapisi_KP_Zapisi_na_priem");
        });

        modelBuilder.Entity<KpVrachi>(entity =>
        {
            entity.HasKey(e => e.KodVracha).HasName("PK__KP_Vrach__643F75EB0287A85F");

            entity.ToTable("KP_Vrachi");

            entity.Property(e => e.KodVracha).HasColumnName("Kod_vracha");
            entity.Property(e => e.Familiya).HasMaxLength(150);
            entity.Property(e => e.Imya).HasMaxLength(150);
            entity.Property(e => e.KodPolzovatelya).HasColumnName("Kod_polzovatelya");
            entity.Property(e => e.KodSpecializacii).HasColumnName("Kod_specializacii");
            entity.Property(e => e.NomerKabineta)
                .HasMaxLength(10)
                .HasColumnName("Nomer_kabineta");
            entity.Property(e => e.Otchestvo).HasMaxLength(150);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.KodPolzovatelyaNavigation).WithMany(p => p.KpVrachis)
                .HasForeignKey(d => d.KodPolzovatelya)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Vrachi__Kod_p__47D18CA4");

            entity.HasOne(d => d.KodSpecializaciiNavigation).WithMany(p => p.KpVrachis)
                .HasForeignKey(d => d.KodSpecializacii)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Vrachi__Kod_s__48C5B0DD");
        });

        modelBuilder.Entity<KpZapisiNaPriem>(entity =>
        {
            entity.HasKey(e => e.KodZapisi).HasName("PK__KP_Zapis__656C912064146882");

            entity.ToTable("KP_Zapisi_na_priem");

            entity.HasIndex(e => e.KodSlota, "UQ__KP_Zapis__D52C8A37D69B25C6").IsUnique();

            entity.Property(e => e.KodZapisi).HasColumnName("Kod_zapisi");
            entity.Property(e => e.DataSozdaniya)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Data_sozdaniya");
            entity.Property(e => e.KodPacienta).HasColumnName("Kod_pacienta");
            entity.Property(e => e.KodSlota).HasColumnName("Kod_slota");
            entity.Property(e => e.StatusZapisi)
                .HasDefaultValueSql("('Zaplanirovana')")
                .HasColumnName("Status_zapisi");

            entity.HasOne(d => d.KodPacientaNavigation).WithMany(p => p.KpZapisiNaPriems)
                .HasForeignKey(d => d.KodPacienta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Zapisi__Kod_p__5713D034");

            entity.HasOne(d => d.KodSlotaNavigation).WithOne(p => p.KpZapisiNaPriem)
                .HasForeignKey<KpZapisiNaPriem>(d => d.KodSlota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KP_Zapisi__Kod_s__5807F46D");

            entity.HasOne(d => d.StatusZapisiNavigation).WithMany(p => p.KpZapisiNaPriems)
                .HasForeignKey(d => d.StatusZapisi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KP_Zapisi_na_priem_KP_Status_zapisi");
        });

        modelBuilder.Entity<Kurorti>(entity =>
        {
            entity.HasKey(e => e.IdKurorta);

            entity.ToTable("Kurorti");

            entity.Property(e => e.IdKurorta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Kurorta");
            entity.Property(e => e.Kommentarii).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Raspolojenie).HasMaxLength(50);
            entity.Property(e => e.Strana).HasMaxLength(50);
        });

        modelBuilder.Entity<Kuryer>(entity =>
        {
            entity.HasKey(e => e.IdKuryer);

            entity.ToTable("Kuryer");

            entity.Property(e => e.IdKuryer)
                .ValueGeneratedNever()
                .HasColumnName("ID_kuryer");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Telephone).HasMaxLength(50);

            entity.HasOne(d => d.ZakazNavigation).WithMany(p => p.Kuryers)
                .HasForeignKey(d => d.Zakaz)
                .HasConstraintName("FK_Kuryer_Zakaz1");
        });

        modelBuilder.Entity<Kuryer1>(entity =>
        {
            entity.HasKey(e => e.IdKuryer);

            entity.ToTable("Kuryer1");

            entity.Property(e => e.IdKuryer)
                .ValueGeneratedNever()
                .HasColumnName("ID_Kuryer");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.Transport).HasMaxLength(50);

            entity.HasOne(d => d.ZakazNavigation).WithMany(p => p.Kuryer1s)
                .HasForeignKey(d => d.Zakaz)
                .HasConstraintName("FK_Kuryer1_Zakaz2");
        });

        modelBuilder.Entity<KuryerPvz>(entity =>
        {
            entity.HasKey(e => e.IdKuryerPvz);

            entity.ToTable("KuryerPvz");

            entity.Property(e => e.IdKuryerPvz)
                .ValueGeneratedNever()
                .HasColumnName("ID_kuryerPvz");
            entity.Property(e => e.IdKuryer).HasColumnName("ID_Kuryer");
            entity.Property(e => e.IdPvz).HasColumnName("ID_Pvz");

            entity.HasOne(d => d.IdKuryerNavigation).WithMany(p => p.KuryerPvzs)
                .HasForeignKey(d => d.IdKuryer)
                .HasConstraintName("FK_KuryerPvz_Kuryer");

            entity.HasOne(d => d.IdPvzNavigation).WithMany(p => p.KuryerPvzs)
                .HasForeignKey(d => d.IdPvz)
                .HasConstraintName("FK_KuryerPvz_Punkt vidachi");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.IdLanguage);

            entity.ToTable("language");

            entity.Property(e => e.IdLanguage)
                .ValueGeneratedNever()
                .HasColumnName("id_language");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Lekarstva>(entity =>
        {
            entity.HasKey(e => e.IdLekarstva);

            entity.ToTable("Lekarstva");

            entity.Property(e => e.IdLekarstva).HasColumnName("ID_Lekarstva");
            entity.Property(e => e.CenaLekarstva)
                .HasColumnType("money")
                .HasColumnName("Cena_Lekarstva");
            entity.Property(e => e.Kategoriya).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.IdManager);

            entity.ToTable("manager");

            entity.Property(e => e.IdManager).HasColumnName("ID_manager");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.ToTable("Manufacturer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Marathon>(entity =>
        {
            entity.HasKey(e => e.MarathonId).HasName("pk_Marathon");

            entity.ToTable("Marathon");

            entity.Property(e => e.MarathonId).ValueGeneratedOnAdd();
            entity.Property(e => e.CityName).HasMaxLength(80);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.MarathonName).HasMaxLength(80);
        });

        modelBuilder.Entity<Marshrut>(entity =>
        {
            entity.HasKey(e => e.IdMarshrut);

            entity.ToTable("Marshrut");

            entity.Property(e => e.IdMarshrut)
                .ValueGeneratedNever()
                .HasColumnName("ID_Marshrut");
            entity.Property(e => e.PunktNaznacheniya)
                .HasMaxLength(50)
                .HasColumnName("Punkt_Naznacheniya");
            entity.Property(e => e.PunktOtpravleniya)
                .HasMaxLength(50)
                .HasColumnName("Punkt_Otpravleniya");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.IdMaterial);

            entity.ToTable("Material");

            entity.Property(e => e.IdMaterial).HasColumnName("ID_Material");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Mdk0502StOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__MDK0502___C3905BAFCC799DE9");

            entity.ToTable("MDK0502_ST_Order");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.OrderPickupPointNavigation).WithMany(p => p.Mdk0502StOrders)
                .HasForeignKey(d => d.OrderPickupPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDK0502_ST_Order_MDK0502_ST_PickupPoint");

            entity.HasOne(d => d.User).WithMany(p => p.Mdk0502StOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Order_User");
        });

        modelBuilder.Entity<Mdk0502StOrderProduct>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductArticleNumber }).HasName("PK__MDK0502___817A26626571C96B");

            entity.ToTable("MDK0502_ST_OrderProduct");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasDefaultValue(1);

            entity.HasOne(d => d.Order).WithMany(p => p.Mdk0502StOrderProducts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MDK0502_S__Order__5748DA5E");

            entity.HasOne(d => d.ProductArticleNumberNavigation).WithMany(p => p.Mdk0502StOrderProducts)
                .HasForeignKey(d => d.ProductArticleNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MDK0502_S__Produ__583CFE97");
        });

        modelBuilder.Entity<Mdk0502StPickupPoint>(entity =>
        {
            entity.HasKey(e => e.PickupPointId).HasName("PK__MDK0502___195D7E80C856F14F");

            entity.ToTable("MDK0502_ST_PickupPoint");

            entity.Property(e => e.PickupPointId).HasColumnName("PickupPointID");
        });

        modelBuilder.Entity<Mdk0502StProduct>(entity =>
        {
            entity.HasKey(e => e.ProductArticleNumber).HasName("PK__MDK0502___2EA7DCD56BB57780");

            entity.ToTable("MDK0502_ST_Product");

            entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);
            entity.Property(e => e.ProductCost).HasColumnType("decimal(19, 4)");
        });

        modelBuilder.Entity<Mdk0502StRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__MDK0502___8AFACE3AB41AE608");

            entity.ToTable("MDK0502_ST_Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<Mdk0502StUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__MDK0502___1788CCACC3F92AD9");

            entity.ToTable("MDK0502_ST_User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserPatronymic).HasMaxLength(100);
            entity.Property(e => e.UserSurname).HasMaxLength(100);

            entity.HasOne(d => d.UserRoleNavigation).WithMany(p => p.Mdk0502StUsers)
                .HasForeignKey(d => d.UserRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MDK0502_S__UserR__509BDCCF");
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.MembershipId).HasName("PK__Membersh__CAE49DDD34D766D1");

            entity.Property(e => e.MembershipId).HasColumnName("membership_id");
            entity.Property(e => e.DurationDays).HasColumnName("duration_days");
            entity.Property(e => e.MaxVisits).HasColumnName("max_visits");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PriceRub).HasColumnName("price_rub");
        });

        modelBuilder.Entity<Nomer>(entity =>
        {
            entity.HasKey(e => e.IdNomera);

            entity.ToTable("Nomer");

            entity.Property(e => e.IdNomera)
                .ValueGeneratedNever()
                .HasColumnName("ID_Nomera");
            entity.Property(e => e.AdressGostinici)
                .HasMaxLength(50)
                .HasColumnName("Adress_Gostinici");
            entity.Property(e => e.Haracteristika).HasMaxLength(50);
            entity.Property(e => e.KolvoMest).HasColumnName("Kolvo_mest");
            entity.Property(e => e.StoimostSutki)
                .HasMaxLength(50)
                .HasColumnName("Stoimost_Sutki");
            entity.Property(e => e.TipNomera)
                .HasMaxLength(50)
                .HasColumnName("Tip_Nomera");
        });

        modelBuilder.Entity<NoviePredmeti>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Novie_Predmeti");

            entity.Property(e => e.IdPredmeta).HasColumnName("ID_Predmeta");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Prepodovatel).HasMaxLength(50);
        });

        modelBuilder.Entity<OblastZnaniy>(entity =>
        {
            entity.HasKey(e => e.IdOblastZnaniy);

            entity.ToTable("Oblast znaniy");

            entity.Property(e => e.IdOblastZnaniy)
                .ValueGeneratedNever()
                .HasColumnName("ID_Oblast_znaniy");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Oceenki>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Oceenki");

            entity.Property(e => e.IdPredmeta).HasColumnName("ID_Predmeta");
            entity.Property(e => e.IdStudenta).HasColumnName("ID_Studenta");
            entity.Property(e => e.Ocenki).HasMaxLength(50);
        });

        modelBuilder.Entity<Ocenki>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ocenki");

            entity.Property(e => e.IdPredmeta).HasColumnName("ID_Predmeta");
            entity.Property(e => e.IdStudenta).HasColumnName("ID_Studenta");
            entity.Property(e => e.Ocenka)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPredmetaNavigation).WithMany()
                .HasForeignKey(d => d.IdPredmeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ocenki_Predmeti");

            entity.HasOne(d => d.IdStudentaNavigation).WithMany()
                .HasForeignKey(d => d.IdStudenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ocenki_Studenti");
        });

        modelBuilder.Entity<Ocenkii>(entity =>
        {
            entity.HasKey(e => e.IdOcenki);

            entity.ToTable("ocenkii");

            entity.Property(e => e.IdOcenki).HasColumnName("ID_Ocenki");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DisciplinaId).HasColumnName("Disciplina_id");
            entity.Property(e => e.PrepodavatelId).HasColumnName("Prepodavatel_id");
            entity.Property(e => e.StudentId).HasColumnName("Student_id");

            entity.HasOne(d => d.Disciplina).WithMany(p => p.Ocenkiis)
                .HasForeignKey(d => d.DisciplinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ocenkii_Disciplina");

            entity.HasOne(d => d.Prepodavatel).WithMany(p => p.Ocenkiis)
                .HasForeignKey(d => d.PrepodavatelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ocenkii_Prepodavatel");

            entity.HasOne(d => d.Student).WithMany(p => p.Ocenkiis)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ocenkii_STUDENT");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order");

            entity.Property(e => e.IdOrder).HasColumnName("ID_Order");
            entity.Property(e => e.IdClient).HasColumnName("ID_Client");
            entity.Property(e => e.IdJewel).HasColumnName("ID_Jewel");
            entity.Property(e => e.IdSeller).HasColumnName("ID_Seller");
            entity.Property(e => e.SaleTime)
                .HasColumnType("datetime")
                .HasColumnName("Sale_time");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Client_26.02");

            entity.HasOne(d => d.IdJewelNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdJewel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Jewel");

            entity.HasOne(d => d.IdSellerNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdSeller)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Seller");
        });

        modelBuilder.Entity<Order1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Orders");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.EmployerId).HasColumnName("EmployerID");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Orderdate).HasColumnType("datetime");
            entity.Property(e => e.ShipAdress).HasMaxLength(60);
            entity.Property(e => e.ShipCity).HasMaxLength(15);
            entity.Property(e => e.ShipCountry).HasMaxLength(15);
            entity.Property(e => e.ShipName).HasMaxLength(40);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShipRegion).HasMaxLength(15);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrderCafe>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("order_cafe");

            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.TotalSum).HasColumnName("total_sum");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Status).WithMany(p => p.OrderCaves)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_order_cafe_status_cafe");

            entity.HasOne(d => d.User).WithMany(p => p.OrderCaves)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_order_cafe_user_cafe");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order Details");

            entity.Property(e => e.IdOrder).HasColumnName("ID_Order");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.IdOrderItem);

            entity.ToTable("orderItem");

            entity.Property(e => e.IdOrderItem).HasColumnName("id_orderItem");
            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Dish).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orderItem_dish");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orderItem_order_cafe");
        });

        modelBuilder.Entity<Otdel>(entity =>
        {
            entity.HasKey(e => e.IdOtdela);

            entity.ToTable("Otdel");

            entity.Property(e => e.IdOtdela).HasColumnName("ID_Otdela");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);

            entity.HasOne(d => d.RukovoditelNavigation).WithMany(p => p.OtdelRukovoditelNavigations)
                .HasForeignKey(d => d.Rukovoditel)
                .HasConstraintName("FK_Otdel_Sotrudnikii1");

            entity.HasOne(d => d.SotrudnikiNavigation).WithMany(p => p.OtdelSotrudnikiNavigations)
                .HasForeignKey(d => d.Sotrudniki)
                .HasConstraintName("FK_Otdel_Sotrudnikii");
        });

        modelBuilder.Entity<OtdelKadrov>(entity =>
        {
            entity.HasKey(e => e.IdOtdelaKadrov);

            entity.ToTable("Otdel Kadrov");

            entity.Property(e => e.IdOtdelaKadrov)
                .ValueGeneratedNever()
                .HasColumnName("ID_Otdela_Kadrov");
            entity.Property(e => e.Adres).HasMaxLength(50);

            entity.HasOne(d => d.ArchivNavigation).WithMany(p => p.OtdelKadrovs)
                .HasForeignKey(d => d.Archiv)
                .HasConstraintName("FK_Otdel Kadrov_Archiv");
        });

        modelBuilder.Entity<Otdeleniye>(entity =>
        {
            entity.HasKey(e => e.IdOtdeleniya);

            entity.ToTable("Otdeleniye");

            entity.Property(e => e.IdOtdeleniya)
                .ValueGeneratedNever()
                .HasColumnName("ID_Otdeleniya");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Zaveduchaya).HasMaxLength(50);
        });

        modelBuilder.Entity<Pacient>(entity =>
        {
            entity.HasKey(e => e.NomerPolisa);

            entity.ToTable("Pacient");

            entity.Property(e => e.NomerPolisa)
                .ValueGeneratedNever()
                .HasColumnName("Nomer_Polisa");
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_Rojdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.IdKarti).HasColumnName("ID_Karti");
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdKartiNavigation).WithMany(p => p.Pacients)
                .HasForeignKey(d => d.IdKarti)
                .HasConstraintName("FK_Pacient_Karta_bolnogo");
        });

        modelBuilder.Entity<Passajir>(entity =>
        {
            entity.HasKey(e => e.IdPassajira);

            entity.ToTable("Passajir");

            entity.Property(e => e.IdPassajira)
                .ValueGeneratedNever()
                .HasColumnName("ID_Passajira");
            entity.Property(e => e.Fio).HasColumnName("FIO");
            entity.Property(e => e.TipDocumenta).HasColumnName("Tip_Documenta");

            entity.HasOne(d => d.TipDocumentaNavigation).WithMany(p => p.Passajirs)
                .HasForeignKey(d => d.TipDocumenta)
                .HasConstraintName("FK_Passajir_Tip_Documenta");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.FamilyMember).HasColumnName("family_member");
            entity.Property(e => e.Good).HasColumnName("good");

            entity.HasOne(d => d.FamilyMemberNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FamilyMember)
                .HasConstraintName("FK_Payments_FamilyMembers");

            entity.HasOne(d => d.GoodNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.Good)
                .HasConstraintName("FK_Payments_Goods");
        });

        modelBuilder.Entity<Performer>(entity =>
        {
            entity.HasKey(e => e.LastName);

            entity.ToTable("performer");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.BegininngOfCareer).HasColumnName("begininng_of_career");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .HasColumnName("education");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PersonalTraining>(entity =>
        {
            entity.HasKey(e => e.TrainingId).HasName("PK__Personal__2F28D08F4FD879C3");

            entity.ToTable("Personal_Trainings");

            entity.Property(e => e.TrainingId).HasColumnName("training_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("request_date");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.TrainerId).HasColumnName("trainer_id");

            entity.HasOne(d => d.Trainer).WithMany(p => p.PersonalTrainings)
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personal_Trainings_Trainers");
        });

        modelBuilder.Entity<Poezd>(entity =>
        {
            entity.HasKey(e => e.IdPoezda);

            entity.ToTable("Poezd");

            entity.Property(e => e.IdPoezda)
                .ValueGeneratedNever()
                .HasColumnName("ID_Poezda");
            entity.Property(e => e.DataOtpravleniya).HasColumnName("Data_Otpravleniya");

            entity.HasOne(d => d.MarshrutNavigation).WithMany(p => p.Poezds)
                .HasForeignKey(d => d.Marshrut)
                .HasConstraintName("FK_Poezd_Marshrut");
        });

        modelBuilder.Entity<Pokupatel>(entity =>
        {
            entity.HasKey(e => e.IdPokupatelya);

            entity.ToTable("Pokupatel");

            entity.Property(e => e.IdPokupatelya).HasColumnName("ID_Pokupatelya");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<PokupatelTovar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pokupatel_Tovar");

            entity.Property(e => e.IdPokupatel).HasColumnName("ID_Pokupatel");
            entity.Property(e => e.IdPokupatelTovar)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Pokupatel_Tovar");
            entity.Property(e => e.IdTovar).HasColumnName("ID_Tovar");

            entity.HasOne(d => d.IdPokupatelNavigation).WithMany()
                .HasForeignKey(d => d.IdPokupatel)
                .HasConstraintName("FK_Pokupatel_Tovar_Pokupatel");

            entity.HasOne(d => d.IdTovarNavigation).WithMany()
                .HasForeignKey(d => d.IdTovar)
                .HasConstraintName("FK_Pokupatel_Tovar_Tovar3");
        });

        modelBuilder.Entity<Polushateli>(entity =>
        {
            entity.HasKey(e => e.IdPolushatel);

            entity.ToTable("Polushateli");

            entity.Property(e => e.IdPolushatel).HasColumnName("ID_Polushatel");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.IdGoroda).HasColumnName("ID_Goroda");
            entity.Property(e => e.Organizaciya).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Poseshayemost>(entity =>
        {
            entity.HasKey(e => e.IdStudenta).HasName("PK__Poseshay__D7AC0B13F2B7E5A2");

            entity.ToTable("Poseshayemost");

            entity.Property(e => e.IdStudenta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Studenta");
            entity.Property(e => e.NeuvajitelniyePropuski)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("neuvajitelniye_propuski");
            entity.Property(e => e.UvajitelniyePropuski)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uvajitelniye_propuski");
        });

        modelBuilder.Entity<PoseshayemostAprel>(entity =>
        {
            entity.HasKey(e => e.IdStudenta);

            entity.ToTable("Poseshayemost_Aprel");

            entity.Property(e => e.IdStudenta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Studenta");
            entity.Property(e => e.NeuvajitelniyePropuski).HasColumnName("neuvajitelniye_propuski");
            entity.Property(e => e.UvajitelniyePropuski).HasColumnName("uvajitelniye_propuski");
        });

        modelBuilder.Entity<PoseshayemostMart>(entity =>
        {
            entity.HasKey(e => e.IdStudenta);

            entity.ToTable("Poseshayemost_mart");

            entity.Property(e => e.IdStudenta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Studenta");
            entity.Property(e => e.NeuvajitelniyePropuski).HasColumnName("neuvajitelniye_propuski");
            entity.Property(e => e.UvajitelniyePropuski).HasColumnName("uvajitelniye_propuski");
        });

        modelBuilder.Entity<PoseshayemostMay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Poseshayemost_May");

            entity.Property(e => e.IdStudenta).HasColumnName("ID_Studenta");
            entity.Property(e => e.NeuvajitelniyePropuski).HasColumnName("neuvajitelniye_propuski");
            entity.Property(e => e.UvajitelniyePropuski).HasColumnName("uvajitelniye_propuski");
        });

        modelBuilder.Entity<Postasvhik3>(entity =>
        {
            entity.HasKey(e => e.IdPostasvshik);

            entity.ToTable("Postasvhik3");

            entity.Property(e => e.IdPostasvshik).HasColumnName("ID_Postasvshik");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Postavshik>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Postavshik");

            entity.Property(e => e.IdPostavshik).HasColumnName("ID_Postavshik");
            entity.Property(e => e.Kontakti).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Postavshik1>(entity =>
        {
            entity.HasKey(e => e.IdPostavshika);

            entity.ToTable("Postavshik1");

            entity.Property(e => e.IdPostavshika)
                .ValueGeneratedNever()
                .HasColumnName("ID_Postavshika");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Predmeti>(entity =>
        {
            entity.HasKey(e => e.IdPredmeta).HasName("PK__Predmeti__07F286ED6A170979");

            entity.ToTable("Predmeti");

            entity.Property(e => e.IdPredmeta).HasColumnName("ID_Predmeta");
            entity.Property(e => e.Nazvanie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prepodovatel)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prepodavatel>(entity =>
        {
            entity.HasKey(e => e.IdPrepodovatelya);

            entity.ToTable("Prepodavatel");

            entity.Property(e => e.IdPrepodovatelya).HasColumnName("ID_Prepodovatelya");
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Otchestvo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<Prepodovatel1>(entity =>
        {
            entity.HasKey(e => e.IdPrepodovatel);

            entity.ToTable("prepodovatel1");

            entity.Property(e => e.IdPrepodovatel)
                .ValueGeneratedNever()
                .HasColumnName("id_prepodovatel");
            entity.Property(e => e.Adres)
                .HasMaxLength(50)
                .HasColumnName("adres");
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .HasColumnName("familiya");
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .HasColumnName("imya");
            entity.Property(e => e.Otchestvo)
                .HasMaxLength(50)
                .HasColumnName("otchestvo");
        });

        modelBuilder.Entity<Prepodovateli>(entity =>
        {
            entity.HasKey(e => e.IdPrepodovatelya);

            entity.ToTable("Prepodovateli");

            entity.Property(e => e.IdPrepodovatelya)
                .ValueGeneratedNever()
                .HasColumnName("ID_Prepodovatelya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
        });

        modelBuilder.Entity<Priem>(entity =>
        {
            entity.HasKey(e => e.IdPriema);

            entity.ToTable("Priem");

            entity.Property(e => e.IdPriema)
                .ValueGeneratedNever()
                .HasColumnName("ID_Priema");
            entity.Property(e => e.DataVremyaPriema)
                .HasColumnType("datetime")
                .HasColumnName("Data_vremya_priema");
            entity.Property(e => e.IdVracha).HasColumnName("ID_Vracha");
            entity.Property(e => e.NomerKabineta).HasColumnName("Nomer_Kabineta");
            entity.Property(e => e.NomerPolisa).HasColumnName("Nomer_Polisa");

            entity.HasOne(d => d.IdVrachaNavigation).WithMany(p => p.Priems)
                .HasForeignKey(d => d.IdVracha)
                .HasConstraintName("FK_Priem_Vrach1");

            entity.HasOne(d => d.NomerKabinetaNavigation).WithMany(p => p.Priems)
                .HasForeignKey(d => d.NomerKabineta)
                .HasConstraintName("FK_Priem_Kabinet");

            entity.HasOne(d => d.NomerPolisaNavigation).WithMany(p => p.Priems)
                .HasForeignKey(d => d.NomerPolisa)
                .HasConstraintName("FK_Priem_Pacient");
        });

        modelBuilder.Entity<ProdajaAbonementov>(entity =>
        {
            entity.HasKey(e => e.NomerKarti);

            entity.ToTable("Prodaja_Abonementov");

            entity.Property(e => e.NomerKarti).HasColumnName("Nomer_Karti");
            entity.Property(e => e.DataNachala).HasColumnName("Data_Nachala");
            entity.Property(e => e.DataOkonshaniya).HasColumnName("Data_Okonshaniya");
            entity.Property(e => e.IdAbonementa).HasColumnName("ID_Abonementa");
            entity.Property(e => e.IdKlienta).HasColumnName("ID_Klienta");
            entity.Property(e => e.KolishestvoOstasvhihsyaPosesheniy).HasColumnName("Kolishestvo_Ostasvhihsya_Posesheniy");

            entity.HasOne(d => d.IdAbonementaNavigation).WithMany(p => p.ProdajaAbonementovs)
                .HasForeignKey(d => d.IdAbonementa)
                .HasConstraintName("FK_Prodaja_Abonementov_Abonementi");

            entity.HasOne(d => d.IdKlientaNavigation).WithMany(p => p.ProdajaAbonementovs)
                .HasForeignKey(d => d.IdKlienta)
                .HasConstraintName("FK_Prodaja_Abonementov_Spisok klientov");
        });

        modelBuilder.Entity<ProdajaTovara>(entity =>
        {
            entity.HasKey(e => e.NomerProdaji);

            entity.ToTable("Prodaja_Tovara");

            entity.Property(e => e.NomerProdaji).HasColumnName("Nomer_Prodaji");
            entity.Property(e => e.IdKlienta).HasColumnName("ID_Klienta");
            entity.Property(e => e.IdTovara).HasColumnName("ID_Tovara");

            entity.HasOne(d => d.IdKlientaNavigation).WithMany(p => p.ProdajaTovaras)
                .HasForeignKey(d => d.IdKlienta)
                .HasConstraintName("FK_Prodaja_Tovara_Spisok klientov");

            entity.HasOne(d => d.IdTovaraNavigation).WithMany(p => p.ProdajaTovaras)
                .HasForeignKey(d => d.IdTovara)
                .HasConstraintName("FK_Prodaja_Tovara_Spisok_Tovarov");
        });

        modelBuilder.Entity<Prodavec>(entity =>
        {
            entity.HasKey(e => e.IdProdavec);

            entity.ToTable("Prodavec");

            entity.Property(e => e.IdProdavec)
                .ValueGeneratedNever()
                .HasColumnName("ID_Prodavec");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Prodavecc>(entity =>
        {
            entity.HasKey(e => e.IdProdavca);

            entity.ToTable("Prodavecc");

            entity.Property(e => e.IdProdavca).HasColumnName("ID_Prodavca");
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.MainImagePath).HasMaxLength(1000);
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Product_Manufacturer");

            entity.HasMany(d => d.AttachedProducts).WithMany(p => p.MainProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "AttachedProduct",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("AttachedProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AttachedProduct_Product1"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("MainProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AttachedProduct_Product"),
                    j =>
                    {
                        j.HasKey("MainProductId", "AttachedProductId");
                        j.ToTable("AttachedProduct");
                        j.IndexerProperty<int>("MainProductId").HasColumnName("MainProductID");
                        j.IndexerProperty<int>("AttachedProductId").HasColumnName("AttachedProductID");
                    });

            entity.HasMany(d => d.MainProducts).WithMany(p => p.AttachedProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "AttachedProduct",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("MainProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AttachedProduct_Product"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("AttachedProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AttachedProduct_Product1"),
                    j =>
                    {
                        j.HasKey("MainProductId", "AttachedProductId");
                        j.ToTable("AttachedProduct");
                        j.IndexerProperty<int>("MainProductId").HasColumnName("MainProductID");
                        j.IndexerProperty<int>("AttachedProductId").HasColumnName("AttachedProductID");
                    });
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity.HasKey(e => e.IdProduct);

            entity.ToTable("Products");

            entity.Property(e => e.IdProduct).HasColumnName("ID_product");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Category).WithMany(p => p.Product1s)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Product1s)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");
        });

        modelBuilder.Entity<ProductPhoto>(entity =>
        {
            entity.ToTable("ProductPhoto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPhotos)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductPhoto_Product");
        });

        modelBuilder.Entity<ProductSale>(entity =>
        {
            entity.ToTable("ProductSale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientServiceId).HasColumnName("ClientServiceID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SaleDate).HasColumnType("datetime");

            entity.HasOne(d => d.ClientService).WithMany(p => p.ProductSales)
                .HasForeignKey(d => d.ClientServiceId)
                .HasConstraintName("FK_ProductSale_ClientService");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSales)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_ProductSale_Product");
        });

        modelBuilder.Entity<Products2>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__47027DF5C3151306");

            entity.ToTable("Products2");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PriceRub).HasColumnName("price_rub");
            entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
        });

        modelBuilder.Entity<Produkciya>(entity =>
        {
            entity.HasKey(e => e.IdProdukciya);

            entity.ToTable("produkciya");

            entity.Property(e => e.IdProdukciya)
                .ValueGeneratedNever()
                .HasColumnName("id_produkciya");
            entity.Property(e => e.Cena).HasColumnName("cena");
            entity.Property(e => e.EdIzmereniya)
                .HasMaxLength(50)
                .HasColumnName("ed_izmereniya");
            entity.Property(e => e.Naimenovanie)
                .HasMaxLength(50)
                .HasColumnName("naimenovanie");
        });

        modelBuilder.Entity<PunktVidachi>(entity =>
        {
            entity.HasKey(e => e.IdPvz);

            entity.ToTable("Punkt vidachi");

            entity.Property(e => e.IdPvz)
                .ValueGeneratedNever()
                .HasColumnName("ID_PVZ");
            entity.Property(e => e.Adres).HasMaxLength(50);

            entity.HasOne(d => d.SotrudnikNavigation).WithMany(p => p.PunktVidachis)
                .HasForeignKey(d => d.Sotrudnik)
                .HasConstraintName("FK_Punkt vidachi_SotrudnikPvz");
        });

        modelBuilder.Entity<Putevki>(entity =>
        {
            entity.HasKey(e => e.IdPutevki);

            entity.ToTable("Putevki");

            entity.Property(e => e.IdPutevki)
                .ValueGeneratedNever()
                .HasColumnName("ID_Putevki");
            entity.Property(e => e.DataNachala).HasColumnName("Data_Nachala");
            entity.Property(e => e.IdKurorta).HasColumnName("ID_Kurorta");
            entity.Property(e => e.IdNomera).HasColumnName("ID_Nomera");
            entity.Property(e => e.IdUslugi).HasColumnName("ID_Uslugi");
            entity.Property(e => e.Prodoljitelnost).HasMaxLength(50);
            entity.Property(e => e.StoimostVsego)
                .HasMaxLength(50)
                .HasColumnName("Stoimost_Vsego");

            entity.HasOne(d => d.IdKurortaNavigation).WithMany(p => p.Putevkis)
                .HasForeignKey(d => d.IdKurorta)
                .HasConstraintName("FK_Putevki_Kurorti");

            entity.HasOne(d => d.IdNomeraNavigation).WithMany(p => p.Putevkis)
                .HasForeignKey(d => d.IdNomera)
                .HasConstraintName("FK_Putevki_Nomer");

            entity.HasOne(d => d.IdUslugiNavigation).WithMany(p => p.Putevkis)
                .HasForeignKey(d => d.IdUslugi)
                .HasConstraintName("FK_Putevki_Uslugi");
        });

        modelBuilder.Entity<QrProduct>(entity =>
        {
            entity.HasKey(e => e.IdProduct);

            entity.ToTable("QR_Product");

            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RaceKitOption>(entity =>
        {
            entity.HasKey(e => e.RaceKitOptionId).HasName("pk_RaceKitOption");

            entity.ToTable("RaceKitOption");

            entity.Property(e => e.RaceKitOptionId)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RaceKitOption1)
                .HasMaxLength(80)
                .HasColumnName("RaceKitOption");
        });

        modelBuilder.Entity<RashodMateriala>(entity =>
        {
            entity.HasKey(e => e.IdRashodMateriala);

            entity.ToTable("rashod_materiala");

            entity.Property(e => e.IdRashodMateriala)
                .ValueGeneratedNever()
                .HasColumnName("id_rashod_materiala");
            entity.Property(e => e.IdMaterial).HasColumnName("id_material");
            entity.Property(e => e.IdProizvodstvo).HasColumnName("id_proizvodstvo");
            entity.Property(e => e.Rashod)
                .HasMaxLength(50)
                .HasColumnName("rashod");
        });

        modelBuilder.Entity<Raspisaniye>(entity =>
        {
            entity.HasKey(e => e.IdZanyatiya);

            entity.ToTable("Raspisaniye");

            entity.Property(e => e.IdZanyatiya)
                .ValueGeneratedNever()
                .HasColumnName("ID_Zanyatiya");
            entity.Property(e => e.NomerPari).HasColumnName("Nomer_Pari");
            entity.Property(e => e.TipZanyatiya).HasColumnName("Tip_zanyatiya");

            entity.HasOne(d => d.AuditoriyaNavigation).WithMany(p => p.Raspisaniyes)
                .HasForeignKey(d => d.Auditoriya)
                .HasConstraintName("FK_Raspisaniye_Auditoriya");

            entity.HasOne(d => d.GruppaNavigation).WithMany(p => p.Raspisaniyes)
                .HasForeignKey(d => d.Gruppa)
                .HasConstraintName("FK_Raspisaniye_Gruppi");

            entity.HasOne(d => d.NomerPariNavigation).WithMany(p => p.Raspisaniyes)
                .HasForeignKey(d => d.NomerPari)
                .HasConstraintName("FK_Raspisaniye_Vremya_Pari");

            entity.HasOne(d => d.PrepodovatelNavigation).WithMany(p => p.Raspisaniyes)
                .HasForeignKey(d => d.Prepodovatel)
                .HasConstraintName("FK_Raspisaniye_Prepodovateli");

            entity.HasOne(d => d.TipZanyatiyaNavigation).WithMany(p => p.Raspisaniyes)
                .HasForeignKey(d => d.TipZanyatiya)
                .HasConstraintName("FK_Raspisaniye_Zanyatiya");
        });

        modelBuilder.Entity<Raspisaniyee>(entity =>
        {
            entity.HasKey(e => e.NomerZapisi);

            entity.ToTable("Raspisaniyee");

            entity.Property(e => e.NomerZapisi).HasColumnName("Nomer_Zapisi");
            entity.Property(e => e.IdSotrudnika).HasColumnName("ID_Sotrudnika");
            entity.Property(e => e.IdTrenirovki).HasColumnName("ID_Trenirovki");
            entity.Property(e => e.IdUslugi).HasColumnName("ID_Uslugi");
            entity.Property(e => e.VremyaNachala).HasColumnName("Vremya_Nachala");
            entity.Property(e => e.VremyaOkonchaniya).HasColumnName("Vremya_Okonchaniya");

            entity.HasOne(d => d.IdSotrudnikaNavigation).WithMany(p => p.Raspisaniyees)
                .HasForeignKey(d => d.IdSotrudnika)
                .HasConstraintName("FK_Raspisaniyee_Spisok_Sotrudnikov");

            entity.HasOne(d => d.IdUslugiNavigation).WithMany(p => p.Raspisaniyees)
                .HasForeignKey(d => d.IdUslugi)
                .HasConstraintName("FK_Raspisaniyee_Spisok_Uslug");
        });

        modelBuilder.Entity<Razdeli>(entity =>
        {
            entity.HasKey(e => e.IdRazdela);

            entity.ToTable("Razdeli");

            entity.Property(e => e.IdRazdela).HasColumnName("ID_Razdela");
            entity.Property(e => e.Razdel).HasMaxLength(50);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("Region");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionDescription)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.RegistrationId).HasName("pk_Registration");

            entity.ToTable("Registration");

            entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RaceKitOptionId)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RegistrationDateTime).HasColumnType("datetime");
            entity.Property(e => e.SponsorshipTarget).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Charity).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.CharityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_Charity");

            entity.HasOne(d => d.RaceKitOption).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.RaceKitOptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_RaceKitOption");

            entity.HasOne(d => d.RegistrationStatus).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.RegistrationStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_RegistrationStatus");

            entity.HasOne(d => d.Runner).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.RunnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_Runner");
        });

        modelBuilder.Entity<RegistrationEvent>(entity =>
        {
            entity.HasKey(e => e.RegistrationEventId).HasName("pk_RegistrationEvent");

            entity.ToTable("RegistrationEvent");

            entity.Property(e => e.EventId)
                .HasMaxLength(6)
                .IsFixedLength();

            entity.HasOne(d => d.Registration).WithMany(p => p.RegistrationEvents)
                .HasForeignKey(d => d.RegistrationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistrationEvent_Registration");
        });

        modelBuilder.Entity<RegistrationStatus>(entity =>
        {
            entity.HasKey(e => e.RegistrationStatusId).HasName("pk_RegistrationStatus");

            entity.ToTable("RegistrationStatus");

            entity.Property(e => e.RegistrationStatusId).ValueGeneratedOnAdd();
            entity.Property(e => e.RegistrationStatus1)
                .HasMaxLength(80)
                .HasColumnName("RegistrationStatus");
        });

        modelBuilder.Entity<Rejiseri>(entity =>
        {
            entity.HasKey(e => e.IdRejisera);

            entity.ToTable("Rejiseri");

            entity.Property(e => e.IdRejisera).HasColumnName("ID_Rejisera");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("pk_Role_");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<Role1>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("Role_1");

            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Role11>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("Role1");

            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Role2>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__760965CC3308EED0");

            entity.ToTable("Roles");

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<RoleAvt>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("role_avt");

            entity.Property(e => e.IdRole)
                .ValueGeneratedNever()
                .HasColumnName("id_role");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RoleCafe>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("role_cafe");

            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RoleJewel>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("Role_jewel");

            entity.Property(e => e.IdRole)
                .ValueGeneratedNever()
                .HasColumnName("ID_Role");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Rolee>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("pk_Rolee");

            entity.ToTable("Rolee");

            entity.Property(e => e.RoleId)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<Roli>(entity =>
        {
            entity.HasKey(e => e.IdRoli);

            entity.ToTable("Roli");

            entity.Property(e => e.IdRoli)
                .ValueGeneratedNever()
                .HasColumnName("ID_Roli");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Runner>(entity =>
        {
            entity.HasKey(e => e.RunnerId).HasName("pk_Runner");

            entity.ToTable("Runner");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.Runners)
                .HasForeignKey(d => d.CountryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Runner__CountryC__19169DBB");

            entity.HasOne(d => d.EmailNavigation).WithMany(p => p.Runners)
                .HasForeignKey(d => d.Email)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Runner__Email__172E5549");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.Runners)
                .HasForeignKey(d => d.Gender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Runner__Gender__18227982");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PK__Sales__E1EB00B2C2968383");

            entity.Property(e => e.SaleId).HasColumnName("sale_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .HasColumnName("payment_method");
            entity.Property(e => e.SaleDate)
                .HasColumnType("datetime")
                .HasColumnName("sale_date");
            entity.Property(e => e.TotalAmountRub).HasColumnName("total_amount_rub");

            entity.HasOne(d => d.Client).WithMany(p => p.Sales)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Clients");

            entity.HasOne(d => d.Employee).WithMany(p => p.Sales)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Employees2");
        });

        modelBuilder.Entity<SaleProduct>(entity =>
        {
            entity.HasKey(e => e.IdSaleproducts);

            entity.ToTable("Sale_Products");

            entity.Property(e => e.IdSaleproducts).HasColumnName("id_saleproducts");
            entity.Property(e => e.PriceRub).HasColumnName("price_rub");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.SaleId).HasColumnName("sale_id");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_Products_Products2");

            entity.HasOne(d => d.Sale).WithMany(p => p.SaleProducts)
                .HasForeignKey(d => d.SaleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_Products_Sales");
        });

        modelBuilder.Entity<SaleService>(entity =>
        {
            entity.HasKey(e => e.SaleServicesId);

            entity.ToTable("Sale_Services");

            entity.Property(e => e.SaleServicesId).HasColumnName("sale_services_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.SaleId).HasColumnName("sale_id");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");

            entity.HasOne(d => d.Sale).WithMany(p => p.SaleServices)
                .HasForeignKey(d => d.SaleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_Services_Sales");

            entity.HasOne(d => d.Service).WithMany(p => p.SaleServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_Services_Services");
        });

        modelBuilder.Entity<Seller>(entity =>
        {
            entity.HasKey(e => e.IdSeller);

            entity.ToTable("Seller");

            entity.Property(e => e.IdSeller).HasColumnName("ID_Seller");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date_of_birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Service");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.MainImage).HasColumnType("image");
            entity.Property(e => e.MainImagePath).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<Service1>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Services__3E0DB8AFD6E14F39");

            entity.ToTable("Services");

            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.DurationMin).HasColumnName("duration_min");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PriceRub).HasColumnName("price_rub");
        });

        modelBuilder.Entity<ServicePhoto>(entity =>
        {
            entity.ToTable("ServicePhoto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

            entity.HasOne(d => d.Service).WithMany(p => p.ServicePhotos)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_ServicePhoto_Service");
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.Property(e => e.ShipperId)
                .ValueGeneratedNever()
                .HasColumnName("ShipperID");
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(24);
        });

        modelBuilder.Entity<Sklad>(entity =>
        {
            entity.HasKey(e => e.IdSklad);

            entity.ToTable("Sklad");

            entity.Property(e => e.IdSklad).HasColumnName("ID_Sklad");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Sorevnovaniya>(entity =>
        {
            entity.HasKey(e => e.IdSorevnovaniya);

            entity.ToTable("Sorevnovaniya");

            entity.Property(e => e.IdSorevnovaniya).HasColumnName("ID_Sorevnovaniya");
            entity.Property(e => e.IdUprajneniya).HasColumnName("ID_Uprajneniya");
            entity.Property(e => e.NazvanieSorevnovaniya)
                .HasMaxLength(50)
                .HasColumnName("Nazvanie_Sorevnovaniya");

            entity.HasOne(d => d.IdUprajneniyaNavigation).WithMany(p => p.Sorevnovaniyas)
                .HasForeignKey(d => d.IdUprajneniya)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sorevnovaniya_Uprajneniya");
        });

        modelBuilder.Entity<Sotrudnik>(entity =>
        {
            entity.HasKey(e => e.IdSotrudnik);

            entity.ToTable("sotrudnik");

            entity.Property(e => e.IdSotrudnik)
                .ValueGeneratedNever()
                .HasColumnName("ID_Sotrudnik");
            entity.Property(e => e.DataRojdeniya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Data_Rojdeniya");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<SotrudnikPvz>(entity =>
        {
            entity.HasKey(e => e.IdSotrudnikPvz);

            entity.ToTable("SotrudnikPvz");

            entity.Property(e => e.IdSotrudnikPvz)
                .ValueGeneratedNever()
                .HasColumnName("ID_SotrudnikPvz");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<Sotrudniki>(entity =>
        {
            entity.HasKey(e => e.IdSotrudnika);

            entity.ToTable("Sotrudniki");

            entity.Property(e => e.IdSotrudnika).HasColumnName("ID_Sotrudnika");
            entity.Property(e => e.Adress).HasMaxLength(50);
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.PasportnieDannie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pasportnie_Dannie");
            entity.Property(e => e.ProcentVoznagrojdeniya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Procent_Voznagrojdeniya");
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sotrudnikii>(entity =>
        {
            entity.HasKey(e => e.IdSotrudnika);

            entity.ToTable("Sotrudnikii");

            entity.Property(e => e.IdSotrudnika).HasColumnName("ID_Sotrudnika");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);

            entity.HasOne(d => d.DoljnostNavigation).WithMany(p => p.Sotrudnikiis)
                .HasForeignKey(d => d.Doljnost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sotrudnikii_Doljnostt");
        });

        modelBuilder.Entity<SpisokKlientov>(entity =>
        {
            entity.HasKey(e => e.IdKlient);

            entity.ToTable("Spisok klientov");

            entity.Property(e => e.IdKlient).HasColumnName("ID_Klient");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_Rojdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.Telephone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpisokSotrudnikov>(entity =>
        {
            entity.HasKey(e => e.IdSotrudnika);

            entity.ToTable("Spisok_Sotrudnikov");

            entity.Property(e => e.IdSotrudnika).HasColumnName("ID_Sotrudnika");
            entity.Property(e => e.Adres).HasMaxLength(50);
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_Rojdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Oklad).HasColumnType("money");
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Photo).HasColumnType("image");
        });

        modelBuilder.Entity<SpisokTovarov>(entity =>
        {
            entity.HasKey(e => e.IdTovara);

            entity.ToTable("Spisok_Tovarov");

            entity.Property(e => e.IdTovara).HasColumnName("ID_Tovara");
            entity.Property(e => e.Cena).HasColumnType("money");
            entity.Property(e => e.KolichestvoVNalichie).HasColumnName("Kolichestvo_V_Nalichie");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<SpisokUslug>(entity =>
        {
            entity.HasKey(e => e.IdUslugi);

            entity.ToTable("Spisok_Uslug");

            entity.Property(e => e.IdUslugi).HasColumnName("ID_Uslugi");
            entity.Property(e => e.Naimenovaniye).HasMaxLength(50);
        });

        modelBuilder.Entity<Sponsorship>(entity =>
        {
            entity.HasKey(e => e.SponsorshipId).HasName("pk_Sponsorship");

            entity.ToTable("Sponsorship");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SponsorName).HasMaxLength(150);

            entity.HasOne(d => d.Registration).WithMany(p => p.Sponsorships)
                .HasForeignKey(d => d.RegistrationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sponsorship_Registration");
        });

        modelBuilder.Entity<Sportsmeni>(entity =>
        {
            entity.HasKey(e => e.IdSportsmena);

            entity.ToTable("Sportsmeni");

            entity.Property(e => e.IdSportsmena).HasColumnName("ID_Sportsmena");
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_Rojdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.IdKlassivikacii).HasColumnName("ID_Klassivikacii");
            entity.Property(e => e.IdRoli).HasColumnName("ID_Roli");
            entity.Property(e => e.IdSorevnovaniya).HasColumnName("ID_Sorevnovaniya");
            entity.Property(e => e.IdTitula).HasColumnName("ID_Titula");
            entity.Property(e => e.IdTrenirovki).HasColumnName("ID_Trenirovki");
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.MestoRojdeniya)
                .HasMaxLength(50)
                .HasColumnName("Mesto_Rojdeniya");
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdKlassivikaciiNavigation).WithMany(p => p.Sportsmenis)
                .HasForeignKey(d => d.IdKlassivikacii)
                .HasConstraintName("FK_Sportsmeni_Klassifikaciya");

            entity.HasOne(d => d.IdRoliNavigation).WithMany(p => p.Sportsmenis)
                .HasForeignKey(d => d.IdRoli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sportsmeni_Roli");

            entity.HasOne(d => d.IdSorevnovaniyaNavigation).WithMany(p => p.Sportsmenis)
                .HasForeignKey(d => d.IdSorevnovaniya)
                .HasConstraintName("FK_Sportsmeni_Sorevnovaniya");

            entity.HasOne(d => d.IdTitulaNavigation).WithMany(p => p.Sportsmenis)
                .HasForeignKey(d => d.IdTitula)
                .HasConstraintName("FK_Sportsmeni_Titul");
        });

        modelBuilder.Entity<Status1>(entity =>
        {
            entity.HasKey(e => e.IdStatuza);

            entity.ToTable("Status1");

            entity.Property(e => e.IdStatuza).HasColumnName("ID_Statuza");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<StatusCafe>(entity =>
        {
            entity.HasKey(e => e.IdStatus);

            entity.ToTable("status_cafe");

            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StatusTovara>(entity =>
        {
            entity.HasKey(e => e.IdStatusa);

            entity.ToTable("Status_Tovara");

            entity.Property(e => e.IdStatusa)
                .ValueGeneratedNever()
                .HasColumnName("ID_Statusa");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<StatusUser>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("status_user");

            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Statuss>(entity =>
        {
            entity.HasKey(e => e.IdStatus);

            entity.ToTable("statuss");

            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.HasKey(e => e.IdStorage);

            entity.ToTable("Storage");

            entity.Property(e => e.IdStorage).HasColumnName("ID_Storage");
            entity.Property(e => e.Adress).HasMaxLength(50);
        });

        modelBuilder.Entity<StorageBalance>(entity =>
        {
            entity.HasKey(e => e.IdStorageBalance);

            entity.ToTable("storageBalance");

            entity.Property(e => e.IdStorageBalance).HasColumnName("ID_storageBalance");
            entity.Property(e => e.IdGoods).HasColumnName("ID_goods");
            entity.Property(e => e.IdStorage).HasColumnName("ID_storage");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.IdGoodsNavigation).WithMany(p => p.StorageBalances)
                .HasForeignKey(d => d.IdGoods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storageBalance_goodss");

            entity.HasOne(d => d.IdStorageNavigation).WithMany(p => p.StorageBalances)
                .HasForeignKey(d => d.IdStorage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storageBalance_storagee");
        });

        modelBuilder.Entity<Storagee>(entity =>
        {
            entity.HasKey(e => e.IdStorage);

            entity.ToTable("storagee");

            entity.Property(e => e.IdStorage).HasColumnName("ID_storage");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.IdStore);

            entity.ToTable("store");

            entity.Property(e => e.IdStore).HasColumnName("ID_store");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StoreBalance>(entity =>
        {
            entity.HasKey(e => e.IdStoreBalance);

            entity.ToTable("storeBalance");

            entity.Property(e => e.IdStoreBalance).HasColumnName("ID_storeBalance");
            entity.Property(e => e.IdGoods).HasColumnName("ID_goods");
            entity.Property(e => e.IdStore).HasColumnName("ID_Store");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.IdGoodsNavigation).WithMany(p => p.StoreBalances)
                .HasForeignKey(d => d.IdGoods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storeBalance_goodss");

            entity.HasOne(d => d.IdStoreNavigation).WithMany(p => p.StoreBalances)
                .HasForeignKey(d => d.IdStore)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storeBalance_store");
        });

        modelBuilder.Entity<Storekeeper>(entity =>
        {
            entity.HasKey(e => e.IdStorekeeper);

            entity.ToTable("storekeeper");

            entity.Property(e => e.IdStorekeeper).HasColumnName("ID_storekeeper");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.IdStudenta);

            entity.ToTable("STUDENT");

            entity.Property(e => e.IdStudenta).HasColumnName("ID_Studenta");
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Otchestvo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.GruppaNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Gruppa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STUDENT_Grupps");
        });

        modelBuilder.Entity<Student2>(entity =>
        {
            entity.HasKey(e => e.IdStudent);

            entity.ToTable("student2");

            entity.Property(e => e.IdStudent)
                .ValueGeneratedNever()
                .HasColumnName("id_student");
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .HasColumnName("familiya");
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .HasColumnName("imya");
            entity.Property(e => e.Kurs).HasColumnName("kurs");
        });

        modelBuilder.Entity<Studenti>(entity =>
        {
            entity.HasKey(e => e.IdStudenta).HasName("PK__Studenti__D7AC0B134EB50351");

            entity.ToTable("Studenti");

            entity.Property(e => e.IdStudenta).HasColumnName("ID_Studenta");
            entity.Property(e => e.Dom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GruppaZdorovya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gruppa_Zdorovya");
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kvartira)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uvlecheniya)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Studentt>(entity =>
        {
            entity.HasKey(e => e.IdСтудента).HasName("PK__Studentt__8C3BB050E25FC8B0");

            entity.ToTable("Studentt");

            entity.Property(e => e.IdСтудента).HasColumnName("ID_Студента");
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_rojdeniya");
            entity.Property(e => e.Familiya)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Imya).HasMaxLength(100);
            entity.Property(e => e.Otchestvo).HasMaxLength(100);

            entity.HasOne(d => d.GruppaNavigation).WithMany(p => p.Studentts)
                .HasForeignKey(d => d.Gruppa)
                .HasConstraintName("FK_Studentt_Gruppaa");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.HomePage).HasColumnType("ntext");
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
        });

        modelBuilder.Entity<Supplierss>(entity =>
        {
            entity.HasKey(e => e.CompanyName);

            entity.ToTable("supplierss");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .HasColumnName("company_name");
            entity.Property(e => e.SupplierCity)
                .HasMaxLength(50)
                .HasColumnName("supplier_city");
            entity.Property(e => e.SupplierCountry)
                .HasMaxLength(50)
                .HasColumnName("supplier_country");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.HasKey(e => e.IdTable).HasName("PK__TABLE1__3E8B668019728929");

            entity.ToTable("TABLE1");

            entity.Property(e => e.IdTable).HasColumnName("ID_Table");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLE_NAME");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("Tag");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(30);
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.Property(e => e.TerritoryId)
                .HasMaxLength(20)
                .HasColumnName("TerritoryID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.TerritoryDescription)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.Region).WithMany(p => p.Territories)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_Territories_Region");
        });

        modelBuilder.Entity<Tgrewhtew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Role");

            entity.ToTable("tgrewhtew");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TipDocumentum>(entity =>
        {
            entity.HasKey(e => e.IdTipDocumenta);

            entity.ToTable("Tip_Documenta");

            entity.Property(e => e.IdTipDocumenta)
                .ValueGeneratedNever()
                .HasColumnName("ID_Tip_Documenta");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Titul>(entity =>
        {
            entity.HasKey(e => e.IdTitula);

            entity.ToTable("Titul");

            entity.Property(e => e.IdTitula).HasColumnName("ID_Titula");
            entity.Property(e => e.NazvanieTitula)
                .HasMaxLength(50)
                .HasColumnName("Nazvanie_Titula");
        });

        modelBuilder.Entity<Tovar>(entity =>
        {
            entity.HasKey(e => e.IdTovar);

            entity.ToTable("Tovar");

            entity.Property(e => e.IdTovar)
                .ValueGeneratedNever()
                .HasColumnName("ID_Tovar");
            entity.Property(e => e.Cena).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Postavshik).HasMaxLength(50);
        });

        modelBuilder.Entity<Tovar1>(entity =>
        {
            entity.HasKey(e => e.IdTovar);

            entity.ToTable("Tovar1");

            entity.Property(e => e.IdTovar)
                .ValueGeneratedNever()
                .HasColumnName("ID_Tovar");
            entity.Property(e => e.Cena).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);

            entity.HasOne(d => d.PostavshikNavigation).WithMany(p => p.Tovar1s)
                .HasForeignKey(d => d.Postavshik)
                .HasConstraintName("FK_Tovar1_Postavshik1");
        });

        modelBuilder.Entity<Tovar2>(entity =>
        {
            entity.HasKey(e => e.IdTovar);

            entity.ToTable("Tovar2");

            entity.Property(e => e.IdTovar)
                .ValueGeneratedNever()
                .HasColumnName("ID_Tovar");
            entity.Property(e => e.Cena).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Ves).HasMaxLength(50);

            entity.HasOne(d => d.ProdavecNavigation).WithMany(p => p.Tovar2s)
                .HasForeignKey(d => d.Prodavec)
                .HasConstraintName("FK_Tovar2_Prodavec");
        });

        modelBuilder.Entity<Tovar3>(entity =>
        {
            entity.HasKey(e => e.IdTovar);

            entity.ToTable("Tovar3");

            entity.Property(e => e.IdTovar).HasColumnName("ID_Tovar");
            entity.Property(e => e.Cena).HasMaxLength(50);
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Ves).HasMaxLength(50);

            entity.HasOne(d => d.PostavshikNavigation).WithMany(p => p.Tovar3s)
                .HasForeignKey(d => d.Postavshik)
                .HasConstraintName("FK_Tovar3_Postasvhik3");
        });

        modelBuilder.Entity<TovarSklad>(entity =>
        {
            entity.HasKey(e => e.IdTovarSklad);

            entity.ToTable("Tovar_Sklad");

            entity.Property(e => e.IdTovarSklad)
                .ValueGeneratedNever()
                .HasColumnName("ID_Tovar_Sklad");
            entity.Property(e => e.IdSklad).HasColumnName("ID_Sklad");
            entity.Property(e => e.IdTovar).HasColumnName("ID_Tovar");

            entity.HasOne(d => d.IdSkladNavigation).WithMany(p => p.TovarSklads)
                .HasForeignKey(d => d.IdSklad)
                .HasConstraintName("FK_Tovar_Sklad_Sklad");

            entity.HasOne(d => d.IdTovarNavigation).WithMany(p => p.TovarSklads)
                .HasForeignKey(d => d.IdTovar)
                .HasConstraintName("FK_Tovar_Sklad_Tovar3");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.TovarSklads)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Tovar_Sklad_Status_Tovara");
        });

        modelBuilder.Entity<TovarZakaz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tovar zakaz");

            entity.Property(e => e.IdTovar).HasColumnName("ID_Tovar");
            entity.Property(e => e.IdZakaz).HasColumnName("ID_Zakaz");
            entity.Property(e => e.Kolichestvo).HasMaxLength(50);

            entity.HasOne(d => d.IdTovarNavigation).WithMany()
                .HasForeignKey(d => d.IdTovar)
                .HasConstraintName("FK_Tovar zakaz_Tovar");

            entity.HasOne(d => d.IdZakazNavigation).WithMany()
                .HasForeignKey(d => d.IdZakaz)
                .HasConstraintName("FK_Tovar zakaz_Zakaz");
        });

        modelBuilder.Entity<TovarZakaz11>(entity =>
        {
            entity.HasKey(e => e.IdTovarZakaz);

            entity.ToTable("TovarZakaz1");

            entity.Property(e => e.IdTovarZakaz)
                .ValueGeneratedNever()
                .HasColumnName("ID_TovarZakaz");
            entity.Property(e => e.IdTovar).HasColumnName("ID_Tovar");
            entity.Property(e => e.IdZakaz).HasColumnName("ID_Zakaz");
            entity.Property(e => e.Kolichestvo).HasMaxLength(50);

            entity.HasOne(d => d.IdTovarNavigation).WithMany(p => p.TovarZakaz11s)
                .HasForeignKey(d => d.IdTovar)
                .HasConstraintName("FK_TovarZakaz1_Tovar2");

            entity.HasOne(d => d.IdZakazNavigation).WithMany(p => p.TovarZakaz11s)
                .HasForeignKey(d => d.IdZakaz)
                .HasConstraintName("FK_TovarZakaz1_Zakaz2");
        });

        modelBuilder.Entity<Tovarzakaz1>(entity =>
        {
            entity.HasKey(e => e.IdTovarZakaz);

            entity.ToTable("tovarzakaz");

            entity.Property(e => e.IdTovarZakaz)
                .ValueGeneratedNever()
                .HasColumnName("ID_TovarZakaz");
            entity.Property(e => e.Kolichestvo).HasMaxLength(50);

            entity.HasOne(d => d.TovarNavigation).WithMany(p => p.Tovarzakaz1s)
                .HasForeignKey(d => d.Tovar)
                .HasConstraintName("FK_tovarzakaz_Tovar1");

            entity.HasOne(d => d.ZakazNavigation).WithMany(p => p.Tovarzakaz1s)
                .HasForeignKey(d => d.Zakaz)
                .HasConstraintName("FK_tovarzakaz_Zakaz1");
        });

        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.HasKey(e => e.TrainerId).HasName("PK__Trainers__65A4B62954963B36");

            entity.Property(e => e.TrainerId).HasColumnName("trainer_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.ExperienceYears).HasColumnName("experience_years");
            entity.Property(e => e.Specialization)
                .HasMaxLength(100)
                .HasColumnName("specialization");
            entity.Property(e => e.WorkSchedule).HasColumnName("work_schedule");

            entity.HasOne(d => d.Employee).WithMany(p => p.Trainers)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trainers_Employees21");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__85C600AF017AFBA8");

            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.AmountRub).HasColumnName("amount_rub");
            entity.Property(e => e.SaleId).HasColumnName("sale_id");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Trenera>(entity =>
        {
            entity.HasKey(e => e.IdTrenera);

            entity.ToTable("Trenera");

            entity.Property(e => e.IdTrenera).HasColumnName("ID_Trenera");
            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_Rojdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Staj).HasMaxLength(50);
            entity.Property(e => e.Zvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<Trenirovki>(entity =>
        {
            entity.HasKey(e => e.IdTrenirovki);

            entity.ToTable("Trenirovki");

            entity.Property(e => e.IdTrenirovki).HasColumnName("ID_Trenirovki");
            entity.Property(e => e.IdTrenera).HasColumnName("ID_Trenera");
            entity.Property(e => e.MestoProvedeniyaTrenirovok)
                .HasMaxLength(50)
                .HasColumnName("Mesto_provedeniya_trenirovok");
            entity.Property(e => e.NomerZala).HasColumnName("Nomer_zala");
            entity.Property(e => e.ProdoljitelnostOdnoyTrenirovki)
                .HasMaxLength(50)
                .HasColumnName("Prodoljitelnost_odnoy_trenirovki");
            entity.Property(e => e.Raspisaniye).HasMaxLength(50);

            entity.HasOne(d => d.IdTreneraNavigation).WithMany(p => p.Trenirovkis)
                .HasForeignKey(d => d.IdTrenera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trenirovki_Trenera");
        });

        modelBuilder.Entity<TrudovayaKnijka>(entity =>
        {
            entity.HasKey(e => e.IdTrudovoyKnijki);

            entity.ToTable("Trudovaya knijka");

            entity.Property(e => e.IdTrudovoyKnijki)
                .ValueGeneratedNever()
                .HasColumnName("ID_Trudovoy_knijki");
            entity.Property(e => e.Staj).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.SotrudnikNavigation).WithMany(p => p.TrudovayaKnijkas)
                .HasForeignKey(d => d.Sotrudnik)
                .HasConstraintName("FK_Trudovaya knijka_sotrudnik");
        });

        modelBuilder.Entity<Up03Avtomobil>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Avt__C41FEDBD10E176EB");

            entity.ToTable("up03_Avtomobil");

            entity.HasIndex(e => e.Vin, "UQ__up03_Avt__C5DF234CDE32B4EB").IsUnique();

            entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cvet).HasMaxLength(30);
            entity.Property(e => e.DataDobavleniya)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.KorobkaPeredach).HasMaxLength(30);
            entity.Property(e => e.ObemDvigatelya).HasColumnType("decimal(3, 1)");
            entity.Property(e => e.PutFoto).HasMaxLength(255);
            entity.Property(e => e.TipPrivoda).HasMaxLength(20);
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .HasColumnName("VIN");

            entity.HasOne(d => d.KodModeliNavigation).WithMany(p => p.Up03Avtomobils)
                .HasForeignKey(d => d.KodModeli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_Avto_Model");

            entity.HasOne(d => d.KodStatusaNavigation).WithMany(p => p.Up03Avtomobils)
                .HasForeignKey(d => d.KodStatusa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_Avto_Status");
        });

        modelBuilder.Entity<Up03Klient>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Kli__C41FEDBDD75D7B8E");

            entity.ToTable("up03_Klient");

            entity.Property(e => e.Adres).HasMaxLength(200);
            entity.Property(e => e.DataRegistratsii)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fio)
                .HasMaxLength(100)
                .HasColumnName("FIO");
            entity.Property(e => e.Pochta).HasMaxLength(50);
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<Up03Marka>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Mar__C41FEDBD8E5BE1CD");

            entity.ToTable("up03_Marka");

            entity.HasIndex(e => e.Nazvanie, "UQ__up03_Mar__C5571E6ED26889A9").IsUnique();

            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.Strana).HasMaxLength(50);
        });

        modelBuilder.Entity<Up03Model>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Mod__C41FEDBD83CC623B");

            entity.ToTable("up03_Model");

            entity.Property(e => e.Nazvanie).HasMaxLength(50);
            entity.Property(e => e.TipKuzova).HasMaxLength(30);

            entity.HasOne(d => d.KodMarkiNavigation).WithMany(p => p.Up03Models)
                .HasForeignKey(d => d.KodMarki)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_Model_Marka");
        });

        modelBuilder.Entity<Up03Role>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Rol__C41FEDBD7EC73D57");

            entity.ToTable("up03_Role");

            entity.HasIndex(e => e.Nazvanie, "UQ__up03_Rol__C5571E6EAD7289EB").IsUnique();

            entity.Property(e => e.Nazvanie).HasMaxLength(30);
            entity.Property(e => e.Opisanie).HasMaxLength(200);
        });

        modelBuilder.Entity<Up03Sdelka>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Sde__C41FEDBD4484B28B");

            entity.ToTable("up03_Sdelka");

            entity.HasIndex(e => e.NomerDogovora, "UQ__up03_Sde__C4364CAE154D8571").IsUnique();

            entity.Property(e => e.DataSdelki)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ItogovayaCena).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NomerDogovora).HasMaxLength(50);
            entity.Property(e => e.Skidka).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SposobOplaty).HasMaxLength(50);

            entity.HasOne(d => d.KodAvtomobilyaNavigation).WithMany(p => p.Up03Sdelkas)
                .HasForeignKey(d => d.KodAvtomobilya)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_Sdelka_Avto");

            entity.HasOne(d => d.KodKlientaNavigation).WithMany(p => p.Up03Sdelkas)
                .HasForeignKey(d => d.KodKlienta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_Sdelka_Klient");

            entity.HasOne(d => d.KodProdavtsaNavigation).WithMany(p => p.Up03Sdelkas)
                .HasForeignKey(d => d.KodProdavtsa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_Sdelka_User");
        });

        modelBuilder.Entity<Up03Status>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Sta__C41FEDBD5BFFD7CA");

            entity.ToTable("up03_Status");

            entity.HasIndex(e => e.Nazvanie, "UQ__up03_Sta__C5571E6E109F47F6").IsUnique();

            entity.Property(e => e.Nazvanie).HasMaxLength(30);
            entity.Property(e => e.Opisanie).HasMaxLength(200);
        });

        modelBuilder.Entity<Up03User>(entity =>
        {
            entity.HasKey(e => e.Kod).HasName("PK__up03_Use__C41FEDBD00A468AC");

            entity.ToTable("up03_User");

            entity.HasIndex(e => e.Login, "UQ__up03_Use__5E55825B8AF07E8A").IsUnique();

            entity.Property(e => e.Aktiven).HasDefaultValue(true);
            entity.Property(e => e.DataPoslednegoVhoda).HasColumnType("datetime");
            entity.Property(e => e.Fio)
                .HasMaxLength(100)
                .HasColumnName("FIO");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Parol).HasMaxLength(255);
            entity.Property(e => e.Pochta).HasMaxLength(50);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.KodRoliNavigation).WithMany(p => p.Up03Users)
                .HasForeignKey(d => d.KodRoli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_up03_User_Role");
        });

        modelBuilder.Entity<Up05StRole>(entity =>
        {
            entity.HasKey(e => e.Idrole).HasName("PK__up05_ST___A1BA16C484DE807D");

            entity.ToTable("up05_ST_Roles");

            entity.HasIndex(e => e.RoleName, "UQ__up05_ST___B19478611DA8091E").IsUnique();

            entity.Property(e => e.Idrole).HasColumnName("IDRole");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Up05StUser>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PK__up05_ST___EAE6D9DF105F0B25");

            entity.ToTable("up05_ST_Users");

            entity.HasIndex(e => e.Familiya, "UQ__up05_ST___34F9FB0E4278514C").IsUnique();

            entity.HasIndex(e => e.Imya, "UQ__up05_ST___46F055D4B3CB5113").IsUnique();

            entity.HasIndex(e => e.Login, "UQ__up05_ST___5E55825B22634FF7").IsUnique();

            entity.HasIndex(e => e.Password, "UQ__up05_ST___87909B15284C2937").IsUnique();

            entity.HasIndex(e => e.Idrole, "UQ__up05_ST___A1BA16C51C35A608").IsUnique();

            entity.HasIndex(e => e.Otchestvo, "UQ__up05_ST___EBDDE11724B98F5E").IsUnique();

            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.Familiya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idrole).HasColumnName("IDRole");
            entity.Property(e => e.Imya)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Otchestvo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Uprajneniya>(entity =>
        {
            entity.HasKey(e => e.IdUprajneniya);

            entity.ToTable("Uprajneniya");

            entity.Property(e => e.IdUprajneniya).HasColumnName("ID_Uprajneniya");
            entity.Property(e => e.NazvanieUprajneniya)
                .HasMaxLength(50)
                .HasColumnName("Nazvanie_uprajneniya");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("pk_Userr");

            entity.ToTable("User");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(80);
            entity.Property(e => e.LastName).HasMaxLength(80);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.RoleId)
                .HasMaxLength(1)
                .IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__RoleId__163A3110");
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.ToTable("User_1");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.User1s)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("FK_User_1_Role_1");
        });

        modelBuilder.Entity<User11>(entity =>
        {
            entity.ToTable("User1");

            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.User11s)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("FK_User1_Role1");
        });

        modelBuilder.Entity<User2>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User2__B9BE370F6F308E2B");

            entity.ToTable("User2");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.IsBlocked).HasColumnName("is_blocked");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Role).WithMany(p => p.User2s)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User2_Roles1");
        });

        modelBuilder.Entity<User3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Users");

            entity.Property(e => e.IdRole).HasColumnName("ID_Role");
            entity.Property(e => e.IdSotrudnik)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Sotrudnik");
        });

        modelBuilder.Entity<UserAvt1>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("User_avt1");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Passport)
                .HasMaxLength(50)
                .HasColumnName("passport");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<UserCafe>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("user_cafe");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Role).WithMany(p => p.UserCaves)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_cafe_role_cafe");
        });

        modelBuilder.Entity<UserFavorite>(entity =>
        {
            entity.HasKey(e => e.IdFavorite).HasName("PK__user_fav__72301460EC046621");

            entity.ToTable("user_favorites");

            entity.Property(e => e.IdFavorite).HasColumnName("ID_favorite");
            entity.Property(e => e.AddedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.FilmNameNavigation).WithMany(p => p.UserFavorites)
                .HasForeignKey(d => d.FilmName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_favorites_DVD_movies");

            entity.HasOne(d => d.User).WithMany(p => p.UserFavorites)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_favorites_usersCD");
        });

        modelBuilder.Entity<Userr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Userr");

            entity.Property(e => e.DataRojdeniya).HasColumnName("Data_rojdeniya");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.IdRole).HasColumnName("ID_Role");
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<Userrr>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("pk_Userrr");

            entity.ToTable("Userrr");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(80);
            entity.Property(e => e.LastName).HasMaxLength(80);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.RoleId)
                .HasMaxLength(1)
                .IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.Userrrs)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Userrr_Rolee");
        });

        modelBuilder.Entity<UsersCd>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("usersCD");

            entity.Property(e => e.IdUser).HasColumnName("ID_user");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Userstore>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("userstore");

            entity.Property(e => e.IdUser).HasColumnName("ID_user");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.JobTitle).HasColumnName("Job_title");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Role).HasColumnName("role");

            entity.HasOne(d => d.JobTitleNavigation).WithMany(p => p.Userstores)
                .HasForeignKey(d => d.JobTitle)
                .HasConstraintName("FK_userstore_Job_title");
        });

        modelBuilder.Entity<UshetPosesheniy>(entity =>
        {
            entity.HasKey(e => e.NomerPosesheniya);

            entity.ToTable("Ushet_Posesheniy");

            entity.Property(e => e.NomerPosesheniya).HasColumnName("Nomer_Posesheniya");
            entity.Property(e => e.NomerKarti).HasColumnName("Nomer_Karti");
            entity.Property(e => e.NomerZapisi).HasColumnName("Nomer_Zapisi");

            entity.HasOne(d => d.NomerKartiNavigation).WithMany(p => p.UshetPosesheniys)
                .HasForeignKey(d => d.NomerKarti)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ushet_Posesheniy_Prodaja_Abonementov");

            entity.HasOne(d => d.NomerZapisiNavigation).WithMany(p => p.UshetPosesheniys)
                .HasForeignKey(d => d.NomerZapisi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ushet_Posesheniy_Raspisaniyee");
        });

        modelBuilder.Entity<Uslugi>(entity =>
        {
            entity.HasKey(e => e.IdUslugi);

            entity.ToTable("Uslugi");

            entity.Property(e => e.IdUslugi)
                .ValueGeneratedNever()
                .HasColumnName("ID_Uslugi");
            entity.Property(e => e.StoimostStrahovki)
                .HasMaxLength(50)
                .HasColumnName("Stoimost_Strahovki");
            entity.Property(e => e.StoimostVisa)
                .HasMaxLength(50)
                .HasColumnName("Stoimost_Visa");
            entity.Property(e => e.Visa).HasMaxLength(50);
            entity.Property(e => e.Zagranpassport).HasMaxLength(50);
        });

        modelBuilder.Entity<Vagon>(entity =>
        {
            entity.HasKey(e => e.IdVagon);

            entity.ToTable("Vagon");

            entity.Property(e => e.IdVagon)
                .ValueGeneratedNever()
                .HasColumnName("ID_Vagon");
            entity.Property(e => e.TipVagona)
                .HasMaxLength(50)
                .HasColumnName("TIp_vagona");

            entity.HasOne(d => d.PoezdNavigation).WithMany(p => p.Vagons)
                .HasForeignKey(d => d.Poezd)
                .HasConstraintName("FK_Vagon_Poezd");
        });

        modelBuilder.Entity<VidRaboti>(entity =>
        {
            entity.HasKey(e => e.IdVidaRaboti);

            entity.ToTable("Vid_Raboti");

            entity.Property(e => e.IdVidaRaboti).HasColumnName("ID_Vida_Raboti");
            entity.Property(e => e.CenaEd)
                .HasMaxLength(50)
                .HasColumnName("Cena_ed");
            entity.Property(e => e.Naimenovanie).HasMaxLength(50);
        });

        modelBuilder.Entity<VidTrenirovlki>(entity =>
        {
            entity.HasKey(e => e.IdVidaTrenirovki);

            entity.ToTable("Vid_Trenirovlki");

            entity.Property(e => e.IdVidaTrenirovki).HasColumnName("ID_Vida_Trenirovki");
            entity.Property(e => e.VidTrenirovki)
                .HasMaxLength(50)
                .HasColumnName("Vid_Trenirovki");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.VisitId).HasName("PK__Visits__375A75E18435E08B");

            entity.Property(e => e.VisitId).HasColumnName("visit_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.EntryTime)
                .HasColumnType("datetime")
                .HasColumnName("entry_time");
            entity.Property(e => e.ExitTime)
                .HasColumnType("datetime")
                .HasColumnName("exit_time");
            entity.Property(e => e.VisitType)
                .HasMaxLength(20)
                .HasColumnName("visit_type");

            entity.HasOne(d => d.Client).WithMany(p => p.Visits)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Visits_Clients");
        });

        modelBuilder.Entity<Volunteer>(entity =>
        {
            entity.HasKey(e => e.VolunteerId).HasName("pk_Volunteer");

            entity.ToTable("Volunteer");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.FirstName).HasMaxLength(80);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.LastName).HasMaxLength(80);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.Volunteers)
                .HasForeignKey(d => d.CountryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Volunteer__Count__1AFEE62D");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.Volunteers)
                .HasForeignKey(d => d.Gender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Volunteer__Gende__1A0AC1F4");
        });

        modelBuilder.Entity<Vrach>(entity =>
        {
            entity.HasKey(e => e.IdVracha);

            entity.ToTable("Vrach");

            entity.Property(e => e.IdVracha)
                .ValueGeneratedNever()
                .HasColumnName("ID_Vracha");
            entity.Property(e => e.ChasiPriemaDo).HasColumnName("Chasi_priema_do");
            entity.Property(e => e.ChasiPriemaS).HasColumnName("Chasi_priema_s");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.NomerKabineta).HasColumnName("Nomer_Kabineta");
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
        });

        modelBuilder.Entity<VremyaPari>(entity =>
        {
            entity.HasKey(e => e.NomerPari);

            entity.ToTable("Vremya_Pari");

            entity.Property(e => e.NomerPari).HasColumnName("Nomer_Pari");
        });

        modelBuilder.Entity<Waybill>(entity =>
        {
            entity.HasKey(e => e.IdWaybill);

            entity.ToTable("waybill");

            entity.Property(e => e.IdWaybill).HasColumnName("ID_waybill");
            entity.Property(e => e.IdStorage).HasColumnName("ID_storage");
            entity.Property(e => e.IdStore).HasColumnName("ID_store");
            entity.Property(e => e.IdUser).HasColumnName("ID_User");

            entity.HasOne(d => d.IdStorageNavigation).WithMany(p => p.Waybills)
                .HasForeignKey(d => d.IdStorage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_waybill_storagee");

            entity.HasOne(d => d.IdStoreNavigation).WithMany(p => p.Waybills)
                .HasForeignKey(d => d.IdStore)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_waybill_store");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Waybills)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_waybill_storekeeper");

            entity.HasOne(d => d.IdUser1).WithMany(p => p.Waybills)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_waybill_userstore");
        });

        modelBuilder.Entity<WaybillGood>(entity =>
        {
            entity.HasKey(e => e.IdWaybillGoods);

            entity.ToTable("waybillGoods");

            entity.Property(e => e.IdWaybillGoods).HasColumnName("ID_waybillGoods");
            entity.Property(e => e.IdGoods).HasColumnName("ID_goods");
            entity.Property(e => e.IdWaybill).HasColumnName("ID_waybill");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.IdGoodsNavigation).WithMany(p => p.WaybillGoods)
                .HasForeignKey(d => d.IdGoods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_waybillGoods_goodss");

            entity.HasOne(d => d.IdWaybillNavigation).WithMany(p => p.WaybillGoods)
                .HasForeignKey(d => d.IdWaybill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_waybillGoods_waybill");
        });

        modelBuilder.Entity<Zadanie>(entity =>
        {
            entity.ToTable("Zadanie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
        });

        modelBuilder.Entity<Zakaz>(entity =>
        {
            entity.HasKey(e => e.IdZakaz);

            entity.ToTable("Zakaz");

            entity.Property(e => e.IdZakaz)
                .ValueGeneratedNever()
                .HasColumnName("ID_Zakaz");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Zakaz1>(entity =>
        {
            entity.HasKey(e => e.IdZakaz);

            entity.ToTable("Zakaz1");

            entity.Property(e => e.IdZakaz)
                .ValueGeneratedNever()
                .HasColumnName("ID_Zakaz");
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.KlientNavigation).WithMany(p => p.Zakaz1s)
                .HasForeignKey(d => d.Klient)
                .HasConstraintName("FK_Zakaz1_klient1");
        });

        modelBuilder.Entity<Zakaz2>(entity =>
        {
            entity.HasKey(e => e.IdZakaz);

            entity.ToTable("Zakaz2");

            entity.Property(e => e.IdZakaz)
                .ValueGeneratedNever()
                .HasColumnName("ID_Zakaz");
            entity.Property(e => e.DataZakaza).HasColumnName("Data_zakaza");
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.ClientNavigation).WithMany(p => p.Zakaz2s)
                .HasForeignKey(d => d.Client)
                .HasConstraintName("FK_Zakaz2_Client1");
        });

        modelBuilder.Entity<Zakaz4>(entity =>
        {
            entity.HasKey(e => e.IdZakaza);

            entity.ToTable("Zakaz4");

            entity.Property(e => e.IdZakaza).HasColumnName("ID_Zakaza");
            entity.Property(e => e.DataIspolneniya).HasColumnName("Data_ispolneniya");
            entity.Property(e => e.DataOformleniya).HasColumnName("Data_oformleniya");
            entity.Property(e => e.IdKlient).HasColumnName("ID_Klient");
            entity.Property(e => e.IdSotrudnik).HasColumnName("ID_Sotrudnik");
            entity.Property(e => e.IdStatus).HasColumnName("ID_Status");
            entity.Property(e => e.IdVidRaboti).HasColumnName("ID_VId_Raboti");
            entity.Property(e => e.KolVoEdenic).HasColumnName("Kol_vo_edenic");

            entity.HasOne(d => d.IdKlientNavigation).WithMany(p => p.Zakaz4s)
                .HasForeignKey(d => d.IdKlient)
                .HasConstraintName("FK_Zakaz4_Klient");

            entity.HasOne(d => d.IdSotrudnikNavigation).WithMany(p => p.Zakaz4s)
                .HasForeignKey(d => d.IdSotrudnik)
                .HasConstraintName("FK_Zakaz4_Sotrudniki");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Zakaz4s)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_Zakaz4_Status1");

            entity.HasOne(d => d.IdVidRabotiNavigation).WithMany(p => p.Zakaz4s)
                .HasForeignKey(d => d.IdVidRaboti)
                .HasConstraintName("FK_Zakaz4_Vid_Raboti");
        });

        modelBuilder.Entity<ZakazProdukciya>(entity =>
        {
            entity.HasKey(e => e.IdZakazProdukciya);

            entity.ToTable("zakaz_produkciya");

            entity.Property(e => e.IdZakazProdukciya)
                .ValueGeneratedNever()
                .HasColumnName("id_zakaz_produkciya");
            entity.Property(e => e.Cena).HasColumnName("cena");
            entity.Property(e => e.IdProdukciyii).HasColumnName("id_produkciyii");
            entity.Property(e => e.IdZakaza).HasColumnName("id_zakaza");
            entity.Property(e => e.Kolichestvo).HasColumnName("kolichestvo");
        });

        modelBuilder.Entity<Zakazhi>(entity =>
        {
            entity.HasKey(e => e.IdZakaza).HasName("PK__zakazhi__17350987521E2B3F");

            entity.ToTable("zakazhi");

            entity.Property(e => e.IdZakaza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id_zakaza");
            entity.Property(e => e.Addres)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("addres");
            entity.Property(e => e.Buyer)
                .HasDefaultValue(false)
                .HasColumnName("buyer");
            entity.Property(e => e.Inn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("inn");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Salesman)
                .HasDefaultValue(false)
                .HasColumnName("salesman");
        });

        modelBuilder.Entity<Zakazi>(entity =>
        {
            entity.HasKey(e => e.IdZakaza);

            entity.ToTable("Zakazi");

            entity.Property(e => e.IdZakaza).HasColumnName("ID_Zakaza");
            entity.Property(e => e.DataOtgruzki).HasColumnName("Data_Otgruzki");
            entity.Property(e => e.DataZakaza).HasColumnName("Data_Zakaza");
            entity.Property(e => e.IdPolushatel).HasColumnName("ID_Polushatel");
            entity.Property(e => e.NomerNakladnoy).HasColumnName("Nomer_Nakladnoy");

            entity.HasOne(d => d.IdPolushatelNavigation).WithMany(p => p.Zakazis)
                .HasForeignKey(d => d.IdPolushatel)
                .HasConstraintName("FK_Zakazi_Polushateli");
        });

        modelBuilder.Entity<Zanyatie1>(entity =>
        {
            entity.HasKey(e => e.IdZanyatie);

            entity.ToTable("zanyatie1");

            entity.Property(e => e.IdZanyatie).HasColumnName("id_zanyatie");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdDisciplina).HasColumnName("id_disciplina");
            entity.Property(e => e.IdGruppa).HasColumnName("id_gruppa");
            entity.Property(e => e.IdPrepodovatel).HasColumnName("id_prepodovatel");

            entity.HasOne(d => d.IdDisciplinaNavigation).WithMany(p => p.Zanyatie1s)
                .HasForeignKey(d => d.IdDisciplina)
                .HasConstraintName("FK_zanyatie1_disciplina1");

            entity.HasOne(d => d.IdGruppaNavigation).WithMany(p => p.Zanyatie1s)
                .HasForeignKey(d => d.IdGruppa)
                .HasConstraintName("FK_zanyatie1_gruppa1");

            entity.HasOne(d => d.IdPrepodovatelNavigation).WithMany(p => p.Zanyatie1s)
                .HasForeignKey(d => d.IdPrepodovatel)
                .HasConstraintName("FK_zanyatie1_prepodovatel1");
        });

        modelBuilder.Entity<Zanyatiya>(entity =>
        {
            entity.HasKey(e => e.IdZanyatiya);

            entity.ToTable("Zanyatiya");

            entity.Property(e => e.IdZanyatiya)
                .ValueGeneratedNever()
                .HasColumnName("ID_Zanyatiya");
            entity.Property(e => e.TipZanyatiya)
                .HasMaxLength(50)
                .HasColumnName("Tip_Zanyatiya");
        });

        modelBuilder.Entity<Zayavka>(entity =>
        {
            entity.HasKey(e => e.IdZayavki);

            entity.ToTable("Zayavka");

            entity.Property(e => e.IdZayavki).HasColumnName("ID_Zayavki");
            entity.Property(e => e.DataZayavki).HasColumnName("Data_zayavki");
            entity.Property(e => e.IdKlienta).HasColumnName("ID_Klienta");
            entity.Property(e => e.IdLekarstva).HasColumnName("ID_Lekarstva");
            entity.Property(e => e.IdProdavca).HasColumnName("ID_Prodavca");

            entity.HasOne(d => d.IdKlientaNavigation).WithMany(p => p.Zayavkas)
                .HasForeignKey(d => d.IdKlienta)
                .HasConstraintName("FK_Zayavka_Klientt");

            entity.HasOne(d => d.IdLekarstvaNavigation).WithMany(p => p.Zayavkas)
                .HasForeignKey(d => d.IdLekarstva)
                .HasConstraintName("FK_Zayavka_Lekarstva");

            entity.HasOne(d => d.IdProdavcaNavigation).WithMany(p => p.Zayavkas)
                .HasForeignKey(d => d.IdProdavca)
                .HasConstraintName("FK_Zayavka_Prodavecc");
        });

        modelBuilder.Entity<_0209Material>(entity =>
        {
            entity.HasKey(e => e.IdMaterial);

            entity.ToTable("02.09_material");

            entity.Property(e => e.IdMaterial)
                .ValueGeneratedNever()
                .HasColumnName("id_material");
            entity.Property(e => e.Cena).HasColumnName("cena");
            entity.Property(e => e.EdIzmereniya)
                .HasMaxLength(50)
                .HasColumnName("ed_izmereniya");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("kod");
            entity.Property(e => e.Naimenovanie)
                .HasMaxLength(50)
                .HasColumnName("naimenovanie");
        });

        modelBuilder.Entity<_0209Produkciya>(entity =>
        {
            entity.HasKey(e => e.IdProdukciya);

            entity.ToTable("02.09_produkciya");

            entity.Property(e => e.IdProdukciya)
                .ValueGeneratedNever()
                .HasColumnName("id_produkciya");
            entity.Property(e => e.EdIzmereniya)
                .HasMaxLength(50)
                .HasColumnName("ed_izmereniya");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("kod");
            entity.Property(e => e.Naimenovanie)
                .HasMaxLength(50)
                .HasColumnName("naimenovanie");
        });

        modelBuilder.Entity<_0209Proizvodstvo>(entity =>
        {
            entity.HasKey(e => e.IdProizvodstvo);

            entity.ToTable("02.09_proizvodstvo");

            entity.Property(e => e.IdProizvodstvo)
                .ValueGeneratedNever()
                .HasColumnName("id_proizvodstvo");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdProdukcii).HasColumnName("id_produkcii");
            entity.Property(e => e.Kolichestvo).HasColumnName("kolichestvo");

            entity.HasOne(d => d.IdProdukciiNavigation).WithMany(p => p._0209Proizvodstvos)
                .HasForeignKey(d => d.IdProdukcii)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_02.09_proizvodstvo_02.09_produkciya");
        });

        modelBuilder.Entity<_0209RashodMaterialov>(entity =>
        {
            entity.HasKey(e => e.IdRashodMaterialov);

            entity.ToTable("02.09_rashod_materialov");

            entity.Property(e => e.IdRashodMaterialov)
                .ValueGeneratedNever()
                .HasColumnName("id_rashod_materialov");
            entity.Property(e => e.IdMateriala).HasColumnName("id_materiala");
            entity.Property(e => e.IdProizvodstva).HasColumnName("id_proizvodstva");
            entity.Property(e => e.Rashod)
                .HasMaxLength(50)
                .HasColumnName("rashod");

            entity.HasOne(d => d.IdMaterialaNavigation).WithMany(p => p._0209RashodMaterialovs)
                .HasForeignKey(d => d.IdMateriala)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_02.09_rashod_materialov_02.09_material");

            entity.HasOne(d => d.IdProizvodstvaNavigation).WithMany(p => p._0209RashodMaterialovs)
                .HasForeignKey(d => d.IdProizvodstva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_02.09_rashod_materialov_02.09_proizvodstvo");
        });

        modelBuilder.Entity<_0209Specifikaciya>(entity =>
        {
            entity.HasKey(e => e.IdSpecifikaciya);

            entity.ToTable("02.09_specifikaciya");

            entity.Property(e => e.IdSpecifikaciya)
                .ValueGeneratedNever()
                .HasColumnName("id_specifikaciya");
            entity.Property(e => e.IdMaterial).HasColumnName("id_material");
            entity.Property(e => e.IdProdukciya).HasColumnName("id_produkciya");
            entity.Property(e => e.KolichestvoNaEd).HasColumnName("kolichestvo_na_ed");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p._0209Specifikaciyas)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_02.09_specifikaciya_02.09_material");

            entity.HasOne(d => d.IdProdukciyaNavigation).WithMany(p => p._0209Specifikaciyas)
                .HasForeignKey(d => d.IdProdukciya)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_02.09_specifikaciya_02.09_produkciya");
        });

        modelBuilder.Entity<_0209Zakashiki>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("02.09_zakashiki");

            entity.Property(e => e.Adres)
                .HasMaxLength(150)
                .HasColumnName("adres");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .HasColumnName("FIO");
            entity.Property(e => e.IdZakashika).HasColumnName("id_zakashika");
            entity.Property(e => e.Inn).HasColumnName("INN");
            entity.Property(e => e.Pokupatel).HasColumnName("pokupatel");
            entity.Property(e => e.Prodavec).HasColumnName("prodavec");
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .HasColumnName("telephone");

            entity.HasOne(d => d.IdZakashikaNavigation).WithMany()
                .HasForeignKey(d => d.IdZakashika)
                .HasConstraintName("FK_02.09_zakashiki_02.09_zakaz");
        });

        modelBuilder.Entity<_0209Zakaz>(entity =>
        {
            entity.HasKey(e => e.IdZakaza);

            entity.ToTable("02.09_zakaz");

            entity.Property(e => e.IdZakaza)
                .ValueGeneratedNever()
                .HasColumnName("ID_zakaza");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdIspolnitel).HasColumnName("id_ispolnitel");
            entity.Property(e => e.IdZakazchika).HasColumnName("id_zakazchika");
        });

        modelBuilder.Entity<_0209ZakazProdukciya>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("02.09_zakaz_produkciya");

            entity.Property(e => e.Cena)
                .HasMaxLength(50)
                .HasColumnName("cena");
            entity.Property(e => e.IdProdukcii).HasColumnName("id_produkcii");
            entity.Property(e => e.IdZakazProdukcii).HasColumnName("ID_zakaz_produkcii");
            entity.Property(e => e.IdZakaza).HasColumnName("id_zakaza");
            entity.Property(e => e.Kolichestvo)
                .HasMaxLength(50)
                .HasColumnName("kolichestvo");

            entity.HasOne(d => d.IdProdukciiNavigation).WithMany()
                .HasForeignKey(d => d.IdProdukcii)
                .HasConstraintName("FK_02.09_zakaz_produkciya_02.09_produkciya");

            entity.HasOne(d => d.IdZakazaNavigation).WithMany()
                .HasForeignKey(d => d.IdZakaza)
                .HasConstraintName("FK_02.09_zakaz_produkciya_02.09_zakaz");
        });

        modelBuilder.Entity<_0302ArhivSotrudnikov>(entity =>
        {
            entity.HasKey(e => e.ArhivId).HasName("PK__03.02_Ar__9E4869687FDB44D0");

            entity.ToTable("03.02_ArhivSotrudnikov");

            entity.Property(e => e.ArhivId).HasColumnName("ArhivID");
            entity.Property(e => e.Dolzhnost).HasMaxLength(100);
            entity.Property(e => e.Fio)
                .HasMaxLength(200)
                .HasColumnName("FIO");
            entity.Property(e => e.Otdel).HasMaxLength(100);
            entity.Property(e => e.Prichina).HasMaxLength(200);
            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");
        });

        modelBuilder.Entity<_0302Bolnichnye>(entity =>
        {
            entity.HasKey(e => e.BolnichnyId).HasName("PK__03.02_Bo__BD7FB37507F71CFA");

            entity.ToTable("03.02_Bolnichnye");

            entity.HasIndex(e => e.NomerEln, "UQ__03.02_Bo__415A6E9CF6B4D965").IsUnique();

            entity.Property(e => e.BolnichnyId).HasColumnName("BolnichnyID");
            entity.Property(e => e.NomerEln)
                .HasMaxLength(20)
                .HasColumnName("NomerELN");
            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");

            entity.HasOne(d => d.Sotrudnik).WithMany(p => p._0302Bolnichnyes)
                .HasForeignKey(d => d.SotrudnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bolnichnye_Sotrudniki");
        });

        modelBuilder.Entity<_0302Dolzhnosti>(entity =>
        {
            entity.HasKey(e => e.DolzhnostId).HasName("PK__03.02_Do__92BE7F06C62D928E");

            entity.ToTable("03.02_Dolzhnosti");

            entity.HasIndex(e => e.Nazvanie, "UQ__03.02_Do__C5571E6ECC1FAD3C").IsUnique();

            entity.Property(e => e.DolzhnostId).HasColumnName("DolzhnostID");
            entity.Property(e => e.Nazvanie).HasMaxLength(100);
            entity.Property(e => e.Oklad).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<_0302OcenkaKompetenciy>(entity =>
        {
            entity.HasKey(e => e.OcenkaId).HasName("PK__03.02_Oc__DC04D238C134FFFC");

            entity.ToTable("03.02_OcenkaKompetenciy");

            entity.Property(e => e.OcenkaId).HasColumnName("OcenkaID");
            entity.Property(e => e.DataOcenki)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Kommentariy).HasMaxLength(500);
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");

            entity.HasOne(d => d.Sotrudnik).WithMany(p => p._0302OcenkaKompetenciys)
                .HasForeignKey(d => d.SotrudnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ocenka_Sotrudniki");
        });

        modelBuilder.Entity<_0302Podrazdeleniya>(entity =>
        {
            entity.HasKey(e => e.PodrazdelenieId).HasName("PK__03.02_Po__C276B1E0DB91E00F");

            entity.ToTable("03.02_Podrazdeleniya");

            entity.HasIndex(e => e.Nazvanie, "UQ__03.02_Po__C5571E6E159839C9").IsUnique();

            entity.Property(e => e.PodrazdelenieId).HasColumnName("PodrazdelenieID");
            entity.Property(e => e.Nazvanie).HasMaxLength(100);
            entity.Property(e => e.Rukovoditel).HasMaxLength(150);
        });

        modelBuilder.Entity<_0302ProizvodstvennyyKalendar>(entity =>
        {
            entity.HasKey(e => e.KalendarId).HasName("PK__03.02_Pr__B29A7AA0DC522A36");

            entity.ToTable("03.02_ProizvodstvennyyKalendar");

            entity.HasIndex(e => e.Data, "UQ__03.02_Pr__77387D0B899EA549").IsUnique();

            entity.Property(e => e.KalendarId).HasColumnName("KalendarID");
            entity.Property(e => e.Kommentariy).HasMaxLength(200);
            entity.Property(e => e.NormaChasov).HasDefaultValue(8);
            entity.Property(e => e.TipDnya).HasMaxLength(20);
        });

        modelBuilder.Entity<_0302RaschetnyeListki>(entity =>
        {
            entity.HasKey(e => e.ListokId).HasName("PK__03.02_Ra__12CA7673F5E39378");

            entity.ToTable("03.02_RaschetnyeListki");

            entity.Property(e => e.ListokId).HasColumnName("ListokID");
            entity.Property(e => e.Itogo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Nadbavki).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Ndfl)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("NDFL");
            entity.Property(e => e.Oklad).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Period).HasMaxLength(20);
            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");

            entity.HasOne(d => d.Sotrudnik).WithMany(p => p._0302RaschetnyeListkis)
                .HasForeignKey(d => d.SotrudnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Listki_Sotrudniki");
        });

        modelBuilder.Entity<_0302Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__03.02_Ro__8AFACE3AC0DB0DDB");

            entity.ToTable("03.02_Roles");

            entity.HasIndex(e => e.RoleName, "UQ__03.02_Ro__8A2B61604B60B2F4").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<_0302ShtatnoeRaspisanie>(entity =>
        {
            entity.HasKey(e => e.ShtatId).HasName("PK__03.02_Sh__D13654D4157F751C");

            entity.ToTable("03.02_ShtatnoeRaspisanie");

            entity.Property(e => e.ShtatId).HasColumnName("ShtatID");
            entity.Property(e => e.DolzhnostId).HasColumnName("DolzhnostID");
            entity.Property(e => e.PodrazdelenieId).HasColumnName("PodrazdelenieID");

            entity.HasOne(d => d.Dolzhnost).WithMany(p => p._0302ShtatnoeRaspisanies)
                .HasForeignKey(d => d.DolzhnostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shtat_Dolzhnosti");

            entity.HasOne(d => d.Podrazdelenie).WithMany(p => p._0302ShtatnoeRaspisanies)
                .HasForeignKey(d => d.PodrazdelenieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shtat_Podrazdeleniya");
        });

        modelBuilder.Entity<_0302Sotrudniki>(entity =>
        {
            entity.HasKey(e => e.SotrudnikId).HasName("PK__03.02_So__83B4D268F59C1700");

            entity.ToTable("03.02_Sotrudniki");

            entity.HasIndex(e => e.Snils, "UQ__03.02_So__7EB2A6F9F8BEF419").IsUnique();

            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");
            entity.Property(e => e.DolzhnostId).HasColumnName("DolzhnostID");
            entity.Property(e => e.Familiya).HasMaxLength(50);
            entity.Property(e => e.Imya).HasMaxLength(50);
            entity.Property(e => e.Inn)
                .HasMaxLength(12)
                .HasColumnName("INN");
            entity.Property(e => e.Otchestvo).HasMaxLength(50);
            entity.Property(e => e.PodrazdelenieId).HasColumnName("PodrazdelenieID");
            entity.Property(e => e.Snils)
                .HasMaxLength(11)
                .HasColumnName("SNILS");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Активен");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Dolzhnost).WithMany(p => p._0302Sotrudnikis)
                .HasForeignKey(d => d.DolzhnostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sotrudniki_Dolzhnosti");

            entity.HasOne(d => d.Podrazdelenie).WithMany(p => p._0302Sotrudnikis)
                .HasForeignKey(d => d.PodrazdelenieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sotrudniki_Podrazdeleniya");

            entity.HasOne(d => d.User).WithMany(p => p._0302Sotrudnikis)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Sotrudniki_Users");
        });

        modelBuilder.Entity<_0302Tabel>(entity =>
        {
            entity.HasKey(e => e.TabelId).HasName("PK__03.02_Ta__7E69B8355891867A");

            entity.ToTable("03.02_Tabel");

            entity.Property(e => e.TabelId).HasColumnName("TabelID");
            entity.Property(e => e.Chasov).HasDefaultValue(8);
            entity.Property(e => e.Prichina).HasMaxLength(50);
            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");
            entity.Property(e => e.Yavka).HasDefaultValue(true);

            entity.HasOne(d => d.Sotrudnik).WithMany(p => p._0302Tabels)
                .HasForeignKey(d => d.SotrudnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tabel_Sotrudniki");
        });

        modelBuilder.Entity<_0302TipyOtpustov>(entity =>
        {
            entity.HasKey(e => e.TipOtpustaId).HasName("PK__03.02_Ti__B3E391970A4F8FCB");

            entity.ToTable("03.02_TipyOtpustov");

            entity.HasIndex(e => e.Nazvanie, "UQ__03.02_Ti__C5571E6E9CDAB600").IsUnique();

            entity.Property(e => e.TipOtpustaId).HasColumnName("TipOtpustaID");
            entity.Property(e => e.Nazvanie).HasMaxLength(50);
        });

        modelBuilder.Entity<_0302User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__03.02_Us__1788CCACB2B87969");

            entity.ToTable("03.02_Users");

            entity.HasIndex(e => e.Login, "UQ__03.02_Us__5E55825BFB00E684").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p._0302Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        modelBuilder.Entity<_0302Zayavleniya>(entity =>
        {
            entity.HasKey(e => e.ZayavlenieId).HasName("PK__03.02_Za__B8FAB9D237DE45E9");

            entity.ToTable("03.02_Zayavleniya");

            entity.Property(e => e.ZayavlenieId).HasColumnName("ZayavlenieID");
            entity.Property(e => e.DataSozdaniya)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SotrudnikId).HasColumnName("SotrudnikID");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValue("На согласовании");
            entity.Property(e => e.TipOtpustaId).HasColumnName("TipOtpustaID");

            entity.HasOne(d => d.Sotrudnik).WithMany(p => p._0302Zayavleniyas)
                .HasForeignKey(d => d.SotrudnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Zayavleniya_Sotrudniki");

            entity.HasOne(d => d.TipOtpusta).WithMany(p => p._0302Zayavleniyas)
                .HasForeignKey(d => d.TipOtpustaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Zayavleniya_TipyOtpustov");
        });

        modelBuilder.Entity<_0309Role>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("03.09_role");

            entity.Property(e => e.IdRole)
                .ValueGeneratedNever()
                .HasColumnName("id_role");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<_0309Role1>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.ToTable("03.09_roles");

            entity.Property(e => e.IdRole)
                .ValueGeneratedNever()
                .HasColumnName("id_role");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<_0309Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus);

            entity.ToTable("03.09_status");

            entity.Property(e => e.IdStatus)
                .ValueGeneratedNever()
                .HasColumnName("id_status");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<_0309User>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("03.09_user");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.LastLoginDate).HasColumnName("last_login_date");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .HasColumnName("patronymic");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p._0309Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_03.09_user_03.09_role");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p._0309Users)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_03.09_user_03.09_status");
        });

        modelBuilder.Entity<_0309User1>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("03.09_users");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.IsBlocked).HasColumnName("isBlocked");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p._0309User1s)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_03.09_users_03.09_roles");
        });

        modelBuilder.Entity<_0502Client>(entity =>
        {
            entity.ToTable("05_02_Client");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MainImage).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);

            entity.HasOne(d => d.GenderCodeNavigation).WithMany(p => p._0502Clients)
                .HasForeignKey(d => d.GenderCode)
                .HasConstraintName("FK_05_02_Client_Gender");

            entity.HasMany(d => d.Tags).WithMany(p => p.Clients)
                .UsingEntity<Dictionary<string, object>>(
                    "_0502TagOfClient",
                    r => r.HasOne<_0502Tag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_05_02_TagOfClient_Tag"),
                    l => l.HasOne<_0502Client>().WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_05_02_TagOfClient_Client"),
                    j =>
                    {
                        j.HasKey("ClientId", "TagId");
                        j.ToTable("05_02_TagOfClient");
                        j.IndexerProperty<int>("ClientId").HasColumnName("ClientID");
                        j.IndexerProperty<int>("TagId").HasColumnName("TagID");
                    });
        });

        modelBuilder.Entity<_0502Client1>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.ToTable("05_02_clients");

            entity.Property(e => e.IdClient)
                .ValueGeneratedNever()
                .HasColumnName("id_client");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Patronymic)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<_0502ClientService>(entity =>
        {
            entity.ToTable("05_02_ClientService");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.Client).WithMany(p => p._0502ClientServices)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_ClientService_Client");

            entity.HasOne(d => d.Service).WithMany(p => p._0502ClientServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_ClientService_Service");
        });

        modelBuilder.Entity<_0502DocumentByService>(entity =>
        {
            entity.ToTable("05_02_DocumentByService");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientServiceId).HasColumnName("ClientServiceID");
            entity.Property(e => e.DocumentPath).HasMaxLength(1000);

            entity.HasOne(d => d.ClientService).WithMany(p => p._0502DocumentByServices)
                .HasForeignKey(d => d.ClientServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_DocumentByService_ClientService");
        });

        modelBuilder.Entity<_0502Gender>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("05_02_Gender");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(10);
        });

        modelBuilder.Entity<_0502Manufacturer>(entity =>
        {
            entity.ToTable("05_02_Manufacturer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<_0502Product>(entity =>
        {
            entity.ToTable("05_02_Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.MainImagePath).HasMaxLength(1000);
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.Manufacturer).WithMany(p => p._0502Products)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_05_02_Product_Manufacturer");

            entity.HasMany(d => d.AttachedProducts).WithMany(p => p.MainProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "_0502AttachedProduct",
                    r => r.HasOne<_0502Product>().WithMany()
                        .HasForeignKey("AttachedProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_05_02_AttachedProduct_Product1"),
                    l => l.HasOne<_0502Product>().WithMany()
                        .HasForeignKey("MainProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_05_02_AttachedProduct_Product"),
                    j =>
                    {
                        j.HasKey("MainProductId", "AttachedProductId");
                        j.ToTable("05_02_AttachedProduct");
                        j.IndexerProperty<int>("MainProductId").HasColumnName("MainProductID");
                        j.IndexerProperty<int>("AttachedProductId").HasColumnName("AttachedProductID");
                    });

            entity.HasMany(d => d.MainProducts).WithMany(p => p.AttachedProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "_0502AttachedProduct",
                    r => r.HasOne<_0502Product>().WithMany()
                        .HasForeignKey("MainProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_05_02_AttachedProduct_Product"),
                    l => l.HasOne<_0502Product>().WithMany()
                        .HasForeignKey("AttachedProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_05_02_AttachedProduct_Product1"),
                    j =>
                    {
                        j.HasKey("MainProductId", "AttachedProductId");
                        j.ToTable("05_02_AttachedProduct");
                        j.IndexerProperty<int>("MainProductId").HasColumnName("MainProductID");
                        j.IndexerProperty<int>("AttachedProductId").HasColumnName("AttachedProductID");
                    });
        });

        modelBuilder.Entity<_0502ProductPhoto>(entity =>
        {
            entity.ToTable("05_02_ProductPhoto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p._0502ProductPhotos)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_ProductPhoto_Product");
        });

        modelBuilder.Entity<_0502ProductSale>(entity =>
        {
            entity.ToTable("05_02_ProductSale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientServiceId).HasColumnName("ClientServiceID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SaleDate).HasColumnType("datetime");

            entity.HasOne(d => d.ClientService).WithMany(p => p._0502ProductSales)
                .HasForeignKey(d => d.ClientServiceId)
                .HasConstraintName("FK_05_02_ProductSale_ClientService");
        });

        modelBuilder.Entity<_0502Service>(entity =>
        {
            entity.ToTable("05_02_Service");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.MainImagePath).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<_0502ServicePhoto>(entity =>
        {
            entity.ToTable("05_02_ServicePhoto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

            entity.HasOne(d => d.Service).WithMany(p => p._0502ServicePhotos)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_05_02_ServicePhoto_05_02_Service");
        });

        modelBuilder.Entity<_0502Tag>(entity =>
        {
            entity.ToTable("05_02_Tag");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(30);
        });

        modelBuilder.Entity<_18090502Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__18.09050__3214EC077F1A0356");

            entity.ToTable("18.090502_Roles");

            entity.HasIndex(e => e.Name, "UQ__18.09050__737584F6231A2604").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<_1809Gruzoviki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__18.09_Gr__3214EC07844490EB");

            entity.ToTable("18.09_Gruzoviki");

            entity.HasIndex(e => e.Nomer, "UQ__18.09_Gr__2DF21C2C89B8A539").IsUnique();

            entity.Property(e => e.Gruzopodemnost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Nomer).HasMaxLength(20);
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValue("Свободен");
            entity.Property(e => e.Tip).HasMaxLength(50);
        });

        modelBuilder.Entity<_1809Gruzoviki1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Gru__3214EC07942AF2B8");

            entity.ToTable("1809_Gruzoviki");

            entity.HasIndex(e => e.Nomer, "UQ__1809_Gru__2DF21C2CA2CC78DD").IsUnique();

            entity.Property(e => e.DataTo)
                .HasColumnType("datetime")
                .HasColumnName("DataTO");
            entity.Property(e => e.Gruzopodemnost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Marka).HasMaxLength(100);
            entity.Property(e => e.Nomer).HasMaxLength(20);
            entity.Property(e => e.Obyom).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Primechaniya).HasMaxLength(255);
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValue("Свободен");
            entity.Property(e => e.Tip).HasMaxLength(50);
        });

        modelBuilder.Entity<_1809IstoriyaStatusov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Ist__3214EC07F0DA4DB5");

            entity.ToTable("1809_IstoriyaStatusov");

            entity.HasIndex(e => e.OrderId, "idx_1809_istoriya_order");

            entity.Property(e => e.Izmeneno).HasColumnType("datetime");
            entity.Property(e => e.NovyyStatus).HasMaxLength(30);
            entity.Property(e => e.StaryyStatus).HasMaxLength(30);

            entity.HasOne(d => d.IzmenilUser).WithMany(p => p._1809IstoriyaStatusovs)
                .HasForeignKey(d => d.IzmenilUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1809_Istoriya_Users");

            entity.HasOne(d => d.Order).WithMany(p => p._1809IstoriyaStatusovs)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_1809_Istoriya_Zakazy");
        });

        modelBuilder.Entity<_1809Izbrannoe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("18.09_izbrannoe");

            entity.Property(e => e.IdGoroskop).HasColumnName("id_goroskop");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdGoroskopNavigation).WithMany()
                .HasForeignKey(d => d.IdGoroskop)
                .HasConstraintName("FK_18.09_izbrannoe_goroskop");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_18.09_izbrannoe_18.09_users");
        });

        modelBuilder.Entity<_1809Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__18.09_Ro__3214EC07461BD2F6");

            entity.ToTable("18.09_Roles");

            entity.HasIndex(e => e.Name, "UQ__18.09_Ro__737584F6DEF2398C").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<_1809Role1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Rol__3214EC0720424745");

            entity.ToTable("1809_Roles");

            entity.HasIndex(e => e.Name, "UQ__1809_Rol__737584F6E703BD47").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<_1809User>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("18.09_users");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.IdZodiak).HasColumnName("id_zodiak");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");

            entity.HasOne(d => d.IdZodiakNavigation).WithMany(p => p._1809Users)
                .HasForeignKey(d => d.IdZodiak)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_18.09_users_18.09_zodiakSign");
        });

        modelBuilder.Entity<_1809User1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Use__3214EC07177D713D");

            entity.ToTable("1809_Users");

            entity.HasIndex(e => e.Login, "UQ__1809_Use__5E55825BB24EDC4B").IsUnique();

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasOne(d => d.Role).WithMany(p => p._1809User1s)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1809_Users_Roles");
        });

        modelBuilder.Entity<_1809Voditeli>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Vod__3214EC07A885900D");

            entity.ToTable("1809_Voditeli");

            entity.HasIndex(e => e.NomerPrav, "UQ__1809_Vod__CADC1960EADA06F1").IsUnique();

            entity.Property(e => e.DataPriyoma).HasColumnType("datetime");
            entity.Property(e => e.Dostupen).HasDefaultValue(1);
            entity.Property(e => e.Kategorii).HasMaxLength(20);
            entity.Property(e => e.NomerPrav).HasMaxLength(30);
            entity.Property(e => e.StatusDostupnosti)
                .HasMaxLength(30)
                .HasDefaultValue("Доступен");

            entity.HasOne(d => d.Truck).WithMany(p => p._1809Voditelis)
                .HasForeignKey(d => d.TruckId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_1809_Voditeli_Gruzoviki");

            entity.HasOne(d => d.User).WithMany(p => p._1809Voditelis)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_1809_Voditeli_Users");
        });

        modelBuilder.Entity<_1809Zakazy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Zak__3214EC07CC848815");

            entity.ToTable("1809_Zakazy");

            entity.HasIndex(e => e.ClientId, "idx_1809_zakazy_client");

            entity.HasIndex(e => e.DriverId, "idx_1809_zakazy_driver");

            entity.HasIndex(e => e.Status, "idx_1809_zakazy_status");

            entity.Property(e => e.AdresKuda).HasMaxLength(255);
            entity.Property(e => e.AdresOtkuda).HasMaxLength(255);
            entity.Property(e => e.Dostavlen).HasColumnType("datetime");
            entity.Property(e => e.NazvanieGruza).HasMaxLength(200);
            entity.Property(e => e.Sozdan).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValue("Создан");
            entity.Property(e => e.Tsena).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Ves).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Client).WithMany(p => p._1809Zakazies)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1809_Zakazy_Users");

            entity.HasOne(d => d.Driver).WithMany(p => p._1809Zakazies)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_1809_Zakazy_Voditeli");

            entity.HasOne(d => d.Truck).WithMany(p => p._1809Zakazies)
                .HasForeignKey(d => d.TruckId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_1809_Zakazy_Gruzoviki");
        });

        modelBuilder.Entity<_1809ZhurnalAuditum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1809_Zhu__3214EC07691CD6CD");

            entity.ToTable("1809_ZhurnalAudita");

            entity.HasIndex(e => e.UserId, "idx_1809_audit_user");

            entity.Property(e => e.Deystvie).HasMaxLength(100);
            entity.Property(e => e.ImyaSushchnosti).HasMaxLength(100);
            entity.Property(e => e.Vremya).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p._1809ZhurnalAudita)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_1809_Audit_Users");
        });

        modelBuilder.Entity<_1809ZodiakSign>(entity =>
        {
            entity.HasKey(e => e.IdZodiakSign);

            entity.ToTable("18.09_zodiakSign");

            entity.Property(e => e.IdZodiakSign)
                .ValueGeneratedNever()
                .HasColumnName("id_zodiakSign");
            entity.Property(e => e.DateEnd).HasColumnName("date_end");
            entity.Property(e => e.DateStart).HasColumnName("date_start");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<_1klient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("1klient");

            entity.Property(e => e.Adres).HasColumnName("adres");
            entity.Property(e => e.Familiya).HasColumnName("familiya");
            entity.Property(e => e.IdKlient).HasColumnName("id_klient");
            entity.Property(e => e.Imya).HasColumnName("imya");
            entity.Property(e => e.Otchestvo).HasColumnName("otchestvo");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
