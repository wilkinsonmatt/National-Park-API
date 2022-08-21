using Microsoft.EntityFrameworkCore;

namespace ParkLookUp.Models
{
    public class ParkLookUpContext : DbContext
    {
        public ParkLookUpContext(DbContextOptions<ParkLookUpContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 1, Name = "Acadia", State = "Maine", YearFounded = 1919 },
                new Park { ParkId = 2, Name = "American Samoa", State = "American Samoa", YearFounded = 1988 },
                new Park { ParkId = 3, Name = "Arches", State = "Utah", YearFounded = 1929 },
                new Park { ParkId = 4, Name = "Badlands", State = "South Dakota", YearFounded = 1978 },
                new Park { ParkId = 5, Name = "Big Bend", State = "Texas", YearFounded = 1944 },
                new Park { ParkId = 6, Name = "Biscayne", State = "Florida", YearFounded = 1980 },
                new Park { ParkId = 7, Name = "Black Canyon of the Gunnison", State = "Colorado", YearFounded = 1999 },
                new Park { ParkId = 8, Name = "Bryce Canyon", State = "Utah", YearFounded = 1928 },
                new Park { ParkId = 9, Name = "Canyonlands", State = "Utah", YearFounded = 1964 },
                new Park { ParkId = 10, Name = "Capitol Reef", State = "Utah", YearFounded = 1971 },
                new Park { ParkId = 11, Name = "Carlsbad Caverns", State = "New Mexico", YearFounded = 1930 },
                new Park { ParkId = 12, Name = "Channel Islands", State = "California", YearFounded = 1980 },
                new Park { ParkId = 13, Name = "Congaree", State = "South Carolina", YearFounded = 2003 },
                new Park { ParkId = 14, Name = "Crater Lake", State = "Oregon", YearFounded = 1902 },
                new Park { ParkId = 15, Name = "Cuyahoga Valley", State = "Ohio", YearFounded = 1974 },
                new Park { ParkId = 16, Name = "Death Valley", State = "California", YearFounded = 1994 },
                new Park { ParkId = 17, Name = "Denali", State = "Alaska", YearFounded = 1917 },
                new Park { ParkId = 18, Name = "Dry Tortugas", State = "Florida", YearFounded = 1935 },
                new Park { ParkId = 19, Name = "Everglades", State = "Florida", YearFounded = 1947 },
                new Park { ParkId = 20, Name = "Gates of the Arctic", State = "Alaska", YearFounded = 1980 },
                new Park { ParkId = 21, Name = "Gateway Arch", State = "Missouri", YearFounded = 2018 },
                new Park { ParkId = 22, Name = "Glacier", State = "Montana", YearFounded = 1910 },
                new Park { ParkId = 23, Name = "Glacier Bay", State = "Alaska", YearFounded = 1980 },
                new Park { ParkId = 24, Name = "Grand Canyon", State = "Arizona", YearFounded = 1919 },
                new Park { ParkId = 25, Name = "Grand Teton", State = "Wyoming", YearFounded = 1929 },
                new Park { ParkId = 26, Name = "Great Basin", State = "Nevada", YearFounded = 1986 },
                new Park { ParkId = 27, Name = "Great Sand Dunes", State = "Colorado", YearFounded = 1932 },
                new Park { ParkId = 28, Name = "Great Smoky Mountains", State = "Tennessee", YearFounded = 1934 },
                new Park { ParkId = 29, Name = "Guadalupe Mountains", State = "Texas", YearFounded = 1972 },
                new Park { ParkId = 30, Name = "Haleakala", State = "Hawaii", YearFounded = 1961 },
                new Park { ParkId = 31, Name = "Hawai’i Volcanoes", State = "Hawaii", YearFounded = 1916 },
                new Park { ParkId = 32, Name = "Hot Springs", State = "Arkansas", YearFounded = 1921 },
                new Park { ParkId = 33, Name = "Indiana Dunes", State = "Indiana", YearFounded = 2019 },
                new Park { ParkId = 34, Name = "Isle Royale", State = "Michigan", YearFounded = 1940 },
                new Park { ParkId = 35, Name = "Joshua Tree", State = "California", YearFounded = 1994 },
                new Park { ParkId = 36, Name = "Katmai", State = "Alaska", YearFounded = 1918 },
                new Park { ParkId = 37, Name = "Kenai Fjords", State = "Alaska", YearFounded = 1980 },
                new Park { ParkId = 38, Name = "Kings Canyon", State = "California", YearFounded = 1940 },
                new Park { ParkId = 39, Name = "Kobuk Valley", State = "Alaska", YearFounded = 1980 },
                new Park { ParkId = 40, Name = "Lake Clark", State = "Alaska", YearFounded = 1980 },
                new Park { ParkId = 41, Name = "Lassen Volcanic", State = "California", YearFounded = 1916 },
                new Park { ParkId = 42, Name = "Mammoth Cave", State = "Kentucky", YearFounded = 1941 },
                new Park { ParkId = 43, Name = "Mesa Verde", State = "Colorado", YearFounded = 1906 },
                new Park { ParkId = 44, Name = "Mount Rainier", State = "Washington", YearFounded = 1899 },
                new Park { ParkId = 45, Name = "New River Gorge", State = "West Virginia", YearFounded = 2020 },
                new Park { ParkId = 46, Name = "North Cascades", State = "Washington", YearFounded = 1968 },
                new Park { ParkId = 47, Name = "Olympic", State = "Washington", YearFounded = 1938 },
                new Park { ParkId = 48, Name = "Petrified Forest", State = "Arizona", YearFounded = 1962 },
                new Park { ParkId = 49, Name = "Pinnacles", State = "California", YearFounded = 2013 },
                new Park { ParkId = 50, Name = "Redwood", State = "California", YearFounded = 1968 },
                new Park { ParkId = 51, Name = "Rocky Mountain", State = "Colorado", YearFounded = 1915 },
                new Park { ParkId = 52, Name = "Saguaro", State = "Arizona", YearFounded = 1994 },
                new Park { ParkId = 53, Name = "Sequoia", State = "California", YearFounded = 1890 },
                new Park { ParkId = 54, Name = "Shenandoah", State = "Virginia", YearFounded = 1935 },
                new Park { ParkId = 55, Name = "Theodore Roosevelt", State = "North Dakota", YearFounded = 1978 },
                new Park { ParkId = 56, Name = "Virgin Islands", State = "US Virgin Islands", YearFounded = 1956 },
                new Park { ParkId = 57, Name = "Voyageurs", State = "Minnesota", YearFounded = 1975 },
                new Park { ParkId = 58, Name = "White Sands", State = "New Mexico", YearFounded = 2019 },
                new Park { ParkId = 59, Name = "Wind Cave", State = "South Dakota", YearFounded = 1903 },
                new Park { ParkId = 60, Name = "Wrangell-St. Elias", State = "Alaska", YearFounded = 1980 },
                new Park { ParkId = 61, Name = "Yellowstone", State = "Wyoming", YearFounded = 1872 },
                new Park { ParkId = 62, Name = "Yosemite", State = "California", YearFounded = 1890 },
                new Park { ParkId = 63, Name = "Zion", State = "Utah", YearFounded = 1919 }
            );
        }

        public DbSet<Park> Parks { get; set; }
    }
}