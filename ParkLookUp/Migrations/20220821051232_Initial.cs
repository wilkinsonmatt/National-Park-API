using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkLookUp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    YearFounded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "YearFounded" },
                values: new object[,]
                {
                    { 1, "Acadia", "Maine", 1919 },
                    { 34, "Isle Royale", "Michigan", 1940 },
                    { 35, "Joshua Tree", "California", 1994 },
                    { 36, "Katmai", "Alaska", 1918 },
                    { 37, "Kenai Fjords", "Alaska", 1980 },
                    { 38, "Kings Canyon", "California", 1940 },
                    { 39, "Kobuk Valley", "Alaska", 1980 },
                    { 40, "Lake Clark", "Alaska", 1980 },
                    { 41, "Lassen Volcanic", "California", 1916 },
                    { 42, "Mammoth Cave", "Kentucky", 1941 },
                    { 43, "Mesa Verde", "Colorado", 1906 },
                    { 44, "Mount Rainier", "Washington", 1899 },
                    { 45, "New River Gorge", "West Virginia", 2020 },
                    { 46, "North Cascades", "Washington", 1968 },
                    { 33, "Indiana Dunes", "Indiana", 2019 },
                    { 47, "Olympic", "Washington", 1938 },
                    { 49, "Pinnacles", "California", 2013 },
                    { 50, "Redwood", "California", 1968 },
                    { 51, "Rocky Mountain", "Colorado", 1915 },
                    { 52, "Saguaro", "Arizona", 1994 },
                    { 53, "Sequoia", "California", 1890 },
                    { 54, "Shenandoah", "Virginia", 1935 },
                    { 55, "Theodore Roosevelt", "North Dakota", 1978 },
                    { 56, "Virgin Islands", "US Virgin Islands", 1956 },
                    { 57, "Voyageurs", "Minnesota", 1975 },
                    { 58, "White Sands", "New Mexico", 2019 },
                    { 59, "Wind Cave", "South Dakota", 1903 },
                    { 60, "Wrangell-St. Elias", "Alaska", 1980 },
                    { 61, "Yellowstone", "Wyoming", 1872 },
                    { 48, "Petrified Forest", "Arizona", 1962 },
                    { 62, "Yosemite", "California", 1890 },
                    { 32, "Hot Springs", "Arkansas", 1921 },
                    { 30, "Haleakala", "Hawaii", 1961 },
                    { 2, "American Samoa", "American Samoa", 1988 },
                    { 3, "Arches", "Utah", 1929 },
                    { 4, "Badlands", "South Dakota", 1978 },
                    { 5, "Big Bend", "Texas", 1944 },
                    { 6, "Biscayne", "Florida", 1980 },
                    { 7, "Black Canyon of the Gunnison", "Colorado", 1999 },
                    { 8, "Bryce Canyon", "Utah", 1928 },
                    { 9, "Canyonlands", "Utah", 1964 },
                    { 10, "Capitol Reef", "Utah", 1971 },
                    { 11, "Carlsbad Caverns", "New Mexico", 1930 },
                    { 12, "Channel Islands", "California", 1980 },
                    { 13, "Congaree", "South Carolina", 2003 },
                    { 14, "Crater Lake", "Oregon", 1902 },
                    { 31, "Hawai’i Volcanoes", "Hawaii", 1916 },
                    { 15, "Cuyahoga Valley", "Ohio", 1974 },
                    { 17, "Denali", "Alaska", 1917 },
                    { 18, "Dry Tortugas", "Florida", 1935 },
                    { 19, "Everglades", "Florida", 1947 },
                    { 20, "Gates of the Arctic", "Alaska", 1980 },
                    { 21, "Gateway Arch", "Missouri", 2018 },
                    { 22, "Glacier", "Montana", 1910 },
                    { 23, "Glacier Bay", "Alaska", 1980 },
                    { 24, "Grand Canyon", "Arizona", 1919 },
                    { 25, "Grand Teton", "Wyoming", 1929 },
                    { 26, "Great Basin", "Nevada", 1986 },
                    { 27, "Great Sand Dunes", "Colorado", 1932 },
                    { 28, "Great Smoky Mountains", "Tennessee", 1934 },
                    { 29, "Guadalupe Mountains", "Texas", 1972 },
                    { 16, "Death Valley", "California", 1994 },
                    { 63, "Zion", "Utah", 1919 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
