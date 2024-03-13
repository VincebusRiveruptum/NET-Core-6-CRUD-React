using System;
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
                    uid = table.Column<Guid>(type: "TEXT", nullable: false),
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
                values: new object[] { 95, null, "6294614778", "ALKEN ASSET MANAGEMENT", "027200760", "BARBGB2LKEN", new Guid("8cc0a47d-1ef6-40ff-8bf0-b6689aea7651") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 545, null, "3205585355", "ALLIED BANK PHILIPPINES (UK) PLC", "039468891", "BOFAGB4TCDO", new Guid("f6227478-ff23-4e45-86d0-67dc5cbadcad") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 557, null, "4453330102", "ABN AMRO CORPORATE FINANCE LIMITED", "095734116", "BSCHGB2LEQU", new Guid("8fcf7df6-a810-4cea-8189-6a06773d3458") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 639, null, "0527202304", "ABN AMRO HOARE GOVETT LIMITED", "613832458", "BARBGB2LBIR", new Guid("523367c0-fcb5-424a-bc43-16f8f919d48f") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 985, null, "5677377307", "ABG SUNDAL COLLIER LIMITED", "007645882", "ABCMGB21", new Guid("44ef9aac-156f-413d-a317-dc67d8ebd50a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1044, null, "6655882521", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "656597585", "BARBGB2LTOO", new Guid("8e312a88-6875-4e43-979a-5ba9fa9eb479") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1293, null, "0732132424", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "213559115", "UBKLGB2LXXX", new Guid("5feaab1c-8a0c-4ff8-8d5c-0f42164a3a8f") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1294, null, "1000747406", "ALLIED BANK PHILIPPINES (UK) PLC", "019076944", "ABAZGB21", new Guid("96220942-2eb0-4646-9082-8763b86cf6ee") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1384, null, "9920208729", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "690322703", "AKBKGB22XXX", new Guid("f2b3e060-060f-4a8d-a453-d4f4d3a0faa9") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1684, null, "4824836895", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "661169377", "BARBGB2LBIR", new Guid("e5da122c-a752-43bb-9022-0c1f9ec52a11") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1760, null, "9095140009", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "230376423", "ABECGB21", new Guid("023ae084-7ea0-4dde-9f30-a4513171325c") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1792, null, "4910392711", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "111710917", "ANTSGB2LCHA", new Guid("6ca24e05-533f-49f4-ad41-aa4ca5b2e4c9") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1794, null, "7153500295", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "015089126", "BARBGB2LSOU", new Guid("a2ff3881-b63a-4936-bb3e-4d400ef8d5da") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1839, null, "0578657349", "ABN AMRO MEZZANINE (UK) LIMITED", "263456611", "UBKLGB2LXXX", new Guid("2063985c-ffc8-4b60-a872-a18e7681cf91") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1843, null, "7631586084", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "312027904", "UBKLGB2LXXX", new Guid("cfe0502f-7d72-4ff1-96af-baf5f814ed01") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1926, null, "0895321850", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "008179247", "BRBAGB2LXXX", new Guid("efda52dd-6454-4c88-bf72-2a4fb16c97a3") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 1946, null, "5817841485", "PGMS (GLASGOW) LIMITED", "655558130", "BOFAGB22CLS", new Guid("bc055217-570e-47b9-b411-90d0daf0384a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2006, null, "3770488109", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "670089286", "BCYPGB2LCSB", new Guid("658a50f7-5dac-45df-b228-a04dc94a9943") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2111, null, "9391171613", "ABINGWORTH MANAGEMENT LIMITED", "632253717", "ABCEGB2L", new Guid("48ea6761-c9bc-4ee4-9dff-3f30ef25b716") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2238, null, "7289778048", "THE ROYAL BANK OF SCOTLAND PLC (FORMER RBS NV)", "682667719", "ANTSGB2LXXX", new Guid("3e742568-8d05-48e9-abc9-88e02dd74300") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2256, null, "8306921376", "ALKEN ASSET MANAGEMENT", "688226646", "BCYPGB2LMBB", new Guid("0f05e2f4-9127-490b-a868-bf7319a9e2a1") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2306, null, "0662038705", "ABU DHABI ISLAMIC BANK", "800639189", "ABNAGB21VOC", new Guid("2a22904f-1975-404d-a229-dd44125a41ba") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2437, null, "4395070320", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "050575255", "AKBKGB22XXX", new Guid("239c184c-cca3-4303-a641-7c3b838d2014") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2505, null, "5685927950", "ABN AMRO CORPORATE FINANCE LIMITED", "808230014", "ASTPGB2LXXX", new Guid("b5610193-37fc-4586-983f-044ddfc196cb") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2540, null, "7036346156", "ABC INTERNATIONAL BANK PLC", "320174250", "BOFAGB4TIPA", new Guid("f26d51ee-1d2c-4e3c-a731-0c8d851025b0") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2547, null, "1044565900", "ABINGWORTH MANAGEMENT LIMITED", "706139123", "ABECGB21", new Guid("2f6887d9-5dfd-41c0-a6e8-9620e9e087c4") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2593, null, "1099565609", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "613390084", "ALEIGB22TSY", new Guid("41c340f4-782e-45fe-9ca3-f1b1aaf4229b") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2646, null, "2327123106", "ABG SUNDAL COLLIER LIMITED", "662418506", "BRBAGB2LXXX", new Guid("7af616f1-3797-44ba-ad3a-a2e51a3b2f40") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2729, null, "7671772840", "ABN AMRO HOARE GOVETT SECURITIES", "637518693", "BOFAGB22SEC", new Guid("095d9a71-fef5-401c-876a-dd4d6ff52ffc") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2737, null, "0586994297", "ALLIED BANK PHILIPPINES (UK) PLC", "276129689", "BOFAGB22SEC", new Guid("05be1eb2-e6b6-48a1-8cb6-e64dd7e8591a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2946, null, "2175186024", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "307473835", "AAPUGB21", new Guid("3cf2f166-19b4-4ffe-bab9-bf5bc3f4fa64") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 2975, null, "2463636609", "ABN AMRO MEZZANINE (UK) LIMITED", "099099679", "BOFAGB4TCDO", new Guid("8c5ccac2-f47b-4783-b6c7-662cb1d46b1f") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3170, null, "5831043677", "ABN AMRO MEZZANINE (UK) LIMITED", "654479090", "BOFAGB22SEC", new Guid("918bd8f5-1143-468c-8f95-41c5b7b4bb64") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3331, null, "9062579305", "ABN AMRO MEZZANINE (UK) LIMITED", "677372967", "BCYPGB2LCBB", new Guid("616bcd45-d64c-415e-8520-7c8a016a2092") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3351, null, "0358369447", "ABN AMRO FUND MANAGERS LIMITED", "681060760", "BCYPGB2LXXX", new Guid("d47dd363-8f32-4315-8f96-e2060d78f0dc") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3583, null, "8215043803", "ALKEN ASSET MANAGEMENT", "681933114", "BARBGB2LTOO", new Guid("85a0c421-f342-46cf-b928-81e9172d6768") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3629, null, "8331595411", "ABN AMRO MEZZANINE (UK) LIMITED", "081857968", "ABECGB21", new Guid("d26adc51-e9a2-4e48-aee9-5072e136193d") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3730, null, "1859425221", "ALLIED BANK PHILIPPINES (UK) PLC", "238246351", "BCYPGB2LCSB", new Guid("e997e0fe-a72a-44bc-a8fa-64cbddc19e8c") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3735, null, "3464171977", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "087529737", "ANTSGB2LCHA", new Guid("5c4d5ef8-f44f-479a-aa1f-9af3ed0f9c58") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3754, null, "9789754046", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "614772012", "BARBGB2LHAR", new Guid("03ba9b37-e0d7-4201-92e2-2f7829ff6fde") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3897, null, "8030446400", "ABC INTERNATIONAL BANK PLC", "682672348", "AACCGB21", new Guid("5153c207-ff0c-4cb1-b1e2-7e38ed607d5a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 3996, null, "5734840945", "ALKEN ASSET MANAGEMENT", "269741142", "ABBYGB2L", new Guid("c7abe6e1-0c3e-4243-adcc-d792b41d4bc2") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4271, null, "9226259614", "AAC CAPITAL PARTNERS LIMITED", "315214549", "AAFMGB21", new Guid("ad2b4ef3-22cf-488c-8f14-b37cddfcf545") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4309, null, "7229890277", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "302500965", "BOFAGB22OF2", new Guid("e6298731-bd6f-4289-9d8c-8dbb2c0d73a7") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4312, null, "3609513352", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "087438420", "BCYPGB2LHGB", new Guid("969838ff-2e1d-48bb-b7b3-cd014997dfcc") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4659, null, "1895677287", "AAC CAPITAL PARTNERS LIMITED", "805097658", "ABCMGB21", new Guid("9c755920-0f13-4e73-a7f6-127daa0e2b05") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4663, null, "4382482909", "ALLIED BANK PHILIPPINES (UK) PLC", "613793270", "ABCMGB21", new Guid("3126cb6a-1642-4dea-a582-5f19e365857a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4781, null, "6474483826", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "004175902", "BOFAGB4TLFS", new Guid("ba669989-67d5-4aae-a66d-01df91fafa09") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4862, null, "6256633427", "ABN AMRO CORPORATE FINANCE LIMITED", "677596837", "UBKLGB2LXXX", new Guid("ed3770a3-9281-4c19-b521-7d267d508b39") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 4975, null, "1705669071", "ABN AMRO MEZZANINE (UK) LIMITED", "005031870", "BSABGB2LXXX", new Guid("a54bd811-3473-47a4-a1d6-694228612f0d") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5177, null, "8203501267", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "725393911", "ABCEGB2L", new Guid("c5709546-046d-4bb3-a0c9-7a8394ae0711") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5262, null, "4437955817", "ABBEY LIFE", "046206321", "ANTSGB2LXXX", new Guid("0b9a62ea-d523-49b9-b800-a9b52dd64914") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5265, null, "8528246590", "ABN AMRO HOARE GOVETT SECURITIES", "228396415", "BCYPGB2LCSB", new Guid("3bc33768-568d-4078-9c6a-f7bb21697f95") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5326, null, "1157408826", "ABN AMRO MEZZANINE (UK) LIMITED", "007996845", "BOFAGB22SCP", new Guid("57482c7c-a8c5-4d2a-a92c-8c53f218b1a9") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5402, null, "2259922501", "AAC CAPITAL PARTNERS LIMITED", "051693233", "ANTSGB2LCHA", new Guid("c1e7a6bf-6ce5-4ea2-bac6-1cc145340e2a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5410, null, "9498037270", "AAC CAPITAL PARTNERS LIMITED", "642524407", "BSABGB2LXXX", new Guid("d6ab2d75-d132-4a7b-91c1-b8a6f05aaf83") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5435, null, "7813923604", "ABN AMRO MEZZANINE (UK) LIMITED", "263232356", "BOFAGB4TCCD", new Guid("0812526d-3f9f-41a8-9a15-0464938beebd") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5616, null, "4750231753", "ABBEY LIFE", "115000212", "UBKLGB2LBAK", new Guid("88c2547b-ffd4-4a4b-ba31-e4cdcddfd239") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5679, null, "9356610914", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "683856419", "AAPUGB21", new Guid("b1a3dcd1-b169-4392-babb-0c4af503c2d5") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5702, null, "1677311862", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "305958404", "BCYPGB2LPGB", new Guid("6cde92e2-c03f-49c7-b865-7f0760a0eb45") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 5924, null, "1628405193", "ALKEN ASSET MANAGEMENT", "721579784", "ABNAGB21VOC", new Guid("1dd227d0-9096-4bfd-ae87-08f15a3486b8") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6124, null, "8736284876", "ABN AMRO CORPORATE FINANCE LIMITED", "285772687", "BSABGB2LXXX", new Guid("5d8ff2b6-68b4-4221-ad87-c2434300c20b") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6230, null, "1475069159", "AAC CAPITAL PARTNERS LIMITED", "621204793", "UBKLGB2LXXX", new Guid("3ddef91f-4e8d-40a9-9c69-daff86b6e9aa") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6256, null, "9678903551", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "098754630", "BCYPGB2LHHB", new Guid("20422dab-1cb5-4799-92e7-5641d0d4ee48") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6576, null, "7733616268", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "280428787", "BCYPGB2LSSB", new Guid("202e5533-4c36-4044-b89b-439fdd726827") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6614, null, "9338417038", "ABN AMRO CORPORATE FINANCE LIMITED", "284413921", "BOFAGB4TLFS", new Guid("63fca0d9-44cc-475b-abc9-eb205bf0f503") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6618, null, "7336430907", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "630931743", "AANLGB2L", new Guid("ccef4b43-cd27-4c07-beb3-02dcde9ab8a3") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6782, null, "4864943626", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "033154907", "AIBKGB2XTSY", new Guid("8eab14da-e0e5-45eb-a2b6-259a15cb8e42") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6940, null, "4191400435", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "257006527", "AANLGB2L", new Guid("cd1a2c4f-bb34-4d4b-8a34-5a429b8b7274") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 6966, null, "9581210759", "ABN AMRO FUND MANAGERS LIMITED", "642669304", "ABCEGB2L", new Guid("fa634263-569d-48f2-a964-6355368d9bdd") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7011, null, "3759084489", "ABBOTSTONE AGRICULTURAL PROPERTY UNIT TRUST", "807664186", "AAFMGB21", new Guid("9a6a8302-e6ec-4ac8-824e-d0902c0e54fe") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7028, null, "7653217065", "PGMS (GLASGOW) LIMITED", "060096261", "BARBGB2LKEN", new Guid("81ea1e59-eb33-4684-a322-1b50222c61bf") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7081, null, "4514427067", "ABN AMRO HOARE GOVETT LIMITED", "629265446", "BOFAGB22SCP", new Guid("cb1becf1-82e7-485c-b63e-be36202c9ba8") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7089, null, "3984496637", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "723798217", "ABFIGB21", new Guid("5527b36d-ca2f-46dd-900c-fbc83c60e296") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7159, null, "7125664297", "ABG SUNDAL COLLIER LIMITED", "115409664", "BKCHGB2LXXX", new Guid("df958dab-88c3-4d28-aebf-65236b08c96a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7217, null, "5566379053", "ALKEN ASSET MANAGEMENT", "102701647", "ABDIGB21", new Guid("62856ce0-8582-4115-a0f9-406bc4b10881") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7313, null, "4749848658", "ALKEN ASSET MANAGEMENT", "807143131", "BARBGB2LHAR", new Guid("864ff07b-10c0-4b63-a15e-4ac6e8cf4c16") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7429, null, "9794272840", "PGMS (GLASGOW) LIMITED", "307002536", "BCEYGB2LXXX", new Guid("2c3ef8cb-960e-41c2-b404-d5e1e5cb98a9") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7613, null, "5038086178", "ABG SUNDAL COLLIER LIMITED", "268561844", "BRBAGB2LXXX", new Guid("ef57993b-899a-4283-b5fd-cd89469a3430") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7643, null, "6579813345", "ABN AMRO HOARE GOVETT LIMITED", "241366781", "BOFAGB4TLTR", new Guid("c685cc36-43cd-4881-91ae-bbeb718da3cb") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7793, null, "9754118202", "ALKEN ASSET MANAGEMENT", "314834917", "UBKLGB2LBAK", new Guid("435adc76-08b9-4166-81bf-58e8c907b7d1") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7845, null, "5361107242", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "055093114", "BARBGB2LMAN", new Guid("51b321c1-678b-4c84-a803-aa4b6541a214") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7946, null, "5221183878", "AAC CAPITAL PARTNERS LIMITED", "266635015", "AAPUGB21", new Guid("5d31322b-dc0f-4f1e-b943-1ed5e87f680f") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 7959, null, "3387364407", "ABN AMRO FUND MANAGERS LIMITED", "243069701", "BOFAGB4TCCD", new Guid("1825b49c-2bcf-4e05-b10c-43c25cf78f32") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8130, null, "7192086499", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "708283679", "BSABGB2LXXX", new Guid("fcc5f6cd-c930-4924-949a-b35038ddd2be") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8499, null, "4452236206", "ALKEN ASSET MANAGEMENT", "087924581", "BCYPGB2LHHB", new Guid("aa97b56e-518c-4837-abbf-454f3176c1d2") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8650, null, "0722483217", "UBS CLEARING AND EXECUTION SERVICES LIMITED", "031229300", "BCYPGB2LBBB", new Guid("b33d7d04-1985-442d-85c2-a6ae987e67b6") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8709, null, "5483486474", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "727991638", "BOFAGB4TCDO", new Guid("09c5802f-80e5-492d-b90e-c423bb1342b5") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8828, null, "9908684348", "ABN AMRO QUOTED INVESTMENTS (UK) LIMITED", "028528373", "BSABGB2LXXX", new Guid("451ad112-a681-485f-b92e-7db7c33e66bc") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 8995, null, "5957424831", "OTKRITIE SECURITIES LIMITED", "326236749", "ABBYGB2L", new Guid("14c0be48-c9b9-4a42-8bbb-f5ac8728f561") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9118, null, "2681812229", "ABN AMRO HOARE GOVETT SECURITIES", "019085304", "ANTSGB2LCHA", new Guid("23da80f6-2c6a-4d5b-b4a3-34d8056154c2") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9216, null, "9415825639", "ALKEN ASSET MANAGEMENT", "001160936", "BKCHGB2LXXX", new Guid("5a79448a-82c4-44df-9fe0-78dfe7f1cdce") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9226, null, "0769351163", "ABN AMRO HOARE GOVETT CORPORATE FINANCE LTD.", "678582439", "BOFAGB4TLFS", new Guid("3fe5352a-1084-4760-89e9-c514cc3d7c16") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9300, null, "9329277815", "ABINGWORTH MANAGEMENT LIMITED", "068524353", "BCYPGB2LMBB", new Guid("2d5ed98e-56e3-4d3d-b26e-ec3afd48df5b") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9512, null, "4064094308", "ALKEN ASSET MANAGEMENT", "082601346", "AACNGB21", new Guid("2ecbfc9f-e177-4aee-916b-fe75264d811a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9514, null, "0909666287", "AAC CAPITAL PARTNERS LIMITED", "282347879", "BARBGB2LKEN", new Guid("4e8cbf9f-555f-4d9c-8952-6a71b13bf51a") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9528, null, "8519919354", "ALLIED BANK PHILIPPINES (UK) PLC", "619925660", "BARBGB2LKEN", new Guid("a4e16c1c-c509-4ebd-b807-3ff8b95b3262") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9709, null, "7683878143", "ABN AMRO CORPORATE FINANCE LIMITED", "260023429", "AANLGB2L", new Guid("0ed9bb84-7c3b-44e4-922a-68b1278edbc2") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9759, null, "1998013515", "AAC CAPITAL PARTNERS LIMITED", "051607847", "ANTSGB2LCHA", new Guid("d735a9f5-9ab5-412e-bd84-ae659915b7c5") });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "id", "IBAN", "account_number", "bank_name", "routing_number", "swift_bic", "uid" },
                values: new object[] { 9886, null, "9024294320", "ABG SUNDAL COLLIER LIMITED", "217927031", "BCYPGB2LMBB", new Guid("66418a05-5f55-4bc6-82d0-724a35aeef5f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");
        }
    }
}
