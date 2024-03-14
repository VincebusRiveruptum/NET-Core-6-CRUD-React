using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prueba_tecnica_finixgroup.Server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    uid = table.Column<string>(type: "TEXT", nullable: false, defaultValueSql: "lower(hex(randomblob(16)))"),
                    account_number = table.Column<string>(type: "TEXT", nullable: true),
                    IBAN = table.Column<string>(type: "TEXT", nullable: true),
                    bank_name = table.Column<string>(type: "TEXT", nullable: true),
                    routing_number = table.Column<string>(type: "TEXT", nullable: true),
                    swift_bic = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 22, null, "2340696804", "ABG SUNDAL COLLIER LIMITED", "641297955", "AAPUGB21", "ffad1a6f-36b8-4e9c-bc8a-200a5c83a564" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 224, null, "8998184740", "ALKEN ASSET MANAGEMENT", "063659045", "AIBKGB2XTSY", "8cc0a25e-29ad-41da-858a-19fa238b9bda" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 244, null, "3258937445", "ALKEN ASSET MANAGEMENT", "234043176", "BARBGB2LTOO", "0dce483a-a3df-401c-be23-a8ead87a977f" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 266, null, "6157187035", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "269868122", "ABCMGB21", "fd03bac5-c799-45d1-a112-184ae7c4c596" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 305, null, "3909346306", "ABC INTERNATIONAL BANK PLC", "048869300", "BKCHGB2LXXX", "1b37b3d9-88a5-45c1-941f-589f47139e53" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 621, null, "0906354893", "ABINGWORTH MANAGEMENT LIMITED", "323840002", "BOFAGB3SSWI", "090cef25-39d4-4e73-87bc-df7c5dc7dc89" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 763, null, "6361141667", "ALKEN ASSET MANAGEMENT", "646281924", "ABBYGB2L", "03a357be-c9b0-4e2c-a8c1-304f9412f309" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 940, null, "6274419110", "PGMS (GLASGOW) LIMITED", "611223218", "BOFAGB22OF2", "2d287a8c-54b2-4019-ab00-507119a68438" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1030, null, "4534031759", "ABU DHABI ISLAMIC BANK", "215913597", "AIBKGB2XTSY", "0a6f78b9-275f-487a-b843-5ceffca35b00" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1091, null, "0753818055", "ABN AMRO MEZZANINE (UK) LIMITED", "110352761", "ABCEGB2L", "91b871c8-3d99-47f0-ab6c-fb0c82e210aa" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1102, null, "2708738488", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "264209207", "BOFAGB4TLTR", "df777d5e-f739-483d-8211-01735f98388a" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1159, null, "9075948519", "ABN AMRO FUND MANAGERS LIMITED", "328674671", "BOFAGB3SSWI", "c78b1dd3-2f03-4f0a-a4a6-6a2c43c5613a" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1315, null, "0828824404", "ALKEN ASSET MANAGEMENT", "049830215", "ABCMGB21", "b3a29564-dfb2-483c-9f04-7fbf89ffb54d" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1604, null, "4677665145", "ABC INTERNATIONAL BANK PLC", "697745244", "BCYPGB2LHGB", "615d7645-3f65-4f24-aa5c-d6d88892dc84" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1643, null, "4808313284", "ABC INTERNATIONAL BANK PLC", "250876149", "BARBGB2LKIL", "514642b3-75b0-4261-b243-e8e2635e1173" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1712, null, "5048566035", "ABINGWORTH MANAGEMENT LIMITED", "077002235", "AAHOGB21", "4311f707-5aa3-45d3-aaeb-e7f964265cff" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2040, null, "7978914690", "ABN AMRO HOARE GOVETT LIMITED", "614897162", "UBKLGB2LBAK", "baea4835-a647-4eaa-b60f-70596579ade9" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2149, null, "0167111793", "ABN AMRO MEZZANINE (UK) LIMITED", "235725008", "ABAZGB21", "1f141bea-6cb8-43fa-a8ef-85b7e38af14d" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2243, null, "1012546588", "ALKEN ASSET MANAGEMENT", "315530003", "BCYPGB2LSSB", "84c56d8a-8dd3-40b1-86d2-f31f421d2b49" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2418, null, "5244753272", "ABN AMRO FUND MANAGERS LIMITED", "657074829", "ASTPGB2LXXX", "c17ecad3-f372-49d9-a26a-34628653b2e7" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2436, null, "5779014630", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "000318307", "BOFAGB22OF2", "d04a5452-75ca-4db5-b4f5-61e32bd4831a" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2515, null, "1620392290", "ABN AMRO MEZZANINE (UK) LIMITED", "128348398", "BOFAGB4TLFS", "f2c25cc6-1802-4d57-a86b-e0f52cbfdb52" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2624, null, "7204333852", "PGMS (GLASGOW) LIMITED", "002005540", "AAFMGB21", "1c956fa5-bdd3-488e-a1b0-bcc023c3068e" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2745, null, "7368276432", "ABN AMRO HOARE GOVETT SECURITIES", "258466344", "ABCCGB22", "a6e35170-1a58-4a37-9463-306c92d07b27" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2967, null, "4951420626", "ABG SUNDAL COLLIER LIMITED", "086797191", "BARBGB2LLEI", "d714149c-ac07-4cbc-8964-d77825e0b364" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3055, null, "3233094230", "ALLIED BANK PHILIPPINES (UK) PLC", "674502222", "BRBAGB2LXXX", "ed943ee2-5d68-49a4-933b-d18f18d4bb0d" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3061, null, "9738656138", "ABU DHABI ISLAMIC BANK", "064120159", "BOFAGB3SSWI", "d67945af-b2fa-4018-b9f1-c0e3d4094cf1" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3077, null, "1177210059", "ABBEY LIFE", "103259583", "AAFMGB21", "ce40343d-eb88-40c4-9e37-947780666007" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3104, null, "6706920964", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "027967980", "AACCGB21", "11049507-251e-43fa-9346-00a048a180f9" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3121, null, "8799350402", "OTKRITIE SECURITIES LIMITED", "232054730", "BCYPGB2LMBB", "2cddae93-abcb-44f6-9799-8bd8b107278f" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3220, null, "1007622495", "OTKRITIE SECURITIES LIMITED", "632641442", "ABNAGB21VOC", "c48373b5-b1f3-423c-a0c4-6eddcb014cf3" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3282, null, "0472524631", "ALKEN ASSET MANAGEMENT", "693911739", "MORLGB2LSMK", "4298afbc-8aaa-4ce7-9445-443c931af29b" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3389, null, "6435814142", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "240168922", "BKCHGB2LXXX", "2df76a3e-24f1-4e3e-85b5-7ce2cea191f9" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3480, null, "5704612496", "ABN AMRO FUND MANAGERS LIMITED", "028494436", "BARBGB2LMAN", "2f660ba0-610d-46e8-a445-c3175071ca2a" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3525, null, "6832417509", "ABINGWORTH MANAGEMENT LIMITED", "800735274", "BCYPGB2LPGB", "26470875-70b0-4ef3-bd07-57b2492115ce" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3530, null, "6690776043", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "803976865", "ANTSGB2LXXX", "96019b2a-a382-4a71-a120-4ba8b2476df3" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3567, null, "3285585516", "ABG SUNDAL COLLIER LIMITED", "216386589", "AAOGGB21", "961f425d-ab72-42cd-880b-b9bc55408d88" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3620, null, "5069122959", "ABN AMRO MEZZANINE (UK) LIMITED", "679460356", "AAHVGB21", "c164abda-b240-4809-84bf-0f4ac370717b" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3631, null, "0072558250", "ALKEN ASSET MANAGEMENT", "702838237", "BARBGB2LHAR", "5a09e442-c721-4967-a2f1-7d59cb3ae08a" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3654, null, "3441599921", "SANTANDER UK PLC", "321327213", "BCYPGB2LBBB", "79cdf916-4873-42de-a42d-bc7fc924b7ba" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3680, null, "1057359365", "ABN AMRO MEZZANINE (UK) LIMITED", "104640337", "AAPEGB21", "5bee8501-da0e-4dde-bdff-0576524f29aa" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3754, null, "3879438912", "ABN AMRO CORPORATE FINANCE LIMITED", "620738095", "BOFAGB22XXX", "add2b0ee-efff-46ba-9343-d6d725cff1e1" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3756, null, "2378527930", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "241811757", "UBKLGB2LBAK", "98688059-8fe9-4c52-8b9e-3484b69e837b" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3785, null, "2861612843", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "076809507", "BOFAGB4TLTR", "b9865057-8e05-48a0-b68a-bc66fcce2e85" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3800, null, "0794435344", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "227298789", "BKCHGB2UXXX", "04ef45b3-6463-4765-9249-391eb7864d2d" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3802, null, "6071659669", "ABINGWORTH MANAGEMENT LIMITED", "078363067", "ABBEGB21", "8e14b0e3-28f7-4fa0-b809-6b5a21e90831" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3817, null, "2038434614", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "065069549", "BOFAGB22XXX", "60ec56e9-52bd-4e67-87d3-23d3238af9be" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3898, null, "9811444763", "OTKRITIE SECURITIES LIMITED", "698458996", "AANLGB2L", "85061ea1-90de-4c2c-a3b0-78ac96a6a340" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4148, null, "9473112765", "ALLIED BANK PHILIPPINES (UK) PLC", "040207766", "BOFAGB22OF2", "fe0e65f3-e5a6-42d0-9c74-c1f75212d14e" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4324, null, "7895679073", "ABU DHABI ISLAMIC BANK", "069069228", "BOFAGB22SCP", "ba728df8-b668-41c9-9888-c49b58638734" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4346, null, "5664996531", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "035114770", "BOFAGB4TLFS", "aa693007-0b2d-4f19-b2d4-f0f8ca1a3eb7" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4358, null, "7827887923", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "276584855", "BCYPGB2LSSB", "a2160a7f-95df-4436-99f5-d55a8548a0ab" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4374, null, "5780068547", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "612711554", "ABAZGB21", "f96f0127-212c-4359-ae27-bc18596bc194" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4456, null, "2718513403", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "640532925", "BCYPGB2LCBB", "6ec7e2b7-2659-4c58-a459-3c657ef5d9de" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4494, null, "2480547311", "ALKEN ASSET MANAGEMENT", "112333665", "BARBGB2LMAN", "3b257f5f-03e6-45ea-a202-4f9302569c61" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4911, null, "3038318755", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "250621048", "BCYPGB2LBBB", "e2588ef1-5beb-4ac7-bb9b-8fe4ee5d3dd3" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4947, null, "4848684424", "ABN AMRO HOARE GOVETT SECURITIES", "044065302", "BCYPGB2LBBB", "52781a50-5530-4067-a7ef-e964bde5d599" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4954, null, "5041705789", "ABINGWORTH MANAGEMENT LIMITED", "803005134", "AAHVGB21", "a36b5787-2393-48ff-89d7-28542781bbfa" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4988, null, "6313763236", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "722517897", "ABNAGB21VOC", "f040b0d8-5ff8-45c8-b130-8c4d12b57114" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5081, null, "9860321542", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "657742012", "BARBGB2LLEI", "cb8da82c-d684-4f11-9be8-dde526a2d7fe" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5142, null, "2926630735", "ALKEN ASSET MANAGEMENT", "218537187", "BARBGB2LMAN", "3c864e81-7fcb-4b4e-9692-0b019ffe6665" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5284, null, "6832738618", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "265896185", "ABECGB21", "a1ebd9e3-d7c3-4d99-9201-ed1548f69014" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5286, null, "7399111702", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "106164222", "BARBGB2LTOO", "59f30812-98fa-4e0d-ba73-34bcf3dde129" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5430, null, "6616185510", "ABBEY LIFE", "324871656", "BCYPGB2LBBB", "425f1441-17d1-4570-b55f-bd875188e256" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5476, null, "0948977507", "ABG SUNDAL COLLIER LIMITED", "087033760", "UBKLGB2LXXX", "46541c0e-a583-4d35-807e-2bf7e039b25f" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5523, null, "4406897234", "ABN AMRO MEZZANINE (UK) LIMITED", "035827342", "BSABGB2LXXX", "a9a916fe-4ae1-4d27-a9e3-1dcdfe47be24" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5612, null, "8456711064", "ABU DHABI ISLAMIC BANK", "222800897", "MORLGB2LSMK", "b5a4df95-2594-4cf0-88bf-1d8e81d5eb02" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5656, null, "7768934454", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "069293968", "AAFMGB21", "237cc7f4-3e31-4da8-9cab-3f64f7cc57e5" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5722, null, "9324571965", "SANTANDER UK PLC", "013618861", "AAFMGB21", "bc668ddd-7e85-4008-b34a-d4240d7417a2" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5915, null, "5328822406", "ABN AMRO MEZZANINE (UK) LIMITED", "280279923", "BCYPGB2LCBB", "ed29c020-726e-4ff7-90f0-f6b3f21f1c45" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5921, null, "5884750084", "AAC CAPITAL PARTNERS LIMITED", "094421022", "UBKLGB2LXXX", "b5a7ea20-a156-4d81-8dff-b6b031f63a36" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5983, null, "2096461884", "ABU DHABI ISLAMIC BANK", "219073912", "AACCGB21", "e51df290-e837-4225-8b0f-31955120f816" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6087, null, "8040510153", "ABN AMRO CORPORATE FINANCE LIMITED", "685702561", "BOFAGB4TLTR", "f3dd32fa-d685-4c18-b4f8-9d80643a8f5f" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6207, null, "2623350128", "ABN AMRO HOARE GOVETT SECURITIES", "081291951", "ABBEGB21", "94a0983f-359a-4750-94c1-458275f56b3f" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6440, null, "3249515617", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "287170892", "BCYPGB2LPGB", "fad1ccdf-6179-495c-b894-561d85ba039b" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6469, null, "2587601314", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "062731304", "ABFIGB21", "0809e1c3-b3d3-4ad1-b45c-a33835ff2815" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6614, null, "4808912457", "ALLIED BANK PHILIPPINES (UK) PLC", "315853298", "BARBGB2LTOO", "2e3c5e3d-0607-447c-823a-81b092aeff9e" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6726, null, "9874041672", "ABN AMRO CORPORATE FINANCE LIMITED", "807532580", "BCYPGB2LHGB", "5f762587-1568-41eb-be26-82ac4e9a7ff8" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6983, null, "9528777042", "ABINGWORTH MANAGEMENT LIMITED", "106080746", "BARBGB2LBIR", "5339146d-5fb1-4ced-a95d-2612e4efc702" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7052, null, "1712915723", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "674404029", "ABCCGB22", "c7daa704-d455-479d-b3a8-8f56e237a2ff" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7104, null, "0997878822", "ABINGWORTH MANAGEMENT LIMITED", "070264627", "BCYPGB2LBBB", "e2c29dc9-e00f-4fab-afbf-88da79a69ed6" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7367, null, "4568167857", "ABINGWORTH MANAGEMENT LIMITED", "259533522", "AANLGB21", "dfbd3837-862d-4ecd-ad2a-24408aeeb7f2" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7697, null, "8210385685", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "301059174", "AAPUGB21", "aedfea8a-3b7c-4f9a-ae94-8bb8af5bb63e" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7699, null, "8977235708", "ABN AMRO CORPORATE FINANCE LIMITED", "804538943", "BCYPGB2LMBB", "ac580346-0a21-4ca8-a235-958dbbce9067" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7824, null, "2001619206", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "047648014", "ABCEGB2L", "8f173a2a-0693-4199-9577-c6be8f92605c" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7910, null, "5231057700", "ALLIED BANK PHILIPPINES (UK) PLC", "261579927", "UBKLGB2LXXX", "8777933e-b884-48f7-a78f-27da6d812b04" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7988, null, "4695001952", "ABN AMRO MEZZANINE (UK) LIMITED", "053067663", "AAFMGB21", "849a71e6-5dd0-4ae9-ae85-507c3af2afe9" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8115, null, "6510167356", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "046023481", "BOFAGB4TLTR", "ad61c979-54be-4d6c-a02d-747c9bab25ad" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8340, null, "1801484613", "ABG SUNDAL COLLIER LIMITED", "121323653", "ABAZGB21", "ab54e2b9-eec0-4382-9aac-ab25e396f1ae" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8391, null, "7715244346", "OTKRITIE SECURITIES LIMITED", "326946929", "BCEYGB2LXXX", "5c5dcde4-3b0f-422b-9407-3017b721e9a3" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8461, null, "2886802242", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "263975024", "AANLGB2L", "e00bbe8e-9d53-4f19-bf10-e8ab8d2ed201" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8588, null, "1239995315", "ABU DHABI ISLAMIC BANK", "110111889", "BARBGB2LMAN", "f1a257c1-eeda-4128-be46-6a2017b570f3" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8772, null, "6672148490", "ABBEY LIFE", "695943462", "AANLGB21", "3e521388-27ad-40a2-a75c-a4b479f757ef" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8822, null, "8666970108", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "803545445", "ABCMGB21", "ee0285d2-29ce-49d2-80d0-43a0f0994f52" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9036, null, "4415135339", "ALKEN ASSET MANAGEMENT", "277623317", "AAHVGB21", "7dda5625-ebf5-40ae-82fe-ed37b931e0fc" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9052, null, "5598352160", "ABBEY LIFE", "291144830", "ANTSGB2LCHA", "bd244a46-ce75-4986-b43f-08231a4ddc27" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9083, null, "2439906081", "ABN AMRO FUND MANAGERS LIMITED", "276618530", "AKBKGB22XXX", "7161361f-b782-4102-ae3e-c438bf37d202" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9395, null, "8996614354", "SANTANDER UK PLC", "106358737", "AANLGB2L", "12359219-6fbf-4b54-bbcd-e4a788d63cd3" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9719, null, "7009390273", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "643115200", "BOFAGB22CLS", "0152d7a0-6bd7-47fb-9d52-061a675b4849" });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9800, null, "6424979116", "ALKEN ASSET MANAGEMENT", "057854102", "BCYPGB2LCSB", "af305073-a2dc-4127-b71d-151ed845f4af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");
        }
    }
}
