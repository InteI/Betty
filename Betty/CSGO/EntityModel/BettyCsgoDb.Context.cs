﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Betty
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BettyContextCsgo : DbContext
    {
        public BettyContextCsgo()
            : base("name=BettyContextCsgo")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CsgoBets> csgo_bets { get; set; }
        public virtual DbSet<CsgoMatch> csgo_match { get; set; }
        public virtual DbSet<CsgoParserDetails> csgo_parser_details { get; set; }
        public virtual DbSet<CsgoPlayer> csgo_player { get; set; }
        public virtual DbSet<CsgoTeam> csgo_team { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}