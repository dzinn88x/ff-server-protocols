using System;
using Il2CppDummyDll;
using message;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
[Serializable]
public class AISpawnInfo
{
	// Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1F82E60", Offset = "0x1F82E60", VA = "0x7BBC782E60")]
	public AISpawnInfo()
	{
	}

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x10")]
	public LKBHVE} AIType;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF914", Offset = "0x10FF914")]
	public int AISkinID;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x18")]
	public int SpawnNum;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x1C")]
	public float HealthScaleOnBase;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x20")]
	public float SpeedScale;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x24")]
	public bool isBoss;
}
