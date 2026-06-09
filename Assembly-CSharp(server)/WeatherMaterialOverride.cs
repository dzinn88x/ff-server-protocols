using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
[ExecuteInEditMode]
public class WeatherMaterialOverride : MonoBehaviour
{
	// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x218D9C4", Offset = "0x218D9C4", VA = "0x7BBC98D9C4")]
	private void Awake()
	{
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x218DA1C", Offset = "0x218DA1C", VA = "0x7BBC98DA1C")]
	private void OnEnable()
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x218DB0C", Offset = "0x218DB0C", VA = "0x7BBC98DB0C")]
	private void OnDisable()
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x218DBFC", Offset = "0x218DBFC", VA = "0x7BBC98DBFC")]
	private void OnWeatherChanged(string weatherName)
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x218DD78", Offset = "0x218DD78", VA = "0x7BBC98DD78")]
	public void ReadProperties()
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x218DC38", Offset = "0x218DC38", VA = "0x7BBC98DC38")]
	public void ApplyProperties()
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x218DEB8", Offset = "0x218DEB8", VA = "0x7BBC98DEB8")]
	public WeatherMaterialOverride()
	{
	}

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x18")]
	private Renderer renderer;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x20")]
	public string weatherName;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x28")]
	public Color[] colors;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x30")]
	public string[] colorNames;
}
