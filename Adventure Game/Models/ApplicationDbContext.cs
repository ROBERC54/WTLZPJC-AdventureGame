using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adventure_Game.Models;

namespace Adventure_Game.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AccessPoint> AccessPoints  { get; set; }
        public DbSet<AccessRequirement> AccessRequirements{ get; set; }
        public DbSet<Consumable> Consumables  { get; set; }
        public DbSet<Enemy> Enemies  { get; set; }
        public DbSet<Fightlog> Fightlogs  { get; set; }
        public DbSet<InventoryItem> InventoryItems  { get; set; }
        public DbSet<Item> Items  { get; set; }
        public DbSet<ItemType> ItemTypes  { get; set; }
        public DbSet<Screen> Screens  { get; set; }
        public DbSet<ScreenEnemy> ScreenEnemies  { get; set; }
        public DbSet<ScreenItem> ScreenItems  { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
