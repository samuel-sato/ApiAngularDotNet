using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<PersonModel>
    {
        public void Configure(EntityTypeBuilder<PersonModel> builder)
        {
            builder.HasData(
                new PersonModel
                {
                    Id = new Guid(),
                    Name = "Teste",
                    Active = true,
                    Age = 23,
                    Email = "email@email.com"
                }
            );
        }
    }
}
