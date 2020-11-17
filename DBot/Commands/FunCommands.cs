using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        [Description("Pong pong pong!!!")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("Giỏi")]
        [RequireRoles(RoleCheckMode.All, "Moderator")]
        public async Task ThanksSir(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Dạ cám ơn ông chủ").ConfigureAwait(false);
        }

        [Command("add")]
        [Description("Cộng hai số nguyên")]
        public async Task Add(CommandContext ctx, 
            [Description("Số nguyên thứ nhất")] int numberOne,
            [Description("Số nguyên thứ hai")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo).ToString())
                .ConfigureAwait(false);
        }
    }
}
