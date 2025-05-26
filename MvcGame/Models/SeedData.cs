using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGame.Data;
using System;
using System.Linq;

namespace MvcGame.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcGameContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcGameContext>>()))
        {
            // Look for any movies.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }
            context.Game.AddRange(
                new Game
                {
                    Player = "Yatoro",
                    Character = "Terror Blade",
                    Level = 23,
                    Gold = 20400,
                    Result = "Win"
                },
                new Game
                {
                    Player = "quarwey",
                    Character = "Hoodwink",
                    Level = 30,
                    Gold = 45000,
                    Result = "Win"
                },
                new Game
                {
                    Player = "Ame",
                    Character = "Anti Mage",
                    Level = 20,
                    Gold = 15000,
                    Result = "Lose"
                },
                new Game
                {
                    Player = "Zhenya",
                    Character = "Dark Willow",
                    Level = 1,
                    Gold = 0,
                    Result = "Lose"
                }
            );
            context.SaveChanges();
        }
    }
}