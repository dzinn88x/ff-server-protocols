using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F0 RID: 2288
	[Token(Token = "0x20008F0")]
	[ProtoContract]
	public class ManualWeaponReward
	{
		// Token: 0x060025FE RID: 9726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x21BC478", Offset = "0x21BC478", VA = "0x7BBC9BC478")]
		public ManualWeaponReward()
		{
		}

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11174E4", Offset = "0x11174E4")]
		public uint quantity_period;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11174F8", Offset = "0x11174F8")]
		public EManual.State state;
	}
}
