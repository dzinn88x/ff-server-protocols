using System;
using Il2CppDummyDll;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
[Serializable]
public class EnvWeatherSound
{
	// Token: 0x060001AC RID: 428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x23FA750", Offset = "0x23FA750", VA = "0x7BBCBFA750")]
	public EnvWeatherSound()
	{
	}

	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x10")]
	public bool hasSound;

	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x14")]
	public float volume;

	// Token: 0x040001C6 RID: 454
	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x18")]
	public string loopOutside;

	// Token: 0x040001C7 RID: 455
	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x20")]
	public string loopInRoom;

	// Token: 0x040001C8 RID: 456
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x28")]
	public string[] footsteps;
}
