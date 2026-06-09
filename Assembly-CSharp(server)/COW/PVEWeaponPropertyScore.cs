using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001176 RID: 4470
	[Token(Token = "0x2001176")]
	public class PVEWeaponPropertyScore : CSVBaseData, IGetId
	{
		// Token: 0x06004595 RID: 17813 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x203D0B0", Offset = "0x203D0B0", VA = "0x7BBC83D0B0", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x203D0B8", Offset = "0x203D0B8", VA = "0x7BBC83D0B8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004597")]
		[Address(RVA = "0x203D0C4", Offset = "0x203D0C4", VA = "0x7BBC83D0C4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x203D5D4", Offset = "0x203D5D4", VA = "0x7BBC83D5D4")]
		public PVEWeaponPropertyScore()
		{
		}

		// Token: 0x0400567F RID: 22143
		[Token(Token = "0x400567F")]
		[FieldOffset(Offset = "0x10")]
		public int[] Property;

		// Token: 0x04005680 RID: 22144
		[Token(Token = "0x4005680")]
		[FieldOffset(Offset = "0x18")]
		public int[] PropertyBlocks;

		// Token: 0x04005681 RID: 22145
		[Token(Token = "0x4005681")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04005682 RID: 22146
		[Token(Token = "0x4005682")]
		[FieldOffset(Offset = "0x28")]
		public uint SkinID;

		// Token: 0x04005683 RID: 22147
		[Token(Token = "0x4005683")]
		[FieldOffset(Offset = "0x2C")]
		public uint WeaponLevel;
	}
}
