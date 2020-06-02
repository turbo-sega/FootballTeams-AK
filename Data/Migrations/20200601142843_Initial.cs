using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Championships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    IsNational = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Coaches = table.Column<string>(maxLength: 500, nullable: false),
                    History = table.Column<string>(maxLength: 2000, nullable: true),
                    GameScheme = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Number = table.Column<string>(maxLength: 20, nullable: false),
                    Position = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: false),
                    ChampionshipId = table.Column<int>(nullable: false),
                    Years = table.Column<string>(maxLength: 20, nullable: false),
                    IsChampion = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamStatistics_Championships_ChampionshipId",
                        column: x => x.ChampionshipId,
                        principalTable: "Championships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamStatistics_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Championships",
                columns: new[] { "Id", "Country", "IsNational", "Name" },
                values: new object[,]
                {
                    { 1, "Італія", true, "Серія А" },
                    { 2, "Італія", true, "Кубок Італії" },
                    { 3, "Іспанія", true, "Ла-Ліга" },
                    { 4, "Іспанія", true, "Кубок Іспанії" },
                    { 5, "Англія", true, "Прем'єр-ліга" },
                    { 6, "Англія", true, "Кубок Англії" },
                    { 7, "", false, "Ліга чемпіонів УЄФА" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Coaches", "Country", "GameScheme", "History", "Name" },
                values: new object[,]
                {
                    { 1, "Турин", "Мауріціо Саррі", "Італія", "2-4-4", null, "Ювентус" },
                    { 2, "Барселона", "Ернесто Вальверде", "Іспанія", "2-4-4", null, "Барселона" },
                    { 3, "Енфілд", "Юрген Клопп", "Англія", "2-4-4", null, "Ліверпуль" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "Number", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, "Войчех Шченсний", "1", null, 1 },
                    { 31, "Мохамед салах", "11", null, 3 },
                    { 29, "Джордан Хендерсон", "14", null, 3 },
                    { 28, "Садіо Мане", "10", null, 3 },
                    { 27, "Ендрю Робертсон", "26", null, 3 },
                    { 26, "Джо Гомес", "12", null, 3 },
                    { 25, "Вірджил ван Дейк", "4", null, 3 },
                    { 12, "Марк-Андре тер Штеген", "22", null, 2 },
                    { 13, "Нелсон Семеду", "2", null, 2 },
                    { 14, "Жерар Піке", "3", null, 2 },
                    { 15, "Жоржи Альба", "18", null, 2 },
                    { 16, "Самюель Умтіті", "23", null, 2 },
                    { 17, "Артуро Відаль", "22", null, 2 },
                    { 18, "Френкі де йонг", "21", null, 2 },
                    { 19, "Усман Дембеле", "11", null, 2 },
                    { 20, "Антуан Грізман", "17", null, 2 },
                    { 21, "Луіс Суарес", "9", null, 2 },
                    { 22, "Ліонель Мессі", "10", null, 2 },
                    { 24, "Трент Александр-Арнольд", "66", null, 3 },
                    { 23, "Алісон Беккер", "13", null, 3 },
                    { 32, "Роберто Фірміно", "9", null, 3 },
                    { 33, "Дивок Орігі", "27", null, 3 },
                    { 30, "Фабіньйо", "3", null, 3 },
                    { 8, "Айрон Ремзі", "8", null, 1 },
                    { 9, "Пауло Дібала", "10", null, 1 },
                    { 10, "Фредеріко Бернандескі", "33", null, 1 },
                    { 11, "Кріштіану Роналду", "7", null, 1 },
                    { 5, "Даніло", "13", null, 1 },
                    { 4, "Алекс Сандро", "12", null, 1 },
                    { 3, "Матейс де Лігт", "4", null, 1 },
                    { 2, "Леонардо Бонуччі", "19", null, 1 },
                    { 6, "Миралем Пяніч", "5", null, 1 },
                    { 7, "Блез Матюіді", "14", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "TeamStatistics",
                columns: new[] { "Id", "ChampionshipId", "IsChampion", "TeamId", "Years" },
                values: new object[,]
                {
                    { 51, 7, true, 2, "2006" },
                    { 54, 7, true, 2, "2015" },
                    { 50, 7, true, 2, "1992" },
                    { 49, 4, true, 2, "2018" },
                    { 48, 4, true, 2, "2017" },
                    { 47, 4, true, 2, "2016" },
                    { 46, 4, true, 2, "2015" },
                    { 45, 4, true, 2, "2012" },
                    { 44, 4, true, 2, "2009" },
                    { 52, 7, true, 2, "2009" },
                    { 53, 7, true, 2, "2011" },
                    { 58, 5, true, 3, "1987/88" },
                    { 70, 7, true, 3, "1984" },
                    { 57, 5, true, 3, "1985/86" },
                    { 56, 5, true, 3, "1981/82" },
                    { 55, 5, true, 3, "1979/80" },
                    { 60, 6, true, 3, "1965" },
                    { 61, 6, true, 3, "1974" },
                    { 62, 6, true, 3, "1986" },
                    { 59, 5, true, 3, "1989/90" },
                    { 43, 4, true, 2, "1998" },
                    { 64, 6, true, 3, "1992" },
                    { 65, 6, true, 3, "2001" },
                    { 66, 6, true, 3, "2006" },
                    { 67, 7, true, 3, "1977" },
                    { 68, 7, true, 3, "1978" },
                    { 69, 7, true, 3, "1981" },
                    { 63, 6, true, 3, "1989" },
                    { 42, 4, true, 2, "1997" },
                    { 31, 3, true, 2, "2008/09" },
                    { 40, 4, true, 2, "1988" },
                    { 17, 1, true, 1, "2018/19" },
                    { 16, 1, true, 1, "2017/18" },
                    { 15, 1, true, 1, "2016/17" },
                    { 14, 1, true, 1, "2015/16" },
                    { 13, 1, true, 1, "2014/15" },
                    { 12, 1, true, 1, "2013/14" },
                    { 11, 1, true, 1, "2012/13" },
                    { 10, 1, true, 1, "2011/12" },
                    { 9, 1, true, 1, "2005/06" },
                    { 8, 1, true, 1, "2004/05" },
                    { 7, 1, true, 1, "2002/03" },
                    { 6, 1, true, 1, "2001/02" },
                    { 5, 1, true, 1, "1997/98" },
                    { 4, 1, true, 1, "1996/97" },
                    { 3, 1, true, 1, "1994/95" },
                    { 2, 1, true, 1, "1985/86" },
                    { 1, 1, true, 1, "1983/84" },
                    { 18, 2, true, 1, "1982/83" },
                    { 19, 2, true, 1, "1989/90" },
                    { 20, 2, true, 1, "1994/95" },
                    { 21, 2, true, 1, "2014/15" },
                    { 39, 4, true, 2, "1981" },
                    { 38, 4, true, 2, "1978" },
                    { 37, 3, true, 2, "2017/18" },
                    { 36, 3, true, 2, "2015/16" },
                    { 35, 3, true, 2, "2014/15" },
                    { 34, 3, true, 2, "2012/13" },
                    { 33, 3, true, 2, "2010/11" },
                    { 32, 3, true, 2, "2009/10" },
                    { 41, 4, true, 2, "1990" },
                    { 71, 7, true, 3, "2005" },
                    { 29, 3, true, 2, "2004/05" },
                    { 28, 3, true, 2, "1998/99" },
                    { 27, 3, true, 2, "1994/95" },
                    { 26, 3, true, 2, "1992/93" },
                    { 25, 7, true, 1, "1995/96" },
                    { 24, 7, true, 1, "1984/85" },
                    { 23, 2, true, 1, "2017/18" },
                    { 22, 2, true, 1, "2015/16" },
                    { 30, 3, true, 2, "2005/06" },
                    { 72, 7, true, 3, "2019" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatistics_ChampionshipId",
                table: "TeamStatistics",
                column: "ChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatistics_TeamId",
                table: "TeamStatistics",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "TeamStatistics");

            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
