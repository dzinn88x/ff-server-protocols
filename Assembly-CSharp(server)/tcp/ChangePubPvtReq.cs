using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	[ProtoContract]
	public class ChangePubPvtReq
	{
		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x24A29E8", Offset = "0x24A29E8", VA = "0x7BBCCA29E8")]
		public ChangePubPvtReq()
		{
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0000CA80 File Offset: 0x0000AC80
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C3C", Offset = "0x1155C3C")]
		public bool is_public
		{
			[Token(Token = "0x6001DAA")]
			[Address(RVA = "0x24A29F0", Offset = "0x24A29F0", VA = "0x7BBCCA29F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136264", Offset = "0x1136264")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DAB")]
			[Address(RVA = "0x24A29F8", Offset = "0x24A29F8", VA = "0x7BBCCA29F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136274", Offset = "0x1136274")]
			set
			{
			}
		}

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11026F4", Offset = "0x11026F4")]
		private bool <is_public>k__BackingField;
	}
}
