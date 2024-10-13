using System.Text;
using System;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace BossChecklist
{
    [ApiVersion(2, 1)]
    public class BossChecklist_TShock : TerrariaPlugin
    {
        public override string Author => "HDSeventh, remade by Keyou";
        public override string Description => "Boss Checklist for TShock";
        public override string Name => "Boss Checklist";
        public override Version Version { get { return new Version(1, 0, 1); } }
        public BossChecklist_TShock(Main game) : base(game) { }
        public override void Initialize()
        {
            ServerApi.Hooks.GameInitialize.Register(this, OnInitialize);
        }

        public void OnInitialize(EventArgs args)
        {
            Commands.ChatCommands.Add(new Command("bcheck.use", bosscheck, "bosses"));
        }

        public void bosscheck(CommandArgs args)
        {
            var killed = "[c/008000:✔]";
            var alive = "[c/FF0000:✖]";
            StringBuilder sb = new StringBuilder();
            if (args.Parameters.Count == 0 || args.Parameters[0] == "help") {
                sb.Append("Usage: /bosses [pre-hardmode/1] | [hardmode/2] | [event/3]");

            } else if (args.Parameters[0] == "1" || args.Parameters[0] == "pre-hardmode") {
                sb.Append("Eye of Cthulu " + (NPC.downedBoss1 ? killed : alive));
                sb.Append("\nKing Slime " + (NPC.downedSlimeKing ? killed : alive));
                sb.Append("\nEvil Boss " + (NPC.downedBoss2 ? killed : alive));
                sb.Append("\nQueen Bee" + (NPC.downedQueenBee ? killed : alive));
                sb.Append("\nSkeletron " + (NPC.downedBoss3 ? killed : alive));
                sb.Append("\nDeerclops" + (NPC.downedDeerclops ? killed : alive));
                sb.Append("\nWall of Flesh " + (Main.hardMode ? killed : alive));

            } else if (args.Parameters[0] == "2" || args.Parameters[0] == "hardmode") {
                sb.Append("Queen Slime " + (NPC.downedQueenSlime ? killed : alive));
                sb.Append("\nThe Destroyer " + (NPC.downedMechBoss1 ? killed : alive));
                sb.Append("\nThe Twins " + (NPC.downedMechBoss2 ? killed : alive));
                sb.Append("\nSkeletron Prime " + (NPC.downedMechBoss3 ? killed : alive));
                sb.Append("\nPlantera " + (NPC.downedPlantBoss ? killed : alive));
                sb.Append("\nGolem " + (NPC.downedGolemBoss ? killed : alive));
                sb.Append("\nDuke of Fishron " + (NPC.downedFishron ? killed : alive));
                sb.Append("\nEmpress of Light " + (NPC.downedEmpressOfLight ? killed : alive));
                sb.Append("\nLunatic Cultist " + (NPC.downedAncientCultist ? killed : alive));
                sb.Append("\nMoon Lord " + (NPC.downedMoonlord ? killed : alive));

            } else if (args.Parameters[0] == "3" || args.Parameters[0] == "event"){
                sb.Append("\nMourning Wood" + (NPC.downedHalloweenTree ? killed : alive));
                sb.Append("\nPumpking" + (NPC.downedHalloweenKing ? killed : alive));
                sb.Append("\nEverscream" + (NPC.downedChristmasTree ? killed : alive));
                sb.Append("\nSanta-NK1" + (NPC.downedChristmasSantank ? killed : alive));
                sb.Append("\nIce Queen" + (NPC.downedChristmasIceQueen ? killed : alive));
                sb.Append("\nMartian Saurcer" + (NPC.downedMartians ? killed : alive));
                sb.Append("\nSolar Pillar" + (NPC.downedTowerSolar ? killed : alive));
                sb.Append("\nNebula Pillar" + (NPC.downedTowerNebula ? killed : alive));
                sb.Append("\nVortex Pillar" + (NPC.downedTowerVortex ? killed : alive));
                sb.Append("\nStardust Pillar" + (NPC.downedTowerStardust ? killed : alive));
            } else {
                sb.Append("Invalid parameters");
            }
            args.Player.SendInfoMessage(sb.ToString());
        }

        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                ServerApi.Hooks.GameInitialize.Deregister(this, OnInitialize);
            }
            base.Dispose(Disposing);
        }
    }
}