using System.Collections.Generic;

namespace Ink.Core.Domain
{
    public class Center
    {
        public Center()
        {            
            Takings = new HashSet<Taking>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public bool IsDefault { get; set; }        
        public int? ParentCenterId { get; set; }
        public bool IsActive { get; set; }
        public virtual Center ParentCenter { get; set; }
        public ICollection<Center> Children { get; set; }

        public virtual ICollection<Taking> Takings { get; set; }
    }
}

/*public class BucketGroup
{
  public int Id {get;set;} 

  public string Name {get;set;}

  public int? ParentCenterId {get;set;}

  public virtual BucketGroup ParentBucketGroup-ParentCenter {get;set;}

  public virtual ICollection<BucketGroup> Children { get; set; }
}
And, to configure the relationship, you could override the OnModelCreating method on your context:

modelbuilder.Entity<Center>().HasOptional(b=>b.ParentCenter )
                                  .WithMany(b=>b.Children )
                                  .HasForeignKey(b=>b.ParentCenterId);
                                  */
