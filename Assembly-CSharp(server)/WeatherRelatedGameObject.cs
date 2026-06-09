using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000086 RID: 134
[Token(Token = "0x2000086")]
[ExecuteInEditMode]
public class WeatherRelatedGameObject : MonoBehaviour
{
	// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x218DF10", Offset = "0x218DF10", VA = "0x7BBC98DF10")]
	private void Start()
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x218E184", Offset = "0x218E184", VA = "0x7BBC98E184")]
	private void OnDestroy()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x218E030", Offset = "0x218E030", VA = "0x7BBC98E030")]
	private void OnWeatherChanged(string weatherName)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x218E274", Offset = "0x218E274", VA = "0x7BBC98E274")]
	public WeatherRelatedGameObject()
	{
	}

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x18")]
	public string[] WeatherNames;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x20")]
	public bool[] ShowOrNot;
}
