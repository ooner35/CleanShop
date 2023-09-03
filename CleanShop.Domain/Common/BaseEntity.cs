namespace CleanShop.Domain.Common
{
    public abstract class BaseEntity : IEntityTimeStamps
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
