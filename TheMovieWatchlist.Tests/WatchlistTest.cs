using TheMovieWatchlist.Components;
using TheMovieWatchlist.Data;

namespace TheMovieWatchlist.Tests;

public class WatchlistTest : BunitTestContext
{
    [Test]
    public void WatchlistMovieTest()
    {
        var component = RenderComponent<ActorRoleCard>(parameter =>
            parameter.Add(p =>
                p.Actor, new Actorlist
                {
                    id = "1",
                    name = "Drew",
                    image = "file.jpg",
                    asCharacter = "Karl"
                }
                ));

        Assert.AreEqual(component.FindAll("p")[0].InnerHtml, "Drew");
        Assert.AreEqual(component.FindAll("p")[1].InnerHtml, "Karl");
    }
}
