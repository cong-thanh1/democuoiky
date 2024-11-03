using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace listnhac.Model
{
    public partial class ModelMediaApp : DbContext
    {
        public ModelMediaApp()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public virtual DbSet<PlaylistVideo> PlaylistVideos { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSession> UserSessions { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playlist>()
                .HasMany(e => e.PlaylistSongs)
                .WithRequired(e => e.Playlist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Playlist>()
                .HasMany(e => e.PlaylistVideos)
                .WithRequired(e => e.Playlist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Song>()
                .HasMany(e => e.PlaylistSongs)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Song>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Songs)
                .Map(m => m.ToTable("UserSongs").MapLeftKey("SongId").MapRightKey("UserId"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.Videos)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("UserVideos").MapLeftKey("UserId").MapRightKey("VideoId"));

            modelBuilder.Entity<Video>()
                .HasMany(e => e.PlaylistVideos)
                .WithRequired(e => e.Video)
                .WillCascadeOnDelete(false);
        }
    }
}
