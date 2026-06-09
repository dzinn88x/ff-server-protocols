using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001159 RID: 4441
	[Token(Token = "0x2001159")]
	public class PetData : CSVBaseData
	{
		// Token: 0x06004542 RID: 17730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x2050AF8", Offset = "0x2050AF8", VA = "0x7BBC850AF8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x2050B04", Offset = "0x2050B04", VA = "0x7BBC850B04", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x2051024", Offset = "0x2051024", VA = "0x7BBC851024")]
		public PetData()
		{
		}

		// Token: 0x040055FB RID: 22011
		[Token(Token = "0x40055FB")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040055FC RID: 22012
		[Token(Token = "0x40055FC")]
		[FieldOffset(Offset = "0x14")]
		public int Type;

		// Token: 0x040055FD RID: 22013
		[Token(Token = "0x40055FD")]
		[FieldOffset(Offset = "0x18")]
		public int RareType;

		// Token: 0x040055FE RID: 22014
		[Token(Token = "0x40055FE")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID IngameModel;

		// Token: 0x040055FF RID: 22015
		[Token(Token = "0x40055FF")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID IngameModel3P;

		// Token: 0x04005600 RID: 22016
		[Token(Token = "0x4005600")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID PreviewModel;

		// Token: 0x04005601 RID: 22017
		[Token(Token = "0x4005601")]
		[FieldOffset(Offset = "0x28")]
		public string DefaultName;

		// Token: 0x04005602 RID: 22018
		[Token(Token = "0x4005602")]
		[FieldOffset(Offset = "0x30")]
		public string IdleAction;

		// Token: 0x04005603 RID: 22019
		[Token(Token = "0x4005603")]
		[FieldOffset(Offset = "0x38")]
		public string FeedAction;

		// Token: 0x04005604 RID: 22020
		[Token(Token = "0x4005604")]
		[FieldOffset(Offset = "0x40")]
		public string LobbyAction;

		// Token: 0x04005605 RID: 22021
		[Token(Token = "0x4005605")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID FeedSfx;

		// Token: 0x04005606 RID: 22022
		[Token(Token = "0x4005606")]
		[FieldOffset(Offset = "0x4C")]
		public ResourceID LobbySfx;

		// Token: 0x04005607 RID: 22023
		[Token(Token = "0x4005607")]
		[FieldOffset(Offset = "0x50")]
		public ResourceID LobbyVfx;

		// Token: 0x04005608 RID: 22024
		[Token(Token = "0x4005608")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID MultiFeedVFX;

		// Token: 0x04005609 RID: 22025
		[Token(Token = "0x4005609")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID FeedVFX;

		// Token: 0x0400560A RID: 22026
		[Token(Token = "0x400560A")]
		[FieldOffset(Offset = "0x5C")]
		public ResourceID ListImage;

		// Token: 0x0400560B RID: 22027
		[Token(Token = "0x400560B")]
		[FieldOffset(Offset = "0x60")]
		public float NameHeight;

		// Token: 0x0400560C RID: 22028
		[Token(Token = "0x400560C")]
		[FieldOffset(Offset = "0x64")]
		public uint MaxLevel;

		// Token: 0x0400560D RID: 22029
		[Token(Token = "0x400560D")]
		[FieldOffset(Offset = "0x68")]
		public float WanderAnimBaseSpeed;

		// Token: 0x0400560E RID: 22030
		[Token(Token = "0x400560E")]
		[FieldOffset(Offset = "0x6C")]
		public float WalkAnimBaseSpeed;

		// Token: 0x0400560F RID: 22031
		[Token(Token = "0x400560F")]
		[FieldOffset(Offset = "0x70")]
		public float RunAnimBaseSpeed;

		// Token: 0x04005610 RID: 22032
		[Token(Token = "0x4005610")]
		[FieldOffset(Offset = "0x74")]
		public float LobbyScale;

		// Token: 0x04005611 RID: 22033
		[Token(Token = "0x4005611")]
		[FieldOffset(Offset = "0x78")]
		public string HDLobbyWalkAction;

		// Token: 0x04005612 RID: 22034
		[Token(Token = "0x4005612")]
		[FieldOffset(Offset = "0x80")]
		public ResourceID InGameBasicActionRes;

		// Token: 0x04005613 RID: 22035
		[Token(Token = "0x4005613")]
		[FieldOffset(Offset = "0x84")]
		public ResourceID LobbyBasicActionRes;

		// Token: 0x04005614 RID: 22036
		[Token(Token = "0x4005614")]
		[FieldOffset(Offset = "0x88")]
		public ResourceID ExtraActionRes;
	}
}
