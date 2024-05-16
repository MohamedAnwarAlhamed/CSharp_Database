
public class TweetConfiguration : IEntityTypeConfiguration<Tweet>
{
    public void Configure(EntityTypeBuilder<Tweet> builder)
    {
        builder.ToTable("tblTweets");
    }
}

