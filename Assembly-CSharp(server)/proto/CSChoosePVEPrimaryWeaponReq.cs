using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	[ProtoContract]
	public class CSChoosePVEPrimaryWeaponReq
	{
		// Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x21B0680", Offset = "0x21B0680", VA = "0x7BBC9B0680")]
		public CSChoosePVEPrimaryWeaponReq()
		{
		}

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC14", Offset = "0x110DC14")]
		public uint primary_weapon_id;

		// Token: 0x04002554 RID: 9556
		[Token(Token = "0x4002554")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC28", Offset = "0x110DC28")]
		public ulong group_id;
	}
}
