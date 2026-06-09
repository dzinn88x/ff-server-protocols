using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF4 RID: 2804
	[Token(Token = "0x2000AF4")]
	[ProtoContract]
	public class NewRegisterProcedureDesc
	{
		// Token: 0x060027FC RID: 10236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x249EC08", Offset = "0x249EC08", VA = "0x7BBCC9EC08")]
		public NewRegisterProcedureDesc()
		{
		}

		// Token: 0x040034D4 RID: 13524
		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129554", Offset = "0x1129554")]
		public bool is_new_procedure_open;

		// Token: 0x040034D5 RID: 13525
		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129568", Offset = "0x1129568")]
		public float new_probability;

		// Token: 0x040034D6 RID: 13526
		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112957C", Offset = "0x112957C")]
		public bool is_squad_first_game_open;

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129590", Offset = "0x1129590")]
		public float squad_probability;
	}
}
