using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200112E RID: 4398
	[Token(Token = "0x200112E")]
	public class LobbyBgSwitchData : CSVBaseData
	{
		// Token: 0x060044BF RID: 17599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x14083A8", Offset = "0x14083A8", VA = "0x7BBBC083A8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C0")]
		[Address(RVA = "0x14083B4", Offset = "0x14083B4", VA = "0x7BBBC083B4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C1")]
		[Address(RVA = "0x1408550", Offset = "0x1408550", VA = "0x7BBBC08550")]
		public LobbyBgSwitchData()
		{
		}

		// Token: 0x040054ED RID: 21741
		[Token(Token = "0x40054ED")]
		[FieldOffset(Offset = "0x10")]
		public string region;

		// Token: 0x040054EE RID: 21742
		[Token(Token = "0x40054EE")]
		[FieldOffset(Offset = "0x18")]
		public uint iID;

		// Token: 0x040054EF RID: 21743
		[Token(Token = "0x40054EF")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID resource;
	}
}
