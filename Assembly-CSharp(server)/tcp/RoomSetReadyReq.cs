using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	[ProtoContract]
	public class RoomSetReadyReq
	{
		// Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x24A6D90", Offset = "0x24A6D90", VA = "0x7BBCCA6D90")]
		public RoomSetReadyReq()
		{
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000555")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158540", Offset = "0x1158540")]
		public bool ready
		{
			[Token(Token = "0x60020CA")]
			[Address(RVA = "0x24A6D98", Offset = "0x24A6D98", VA = "0x7BBCCA6D98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E84", Offset = "0x1138E84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020CB")]
			[Address(RVA = "0x24A6DA0", Offset = "0x24A6DA0", VA = "0x7BBCCA6DA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E94", Offset = "0x1138E94")]
			set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0000E208 File Offset: 0x0000C408
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000556")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158554", Offset = "0x1158554")]
		public bool set_group
		{
			[Token(Token = "0x60020CC")]
			[Address(RVA = "0x24A6DAC", Offset = "0x24A6DAC", VA = "0x7BBCCA6DAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138EA4", Offset = "0x1138EA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020CD")]
			[Address(RVA = "0x24A6DB4", Offset = "0x24A6DB4", VA = "0x7BBCCA6DB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138EB4", Offset = "0x1138EB4")]
			set
			{
			}
		}

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D04", Offset = "0x1103D04")]
		private bool <ready>k__BackingField;

		// Token: 0x04001870 RID: 6256
		[Token(Token = "0x4001870")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D14", Offset = "0x1103D14")]
		private bool <set_group>k__BackingField;
	}
}
