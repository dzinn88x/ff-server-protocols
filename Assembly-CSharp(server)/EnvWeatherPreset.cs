using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000082")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x10E1BF0", Offset = "0x10E1BF0")]
public class EnvWeatherPreset : ScriptableObject
{
	// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x23FA748", Offset = "0x23FA748", VA = "0x7BBCBFA748")]
	public EnvWeatherPreset()
	{
	}

	// Token: 0x040001C9 RID: 457
	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x18")]
	public EnvSkybox skybox;

	// Token: 0x040001CA RID: 458
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x20")]
	public EnvGlobalSetting setting;

	// Token: 0x040001CB RID: 459
	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x28")]
	public EnvWeatherEffect effect;

	// Token: 0x040001CC RID: 460
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x30")]
	public EnvWeatherSound sound;
}
