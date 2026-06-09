using System;
using Il2CppDummyDll;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000080")]
[Serializable]
public class EnvWeatherEffect
{
	// Token: 0x060001AB RID: 427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x23FA740", Offset = "0x23FA740", VA = "0x7BBCBFA740")]
	public EnvWeatherEffect()
	{
	}

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x10")]
	public string effectResourceID;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x18")]
	public float effectUp;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x1C")]
	public float effectDistance;

	// Token: 0x040001C3 RID: 451
	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x20")]
	public bool stopWhenUnderShelter;
}
