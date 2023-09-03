namespace CleanShop.Domain.Common
{
    public interface IEntityTimeStamps
    {
        DateTime CreatedDate { get; set; }

        DateTime? ModifiedDate { get; set; }

        DateTime? DeletedDate { get; set; }
    }
}
