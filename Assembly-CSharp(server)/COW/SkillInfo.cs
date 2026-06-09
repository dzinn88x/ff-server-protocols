using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200170F RID: 5903
	[Token(Token = "0x200170F")]
	public class SkillInfo
	{
		// Token: 0x06006E03 RID: 28163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E03")]
		[Address(RVA = "0x1B39248", Offset = "0x1B39248", VA = "0x7BBC339248")]
		public SkillInfo()
		{
		}

		// Token: 0x040088D1 RID: 35025
		[Token(Token = "0x40088D1")]
		[FieldOffset(Offset = "0x10")]
		public uint skillID;

		// Token: 0x040088D2 RID: 35026
		[Token(Token = "0x40088D2")]
		[FieldOffset(Offset = "0x14")]
		public bool isEquiped;

		// Token: 0x040088D3 RID: 35027
		[Token(Token = "0x40088D3")]
		[FieldOffset(Offset = "0x18")]
		public int slotID;

		// Token: 0x040088D4 RID: 35028
		[Token(Token = "0x40088D4")]
		[FieldOffset(Offset = "0x1C")]
		public int skillLevel;

		// Token: 0x040088D5 RID: 35029
		[Token(Token = "0x40088D5")]
		[FieldOffset(Offset = "0x20")]
		public int skillColor;
	}
}
