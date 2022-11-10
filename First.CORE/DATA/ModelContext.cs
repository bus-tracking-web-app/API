using Microsoft.EntityFrameworkCore;

#nullable disable

namespace First.CORE.DATA
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

        public virtual DbSet<Aboutu> Aboutus { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Attendancestatus> Attendancestatuses { get; set; }
        public virtual DbSet<Bu> buses { get; set; }
        public virtual DbSet<Contactu> Contactus { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Roundstatus> Roundstatuses { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<Testimonialstatus> Testimonialstatuses { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=JOR17_User162;PASSWORD=Bus123;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("JOR17_USER162")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Aboutu>(entity =>
            {
                entity.ToTable("ABOUTUS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Information)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("INFORMATION");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("ATTENDANCE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Attendancestatus)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ATTENDANCESTATUS");

                entity.Property(e => e.Busid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BUSID");

                entity.Property(e => e.Dateofattendance)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEOFATTENDANCE");

                entity.Property(e => e.Studentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STUDENTID");

                entity.HasOne(d => d.AttendancestatusNavigation)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.Attendancestatus)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ATTENDANCESTATUS1");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.Busid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BUS3");
            });

            modelBuilder.Entity<Attendancestatus>(entity =>
            {
                entity.ToTable("ATTENDANCESTATUS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<Bu>(entity =>
            {
                entity.ToTable("BUS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Busdriver)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BUSDRIVER");

                entity.Property(e => e.Busnumber)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BUSNUMBER");

                entity.Property(e => e.Round)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROUND");

                entity.Property(e => e.Teacher)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TEACHER");

                entity.HasOne(d => d.BusdriverNavigation)
                    .WithMany(p => p.BuBusdriverNavigations)
                    .HasForeignKey(d => d.Busdriver)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BUSDRIVER");

                entity.HasOne(d => d.RoundNavigation)
                    .WithMany(p => p.Bus)
                    .HasForeignKey(d => d.Round)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ROUND");

                entity.HasOne(d => d.TeacherNavigation)
                    .WithMany(p => p.BuTeacherNavigations)
                    .HasForeignKey(d => d.Teacher)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_TEACHER");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.ToTable("CONTACTUS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Massage)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("MASSAGE");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("FOOTER");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Abouttxt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABOUTTXT");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Titel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITEL");

                entity.Property(e => e.Txt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TXT");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Roundstatus>(entity =>
            {
                entity.ToTable("ROUNDSTATUS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Roundstatus1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ROUNDSTATUS");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("ROUTE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Busid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BUSID");

                entity.Property(e => e.Xcurrent)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("XCURRENT");

                entity.Property(e => e.Xend)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("XEND");

                entity.Property(e => e.Xstart)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("XSTART");

                entity.Property(e => e.Ycurrent)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("YCURRENT");

                entity.Property(e => e.Yend)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("YEND");

                entity.Property(e => e.Ystart)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("YSTART");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.Busid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BUS2");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("SCHOOL");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Logo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LOGO");

                entity.Property(e => e.Xschool)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("XSCHOOL");

                entity.Property(e => e.Yschool)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("YSCHOOL");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Busid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BUSID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Imgpath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMGPATH");

                entity.Property(e => e.Inbusstatus)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("INBUSSTATUS");

                entity.Property(e => e.Parentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENTID");

                entity.Property(e => e.Round)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROUND");

                entity.Property(e => e.Xhome)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("XHOME");

                entity.Property(e => e.Yhome)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("YHOME");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Busid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_STUDENTBUS");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Parentid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_STUDENTPARENTID");

                entity.HasOne(d => d.RoundNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Round)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_STUDENTROUND");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FEEDBACK");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Statusid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATUSID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_STATUSID");
            });

            modelBuilder.Entity<Testimonialstatus>(entity =>
            {
                entity.ToTable("TESTIMONIALSTATUS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ROLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
